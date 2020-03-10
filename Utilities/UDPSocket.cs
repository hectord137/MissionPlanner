using MissionPlanner.GCSViews.ConfigurationView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Utilities
{
    public class UDPSocket
    {

        private static Socket socket = null;
        public bool runing = false;
        public Thread thread;
        private JsonConfig _Json;
        private IPEndPoint pointRx = null;
        private IPEndPoint pointTx = null;

        public UDPSocket() 
        {
        _Json = new JsonConfig();
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
         Getconfiginitial();
        }

        public void Run() {
            thread = new Thread(Listen);
            thread.Start();
        }
        public void Getconfiginitial()
        {
            var RemoteSystem = _Json.ReadRemoteSystem();
            foreach (var items in RemoteSystem)
            {
                pointRx = new IPEndPoint(IPAddress.Parse(items.Ip), items.PortRx);
                pointTx = new IPEndPoint(IPAddress.Parse(items.Ip), items.PortTx);
            }
         
        }

        public void EnviaUDP(string Mensaje)
        {
            byte[] datosEnBytes = Encoding.Default.GetBytes(Mensaje);
            socket.SendTo(datosEnBytes, pointTx);
        }
      

        public  void Listen()
        {
            try
            {
                socket.Bind(pointRx);
            }
            catch {
            }
            byte[] buffer = new byte[1024];
            EndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 0);
            runing = true;
            while (runing)
            {
                if (socket.Available == 0)
                {
                    Thread.Sleep(200);
                    continue;
                }
                try
                {
                    int Byteread = socket.ReceiveFrom(buffer, ref RemoteIP);
                    string DataReceiving = Encoding.Default.GetString(buffer, 0, Byteread);
               
                List<string> result = Regex.Split(DataReceiving, "/r/n").Select(s => s.Replace("#", "")).ToList();
                if (result[0].Substring(0, 5) == "range")
                {
                    DecodeEchoSounder(DataReceiving);
                    Control.CheckForIllegalCrossThreadCalls = false;
                    ConfigPlanner.instance.SetValuesEchosounder();
                    CustomColor.instance.Normalcolor(ConfigPlanner.instance.myButton2);
                    Control.CheckForIllegalCrossThreadCalls = true;

                }
                else if(result[0].Substring(0, 9) == "frequency") {
                    DecodeGps(DataReceiving);
                    Control.CheckForIllegalCrossThreadCalls = false;
                    ConfigPlanner.instance.SetValuesGPS();
                    CustomColor.instance.Normalcolor(ConfigPlanner.instance.BtnReadGps);
                    Control.CheckForIllegalCrossThreadCalls = true;

                }
                else if (result[0].Substring(0, 11) == "temperature")
                {
                        DecodeSensores(DataReceiving);
                }

                    runing = true;
                }
                catch {  }
            }
        }
      
         
    public  void DecodeEchoSounder(string Mensaje) {
            List<string> result = Regex.Split(Mensaje, @"/r/n").Select(s => s.Replace("#", "")).ToList();
            try
            {
                int range = Convert.ToInt32(result[0].Substring(5));
                double interval = Convert.ToDouble(result[1].Substring(8));
                int threshold = Convert.ToInt32(result[2].Substring(9));
                int offset = Convert.ToInt32(result[3].Substring(6));
                int deadzone = Convert.ToInt32(result[4].Substring(8));
                int sound = Convert.ToInt32(result[5].Substring(5));
                double gain = Convert.ToDouble(result[6].Substring(4));
            if (range != 0 || interval != 0.0 || threshold != 0 || offset != 0 || deadzone != 0 || sound != 0 || gain != 0.0)
            {
                _Json.CreateConfigFileEchoSounder(range, interval, threshold, offset, deadzone, sound, gain);
            }
            else {
                CustomMessageBox.Show("Incorrect format", "Error");
            }
            }
            catch
            {
                CustomMessageBox.Show("Invalid Data");
            }

        }
        public void DecodeGps(string Mensaje)
        {
            List<string> result = Regex.Split(Mensaje, @"/r/n").Select(s => s.Replace("#", "")).ToList();

            int Frequency = Convert.ToInt32(result[0].Substring(9));
            string Protocol = result[1].Substring(8);
           

            if (Frequency != 0 || Protocol != null)
            {
                _Json.CreateGpsConfig(Frequency,  Protocol);
            }
            else
            {
                CustomMessageBox.Show("Incorrect format", "Error");
            }

        }

        public void DecodeSensores(string Mensaje)
        {
            List<string> result = Regex.Split(Mensaje, @"/r/n").Select(s => s.Replace("#", "")).ToList();
            Control.CheckForIllegalCrossThreadCalls = false;
            GCSViews.ConfigurationView.ConfigPlanner.instance.lblTemp.Text = Convert.ToInt32(result[0].Substring(11)).ToString() + "°";
            GCSViews.ConfigurationView.ConfigPlanner.instance.lblHum.Text = Convert.ToInt64(result[1].Substring(8)).ToString() + "%";
            Control.CheckForIllegalCrossThreadCalls = true;
        }





        public string CreateMessaje(List<JsonEchosounder> data)
        {
            //gpsConfig
            string StringToSend = null;
            foreach (var Messaje in data)
            {
                StringToSend = "#range " + Messaje.Range + "/r/n" + "#interval " + Messaje.Interval +
                   "/r/n" + "#threshold " + Messaje.Threshold + "/r/n" + "#offset " + Messaje.Offset + "/r/n" + "#deadzone "
                   + Messaje.Deadzone + "/r/n" + "#sound " + Messaje.Sound + "/r/n" + "#gain " + Messaje.Gain + "/r/n";

            }
            //save data in local Json
            DecodeEchoSounder(StringToSend);
            return StringToSend;
        }

        public string CreateMessageGps(List<GPSConfig> data)
        {
            string StringToSend = null;

            foreach (var Messaje in data)
            {
                StringToSend = "#frequency " + Messaje.Frequency + "/r/n" + "#protocol " + Messaje.Protocol + "/r/n";
            }
            //save data in local Json
            DecodeGps(StringToSend);
            return StringToSend;
        }

        public string CreateMessageAutoStop(List<ConfigToSendEchosounder> data)
        {
            string StringToSend = null;

            foreach (var Messaje in data)
            {
                StringToSend = "#autostop " + Messaje.Autostop + "/r/n" + "#status " + Messaje.Enabled + "/r/n";
            }
            //save data in local Json
            DecodeGps(StringToSend);
            return StringToSend;
        }



    }

}
    

