using IronPython.Runtime.Operations;
using ManagedNativeWifi.Simple;
using SimpleWifi;
using SimpleWifi.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Threading;
using SimpleWifi.Win32.Interop;
using MissionPlanner.GCSViews;
using System.Net;
using System.Web;
using System.Net.NetworkInformation;
using System.IO;

namespace MissionPlanner.Utilities
{
    class ConexWifi
    {

        private string interfaz;
        private string password;
        public string Name_wifi;
        private string mac;

        Wifi objwifi = new Wifi();

        //unidad de disco duro
        string C = System.Environment.SystemDirectory.Substring(0, 1);
        //Path archivo de configuración
        private string PathDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Mission Planner\";

        public void main() {

            if (File.Exists(PathDoc + @"config.txt"))
            {
                ReadParameters();
                if (interfaz == " " || Name_wifi == " " || password == " " || mac == " ")
                {
                    CustomMessageBox.Show("Configurar Parametros en pesataña de configuración");
                }
                else
                {
                    if (GetInterfaces())
                    {
                        conectwifi();
                    }
                }
            }
            else {
                configfile();
            }




        }




        private void configfile() {

            if (!File.Exists(PathDoc + @"config.txt"))
            {
                DirectoryInfo di = Directory.CreateDirectory(PathDoc);
                TxtParameters();
                CustomMessageBox.Show("Configurar Parametros pesataña de configuración");
            }

        }

        public void TxtParameters()
        {
            string[] lines = { @"# == comentarios", "#Adaptador de red", " ", "#Red Wifi", " ", "#Contraseña", " ", "#Mac xx-xx-xx-xx-xx-xx ", " " };
            System.IO.File.WriteAllLines(PathDoc + @"config.txt", lines);
        }


        List<string> parameters = new List<string>();
        public void ReadParameters()
        {
            string[] lines = System.IO.File.ReadAllLines(PathDoc + @"config.txt");
            foreach (string line in lines)
            {
                if (line.Substring(0, 1) != "#")
                {
                    parameters.Add(line);
                }
            }

            this.interfaz = this.parameters[0];
            this.Name_wifi = this.parameters[1];
            this.password = this.parameters[2];
            this.mac = this.parameters[3];

        }



        private string ExecuteComand(String strCommandParameters) {

            string strCommand = @"cmd.exe";
            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = strCommand;

            //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = "/c" + strCommandParameters;

            pProcess.StartInfo.UseShellExecute = false;

            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;


            //Start the process
            pProcess.Start();

            //Get program output
            string strOutput = pProcess.StandardOutput.ReadToEnd();

            return strOutput;

        }


        public bool GetInterfaces()
        {
            WlanClient client = new WlanClient();
            List<string> Listinterfaces = new List<string>();
            foreach (WlanInterface wlanIface in client.Interfaces)
            {
                Listinterfaces.Add(wlanIface.InterfaceName);
            }

            bool Interface_ex = Listinterfaces.Any(x => x == interfaz);

            if (Interface_ex)
            {
                return true;
            }
            else
            {
                CustomMessageBox.Show("Interfaz " + interfaz + " no conectada", "Error");
                return false;
            }


        }




        private void ChangePriority()
        {
            string command = "netsh wlan set profileorder name=" + Name_wifi + " interface=" + interfaz + " priority=1";
            ExecuteComand(command);
        }

        private Tuple<bool, List<AccessPoint>> FindWifi()
        {
            List<string> name_Wifi = new List<string>();
            List<AccessPoint> aps = objwifi.GetAccessPoints();
            foreach (AccessPoint ap in aps)
            {
                name_Wifi.Add(ap.Name);
            }
            return Tuple.Create(name_Wifi.Any(x => x == Name_wifi), aps);
        }

        public bool GetMac()
        {
            WlanClient client = new WlanClient();
            List<string> Listinterfacesmac = new List<string>();
            foreach (WlanInterface wlanIface in client.Interfaces)
            {
                SimpleWifi.Win32.Interop.WlanBssEntry[] wlanBssEntries = wlanIface.GetNetworkBssList();
                foreach (WlanBssEntry wlanBssEntry in wlanBssEntries)
                {
                    byte[] macAddr = wlanBssEntry.dot11Bssid;
                    var macAddrLen = (uint)macAddr.Length;
                    var str = new string[(int)macAddrLen];
                    for (int i = 0; i < macAddrLen; i++)
                    {
                        str[i] = macAddr[i].ToString("x2");
                    }
                    Listinterfacesmac.Add(string.Join("-", str));
                }
            }
            List<string> test = Listinterfacesmac;
            bool ok_mac = Listinterfacesmac.Any(x => x == mac);
            return ok_mac;

        }

        public bool status_conection;
        private void conectwifi() {
            if (!FindWifi().Item1) {
                CustomMessageBox.Show("Device not found", "Error");
                status_conection = false;
            }
            else if (!GetMac())
            {
                CustomMessageBox.Show("Incorrect Mac Address");
                status_conection = false;
            }
            else if (FindWifi().Item1)

            {
                CustomMessageBox.Show("Trying to connect..");
                // for each access point from list
                foreach (AccessPoint ap in FindWifi().Item2.Where(i => i.Name == Name_wifi))
                {
                    if (ap.IsConnected)
                    {
                        objwifi.Disconnect();
                    }
                    AuthRequest authRequest = new AuthRequest(ap);
                    authRequest.Password = password;
                    ap.Name.startswith(Name_wifi);
                    if (ap.Connect(authRequest))
                    {
                        CustomMessageBox.Show("Connected", "Success");
                        status_conection = true;

                    }
                }
                ChangePriority();

            }

        }

        public void disconect() {
        objwifi.Disconnect();          
        }

        public void Tick_Elapsed(object sender, ElapsedEventArgs e)
        {

            Conecctionstatus();
            signal();
        }


        public void Conecctionstatus()
        {
            FlightData fd = new FlightData();
            if (fd.manual_status)
            {
                try
                {
                    if (GetDefaultGateway() == null)
                    {
                        conectwifi();
                        status_conection = false;
                        FlightData.instance.LBLSignal.Text = "signal lost";

                    }
                    else
                    {
                        Ping myPing = new Ping();
                        var host = GetDefaultGateway();
                        byte[] buffer = new byte[32];
                        int timeout = 1000;
                        PingOptions pingOptions = new PingOptions();
                        PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                        if (reply.Status == IPStatus.Success)
                        {
                            status_conection = true;
                        }
                        else
                        {
                            conectwifi();
                            status_conection = false;
                            FlightData.instance.LBLSignal.Text = "signal lost";
                        }
                    }
                }
                catch (Exception ex)
                {
                    status_conection = false;
                    conectwifi();
                }
            }
        }
   

        public static IPAddress GetDefaultGateway()
        {
            IPAddress result = null;
            var cards = NetworkInterface.GetAllNetworkInterfaces().ToList();
            if (cards.Any())
            {
                foreach (var card in cards)
                {
                    var props = card.GetIPProperties();
                    if (props == null)
                        continue;

                    var gateways = props.GatewayAddresses;
                    if (!gateways.Any())
                        continue;

                    var gateway =
                        gateways.FirstOrDefault(g => g.Address.AddressFamily.ToString() == "InterNetwork");
                    if (gateway == null)
                        continue;

                    result = gateway.Address;
                    break;
                };
            }

            return result;
        }

        public string signallbl;
        public void signal()
        {
            string signalvalue = "";
            List<AccessPoint> pa = objwifi.GetAccessPoints();
            foreach (AccessPoint ap in pa.Where(i => i.Name == Name_wifi))
            {
                signalvalue = ap.SignalStrength + "%";
            }

            signallbl = signalvalue;
        }

    }
}
