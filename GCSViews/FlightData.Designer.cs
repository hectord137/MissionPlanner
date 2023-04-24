namespace MissionPlanner.GCSViews
{
    partial class FlightData
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightData));
            CodeArtEng.Gauge.Themes.ThemeColors themeColors1 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors2 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors3 = new CodeArtEng.Gauge.Themes.ThemeColors();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSourceHud = new System.Windows.Forms.BindingSource(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goHereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToHereAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointCameraHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PointCameraCoordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightPlannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEKFHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.takeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onOffCameraOverlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altitudeAngelSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CB_tuning = new System.Windows.Forms.CheckBox();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
            this.Zoomlevel = new System.Windows.Forms.NumericUpDown();
            this.Bat_Body_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TimerUpdateSecondMAV = new System.Windows.Forms.Timer(this.components);
            this.depthAlertTimer = new System.Windows.Forms.Timer(this.components);
            this.tableMap = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.BUT_ClearEchoData = new MissionPlanner.Controls.MyButton();
            this.BUT_DownloadEchoData = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_TimeRemain = new System.Windows.Forms.Label();
            this.lineSeparator1 = new MissionPlanner.Controls.LineSeparator();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_TotalDist = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBL_TraveledDist = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LBL_MissionCompleted = new System.Windows.Forms.Label();
            this.COMBJOY = new System.Windows.Forms.ComboBox();
            this.but_disablejoystick = new MissionPlanner.Controls.MyButton();
            this.distanceBar1 = new MissionPlanner.Controls.DistanceBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TRK_zoom = new MissionPlanner.Controls.MyTrackBar();
            this.gMapControl1 = new MissionPlanner.Controls.myGMAP();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.tableLayoutPaneltlogs = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_loadtelem = new MissionPlanner.Controls.MyButton();
            this.tracklog = new System.Windows.Forms.TrackBar();
            this.BUT_playlog = new MissionPlanner.Controls.MyButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BUT_speed10 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed5 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_4 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_10 = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.NUM_DepthAlarmValue = new System.Windows.Forms.NumericUpDown();
            this.BUT_MuteDepthAlarm = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.CMB_setwp = new System.Windows.Forms.ComboBox();
            this.BUT_setwp = new MissionPlanner.Controls.MyButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_EchoGrab = new MissionPlanner.Controls.MyButton();
            this.BUT_StopGrab = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentR_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            this.Hum_R_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.CurrentL_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            this.Hum_L_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.Hum_Body_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.Temp_R_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.Temp_L_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.Temp_Body_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.Bat_R_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.Bat_L_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.Depth_Gauge = new CodeArtEng.Gauge.LinearGauge();
            this.Speed_Gauge = new CodeArtEng.Gauge.LinearGauge();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarL_Down = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator();
            this.progressBarL_Up = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarR_Down = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator();
            this.progressBarR_Up = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator();
            this.label20 = new System.Windows.Forms.Label();
            this.CurrentMain_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Link_Quality_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            this.Dist_To_Home_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            this.BUT_manual = new MissionPlanner.Controls.MyButton();
            this.BUT_quickrtl = new MissionPlanner.Controls.MyButton();
            this.BUTrestartmission = new MissionPlanner.Controls.MyButton();
            this.BUT_clear_track = new MissionPlanner.Controls.MyButton();
            this.BUT_quickauto = new MissionPlanner.Controls.MyButton();
            this.BUT_ARM = new MissionPlanner.Controls.MyButton();
            this.Storage_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.Satellites_Gauge = new CodeArtEng.Gauge.CircularGauge();
            this.hud1 = new MissionPlanner.Controls.HUD();
            this.MainH = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.ZedGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BUT_EchoGrab_BlinkTimer = new System.Windows.Forms.Timer(this.components);
            this.PingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).BeginInit();
            this.contextMenuStripMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).BeginInit();
            this.tableMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPaneltlogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_DepthAlarmValue)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).BeginInit();
            this.MainH.Panel1.SuspendLayout();
            this.MainH.Panel2.SuspendLayout();
            this.MainH.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceHud
            // 
            this.bindingSourceHud.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "siren.png");
            this.imageList2.Images.SetKeyName(1, "siren2.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mute6.png");
            this.imageList1.Images.SetKeyName(1, "mute3.png");
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHereToolStripMenuItem1,
            this.flyToHereAltToolStripMenuItem,
            this.addPoiToolStripMenuItem,
            this.pointCameraHereToolStripMenuItem,
            this.PointCameraCoordsToolStripMenuItem1,
            this.triggerCameraToolStripMenuItem,
            this.flightPlannerToolStripMenuItem,
            this.setHomeHereToolStripMenuItem,
            this.takeOffToolStripMenuItem,
            this.onOffCameraOverlapToolStripMenuItem,
            this.altitudeAngelSettingsToolStripMenuItem,
            this.setHomeHereToolStripMenuItem2});
            this.contextMenuStripMap.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStripMap, "contextMenuStripMap");
            // 
            // goHereToolStripMenuItem1
            // 
            this.goHereToolStripMenuItem1.Name = "goHereToolStripMenuItem1";
            resources.ApplyResources(this.goHereToolStripMenuItem1, "goHereToolStripMenuItem1");
            this.goHereToolStripMenuItem1.Click += new System.EventHandler(this.goHereToolStripMenuItem_Click);
            // 
            // flyToHereAltToolStripMenuItem
            // 
            this.flyToHereAltToolStripMenuItem.Name = "flyToHereAltToolStripMenuItem";
            resources.ApplyResources(this.flyToHereAltToolStripMenuItem, "flyToHereAltToolStripMenuItem");
            this.flyToHereAltToolStripMenuItem.Click += new System.EventHandler(this.flyToHereAltToolStripMenuItem_Click);
            // 
            // addPoiToolStripMenuItem
            // 
            this.addPoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.loadFileToolStripMenuItem});
            this.addPoiToolStripMenuItem.Name = "addPoiToolStripMenuItem";
            resources.ApplyResources(this.addPoiToolStripMenuItem, "addPoiToolStripMenuItem");
            this.addPoiToolStripMenuItem.Click += new System.EventHandler(this.addPoiToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            resources.ApplyResources(this.saveFileToolStripMenuItem, "saveFileToolStripMenuItem");
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            resources.ApplyResources(this.loadFileToolStripMenuItem, "loadFileToolStripMenuItem");
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // pointCameraHereToolStripMenuItem
            // 
            this.pointCameraHereToolStripMenuItem.Name = "pointCameraHereToolStripMenuItem";
            resources.ApplyResources(this.pointCameraHereToolStripMenuItem, "pointCameraHereToolStripMenuItem");
            this.pointCameraHereToolStripMenuItem.Click += new System.EventHandler(this.pointCameraHereToolStripMenuItem_Click);
            // 
            // PointCameraCoordsToolStripMenuItem1
            // 
            this.PointCameraCoordsToolStripMenuItem1.Name = "PointCameraCoordsToolStripMenuItem1";
            resources.ApplyResources(this.PointCameraCoordsToolStripMenuItem1, "PointCameraCoordsToolStripMenuItem1");
            this.PointCameraCoordsToolStripMenuItem1.Click += new System.EventHandler(this.PointCameraCoordsToolStripMenuItem1_Click);
            // 
            // triggerCameraToolStripMenuItem
            // 
            this.triggerCameraToolStripMenuItem.Name = "triggerCameraToolStripMenuItem";
            resources.ApplyResources(this.triggerCameraToolStripMenuItem, "triggerCameraToolStripMenuItem");
            this.triggerCameraToolStripMenuItem.Click += new System.EventHandler(this.triggerCameraToolStripMenuItem_Click);
            // 
            // flightPlannerToolStripMenuItem
            // 
            this.flightPlannerToolStripMenuItem.Name = "flightPlannerToolStripMenuItem";
            resources.ApplyResources(this.flightPlannerToolStripMenuItem, "flightPlannerToolStripMenuItem");
            this.flightPlannerToolStripMenuItem.Click += new System.EventHandler(this.flightPlannerToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem
            // 
            this.setHomeHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setEKFHomeHereToolStripMenuItem,
            this.setHomeHereToolStripMenuItem1});
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            this.setHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // setEKFHomeHereToolStripMenuItem
            // 
            this.setEKFHomeHereToolStripMenuItem.Name = "setEKFHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setEKFHomeHereToolStripMenuItem, "setEKFHomeHereToolStripMenuItem");
            this.setEKFHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setEKFHomeHereToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem1
            // 
            this.setHomeHereToolStripMenuItem1.Name = "setHomeHereToolStripMenuItem1";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem1, "setHomeHereToolStripMenuItem1");
            this.setHomeHereToolStripMenuItem1.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // takeOffToolStripMenuItem
            // 
            this.takeOffToolStripMenuItem.Name = "takeOffToolStripMenuItem";
            resources.ApplyResources(this.takeOffToolStripMenuItem, "takeOffToolStripMenuItem");
            this.takeOffToolStripMenuItem.Click += new System.EventHandler(this.takeOffToolStripMenuItem_Click);
            // 
            // onOffCameraOverlapToolStripMenuItem
            // 
            this.onOffCameraOverlapToolStripMenuItem.CheckOnClick = true;
            this.onOffCameraOverlapToolStripMenuItem.Name = "onOffCameraOverlapToolStripMenuItem";
            resources.ApplyResources(this.onOffCameraOverlapToolStripMenuItem, "onOffCameraOverlapToolStripMenuItem");
            this.onOffCameraOverlapToolStripMenuItem.Click += new System.EventHandler(this.onOffCameraOverlapToolStripMenuItem_Click);
            // 
            // altitudeAngelSettingsToolStripMenuItem
            // 
            this.altitudeAngelSettingsToolStripMenuItem.Name = "altitudeAngelSettingsToolStripMenuItem";
            resources.ApplyResources(this.altitudeAngelSettingsToolStripMenuItem, "altitudeAngelSettingsToolStripMenuItem");
            this.altitudeAngelSettingsToolStripMenuItem.Click += new System.EventHandler(this.altitudeAngelSettingsToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem2
            // 
            this.setHomeHereToolStripMenuItem2.Name = "setHomeHereToolStripMenuItem2";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem2, "setHomeHereToolStripMenuItem2");
            this.setHomeHereToolStripMenuItem2.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem2_Click);
            // 
            // CB_tuning
            // 
            resources.ApplyResources(this.CB_tuning, "CB_tuning");
            this.CB_tuning.Name = "CB_tuning";
            this.toolTip1.SetToolTip(this.CB_tuning, resources.GetString("CB_tuning.ToolTip"));
            this.CB_tuning.UseVisualStyleBackColor = true;
            this.CB_tuning.CheckedChanged += new System.EventHandler(this.CB_tuning_CheckedChanged);
            // 
            // CHK_autopan
            // 
            resources.ApplyResources(this.CHK_autopan, "CHK_autopan");
            this.CHK_autopan.Checked = true;
            this.CHK_autopan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_autopan.Name = "CHK_autopan";
            this.toolTip1.SetToolTip(this.CHK_autopan, resources.GetString("CHK_autopan.ToolTip"));
            this.CHK_autopan.UseVisualStyleBackColor = true;
            this.CHK_autopan.CheckedChanged += new System.EventHandler(this.CHK_autopan_CheckedChanged);
            // 
            // Zoomlevel
            // 
            resources.ApplyResources(this.Zoomlevel, "Zoomlevel");
            this.Zoomlevel.DecimalPlaces = 1;
            this.Zoomlevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Zoomlevel.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Zoomlevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Zoomlevel.Name = "Zoomlevel";
            this.toolTip1.SetToolTip(this.Zoomlevel, resources.GetString("Zoomlevel.ToolTip"));
            this.Zoomlevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Zoomlevel.ValueChanged += new System.EventHandler(this.Zoomlevel_ValueChanged);
            // 
            // Bat_Body_Gauge
            // 
            this.Bat_Body_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Bat_Body_Gauge, "Bat_Body_Gauge");
            this.Bat_Body_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Bat_Body_Gauge.ErrorLimit = 10D;
            this.Bat_Body_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Bat_Body_Gauge.InvertLimit = true;
            this.Bat_Body_Gauge.MajorTicks.Interval = 0D;
            this.Bat_Body_Gauge.MajorTicks.MarkerLength = 5;
            this.Bat_Body_Gauge.Maximum = 100D;
            this.Bat_Body_Gauge.MinorTicks.Interval = 0D;
            this.Bat_Body_Gauge.MinorTicks.MarkerLength = 5;
            this.Bat_Body_Gauge.Name = "Bat_Body_Gauge";
            this.Bat_Body_Gauge.PointerEndAngle = 504;
            this.Bat_Body_Gauge.PointerStartAngle = 216;
            this.Bat_Body_Gauge.ResetValue = 0D;
            this.Bat_Body_Gauge.ScaleFactor = 1D;
            this.Bat_Body_Gauge.ScaleLabel.Interval = 10D;
            this.Bat_Body_Gauge.SegmentCount = 50;
            this.Bat_Body_Gauge.SegmentGap = 2;
            this.Bat_Body_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Bat_Body_Gauge.Title = "";
            this.toolTip1.SetToolTip(this.Bat_Body_Gauge, resources.GetString("Bat_Body_Gauge.ToolTip"));
            this.Bat_Body_Gauge.Unit = "Bat B";
            themeColors1.MajorTickLineColor = System.Drawing.Color.White;
            themeColors1.MinorTickLineColor = System.Drawing.Color.White;
            themeColors1.NeedleColor = System.Drawing.Color.White;
            themeColors1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            themeColors1.PanelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            themeColors1.PointerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            themeColors1.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            themeColors1.ScaleLabelColor = System.Drawing.Color.Silver;
            themeColors1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Bat_Body_Gauge.UserDefinedColors.Base = themeColors1;
            themeColors2.MajorTickLineColor = System.Drawing.Color.White;
            themeColors2.MinorTickLineColor = System.Drawing.Color.White;
            themeColors2.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            themeColors2.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            themeColors2.PanelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            themeColors2.PointerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            themeColors2.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            themeColors2.ScaleLabelColor = System.Drawing.Color.Silver;
            themeColors2.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Bat_Body_Gauge.UserDefinedColors.Error = themeColors2;
            themeColors3.MajorTickLineColor = System.Drawing.Color.White;
            themeColors3.MinorTickLineColor = System.Drawing.Color.White;
            themeColors3.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            themeColors3.PanelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            themeColors3.PointerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            themeColors3.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            themeColors3.ScaleLabelColor = System.Drawing.Color.Silver;
            themeColors3.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Bat_Body_Gauge.UserDefinedColors.Warning = themeColors3;
            this.Bat_Body_Gauge.Value = 1D;
            this.Bat_Body_Gauge.ValueFormat = "0 \"%\"";
            this.Bat_Body_Gauge.WarningLimit = 30D;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // TimerUpdateSecondMAV
            // 
            this.TimerUpdateSecondMAV.Enabled = true;
            this.TimerUpdateSecondMAV.Interval = 500;
            this.TimerUpdateSecondMAV.Tick += new System.EventHandler(this.TimerUpdateSecondMAV_Tick);
            // 
            // depthAlertTimer
            // 
            this.depthAlertTimer.Interval = 500;
            this.depthAlertTimer.Tick += new System.EventHandler(this.depthAlertTimer_Tick_1);
            // 
            // tableMap
            // 
            resources.ApplyResources(this.tableMap, "tableMap");
            this.tableMap.Controls.Add(this.splitContainer1, 0, 0);
            this.tableMap.Controls.Add(this.panel1, 0, 1);
            this.tableMap.Name = "tableMap";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.zg1);
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.ContextMenuStrip = this.contextMenuStripMap;
            this.splitContainer1.Panel2.Controls.Add(this.BUT_ClearEchoData);
            this.splitContainer1.Panel2.Controls.Add(this.BUT_DownloadEchoData);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel12);
            this.splitContainer1.Panel2.Controls.Add(this.COMBJOY);
            this.splitContainer1.Panel2.Controls.Add(this.but_disablejoystick);
            this.splitContainer1.Panel2.Controls.Add(this.distanceBar1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.TRK_zoom);
            this.splitContainer1.Panel2.Controls.Add(this.gMapControl1);
            // 
            // zg1
            // 
            resources.ApplyResources(this.zg1, "zg1");
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.UseExtendedPrintDialog = true;
            this.zg1.DoubleClick += new System.EventHandler(this.zg1_DoubleClick);
            // 
            // BUT_ClearEchoData
            // 
            resources.ApplyResources(this.BUT_ClearEchoData, "BUT_ClearEchoData");
            this.BUT_ClearEchoData.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_ClearEchoData.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_ClearEchoData.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_ClearEchoData.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_ClearEchoData.Name = "BUT_ClearEchoData";
            this.BUT_ClearEchoData.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_ClearEchoData.TextColor = System.Drawing.Color.Black;
            this.BUT_ClearEchoData.Click += new System.EventHandler(this.BUT_ClearEchoData_Click);
            // 
            // BUT_DownloadEchoData
            // 
            resources.ApplyResources(this.BUT_DownloadEchoData, "BUT_DownloadEchoData");
            this.BUT_DownloadEchoData.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_DownloadEchoData.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_DownloadEchoData.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_DownloadEchoData.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_DownloadEchoData.Name = "BUT_DownloadEchoData";
            this.BUT_DownloadEchoData.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_DownloadEchoData.TextColor = System.Drawing.Color.Black;
            this.BUT_DownloadEchoData.Click += new System.EventHandler(this.BUT_DownloadEchoData_Click);
            // 
            // tableLayoutPanel12
            // 
            resources.ApplyResources(this.tableLayoutPanel12, "tableLayoutPanel12");
            this.tableLayoutPanel12.Controls.Add(this.LBL_TimeRemain, 0, 5);
            this.tableLayoutPanel12.Controls.Add(this.lineSeparator1, 0, 3);
            this.tableLayoutPanel12.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel12.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.LBL_TotalDist, 2, 2);
            this.tableLayoutPanel12.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.LBL_TraveledDist, 1, 2);
            this.tableLayoutPanel12.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel12.Controls.Add(this.LBL_MissionCompleted, 0, 2);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            // 
            // LBL_TimeRemain
            // 
            this.LBL_TimeRemain.AutoEllipsis = true;
            resources.ApplyResources(this.LBL_TimeRemain, "LBL_TimeRemain");
            this.tableLayoutPanel12.SetColumnSpan(this.LBL_TimeRemain, 3);
            this.LBL_TimeRemain.Name = "LBL_TimeRemain";
            // 
            // lineSeparator1
            // 
            resources.ApplyResources(this.lineSeparator1, "lineSeparator1");
            this.tableLayoutPanel12.SetColumnSpan(this.lineSeparator1, 3);
            this.lineSeparator1.Name = "lineSeparator1";
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            resources.ApplyResources(this.label17, "label17");
            this.tableLayoutPanel12.SetColumnSpan(this.label17, 3);
            this.label17.Name = "label17";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            resources.ApplyResources(this.label7, "label7");
            this.tableLayoutPanel12.SetColumnSpan(this.label7, 3);
            this.label7.Name = "label7";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // LBL_TotalDist
            // 
            this.LBL_TotalDist.AutoEllipsis = true;
            resources.ApplyResources(this.LBL_TotalDist, "LBL_TotalDist");
            this.LBL_TotalDist.Name = "LBL_TotalDist";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // LBL_TraveledDist
            // 
            this.LBL_TraveledDist.AutoEllipsis = true;
            resources.ApplyResources(this.LBL_TraveledDist, "LBL_TraveledDist");
            this.LBL_TraveledDist.Name = "LBL_TraveledDist";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // LBL_MissionCompleted
            // 
            this.LBL_MissionCompleted.AutoEllipsis = true;
            resources.ApplyResources(this.LBL_MissionCompleted, "LBL_MissionCompleted");
            this.LBL_MissionCompleted.Name = "LBL_MissionCompleted";
            // 
            // COMBJOY
            // 
            this.COMBJOY.FormattingEnabled = true;
            resources.ApplyResources(this.COMBJOY, "COMBJOY");
            this.COMBJOY.Name = "COMBJOY";
            // 
            // but_disablejoystick
            // 
            this.but_disablejoystick.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_disablejoystick.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_disablejoystick.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.but_disablejoystick, "but_disablejoystick");
            this.but_disablejoystick.Name = "but_disablejoystick";
            this.but_disablejoystick.TextColor = System.Drawing.Color.Empty;
            this.but_disablejoystick.UseVisualStyleBackColor = true;
            this.but_disablejoystick.Click += new System.EventHandler(this.but_disablejoystick_Click);
            // 
            // distanceBar1
            // 
            resources.ApplyResources(this.distanceBar1, "distanceBar1");
            this.distanceBar1.BackColor = System.Drawing.Color.Transparent;
            this.distanceBar1.Name = "distanceBar1";
            this.distanceBar1.totaldist = 100F;
            this.distanceBar1.traveleddist = 0F;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            this.label6.Tag = "custom";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Name = "label5";
            this.label5.Tag = "custom";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Name = "label3";
            this.label3.Tag = "custom";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            this.label4.Tag = "custom";
            // 
            // TRK_zoom
            // 
            resources.ApplyResources(this.TRK_zoom, "TRK_zoom");
            this.TRK_zoom.LargeChange = 1F;
            this.TRK_zoom.Maximum = 24F;
            this.TRK_zoom.Minimum = 1F;
            this.TRK_zoom.Name = "TRK_zoom";
            this.TRK_zoom.SmallChange = 1F;
            this.TRK_zoom.TickFrequency = 1F;
            this.TRK_zoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TRK_zoom.Value = 1F;
            this.TRK_zoom.Scroll += new System.EventHandler(this.TRK_zoom_Scroll);
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.Black;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.ContextMenuStrip = this.contextMenuStripMap;
            resources.ApplyResources(this.gMapControl1, "gMapControl1");
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Gray;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.HoldInvalidation = false;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 24;
            this.gMapControl1.MinZoom = 0;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Zoom = 3D;
            this.gMapControl1.OnPositionChanged += new GMap.NET.PositionChanged(this.gMapControl1_OnPositionChanged);
            this.gMapControl1.Click += new System.EventHandler(this.gMapControl1_Click);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseLeave += new System.EventHandler(this.gMapControl1_MouseLeave);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            this.gMapControl1.Resize += new System.EventHandler(this.gMapControl1_Resize);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.coords1);
            this.panel1.Controls.Add(this.Zoomlevel);
            this.panel1.Controls.Add(this.CHK_autopan);
            this.panel1.Controls.Add(this.CB_tuning);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHud, "armed", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            this.label19.Name = "label19";
            this.label19.TextChanged += new System.EventHandler(this.label19_TextChanged);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHud, "mode", true));
            this.label18.Name = "label18";
            this.label18.TextChanged += new System.EventHandler(this.label18_TextChanged);
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Alt", this.bindingSourceHud, "alt", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lat", this.bindingSourceHud, "lat", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lng", this.bindingSourceHud, "lng", true));
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Name = "coords1";
            this.coords1.Vertical = false;
            // 
            // tableLayoutPaneltlogs
            // 
            resources.ApplyResources(this.tableLayoutPaneltlogs, "tableLayoutPaneltlogs");
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_loadtelem, 0, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_playlog, 1, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.tracklog, 0, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPaneltlogs.Name = "tableLayoutPaneltlogs";
            // 
            // BUT_loadtelem
            // 
            this.BUT_loadtelem.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_loadtelem.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_loadtelem, "BUT_loadtelem");
            this.BUT_loadtelem.Name = "BUT_loadtelem";
            this.BUT_loadtelem.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_loadtelem.TextColor = System.Drawing.Color.Black;
            this.BUT_loadtelem.UseVisualStyleBackColor = true;
            this.BUT_loadtelem.Click += new System.EventHandler(this.BUT_loadtelem_Click);
            // 
            // tracklog
            // 
            this.tableLayoutPaneltlogs.SetColumnSpan(this.tracklog, 2);
            resources.ApplyResources(this.tracklog, "tracklog");
            this.tracklog.Maximum = 100;
            this.tracklog.Name = "tracklog";
            this.tracklog.TickFrequency = 5;
            this.tracklog.Scroll += new System.EventHandler(this.tracklog_Scroll);
            // 
            // BUT_playlog
            // 
            this.BUT_playlog.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_playlog.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_playlog, "BUT_playlog");
            this.BUT_playlog.Name = "BUT_playlog";
            this.BUT_playlog.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_playlog.TextColor = System.Drawing.Color.Black;
            this.BUT_playlog.UseVisualStyleBackColor = true;
            this.BUT_playlog.Click += new System.EventHandler(this.BUT_playlog_Click);
            // 
            // panel2
            // 
            this.tableLayoutPaneltlogs.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.BUT_speed10);
            this.panel2.Controls.Add(this.BUT_speed5);
            this.panel2.Controls.Add(this.BUT_speed2);
            this.panel2.Controls.Add(this.BUT_speed1);
            this.panel2.Controls.Add(this.BUT_speed1_2);
            this.panel2.Controls.Add(this.BUT_speed1_4);
            this.panel2.Controls.Add(this.BUT_speed1_10);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // BUT_speed10
            // 
            this.BUT_speed10.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_speed10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed10, "BUT_speed10");
            this.BUT_speed10.Name = "BUT_speed10";
            this.BUT_speed10.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_speed10.Tag = "10";
            this.BUT_speed10.TextColor = System.Drawing.Color.Black;
            this.BUT_speed10.UseVisualStyleBackColor = true;
            this.BUT_speed10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed5
            // 
            this.BUT_speed5.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_speed5.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed5, "BUT_speed5");
            this.BUT_speed5.Name = "BUT_speed5";
            this.BUT_speed5.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_speed5.Tag = "5";
            this.BUT_speed5.TextColor = System.Drawing.Color.Black;
            this.BUT_speed5.UseVisualStyleBackColor = true;
            this.BUT_speed5.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed2
            // 
            this.BUT_speed2.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_speed2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed2, "BUT_speed2");
            this.BUT_speed2.Name = "BUT_speed2";
            this.BUT_speed2.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_speed2.Tag = "2";
            this.BUT_speed2.TextColor = System.Drawing.Color.Black;
            this.BUT_speed2.UseVisualStyleBackColor = true;
            this.BUT_speed2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1
            // 
            this.BUT_speed1.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_speed1.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1, "BUT_speed1");
            this.BUT_speed1.Name = "BUT_speed1";
            this.BUT_speed1.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_speed1.Tag = "1";
            this.BUT_speed1.TextColor = System.Drawing.Color.Black;
            this.BUT_speed1.UseVisualStyleBackColor = true;
            this.BUT_speed1.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_2
            // 
            this.BUT_speed1_2.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_speed1_2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1_2, "BUT_speed1_2");
            this.BUT_speed1_2.Name = "BUT_speed1_2";
            this.BUT_speed1_2.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_speed1_2.Tag = "0.5";
            this.BUT_speed1_2.TextColor = System.Drawing.Color.Black;
            this.BUT_speed1_2.UseVisualStyleBackColor = true;
            this.BUT_speed1_2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_4
            // 
            this.BUT_speed1_4.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_speed1_4.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1_4, "BUT_speed1_4");
            this.BUT_speed1_4.Name = "BUT_speed1_4";
            this.BUT_speed1_4.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_speed1_4.Tag = "0.25";
            this.BUT_speed1_4.TextColor = System.Drawing.Color.Black;
            this.BUT_speed1_4.UseVisualStyleBackColor = true;
            this.BUT_speed1_4.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_10
            // 
            this.BUT_speed1_10.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_speed1_10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1_10, "BUT_speed1_10");
            this.BUT_speed1_10.Name = "BUT_speed1_10";
            this.BUT_speed1_10.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_speed1_10.Tag = "0.1";
            this.BUT_speed1_10.TextColor = System.Drawing.Color.Black;
            this.BUT_speed1_10.UseVisualStyleBackColor = true;
            this.BUT_speed1_10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // tableLayoutPanel11
            // 
            resources.ApplyResources(this.tableLayoutPanel11, "tableLayoutPanel11");
            this.tableLayoutPanel11.Controls.Add(this.NUM_DepthAlarmValue, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.BUT_MuteDepthAlarm, 0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            // 
            // NUM_DepthAlarmValue
            // 
            resources.ApplyResources(this.NUM_DepthAlarmValue, "NUM_DepthAlarmValue");
            this.NUM_DepthAlarmValue.DecimalPlaces = 2;
            this.NUM_DepthAlarmValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.NUM_DepthAlarmValue.Name = "NUM_DepthAlarmValue";
            this.NUM_DepthAlarmValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            131072});
            this.NUM_DepthAlarmValue.ValueChanged += new System.EventHandler(this.NUM_DepthAlarmValue_ValueChanged);
            // 
            // BUT_MuteDepthAlarm
            // 
            this.BUT_MuteDepthAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BUT_MuteDepthAlarm, "BUT_MuteDepthAlarm");
            this.BUT_MuteDepthAlarm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_MuteDepthAlarm.ImageList = this.imageList1;
            this.BUT_MuteDepthAlarm.Name = "BUT_MuteDepthAlarm";
            this.BUT_MuteDepthAlarm.UseVisualStyleBackColor = false;
            this.BUT_MuteDepthAlarm.Click += new System.EventHandler(this.BUT_Mute_Click);
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel7);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.CMB_setwp, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.BUT_setwp, 0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // CMB_setwp
            // 
            resources.ApplyResources(this.CMB_setwp, "CMB_setwp");
            this.CMB_setwp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_setwp.FormattingEnabled = true;
            this.CMB_setwp.Items.AddRange(new object[] {
            resources.GetString("CMB_setwp.Items")});
            this.CMB_setwp.Name = "CMB_setwp";
            this.CMB_setwp.Click += new System.EventHandler(this.CMB_setwp_Click);
            // 
            // BUT_setwp
            // 
            resources.ApplyResources(this.BUT_setwp, "BUT_setwp");
            this.BUT_setwp.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_setwp.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_setwp.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_setwp.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_setwp.Name = "BUT_setwp";
            this.BUT_setwp.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_setwp.TextColor = System.Drawing.Color.Black;
            this.BUT_setwp.Click += new System.EventHandler(this.BUT_setwp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.BUT_EchoGrab, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.BUT_StopGrab, 1, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // BUT_EchoGrab
            // 
            resources.ApplyResources(this.BUT_EchoGrab, "BUT_EchoGrab");
            this.BUT_EchoGrab.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_EchoGrab.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_EchoGrab.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_EchoGrab.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_EchoGrab.Name = "BUT_EchoGrab";
            this.BUT_EchoGrab.Outline = System.Drawing.Color.Black;
            this.BUT_EchoGrab.Tag = "";
            this.BUT_EchoGrab.TextColor = System.Drawing.Color.Black;
            this.BUT_EchoGrab.Click += new System.EventHandler(this.BUT_EchoGrab_Click);
            // 
            // BUT_StopGrab
            // 
            resources.ApplyResources(this.BUT_StopGrab, "BUT_StopGrab");
            this.BUT_StopGrab.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_StopGrab.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_StopGrab.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_StopGrab.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_StopGrab.Name = "BUT_StopGrab";
            this.BUT_StopGrab.TextColor = System.Drawing.Color.Black;
            this.BUT_StopGrab.Click += new System.EventHandler(this.BUT_StopGrab_Click);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.CurrentR_Indicator, 2, 5);
            this.tableLayoutPanel8.Controls.Add(this.Hum_R_Gauge, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.CurrentL_Indicator, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.Hum_L_Gauge, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.Hum_Body_Gauge, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.Temp_R_Gauge, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.Temp_L_Gauge, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.Temp_Body_Gauge, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.Bat_R_Gauge, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.Bat_L_Gauge, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.Bat_Body_Gauge, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.Depth_Gauge, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.Speed_Gauge, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel1, 1, 6);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel3, 2, 6);
            this.tableLayoutPanel8.Controls.Add(this.CurrentMain_Indicator, 0, 5);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // CurrentR_Indicator
            // 
            this.CurrentR_Indicator.AnimationEnabled = false;
            resources.ApplyResources(this.CurrentR_Indicator, "CurrentR_Indicator");
            this.CurrentR_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon1;
            this.CurrentR_Indicator.ErrorLimit = 8D;
            this.CurrentR_Indicator.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.CurrentR_Indicator.Maximum = 10D;
            this.CurrentR_Indicator.Name = "CurrentR_Indicator";
            this.CurrentR_Indicator.ResetValue = 0D;
            this.CurrentR_Indicator.ScaleFactor = 1D;
            this.CurrentR_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.CurrentR_Indicator.Title = "";
            this.CurrentR_Indicator.Unit = "Curr R";
            this.CurrentR_Indicator.Value = 0D;
            this.CurrentR_Indicator.ValueFormat = "0.0 A";
            this.CurrentR_Indicator.WarningLimit = 5D;
            // 
            // Hum_R_Gauge
            // 
            this.Hum_R_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Hum_R_Gauge, "Hum_R_Gauge");
            this.Hum_R_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Hum_R_Gauge.ErrorLimit = 70D;
            this.Hum_R_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Hum_R_Gauge.MajorTicks.Interval = 0D;
            this.Hum_R_Gauge.MajorTicks.MarkerLength = 5;
            this.Hum_R_Gauge.Maximum = 100D;
            this.Hum_R_Gauge.MinorTicks.Interval = 0D;
            this.Hum_R_Gauge.MinorTicks.MarkerLength = 5;
            this.Hum_R_Gauge.Name = "Hum_R_Gauge";
            this.Hum_R_Gauge.PointerEndAngle = 504;
            this.Hum_R_Gauge.PointerStartAngle = 216;
            this.Hum_R_Gauge.ResetValue = 0D;
            this.Hum_R_Gauge.ScaleFactor = 1D;
            this.Hum_R_Gauge.ScaleLabel.Interval = 10D;
            this.Hum_R_Gauge.SegmentCount = 50;
            this.Hum_R_Gauge.SegmentGap = 2;
            this.Hum_R_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Hum_R_Gauge.Title = "";
            this.Hum_R_Gauge.Unit = "Hum R";
            this.Hum_R_Gauge.Value = 1D;
            this.Hum_R_Gauge.ValueFormat = "0.0";
            this.Hum_R_Gauge.WarningLimit = 60D;
            // 
            // CurrentL_Indicator
            // 
            this.CurrentL_Indicator.AnimationEnabled = false;
            resources.ApplyResources(this.CurrentL_Indicator, "CurrentL_Indicator");
            this.CurrentL_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon1;
            this.CurrentL_Indicator.ErrorLimit = 8D;
            this.CurrentL_Indicator.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.CurrentL_Indicator.Maximum = 10D;
            this.CurrentL_Indicator.Name = "CurrentL_Indicator";
            this.CurrentL_Indicator.ResetValue = 0D;
            this.CurrentL_Indicator.ScaleFactor = 1D;
            this.CurrentL_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.CurrentL_Indicator.Title = "";
            this.CurrentL_Indicator.Unit = "Curr L";
            this.CurrentL_Indicator.Value = 0D;
            this.CurrentL_Indicator.ValueFormat = "0.0 A";
            this.CurrentL_Indicator.WarningLimit = 5D;
            // 
            // Hum_L_Gauge
            // 
            this.Hum_L_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Hum_L_Gauge, "Hum_L_Gauge");
            this.Hum_L_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Hum_L_Gauge.ErrorLimit = 70D;
            this.Hum_L_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Hum_L_Gauge.MajorTicks.Interval = 0D;
            this.Hum_L_Gauge.MajorTicks.MarkerLength = 5;
            this.Hum_L_Gauge.Maximum = 100D;
            this.Hum_L_Gauge.MinorTicks.Interval = 0D;
            this.Hum_L_Gauge.MinorTicks.MarkerLength = 5;
            this.Hum_L_Gauge.Name = "Hum_L_Gauge";
            this.Hum_L_Gauge.PointerEndAngle = 504;
            this.Hum_L_Gauge.PointerStartAngle = 216;
            this.Hum_L_Gauge.ResetValue = 0D;
            this.Hum_L_Gauge.ScaleFactor = 1D;
            this.Hum_L_Gauge.ScaleLabel.Interval = 10D;
            this.Hum_L_Gauge.SegmentCount = 50;
            this.Hum_L_Gauge.SegmentGap = 2;
            this.Hum_L_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Hum_L_Gauge.Title = "";
            this.Hum_L_Gauge.Unit = "Hum L";
            this.Hum_L_Gauge.Value = 1D;
            this.Hum_L_Gauge.ValueFormat = "0.0";
            this.Hum_L_Gauge.WarningLimit = 60D;
            // 
            // Hum_Body_Gauge
            // 
            this.Hum_Body_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Hum_Body_Gauge, "Hum_Body_Gauge");
            this.Hum_Body_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Hum_Body_Gauge.ErrorLimit = 70D;
            this.Hum_Body_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Hum_Body_Gauge.MajorTicks.Interval = 0D;
            this.Hum_Body_Gauge.MajorTicks.MarkerLength = 5;
            this.Hum_Body_Gauge.Maximum = 100D;
            this.Hum_Body_Gauge.MinorTicks.Interval = 0D;
            this.Hum_Body_Gauge.MinorTicks.MarkerLength = 5;
            this.Hum_Body_Gauge.Name = "Hum_Body_Gauge";
            this.Hum_Body_Gauge.PointerEndAngle = 504;
            this.Hum_Body_Gauge.PointerStartAngle = 216;
            this.Hum_Body_Gauge.ResetValue = 0D;
            this.Hum_Body_Gauge.ScaleFactor = 1D;
            this.Hum_Body_Gauge.ScaleLabel.Interval = 10D;
            this.Hum_Body_Gauge.SegmentCount = 50;
            this.Hum_Body_Gauge.SegmentGap = 2;
            this.Hum_Body_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Hum_Body_Gauge.Title = "";
            this.Hum_Body_Gauge.Unit = "Hum B";
            this.Hum_Body_Gauge.Value = 1D;
            this.Hum_Body_Gauge.ValueFormat = "0.0";
            this.Hum_Body_Gauge.WarningLimit = 60D;
            // 
            // Temp_R_Gauge
            // 
            this.Temp_R_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Temp_R_Gauge, "Temp_R_Gauge");
            this.Temp_R_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Temp_R_Gauge.ErrorLimit = 50D;
            this.Temp_R_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Temp_R_Gauge.MajorTicks.Interval = 0D;
            this.Temp_R_Gauge.MajorTicks.MarkerLength = 5;
            this.Temp_R_Gauge.Maximum = 100D;
            this.Temp_R_Gauge.MinorTicks.Interval = 0D;
            this.Temp_R_Gauge.MinorTicks.MarkerLength = 5;
            this.Temp_R_Gauge.Name = "Temp_R_Gauge";
            this.Temp_R_Gauge.PointerEndAngle = 504;
            this.Temp_R_Gauge.PointerStartAngle = 216;
            this.Temp_R_Gauge.ResetValue = 0D;
            this.Temp_R_Gauge.ScaleFactor = 1D;
            this.Temp_R_Gauge.ScaleLabel.Interval = 10D;
            this.Temp_R_Gauge.SegmentCount = 50;
            this.Temp_R_Gauge.SegmentGap = 2;
            this.Temp_R_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Temp_R_Gauge.Title = "";
            this.Temp_R_Gauge.Unit = "Tem R";
            this.Temp_R_Gauge.Value = 1D;
            this.Temp_R_Gauge.ValueFormat = "0.0";
            this.Temp_R_Gauge.WarningLimit = 40D;
            // 
            // Temp_L_Gauge
            // 
            this.Temp_L_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Temp_L_Gauge, "Temp_L_Gauge");
            this.Temp_L_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Temp_L_Gauge.ErrorLimit = 50D;
            this.Temp_L_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Temp_L_Gauge.MajorTicks.Interval = 0D;
            this.Temp_L_Gauge.MajorTicks.MarkerLength = 5;
            this.Temp_L_Gauge.Maximum = 100D;
            this.Temp_L_Gauge.MinorTicks.Interval = 0D;
            this.Temp_L_Gauge.MinorTicks.MarkerLength = 5;
            this.Temp_L_Gauge.Name = "Temp_L_Gauge";
            this.Temp_L_Gauge.PointerEndAngle = 504;
            this.Temp_L_Gauge.PointerStartAngle = 216;
            this.Temp_L_Gauge.ResetValue = 0D;
            this.Temp_L_Gauge.ScaleFactor = 1D;
            this.Temp_L_Gauge.ScaleLabel.Interval = 10D;
            this.Temp_L_Gauge.SegmentCount = 50;
            this.Temp_L_Gauge.SegmentGap = 2;
            this.Temp_L_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Temp_L_Gauge.Title = "";
            this.Temp_L_Gauge.Unit = "Tem L";
            this.Temp_L_Gauge.Value = 1D;
            this.Temp_L_Gauge.ValueFormat = "0.0";
            this.Temp_L_Gauge.WarningLimit = 40D;
            // 
            // Temp_Body_Gauge
            // 
            this.Temp_Body_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Temp_Body_Gauge, "Temp_Body_Gauge");
            this.Temp_Body_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Temp_Body_Gauge.ErrorLimit = 50D;
            this.Temp_Body_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Temp_Body_Gauge.MajorTicks.Interval = 0D;
            this.Temp_Body_Gauge.MajorTicks.MarkerLength = 5;
            this.Temp_Body_Gauge.Maximum = 100D;
            this.Temp_Body_Gauge.MinorTicks.Interval = 0D;
            this.Temp_Body_Gauge.MinorTicks.MarkerLength = 5;
            this.Temp_Body_Gauge.Name = "Temp_Body_Gauge";
            this.Temp_Body_Gauge.PointerEndAngle = 504;
            this.Temp_Body_Gauge.PointerStartAngle = 216;
            this.Temp_Body_Gauge.ResetValue = 0D;
            this.Temp_Body_Gauge.ScaleFactor = 1D;
            this.Temp_Body_Gauge.ScaleLabel.Interval = 10D;
            this.Temp_Body_Gauge.SegmentCount = 50;
            this.Temp_Body_Gauge.SegmentGap = 2;
            this.Temp_Body_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Temp_Body_Gauge.Title = "";
            this.Temp_Body_Gauge.Unit = "Tem B";
            this.Temp_Body_Gauge.Value = 1D;
            this.Temp_Body_Gauge.ValueFormat = "0.0";
            this.Temp_Body_Gauge.WarningLimit = 40D;
            // 
            // Bat_R_Gauge
            // 
            this.Bat_R_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Bat_R_Gauge, "Bat_R_Gauge");
            this.Bat_R_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Bat_R_Gauge.ErrorLimit = 10D;
            this.Bat_R_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Bat_R_Gauge.InvertLimit = true;
            this.Bat_R_Gauge.MajorTicks.Interval = 0D;
            this.Bat_R_Gauge.MajorTicks.MarkerLength = 5;
            this.Bat_R_Gauge.Maximum = 100D;
            this.Bat_R_Gauge.MinorTicks.Interval = 0D;
            this.Bat_R_Gauge.MinorTicks.MarkerLength = 5;
            this.Bat_R_Gauge.Name = "Bat_R_Gauge";
            this.Bat_R_Gauge.PointerEndAngle = 504;
            this.Bat_R_Gauge.PointerStartAngle = 216;
            this.Bat_R_Gauge.ResetValue = 0D;
            this.Bat_R_Gauge.ScaleFactor = 1D;
            this.Bat_R_Gauge.ScaleLabel.Interval = 10D;
            this.Bat_R_Gauge.SegmentCount = 50;
            this.Bat_R_Gauge.SegmentGap = 2;
            this.Bat_R_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Bat_R_Gauge.Title = "";
            this.Bat_R_Gauge.Unit = "Bat R";
            this.Bat_R_Gauge.Value = 1D;
            this.Bat_R_Gauge.ValueFormat = "0 \"%\"";
            this.Bat_R_Gauge.WarningLimit = 30D;
            // 
            // Bat_L_Gauge
            // 
            this.Bat_L_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Bat_L_Gauge, "Bat_L_Gauge");
            this.Bat_L_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Bat_L_Gauge.ErrorLimit = 10D;
            this.Bat_L_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Bat_L_Gauge.InvertLimit = true;
            this.Bat_L_Gauge.MajorTicks.Interval = 0D;
            this.Bat_L_Gauge.MajorTicks.MarkerLength = 5;
            this.Bat_L_Gauge.Maximum = 100D;
            this.Bat_L_Gauge.MinorTicks.Interval = 0D;
            this.Bat_L_Gauge.MinorTicks.MarkerLength = 5;
            this.Bat_L_Gauge.Name = "Bat_L_Gauge";
            this.Bat_L_Gauge.PointerEndAngle = 504;
            this.Bat_L_Gauge.PointerStartAngle = 216;
            this.Bat_L_Gauge.ResetValue = 0D;
            this.Bat_L_Gauge.ScaleFactor = 1D;
            this.Bat_L_Gauge.ScaleLabel.Interval = 10D;
            this.Bat_L_Gauge.SegmentCount = 50;
            this.Bat_L_Gauge.SegmentGap = 2;
            this.Bat_L_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Bat_L_Gauge.Title = "";
            this.Bat_L_Gauge.Unit = "Bat L";
            this.Bat_L_Gauge.Value = 1D;
            this.Bat_L_Gauge.ValueFormat = "0 \"%\"";
            this.Bat_L_Gauge.WarningLimit = 30D;
            // 
            // Depth_Gauge
            // 
            this.Depth_Gauge.AnimationStep = 1;
            this.Depth_Gauge.AnimationUpdateInterval = 20;
            this.Depth_Gauge.BottomBarHeight = 5;
            this.tableLayoutPanel8.SetColumnSpan(this.Depth_Gauge, 3);
            resources.ApplyResources(this.Depth_Gauge, "Depth_Gauge");
            this.Depth_Gauge.ErrorLimit = 0.1D;
            this.Depth_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Depth_Gauge.InvertLimit = true;
            this.Depth_Gauge.LabelWidth = 100;
            this.Depth_Gauge.Maximum = 1D;
            this.Depth_Gauge.Name = "Depth_Gauge";
            this.Depth_Gauge.PeakVisible = true;
            this.Depth_Gauge.ResetValue = 0D;
            this.Depth_Gauge.ScaleFactor = 1D;
            this.Depth_Gauge.SegmentGap = 2;
            this.Depth_Gauge.SegmentSize = 4;
            this.Depth_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.NotDefined;
            this.Depth_Gauge.Title = "Depth (0 - 1m)";
            this.Depth_Gauge.Unit = "m";
            this.Depth_Gauge.Value = 0D;
            this.Depth_Gauge.ValueFormat = "0.00";
            this.Depth_Gauge.WarningLimit = 0.5D;
            // 
            // Speed_Gauge
            // 
            this.Speed_Gauge.AnimationStep = 1;
            this.Speed_Gauge.AnimationUpdateInterval = 20;
            this.Speed_Gauge.BottomBarHeight = 5;
            this.tableLayoutPanel8.SetColumnSpan(this.Speed_Gauge, 3);
            this.Speed_Gauge.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceHud, "groundspeed", true));
            resources.ApplyResources(this.Speed_Gauge, "Speed_Gauge");
            this.Speed_Gauge.ErrorLimit = 0.3D;
            this.Speed_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Speed_Gauge.Maximum = 0.3D;
            this.Speed_Gauge.Name = "Speed_Gauge";
            this.Speed_Gauge.PeakVisible = true;
            this.Speed_Gauge.ResetValue = 0D;
            this.Speed_Gauge.ScaleFactor = 1D;
            this.Speed_Gauge.SegmentGap = 2;
            this.Speed_Gauge.SegmentSize = 4;
            this.Speed_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Speed_Gauge.Title = "Speed";
            this.Speed_Gauge.Unit = "m/s";
            this.Speed_Gauge.Value = 0.1D;
            this.Speed_Gauge.ValueFormat = "0.0";
            this.Speed_Gauge.WarningLimit = 0.2D;
            this.Speed_Gauge.ErrorLimitReached += new System.EventHandler(this.Speed_Gauge_ErrorLimitReached);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.progressBarL_Down, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBarL_Up, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // progressBarL_Down
            // 
            this.progressBarL_Down.AnimationStep = 100;
            resources.ApplyResources(this.progressBarL_Down, "progressBarL_Down");
            this.progressBarL_Down.IgnoreLimits = true;
            this.progressBarL_Down.InvertLimit = true;
            this.progressBarL_Down.Maximum = 1500D;
            this.progressBarL_Down.Minimum = 1000D;
            this.progressBarL_Down.Name = "progressBarL_Down";
            this.progressBarL_Down.Orientation = CodeArtEng.Gauge.PanelGauges.LinearIndicatorOrientation.RightToLeft;
            this.progressBarL_Down.ResetValue = 0D;
            this.progressBarL_Down.ScaleFactor = 1D;
            this.progressBarL_Down.SegmentGap = 1;
            this.progressBarL_Down.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.progressBarL_Down.Title = "";
            this.progressBarL_Down.Unit = "A";
            this.progressBarL_Down.Value = 1100D;
            // 
            // progressBarL_Up
            // 
            this.progressBarL_Up.AnimationStep = 100;
            resources.ApplyResources(this.progressBarL_Up, "progressBarL_Up");
            this.progressBarL_Up.IgnoreLimits = true;
            this.progressBarL_Up.InvertLimit = true;
            this.progressBarL_Up.Maximum = 2000D;
            this.progressBarL_Up.Minimum = 1500D;
            this.progressBarL_Up.Name = "progressBarL_Up";
            this.progressBarL_Up.ResetValue = 0D;
            this.progressBarL_Up.ScaleFactor = 1D;
            this.progressBarL_Up.SegmentGap = 1;
            this.progressBarL_Up.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.progressBarL_Up.Title = "";
            this.progressBarL_Up.Unit = "km/h";
            this.progressBarL_Up.Value = 1600D;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.tableLayoutPanel1.SetColumnSpan(this.label11, 2);
            this.label11.Name = "label11";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.progressBarR_Down, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.progressBarR_Up, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // progressBarR_Down
            // 
            this.progressBarR_Down.AnimationStep = 100;
            resources.ApplyResources(this.progressBarR_Down, "progressBarR_Down");
            this.progressBarR_Down.IgnoreLimits = true;
            this.progressBarR_Down.InvertLimit = true;
            this.progressBarR_Down.Maximum = 1500D;
            this.progressBarR_Down.Minimum = 1000D;
            this.progressBarR_Down.Name = "progressBarR_Down";
            this.progressBarR_Down.Orientation = CodeArtEng.Gauge.PanelGauges.LinearIndicatorOrientation.RightToLeft;
            this.progressBarR_Down.ResetValue = 0D;
            this.progressBarR_Down.ScaleFactor = 1D;
            this.progressBarR_Down.SegmentGap = 1;
            this.progressBarR_Down.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.progressBarR_Down.Title = "";
            this.progressBarR_Down.Unit = "km/h";
            this.progressBarR_Down.Value = 1100D;
            // 
            // progressBarR_Up
            // 
            this.progressBarR_Up.AnimationStep = 100;
            resources.ApplyResources(this.progressBarR_Up, "progressBarR_Up");
            this.progressBarR_Up.IgnoreLimits = true;
            this.progressBarR_Up.InvertLimit = true;
            this.progressBarR_Up.Maximum = 2000D;
            this.progressBarR_Up.Minimum = 1500D;
            this.progressBarR_Up.Name = "progressBarR_Up";
            this.progressBarR_Up.ResetValue = 0D;
            this.progressBarR_Up.ScaleFactor = 1D;
            this.progressBarR_Up.SegmentGap = 1;
            this.progressBarR_Up.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.progressBarR_Up.Title = "";
            this.progressBarR_Up.Unit = "km/h";
            this.progressBarR_Up.Value = 1600D;
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.tableLayoutPanel3.SetColumnSpan(this.label20, 2);
            this.label20.Name = "label20";
            // 
            // CurrentMain_Indicator
            // 
            this.CurrentMain_Indicator.AnimationEnabled = false;
            this.CurrentMain_Indicator.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceHud, "current", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            resources.ApplyResources(this.CurrentMain_Indicator, "CurrentMain_Indicator");
            this.CurrentMain_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon1;
            this.CurrentMain_Indicator.ErrorLimit = 8D;
            this.CurrentMain_Indicator.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.CurrentMain_Indicator.Maximum = 10D;
            this.CurrentMain_Indicator.Name = "CurrentMain_Indicator";
            this.CurrentMain_Indicator.ResetValue = 0D;
            this.CurrentMain_Indicator.ScaleFactor = 1D;
            this.CurrentMain_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.CurrentMain_Indicator.Title = "";
            this.CurrentMain_Indicator.Unit = "Curr B";
            this.CurrentMain_Indicator.Value = 0D;
            this.CurrentMain_Indicator.ValueFormat = "0.0 A";
            this.CurrentMain_Indicator.WarningLimit = 5D;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.Link_Quality_Indicator, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.Dist_To_Home_Indicator, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.BUT_manual, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.BUT_quickrtl, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BUTrestartmission, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BUT_clear_track, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.BUT_quickauto, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BUT_ARM, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // Link_Quality_Indicator
            // 
            this.Link_Quality_Indicator.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceHud, "linkqualitygcs", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            resources.ApplyResources(this.Link_Quality_Indicator, "Link_Quality_Indicator");
            this.Link_Quality_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon2;
            this.Link_Quality_Indicator.ErrorLimit = 25D;
            this.Link_Quality_Indicator.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Link_Quality_Indicator.InvertLimit = true;
            this.Link_Quality_Indicator.Maximum = 100D;
            this.Link_Quality_Indicator.Name = "Link_Quality_Indicator";
            this.Link_Quality_Indicator.ResetValue = 0D;
            this.Link_Quality_Indicator.ScaleFactor = 1D;
            this.Link_Quality_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Link_Quality_Indicator.Title = "";
            this.Link_Quality_Indicator.Unit = "Link";
            this.Link_Quality_Indicator.Value = 1D;
            this.Link_Quality_Indicator.ValueFormat = "0 \"%\"";
            this.Link_Quality_Indicator.WarningLimit = 40D;
            // 
            // Dist_To_Home_Indicator
            // 
            this.Dist_To_Home_Indicator.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceHud, "DistToHome", true));
            resources.ApplyResources(this.Dist_To_Home_Indicator, "Dist_To_Home_Indicator");
            this.Dist_To_Home_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon1;
            this.Dist_To_Home_Indicator.ErrorLimit = 1000D;
            this.Dist_To_Home_Indicator.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Dist_To_Home_Indicator.Name = "Dist_To_Home_Indicator";
            this.Dist_To_Home_Indicator.ResetValue = 0D;
            this.Dist_To_Home_Indicator.ScaleFactor = 1D;
            this.Dist_To_Home_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Dist_To_Home_Indicator.Title = "";
            this.Dist_To_Home_Indicator.Unit = "Dist to H";
            this.Dist_To_Home_Indicator.Value = 1D;
            this.Dist_To_Home_Indicator.ValueFormat = "0 m";
            this.Dist_To_Home_Indicator.WarningLimit = 500D;
            // 
            // BUT_manual
            // 
            resources.ApplyResources(this.BUT_manual, "BUT_manual");
            this.BUT_manual.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_manual.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_manual.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_manual.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_manual.Name = "BUT_manual";
            this.BUT_manual.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_manual.TextColor = System.Drawing.Color.Black;
            this.BUT_manual.Click += new System.EventHandler(this.BUT_manual_Click);
            // 
            // BUT_quickrtl
            // 
            resources.ApplyResources(this.BUT_quickrtl, "BUT_quickrtl");
            this.BUT_quickrtl.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_quickrtl.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickrtl.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickrtl.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_quickrtl.Name = "BUT_quickrtl";
            this.BUT_quickrtl.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_quickrtl.TextColor = System.Drawing.Color.Black;
            this.BUT_quickrtl.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // BUTrestartmission
            // 
            resources.ApplyResources(this.BUTrestartmission, "BUTrestartmission");
            this.BUTrestartmission.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUTrestartmission.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUTrestartmission.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUTrestartmission.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUTrestartmission.Name = "BUTrestartmission";
            this.BUTrestartmission.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUTrestartmission.TextColor = System.Drawing.Color.Black;
            this.BUTrestartmission.Click += new System.EventHandler(this.BUTrestartmission_Click);
            // 
            // BUT_clear_track
            // 
            resources.ApplyResources(this.BUT_clear_track, "BUT_clear_track");
            this.BUT_clear_track.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_clear_track.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_clear_track.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_clear_track.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_clear_track.Name = "BUT_clear_track";
            this.BUT_clear_track.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_clear_track.TextColor = System.Drawing.Color.Black;
            this.BUT_clear_track.Click += new System.EventHandler(this.BUT_clear_track_Click);
            // 
            // BUT_quickauto
            // 
            resources.ApplyResources(this.BUT_quickauto, "BUT_quickauto");
            this.BUT_quickauto.BackColor = System.Drawing.SystemColors.Control;
            this.BUT_quickauto.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_quickauto.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_quickauto.ForeColor = System.Drawing.Color.White;
            this.BUT_quickauto.Name = "BUT_quickauto";
            this.BUT_quickauto.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_quickauto.TextColor = System.Drawing.Color.Black;
            this.BUT_quickauto.UseVisualStyleBackColor = true;
            this.BUT_quickauto.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // BUT_ARM
            // 
            resources.ApplyResources(this.BUT_ARM, "BUT_ARM");
            this.BUT_ARM.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BUT_ARM.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BUT_ARM.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_ARM.Name = "BUT_ARM";
            this.BUT_ARM.Outline = System.Drawing.Color.Black;
            this.BUT_ARM.TextColor = System.Drawing.Color.Black;
            this.BUT_ARM.Click += new System.EventHandler(this.BUT_ARM_Click);
            // 
            // Storage_Gauge
            // 
            this.Storage_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Storage_Gauge, "Storage_Gauge");
            this.Storage_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.SegmentMultiColor;
            this.Storage_Gauge.ErrorLimit = 95D;
            this.Storage_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Storage_Gauge.MajorTicks.Interval = 0D;
            this.Storage_Gauge.MajorTicks.MarkerLength = 5;
            this.Storage_Gauge.Maximum = 100D;
            this.Storage_Gauge.MinorTicks.Interval = 0D;
            this.Storage_Gauge.MinorTicks.MarkerLength = 5;
            this.Storage_Gauge.Name = "Storage_Gauge";
            this.Storage_Gauge.PointerEndAngle = 504;
            this.Storage_Gauge.PointerStartAngle = 216;
            this.Storage_Gauge.ResetValue = 0D;
            this.Storage_Gauge.ScaleFactor = 1D;
            this.Storage_Gauge.ScaleLabel.Interval = 10D;
            this.Storage_Gauge.SegmentCount = 20;
            this.Storage_Gauge.SegmentGap = 3;
            this.Storage_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Storage_Gauge.Title = "";
            this.Storage_Gauge.Unit = "Mem";
            this.Storage_Gauge.Value = 1D;
            this.Storage_Gauge.ValueFormat = "0 \"%\"";
            this.Storage_Gauge.WarningLimit = 80D;
            // 
            // tableLayoutPanel15
            // 
            resources.ApplyResources(this.tableLayoutPanel15, "tableLayoutPanel15");
            this.tableLayoutPanel15.Controls.Add(this.Storage_Gauge, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.Satellites_Gauge, 0, 1);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            // 
            // Satellites_Gauge
            // 
            this.Satellites_Gauge.AnimationEnabled = false;
            resources.ApplyResources(this.Satellites_Gauge, "Satellites_Gauge");
            this.Satellites_Gauge.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceHud, "satcount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.Satellites_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.Satellites_Gauge.ErrorLimit = 5D;
            this.Satellites_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            this.Satellites_Gauge.InvertLimit = true;
            this.Satellites_Gauge.MajorTicks.Interval = 0D;
            this.Satellites_Gauge.MajorTicks.MarkerLength = 5;
            this.Satellites_Gauge.Maximum = 30D;
            this.Satellites_Gauge.MinorTicks.Interval = 0D;
            this.Satellites_Gauge.MinorTicks.MarkerLength = 5;
            this.Satellites_Gauge.Name = "Satellites_Gauge";
            this.Satellites_Gauge.PointerEndAngle = 504;
            this.Satellites_Gauge.PointerStartAngle = 216;
            this.Satellites_Gauge.ResetValue = 0D;
            this.Satellites_Gauge.ScaleFactor = 1D;
            this.Satellites_Gauge.ScaleLabel.Interval = 10D;
            this.Satellites_Gauge.SegmentCount = 36;
            this.Satellites_Gauge.SegmentGap = 3;
            this.Satellites_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.Satellites_Gauge.Title = "";
            this.Satellites_Gauge.Unit = "# Sat";
            this.Satellites_Gauge.Value = 1D;
            this.Satellites_Gauge.WarningLimit = 8D;
            // 
            // hud1
            // 
            this.hud1.airspeed = 0F;
            this.hud1.alt = 0F;
            this.hud1.altunit = null;
            this.hud1.AOA = 0F;
            resources.ApplyResources(this.hud1, "hud1");
            this.hud1.BackColor = System.Drawing.Color.Black;
            this.hud1.batterylevel = 0F;
            this.hud1.batteryon = false;
            this.hud1.batteryremaining = 50F;
            this.hud1.bgimage = null;
            this.hud1.connected = false;
            this.hud1.critAOA = 25F;
            this.hud1.critSSA = 30F;
            this.hud1.current = 0F;
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.bindingSourceHud, "airspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("alt", this.bindingSourceHud, "alt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("AOA", this.bindingSourceHud, "AOA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel", this.bindingSourceHud, "battery_voltage", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("connected", this.bindingSourceHud, "connected", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("critAOA", this.bindingSourceHud, "crit_AOA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("current", this.bindingSourceHud, "current", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("datetime", this.bindingSourceHud, "datetime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("disttowp", this.bindingSourceHud, "wp_dist", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("ekfstatus", this.bindingSourceHud, "ekfstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("failsafe", this.bindingSourceHud, "failsafe", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix", this.bindingSourceHud, "gpsstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix2", this.bindingSourceHud, "gpsstatus2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop", this.bindingSourceHud, "gpshdop", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop2", this.bindingSourceHud, "gpshdop2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundalt", this.bindingSourceHud, "HomeAlt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundcourse", this.bindingSourceHud, "groundcourse", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundspeed", this.bindingSourceHud, "groundspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("heading", this.bindingSourceHud, "yaw", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("linkqualitygcs", this.bindingSourceHud, "linkqualitygcs", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("message", this.bindingSourceHud, "messageHigh", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("mode", this.bindingSourceHud, "mode", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navpitch", this.bindingSourceHud, "nav_pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navroll", this.bindingSourceHud, "nav_roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("pitch", this.bindingSourceHud, "pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("roll", this.bindingSourceHud, "roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("SSA", this.bindingSourceHud, "SSA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("status", this.bindingSourceHud, "armed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetalt", this.bindingSourceHud, "targetalt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetheading", this.bindingSourceHud, "nav_bearing", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetspeed", this.bindingSourceHud, "targetairspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("turnrate", this.bindingSourceHud, "turnrate", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("verticalspeed", this.bindingSourceHud, "verticalspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibex", this.bindingSourceHud, "vibex", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibey", this.bindingSourceHud, "vibey", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibez", this.bindingSourceHud, "vibez", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("wpno", this.bindingSourceHud, "wpno", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("xtrack_error", this.bindingSourceHud, "xtrack_error", true));
            this.hud1.datetime = new System.DateTime(((long)(0)));
            this.hud1.displayAOASSA = false;
            this.hud1.displayconninfo = false;
            this.hud1.displayheading = false;
            this.hud1.displayspeed = false;
            this.hud1.displayvibe = false;
            this.hud1.displayxtrack = false;
            this.hud1.disttowp = 0F;
            this.hud1.distunit = null;
            this.hud1.ekfstatus = 0F;
            this.hud1.failsafe = false;
            this.hud1.gpsfix = 0F;
            this.hud1.gpsfix2 = 0F;
            this.hud1.gpshdop = 0F;
            this.hud1.gpshdop2 = 0F;
            this.hud1.groundalt = 0F;
            this.hud1.groundcourse = 0F;
            this.hud1.groundspeed = 0F;
            this.hud1.heading = 0F;
            this.hud1.hudcolor = System.Drawing.Color.LightGray;
            this.hud1.linkqualitygcs = 0F;
            this.hud1.lowairspeed = false;
            this.hud1.lowgroundspeed = false;
            this.hud1.lowvoltagealert = true;
            this.hud1.message = "";
            this.hud1.messagetime = new System.DateTime(((long)(0)));
            this.hud1.mode = "Unknown";
            this.hud1.Name = "hud1";
            this.hud1.navpitch = 0F;
            this.hud1.navroll = 0F;
            this.hud1.pitch = 0F;
            this.hud1.roll = 0F;
            this.hud1.Russian = true;
            this.hud1.skyColor1 = System.Drawing.Color.Blue;
            this.hud1.skyColor2 = System.Drawing.Color.LightBlue;
            this.hud1.speedunit = null;
            this.hud1.SSA = 0F;
            this.hud1.status = false;
            this.hud1.streamjpg = null;
            this.hud1.targetalt = 0F;
            this.hud1.targetheading = 0F;
            this.hud1.targetspeed = 0F;
            this.hud1.turnrate = 0F;
            this.hud1.verticalspeed = 0F;
            this.hud1.vibex = 0F;
            this.hud1.vibey = 0F;
            this.hud1.vibez = 0F;
            this.hud1.VSync = false;
            this.hud1.wpno = 0;
            this.hud1.xtrack_error = 0F;
            this.hud1.ekfclick += new System.EventHandler(this.hud1_ekfclick);
            this.hud1.vibeclick += new System.EventHandler(this.hud1_vibeclick);
            this.hud1.DoubleClick += new System.EventHandler(this.hud1_DoubleClick);
            // 
            // MainH
            // 
            resources.ApplyResources(this.MainH, "MainH");
            this.MainH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainH.Name = "MainH";
            // 
            // MainH.Panel1
            // 
            this.MainH.Panel1.Controls.Add(this.tableLayoutPanel13);
            // 
            // MainH.Panel2
            // 
            this.MainH.Panel2.Controls.Add(this.tableMap);
            // 
            // tableLayoutPanel13
            // 
            resources.ApplyResources(this.tableLayoutPanel13, "tableLayoutPanel13");
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel11, 0, 4);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPaneltlogs, 0, 5);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            // 
            // tableLayoutPanel14
            // 
            resources.ApplyResources(this.tableLayoutPanel14, "tableLayoutPanel14");
            this.tableLayoutPanel14.Controls.Add(this.hud1, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel15, 1, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            // 
            // ZedGraphTimer
            // 
            this.ZedGraphTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.AutoEllipsis = true;
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // BUT_EchoGrab_BlinkTimer
            // 
            this.BUT_EchoGrab_BlinkTimer.Interval = 500;
            this.BUT_EchoGrab_BlinkTimer.Tick += new System.EventHandler(this.BUT_EchoGrab_BlinkTimer_Tick);
            // 
            // PingTimer
            // 
            this.PingTimer.Enabled = true;
            this.PingTimer.Interval = 2000;
            this.PingTimer.Tick += new System.EventHandler(this.PingTimer_Tick);
            // 
            // FlightData
            // 
            this.Controls.Add(this.MainH);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightData_FormClosing);
            this.Load += new System.EventHandler(this.FlightData_Load);
            this.Resize += new System.EventHandler(this.FlightData_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).EndInit();
            this.contextMenuStripMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).EndInit();
            this.tableMap.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPaneltlogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_DepthAlarmValue)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.MainH.Panel1.ResumeLayout(false);
            this.MainH.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).EndInit();
            this.MainH.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolStripMenuItem goHereToolStripMenuItem1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem pointCameraHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flyToHereAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightPlannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerCameraToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSourceHud;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PointCameraCoordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onOffCameraOverlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altitudeAngelSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEKFHomeHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem2;
        private System.Windows.Forms.Timer TimerUpdateSecondMAV;
        private System.Windows.Forms.Timer depthAlertTimer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TableLayoutPanel tableMap;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ZedGraph.ZedGraphControl zg1;
        private System.Windows.Forms.ComboBox COMBJOY;
        private Controls.MyButton but_disablejoystick;
        private Controls.DistanceBar distanceBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public Controls.myGMAP gMapControl1;
        private Controls.MyTrackBar TRK_zoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private Controls.Coords coords1;
        private System.Windows.Forms.NumericUpDown Zoomlevel;
        private System.Windows.Forms.CheckBox CHK_autopan;
        private System.Windows.Forms.CheckBox CB_tuning;
        private Controls.HUD hud1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Controls.MyButton BUT_manual;
        private Controls.MyButton BUT_quickauto;
        private Controls.MyButton BUT_quickrtl;
        private Controls.MyButton BUTrestartmission;
        private Controls.MyButton BUT_clear_track;
        private Controls.MyButton BUT_ARM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ComboBox CMB_setwp;
        private Controls.MyButton BUT_setwp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private Controls.MyButton BUT_EchoGrab;
        private Controls.MyButton BUT_StopGrab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.NumericUpDown NUM_DepthAlarmValue;
        private System.Windows.Forms.Button BUT_MuteDepthAlarm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneltlogs;
        private Controls.MyButton BUT_loadtelem;
        private System.Windows.Forms.TrackBar tracklog;
        private Controls.MyButton BUT_playlog;
        private System.Windows.Forms.Panel panel2;
        private Controls.MyButton BUT_speed10;
        private Controls.MyButton BUT_speed5;
        private Controls.MyButton BUT_speed2;
        private Controls.MyButton BUT_speed1;
        private Controls.MyButton BUT_speed1_2;
        private Controls.MyButton BUT_speed1_4;
        private Controls.MyButton BUT_speed1_10;
        private System.Windows.Forms.SplitContainer MainH;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBL_TimeRemain;
        private Controls.LineSeparator lineSeparator1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LBL_TotalDist;
        private System.Windows.Forms.Label LBL_TraveledDist;
        private System.Windows.Forms.Label LBL_MissionCompleted;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer BUT_EchoGrab_BlinkTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private CodeArtEng.Gauge.CircularGauge Storage_Gauge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private CodeArtEng.Gauge.CircularGauge Satellites_Gauge;
        private CodeArtEng.Gauge.LinearGauge Speed_Gauge;
        private CodeArtEng.Gauge.LinearGauge Depth_Gauge;
        private CodeArtEng.Gauge.CircularGauge Bat_Body_Gauge;
        private CodeArtEng.Gauge.CircularGauge Hum_R_Gauge;
        private CodeArtEng.Gauge.CircularGauge Hum_L_Gauge;
        private CodeArtEng.Gauge.CircularGauge Hum_Body_Gauge;
        private CodeArtEng.Gauge.CircularGauge Temp_R_Gauge;
        private CodeArtEng.Gauge.CircularGauge Temp_L_Gauge;
        private CodeArtEng.Gauge.CircularGauge Temp_Body_Gauge;
        private CodeArtEng.Gauge.CircularGauge Bat_R_Gauge;
        private CodeArtEng.Gauge.CircularGauge Bat_L_Gauge;
        private CodeArtEng.Gauge.RectangleIndicator Dist_To_Home_Indicator;
        private CodeArtEng.Gauge.RectangleIndicator Link_Quality_Indicator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator progressBarL_Down;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator progressBarL_Up;
        private CodeArtEng.Gauge.RectangleIndicator CurrentR_Indicator;
        private CodeArtEng.Gauge.RectangleIndicator CurrentL_Indicator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator progressBarR_Down;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator progressBarR_Up;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private CodeArtEng.Gauge.RectangleIndicator CurrentMain_Indicator;
        private Controls.MyButton BUT_ClearEchoData;
        private Controls.MyButton BUT_DownloadEchoData;
        private System.Windows.Forms.Timer PingTimer;
    }
}