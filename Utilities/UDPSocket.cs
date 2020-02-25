using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MissionPlanner.Utilities
{
        public class UDPSocket
        {

        private static Socket socket = null;
        public static bool runing = false;
        private static IPEndPoint puntoLocal = null;

        public  UDPSocket(IPEndPoint point)
        {
            puntoLocal = point;
            new Thread(Listen).Start();
        }

        //servidor de escucha UDP
        public static void Listen()
        {
            //instanciamos el socket 
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                socket.Bind(puntoLocal);
            }
            catch {
                CustomMessageBox.Show("Invalid port number ", "Error");
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
                Console.WriteLine("Recibí: " + DataReceiving);
                DecodeMessage(DataReceiving);
            }
        }

        public static string DecodeMessage(string Mensaje) {
           var xxx =  Mensaje.Substring(Mensaje.IndexOf("#")+1, Mensaje.IndexOf("/r/n"));
            return xxx;
        }
      
        public static void EnviaUDP(string Mensaje, string Ipdestino, int Port)
        {
            String datosAEnviar = "#" + Mensaje + "/r/n";
            string ipDestino = Ipdestino;
            int puertoDestino = Port;
            byte[] datosEnBytes = Encoding.Default.GetBytes(datosAEnviar);
            EndPoint ipPuertoRemoto = new IPEndPoint(IPAddress.Parse(ipDestino), puertoDestino);
            socket.SendTo(datosEnBytes, ipPuertoRemoto);
        }

    
    }
    }
    

