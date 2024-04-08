namespace MissionPlanner.GCSViews
{
    partial class FlightData
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightData));
            CodeArtEng.Gauge.Themes.ThemeColors themeColors1 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors2 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors3 = new CodeArtEng.Gauge.Themes.ThemeColors();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bindingSourceHud = new BindingSource(components);
            imageList2 = new ImageList(components);
            imageList1 = new ImageList(components);
            contextMenuStripMap = new ContextMenuStrip(components);
            goHereToolStripMenuItem1 = new ToolStripMenuItem();
            flyToHereAltToolStripMenuItem = new ToolStripMenuItem();
            addPoiToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            pointCameraHereToolStripMenuItem = new ToolStripMenuItem();
            PointCameraCoordsToolStripMenuItem1 = new ToolStripMenuItem();
            triggerCameraToolStripMenuItem = new ToolStripMenuItem();
            flightPlannerToolStripMenuItem = new ToolStripMenuItem();
            setHomeHereToolStripMenuItem = new ToolStripMenuItem();
            setEKFHomeHereToolStripMenuItem = new ToolStripMenuItem();
            setHomeHereToolStripMenuItem1 = new ToolStripMenuItem();
            takeOffToolStripMenuItem = new ToolStripMenuItem();
            onOffCameraOverlapToolStripMenuItem = new ToolStripMenuItem();
            altitudeAngelSettingsToolStripMenuItem = new ToolStripMenuItem();
            setHomeHereToolStripMenuItem2 = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            CB_tuning = new CheckBox();
            CHK_autopan = new CheckBox();
            Zoomlevel = new NumericUpDown();
            Bat_Body_Gauge = new CodeArtEng.Gauge.CircularGauge();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            TimerUpdateSecondMAV = new System.Windows.Forms.Timer(components);
            depthAlertTimer = new System.Windows.Forms.Timer(components);
            tableMap = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            zg1 = new ZedGraph.ZedGraphControl();
            BUT_ClearEchoData = new Controls.MyButton();
            BUT_DownloadEchoData = new Controls.MyButton();
            tableLayoutPanel12 = new TableLayoutPanel();
            LBL_TimeRemain = new Label();
            lineSeparator1 = new Controls.LineSeparator();
            label17 = new Label();
            label7 = new Label();
            label9 = new Label();
            LBL_TotalDist = new Label();
            label8 = new Label();
            LBL_TraveledDist = new Label();
            label10 = new Label();
            LBL_MissionCompleted = new Label();
            COMBJOY = new ComboBox();
            but_disablejoystick = new Controls.MyButton();
            distanceBar1 = new Controls.DistanceBar();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            TRK_zoom = new Controls.MyTrackBar();
            gMapControl1 = new Controls.myGMAP();
            panel1 = new Panel();
            label19 = new Label();
            label18 = new Label();
            coords1 = new Controls.Coords();
            tableLayoutPaneltlogs = new TableLayoutPanel();
            BUT_loadtelem = new Controls.MyButton();
            BUT_playlog = new Controls.MyButton();
            tracklog = new TrackBar();
            panel2 = new Panel();
            BUT_speed10 = new Controls.MyButton();
            BUT_speed5 = new Controls.MyButton();
            BUT_speed2 = new Controls.MyButton();
            BUT_speed1 = new Controls.MyButton();
            BUT_speed1_2 = new Controls.MyButton();
            BUT_speed1_4 = new Controls.MyButton();
            BUT_speed1_10 = new Controls.MyButton();
            tableLayoutPanel11 = new TableLayoutPanel();
            NUM_DepthAlarmValue = new NumericUpDown();
            BUT_MuteDepthAlarm = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            CMB_setwp = new ComboBox();
            BUT_setwp = new Controls.MyButton();
            groupBox1 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            BUT_EchoGrab = new Controls.MyButton();
            BUT_StopGrab = new Controls.MyButton();
            tableLayoutPanel8 = new TableLayoutPanel();
            CurrentR_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            Hum_R_Gauge = new CodeArtEng.Gauge.CircularGauge();
            CurrentL_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            Hum_L_Gauge = new CodeArtEng.Gauge.CircularGauge();
            Hum_Body_Gauge = new CodeArtEng.Gauge.CircularGauge();
            Temp_R_Gauge = new CodeArtEng.Gauge.CircularGauge();
            Temp_L_Gauge = new CodeArtEng.Gauge.CircularGauge();
            Temp_Body_Gauge = new CodeArtEng.Gauge.CircularGauge();
            Bat_R_Gauge = new CodeArtEng.Gauge.CircularGauge();
            Bat_L_Gauge = new CodeArtEng.Gauge.CircularGauge();
            Depth_Gauge = new CodeArtEng.Gauge.LinearGauge();
            Speed_Gauge = new CodeArtEng.Gauge.LinearGauge();
            tableLayoutPanel1 = new TableLayoutPanel();
            progressBarL_Down = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator();
            progressBarL_Up = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator();
            label11 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            progressBarR_Down = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator();
            progressBarR_Up = new CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator();
            label20 = new Label();
            CurrentMain_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            tableLayoutPanel4 = new TableLayoutPanel();
            Link_Quality_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            Dist_To_Home_Indicator = new CodeArtEng.Gauge.RectangleIndicator();
            BUT_manual = new Controls.MyButton();
            BUT_quickrtl = new Controls.MyButton();
            BUTrestartmission = new Controls.MyButton();
            BUT_clear_track = new Controls.MyButton();
            BUT_quickauto = new Controls.MyButton();
            BUT_ARM = new Controls.MyButton();
            Storage_Gauge = new CodeArtEng.Gauge.CircularGauge();
            tableLayoutPanel15 = new TableLayoutPanel();
            Satellites_Gauge = new CodeArtEng.Gauge.CircularGauge();
            hud1 = new Controls.HUD();
            MainH = new SplitContainer();
            tableLayoutPanel13 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            ZedGraphTimer = new System.Windows.Forms.Timer(components);
            label15 = new Label();
            label16 = new Label();
            BUT_EchoGrab_BlinkTimer = new System.Windows.Forms.Timer(components);
            PingTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bindingSourceHud).BeginInit();
            contextMenuStripMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Zoomlevel).BeginInit();
            tableMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TRK_zoom).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPaneltlogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tracklog).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUM_DepthAlarmValue).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainH).BeginInit();
            MainH.Panel1.SuspendLayout();
            MainH.Panel2.SuspendLayout();
            MainH.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            SuspendLayout();
            // 
            // bindingSourceHud
            // 
            bindingSourceHud.DataSource = typeof(CurrentState);
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "siren.png");
            imageList2.Images.SetKeyName(1, "siren2.png");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "mute6.png");
            imageList1.Images.SetKeyName(1, "mute3.png");
            // 
            // contextMenuStripMap
            // 
            contextMenuStripMap.ImageScalingSize = new Size(18, 18);
            contextMenuStripMap.Items.AddRange(new ToolStripItem[] { goHereToolStripMenuItem1, flyToHereAltToolStripMenuItem, addPoiToolStripMenuItem, pointCameraHereToolStripMenuItem, PointCameraCoordsToolStripMenuItem1, triggerCameraToolStripMenuItem, flightPlannerToolStripMenuItem, setHomeHereToolStripMenuItem, takeOffToolStripMenuItem, onOffCameraOverlapToolStripMenuItem, altitudeAngelSettingsToolStripMenuItem, setHomeHereToolStripMenuItem2 });
            contextMenuStripMap.Name = "contextMenuStrip1";
            resources.ApplyResources(contextMenuStripMap, "contextMenuStripMap");
            // 
            // goHereToolStripMenuItem1
            // 
            goHereToolStripMenuItem1.Name = "goHereToolStripMenuItem1";
            resources.ApplyResources(goHereToolStripMenuItem1, "goHereToolStripMenuItem1");
            goHereToolStripMenuItem1.Click += goHereToolStripMenuItem_Click;
            // 
            // flyToHereAltToolStripMenuItem
            // 
            flyToHereAltToolStripMenuItem.Name = "flyToHereAltToolStripMenuItem";
            resources.ApplyResources(flyToHereAltToolStripMenuItem, "flyToHereAltToolStripMenuItem");
            flyToHereAltToolStripMenuItem.Click += flyToHereAltToolStripMenuItem_Click;
            // 
            // addPoiToolStripMenuItem
            // 
            addPoiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, saveFileToolStripMenuItem, loadFileToolStripMenuItem });
            addPoiToolStripMenuItem.Name = "addPoiToolStripMenuItem";
            resources.ApplyResources(addPoiToolStripMenuItem, "addPoiToolStripMenuItem");
            addPoiToolStripMenuItem.Click += addPoiToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(deleteToolStripMenuItem, "deleteToolStripMenuItem");
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            resources.ApplyResources(saveFileToolStripMenuItem, "saveFileToolStripMenuItem");
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            resources.ApplyResources(loadFileToolStripMenuItem, "loadFileToolStripMenuItem");
            loadFileToolStripMenuItem.Click += loadFileToolStripMenuItem_Click;
            // 
            // pointCameraHereToolStripMenuItem
            // 
            pointCameraHereToolStripMenuItem.Name = "pointCameraHereToolStripMenuItem";
            resources.ApplyResources(pointCameraHereToolStripMenuItem, "pointCameraHereToolStripMenuItem");
            pointCameraHereToolStripMenuItem.Click += pointCameraHereToolStripMenuItem_Click;
            // 
            // PointCameraCoordsToolStripMenuItem1
            // 
            PointCameraCoordsToolStripMenuItem1.Name = "PointCameraCoordsToolStripMenuItem1";
            resources.ApplyResources(PointCameraCoordsToolStripMenuItem1, "PointCameraCoordsToolStripMenuItem1");
            PointCameraCoordsToolStripMenuItem1.Click += PointCameraCoordsToolStripMenuItem1_Click;
            // 
            // triggerCameraToolStripMenuItem
            // 
            triggerCameraToolStripMenuItem.Name = "triggerCameraToolStripMenuItem";
            resources.ApplyResources(triggerCameraToolStripMenuItem, "triggerCameraToolStripMenuItem");
            triggerCameraToolStripMenuItem.Click += triggerCameraToolStripMenuItem_Click;
            // 
            // flightPlannerToolStripMenuItem
            // 
            flightPlannerToolStripMenuItem.Name = "flightPlannerToolStripMenuItem";
            resources.ApplyResources(flightPlannerToolStripMenuItem, "flightPlannerToolStripMenuItem");
            flightPlannerToolStripMenuItem.Click += flightPlannerToolStripMenuItem_Click;
            // 
            // setHomeHereToolStripMenuItem
            // 
            setHomeHereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setEKFHomeHereToolStripMenuItem, setHomeHereToolStripMenuItem1 });
            setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            resources.ApplyResources(setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            setHomeHereToolStripMenuItem.Click += setHomeHereToolStripMenuItem_Click;
            // 
            // setEKFHomeHereToolStripMenuItem
            // 
            setEKFHomeHereToolStripMenuItem.Name = "setEKFHomeHereToolStripMenuItem";
            resources.ApplyResources(setEKFHomeHereToolStripMenuItem, "setEKFHomeHereToolStripMenuItem");
            setEKFHomeHereToolStripMenuItem.Click += setEKFHomeHereToolStripMenuItem_Click;
            // 
            // setHomeHereToolStripMenuItem1
            // 
            setHomeHereToolStripMenuItem1.Name = "setHomeHereToolStripMenuItem1";
            resources.ApplyResources(setHomeHereToolStripMenuItem1, "setHomeHereToolStripMenuItem1");
            setHomeHereToolStripMenuItem1.Click += setHomeHereToolStripMenuItem_Click;
            // 
            // takeOffToolStripMenuItem
            // 
            takeOffToolStripMenuItem.Name = "takeOffToolStripMenuItem";
            resources.ApplyResources(takeOffToolStripMenuItem, "takeOffToolStripMenuItem");
            takeOffToolStripMenuItem.Click += takeOffToolStripMenuItem_Click;
            // 
            // onOffCameraOverlapToolStripMenuItem
            // 
            onOffCameraOverlapToolStripMenuItem.CheckOnClick = true;
            onOffCameraOverlapToolStripMenuItem.Name = "onOffCameraOverlapToolStripMenuItem";
            resources.ApplyResources(onOffCameraOverlapToolStripMenuItem, "onOffCameraOverlapToolStripMenuItem");
            onOffCameraOverlapToolStripMenuItem.Click += onOffCameraOverlapToolStripMenuItem_Click;
            // 
            // altitudeAngelSettingsToolStripMenuItem
            // 
            altitudeAngelSettingsToolStripMenuItem.Name = "altitudeAngelSettingsToolStripMenuItem";
            resources.ApplyResources(altitudeAngelSettingsToolStripMenuItem, "altitudeAngelSettingsToolStripMenuItem");
            altitudeAngelSettingsToolStripMenuItem.Click += altitudeAngelSettingsToolStripMenuItem_Click;
            // 
            // setHomeHereToolStripMenuItem2
            // 
            setHomeHereToolStripMenuItem2.Name = "setHomeHereToolStripMenuItem2";
            resources.ApplyResources(setHomeHereToolStripMenuItem2, "setHomeHereToolStripMenuItem2");
            setHomeHereToolStripMenuItem2.Click += setHomeHereToolStripMenuItem2_Click;
            // 
            // CB_tuning
            // 
            resources.ApplyResources(CB_tuning, "CB_tuning");
            CB_tuning.Name = "CB_tuning";
            toolTip1.SetToolTip(CB_tuning, resources.GetString("CB_tuning.ToolTip"));
            CB_tuning.UseVisualStyleBackColor = true;
            CB_tuning.CheckedChanged += CB_tuning_CheckedChanged;
            // 
            // CHK_autopan
            // 
            resources.ApplyResources(CHK_autopan, "CHK_autopan");
            CHK_autopan.Checked = true;
            CHK_autopan.CheckState = CheckState.Checked;
            CHK_autopan.Name = "CHK_autopan";
            toolTip1.SetToolTip(CHK_autopan, resources.GetString("CHK_autopan.ToolTip"));
            CHK_autopan.UseVisualStyleBackColor = true;
            CHK_autopan.CheckedChanged += CHK_autopan_CheckedChanged;
            // 
            // Zoomlevel
            // 
            resources.ApplyResources(Zoomlevel, "Zoomlevel");
            Zoomlevel.DecimalPlaces = 1;
            Zoomlevel.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            Zoomlevel.Maximum = new decimal(new int[] { 18, 0, 0, 0 });
            Zoomlevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Zoomlevel.Name = "Zoomlevel";
            toolTip1.SetToolTip(Zoomlevel, resources.GetString("Zoomlevel.ToolTip"));
            Zoomlevel.Value = new decimal(new int[] { 10, 0, 0, 0 });
            Zoomlevel.ValueChanged += Zoomlevel_ValueChanged;
            // 
            // Bat_Body_Gauge
            // 
            Bat_Body_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Bat_Body_Gauge, "Bat_Body_Gauge");
            Bat_Body_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Bat_Body_Gauge.ErrorLimit = 10D;
            Bat_Body_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Bat_Body_Gauge.InvertLimit = true;
            Bat_Body_Gauge.MajorTicks.Interval = 0D;
            Bat_Body_Gauge.MajorTicks.MarkerLength = 5;
            Bat_Body_Gauge.Maximum = 100D;
            Bat_Body_Gauge.MinorTicks.Interval = 0D;
            Bat_Body_Gauge.MinorTicks.MarkerLength = 5;
            Bat_Body_Gauge.Name = "Bat_Body_Gauge";
            Bat_Body_Gauge.PointerEndAngle = 504;
            Bat_Body_Gauge.PointerStartAngle = 216;
            Bat_Body_Gauge.ResetValue = 0D;
            Bat_Body_Gauge.ScaleFactor = 1D;
            Bat_Body_Gauge.ScaleLabel.Interval = 10D;
            Bat_Body_Gauge.SegmentCount = 50;
            Bat_Body_Gauge.SegmentGap = 2;
            Bat_Body_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Bat_Body_Gauge.Title = "";
            toolTip1.SetToolTip(Bat_Body_Gauge, resources.GetString("Bat_Body_Gauge.ToolTip"));
            Bat_Body_Gauge.Unit = "Bat B";
            themeColors1.MajorTickLineColor = Color.Gray;
            themeColors1.MinorTickLineColor = Color.Gray;
            themeColors1.PanelBackColor = Color.FromArgb(0, 60, 0);
            themeColors1.PanelBorderColor = Color.FromArgb(0, 192, 0);
            themeColors1.PointerBackColor = Color.FromArgb(22, 22, 22);
            themeColors1.PointerColor = Color.FromArgb(0, 200, 0);
            themeColors1.ScaleLabelColor = Color.Silver;
            themeColors1.TextForeColor = Color.FromArgb(128, 255, 128);
            Bat_Body_Gauge.UserDefinedColors.Base = themeColors1;
            themeColors2.MajorTickLineColor = Color.Gray;
            themeColors2.MinorTickLineColor = Color.Gray;
            themeColors2.NeedleColor = Color.FromArgb(255, 127, 127);
            themeColors2.PanelBackColor = Color.FromArgb(60, 0, 0);
            themeColors2.PanelBorderColor = Color.FromArgb(255, 128, 128);
            themeColors2.PointerBackColor = Color.FromArgb(22, 22, 22);
            themeColors2.PointerColor = Color.FromArgb(220, 0, 0);
            themeColors2.ScaleLabelColor = Color.Silver;
            themeColors2.TextForeColor = Color.FromArgb(255, 192, 192);
            Bat_Body_Gauge.UserDefinedColors.Error = themeColors2;
            themeColors3.MajorTickLineColor = Color.Gray;
            themeColors3.MinorTickLineColor = Color.Gray;
            themeColors3.PanelBackColor = Color.FromArgb(60, 60, 0);
            themeColors3.PanelBorderColor = Color.FromArgb(192, 192, 0);
            themeColors3.PointerBackColor = Color.FromArgb(22, 22, 22);
            themeColors3.PointerColor = Color.FromArgb(229, 187, 0);
            themeColors3.ScaleLabelColor = Color.Silver;
            themeColors3.TextForeColor = Color.FromArgb(255, 255, 128);
            Bat_Body_Gauge.UserDefinedColors.Warning = themeColors3;
            Bat_Body_Gauge.Value = 1D;
            Bat_Body_Gauge.ValueFormat = "0 \"%\"";
            Bat_Body_Gauge.WarningLimit = 30D;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(dataGridViewImageColumn1, "dataGridViewImageColumn1");
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(dataGridViewImageColumn2, "dataGridViewImageColumn2");
            dataGridViewImageColumn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // TimerUpdateSecondMAV
            // 
            TimerUpdateSecondMAV.Enabled = true;
            TimerUpdateSecondMAV.Interval = 500;
            TimerUpdateSecondMAV.Tick += TimerUpdateSecondMAV_Tick;
            // 
            // depthAlertTimer
            // 
            depthAlertTimer.Interval = 500;
            depthAlertTimer.Tick += depthAlertTimer_Tick_1;
            // 
            // tableMap
            // 
            resources.ApplyResources(tableMap, "tableMap");
            tableMap.Controls.Add(splitContainer1, 0, 0);
            tableMap.Controls.Add(panel1, 0, 1);
            tableMap.Name = "tableMap";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(zg1);
            splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.ContextMenuStrip = contextMenuStripMap;
            splitContainer1.Panel2.Controls.Add(BUT_ClearEchoData);
            splitContainer1.Panel2.Controls.Add(BUT_DownloadEchoData);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel12);
            splitContainer1.Panel2.Controls.Add(COMBJOY);
            splitContainer1.Panel2.Controls.Add(but_disablejoystick);
            splitContainer1.Panel2.Controls.Add(distanceBar1);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(TRK_zoom);
            splitContainer1.Panel2.Controls.Add(gMapControl1);
            // 
            // zg1
            // 
            resources.ApplyResources(zg1, "zg1");
            zg1.Name = "zg1";
            zg1.ScrollGrace = 0D;
            zg1.ScrollMaxX = 0D;
            zg1.ScrollMaxY = 0D;
            zg1.ScrollMaxY2 = 0D;
            zg1.ScrollMinX = 0D;
            zg1.ScrollMinY = 0D;
            zg1.ScrollMinY2 = 0D;
            zg1.DoubleClick += zg1_DoubleClick;
            // 
            // BUT_ClearEchoData
            // 
            resources.ApplyResources(BUT_ClearEchoData, "BUT_ClearEchoData");
            BUT_ClearEchoData.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_ClearEchoData.ColorMouseDown = Color.Empty;
            BUT_ClearEchoData.ColorMouseOver = Color.Empty;
            BUT_ClearEchoData.ColorNotEnabled = Color.Empty;
            BUT_ClearEchoData.Name = "BUT_ClearEchoData";
            BUT_ClearEchoData.Outline = Color.FromArgb(148, 193, 50);
            BUT_ClearEchoData.TextColor = Color.Black;
            BUT_ClearEchoData.TextColorNotEnabled = Color.Black;
            BUT_ClearEchoData.Click += BUT_ClearEchoData_Click;
            // 
            // BUT_DownloadEchoData
            // 
            resources.ApplyResources(BUT_DownloadEchoData, "BUT_DownloadEchoData");
            BUT_DownloadEchoData.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_DownloadEchoData.ColorMouseDown = Color.Empty;
            BUT_DownloadEchoData.ColorMouseOver = Color.Empty;
            BUT_DownloadEchoData.ColorNotEnabled = Color.Empty;
            BUT_DownloadEchoData.Name = "BUT_DownloadEchoData";
            BUT_DownloadEchoData.Outline = Color.FromArgb(148, 193, 50);
            BUT_DownloadEchoData.TextColor = Color.Black;
            BUT_DownloadEchoData.TextColorNotEnabled = Color.Black;
            BUT_DownloadEchoData.Click += BUT_DownloadEchoData_Click;
            // 
            // tableLayoutPanel12
            // 
            resources.ApplyResources(tableLayoutPanel12, "tableLayoutPanel12");
            tableLayoutPanel12.Controls.Add(LBL_TimeRemain, 0, 5);
            tableLayoutPanel12.Controls.Add(lineSeparator1, 0, 3);
            tableLayoutPanel12.Controls.Add(label17, 0, 4);
            tableLayoutPanel12.Controls.Add(label7, 0, 0);
            tableLayoutPanel12.Controls.Add(label9, 1, 1);
            tableLayoutPanel12.Controls.Add(LBL_TotalDist, 2, 2);
            tableLayoutPanel12.Controls.Add(label8, 0, 1);
            tableLayoutPanel12.Controls.Add(LBL_TraveledDist, 1, 2);
            tableLayoutPanel12.Controls.Add(label10, 2, 1);
            tableLayoutPanel12.Controls.Add(LBL_MissionCompleted, 0, 2);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            // 
            // LBL_TimeRemain
            // 
            LBL_TimeRemain.AutoEllipsis = true;
            resources.ApplyResources(LBL_TimeRemain, "LBL_TimeRemain");
            tableLayoutPanel12.SetColumnSpan(LBL_TimeRemain, 3);
            LBL_TimeRemain.Name = "LBL_TimeRemain";
            // 
            // lineSeparator1
            // 
            resources.ApplyResources(lineSeparator1, "lineSeparator1");
            tableLayoutPanel12.SetColumnSpan(lineSeparator1, 3);
            lineSeparator1.Name = "lineSeparator1";
            // 
            // label17
            // 
            label17.AutoEllipsis = true;
            resources.ApplyResources(label17, "label17");
            tableLayoutPanel12.SetColumnSpan(label17, 3);
            label17.Name = "label17";
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            resources.ApplyResources(label7, "label7");
            tableLayoutPanel12.SetColumnSpan(label7, 3);
            label7.Name = "label7";
            // 
            // label9
            // 
            label9.AutoEllipsis = true;
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // LBL_TotalDist
            // 
            LBL_TotalDist.AutoEllipsis = true;
            resources.ApplyResources(LBL_TotalDist, "LBL_TotalDist");
            LBL_TotalDist.Name = "LBL_TotalDist";
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // LBL_TraveledDist
            // 
            LBL_TraveledDist.AutoEllipsis = true;
            resources.ApplyResources(LBL_TraveledDist, "LBL_TraveledDist");
            LBL_TraveledDist.Name = "LBL_TraveledDist";
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // LBL_MissionCompleted
            // 
            LBL_MissionCompleted.AutoEllipsis = true;
            resources.ApplyResources(LBL_MissionCompleted, "LBL_MissionCompleted");
            LBL_MissionCompleted.Name = "LBL_MissionCompleted";
            // 
            // COMBJOY
            // 
            COMBJOY.FormattingEnabled = true;
            resources.ApplyResources(COMBJOY, "COMBJOY");
            COMBJOY.Name = "COMBJOY";
            // 
            // but_disablejoystick
            // 
            but_disablejoystick.ColorMouseDown = Color.Empty;
            but_disablejoystick.ColorMouseOver = Color.Empty;
            but_disablejoystick.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(but_disablejoystick, "but_disablejoystick");
            but_disablejoystick.Name = "but_disablejoystick";
            but_disablejoystick.TextColor = Color.Empty;
            but_disablejoystick.TextColorNotEnabled = Color.Empty;
            but_disablejoystick.UseVisualStyleBackColor = true;
            but_disablejoystick.Click += but_disablejoystick_Click;
            // 
            // distanceBar1
            // 
            resources.ApplyResources(distanceBar1, "distanceBar1");
            distanceBar1.BackColor = Color.Transparent;
            distanceBar1.Name = "distanceBar1";
            distanceBar1.totaldist = 100F;
            distanceBar1.traveleddist = 0F;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.White;
            label6.Name = "label6";
            label6.Tag = "custom";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.Green;
            label5.Name = "label5";
            label5.Tag = "custom";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Name = "label3";
            label3.Tag = "custom";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.Red;
            label4.Name = "label4";
            label4.Tag = "custom";
            // 
            // TRK_zoom
            // 
            resources.ApplyResources(TRK_zoom, "TRK_zoom");
            TRK_zoom.LargeChange = 1F;
            TRK_zoom.Maximum = 24F;
            TRK_zoom.Minimum = 1F;
            TRK_zoom.Name = "TRK_zoom";
            TRK_zoom.SmallChange = 1F;
            TRK_zoom.TickFrequency = 1F;
            TRK_zoom.TickStyle = TickStyle.Both;
            TRK_zoom.Value = 1F;
            TRK_zoom.Scroll += TRK_zoom_Scroll;
            // 
            // gMapControl1
            // 
            gMapControl1.BackColor = Color.Black;
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.ContextMenuStrip = contextMenuStripMap;
            resources.ApplyResources(gMapControl1, "gMapControl1");
            gMapControl1.EmptyTileColor = Color.Gray;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.HoldInvalidation = false;
            gMapControl1.LevelsKeepInMemmory = 5;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 24;
            gMapControl1.MinZoom = 0;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Zoom = 3D;
            gMapControl1.OnPositionChanged += gMapControl1_OnPositionChanged;
            gMapControl1.Click += gMapControl1_Click;
            gMapControl1.MouseDown += gMapControl1_MouseDown;
            gMapControl1.MouseLeave += gMapControl1_MouseLeave;
            gMapControl1.MouseMove += gMapControl1_MouseMove;
            gMapControl1.Resize += gMapControl1_Resize;
            // 
            // panel1
            // 
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(coords1);
            panel1.Controls.Add(Zoomlevel);
            panel1.Controls.Add(CHK_autopan);
            panel1.Controls.Add(CB_tuning);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label19
            // 
            resources.ApplyResources(label19, "label19");
            label19.DataBindings.Add(new Binding("Text", bindingSourceHud, "armed", true, DataSourceUpdateMode.OnValidation, "0"));
            label19.Name = "label19";
            label19.TextChanged += label19_TextChanged;
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            label18.DataBindings.Add(new Binding("Text", bindingSourceHud, "mode", true));
            label18.Name = "label18";
            label18.TextChanged += label18_TextChanged;
            // 
            // coords1
            // 
            coords1.Alt = 0D;
            coords1.AltSource = "";
            coords1.AltUnit = "m";
            coords1.DataBindings.Add(new Binding("Alt", bindingSourceHud, "alt", true));
            coords1.DataBindings.Add(new Binding("Lat", bindingSourceHud, "lat", true));
            coords1.DataBindings.Add(new Binding("Lng", bindingSourceHud, "lng", true));
            coords1.Lat = 0D;
            coords1.Lng = 0D;
            resources.ApplyResources(coords1, "coords1");
            coords1.Name = "coords1";
            coords1.Vertical = false;
            // 
            // tableLayoutPaneltlogs
            // 
            resources.ApplyResources(tableLayoutPaneltlogs, "tableLayoutPaneltlogs");
            tableLayoutPaneltlogs.Controls.Add(BUT_loadtelem, 0, 0);
            tableLayoutPaneltlogs.Controls.Add(BUT_playlog, 1, 0);
            tableLayoutPaneltlogs.Controls.Add(tracklog, 0, 1);
            tableLayoutPaneltlogs.Controls.Add(panel2, 0, 2);
            tableLayoutPaneltlogs.Name = "tableLayoutPaneltlogs";
            // 
            // BUT_loadtelem
            // 
            BUT_loadtelem.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_loadtelem.ColorMouseDown = Color.Empty;
            BUT_loadtelem.ColorMouseOver = Color.Empty;
            BUT_loadtelem.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(BUT_loadtelem, "BUT_loadtelem");
            BUT_loadtelem.Name = "BUT_loadtelem";
            BUT_loadtelem.Outline = Color.FromArgb(148, 193, 50);
            BUT_loadtelem.TextColor = Color.Black;
            BUT_loadtelem.TextColorNotEnabled = Color.Black;
            BUT_loadtelem.UseVisualStyleBackColor = true;
            BUT_loadtelem.Click += BUT_loadtelem_Click;
            // 
            // BUT_playlog
            // 
            BUT_playlog.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_playlog.ColorMouseDown = Color.Empty;
            BUT_playlog.ColorMouseOver = Color.Empty;
            BUT_playlog.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(BUT_playlog, "BUT_playlog");
            BUT_playlog.Name = "BUT_playlog";
            BUT_playlog.Outline = Color.FromArgb(148, 193, 50);
            BUT_playlog.TextColor = Color.Black;
            BUT_playlog.TextColorNotEnabled = Color.Black;
            BUT_playlog.UseVisualStyleBackColor = true;
            BUT_playlog.Click += BUT_playlog_Click;
            // 
            // tracklog
            // 
            tableLayoutPaneltlogs.SetColumnSpan(tracklog, 2);
            resources.ApplyResources(tracklog, "tracklog");
            tracklog.Maximum = 100;
            tracklog.Name = "tracklog";
            tracklog.TickFrequency = 5;
            tracklog.Scroll += tracklog_Scroll;
            // 
            // panel2
            // 
            tableLayoutPaneltlogs.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(BUT_speed10);
            panel2.Controls.Add(BUT_speed5);
            panel2.Controls.Add(BUT_speed2);
            panel2.Controls.Add(BUT_speed1);
            panel2.Controls.Add(BUT_speed1_2);
            panel2.Controls.Add(BUT_speed1_4);
            panel2.Controls.Add(BUT_speed1_10);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // BUT_speed10
            // 
            BUT_speed10.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_speed10.ColorMouseDown = Color.Empty;
            BUT_speed10.ColorMouseOver = Color.Empty;
            BUT_speed10.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(BUT_speed10, "BUT_speed10");
            BUT_speed10.Name = "BUT_speed10";
            BUT_speed10.Outline = Color.FromArgb(148, 193, 50);
            BUT_speed10.Tag = "10";
            BUT_speed10.TextColor = Color.Black;
            BUT_speed10.TextColorNotEnabled = Color.Black;
            BUT_speed10.UseVisualStyleBackColor = true;
            BUT_speed10.Click += BUT_speed1_Click;
            // 
            // BUT_speed5
            // 
            BUT_speed5.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_speed5.ColorMouseDown = Color.Empty;
            BUT_speed5.ColorMouseOver = Color.Empty;
            BUT_speed5.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(BUT_speed5, "BUT_speed5");
            BUT_speed5.Name = "BUT_speed5";
            BUT_speed5.Outline = Color.FromArgb(148, 193, 50);
            BUT_speed5.Tag = "5";
            BUT_speed5.TextColor = Color.Black;
            BUT_speed5.TextColorNotEnabled = Color.Black;
            BUT_speed5.UseVisualStyleBackColor = true;
            BUT_speed5.Click += BUT_speed1_Click;
            // 
            // BUT_speed2
            // 
            BUT_speed2.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_speed2.ColorMouseDown = Color.Empty;
            BUT_speed2.ColorMouseOver = Color.Empty;
            BUT_speed2.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(BUT_speed2, "BUT_speed2");
            BUT_speed2.Name = "BUT_speed2";
            BUT_speed2.Outline = Color.FromArgb(148, 193, 50);
            BUT_speed2.Tag = "2";
            BUT_speed2.TextColor = Color.Black;
            BUT_speed2.TextColorNotEnabled = Color.Black;
            BUT_speed2.UseVisualStyleBackColor = true;
            BUT_speed2.Click += BUT_speed1_Click;
            // 
            // BUT_speed1
            // 
            BUT_speed1.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_speed1.ColorMouseDown = Color.Empty;
            BUT_speed1.ColorMouseOver = Color.Empty;
            BUT_speed1.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(BUT_speed1, "BUT_speed1");
            BUT_speed1.Name = "BUT_speed1";
            BUT_speed1.Outline = Color.FromArgb(148, 193, 50);
            BUT_speed1.Tag = "1";
            BUT_speed1.TextColor = Color.Black;
            BUT_speed1.TextColorNotEnabled = Color.Black;
            BUT_speed1.UseVisualStyleBackColor = true;
            BUT_speed1.Click += BUT_speed1_Click;
            // 
            // BUT_speed1_2
            // 
            BUT_speed1_2.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_speed1_2.ColorMouseDown = Color.Empty;
            BUT_speed1_2.ColorMouseOver = Color.Empty;
            BUT_speed1_2.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(BUT_speed1_2, "BUT_speed1_2");
            BUT_speed1_2.Name = "BUT_speed1_2";
            BUT_speed1_2.Outline = Color.FromArgb(148, 193, 50);
            BUT_speed1_2.Tag = "0.5";
            BUT_speed1_2.TextColor = Color.Black;
            BUT_speed1_2.TextColorNotEnabled = Color.Black;
            BUT_speed1_2.UseVisualStyleBackColor = true;
            BUT_speed1_2.Click += BUT_speed1_Click;
            // 
            // BUT_speed1_4
            // 
            BUT_speed1_4.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_speed1_4.ColorMouseDown = Color.Empty;
            BUT_speed1_4.ColorMouseOver = Color.Empty;
            BUT_speed1_4.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(BUT_speed1_4, "BUT_speed1_4");
            BUT_speed1_4.Name = "BUT_speed1_4";
            BUT_speed1_4.Outline = Color.FromArgb(148, 193, 50);
            BUT_speed1_4.Tag = "0.25";
            BUT_speed1_4.TextColor = Color.Black;
            BUT_speed1_4.TextColorNotEnabled = Color.Black;
            BUT_speed1_4.UseVisualStyleBackColor = true;
            BUT_speed1_4.Click += BUT_speed1_Click;
            // 
            // BUT_speed1_10
            // 
            BUT_speed1_10.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_speed1_10.ColorMouseDown = Color.Empty;
            BUT_speed1_10.ColorMouseOver = Color.Empty;
            BUT_speed1_10.ColorNotEnabled = Color.Empty;
            resources.ApplyResources(BUT_speed1_10, "BUT_speed1_10");
            BUT_speed1_10.Name = "BUT_speed1_10";
            BUT_speed1_10.Outline = Color.FromArgb(148, 193, 50);
            BUT_speed1_10.Tag = "0.1";
            BUT_speed1_10.TextColor = Color.Black;
            BUT_speed1_10.TextColorNotEnabled = Color.Black;
            BUT_speed1_10.UseVisualStyleBackColor = true;
            BUT_speed1_10.Click += BUT_speed1_Click;
            // 
            // tableLayoutPanel11
            // 
            resources.ApplyResources(tableLayoutPanel11, "tableLayoutPanel11");
            tableLayoutPanel11.Controls.Add(NUM_DepthAlarmValue, 1, 0);
            tableLayoutPanel11.Controls.Add(BUT_MuteDepthAlarm, 0, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            // 
            // NUM_DepthAlarmValue
            // 
            resources.ApplyResources(NUM_DepthAlarmValue, "NUM_DepthAlarmValue");
            NUM_DepthAlarmValue.DecimalPlaces = 2;
            NUM_DepthAlarmValue.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            NUM_DepthAlarmValue.Name = "NUM_DepthAlarmValue";
            NUM_DepthAlarmValue.Value = new decimal(new int[] { 30, 0, 0, 131072 });
            NUM_DepthAlarmValue.ValueChanged += NUM_DepthAlarmValue_ValueChanged;
            // 
            // BUT_MuteDepthAlarm
            // 
            BUT_MuteDepthAlarm.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_MuteDepthAlarm, "BUT_MuteDepthAlarm");
            BUT_MuteDepthAlarm.FlatAppearance.BorderColor = Color.FromArgb(148, 193, 31);
            BUT_MuteDepthAlarm.ImageList = imageList1;
            BUT_MuteDepthAlarm.Name = "BUT_MuteDepthAlarm";
            BUT_MuteDepthAlarm.UseVisualStyleBackColor = false;
            BUT_MuteDepthAlarm.Click += BUT_Mute_Click;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(tableLayoutPanel5, "tableLayoutPanel5");
            tableLayoutPanel5.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel5.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel7);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(tableLayoutPanel7, "tableLayoutPanel7");
            tableLayoutPanel7.Controls.Add(CMB_setwp, 1, 0);
            tableLayoutPanel7.Controls.Add(BUT_setwp, 0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // CMB_setwp
            // 
            resources.ApplyResources(CMB_setwp, "CMB_setwp");
            CMB_setwp.DropDownStyle = ComboBoxStyle.DropDownList;
            CMB_setwp.FormattingEnabled = true;
            CMB_setwp.Items.AddRange(new object[] { resources.GetString("CMB_setwp.Items") });
            CMB_setwp.Name = "CMB_setwp";
            CMB_setwp.Click += CMB_setwp_Click;
            // 
            // BUT_setwp
            // 
            resources.ApplyResources(BUT_setwp, "BUT_setwp");
            BUT_setwp.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_setwp.ColorMouseDown = Color.Empty;
            BUT_setwp.ColorMouseOver = Color.Empty;
            BUT_setwp.ColorNotEnabled = Color.Empty;
            BUT_setwp.Name = "BUT_setwp";
            BUT_setwp.Outline = Color.FromArgb(148, 193, 50);
            BUT_setwp.TextColor = Color.Black;
            BUT_setwp.TextColorNotEnabled = Color.Black;
            BUT_setwp.Click += BUT_setwp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel6);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(tableLayoutPanel6, "tableLayoutPanel6");
            tableLayoutPanel6.Controls.Add(BUT_EchoGrab, 0, 0);
            tableLayoutPanel6.Controls.Add(BUT_StopGrab, 1, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // BUT_EchoGrab
            // 
            resources.ApplyResources(BUT_EchoGrab, "BUT_EchoGrab");
            BUT_EchoGrab.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_EchoGrab.ColorMouseDown = Color.Empty;
            BUT_EchoGrab.ColorMouseOver = Color.Empty;
            BUT_EchoGrab.ColorNotEnabled = Color.Empty;
            BUT_EchoGrab.Name = "BUT_EchoGrab";
            BUT_EchoGrab.Outline = Color.Black;
            BUT_EchoGrab.Tag = "";
            BUT_EchoGrab.TextColor = Color.Black;
            BUT_EchoGrab.TextColorNotEnabled = Color.Black;
            BUT_EchoGrab.Click += BUT_EchoGrab_Click;
            // 
            // BUT_StopGrab
            // 
            resources.ApplyResources(BUT_StopGrab, "BUT_StopGrab");
            BUT_StopGrab.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_StopGrab.ColorMouseDown = Color.Empty;
            BUT_StopGrab.ColorMouseOver = Color.Empty;
            BUT_StopGrab.ColorNotEnabled = Color.Empty;
            BUT_StopGrab.Name = "BUT_StopGrab";
            BUT_StopGrab.TextColor = Color.Black;
            BUT_StopGrab.TextColorNotEnabled = Color.Black;
            BUT_StopGrab.Click += BUT_StopGrab_Click;
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(tableLayoutPanel8, "tableLayoutPanel8");
            tableLayoutPanel8.Controls.Add(CurrentR_Indicator, 2, 5);
            tableLayoutPanel8.Controls.Add(Hum_R_Gauge, 2, 4);
            tableLayoutPanel8.Controls.Add(CurrentL_Indicator, 1, 5);
            tableLayoutPanel8.Controls.Add(Hum_L_Gauge, 1, 4);
            tableLayoutPanel8.Controls.Add(Hum_Body_Gauge, 0, 4);
            tableLayoutPanel8.Controls.Add(Temp_R_Gauge, 2, 3);
            tableLayoutPanel8.Controls.Add(Temp_L_Gauge, 1, 3);
            tableLayoutPanel8.Controls.Add(Temp_Body_Gauge, 0, 3);
            tableLayoutPanel8.Controls.Add(Bat_R_Gauge, 2, 2);
            tableLayoutPanel8.Controls.Add(Bat_L_Gauge, 1, 2);
            tableLayoutPanel8.Controls.Add(Bat_Body_Gauge, 0, 2);
            tableLayoutPanel8.Controls.Add(Depth_Gauge, 0, 1);
            tableLayoutPanel8.Controls.Add(Speed_Gauge, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel1, 1, 6);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel3, 2, 6);
            tableLayoutPanel8.Controls.Add(CurrentMain_Indicator, 0, 5);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // CurrentR_Indicator
            // 
            CurrentR_Indicator.AnimationEnabled = false;
            resources.ApplyResources(CurrentR_Indicator, "CurrentR_Indicator");
            CurrentR_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon1;
            CurrentR_Indicator.ErrorLimit = 8D;
            CurrentR_Indicator.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            CurrentR_Indicator.Maximum = 10D;
            CurrentR_Indicator.Name = "CurrentR_Indicator";
            CurrentR_Indicator.ResetValue = 0D;
            CurrentR_Indicator.ScaleFactor = 1D;
            CurrentR_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            CurrentR_Indicator.Title = "";
            CurrentR_Indicator.Unit = "Curr R";
            CurrentR_Indicator.Value = 0D;
            CurrentR_Indicator.ValueFormat = "0.0 A";
            CurrentR_Indicator.WarningLimit = 5D;
            // 
            // Hum_R_Gauge
            // 
            Hum_R_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Hum_R_Gauge, "Hum_R_Gauge");
            Hum_R_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Hum_R_Gauge.ErrorLimit = 70D;
            Hum_R_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Hum_R_Gauge.MajorTicks.Interval = 0D;
            Hum_R_Gauge.MajorTicks.MarkerLength = 5;
            Hum_R_Gauge.Maximum = 100D;
            Hum_R_Gauge.MinorTicks.Interval = 0D;
            Hum_R_Gauge.MinorTicks.MarkerLength = 5;
            Hum_R_Gauge.Name = "Hum_R_Gauge";
            Hum_R_Gauge.PointerEndAngle = 504;
            Hum_R_Gauge.PointerStartAngle = 216;
            Hum_R_Gauge.ResetValue = 0D;
            Hum_R_Gauge.ScaleFactor = 1D;
            Hum_R_Gauge.ScaleLabel.Interval = 10D;
            Hum_R_Gauge.SegmentCount = 50;
            Hum_R_Gauge.SegmentGap = 2;
            Hum_R_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Hum_R_Gauge.Title = "";
            Hum_R_Gauge.Unit = "Hum R";
            Hum_R_Gauge.Value = 1D;
            Hum_R_Gauge.ValueFormat = "0.0";
            Hum_R_Gauge.WarningLimit = 60D;
            // 
            // CurrentL_Indicator
            // 
            CurrentL_Indicator.AnimationEnabled = false;
            resources.ApplyResources(CurrentL_Indicator, "CurrentL_Indicator");
            CurrentL_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon1;
            CurrentL_Indicator.ErrorLimit = 8D;
            CurrentL_Indicator.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            CurrentL_Indicator.Maximum = 10D;
            CurrentL_Indicator.Name = "CurrentL_Indicator";
            CurrentL_Indicator.ResetValue = 0D;
            CurrentL_Indicator.ScaleFactor = 1D;
            CurrentL_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            CurrentL_Indicator.Title = "";
            CurrentL_Indicator.Unit = "Curr L";
            CurrentL_Indicator.Value = 0D;
            CurrentL_Indicator.ValueFormat = "0.0 A";
            CurrentL_Indicator.WarningLimit = 5D;
            // 
            // Hum_L_Gauge
            // 
            Hum_L_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Hum_L_Gauge, "Hum_L_Gauge");
            Hum_L_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Hum_L_Gauge.ErrorLimit = 70D;
            Hum_L_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Hum_L_Gauge.MajorTicks.Interval = 0D;
            Hum_L_Gauge.MajorTicks.MarkerLength = 5;
            Hum_L_Gauge.Maximum = 100D;
            Hum_L_Gauge.MinorTicks.Interval = 0D;
            Hum_L_Gauge.MinorTicks.MarkerLength = 5;
            Hum_L_Gauge.Name = "Hum_L_Gauge";
            Hum_L_Gauge.PointerEndAngle = 504;
            Hum_L_Gauge.PointerStartAngle = 216;
            Hum_L_Gauge.ResetValue = 0D;
            Hum_L_Gauge.ScaleFactor = 1D;
            Hum_L_Gauge.ScaleLabel.Interval = 10D;
            Hum_L_Gauge.SegmentCount = 50;
            Hum_L_Gauge.SegmentGap = 2;
            Hum_L_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Hum_L_Gauge.Title = "";
            Hum_L_Gauge.Unit = "Hum L";
            Hum_L_Gauge.Value = 1D;
            Hum_L_Gauge.ValueFormat = "0.0";
            Hum_L_Gauge.WarningLimit = 60D;
            // 
            // Hum_Body_Gauge
            // 
            Hum_Body_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Hum_Body_Gauge, "Hum_Body_Gauge");
            Hum_Body_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Hum_Body_Gauge.ErrorLimit = 70D;
            Hum_Body_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Hum_Body_Gauge.MajorTicks.Interval = 0D;
            Hum_Body_Gauge.MajorTicks.MarkerLength = 5;
            Hum_Body_Gauge.Maximum = 100D;
            Hum_Body_Gauge.MinorTicks.Interval = 0D;
            Hum_Body_Gauge.MinorTicks.MarkerLength = 5;
            Hum_Body_Gauge.Name = "Hum_Body_Gauge";
            Hum_Body_Gauge.PointerEndAngle = 504;
            Hum_Body_Gauge.PointerStartAngle = 216;
            Hum_Body_Gauge.ResetValue = 0D;
            Hum_Body_Gauge.ScaleFactor = 1D;
            Hum_Body_Gauge.ScaleLabel.Interval = 10D;
            Hum_Body_Gauge.SegmentCount = 50;
            Hum_Body_Gauge.SegmentGap = 2;
            Hum_Body_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Hum_Body_Gauge.Title = "";
            Hum_Body_Gauge.Unit = "Hum B";
            Hum_Body_Gauge.Value = 1D;
            Hum_Body_Gauge.ValueFormat = "0.0";
            Hum_Body_Gauge.WarningLimit = 60D;
            // 
            // Temp_R_Gauge
            // 
            Temp_R_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Temp_R_Gauge, "Temp_R_Gauge");
            Temp_R_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Temp_R_Gauge.ErrorLimit = 50D;
            Temp_R_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Temp_R_Gauge.MajorTicks.Interval = 0D;
            Temp_R_Gauge.MajorTicks.MarkerLength = 5;
            Temp_R_Gauge.Maximum = 100D;
            Temp_R_Gauge.MinorTicks.Interval = 0D;
            Temp_R_Gauge.MinorTicks.MarkerLength = 5;
            Temp_R_Gauge.Name = "Temp_R_Gauge";
            Temp_R_Gauge.PointerEndAngle = 504;
            Temp_R_Gauge.PointerStartAngle = 216;
            Temp_R_Gauge.ResetValue = 0D;
            Temp_R_Gauge.ScaleFactor = 1D;
            Temp_R_Gauge.ScaleLabel.Interval = 10D;
            Temp_R_Gauge.SegmentCount = 50;
            Temp_R_Gauge.SegmentGap = 2;
            Temp_R_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Temp_R_Gauge.Title = "";
            Temp_R_Gauge.Unit = "Tem R";
            Temp_R_Gauge.Value = 1D;
            Temp_R_Gauge.ValueFormat = "0.0";
            Temp_R_Gauge.WarningLimit = 40D;
            // 
            // Temp_L_Gauge
            // 
            Temp_L_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Temp_L_Gauge, "Temp_L_Gauge");
            Temp_L_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Temp_L_Gauge.ErrorLimit = 50D;
            Temp_L_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Temp_L_Gauge.MajorTicks.Interval = 0D;
            Temp_L_Gauge.MajorTicks.MarkerLength = 5;
            Temp_L_Gauge.Maximum = 100D;
            Temp_L_Gauge.MinorTicks.Interval = 0D;
            Temp_L_Gauge.MinorTicks.MarkerLength = 5;
            Temp_L_Gauge.Name = "Temp_L_Gauge";
            Temp_L_Gauge.PointerEndAngle = 504;
            Temp_L_Gauge.PointerStartAngle = 216;
            Temp_L_Gauge.ResetValue = 0D;
            Temp_L_Gauge.ScaleFactor = 1D;
            Temp_L_Gauge.ScaleLabel.Interval = 10D;
            Temp_L_Gauge.SegmentCount = 50;
            Temp_L_Gauge.SegmentGap = 2;
            Temp_L_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Temp_L_Gauge.Title = "";
            Temp_L_Gauge.Unit = "Tem L";
            Temp_L_Gauge.Value = 1D;
            Temp_L_Gauge.ValueFormat = "0.0";
            Temp_L_Gauge.WarningLimit = 40D;
            // 
            // Temp_Body_Gauge
            // 
            Temp_Body_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Temp_Body_Gauge, "Temp_Body_Gauge");
            Temp_Body_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Temp_Body_Gauge.ErrorLimit = 50D;
            Temp_Body_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Temp_Body_Gauge.MajorTicks.Interval = 0D;
            Temp_Body_Gauge.MajorTicks.MarkerLength = 5;
            Temp_Body_Gauge.Maximum = 100D;
            Temp_Body_Gauge.MinorTicks.Interval = 0D;
            Temp_Body_Gauge.MinorTicks.MarkerLength = 5;
            Temp_Body_Gauge.Name = "Temp_Body_Gauge";
            Temp_Body_Gauge.PointerEndAngle = 504;
            Temp_Body_Gauge.PointerStartAngle = 216;
            Temp_Body_Gauge.ResetValue = 0D;
            Temp_Body_Gauge.ScaleFactor = 1D;
            Temp_Body_Gauge.ScaleLabel.Interval = 10D;
            Temp_Body_Gauge.SegmentCount = 50;
            Temp_Body_Gauge.SegmentGap = 2;
            Temp_Body_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Temp_Body_Gauge.Title = "";
            Temp_Body_Gauge.Unit = "Tem B";
            Temp_Body_Gauge.Value = 1D;
            Temp_Body_Gauge.ValueFormat = "0.0";
            Temp_Body_Gauge.WarningLimit = 40D;
            // 
            // Bat_R_Gauge
            // 
            Bat_R_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Bat_R_Gauge, "Bat_R_Gauge");
            Bat_R_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Bat_R_Gauge.ErrorLimit = 10D;
            Bat_R_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Bat_R_Gauge.InvertLimit = true;
            Bat_R_Gauge.MajorTicks.Interval = 0D;
            Bat_R_Gauge.MajorTicks.MarkerLength = 5;
            Bat_R_Gauge.Maximum = 100D;
            Bat_R_Gauge.MinorTicks.Interval = 0D;
            Bat_R_Gauge.MinorTicks.MarkerLength = 5;
            Bat_R_Gauge.Name = "Bat_R_Gauge";
            Bat_R_Gauge.PointerEndAngle = 504;
            Bat_R_Gauge.PointerStartAngle = 216;
            Bat_R_Gauge.ResetValue = 0D;
            Bat_R_Gauge.ScaleFactor = 1D;
            Bat_R_Gauge.ScaleLabel.Interval = 10D;
            Bat_R_Gauge.SegmentCount = 50;
            Bat_R_Gauge.SegmentGap = 2;
            Bat_R_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Bat_R_Gauge.Title = "";
            Bat_R_Gauge.Unit = "Bat R";
            Bat_R_Gauge.Value = 1D;
            Bat_R_Gauge.ValueFormat = "0 \"%\"";
            Bat_R_Gauge.WarningLimit = 30D;
            // 
            // Bat_L_Gauge
            // 
            Bat_L_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Bat_L_Gauge, "Bat_L_Gauge");
            Bat_L_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Bat_L_Gauge.ErrorLimit = 10D;
            Bat_L_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Bat_L_Gauge.InvertLimit = true;
            Bat_L_Gauge.MajorTicks.Interval = 0D;
            Bat_L_Gauge.MajorTicks.MarkerLength = 5;
            Bat_L_Gauge.Maximum = 100D;
            Bat_L_Gauge.MinorTicks.Interval = 0D;
            Bat_L_Gauge.MinorTicks.MarkerLength = 5;
            Bat_L_Gauge.Name = "Bat_L_Gauge";
            Bat_L_Gauge.PointerEndAngle = 504;
            Bat_L_Gauge.PointerStartAngle = 216;
            Bat_L_Gauge.ResetValue = 0D;
            Bat_L_Gauge.ScaleFactor = 1D;
            Bat_L_Gauge.ScaleLabel.Interval = 10D;
            Bat_L_Gauge.SegmentCount = 50;
            Bat_L_Gauge.SegmentGap = 2;
            Bat_L_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Bat_L_Gauge.Title = "";
            Bat_L_Gauge.Unit = "Bat L";
            Bat_L_Gauge.Value = 1D;
            Bat_L_Gauge.ValueFormat = "0 \"%\"";
            Bat_L_Gauge.WarningLimit = 30D;
            // 
            // Depth_Gauge
            // 
            Depth_Gauge.AnimationStep = 1;
            Depth_Gauge.AnimationUpdateInterval = 20;
            Depth_Gauge.BottomBarHeight = 5;
            tableLayoutPanel8.SetColumnSpan(Depth_Gauge, 3);
            resources.ApplyResources(Depth_Gauge, "Depth_Gauge");
            Depth_Gauge.ErrorLimit = 0.1D;
            Depth_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Depth_Gauge.InvertLimit = true;
            Depth_Gauge.LabelWidth = 100;
            Depth_Gauge.Maximum = 1D;
            Depth_Gauge.Name = "Depth_Gauge";
            Depth_Gauge.PeakVisible = true;
            Depth_Gauge.ResetValue = 0D;
            Depth_Gauge.ScaleFactor = 1D;
            Depth_Gauge.SegmentGap = 2;
            Depth_Gauge.SegmentSize = 4;
            Depth_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.NotDefined;
            Depth_Gauge.Title = "Depth (0 - 1m)";
            Depth_Gauge.Unit = "m";
            Depth_Gauge.Value = 0D;
            Depth_Gauge.ValueFormat = "0.00";
            Depth_Gauge.WarningLimit = 0.5D;
            // 
            // Speed_Gauge
            // 
            Speed_Gauge.AnimationStep = 1;
            Speed_Gauge.AnimationUpdateInterval = 20;
            Speed_Gauge.BottomBarHeight = 5;
            tableLayoutPanel8.SetColumnSpan(Speed_Gauge, 3);
            Speed_Gauge.DataBindings.Add(new Binding("Value", bindingSourceHud, "groundspeed", true));
            resources.ApplyResources(Speed_Gauge, "Speed_Gauge");
            Speed_Gauge.ErrorLimit = 0.3D;
            Speed_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Speed_Gauge.Maximum = 0.3D;
            Speed_Gauge.Name = "Speed_Gauge";
            Speed_Gauge.PeakVisible = true;
            Speed_Gauge.ResetValue = 0D;
            Speed_Gauge.ScaleFactor = 1D;
            Speed_Gauge.SegmentGap = 2;
            Speed_Gauge.SegmentSize = 4;
            Speed_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Speed_Gauge.Title = "Speed";
            Speed_Gauge.Unit = "m/s";
            Speed_Gauge.Value = 0.1D;
            Speed_Gauge.ValueFormat = "0.0";
            Speed_Gauge.WarningLimit = 0.2D;
            Speed_Gauge.ErrorLimitReached += Speed_Gauge_ErrorLimitReached;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(progressBarL_Down, 0, 0);
            tableLayoutPanel1.Controls.Add(progressBarL_Up, 1, 0);
            tableLayoutPanel1.Controls.Add(label11, 0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // progressBarL_Down
            // 
            progressBarL_Down.AnimationStep = 100;
            resources.ApplyResources(progressBarL_Down, "progressBarL_Down");
            progressBarL_Down.IgnoreLimits = true;
            progressBarL_Down.InvertLimit = true;
            progressBarL_Down.Maximum = 1500D;
            progressBarL_Down.Minimum = 1000D;
            progressBarL_Down.Name = "progressBarL_Down";
            progressBarL_Down.Orientation = CodeArtEng.Gauge.PanelGauges.LinearIndicatorOrientation.RightToLeft;
            progressBarL_Down.ResetValue = 0D;
            progressBarL_Down.ScaleFactor = 1D;
            progressBarL_Down.SegmentGap = 1;
            progressBarL_Down.Theme = CodeArtEng.Gauge.GaugeTheme.Light_Dark_Background;
            progressBarL_Down.Title = "";
            progressBarL_Down.Unit = "A";
            progressBarL_Down.Value = 1100D;
            // 
            // progressBarL_Up
            // 
            progressBarL_Up.AnimationStep = 100;
            resources.ApplyResources(progressBarL_Up, "progressBarL_Up");
            progressBarL_Up.IgnoreLimits = true;
            progressBarL_Up.InvertLimit = true;
            progressBarL_Up.Maximum = 2000D;
            progressBarL_Up.Minimum = 1500D;
            progressBarL_Up.Name = "progressBarL_Up";
            progressBarL_Up.ResetValue = 0D;
            progressBarL_Up.ScaleFactor = 1D;
            progressBarL_Up.SegmentGap = 1;
            progressBarL_Up.Theme = CodeArtEng.Gauge.GaugeTheme.Light_Dark_Background;
            progressBarL_Up.Title = "";
            progressBarL_Up.Unit = "km/h";
            progressBarL_Up.Value = 1600D;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            tableLayoutPanel1.SetColumnSpan(label11, 2);
            label11.Name = "label11";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(progressBarR_Down, 0, 0);
            tableLayoutPanel3.Controls.Add(progressBarR_Up, 1, 0);
            tableLayoutPanel3.Controls.Add(label20, 0, 1);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // progressBarR_Down
            // 
            progressBarR_Down.AnimationStep = 100;
            resources.ApplyResources(progressBarR_Down, "progressBarR_Down");
            progressBarR_Down.IgnoreLimits = true;
            progressBarR_Down.InvertLimit = true;
            progressBarR_Down.Maximum = 1500D;
            progressBarR_Down.Minimum = 1000D;
            progressBarR_Down.Name = "progressBarR_Down";
            progressBarR_Down.Orientation = CodeArtEng.Gauge.PanelGauges.LinearIndicatorOrientation.RightToLeft;
            progressBarR_Down.ResetValue = 0D;
            progressBarR_Down.ScaleFactor = 1D;
            progressBarR_Down.SegmentGap = 1;
            progressBarR_Down.Theme = CodeArtEng.Gauge.GaugeTheme.Light_Dark_Background;
            progressBarR_Down.Title = "";
            progressBarR_Down.Unit = "km/h";
            progressBarR_Down.Value = 1100D;
            // 
            // progressBarR_Up
            // 
            progressBarR_Up.AnimationStep = 100;
            resources.ApplyResources(progressBarR_Up, "progressBarR_Up");
            progressBarR_Up.IgnoreLimits = true;
            progressBarR_Up.InvertLimit = true;
            progressBarR_Up.Maximum = 2000D;
            progressBarR_Up.Minimum = 1500D;
            progressBarR_Up.Name = "progressBarR_Up";
            progressBarR_Up.ResetValue = 0D;
            progressBarR_Up.ScaleFactor = 1D;
            progressBarR_Up.SegmentGap = 1;
            progressBarR_Up.Theme = CodeArtEng.Gauge.GaugeTheme.Light_Dark_Background;
            progressBarR_Up.Title = "";
            progressBarR_Up.Unit = "km/h";
            progressBarR_Up.Value = 1600D;
            // 
            // label20
            // 
            resources.ApplyResources(label20, "label20");
            tableLayoutPanel3.SetColumnSpan(label20, 2);
            label20.Name = "label20";
            // 
            // CurrentMain_Indicator
            // 
            CurrentMain_Indicator.AnimationEnabled = false;
            CurrentMain_Indicator.DataBindings.Add(new Binding("Value", bindingSourceHud, "current", true, DataSourceUpdateMode.OnValidation, "0"));
            resources.ApplyResources(CurrentMain_Indicator, "CurrentMain_Indicator");
            CurrentMain_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon1;
            CurrentMain_Indicator.ErrorLimit = 8D;
            CurrentMain_Indicator.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            CurrentMain_Indicator.Maximum = 10D;
            CurrentMain_Indicator.Name = "CurrentMain_Indicator";
            CurrentMain_Indicator.ResetValue = 0D;
            CurrentMain_Indicator.ScaleFactor = 1D;
            CurrentMain_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            CurrentMain_Indicator.Title = "";
            CurrentMain_Indicator.Unit = "Curr B";
            CurrentMain_Indicator.Value = 0D;
            CurrentMain_Indicator.ValueFormat = "0.0 A";
            CurrentMain_Indicator.WarningLimit = 5D;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.Controls.Add(Link_Quality_Indicator, 3, 1);
            tableLayoutPanel4.Controls.Add(Dist_To_Home_Indicator, 2, 1);
            tableLayoutPanel4.Controls.Add(BUT_manual, 3, 0);
            tableLayoutPanel4.Controls.Add(BUT_quickrtl, 2, 0);
            tableLayoutPanel4.Controls.Add(BUTrestartmission, 0, 1);
            tableLayoutPanel4.Controls.Add(BUT_clear_track, 1, 1);
            tableLayoutPanel4.Controls.Add(BUT_quickauto, 1, 0);
            tableLayoutPanel4.Controls.Add(BUT_ARM, 0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // Link_Quality_Indicator
            // 
            Link_Quality_Indicator.DataBindings.Add(new Binding("Value", bindingSourceHud, "linkqualitygcs", true, DataSourceUpdateMode.OnValidation, "0", "N0"));
            resources.ApplyResources(Link_Quality_Indicator, "Link_Quality_Indicator");
            Link_Quality_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon2;
            Link_Quality_Indicator.ErrorLimit = 25D;
            Link_Quality_Indicator.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Link_Quality_Indicator.InvertLimit = true;
            Link_Quality_Indicator.Maximum = 100D;
            Link_Quality_Indicator.Name = "Link_Quality_Indicator";
            Link_Quality_Indicator.ResetValue = 0D;
            Link_Quality_Indicator.ScaleFactor = 1D;
            Link_Quality_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Link_Quality_Indicator.Title = "";
            Link_Quality_Indicator.Unit = "Link";
            Link_Quality_Indicator.Value = 1D;
            Link_Quality_Indicator.ValueFormat = "0 \"%\"";
            Link_Quality_Indicator.WarningLimit = 40D;
            // 
            // Dist_To_Home_Indicator
            // 
            Dist_To_Home_Indicator.DataBindings.Add(new Binding("Value", bindingSourceHud, "DistToHome", true));
            resources.ApplyResources(Dist_To_Home_Indicator, "Dist_To_Home_Indicator");
            Dist_To_Home_Indicator.DrawStyle = CodeArtEng.Gauge.RectangleIndicatorDrawStyle.Hexagon1;
            Dist_To_Home_Indicator.ErrorLimit = 1000D;
            Dist_To_Home_Indicator.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Dist_To_Home_Indicator.Name = "Dist_To_Home_Indicator";
            Dist_To_Home_Indicator.ResetValue = 0D;
            Dist_To_Home_Indicator.ScaleFactor = 1D;
            Dist_To_Home_Indicator.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Dist_To_Home_Indicator.Title = "";
            Dist_To_Home_Indicator.Unit = "Dist to H";
            Dist_To_Home_Indicator.Value = 1D;
            Dist_To_Home_Indicator.ValueFormat = "0 m";
            Dist_To_Home_Indicator.WarningLimit = 500D;
            // 
            // BUT_manual
            // 
            resources.ApplyResources(BUT_manual, "BUT_manual");
            BUT_manual.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_manual.ColorMouseDown = Color.Empty;
            BUT_manual.ColorMouseOver = Color.Empty;
            BUT_manual.ColorNotEnabled = Color.Empty;
            BUT_manual.Name = "BUT_manual";
            BUT_manual.Outline = Color.FromArgb(148, 193, 50);
            BUT_manual.TextColor = Color.Black;
            BUT_manual.TextColorNotEnabled = Color.Black;
            BUT_manual.Click += BUT_manual_Click;
            // 
            // BUT_quickrtl
            // 
            resources.ApplyResources(BUT_quickrtl, "BUT_quickrtl");
            BUT_quickrtl.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_quickrtl.ColorMouseDown = Color.Empty;
            BUT_quickrtl.ColorMouseOver = Color.Empty;
            BUT_quickrtl.ColorNotEnabled = Color.Empty;
            BUT_quickrtl.Name = "BUT_quickrtl";
            BUT_quickrtl.Outline = Color.FromArgb(148, 193, 50);
            BUT_quickrtl.TextColor = Color.Black;
            BUT_quickrtl.TextColorNotEnabled = Color.Black;
            BUT_quickrtl.Click += BUT_quickrtl_Click;
            // 
            // BUTrestartmission
            // 
            resources.ApplyResources(BUTrestartmission, "BUTrestartmission");
            BUTrestartmission.BGGradBot = Color.FromArgb(148, 193, 31);
            BUTrestartmission.ColorMouseDown = Color.Empty;
            BUTrestartmission.ColorMouseOver = Color.Empty;
            BUTrestartmission.ColorNotEnabled = Color.Empty;
            BUTrestartmission.Name = "BUTrestartmission";
            BUTrestartmission.Outline = Color.FromArgb(148, 193, 50);
            BUTrestartmission.TextColor = Color.Black;
            BUTrestartmission.TextColorNotEnabled = Color.Black;
            BUTrestartmission.Click += BUTrestartmission_Click;
            // 
            // BUT_clear_track
            // 
            resources.ApplyResources(BUT_clear_track, "BUT_clear_track");
            BUT_clear_track.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_clear_track.ColorMouseDown = Color.Empty;
            BUT_clear_track.ColorMouseOver = Color.Empty;
            BUT_clear_track.ColorNotEnabled = Color.Empty;
            BUT_clear_track.Name = "BUT_clear_track";
            BUT_clear_track.Outline = Color.FromArgb(148, 193, 50);
            BUT_clear_track.TextColor = Color.Black;
            BUT_clear_track.TextColorNotEnabled = Color.Black;
            BUT_clear_track.Click += BUT_clear_track_Click;
            // 
            // BUT_quickauto
            // 
            resources.ApplyResources(BUT_quickauto, "BUT_quickauto");
            BUT_quickauto.BackColor = SystemColors.Control;
            BUT_quickauto.BGGradBot = Color.FromArgb(148, 193, 31);
            BUT_quickauto.ColorMouseDown = Color.Empty;
            BUT_quickauto.ColorMouseOver = Color.Empty;
            BUT_quickauto.ColorNotEnabled = Color.Empty;
            BUT_quickauto.ForeColor = SystemColors.ControlText;
            BUT_quickauto.Name = "BUT_quickauto";
            BUT_quickauto.Outline = Color.FromArgb(148, 193, 50);
            BUT_quickauto.TextColor = Color.Black;
            BUT_quickauto.TextColorNotEnabled = Color.Black;
            BUT_quickauto.UseVisualStyleBackColor = true;
            BUT_quickauto.Click += BUT_quickauto_Click;
            // 
            // BUT_ARM
            // 
            resources.ApplyResources(BUT_ARM, "BUT_ARM");
            BUT_ARM.BGGradBot = Color.FromArgb(255, 128, 128);
            BUT_ARM.BGGradTop = Color.FromArgb(255, 192, 192);
            BUT_ARM.ColorMouseDown = Color.Empty;
            BUT_ARM.ColorMouseOver = Color.Empty;
            BUT_ARM.ColorNotEnabled = Color.Empty;
            BUT_ARM.Name = "BUT_ARM";
            BUT_ARM.Outline = Color.Black;
            BUT_ARM.TextColor = Color.Black;
            BUT_ARM.TextColorNotEnabled = Color.Black;
            BUT_ARM.Click += BUT_ARM_Click;
            // 
            // Storage_Gauge
            // 
            Storage_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Storage_Gauge, "Storage_Gauge");
            Storage_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.SegmentMultiColor;
            Storage_Gauge.ErrorLimit = 95D;
            Storage_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Storage_Gauge.MajorTicks.Interval = 0D;
            Storage_Gauge.MajorTicks.MarkerLength = 5;
            Storage_Gauge.Maximum = 100D;
            Storage_Gauge.MinorTicks.Interval = 0D;
            Storage_Gauge.MinorTicks.MarkerLength = 5;
            Storage_Gauge.Name = "Storage_Gauge";
            Storage_Gauge.PointerEndAngle = 504;
            Storage_Gauge.PointerStartAngle = 216;
            Storage_Gauge.ResetValue = 0D;
            Storage_Gauge.ScaleFactor = 1D;
            Storage_Gauge.ScaleLabel.Interval = 10D;
            Storage_Gauge.SegmentCount = 20;
            Storage_Gauge.SegmentGap = 3;
            Storage_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Storage_Gauge.Title = "";
            Storage_Gauge.Unit = "Mem";
            Storage_Gauge.Value = 1D;
            Storage_Gauge.ValueFormat = "0 \"%\"";
            Storage_Gauge.WarningLimit = 80D;
            // 
            // tableLayoutPanel15
            // 
            resources.ApplyResources(tableLayoutPanel15, "tableLayoutPanel15");
            tableLayoutPanel15.Controls.Add(Storage_Gauge, 0, 0);
            tableLayoutPanel15.Controls.Add(Satellites_Gauge, 0, 1);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            // 
            // Satellites_Gauge
            // 
            Satellites_Gauge.AnimationEnabled = false;
            resources.ApplyResources(Satellites_Gauge, "Satellites_Gauge");
            Satellites_Gauge.DataBindings.Add(new Binding("Value", bindingSourceHud, "satcount", true, DataSourceUpdateMode.OnValidation, "0", "N0"));
            Satellites_Gauge.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            Satellites_Gauge.ErrorLimit = 5D;
            Satellites_Gauge.InfoPage = CodeArtEng.Gauge.GaugeInfoType.Limits;
            Satellites_Gauge.InvertLimit = true;
            Satellites_Gauge.MajorTicks.Interval = 0D;
            Satellites_Gauge.MajorTicks.MarkerLength = 5;
            Satellites_Gauge.Maximum = 30D;
            Satellites_Gauge.MinorTicks.Interval = 0D;
            Satellites_Gauge.MinorTicks.MarkerLength = 5;
            Satellites_Gauge.Name = "Satellites_Gauge";
            Satellites_Gauge.PointerEndAngle = 504;
            Satellites_Gauge.PointerStartAngle = 216;
            Satellites_Gauge.ResetValue = 0D;
            Satellites_Gauge.ScaleFactor = 1D;
            Satellites_Gauge.ScaleLabel.Interval = 10D;
            Satellites_Gauge.SegmentCount = 36;
            Satellites_Gauge.SegmentGap = 3;
            Satellites_Gauge.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            Satellites_Gauge.Title = "";
            Satellites_Gauge.Unit = "# Sat";
            Satellites_Gauge.Value = 1D;
            Satellites_Gauge.WarningLimit = 8D;
            // 
            // hud1
            // 
            hud1.airspeed = 0F;
            hud1.alt = 0F;
            hud1.altunit = null;
            hud1.AOA = 0F;
            resources.ApplyResources(hud1, "hud1");
            hud1.BackColor = Color.Black;
            hud1.batterycellcount = 0;
            hud1.batterylevel = 0F;
            hud1.batterylevel2 = 0F;
            hud1.batteryon = false;
            hud1.batteryon2 = false;
            hud1.batteryremaining = 50F;
            hud1.batteryremaining2 = 0F;
            hud1.bgimage = null;
            hud1.connected = false;
            hud1.critAOA = 25F;
            hud1.criticalvoltagealert = false;
            hud1.critSSA = 30F;
            hud1.current = 0F;
            hud1.current2 = 0F;
            hud1.DataBindings.Add(new Binding("airspeed", bindingSourceHud, "airspeed", true));
            hud1.DataBindings.Add(new Binding("alt", bindingSourceHud, "alt", true));
            hud1.DataBindings.Add(new Binding("AOA", bindingSourceHud, "AOA", true));
            hud1.DataBindings.Add(new Binding("batterylevel", bindingSourceHud, "battery_voltage", true));
            hud1.DataBindings.Add(new Binding("connected", bindingSourceHud, "connected", true));
            hud1.DataBindings.Add(new Binding("critAOA", bindingSourceHud, "crit_AOA", true));
            hud1.DataBindings.Add(new Binding("current", bindingSourceHud, "current", true));
            hud1.DataBindings.Add(new Binding("datetime", bindingSourceHud, "datetime", true));
            hud1.DataBindings.Add(new Binding("disttowp", bindingSourceHud, "wp_dist", true));
            hud1.DataBindings.Add(new Binding("ekfstatus", bindingSourceHud, "ekfstatus", true));
            hud1.DataBindings.Add(new Binding("failsafe", bindingSourceHud, "failsafe", true));
            hud1.DataBindings.Add(new Binding("gpsfix", bindingSourceHud, "gpsstatus", true));
            hud1.DataBindings.Add(new Binding("gpsfix2", bindingSourceHud, "gpsstatus2", true));
            hud1.DataBindings.Add(new Binding("gpshdop", bindingSourceHud, "gpshdop", true));
            hud1.DataBindings.Add(new Binding("gpshdop2", bindingSourceHud, "gpshdop2", true));
            hud1.DataBindings.Add(new Binding("groundalt", bindingSourceHud, "HomeAlt", true));
            hud1.DataBindings.Add(new Binding("groundcourse", bindingSourceHud, "groundcourse", true));
            hud1.DataBindings.Add(new Binding("groundspeed", bindingSourceHud, "groundspeed", true));
            hud1.DataBindings.Add(new Binding("heading", bindingSourceHud, "yaw", true));
            hud1.DataBindings.Add(new Binding("linkqualitygcs", bindingSourceHud, "linkqualitygcs", true));
            hud1.DataBindings.Add(new Binding("message", bindingSourceHud, "messageHigh", true));
            hud1.DataBindings.Add(new Binding("mode", bindingSourceHud, "mode", true));
            hud1.DataBindings.Add(new Binding("navpitch", bindingSourceHud, "nav_pitch", true));
            hud1.DataBindings.Add(new Binding("navroll", bindingSourceHud, "nav_roll", true));
            hud1.DataBindings.Add(new Binding("pitch", bindingSourceHud, "pitch", true));
            hud1.DataBindings.Add(new Binding("roll", bindingSourceHud, "roll", true));
            hud1.DataBindings.Add(new Binding("SSA", bindingSourceHud, "SSA", true));
            hud1.DataBindings.Add(new Binding("status", bindingSourceHud, "armed", true));
            hud1.DataBindings.Add(new Binding("targetalt", bindingSourceHud, "targetalt", true));
            hud1.DataBindings.Add(new Binding("targetheading", bindingSourceHud, "nav_bearing", true));
            hud1.DataBindings.Add(new Binding("targetspeed", bindingSourceHud, "targetairspeed", true));
            hud1.DataBindings.Add(new Binding("turnrate", bindingSourceHud, "turnrate", true));
            hud1.DataBindings.Add(new Binding("verticalspeed", bindingSourceHud, "verticalspeed", true));
            hud1.DataBindings.Add(new Binding("vibex", bindingSourceHud, "vibex", true));
            hud1.DataBindings.Add(new Binding("vibey", bindingSourceHud, "vibey", true));
            hud1.DataBindings.Add(new Binding("vibez", bindingSourceHud, "vibez", true));
            hud1.DataBindings.Add(new Binding("wpno", bindingSourceHud, "wpno", true));
            hud1.DataBindings.Add(new Binding("xtrack_error", bindingSourceHud, "xtrack_error", true));
            hud1.datetime = new DateTime(0L);
            hud1.displayAOASSA = false;
            hud1.displayCellVoltage = false;
            hud1.displayconninfo = false;
            hud1.displayheading = false;
            hud1.displayspeed = false;
            hud1.displayvibe = false;
            hud1.displayxtrack = false;
            hud1.disttowp = 0F;
            hud1.distunit = "m";
            hud1.ekfstatus = 0F;
            hud1.failsafe = false;
            hud1.gpsfix = 0F;
            hud1.gpsfix2 = 0F;
            hud1.gpshdop = 0F;
            hud1.gpshdop2 = 0F;
            hud1.groundalt = 0F;
            hud1.groundcourse = 0F;
            hud1.groundspeed = 0F;
            hud1.heading = 0F;
            hud1.hudcolor = Color.LightGray;
            hud1.linkqualitygcs = 0F;
            hud1.load = 0F;
            hud1.lowairspeed = false;
            hud1.lowgroundspeed = false;
            hud1.lowvoltagealert = true;
            hud1.message = "";
            hud1.messageSeverity = MAVLink.MAV_SEVERITY.EMERGENCY;
            hud1.mode = "Unknown";
            hud1.Name = "hud1";
            hud1.navpitch = 0F;
            hud1.navroll = 0F;
            hud1.pitch = 0F;
            hud1.prearmstatus = false;
            hud1.roll = 0F;
            hud1.Russian = true;
            hud1.skyColor1 = Color.Blue;
            hud1.skyColor2 = Color.LightBlue;
            hud1.speedunit = null;
            hud1.SSA = 0F;
            hud1.status = false;
            hud1.targetalt = 0F;
            hud1.targetheading = 0F;
            hud1.targetspeed = 0F;
            hud1.turnrate = 0F;
            hud1.verticalspeed = 0F;
            hud1.vibex = 0F;
            hud1.vibey = 0F;
            hud1.vibez = 0F;
            hud1.VSync = false;
            hud1.wpno = 0;
            hud1.xtrack_error = 0F;
            hud1.ekfclick += hud1_ekfclick;
            hud1.vibeclick += hud1_vibeclick;
            hud1.DoubleClick += hud1_DoubleClick;
            // 
            // MainH
            // 
            resources.ApplyResources(MainH, "MainH");
            MainH.FixedPanel = FixedPanel.Panel1;
            MainH.Name = "MainH";
            // 
            // MainH.Panel1
            // 
            MainH.Panel1.Controls.Add(tableLayoutPanel13);
            // 
            // MainH.Panel2
            // 
            MainH.Panel2.Controls.Add(tableMap);
            // 
            // tableLayoutPanel13
            // 
            resources.ApplyResources(tableLayoutPanel13, "tableLayoutPanel13");
            tableLayoutPanel13.Controls.Add(tableLayoutPanel11, 0, 4);
            tableLayoutPanel13.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel13.Controls.Add(tableLayoutPanel8, 0, 3);
            tableLayoutPanel13.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel13.Controls.Add(tableLayoutPanel14, 0, 0);
            tableLayoutPanel13.Controls.Add(tableLayoutPaneltlogs, 0, 5);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            // 
            // tableLayoutPanel14
            // 
            resources.ApplyResources(tableLayoutPanel14, "tableLayoutPanel14");
            tableLayoutPanel14.Controls.Add(hud1, 0, 0);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel15, 1, 0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            // 
            // ZedGraphTimer
            // 
            ZedGraphTimer.Tick += timer1_Tick;
            // 
            // label15
            // 
            label15.AutoEllipsis = true;
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // label16
            // 
            label16.AutoEllipsis = true;
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            // 
            // BUT_EchoGrab_BlinkTimer
            // 
            BUT_EchoGrab_BlinkTimer.Interval = 500;
            BUT_EchoGrab_BlinkTimer.Tick += BUT_EchoGrab_BlinkTimer_Tick;
            // 
            // PingTimer
            // 
            PingTimer.Enabled = true;
            PingTimer.Interval = 2000;
            PingTimer.Tick += PingTimer_Tick;
            // 
            // FlightData
            // 
            Controls.Add(MainH);
            resources.ApplyResources(this, "$this");
            Name = "FlightData";
            FormClosing += FlightData_FormClosing;
            Load += FlightData_Load;
            Resize += FlightData_Resize;
            ((System.ComponentModel.ISupportInitialize)bindingSourceHud).EndInit();
            contextMenuStripMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Zoomlevel).EndInit();
            tableMap.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TRK_zoom).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPaneltlogs.ResumeLayout(false);
            tableLayoutPaneltlogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tracklog).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NUM_DepthAlarmValue).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            MainH.Panel1.ResumeLayout(false);
            MainH.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainH).EndInit();
            MainH.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            ResumeLayout(false);
        }

        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private ToolStripMenuItem goHereToolStripMenuItem1;
        private ToolTip toolTip1;
        private ToolStripMenuItem pointCameraHereToolStripMenuItem;
        private ToolStripMenuItem flyToHereAltToolStripMenuItem;
        private ToolStripMenuItem flightPlannerToolStripMenuItem;
        private ToolStripMenuItem triggerCameraToolStripMenuItem;
        private BindingSource bindingSourceHud;
        public ContextMenuStrip contextMenuStripMap;
        private ToolStripMenuItem setHomeHereToolStripMenuItem;
        private ToolStripMenuItem addPoiToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem takeOffToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem PointCameraCoordsToolStripMenuItem1;
        private ToolStripMenuItem onOffCameraOverlapToolStripMenuItem;
        private ToolStripMenuItem altitudeAngelSettingsToolStripMenuItem;
        private ToolStripMenuItem setEKFHomeHereToolStripMenuItem;
        private ToolStripMenuItem setHomeHereToolStripMenuItem1;
        private ToolStripMenuItem setHomeHereToolStripMenuItem2;
        private System.Windows.Forms.Timer TimerUpdateSecondMAV;
        private System.Windows.Forms.Timer depthAlertTimer;
        private ImageList imageList1;
        private ImageList imageList2;
        private TableLayoutPanel tableMap;
        private SplitContainer splitContainer1;
        private ZedGraph.ZedGraphControl zg1;
        private ComboBox COMBJOY;
        private Controls.MyButton but_disablejoystick;
        private Controls.DistanceBar distanceBar1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        public Controls.myGMAP gMapControl1;
        private Controls.MyTrackBar TRK_zoom;
        private Panel panel1;
        private Label label19;
        private Label label18;
        private Controls.Coords coords1;
        private NumericUpDown Zoomlevel;
        private CheckBox CHK_autopan;
        private CheckBox CB_tuning;
        private Controls.HUD hud1;
        private TableLayoutPanel tableLayoutPanel4;
        private Controls.MyButton BUT_manual;
        private Controls.MyButton BUT_quickauto;
        private Controls.MyButton BUT_quickrtl;
        private Controls.MyButton BUTrestartmission;
        private Controls.MyButton BUT_clear_track;
        private Controls.MyButton BUT_ARM;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel7;
        private ComboBox CMB_setwp;
        private Controls.MyButton BUT_setwp;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel6;
        private Controls.MyButton BUT_EchoGrab;
        private Controls.MyButton BUT_StopGrab;
        private TableLayoutPanel tableLayoutPanel8;
        private NumericUpDown NUM_DepthAlarmValue;
        private Button BUT_MuteDepthAlarm;
        private TableLayoutPanel tableLayoutPaneltlogs;
        private Controls.MyButton BUT_loadtelem;
        private TrackBar tracklog;
        private Controls.MyButton BUT_playlog;
        private Panel panel2;
        private Controls.MyButton BUT_speed10;
        private Controls.MyButton BUT_speed5;
        private Controls.MyButton BUT_speed2;
        private Controls.MyButton BUT_speed1;
        private Controls.MyButton BUT_speed1_2;
        private Controls.MyButton BUT_speed1_4;
        private Controls.MyButton BUT_speed1_10;
        private SplitContainer MainH;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label7;
        private Label LBL_TimeRemain;
        private Controls.LineSeparator lineSeparator1;
        private Label label17;
        private Label LBL_TotalDist;
        private Label LBL_TraveledDist;
        private Label LBL_MissionCompleted;
        private Label label15;
        private Label label16;
        private System.Windows.Forms.Timer BUT_EchoGrab_BlinkTimer;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel14;
        private CodeArtEng.Gauge.CircularGauge Storage_Gauge;
        private TableLayoutPanel tableLayoutPanel15;
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
        private TableLayoutPanel tableLayoutPanel1;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator progressBarL_Down;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator progressBarL_Up;
        private CodeArtEng.Gauge.RectangleIndicator CurrentR_Indicator;
        private CodeArtEng.Gauge.RectangleIndicator CurrentL_Indicator;
        private TableLayoutPanel tableLayoutPanel3;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator progressBarR_Down;
        private CodeArtEng.Gauge.PanelGauges.PanelGaugeLinearIndicator progressBarR_Up;
        private Label label11;
        private Label label20;
        private CodeArtEng.Gauge.RectangleIndicator CurrentMain_Indicator;
        private Controls.MyButton BUT_ClearEchoData;
        private Controls.MyButton BUT_DownloadEchoData;
        private System.Windows.Forms.Timer PingTimer;
    }
}