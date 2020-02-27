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

namespace MissionPlanner.Utilities
{
    public class UDPSocket
    {
      
        private static Socket socket = null;
        public  bool runing = false;
        public IPEndPoint puntoLocal = null;
        public Thread thread;
        public UDPSocket(){

        socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        public void Run() {
            thread = new Thread(Listen);
            thread.Start();

        }

        //servidor de escucha UDP
        public  void Listen()
        {
           

            //instanciamos el socket 
            try
            {
                socket.Bind(puntoLocal);
            }
            catch {
            }
            CustomMessageBox.Show("reading information", "Wait");
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

                int Byteread = socket.ReceiveFrom(buffer, ref RemoteIP);
                string DataReceiving = Encoding.Default.GetString(buffer, 0, Byteread);
                Console.WriteLine(DataReceiving);
                
                List<string> result = Regex.Split(DataReceiving, @"/r/n").Select(s => s.Replace("#", "")).ToList();
                if (result[0].Substring(0, 5) == "Range")
                {
                    DecodeEchoSounder(DataReceiving);
                    
                }
                else if(result[0].Substring(0, 9) == "Frecuency") {
                    DecodeGps(DataReceiving);
                }

                runing = false;
                CustomColor.instance.Normalcolor(ConfigPlanner.instance.myButton2);
                thread.Abort();

            }
        }

        public  void DecodeEchoSounder(string Mensaje) {
            List<string> result = Regex.Split(Mensaje, @"/r/n").Select(s => s.Replace("#", "")).ToList();

            int range       = Convert.ToInt32(result[0].Substring(5));
            double interval    = Convert.ToDouble(result[1].Substring(8));
            int threshold   = Convert.ToInt32(result[2].Substring(9));
            int offset      = Convert.ToInt32(result[3].Substring(6));
            int deadzone    = Convert.ToInt32(result[4].Substring(8));
            int sound       = Convert.ToInt32(result[5].Substring(5));
            double gain        = Convert.ToDouble(result[6].Substring(4));

            if (range != 0 || interval != 0.0 || threshold != 0 || offset != 0 || deadzone != 0 || sound != 0 || gain != 0.0)
            {
                var Json = new JsonConfig();
                Json.CreateConfigFileEchoSounder(range, interval, threshold, offset, deadzone, sound, gain);
            }
            else {
                CustomMessageBox.Show("Incorrect format", "Error");
            }
            
        }
        public void DecodeGps(string Mensaje)
        {
            List<string> result = Regex.Split(Mensaje, @"/r/n").Select(s => s.Replace("#", "")).ToList();

            int Frecuency = Convert.ToInt32(result[0].Substring(9));
            string Protocol = result[1].Substring(8);
           

            if (Frecuency != 0 || Protocol != null)
            {
                var Json = new JsonConfig();
                Json.CreateGpsConfig(Frecuency,  Protocol);
            }
            else
            {
                CustomMessageBox.Show("Incorrect format", "Error");
            }

        }


        public  void EnviaUDP(string Mensaje, string Ipdestino, int Port)
        {
            byte[] datosEnBytes = Encoding.Default.GetBytes(Mensaje);
            EndPoint ipPuertoRemoto = new IPEndPoint(IPAddress.Parse(Ipdestino), Port);
            socket.SendTo(datosEnBytes, ipPuertoRemoto);
        }

    
    }
    }
    

