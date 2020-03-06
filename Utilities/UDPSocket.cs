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
        //servidor de escucha UDP
        public  void Listen()
        {
            try
            {
                socket.Bind(pointRx);
            }
            catch {
            }
            CustomMessageBox.Show("Reading information", "Wait");
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
                if (result[0].Substring(0, 5) == "Range")
                {
                    DecodeEchoSounder(DataReceiving);
                    Control.CheckForIllegalCrossThreadCalls = false;
                    ConfigPlanner.instance.SetValuesEchosounder();
                    CustomColor.instance.Normalcolor(ConfigPlanner.instance.myButton2);
                    Control.CheckForIllegalCrossThreadCalls = true;

                }
                else if(result[0].Substring(0, 9) == "Frequency") {
                    DecodeGps(DataReceiving);
                    Control.CheckForIllegalCrossThreadCalls = false;
                    ConfigPlanner.instance.SetValuesGPS();
                    CustomColor.instance.Normalcolor(ConfigPlanner.instance.BtnReadGps);
                    Control.CheckForIllegalCrossThreadCalls = true;

                }

                runing = false;
                CustomColor.instance.Normalcolor(ConfigPlanner.instance.myButton2);
                thread.Abort();
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


   
        public string CreateMessaje(List<JsonEchosounder> data)
        {
            //gpsConfig
            string StringToSend = null;
            foreach (var Messaje in data)
            {
                StringToSend = "#Range " + Messaje.Range + "/r/n" + "#Interval " + Messaje.Interval +
                   "/r/n" + "#Threshold " + Messaje.Threshold + "/r/n" + "#Offset " + Messaje.Offset + "/r/n" + "#Deadzone "
                   + Messaje.Deadzone + "/r/n" + "#Sound " + Messaje.Sound + "/r/n" + "#Gain " + Messaje.Gain + "/r/n";

            }
            //save data in local Json
            DecodeEchoSounder(StringToSend);
            return StringToSend;
        }

        public string CreateMessajeGps(List<GPSConfig> data)
        {
            string StringToSend = null;

            foreach (var Messaje in data)
            {
                StringToSend = "#Frequency " + Messaje.Frequency + "/r/n" + "#Protocol " + Messaje.Protocol + "/r/n";
            }
            //save data in local Json
            DecodeGps(StringToSend);
            return StringToSend;
        }



    }
}
    

