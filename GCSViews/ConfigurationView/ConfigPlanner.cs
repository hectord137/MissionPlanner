using Microsoft.Scripting.Utils;
using MissionPlanner.Controls;
using MissionPlanner.Joystick;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using InputBox = MissionPlanner.Controls.InputBox;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigPlanner : MyUserControl, IActivate
    {
        //private List<CultureInfo> _languages;
        private bool startup;
//        static temp temp;
    
        public static ConfigPlanner instance;
        public ConfigPlanner()
        {
            instance = this;
            InitializeComponent();
            //CMB_Layout.Items.Add(DisplayNames.Basic);
            //CMB_Layout.Items.Add(DisplayNames.Advanced);

            txt_log_dir.TextChanged += OnLogDirTextChanged;
            this.txt_log_dir.AutoSize = false;
            this.txt_log_dir.Size = new System.Drawing.Size(366, 25);
            LBLTittleConfig.ForeColor = Color.FromArgb(217, 172, 24);
        }

        // Called every time that this control is made current in the backstage view
        public void Activate()
        {
            startup = true; // flag to ignore changes while we programatically populate controls
            //if (MainV2.DisplayConfiguration.displayName == DisplayNames.Advanced)
            //{
            //    CMB_Layout.SelectedIndex = 1;
            //}
            //else if (MainV2.DisplayConfiguration.displayName == DisplayNames.Basic)
            //{
            //    CMB_Layout.SelectedIndex = 0;
            //}
            //else
            //{
            //    CMB_Layout.SelectedIndex = 0;
            //}



            // this can't fail because it set at startup
            NUM_tracklength.Value = Settings.Instance.GetInt32("NUM_tracklength", 200);

            // get wps on connect
            SetCheckboxFromConfig("loadwpsonconnect", CHK_loadwponconnect);

            // setup other config state
            SetCheckboxFromConfig("CHK_resetapmonconnect", CHK_resetapmonconnect);

            CMB_rateattitude.Text = MainV2.comPort.MAV.cs.rateattitude.ToString();
            CMB_rateposition.Text = MainV2.comPort.MAV.cs.rateposition.ToString();
            CMB_raterc.Text = MainV2.comPort.MAV.cs.raterc.ToString();
            CMB_ratestatus.Text = MainV2.comPort.MAV.cs.ratestatus.ToString();
            CMB_ratesensors.Text = MainV2.comPort.MAV.cs.ratesensors.ToString();

            SetCheckboxFromConfig("CHK_GDIPlus", CHK_GDIPlus);


            SetCheckboxFromConfig("CHK_disttohomeflightdata", CHK_disttohomeflightdata);

//            CHK_AutoParamCommit.Visible = MainV2.DisplayConfiguration.displayParamCommitButton;





            txt_log_dir.Text = Settings.Instance.LogDir;

            startup = false;
        }




        private void BUT_Joystick_Click(object sender, EventArgs e)
        {
            new JoystickSetup().ShowUserControl();
        }

        private void CMB_rateattitude_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            Settings.Instance[((ComboBox)sender).Name] = ((ComboBox)sender).Text;
            MainV2.comPort.MAV.cs.rateattitude = int.Parse(((ComboBox)sender).Text);

            CurrentState.rateattitudebackup = MainV2.comPort.MAV.cs.rateattitude;

            MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.EXTRA1, MainV2.comPort.MAV.cs.rateattitude);
            // request attitude
            MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.EXTRA2, MainV2.comPort.MAV.cs.rateattitude);
            // request vfr
        }

        private void CMB_rateposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            Settings.Instance[((ComboBox)sender).Name] = ((ComboBox)sender).Text;
            MainV2.comPort.MAV.cs.rateposition = int.Parse(((ComboBox)sender).Text);

            CurrentState.ratepositionbackup = MainV2.comPort.MAV.cs.rateposition;

            MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.POSITION, MainV2.comPort.MAV.cs.rateposition);
            // request gps
        }

        private void CMB_ratestatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            Settings.Instance[((ComboBox)sender).Name] = ((ComboBox)sender).Text;
            MainV2.comPort.MAV.cs.ratestatus = int.Parse(((ComboBox)sender).Text);

            CurrentState.ratestatusbackup = MainV2.comPort.MAV.cs.ratestatus;

            MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.EXTENDED_STATUS, MainV2.comPort.MAV.cs.ratestatus);
            // mode
        }

        private void CMB_raterc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            Settings.Instance[((ComboBox)sender).Name] = ((ComboBox)sender).Text;
            MainV2.comPort.MAV.cs.raterc = int.Parse(((ComboBox)sender).Text);

            CurrentState.ratercbackup = MainV2.comPort.MAV.cs.raterc;

            MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.RC_CHANNELS, MainV2.comPort.MAV.cs.raterc);
            // request rc info 
        }

        private void CMB_ratesensors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            Settings.Instance[((ComboBox)sender).Name] = ((ComboBox)sender).Text;
            MainV2.comPort.MAV.cs.ratesensors = int.Parse(((ComboBox)sender).Text);

            CurrentState.ratesensorsbackup = MainV2.comPort.MAV.cs.ratesensors;

            MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.EXTRA3, MainV2.comPort.MAV.cs.ratesensors);
            // request extra stuff - tridge
            MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.RAW_SENSORS, MainV2.comPort.MAV.cs.ratesensors);
            // request raw sensor
        }

        private void CHK_mavdebug_CheckedChanged(object sender, EventArgs e)
        {
            MainV2.comPort.debugmavlink = CHK_mavdebug.Checked;
        }

        private void CHK_resetapmonconnect_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance[((CheckBox)sender).Name] = ((CheckBox)sender).Checked.ToString();
        }

        private void NUM_tracklength_ValueChanged(object sender, EventArgs e)
        {
            Settings.Instance["NUM_tracklength"] = NUM_tracklength.Value.ToString();
        }

        private void CHK_loadwponconnect_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance["loadwpsonconnect"] = CHK_loadwponconnect.Checked.ToString();
        }

        private void CHK_GDIPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            CustomMessageBox.Show("You need to restart the planner for this to take effect");
            Settings.Instance["CHK_GDIPlus"] = CHK_GDIPlus.Checked.ToString();
        }

        // This load handler now only contains code that should execute once
        // on start up. See Activate() for the remainder
        private void ConfigPlanner_Load(object sender, EventArgs e)
        {
        }

        private static void SetCheckboxFromConfig(string configKey, CheckBox chk)
        {
            if (Settings.Instance[configKey] != null)
                chk.Checked = Settings.Instance.GetBoolean(configKey);
        }

        private void CHK_disttohomeflightdata_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance["CHK_disttohomeflightdata"] = CHK_disttohomeflightdata.Checked.ToString();
        }

        private void BUT_logdirbrowse_Click(object sender, EventArgs e)
        {
            var ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_log_dir.Text = ofd.SelectedPath;
            }
        }

        private void OnLogDirTextChanged(object sender, EventArgs e)
        {
            string path = txt_log_dir.Text;
            if (!string.IsNullOrEmpty(path) && System.IO.Directory.Exists(path))
            {
                Settings.Instance.LogDir = path;
            }
        }

        private void chk_temp_CheckedChanged(object sender, EventArgs e)
        {
            //if (chk_temp.Checked)
            //{
            //    temp = new temp();
            //    temp.FormClosing += chk_temp_FormClosing;
            //    temp.Show();
            //}
            //else
            //{
            //    if (temp != null)
            //    {
            //        temp.Close();
            //    }
            //}
        }
        

    }
}