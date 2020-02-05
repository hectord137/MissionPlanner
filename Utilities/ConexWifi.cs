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


namespace MissionPlanner.Utilities
{
    class ConexWifi
    {
        private string Parameterfile = @"C:/config.txt";
        private string interfaz;
        private string password;
        private string Name_wifi;
        private string mac;
      
        Wifi objwifi = new Wifi();

        public void main() {
          
            ReadParameters();

            if (GetInterfaces())
            {
                conectwifi();
            }

            System.Timers.Timer tick = new System.Timers.Timer(1000);
            tick.Elapsed += Tick_Elapsed;
            tick.Start();

        }

        public void Tick_Elapsed(object sender, ElapsedEventArgs e)
        {
            signal();
        }

  

        List<string> parameters = new List<string>();
        public void ReadParameters()
        {
            string[] lines = System.IO.File.ReadAllLines(Parameterfile);
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
            //this.mac = this.parameters[3];
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

        private void conectwifi() {
            if (FindWifi().Item1)
            {
                CustomMessageBox.Show("Trying to connect..\r\n");
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
                    if (ap.Connect(authRequest)) {
                        CustomMessageBox.Show("Conectado", "Success");
                    }
                }
                ChangePriority();
            }
            else
            {
                CustomMessageBox.Show("Red no encontrada", "Error");
            }
        }



        public string signal()
        {
            string signalvalue = "";            
            List<AccessPoint> pa = objwifi.GetAccessPoints();
            foreach (AccessPoint ap in pa.Where(i =>i.Name == Name_wifi))
            {
                 signalvalue = ap.SignalStrength + "%";
            }

            return signalvalue;
        }

    }
}
