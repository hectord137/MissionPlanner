namespace MissionPlanner.GCSViews
{
    partial class FlightData
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainH = new System.Windows.Forms.SplitContainer();
            this.SubMainLeft = new System.Windows.Forms.SplitContainer();
            this.hud1 = new MissionPlanner.Controls.HUD();
            this.contextMenuStripHud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordHudToAVIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMJPEGSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGStreamerSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hereLinkVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gStreamerStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAspectRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianHudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapWithMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceHud = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlactions = new System.Windows.Forms.TabControl();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_resumemis = new MissionPlanner.Controls.MyButton();
            this.BUT_manual = new MissionPlanner.Controls.MyButton();
            this.BUT_quickauto = new MissionPlanner.Controls.MyButton();
            this.BUT_loiter = new MissionPlanner.Controls.MyButton();
            this.BUT_quickrtl = new MissionPlanner.Controls.MyButton();
            this.BUTrestartmission = new MissionPlanner.Controls.MyButton();
            this.BUT_clear_track = new MissionPlanner.Controls.MyButton();
            this.BUT_ARM = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.CMB_setwp = new System.Windows.Forms.ComboBox();
            this.BUT_setwp = new MissionPlanner.Controls.MyButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ButJoyOn = new MissionPlanner.Controls.MyButton();
            this.BUT_joystick_settings = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.verticalProgressBarR_DOWN = new MissionPlanner.Controls.VerticalProgressBar2();
            this.bindingSourceQuickTab = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.verticalProgressBarR_UP = new MissionPlanner.Controls.VerticalProgressBar2();
            this.label12 = new System.Windows.Forms.Label();
            this.verticalProgressBarL_DOWN = new MissionPlanner.Controls.VerticalProgressBar2();
            this.verticalProgressBarL_UP = new MissionPlanner.Controls.VerticalProgressBar2();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LBL_DisToHome = new System.Windows.Forms.Label();
            this.LBL_Depth = new System.Windows.Forms.Label();
            this.LBL_GSpeed = new System.Windows.Forms.Label();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Humidity = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LBL_Temp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LBL_SatNumber = new System.Windows.Forms.Label();
            this.lineSeparator3 = new MissionPlanner.Controls.LineSeparator();
            this.tabTLogs = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPaneltlogs = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_loadtelem = new MissionPlanner.Controls.MyButton();
            this.tracklog = new System.Windows.Forms.TrackBar();
            this.BUT_log2kml = new MissionPlanner.Controls.MyButton();
            this.BUT_playlog = new MissionPlanner.Controls.MyButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BUT_speed10 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed5 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_4 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_10 = new MissionPlanner.Controls.MyButton();
            this.tableMap = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.zg1 = new ZedGraph.ZedGraphControl();
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
            this.lineSeparator1 = new MissionPlanner.Controls.LineSeparator();
            this.COMBJOY = new System.Windows.Forms.ComboBox();
            this.but_disablejoystick = new MissionPlanner.Controls.MyButton();
            this.distanceBar1 = new MissionPlanner.Controls.DistanceBar();
            this.windDir1 = new MissionPlanner.Controls.WindDir();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gMapControl1 = new MissionPlanner.Controls.myGMAP();
            this.TRK_zoom = new MissionPlanner.Controls.MyTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxMapTypeData = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.Zoomlevel = new System.Windows.Forms.NumericUpDown();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
            this.CB_tuning = new System.Windows.Forms.CheckBox();
            this.ZedGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TimerUpdateSecondMAV = new System.Windows.Forms.Timer(this.components);
            this.depthChartTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).BeginInit();
            this.MainH.Panel1.SuspendLayout();
            this.MainH.Panel2.SuspendLayout();
            this.MainH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).BeginInit();
            this.SubMainLeft.Panel1.SuspendLayout();
            this.SubMainLeft.Panel2.SuspendLayout();
            this.SubMainLeft.SuspendLayout();
            this.contextMenuStripHud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).BeginInit();
            this.tabControlactions.SuspendLayout();
            this.tabActions.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tabTLogs.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPaneltlogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).BeginInit();
            this.SuspendLayout();
            // 
            // MainH
            // 
            this.MainH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.MainH, "MainH");
            this.MainH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainH.Name = "MainH";
            // 
            // MainH.Panel1
            // 
            this.MainH.Panel1.Controls.Add(this.SubMainLeft);
            // 
            // MainH.Panel2
            // 
            this.MainH.Panel2.Controls.Add(this.tableMap);
            // 
            // SubMainLeft
            // 
            this.SubMainLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.SubMainLeft, "SubMainLeft");
            this.SubMainLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SubMainLeft.Name = "SubMainLeft";
            // 
            // SubMainLeft.Panel1
            // 
            this.SubMainLeft.Panel1.Controls.Add(this.hud1);
            // 
            // SubMainLeft.Panel2
            // 
            this.SubMainLeft.Panel2.Controls.Add(this.tabControlactions);
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
            this.hud1.batteryremaining = 50F;
            this.hud1.bgimage = null;
            this.hud1.connected = false;
            this.hud1.ContextMenuStrip = this.contextMenuStripHud;
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
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("messagetime", this.bindingSourceHud, "messageHighTime", true));
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
            this.hud1.Resize += new System.EventHandler(this.hud1_Resize);
            // 
            // contextMenuStripHud
            // 
            resources.ApplyResources(this.contextMenuStripHud, "contextMenuStripHud");
            this.contextMenuStripHud.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStripHud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.setAspectRatioToolStripMenuItem,
            this.userItemsToolStripMenuItem,
            this.russianHudToolStripMenuItem,
            this.swapWithMapToolStripMenuItem,
            this.groundColorToolStripMenuItem});
            this.contextMenuStripHud.Name = "contextMenuStrip2";
            this.contextMenuStripHud.TabStop = true;
            this.contextMenuStripHud.UseWaitCursor = true;
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordHudToAVIToolStripMenuItem,
            this.stopRecordToolStripMenuItem,
            this.setMJPEGSourceToolStripMenuItem,
            this.startCameraToolStripMenuItem,
            this.setGStreamerSourceToolStripMenuItem,
            this.hereLinkVideoToolStripMenuItem,
            this.gStreamerStopToolStripMenuItem});
            resources.ApplyResources(this.videoToolStripMenuItem, "videoToolStripMenuItem");
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            // 
            // recordHudToAVIToolStripMenuItem
            // 
            this.recordHudToAVIToolStripMenuItem.Name = "recordHudToAVIToolStripMenuItem";
            resources.ApplyResources(this.recordHudToAVIToolStripMenuItem, "recordHudToAVIToolStripMenuItem");
            this.recordHudToAVIToolStripMenuItem.Click += new System.EventHandler(this.recordHudToAVIToolStripMenuItem_Click);
            // 
            // stopRecordToolStripMenuItem
            // 
            this.stopRecordToolStripMenuItem.Name = "stopRecordToolStripMenuItem";
            resources.ApplyResources(this.stopRecordToolStripMenuItem, "stopRecordToolStripMenuItem");
            this.stopRecordToolStripMenuItem.Click += new System.EventHandler(this.stopRecordToolStripMenuItem_Click);
            // 
            // setMJPEGSourceToolStripMenuItem
            // 
            this.setMJPEGSourceToolStripMenuItem.Name = "setMJPEGSourceToolStripMenuItem";
            resources.ApplyResources(this.setMJPEGSourceToolStripMenuItem, "setMJPEGSourceToolStripMenuItem");
            this.setMJPEGSourceToolStripMenuItem.Click += new System.EventHandler(this.setMJPEGSourceToolStripMenuItem_Click);
            // 
            // startCameraToolStripMenuItem
            // 
            this.startCameraToolStripMenuItem.Name = "startCameraToolStripMenuItem";
            resources.ApplyResources(this.startCameraToolStripMenuItem, "startCameraToolStripMenuItem");
            this.startCameraToolStripMenuItem.Click += new System.EventHandler(this.startCameraToolStripMenuItem_Click);
            // 
            // setGStreamerSourceToolStripMenuItem
            // 
            this.setGStreamerSourceToolStripMenuItem.Name = "setGStreamerSourceToolStripMenuItem";
            resources.ApplyResources(this.setGStreamerSourceToolStripMenuItem, "setGStreamerSourceToolStripMenuItem");
            this.setGStreamerSourceToolStripMenuItem.Click += new System.EventHandler(this.setGStreamerSourceToolStripMenuItem_Click);
            // 
            // hereLinkVideoToolStripMenuItem
            // 
            this.hereLinkVideoToolStripMenuItem.Name = "hereLinkVideoToolStripMenuItem";
            resources.ApplyResources(this.hereLinkVideoToolStripMenuItem, "hereLinkVideoToolStripMenuItem");
            this.hereLinkVideoToolStripMenuItem.Click += new System.EventHandler(this.HereLinkVideoToolStripMenuItem_Click);
            // 
            // gStreamerStopToolStripMenuItem
            // 
            this.gStreamerStopToolStripMenuItem.Name = "gStreamerStopToolStripMenuItem";
            resources.ApplyResources(this.gStreamerStopToolStripMenuItem, "gStreamerStopToolStripMenuItem");
            this.gStreamerStopToolStripMenuItem.Click += new System.EventHandler(this.GStreamerStopToolStripMenuItem_Click);
            // 
            // setAspectRatioToolStripMenuItem
            // 
            resources.ApplyResources(this.setAspectRatioToolStripMenuItem, "setAspectRatioToolStripMenuItem");
            this.setAspectRatioToolStripMenuItem.Name = "setAspectRatioToolStripMenuItem";
            this.setAspectRatioToolStripMenuItem.Click += new System.EventHandler(this.setAspectRatioToolStripMenuItem_Click);
            // 
            // userItemsToolStripMenuItem
            // 
            resources.ApplyResources(this.userItemsToolStripMenuItem, "userItemsToolStripMenuItem");
            this.userItemsToolStripMenuItem.Name = "userItemsToolStripMenuItem";
            this.userItemsToolStripMenuItem.Click += new System.EventHandler(this.hud_UserItem);
            // 
            // russianHudToolStripMenuItem
            // 
            resources.ApplyResources(this.russianHudToolStripMenuItem, "russianHudToolStripMenuItem");
            this.russianHudToolStripMenuItem.Name = "russianHudToolStripMenuItem";
            this.russianHudToolStripMenuItem.Click += new System.EventHandler(this.russianHudToolStripMenuItem_Click);
            // 
            // swapWithMapToolStripMenuItem
            // 
            resources.ApplyResources(this.swapWithMapToolStripMenuItem, "swapWithMapToolStripMenuItem");
            this.swapWithMapToolStripMenuItem.Name = "swapWithMapToolStripMenuItem";
            this.swapWithMapToolStripMenuItem.Click += new System.EventHandler(this.swapWithMapToolStripMenuItem_Click);
            // 
            // groundColorToolStripMenuItem
            // 
            this.groundColorToolStripMenuItem.CheckOnClick = true;
            resources.ApplyResources(this.groundColorToolStripMenuItem, "groundColorToolStripMenuItem");
            this.groundColorToolStripMenuItem.Name = "groundColorToolStripMenuItem";
            this.groundColorToolStripMenuItem.Click += new System.EventHandler(this.groundColorToolStripMenuItem_Click);
            // 
            // bindingSourceHud
            // 
            this.bindingSourceHud.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // tabControlactions
            // 
            this.tabControlactions.Controls.Add(this.tabActions);
            this.tabControlactions.Controls.Add(this.tabTLogs);
            resources.ApplyResources(this.tabControlactions, "tabControlactions");
            this.tabControlactions.Multiline = true;
            this.tabControlactions.Name = "tabControlactions";
            this.tabControlactions.SelectedIndex = 0;
            this.tabControlactions.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlactions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabActions
            // 
            resources.ApplyResources(this.tabActions, "tabActions");
            this.tabActions.Controls.Add(this.tableLayoutPanel3);
            this.tabActions.Name = "tabActions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.BUT_resumemis, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.BUT_manual, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.BUT_quickauto, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BUT_loiter, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BUT_quickrtl, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BUTrestartmission, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BUT_clear_track, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.BUT_ARM, 3, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // BUT_resumemis
            // 
            resources.ApplyResources(this.BUT_resumemis, "BUT_resumemis");
            this.BUT_resumemis.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_resumemis.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_resumemis.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_resumemis.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_resumemis.Name = "BUT_resumemis";
            this.BUT_resumemis.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_resumemis.TextColor = System.Drawing.Color.Black;
            this.BUT_resumemis.Click += new System.EventHandler(this.BUT_resumemis_Click);
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
            this.BUT_manual.UseVisualStyleBackColor = true;
            this.BUT_manual.Click += new System.EventHandler(this.BUT_manual_Click);
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
            this.BUT_quickauto.UseVisualStyleBackColor = false;
            this.BUT_quickauto.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // BUT_loiter
            // 
            resources.ApplyResources(this.BUT_loiter, "BUT_loiter");
            this.BUT_loiter.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_loiter.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loiter.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loiter.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_loiter.Name = "BUT_loiter";
            this.BUT_loiter.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_loiter.TextColor = System.Drawing.Color.Black;
            this.BUT_loiter.UseVisualStyleBackColor = true;
            this.BUT_loiter.Click += new System.EventHandler(this.BUT_loiter_Click);
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
            this.BUT_quickrtl.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel6.Controls.Add(this.ButJoyOn, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.BUT_joystick_settings, 1, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // ButJoyOn
            // 
            this.ButJoyOn.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.ButJoyOn, "ButJoyOn");
            this.ButJoyOn.Name = "ButJoyOn";
            this.ButJoyOn.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.ButJoyOn.TextColor = System.Drawing.Color.Black;
            this.ButJoyOn.Click += new System.EventHandler(this.ButJoyOn_Click_1);
            // 
            // BUT_joystick_settings
            // 
            this.BUT_joystick_settings.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_joystick_settings.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_joystick_settings.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_joystick_settings.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_joystick_settings, "BUT_joystick_settings");
            this.BUT_joystick_settings.Name = "BUT_joystick_settings";
            this.BUT_joystick_settings.TextColor = System.Drawing.Color.Black;
            this.BUT_joystick_settings.Click += new System.EventHandler(this.BUT_joystick_Click);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.verticalProgressBarR_DOWN, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.verticalProgressBarR_UP, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.verticalProgressBarL_DOWN, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.verticalProgressBarL_UP, 0, 1);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // verticalProgressBarR_DOWN
            // 
            resources.ApplyResources(this.verticalProgressBarR_DOWN, "verticalProgressBarR_DOWN");
            this.verticalProgressBarR_DOWN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.verticalProgressBarR_DOWN.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.verticalProgressBarR_DOWN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceQuickTab, "ch3out", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "1500"));
            this.verticalProgressBarR_DOWN.DisplayScale = 1F;
            this.verticalProgressBarR_DOWN.DrawLabel = false;
            this.verticalProgressBarR_DOWN.Inverted = true;
            this.verticalProgressBarR_DOWN.Label = null;
            this.verticalProgressBarR_DOWN.Maximum = 1500;
            this.verticalProgressBarR_DOWN.maxline = 0;
            this.verticalProgressBarR_DOWN.Minimum = 1000;
            this.verticalProgressBarR_DOWN.minline = 0;
            this.verticalProgressBarR_DOWN.Name = "verticalProgressBarR_DOWN";
            this.verticalProgressBarR_DOWN.reverse = true;
            this.verticalProgressBarR_DOWN.Value = 1400;
            this.verticalProgressBarR_DOWN.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // bindingSourceQuickTab
            // 
            this.bindingSourceQuickTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // verticalProgressBarR_UP
            // 
            resources.ApplyResources(this.verticalProgressBarR_UP, "verticalProgressBarR_UP");
            this.verticalProgressBarR_UP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.verticalProgressBarR_UP.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.verticalProgressBarR_UP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceQuickTab, "ch3out", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            this.verticalProgressBarR_UP.DisplayScale = 1F;
            this.verticalProgressBarR_UP.DrawLabel = false;
            this.verticalProgressBarR_UP.Inverted = false;
            this.verticalProgressBarR_UP.Label = null;
            this.verticalProgressBarR_UP.Maximum = 2000;
            this.verticalProgressBarR_UP.maxline = 0;
            this.verticalProgressBarR_UP.Minimum = 1500;
            this.verticalProgressBarR_UP.minline = 0;
            this.verticalProgressBarR_UP.Name = "verticalProgressBarR_UP";
            this.verticalProgressBarR_UP.reverse = false;
            this.verticalProgressBarR_UP.Value = 1600;
            this.verticalProgressBarR_UP.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // verticalProgressBarL_DOWN
            // 
            resources.ApplyResources(this.verticalProgressBarL_DOWN, "verticalProgressBarL_DOWN");
            this.verticalProgressBarL_DOWN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.verticalProgressBarL_DOWN.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.verticalProgressBarL_DOWN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceQuickTab, "ch1out", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "1500"));
            this.verticalProgressBarL_DOWN.DisplayScale = 1F;
            this.verticalProgressBarL_DOWN.DrawLabel = false;
            this.verticalProgressBarL_DOWN.Inverted = true;
            this.verticalProgressBarL_DOWN.Label = null;
            this.verticalProgressBarL_DOWN.Maximum = 1500;
            this.verticalProgressBarL_DOWN.maxline = 0;
            this.verticalProgressBarL_DOWN.Minimum = 1000;
            this.verticalProgressBarL_DOWN.minline = 0;
            this.verticalProgressBarL_DOWN.Name = "verticalProgressBarL_DOWN";
            this.verticalProgressBarL_DOWN.reverse = true;
            this.verticalProgressBarL_DOWN.Value = 1400;
            this.verticalProgressBarL_DOWN.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // verticalProgressBarL_UP
            // 
            resources.ApplyResources(this.verticalProgressBarL_UP, "verticalProgressBarL_UP");
            this.verticalProgressBarL_UP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.verticalProgressBarL_UP.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.verticalProgressBarL_UP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceQuickTab, "ch1out", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            this.verticalProgressBarL_UP.DisplayScale = 1F;
            this.verticalProgressBarL_UP.DrawLabel = false;
            this.verticalProgressBarL_UP.Inverted = false;
            this.verticalProgressBarL_UP.Label = null;
            this.verticalProgressBarL_UP.Maximum = 2000;
            this.verticalProgressBarL_UP.maxline = 0;
            this.verticalProgressBarL_UP.Minimum = 1500;
            this.verticalProgressBarL_UP.minline = 0;
            this.verticalProgressBarL_UP.Name = "verticalProgressBarL_UP";
            this.verticalProgressBarL_UP.reverse = false;
            this.verticalProgressBarL_UP.Value = 1600;
            this.verticalProgressBarL_UP.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // tableLayoutPanel12
            // 
            resources.ApplyResources(this.tableLayoutPanel12, "tableLayoutPanel12");
            this.tableLayoutPanel12.Controls.Add(this.zedGraphControl1, 0, 4);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.lineSeparator2, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tableLayoutPanel12.Controls.Add(this.lineSeparator3, 0, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            // 
            // zedGraphControl1
            // 
            resources.ApplyResources(this.zedGraphControl1, "zedGraphControl1");
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            // 
            // tableLayoutPanel10
            // 
            resources.ApplyResources(this.tableLayoutPanel10, "tableLayoutPanel10");
            this.tableLayoutPanel10.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.LBL_DisToHome, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.LBL_Depth, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.LBL_GSpeed, 1, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // LBL_DisToHome
            // 
            this.LBL_DisToHome.AutoEllipsis = true;
            this.LBL_DisToHome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceQuickTab, "DistToHome", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            resources.ApplyResources(this.LBL_DisToHome, "LBL_DisToHome");
            this.LBL_DisToHome.Name = "LBL_DisToHome";
            // 
            // LBL_Depth
            // 
            this.LBL_Depth.AutoEllipsis = true;
            resources.ApplyResources(this.LBL_Depth, "LBL_Depth");
            this.LBL_Depth.Name = "LBL_Depth";
            // 
            // LBL_GSpeed
            // 
            this.LBL_GSpeed.AutoEllipsis = true;
            this.LBL_GSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceQuickTab, "groundspeed", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            resources.ApplyResources(this.LBL_GSpeed, "LBL_GSpeed");
            this.LBL_GSpeed.Name = "LBL_GSpeed";
            // 
            // lineSeparator2
            // 
            resources.ApplyResources(this.lineSeparator2, "lineSeparator2");
            this.lineSeparator2.Name = "lineSeparator2";
            // 
            // tableLayoutPanel11
            // 
            resources.ApplyResources(this.tableLayoutPanel11, "tableLayoutPanel11");
            this.tableLayoutPanel11.Controls.Add(this.LBL_Humidity, 1, 4);
            this.tableLayoutPanel11.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel11.Controls.Add(this.LBL_Temp, 1, 3);
            this.tableLayoutPanel11.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.LBL_SatNumber, 1, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            // 
            // LBL_Humidity
            // 
            this.LBL_Humidity.AutoEllipsis = true;
            resources.ApplyResources(this.LBL_Humidity, "LBL_Humidity");
            this.LBL_Humidity.Name = "LBL_Humidity";
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // LBL_Temp
            // 
            this.LBL_Temp.AutoEllipsis = true;
            resources.ApplyResources(this.LBL_Temp, "LBL_Temp");
            this.LBL_Temp.Name = "LBL_Temp";
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // LBL_SatNumber
            // 
            this.LBL_SatNumber.AutoEllipsis = true;
            this.LBL_SatNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceQuickTab, "satcount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            resources.ApplyResources(this.LBL_SatNumber, "LBL_SatNumber");
            this.LBL_SatNumber.Name = "LBL_SatNumber";
            // 
            // lineSeparator3
            // 
            resources.ApplyResources(this.lineSeparator3, "lineSeparator3");
            this.lineSeparator3.Name = "lineSeparator3";
            // 
            // tabTLogs
            // 
            this.tabTLogs.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.tabTLogs, "tabTLogs");
            this.tabTLogs.Name = "tabTLogs";
            this.tabTLogs.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPaneltlogs, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPaneltlogs
            // 
            resources.ApplyResources(this.tableLayoutPaneltlogs, "tableLayoutPaneltlogs");
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_loadtelem, 0, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.tracklog, 1, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_log2kml, 0, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_playlog, 0, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPaneltlogs.Name = "tableLayoutPaneltlogs";
            // 
            // BUT_loadtelem
            // 
            resources.ApplyResources(this.BUT_loadtelem, "BUT_loadtelem");
            this.BUT_loadtelem.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_loadtelem.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_loadtelem.Name = "BUT_loadtelem";
            this.BUT_loadtelem.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_loadtelem.TextColor = System.Drawing.Color.Black;
            this.BUT_loadtelem.UseVisualStyleBackColor = true;
            this.BUT_loadtelem.Click += new System.EventHandler(this.BUT_loadtelem_Click);
            // 
            // tracklog
            // 
            resources.ApplyResources(this.tracklog, "tracklog");
            this.tracklog.Maximum = 100;
            this.tracklog.Name = "tracklog";
            this.tracklog.TickFrequency = 5;
            this.tracklog.Scroll += new System.EventHandler(this.tracklog_Scroll);
            // 
            // BUT_log2kml
            // 
            resources.ApplyResources(this.BUT_log2kml, "BUT_log2kml");
            this.BUT_log2kml.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_log2kml.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_log2kml.Name = "BUT_log2kml";
            this.BUT_log2kml.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_log2kml.TextColor = System.Drawing.Color.Black;
            this.BUT_log2kml.UseVisualStyleBackColor = true;
            this.BUT_log2kml.Click += new System.EventHandler(this.BUT_log2kml_Click);
            // 
            // BUT_playlog
            // 
            resources.ApplyResources(this.BUT_playlog, "BUT_playlog");
            this.BUT_playlog.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_playlog.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_playlog.Name = "BUT_playlog";
            this.BUT_playlog.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_playlog.TextColor = System.Drawing.Color.Black;
            this.BUT_playlog.UseVisualStyleBackColor = true;
            this.BUT_playlog.Click += new System.EventHandler(this.BUT_playlog_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            this.splitContainer1.Panel2.Controls.Add(this.lineSeparator1);
            this.splitContainer1.Panel2.Controls.Add(this.COMBJOY);
            this.splitContainer1.Panel2.Controls.Add(this.but_disablejoystick);
            this.splitContainer1.Panel2.Controls.Add(this.distanceBar1);
            this.splitContainer1.Panel2.Controls.Add(this.windDir1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.gMapControl1);
            this.splitContainer1.Panel2.Controls.Add(this.TRK_zoom);
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
            this.zg1.DoubleClick += new System.EventHandler(this.zg1_DoubleClick);
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
            // lineSeparator1
            // 
            resources.ApplyResources(this.lineSeparator1, "lineSeparator1");
            this.lineSeparator1.Name = "lineSeparator1";
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
            // windDir1
            // 
            this.windDir1.BackColor = System.Drawing.Color.Transparent;
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Direction", this.bindingSource1, "wind_dir", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Speed", this.bindingSource1, "wind_vel", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.Direction = 180D;
            resources.ApplyResources(this.windDir1, "windDir1");
            this.windDir1.Name = "windDir1";
            this.windDir1.Speed = 0D;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MissionPlanner.CurrentState);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.comboBoxMapTypeData);
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
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceQuickTab, "armed", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            this.label19.Name = "label19";
            this.label19.TextChanged += new System.EventHandler(this.label19_TextChanged);
            // 
            // comboBoxMapTypeData
            // 
            this.comboBoxMapTypeData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapTypeData.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMapTypeData, "comboBoxMapTypeData");
            this.comboBoxMapTypeData.Name = "comboBoxMapTypeData";
            this.toolTip1.SetToolTip(this.comboBoxMapTypeData, resources.GetString("comboBoxMapTypeData.ToolTip"));
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceQuickTab, "mode", true));
            this.label18.Name = "label18";
            this.label18.TextChanged += new System.EventHandler(this.label18_TextChanged);
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Alt", this.bindingSource1, "alt", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lat", this.bindingSource1, "lat", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lng", this.bindingSource1, "lng", true));
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Name = "coords1";
            this.coords1.Vertical = false;
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
            // CB_tuning
            // 
            resources.ApplyResources(this.CB_tuning, "CB_tuning");
            this.CB_tuning.Name = "CB_tuning";
            this.toolTip1.SetToolTip(this.CB_tuning, resources.GetString("CB_tuning.ToolTip"));
            this.CB_tuning.UseVisualStyleBackColor = true;
            this.CB_tuning.CheckedChanged += new System.EventHandler(this.CB_tuning_CheckedChanged);
            // 
            // ZedGraphTimer
            // 
            this.ZedGraphTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openScriptDialog
            // 
            resources.ApplyResources(this.openScriptDialog, "openScriptDialog");
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
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
            // depthChartTimer
            // 
            this.depthChartTimer.Enabled = true;
            this.depthChartTimer.Tick += new System.EventHandler(this.depthChartTimer_Tick);
            // 
            // FlightData
            // 
            this.Controls.Add(this.MainH);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightData_FormClosing);
            this.Load += new System.EventHandler(this.FlightData_Load);
            this.Resize += new System.EventHandler(this.FlightData_Resize);
            this.ParentChanged += new System.EventHandler(this.FlightData_ParentChanged);
            this.MainH.Panel1.ResumeLayout(false);
            this.MainH.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).EndInit();
            this.MainH.ResumeLayout(false);
            this.SubMainLeft.Panel1.ResumeLayout(false);
            this.SubMainLeft.Panel1.PerformLayout();
            this.SubMainLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).EndInit();
            this.SubMainLeft.ResumeLayout(false);
            this.contextMenuStripHud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).EndInit();
            this.tabControlactions.ResumeLayout(false);
            this.tabActions.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tabTLogs.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPaneltlogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableMap.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).EndInit();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private System.Windows.Forms.SplitContainer MainH;
        private System.Windows.Forms.SplitContainer SubMainLeft;
        private System.Windows.Forms.ToolStripMenuItem goHereToolStripMenuItem1;
        private Controls.HUD hud1;
        private Controls.MyButton BUT_clear_track;
        private System.Windows.Forms.CheckBox CB_tuning;
        private Controls.MyButton BUTrestartmission;
        private System.Windows.Forms.TrackBar tracklog;
        private Controls.MyButton BUT_playlog;
        private Controls.MyButton BUT_loadtelem;
        private System.Windows.Forms.TableLayoutPanel tableMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Zoomlevel;
        private Controls.MyLabel label1;
        private System.Windows.Forms.CheckBox CHK_autopan;
        public Controls.myGMAP gMapControl1;
        private ZedGraph.ZedGraphControl zg1;
        public System.Windows.Forms.TabControl tabControlactions;
        public System.Windows.Forms.TabPage tabTLogs;
        private System.Windows.Forms.ComboBox CMB_setwp;
        private Controls.MyButton BUT_quickrtl;
        private Controls.MyButton BUT_log2kml;
        private Controls.MyButton BUT_joystick_settings;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controls.MyLabel lbl_logpercent;
        private System.Windows.Forms.ToolStripMenuItem pointCameraHereToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.MyLabel lbl_hdop;
        private Controls.MyLabel lbl_sats;
        private Controls.MyLabel lbl_playbackspeed;
        private Controls.QuickView quickView3;
        private Controls.QuickView quickView2;
        private Controls.QuickView quickView1;
        private Controls.QuickView quickView4;
        private Controls.QuickView quickView6;
        private Controls.QuickView quickView5;
        private System.Windows.Forms.ToolStripMenuItem flyToHereAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightPlannerToolStripMenuItem;
        //private Crom.Controls.Docking.DockContainer dockContainer1;
        private Controls.MyButton BUT_ARM;
        private System.Windows.Forms.ToolStripMenuItem triggerCameraToolStripMenuItem;
        private Controls.MyTrackBar TRK_zoom;
        private Controls.MyLabel LBL_logfn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneltlogs;
        private System.Windows.Forms.BindingSource bindingSourceHud;
        private System.Windows.Forms.Panel panel2;
        private Controls.MyButton BUT_speed10;
        private Controls.MyButton BUT_speed5;
        private Controls.MyButton BUT_speed2;
        private Controls.MyButton BUT_speed1;
        private Controls.MyButton BUT_speed1_2;
        private Controls.MyButton BUT_speed1_4;
        private Controls.MyButton BUT_speed1_10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.BindingSource bindingSourceQuickTab;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem;
        private MissionPlanner.Controls.Coords coords1;
        public Controls.WindDir windDir1;
        private System.Windows.Forms.ToolStripMenuItem addPoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private Controls.DistanceBar distanceBar1;
        private System.Windows.Forms.ToolStripMenuItem takeOffToolStripMenuItem;
        private Controls.MyButton but_disablejoystick;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PointCameraCoordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onOffCameraOverlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altitudeAngelSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEKFHomeHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem1;
        public System.Windows.Forms.ComboBox comboBoxMapTypeData;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripHud;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordHudToAVIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMJPEGSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGStreamerSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hereLinkVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gStreamerStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAspectRatioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianHudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swapWithMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groundColorToolStripMenuItem;
        private Controls.MyButton BUT_loiter;
        private Controls.MyButton BUT_setwp;
        private Controls.MyButton BUT_resumemis;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox COMBJOY;
        private Controls.MyButton ButJoyOn;
        private System.Windows.Forms.Timer TimerUpdateSecondMAV;
        private Controls.MyButton BUT_quickauto;
        public System.Windows.Forms.TabPage tabActions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Controls.MyButton BUT_manual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private Controls.VerticalProgressBar2 verticalProgressBarR_UP;
        private Controls.VerticalProgressBar2 verticalProgressBarR_DOWN;
        private Controls.VerticalProgressBar2 verticalProgressBarL_UP;
        private Controls.VerticalProgressBar2 verticalProgressBarL_DOWN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private Controls.LineSeparator lineSeparator2;
        private Controls.LineSeparator lineSeparator3;
        private Controls.LineSeparator lineSeparator1;
        private System.Windows.Forms.Label LBL_SatNumber;
        private System.Windows.Forms.Label LBL_Humidity;
        private System.Windows.Forms.Label LBL_Temp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LBL_DisToHome;
        private System.Windows.Forms.Label LBL_Depth;
        private System.Windows.Forms.Label LBL_GSpeed;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Timer depthChartTimer;
    }
}