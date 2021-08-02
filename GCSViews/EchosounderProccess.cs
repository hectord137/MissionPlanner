using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using MissionPlanner.Controls;
using MissionPlanner.Properties;
using MissionPlanner.Utilities;

using Microsoft.WindowsAPICodePack.Dialogs;
using System.Globalization;
using System.IO;
using System.Threading;

namespace MissionPlanner.GCSViews
{
    public partial class EchosounderProccess : MyUserControl, IActivate
    {
        public delegate IProgressReporterDialogue ProgressEventHandle(string title);
        public static event ProgressEventHandle CreateIProgressReporterDialogue;

        public IProgressReporterDialogue formProgressReporter;

        public EchosounderProccess()
        {
            InitializeComponent();

            CreateIProgressReporterDialogue += title =>
                new ProgressReporterDialogue() { StartPosition = FormStartPosition.CenterScreen, Text = title };
        }

        public void Activate()
        {

        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.EnsureFileExists = true;
            dialog.EnsurePathExists = true;
            dialog.Filters.Add(new CommonFileDialogFilter("NMEA Text", "*.txt"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TXT_InData.Text = dialog.FileName;
            }
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TXT_OutData.Text = dialog.FileName;
            }
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            formProgressReporter = CreateIProgressReporterDialogue("Converting Data");

            formProgressReporter.DoWork += ConvertData;
            formProgressReporter.UpdateProgressAndStatus(-1, "...");

            formProgressReporter.RunBackgroundOperationAsync();

            formProgressReporter.Dispose();
        }

        void ConvertData(IProgressReporterDialogue sender)
        {
            string inFilePath = TXT_InData.Text;
            string[] lines = new string[1];
            if (File.Exists(inFilePath))
            {
                if (formProgressReporter != null)
                    this.formProgressReporter.UpdateProgressAndStatus(1, "Reading input file.");
                try
                {
                    lines = File.ReadAllLines(inFilePath);
                }
                catch(Exception e)
                {
                    if (formProgressReporter != null)
                        formProgressReporter.doWorkArgs.ErrorMessage = e.Message;
                    return;
                }
            }
            else
            {
                if (formProgressReporter != null)
                    formProgressReporter.doWorkArgs.ErrorMessage = "Input file don't exist.";
                return;
            }

            List<Tuple<string, double, double>> timeLatLonList = new List<Tuple<string, double, double>>();
            List<double> depthList = new List<double>();

            bool dbt_OK = false;
            bool gga_OK = false;
            double lat = 0;
            double lon = 0;
            string time = "";
            double depth = 0;
            int progressIndex = 0;
            foreach (string line in lines)
            {
                if(progressIndex % 200 == 0)
                    Thread.Sleep(1);

                progressIndex++;
                //Si el usuario cancela el dialogo
                if (formProgressReporter != null && formProgressReporter.doWorkArgs.CancelRequested)
                {
                    formProgressReporter.doWorkArgs.CancelAcknowledged = true;
                    formProgressReporter.doWorkArgs.ErrorMessage = "User Canceled.";
                    return;
                }

                //Reportar progreso
                if (formProgressReporter != null)
                    this.formProgressReporter.UpdateProgressAndStatus((progressIndex * 70)/lines.Count(), "Extracting NMEA sentences.");

                if (!string.IsNullOrEmpty(line))
                {
                    if (line.Contains("$GPDBT"))
                    {
                        string[] sp = line.Split(',');
                        depth = double.Parse(sp[3], CultureInfo.InvariantCulture);
                        dbt_OK = true;
                    }

                    if (line.Contains("$GPGGA") || line.Contains("$GNGGA"))
                    {
                        string[] sp = line.Split(',');
                        time = sp[1];
                        lat = ToDecimalDegrees(sp[2] + sp[3]);
                        lon = ToDecimalDegrees(sp[4] + sp[5]);
                        gga_OK = true;
                    }

                    continue;
                }

                //Cuando se llega a este punto, se ha completado un bloque.
                if (dbt_OK && gga_OK)
                {
                    PointLatLngAlt point = new PointLatLngAlt(lat, lon);
                    double[] utm  = point.ToUTM();
                    timeLatLonList.Add(time, utm[0], utm[1]);
                    depthList.Add(depth);
                }
                dbt_OK = false;
                gga_OK = false;

            }

            //Crear el Filtro - orden 30, determinado experimental
            MathNet.Filtering.OnlineFilter filter = MathNet.Filtering.OnlineFilter.CreateDenoise(30);

            //Reportar progreso
            if (formProgressReporter != null)
                this.formProgressReporter.UpdateProgressAndStatus(80, "Applying filtering forward-backward.");
            Thread.Sleep(1000);

            //Filtrar Forward y Backward
            double[] depthForward = filter.ProcessSamples(depthList.ToArray());
            double[] depthBackward = filter.ProcessSamples(depthForward.Reverse().ToArray());
            depthBackward = depthBackward.Reverse().ToArray();

            //Reportar progreso
            if (formProgressReporter != null)
                this.formProgressReporter.UpdateProgressAndStatus(85, "Preparing text structure.");
            Thread.Sleep(1000);

            //Crear la lista string Lat,Lon,Depth
            List<string> listOut = new List<string>();

            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

            for (int i = 0; i < timeLatLonList.Count(); i++)
            {
                listOut.Add(timeLatLonList[i].Item2.ToString("F3", culture) + "," + // Lat
                            timeLatLonList[i].Item3.ToString("F3", culture) + "," + // Lon
                            //depthList[i].ToString("F3", culture) + "," +
                            depthBackward[i].ToString("F3", culture));              // Depth
            }

            //Crear la lista string fotmato HYPACK
            List<string> listOutHYPACK = new List<string>();
            listOutHYPACK.Add("FTP NEW 2");
            listOutHYPACK.Add("TND " + DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy"));
            listOutHYPACK.Add("DEV 0 32784 \"ECHOSOUNDER\" 0");
            listOutHYPACK.Add("DEV 1 32837 \"GPS\" 57348");
            listOutHYPACK.Add("USR \"SBY\" \"HYPACK\"");
            listOutHYPACK.Add("EOH");
            for (int i = 0; i < timeLatLonList.Count(); i++)
            {
                //EC2 0 1.0 2.8 0.000
                //POS 1 1.1 307916.529 6461349.538
                DateTime dateTime = DateTime.ParseExact(timeLatLonList[i].Item1, "HHmmss.ff", null);
                string st = dateTime.TimeOfDay.TotalSeconds.ToString("F1", culture);

                listOutHYPACK.Add("EC2 0 " + st + " " + depthBackward[i].ToString("F3", culture) + " 0.0");
                listOutHYPACK.Add("POS 1 " + st + " " + timeLatLonList[i].Item2.ToString("F3", culture) + " " + timeLatLonList[i].Item3.ToString("F3", culture));
            }

            //Reportar progreso
            if (formProgressReporter != null)
                this.formProgressReporter.UpdateProgressAndStatus(90, "Writing the output file.");
            Thread.Sleep(1000);

            //Escribir el archivo XYZ final
            try
            {
                File.WriteAllLines(TXT_OutData.Text + "\\" + Path.GetFileNameWithoutExtension(TXT_InData.Text) + ".XYZ", listOut.ToArray());
            }
            catch(Exception e)
            {
                if (formProgressReporter != null)
                    formProgressReporter.doWorkArgs.ErrorMessage = e.Message;
                return;
            }

            //Escribir el archivo RAW final
            try
            {
                File.WriteAllLines(TXT_OutData.Text + "\\" + Path.GetFileNameWithoutExtension(TXT_InData.Text) + ".RAW", listOutHYPACK.ToArray());
            }
            catch (Exception e)
            {
                if (formProgressReporter != null)
                    formProgressReporter.doWorkArgs.ErrorMessage = e.Message;
                return;
            }

            //Reportar progreso
            if (formProgressReporter != null)
                this.formProgressReporter.UpdateProgressAndStatus(100, "Done.");
            Thread.Sleep(500);

        }

        public static double ToDecimalDegrees(string deg)
        {
            if (string.IsNullOrEmpty(deg))
            {
                return -1;
            }

            var list = deg.Split('.');
            var minuteMajor = list[0].Substring(list[0].Length - 2);
            var degree = list[0].Substring(0, list[0].Length - 2);
            var nesw = list[1].Substring(list[1].Length - 1);
            var minuteMinor = list[1].Substring(0, list[1].Length - 1);
            var minute = minuteMajor + "." + minuteMinor;
            var plusMinus = nesw == "S" || nesw == "W" ? -1 : 1;
            var result = (double.Parse(degree, CultureInfo.InvariantCulture) + (double.Parse(minute, CultureInfo.InvariantCulture) / 60.0)) * plusMinus;
            return result;
        }
    }
}
