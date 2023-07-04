namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class ConfigPlanner
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigPlanner));
            this.LBLTittleConfig = new System.Windows.Forms.Label();
            this.CMB_rateposition = new System.Windows.Forms.ComboBox();
            this.CHK_mavdebug = new System.Windows.Forms.CheckBox();
            this.label96 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CHK_disttohomeflightdata = new System.Windows.Forms.CheckBox();
            this.BUT_Joystick = new MissionPlanner.Controls.MyButton();
            this.chk_temp = new System.Windows.Forms.CheckBox();
            this.txt_log_dir = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BUT_logdirbrowse = new MissionPlanner.Controls.MyButton();
            this.CHK_GDIPlus = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.CHK_loadwponconnect = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.NUM_tracklength = new System.Windows.Forms.NumericUpDown();
            this.label108 = new System.Windows.Forms.Label();
            this.CHK_resetapmonconnect = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.CMB_raterc = new System.Windows.Forms.ComboBox();
            this.CMB_ratestatus = new System.Windows.Forms.ComboBox();
            this.CMB_ratesensors = new System.Windows.Forms.ComboBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.CMB_rateattitude = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_tracklength)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTittleConfig
            // 
            resources.ApplyResources(this.LBLTittleConfig, "LBLTittleConfig");
            this.LBLTittleConfig.BackColor = System.Drawing.Color.Transparent;
            this.LBLTittleConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(172)))), ((int)(((byte)(24)))));
            this.LBLTittleConfig.Name = "LBLTittleConfig";
            // 
            // CMB_rateposition
            // 
            this.CMB_rateposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_rateposition.FormattingEnabled = true;
            this.CMB_rateposition.Items.AddRange(new object[] {
            resources.GetString("CMB_rateposition.Items"),
            resources.GetString("CMB_rateposition.Items1"),
            resources.GetString("CMB_rateposition.Items2"),
            resources.GetString("CMB_rateposition.Items3"),
            resources.GetString("CMB_rateposition.Items4"),
            resources.GetString("CMB_rateposition.Items5"),
            resources.GetString("CMB_rateposition.Items6"),
            resources.GetString("CMB_rateposition.Items7"),
            resources.GetString("CMB_rateposition.Items8"),
            resources.GetString("CMB_rateposition.Items9"),
            resources.GetString("CMB_rateposition.Items10"),
            resources.GetString("CMB_rateposition.Items11"),
            resources.GetString("CMB_rateposition.Items12"),
            resources.GetString("CMB_rateposition.Items13"),
            resources.GetString("CMB_rateposition.Items14")});
            resources.ApplyResources(this.CMB_rateposition, "CMB_rateposition");
            this.CMB_rateposition.Name = "CMB_rateposition";
            this.CMB_rateposition.SelectedIndexChanged += new System.EventHandler(this.CMB_rateposition_SelectedIndexChanged);
            // 
            // CHK_mavdebug
            // 
            resources.ApplyResources(this.CHK_mavdebug, "CHK_mavdebug");
            this.CHK_mavdebug.Name = "CHK_mavdebug";
            this.CHK_mavdebug.UseVisualStyleBackColor = true;
            this.CHK_mavdebug.CheckedChanged += new System.EventHandler(this.CHK_mavdebug_CheckedChanged);
            // 
            // label96
            // 
            resources.ApplyResources(this.label96, "label96");
            this.label96.Name = "label96";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CHK_disttohomeflightdata
            // 
            this.CHK_disttohomeflightdata.Checked = true;
            this.CHK_disttohomeflightdata.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.CHK_disttohomeflightdata, "CHK_disttohomeflightdata");
            this.CHK_disttohomeflightdata.Name = "CHK_disttohomeflightdata";
            this.CHK_disttohomeflightdata.UseVisualStyleBackColor = true;
            this.CHK_disttohomeflightdata.CheckedChanged += new System.EventHandler(this.CHK_disttohomeflightdata_CheckedChanged);
            // 
            // BUT_Joystick
            // 
            resources.ApplyResources(this.BUT_Joystick, "BUT_Joystick");
            this.BUT_Joystick.Name = "BUT_Joystick";
            this.BUT_Joystick.TextColor = System.Drawing.Color.White;
            this.BUT_Joystick.TextColorNotEnabled = System.Drawing.Color.White;
            this.BUT_Joystick.UseVisualStyleBackColor = true;
            this.BUT_Joystick.Click += new System.EventHandler(this.BUT_Joystick_Click);
            // 
            // chk_temp
            // 
            resources.ApplyResources(this.chk_temp, "chk_temp");
            this.chk_temp.Name = "chk_temp";
            this.chk_temp.UseVisualStyleBackColor = true;
            this.chk_temp.CheckedChanged += new System.EventHandler(this.chk_temp_CheckedChanged);
            // 
            // txt_log_dir
            // 
            this.txt_log_dir.Cursor = System.Windows.Forms.Cursors.SizeAll;
            resources.ApplyResources(this.txt_log_dir, "txt_log_dir");
            this.txt_log_dir.Name = "txt_log_dir";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // BUT_logdirbrowse
            // 
            this.BUT_logdirbrowse.BackColor = System.Drawing.Color.Transparent;
            this.BUT_logdirbrowse.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_logdirbrowse.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_logdirbrowse.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_logdirbrowse.ColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BUT_logdirbrowse, "BUT_logdirbrowse");
            this.BUT_logdirbrowse.Name = "BUT_logdirbrowse";
            this.BUT_logdirbrowse.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(45)))));
            this.BUT_logdirbrowse.TextColor = System.Drawing.Color.Black;
            this.BUT_logdirbrowse.TextColorNotEnabled = System.Drawing.Color.Black;
            this.BUT_logdirbrowse.UseVisualStyleBackColor = false;
            this.BUT_logdirbrowse.Click += new System.EventHandler(this.BUT_logdirbrowse_Click);
            // 
            // CHK_GDIPlus
            // 
            resources.ApplyResources(this.CHK_GDIPlus, "CHK_GDIPlus");
            this.CHK_GDIPlus.Name = "CHK_GDIPlus";
            this.CHK_GDIPlus.UseVisualStyleBackColor = true;
            this.CHK_GDIPlus.CheckedChanged += new System.EventHandler(this.CHK_GDIPlus_CheckedChanged);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // CHK_loadwponconnect
            // 
            resources.ApplyResources(this.CHK_loadwponconnect, "CHK_loadwponconnect");
            this.CHK_loadwponconnect.Name = "CHK_loadwponconnect";
            this.CHK_loadwponconnect.UseVisualStyleBackColor = true;
            this.CHK_loadwponconnect.CheckedChanged += new System.EventHandler(this.CHK_loadwponconnect_CheckedChanged);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // NUM_tracklength
            // 
            resources.ApplyResources(this.NUM_tracklength, "NUM_tracklength");
            this.NUM_tracklength.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUM_tracklength.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUM_tracklength.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUM_tracklength.Name = "NUM_tracklength";
            this.NUM_tracklength.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUM_tracklength.ValueChanged += new System.EventHandler(this.NUM_tracklength_ValueChanged);
            // 
            // label108
            // 
            resources.ApplyResources(this.label108, "label108");
            this.label108.Name = "label108";
            // 
            // CHK_resetapmonconnect
            // 
            this.CHK_resetapmonconnect.Checked = true;
            this.CHK_resetapmonconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.CHK_resetapmonconnect, "CHK_resetapmonconnect");
            this.CHK_resetapmonconnect.Name = "CHK_resetapmonconnect";
            this.CHK_resetapmonconnect.UseVisualStyleBackColor = true;
            this.CHK_resetapmonconnect.CheckedChanged += new System.EventHandler(this.CHK_resetapmonconnect_CheckedChanged);
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label107
            // 
            resources.ApplyResources(this.label107, "label107");
            this.label107.Name = "label107";
            // 
            // CMB_raterc
            // 
            this.CMB_raterc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_raterc.FormattingEnabled = true;
            this.CMB_raterc.Items.AddRange(new object[] {
            resources.GetString("CMB_raterc.Items"),
            resources.GetString("CMB_raterc.Items1"),
            resources.GetString("CMB_raterc.Items2"),
            resources.GetString("CMB_raterc.Items3"),
            resources.GetString("CMB_raterc.Items4"),
            resources.GetString("CMB_raterc.Items5"),
            resources.GetString("CMB_raterc.Items6"),
            resources.GetString("CMB_raterc.Items7"),
            resources.GetString("CMB_raterc.Items8"),
            resources.GetString("CMB_raterc.Items9"),
            resources.GetString("CMB_raterc.Items10"),
            resources.GetString("CMB_raterc.Items11")});
            resources.ApplyResources(this.CMB_raterc, "CMB_raterc");
            this.CMB_raterc.Name = "CMB_raterc";
            this.CMB_raterc.SelectedIndexChanged += new System.EventHandler(this.CMB_raterc_SelectedIndexChanged);
            // 
            // CMB_ratestatus
            // 
            this.CMB_ratestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_ratestatus.FormattingEnabled = true;
            this.CMB_ratestatus.Items.AddRange(new object[] {
            resources.GetString("CMB_ratestatus.Items"),
            resources.GetString("CMB_ratestatus.Items1"),
            resources.GetString("CMB_ratestatus.Items2"),
            resources.GetString("CMB_ratestatus.Items3"),
            resources.GetString("CMB_ratestatus.Items4"),
            resources.GetString("CMB_ratestatus.Items5"),
            resources.GetString("CMB_ratestatus.Items6"),
            resources.GetString("CMB_ratestatus.Items7"),
            resources.GetString("CMB_ratestatus.Items8"),
            resources.GetString("CMB_ratestatus.Items9"),
            resources.GetString("CMB_ratestatus.Items10"),
            resources.GetString("CMB_ratestatus.Items11")});
            resources.ApplyResources(this.CMB_ratestatus, "CMB_ratestatus");
            this.CMB_ratestatus.Name = "CMB_ratestatus";
            this.CMB_ratestatus.SelectedIndexChanged += new System.EventHandler(this.CMB_ratestatus_SelectedIndexChanged);
            // 
            // CMB_ratesensors
            // 
            this.CMB_ratesensors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_ratesensors.FormattingEnabled = true;
            this.CMB_ratesensors.Items.AddRange(new object[] {
            resources.GetString("CMB_ratesensors.Items"),
            resources.GetString("CMB_ratesensors.Items1"),
            resources.GetString("CMB_ratesensors.Items2"),
            resources.GetString("CMB_ratesensors.Items3"),
            resources.GetString("CMB_ratesensors.Items4"),
            resources.GetString("CMB_ratesensors.Items5"),
            resources.GetString("CMB_ratesensors.Items6"),
            resources.GetString("CMB_ratesensors.Items7"),
            resources.GetString("CMB_ratesensors.Items8"),
            resources.GetString("CMB_ratesensors.Items9"),
            resources.GetString("CMB_ratesensors.Items10"),
            resources.GetString("CMB_ratesensors.Items11"),
            resources.GetString("CMB_ratesensors.Items12"),
            resources.GetString("CMB_ratesensors.Items13")});
            resources.ApplyResources(this.CMB_ratesensors, "CMB_ratesensors");
            this.CMB_ratesensors.Name = "CMB_ratesensors";
            this.CMB_ratesensors.SelectedIndexChanged += new System.EventHandler(this.CMB_ratesensors_SelectedIndexChanged);
            // 
            // label104
            // 
            resources.ApplyResources(this.label104, "label104");
            this.label104.Name = "label104";
            // 
            // label103
            // 
            resources.ApplyResources(this.label103, "label103");
            this.label103.Name = "label103";
            // 
            // label102
            // 
            resources.ApplyResources(this.label102, "label102");
            this.label102.Name = "label102";
            // 
            // label101
            // 
            resources.ApplyResources(this.label101, "label101");
            this.label101.Name = "label101";
            // 
            // CMB_rateattitude
            // 
            this.CMB_rateattitude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_rateattitude.FormattingEnabled = true;
            this.CMB_rateattitude.Items.AddRange(new object[] {
            resources.GetString("CMB_rateattitude.Items"),
            resources.GetString("CMB_rateattitude.Items1"),
            resources.GetString("CMB_rateattitude.Items2"),
            resources.GetString("CMB_rateattitude.Items3"),
            resources.GetString("CMB_rateattitude.Items4"),
            resources.GetString("CMB_rateattitude.Items5"),
            resources.GetString("CMB_rateattitude.Items6"),
            resources.GetString("CMB_rateattitude.Items7"),
            resources.GetString("CMB_rateattitude.Items8"),
            resources.GetString("CMB_rateattitude.Items9"),
            resources.GetString("CMB_rateattitude.Items10"),
            resources.GetString("CMB_rateattitude.Items11"),
            resources.GetString("CMB_rateattitude.Items12"),
            resources.GetString("CMB_rateattitude.Items13")});
            resources.ApplyResources(this.CMB_rateattitude, "CMB_rateattitude");
            this.CMB_rateattitude.Name = "CMB_rateattitude";
            this.CMB_rateattitude.SelectedIndexChanged += new System.EventHandler(this.CMB_rateattitude_SelectedIndexChanged);
            // 
            // ConfigPlanner
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.LBLTittleConfig);
            this.Controls.Add(this.CMB_rateposition);
            this.Controls.Add(this.CMB_rateattitude);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.label104);
            this.Controls.Add(this.CMB_ratesensors);
            this.Controls.Add(this.chk_temp);
            this.Controls.Add(this.CMB_ratestatus);
            this.Controls.Add(this.CMB_raterc);
            this.Controls.Add(this.label107);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.CHK_resetapmonconnect);
            this.Controls.Add(this.label108);
            this.Controls.Add(this.NUM_tracklength);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.CHK_loadwponconnect);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.CHK_GDIPlus);
            this.Controls.Add(this.BUT_logdirbrowse);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_log_dir);
            this.Controls.Add(this.CHK_disttohomeflightdata);
            this.Controls.Add(this.CHK_mavdebug);
            this.Controls.Add(this.label96);
            this.Controls.Add(this.BUT_Joystick);
            this.Name = "ConfigPlanner";
            this.Load += new System.EventHandler(this.ConfigPlanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_tracklength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CHK_mavdebug;
        private System.Windows.Forms.Label label96;
        private Controls.MyButton BUT_Joystick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CHK_disttohomeflightdata;
        private System.Windows.Forms.CheckBox chk_temp;
        private System.Windows.Forms.TextBox txt_log_dir;
        private System.Windows.Forms.Label label12;
        private Controls.MyButton BUT_logdirbrowse;
        private System.Windows.Forms.CheckBox CHK_GDIPlus;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox CHK_loadwponconnect;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown NUM_tracklength;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.CheckBox CHK_resetapmonconnect;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.ComboBox CMB_raterc;
        private System.Windows.Forms.ComboBox CMB_ratestatus;
        private System.Windows.Forms.ComboBox CMB_ratesensors;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.ComboBox CMB_rateattitude;
        private System.Windows.Forms.ComboBox CMB_rateposition;
        private System.Windows.Forms.Label LBLTittleConfig;
    }
}
