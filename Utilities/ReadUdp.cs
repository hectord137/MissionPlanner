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
    class ReadUdp
    {

        private static Socket socket = null;
        private static bool corriendo = false;
        private static IPEndPoint puntoLocal = null;

    

        public void Main() {
            int puertoEscucha = 0;
            IPAddress ipEscucha = IPAddress.Any;

            JsonConfig jsonConfig = new JsonConfig();
            List<JsonRemoteSystem> port = jsonConfig.ReadRemoteSystem();
            foreach (var data in port)
            {
                puertoEscucha = data.PortRx;
                ipEscucha = IPAddress.Parse(data.Ip);
            }

            puntoLocal = new IPEndPoint(ipEscucha, puertoEscucha);
            new Thread(Start).Start();
            corriendo = false;
        }
        private static void Start()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(puntoLocal);
            Console.WriteLine("escuchando...");
            byte[] buffer = new byte[1024];
            EndPoint ipRemota = new IPEndPoint(IPAddress.Any, 0);
            corriendo = true;
            while (corriendo)
            {
                List<DataRemote> datos = new List<DataRemote>();
                List<string> result = new List<string>();
                try
                {
                    if (socket.Available == 0)
                    {
                        Thread.Sleep(200);
                        continue;
                    }
                    int contadorLeido = socket.ReceiveFrom(buffer, ref ipRemota);
                    string datosRecibidos = Encoding.Default.GetString(buffer, 0, contadorLeido);

                     result = Regex.Split(datosRecibidos, @"/r/n").Select(s => s.Replace("#", "")).ToList();
                }
                catch { CustomMessageBox.Show("Invalid communication port", "Error"); }
                try
                {
                    datos.Add(new DataRemote
                    {
                        Temperature = Convert.ToInt32(result[0].Substring(11)),
                        Humidity = Convert.ToInt64(result[1].Substring(8))
                    });

                    Control.CheckForIllegalCrossThreadCalls = false;
                    GCSViews.ConfigurationView.ConfigPlanner.instance.lblTemp.Text = Convert.ToInt32(result[0].Substring(11)).ToString() + "°";
                    GCSViews.ConfigurationView.ConfigPlanner.instance.lblHum.Text = Convert.ToInt64(result[1].Substring(8)).ToString() + "%";
                    Control.CheckForIllegalCrossThreadCalls = true;
                }
                catch { CustomMessageBox.Show("Data format, Error"); }
            }

        }
    }

    class DataRemote {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
    }
}
