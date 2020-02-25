using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                        CreateConfigFileEchoSounder();
                        break;
                    case "remoteSystemConfig.json":
                        CreateConfigFileRemoteSystem("192.168.0.120", 6000, 6001);
                        break;
                    case "GPSConfig.json":
                        CreateGpsConfig();
                        break;
                    default:
                        CustomMessageBox.Show("File Json", "Error");
                        break;
                }
            }
        }

        public void CreateConfigFileEchoSounder()
        {
            List<JsonEchosounder> _data = new List<JsonEchosounder>();
            _data.Add(new JsonEchosounder()
            {
                Range = 0,
                Interval = 0,
                Threshold = 0,
                Offset = 0,
                Deadzone = 0,
                Sound = 0,
                Gain = 0
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

        public void CreateGpsConfig()
        {
            List<GPSConfig> _data = new List<GPSConfig>();
            _data.Add(new GPSConfig()
            {
                Frecuency = 0,
                Protocol = ""
            }) ;
            string json = JsonConvert.SerializeObject(_data.ToArray());
            System.IO.File.WriteAllText(PathDoc + @"GPSConfig.json", json);
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
            using (StreamReader r = new StreamReader(PathDoc + @"remoteSystemConfig.json"))
            {
                string json = r.ReadToEnd();
                List<JsonRemoteSystem> items = JsonConvert.DeserializeObject<List<JsonRemoteSystem>>(json);
                return items;
            }
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

    public class JsonRemoteSystem {

        public string Ip { get; set; }
        public int PortTx { get; set; }
        public int PortRx { get; set; }

    }

    public class GPSConfig
    {
       public int Frecuency { get; set; }
        public string Protocol { get; set; }
    }
}
