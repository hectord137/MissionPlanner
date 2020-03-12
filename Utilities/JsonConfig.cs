using MissionPlanner.GCSViews.ConfigurationView;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.Utilities
{
    class JsonConfig
    {
    
        private string PathDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Mission Planner\";

        public void VerifyConfigFile(string FileJson)
        {
            if (!File.Exists(PathDoc + FileJson))
            {
                Directory.CreateDirectory(PathDoc);

                switch (FileJson) {
                    case "echosounderconfig.json":
                        CreateConfigFileEchoSounder(0,0,0,0,0,0,0);
                        break;
                    case "remoteSystemConfig.json":
                        CreateConfigFileRemoteSystem("192.168.0.120", 6000, 6001);
                        break;
                    case "GPSConfig.json":
                        CreateGpsConfig(0 ,"");
                        break;
                    case "Config.json":
                        CreateConfig(30);
                        break;
                    case "AutoStop.json":
                        CreateAutoStop(0, false);
                        break;
                    default:
                        CustomMessageBox.Show("File Json", "Error");
                        break;
                }
            }
        }

    

        public void CreateConfigFileEchoSounder(int _Range, double _Interval, int _Threshold, int _Offset,
         int _Deadzone, int _Sound, double _Gain )
        {
            List<JsonEchosounder> _data = new List<JsonEchosounder>();
            _data.Add(new JsonEchosounder()
            {
                Range = _Range,
                Interval = _Interval,
                Threshold = _Threshold,
                Offset = _Offset,
                Deadzone = _Deadzone,
                Sound = _Sound,
                Gain = _Gain
            });
            string json = JsonConvert.SerializeObject(_data.ToArray());
            System.IO.File.WriteAllText(PathDoc + @"echosounderconfig.json", json);
           
        }

        public void CreateConfigFileRemoteSystem(string IP, int PortTx, int PortRx)
        {
            List<JsonRemoteSystem> _data = new List<JsonRemoteSystem>();
            _data.Add(new JsonRemoteSystem()
            {
                Ip = IP,
                PortRx = PortRx,
                PortTx = PortTx,
            });
            string json = JsonConvert.SerializeObject(_data.ToArray());
            System.IO.File.WriteAllText(PathDoc + @"remoteSystemConfig.json", json);

        }

        public void CreateGpsConfig(int Frequency, string Protocol)
        {
            List<GPSConfig> _data = new List<GPSConfig>();
            _data.Add(new GPSConfig()
            {
                Frequency = Frequency,
                Protocol = Protocol
            }) ;
            string json = JsonConvert.SerializeObject(_data.ToArray());
            System.IO.File.WriteAllText(PathDoc + @"GPSConfig.json", json);

        }

        public void CreateConfig(int limit)
        {
            List<GeneralConfig> _data = new List<GeneralConfig>();
            _data.Add(new GeneralConfig()
            {
                LimitEchosounder = limit
            });
            string json = JsonConvert.SerializeObject(_data.ToArray());
            System.IO.File.WriteAllText(PathDoc + @"Config.json", json);
        }

        public void CreateAutoStop(int AutoStop, bool Enabled)
        {
            List<ConfigToSendEchosounder> _data = new List<ConfigToSendEchosounder>();
            _data.Add(new ConfigToSendEchosounder()
            {
                Autostop = AutoStop,
                Enabled = Enabled
            }) ;
            string json = JsonConvert.SerializeObject(_data.ToArray());
            System.IO.File.WriteAllText(PathDoc + @"AutoStop.json", json);

        }

        public List<JsonEchosounder> ReadJsonEchosounder()
        {
            using (StreamReader r = new StreamReader(PathDoc + @"echosounderconfig.json"))
            {
                string json = r.ReadToEnd();
                List<JsonEchosounder> items = JsonConvert.DeserializeObject<List<JsonEchosounder>>(json);
                return items;
            }
        }

        public List<JsonRemoteSystem> ReadRemoteSystem()
        {
            try
            {
                using (StreamReader r = new StreamReader(PathDoc + @"remoteSystemConfig.json"))
                {
                    string json = r.ReadToEnd();
                    List<JsonRemoteSystem> items = JsonConvert.DeserializeObject<List<JsonRemoteSystem>>(json);
                    return items;
                }
            }
            catch { return null; }
        }
        public List<GPSConfig> ReadGPSConfig()
        {
            using (StreamReader r = new StreamReader(PathDoc + @"GPSConfig.json"))
            {
                string json = r.ReadToEnd();
                List<GPSConfig> items = JsonConvert.DeserializeObject<List<GPSConfig>>(json);
                return items;
            }
        }
        public List<GeneralConfig> ReadConfig()
        {
            using (StreamReader r = new StreamReader(PathDoc + @"Config.json"))
            {
                string json = r.ReadToEnd();
                List<GeneralConfig> items = JsonConvert.DeserializeObject<List<GeneralConfig>>(json);
                return items;
            }
        }

        public List<ConfigToSendEchosounder> ReadAutoStop()
        {
            using (StreamReader r = new StreamReader(PathDoc + @"AutoStop.json"))
            {
                string json = r.ReadToEnd();
                List<ConfigToSendEchosounder> items = JsonConvert.DeserializeObject<List<ConfigToSendEchosounder>>(json);
                return items;
            }
        }
    }

    public class JsonEchosounder
    {

        public int Range { get; set; }
        public double Interval { get; set; }
        public int Threshold { get; set; }
        public int Offset { get; set; }
        public int Deadzone { get; set; }
        public int Sound { get; set; }
        public double Gain { get; set; }
    }

    public class GeneralConfig
    {//limit in meters
        public int LimitEchosounder { get; set; }

    }
    public class ConfigToSendEchosounder { 
    public int Autostop { get; set; }
    public bool Enabled { get; set; }
    }

    public class JsonRemoteSystem {

        public string Ip { get; set; }
        public int PortTx { get; set; }
        public int PortRx { get; set; }

    }

    public class GPSConfig
    {
       public int Frequency { get; set; }
        public string Protocol { get; set; }
    }
}
