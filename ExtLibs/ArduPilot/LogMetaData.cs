using ExifLibrary;
using log4net;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SharpCompress.Archives;
using SharpCompress.Compressors.Xz;
using SharpCompress.Readers;

namespace MissionPlanner.ArduPilot
{
    public class LogMetaData
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static string[] vehicles = new[] { "Copter", "Plane", "Rover", "Tracker" };

        static string url = "https://autotest.ardupilot.org/LogMessages/{0}/LogMessages.xml.xz";

        public static  Dictionary<string, Dictionary<string, string>> MetaData { get; } = new Dictionary<string, Dictionary<string, string>>();

        

        public static void ParseMetaData()
        {
            vehicles.ForEach(a =>
            {
                var file = Path.Combine(Settings.GetDataDirectory(), "LogMessages" + a + ".xml");

                if (!File.Exists(file))
                {
                    return;
                }

                try
                {
                    var xml = XDocument.Load(file);

                    xml.Root.Descendants("logformat").ForEach<XElement>(b =>
                    {
                        if (b == null)
                            return;

                        var type = b.Attribute("name");
                        var typedesc = b.Descendants("description").FirstOrDefault();

                        if (!MetaData.ContainsKey(type.Value))
                            MetaData[type.Value] = new Dictionary<string, string>();

                        MetaData[type.Value]["description"] = typedesc.Value;

                        b.Descendants("fields").Descendants("field").ForEach(c =>
                        {
                            var name = c.Attribute("name");
                            var desc = c.Descendants("description").FirstOrDefault();

                            MetaData[type.Value][name.Value] = desc.Value;
                        });
                    });
                }   
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            });
        }
    }
}
