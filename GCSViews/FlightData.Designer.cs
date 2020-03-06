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
            this.tabQuick = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelQuick = new System.Windows.Forms.TableLayoutPanel();
            this.s = new System.Windows.Forms.Label();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblindicadores = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.LBLwp_dist = new System.Windows.Forms.Label();
            this.LBLrangefinder1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LBLDistToHome = new System.Windows.Forms.Label();
            this.LBLgroundspeed = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_quickauto = new MissionPlanner.Controls.MyButton();
            this.BUT_quickrtl = new MissionPlanner.Controls.MyButton();
            this.BUT_resumemis = new MissionPlanner.Controls.MyButton();
            this.BUT_quickmanual = new MissionPlanner.Controls.MyButton();
            this.ButJoyOn = new MissionPlanner.Controls.MyButton();
            this.BUTrestartmission = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_joystick_settings = new MissionPlanner.Controls.MyButton();
            this.BUT_ARM = new MissionPlanner.Controls.MyButton();
            this.BUT_clear_track = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_setwp = new MissionPlanner.Controls.MyButton();
            this.CMB_setwp = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.CMB_modes = new System.Windows.Forms.ComboBox();
            this.BUT_setmode = new MissionPlanner.Controls.MyButton();
            this.BUT_Homealt = new MissionPlanner.Controls.MyButton();
            this.BUT_abortland = new MissionPlanner.Controls.MyButton();
            this.CMB_mountmode = new System.Windows.Forms.ComboBox();
            this.BUT_mountmode = new MissionPlanner.Controls.MyButton();
            this.CMB_action = new System.Windows.Forms.ComboBox();
            this.BUT_RAWSensor = new MissionPlanner.Controls.MyButton();
            this.BUTactiondo = new MissionPlanner.Controls.MyButton();
            this.tabActionsSimple = new System.Windows.Forms.TabPage();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.tabPagePreFlight = new System.Windows.Forms.TabPage();
            this.tabGauges = new System.Windows.Forms.TabPage();
            this.Gvspeed = new AGaugeApp.AGauge();
            this.Gheading = new MissionPlanner.Controls.HSI();
            this.Galt = new AGaugeApp.AGauge();
            this.Gspeed = new AGaugeApp.AGauge();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tabServo = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelServos = new System.Windows.Forms.FlowLayoutPanel();
            this.tabTLogs = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_DFMavlink = new MissionPlanner.Controls.MyButton();
            this.BUT_matlab = new MissionPlanner.Controls.MyButton();
            this.but_bintolog = new MissionPlanner.Controls.MyButton();
            this.but_dflogtokml = new MissionPlanner.Controls.MyButton();
            this.BUT_loganalysis = new MissionPlanner.Controls.MyButton();
            this.BUT_logbrowse = new MissionPlanner.Controls.MyButton();
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
            this.tablogbrowse = new System.Windows.Forms.TabPage();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.checkBoxRedirectOutput = new System.Windows.Forms.CheckBox();
            this.BUT_edit_selected = new MissionPlanner.Controls.MyButton();
            this.labelSelectedScript = new System.Windows.Forms.Label();
            this.BUT_run_script = new MissionPlanner.Controls.MyButton();
            this.BUT_abort_script = new MissionPlanner.Controls.MyButton();
            this.labelScriptStatus = new System.Windows.Forms.Label();
            this.BUT_select_script = new MissionPlanner.Controls.MyButton();
            this.tabPagemessages = new System.Windows.Forms.TabPage();
            this.txt_messagebox = new System.Windows.Forms.TextBox();
            this.tabPayload = new System.Windows.Forms.TabPage();
            this.BUT_PayloadFolder = new MissionPlanner.Controls.MyButton();
            this.groupBoxRoll = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalRollPos = new System.Windows.Forms.TextBox();
            this.bindingSourcePayloadTab = new System.Windows.Forms.BindingSource(this.components);
            this.trackBarRoll = new System.Windows.Forms.TrackBar();
            this.groupBoxYaw = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalYawPos = new System.Windows.Forms.TextBox();
            this.trackBarYaw = new System.Windows.Forms.TrackBar();
            this.BUT_resetGimbalPos = new MissionPlanner.Controls.MyButton();
            this.groupBoxPitch = new System.Windows.Forms.GroupBox();
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.TXT_gimbalPitchPos = new System.Windows.Forms.TextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groundspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wpdistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distToHomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangefinder1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groundcourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altaslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horizondistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altoffsethomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpshdopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpshaccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsvaccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsvelaccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpshdgaccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lat2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lng2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altasl2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsstatus2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpshdop2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satcount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groundspeed2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groundcourse2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satcountBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpstimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altd1000DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altd100DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetairspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowairspeedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.asratioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.azDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelsqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrosqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magfieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ax2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ay2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.az2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelsq2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gx2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gy2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gz2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrosq2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mx2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.my2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mz2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magfield2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ax3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ay3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.az3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelsq3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gx3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gy3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gz3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrosq3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mx3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.my3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mz3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magfield3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch1inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch2inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch3inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch4inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch5inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch6inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch7inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch8inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch9inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch10inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch11inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch12inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch13inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch14inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch15inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch16inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch1outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch2outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch3outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch4outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch5outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch6outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch7outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch8outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch9outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch10outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch11outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch12outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch13outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch14outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch15outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch16outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc1voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc1currDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc1rpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc1tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc2voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc2currDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc2rpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc2tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc3voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc3currDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc3rpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc3tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc4voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc4currDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc4rpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc4tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc5voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc5currDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc5rpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc5tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc6voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc6currDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc6rpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc6tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc7voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc7currDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc7rpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc7tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc8voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc8currDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc8rpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc8tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch3percentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failsafeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rxrssiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.critAOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowgroundspeedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.verticalspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verticalspeedfpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glideratioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navrollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navpitchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navbearingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetbearingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alterrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bererrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aspderrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtrackerrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wpnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.climbrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tohDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distTraveledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSinceArmInAirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInAirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInAirMinSecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winddirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windvelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetaltd100DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetaltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageHighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageHighTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wattsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterymahperkmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterykmleftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterytempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movingBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackerLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distFromMovingBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLToMAVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aZToMAVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonarrangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonarvoltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangefinder2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangefinder3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freememDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brklevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rssiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remrssiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbufferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remnoiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rxerrorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localsnrdbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remotesnrdbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distRSSIRemainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packetdropremoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkqualitygcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hwvoltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardvoltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servovoltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i2cerrorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timesincelastshotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressabsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presstempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressabs2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presstemp2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magofsxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magofsyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magofszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magdeclinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawpressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawtempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrocalxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrocalyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrocalzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelcalxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelcalyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelcalzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateattitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratepositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratesensorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratercDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.campointaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campointbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campointcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gimbalPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gimballatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gimballngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.terrainactiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tercuraltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teraltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terpendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terspaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optmxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optquaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfflagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfvelvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfcompvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfposhorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfposvertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfteraltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidaxisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piddesiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidachievedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibeclip0DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibeclip1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibeclip2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibezDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpm1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpm2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capabilitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtolstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landedstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceQuickTab = new System.Windows.Forms.BindingSource(this.components);
            this.COMBJOY = new System.Windows.Forms.ComboBox();
            this.but_disablejoystick = new MissionPlanner.Controls.MyButton();
            this.windDir1 = new MissionPlanner.Controls.WindDir();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gMapControl1 = new MissionPlanner.Controls.myGMAP();
            this.TRK_zoom = new MissionPlanner.Controls.MyTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBLSignal = new System.Windows.Forms.Label();
            this.lblconexwifi = new System.Windows.Forms.Label();
            this.comboBoxMapTypeData = new System.Windows.Forms.ComboBox();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.Zoomlevel = new System.Windows.Forms.NumericUpDown();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
            this.CB_tuning = new System.Windows.Forms.CheckBox();
            this.contextMenuStripactionstab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceGaugesTab = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStripQuickView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setViewCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZedGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.scriptChecker = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Messagetabtimer = new System.Windows.Forms.Timer(this.components);
            this.bindingSourceStatusTab = new System.Windows.Forms.BindingSource(this.components);
            this.RecargaLbl = new System.Windows.Forms.Timer(this.components);
            this.TimerAlertEchosounder = new System.Windows.Forms.Timer(this.components);
            this.modifyandSetSpeed = new MissionPlanner.Controls.ModifyandSet();
            this.modifyandSetLoiterRad = new MissionPlanner.Controls.ModifyandSet();
            this.modifyandSetAlt = new MissionPlanner.Controls.ModifyandSet();
            this.checkListControl1 = new MissionPlanner.Controls.PreFlight.CheckListControl();
            this.servoOptions1 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions2 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions3 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions4 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions5 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions6 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions7 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions8 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions9 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions10 = new MissionPlanner.Controls.ServoOptions();
            this.relayOptions1 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions2 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions3 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions4 = new MissionPlanner.Controls.RelayOptions();
            this.distanceBar1 = new MissionPlanner.Controls.DistanceBar();
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
            this.tabQuick.SuspendLayout();
            this.tableLayoutPanelQuick.SuspendLayout();
            this.tabActions.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tabActionsSimple.SuspendLayout();
            this.tabPagePreFlight.SuspendLayout();
            this.tabGauges.SuspendLayout();
            this.tabServo.SuspendLayout();
            this.flowLayoutPanelServos.SuspendLayout();
            this.tabTLogs.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPaneltlogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabScripts.SuspendLayout();
            this.tabPagemessages.SuspendLayout();
            this.tabPayload.SuspendLayout();
            this.groupBoxRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).BeginInit();
            this.groupBoxYaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).BeginInit();
            this.groupBoxPitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            this.tableMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).BeginInit();
            this.contextMenuStripactionstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).BeginInit();
            this.contextMenuStripQuickView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).BeginInit();
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
            this.SubMainLeft.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SubMainLeft_Panel2_Paint);
            this.SubMainLeft.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SubMainLeft_SplitterMoved);
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
            this.hud1.batteryremaining = 0F;
            this.hud1.bgimage = null;
            this.hud1.connected = false;
            this.hud1.ContextMenuStrip = this.contextMenuStripHud;
            this.hud1.critAOA = 25F;
            this.hud1.critSSA = 30F;
            this.hud1.current = 0F;
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.bindingSourceHud, "airspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("alt", this.bindingSourceHud, "alt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining", this.bindingSourceHud, "battery_remaining", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("connected", this.bindingSourceHud, "connected", true));
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
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("AOA", this.bindingSourceHud, "AOA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("SSA", this.bindingSourceHud, "SSA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("critAOA", this.bindingSourceHud, "crit_AOA", true));
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
            this.hud1.lowvoltagealert = false;
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
            resources.ApplyResources(this.tabControlactions, "tabControlactions");
            this.tabControlactions.Controls.Add(this.tabQuick);
            this.tabControlactions.Controls.Add(this.tabActions);
            this.tabControlactions.Controls.Add(this.tabActionsSimple);
            this.tabControlactions.Controls.Add(this.tabPagePreFlight);
            this.tabControlactions.Controls.Add(this.tabGauges);
            this.tabControlactions.Controls.Add(this.tabStatus);
            this.tabControlactions.Controls.Add(this.tabServo);
            this.tabControlactions.Controls.Add(this.tabTLogs);
            this.tabControlactions.Controls.Add(this.tablogbrowse);
            this.tabControlactions.Controls.Add(this.tabScripts);
            this.tabControlactions.Controls.Add(this.tabPagemessages);
            this.tabControlactions.Controls.Add(this.tabPayload);
            this.tabControlactions.Multiline = true;
            this.tabControlactions.Name = "tabControlactions";
            this.tabControlactions.SelectedIndex = 0;
            this.tabControlactions.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlactions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControlactions.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuick
            // 
            resources.ApplyResources(this.tabQuick, "tabQuick");
            this.tabQuick.Controls.Add(this.tableLayoutPanelQuick);
            this.tabQuick.Name = "tabQuick";
            this.tabQuick.Resize += new System.EventHandler(this.tabQuick_Resize);
            // 
            // tableLayoutPanelQuick
            // 
            resources.ApplyResources(this.tableLayoutPanelQuick, "tableLayoutPanelQuick");
            this.tableLayoutPanelQuick.Controls.Add(this.s, 1, 0);
            this.tableLayoutPanelQuick.Name = "tableLayoutPanelQuick";
            this.tableLayoutPanelQuick.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelQuick_Paint);
            this.tableLayoutPanelQuick.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // s
            // 
            resources.ApplyResources(this.s, "s");
            this.s.Name = "s";
            // 
            // tabActions
            // 
            resources.ApplyResources(this.tabActions, "tabActions");
            this.tabActions.Controls.Add(this.flowLayoutPanel1);
            this.tabActions.Controls.Add(this.BUT_Homealt);
            this.tabActions.Controls.Add(this.BUT_abortland);
            this.tabActions.Controls.Add(this.CMB_mountmode);
            this.tabActions.Controls.Add(this.BUT_mountmode);
            this.tabActions.Controls.Add(this.CMB_action);
            this.tabActions.Controls.Add(this.BUT_RAWSensor);
            this.tabActions.Controls.Add(this.BUTactiondo);
            this.tabActions.Controls.Add(this.modifyandSetLoiterRad);
            this.tabActions.Controls.Add(this.modifyandSetAlt);
            this.tabActions.Name = "tabActions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.lblindicadores, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel10, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel12, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // lblindicadores
            // 
            resources.ApplyResources(this.lblindicadores, "lblindicadores");
            this.lblindicadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(172)))), ((int)(((byte)(24)))));
            this.lblindicadores.Name = "lblindicadores";
            this.lblindicadores.Click += new System.EventHandler(this.lblindicadores_Click);
            // 
            // tableLayoutPanel10
            // 
            resources.ApplyResources(this.tableLayoutPanel10, "tableLayoutPanel10");
            this.tableLayoutPanel10.Controls.Add(this.LBLwp_dist, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.LBLrangefinder1, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.label11, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.LBLDistToHome, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.LBLgroundspeed, 0, 1);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            // 
            // LBLwp_dist
            // 
            resources.ApplyResources(this.LBLwp_dist, "LBLwp_dist");
            this.LBLwp_dist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(188)))), ((int)(((byte)(224)))));
            this.LBLwp_dist.Name = "LBLwp_dist";
            // 
            // LBLrangefinder1
            // 
            resources.ApplyResources(this.LBLrangefinder1, "LBLrangefinder1");
            this.LBLrangefinder1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(188)))), ((int)(((byte)(224)))));
            this.LBLrangefinder1.Name = "LBLrangefinder1";
            this.LBLrangefinder1.Click += new System.EventHandler(this.LBLrangefinder1_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // LBLDistToHome
            // 
            resources.ApplyResources(this.LBLDistToHome, "LBLDistToHome");
            this.LBLDistToHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(188)))), ((int)(((byte)(224)))));
            this.LBLDistToHome.Name = "LBLDistToHome";
            // 
            // LBLgroundspeed
            // 
            resources.ApplyResources(this.LBLgroundspeed, "LBLgroundspeed");
            this.LBLgroundspeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(188)))), ((int)(((byte)(224)))));
            this.LBLgroundspeed.Name = "LBLgroundspeed";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.BUT_quickauto, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BUT_quickrtl, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.BUT_resumemis, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BUT_quickmanual, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButJoyOn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BUTrestartmission, 1, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // BUT_quickauto
            // 
            resources.ApplyResources(this.BUT_quickauto, "BUT_quickauto");
            this.BUT_quickauto.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_quickauto.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_quickauto.ForeColor = System.Drawing.Color.White;
            this.BUT_quickauto.Name = "BUT_quickauto";
            this.BUT_quickauto.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_quickauto.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.BUT_quickauto, resources.GetString("BUT_quickauto.ToolTip"));
            this.BUT_quickauto.UseVisualStyleBackColor = true;
            this.BUT_quickauto.Click += new System.EventHandler(this.BUT_quickauto_Click);
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
            this.BUT_quickrtl.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.BUT_quickrtl, resources.GetString("BUT_quickrtl.ToolTip"));
            this.BUT_quickrtl.UseVisualStyleBackColor = true;
            this.BUT_quickrtl.Click += new System.EventHandler(this.BUT_quickrtl_Click);
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
            this.BUT_resumemis.TextColor = System.Drawing.Color.White;
            this.BUT_resumemis.UseVisualStyleBackColor = true;
            this.BUT_resumemis.Click += new System.EventHandler(this.BUT_resumemis_Click);
            // 
            // BUT_quickmanual
            // 
            resources.ApplyResources(this.BUT_quickmanual, "BUT_quickmanual");
            this.BUT_quickmanual.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_quickmanual.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickmanual.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickmanual.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_quickmanual.Name = "BUT_quickmanual";
            this.BUT_quickmanual.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_quickmanual.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.BUT_quickmanual, resources.GetString("BUT_quickmanual.ToolTip"));
            this.BUT_quickmanual.UseVisualStyleBackColor = true;
            this.BUT_quickmanual.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // ButJoyOn
            // 
            this.ButJoyOn.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.ButJoyOn, "ButJoyOn");
            this.ButJoyOn.Name = "ButJoyOn";
            this.ButJoyOn.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.ButJoyOn.TextColor = System.Drawing.Color.White;
            this.ButJoyOn.UseVisualStyleBackColor = true;
            this.ButJoyOn.Click += new System.EventHandler(this.ButJoyOn_Click_1);
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
            this.BUTrestartmission.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.BUTrestartmission, resources.GetString("BUTrestartmission.ToolTip"));
            this.BUTrestartmission.UseVisualStyleBackColor = true;
            this.BUTrestartmission.Click += new System.EventHandler(this.BUTrestartmission_Click);
            // 
            // tableLayoutPanel12
            // 
            resources.ApplyResources(this.tableLayoutPanel12, "tableLayoutPanel12");
            this.tableLayoutPanel12.Controls.Add(this.BUT_joystick_settings, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.BUT_ARM, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.BUT_clear_track, 1, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            // 
            // BUT_joystick_settings
            // 
            resources.ApplyResources(this.BUT_joystick_settings, "BUT_joystick_settings");
            this.BUT_joystick_settings.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_joystick_settings.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_joystick_settings.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_joystick_settings.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_joystick_settings.Name = "BUT_joystick_settings";
            this.BUT_joystick_settings.TextColor = System.Drawing.Color.Black;
            this.toolTip1.SetToolTip(this.BUT_joystick_settings, resources.GetString("BUT_joystick_settings.ToolTip"));
            this.BUT_joystick_settings.UseVisualStyleBackColor = true;
            this.BUT_joystick_settings.Click += new System.EventHandler(this.BUT_joystick_Click);
            // 
            // BUT_ARM
            // 
            resources.ApplyResources(this.BUT_ARM, "BUT_ARM");
            this.BUT_ARM.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_ARM.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_ARM.Name = "BUT_ARM";
            this.BUT_ARM.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_ARM.TextColor = System.Drawing.Color.Black;
            this.toolTip1.SetToolTip(this.BUT_ARM, resources.GetString("BUT_ARM.ToolTip"));
            this.BUT_ARM.UseVisualStyleBackColor = true;
            this.BUT_ARM.Click += new System.EventHandler(this.BUT_ARM_Click);
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
            this.toolTip1.SetToolTip(this.BUT_clear_track, resources.GetString("BUT_clear_track.ToolTip"));
            this.BUT_clear_track.UseVisualStyleBackColor = true;
            this.BUT_clear_track.Click += new System.EventHandler(this.BUT_clear_track_Click);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.modifyandSetSpeed, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.BUT_setwp, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.CMB_setwp, 0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
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
            this.toolTip1.SetToolTip(this.BUT_setwp, resources.GetString("BUT_setwp.ToolTip"));
            this.BUT_setwp.UseVisualStyleBackColor = true;
            this.BUT_setwp.Click += new System.EventHandler(this.BUT_setwp_Click);
            // 
            // CMB_setwp
            // 
            resources.ApplyResources(this.CMB_setwp, "CMB_setwp");
            this.CMB_setwp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_setwp.FormattingEnabled = true;
            this.CMB_setwp.Items.AddRange(new object[] {
            resources.GetString("CMB_setwp.Items")});
            this.CMB_setwp.Name = "CMB_setwp";
            this.CMB_setwp.SelectedIndexChanged += new System.EventHandler(this.CMB_setwp_SelectedIndexChanged);
            this.CMB_setwp.Click += new System.EventHandler(this.CMB_setwp_Click);
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.CMB_modes, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.BUT_setmode, 0, 1);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // CMB_modes
            // 
            resources.ApplyResources(this.CMB_modes, "CMB_modes");
            this.CMB_modes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_modes.FormattingEnabled = true;
            this.CMB_modes.Name = "CMB_modes";
            this.CMB_modes.SelectedIndexChanged += new System.EventHandler(this.CMB_modes_SelectedIndexChanged);
            this.CMB_modes.Click += new System.EventHandler(this.CMB_modes_Click);
            // 
            // BUT_setmode
            // 
            resources.ApplyResources(this.BUT_setmode, "BUT_setmode");
            this.BUT_setmode.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_setmode.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_setmode.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_setmode.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_setmode.Name = "BUT_setmode";
            this.BUT_setmode.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_setmode.TextColor = System.Drawing.Color.Black;
            this.toolTip1.SetToolTip(this.BUT_setmode, resources.GetString("BUT_setmode.ToolTip"));
            this.BUT_setmode.UseVisualStyleBackColor = true;
            this.BUT_setmode.Click += new System.EventHandler(this.BUT_setmode_Click);
            // 
            // BUT_Homealt
            // 
            this.BUT_Homealt.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_Homealt.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_Homealt.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_Homealt, "BUT_Homealt");
            this.BUT_Homealt.Name = "BUT_Homealt";
            this.BUT_Homealt.TextColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.BUT_Homealt, resources.GetString("BUT_Homealt.ToolTip"));
            this.BUT_Homealt.UseVisualStyleBackColor = true;
            this.BUT_Homealt.Click += new System.EventHandler(this.BUT_Homealt_Click);
            // 
            // BUT_abortland
            // 
            this.BUT_abortland.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_abortland.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_abortland.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_abortland, "BUT_abortland");
            this.BUT_abortland.Name = "BUT_abortland";
            this.BUT_abortland.TextColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.BUT_abortland, resources.GetString("BUT_abortland.ToolTip"));
            this.BUT_abortland.UseVisualStyleBackColor = true;
            this.BUT_abortland.Click += new System.EventHandler(this.BUT_abortland_Click);
            // 
            // CMB_mountmode
            // 
            this.CMB_mountmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_mountmode.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_mountmode, "CMB_mountmode");
            this.CMB_mountmode.Name = "CMB_mountmode";
            // 
            // BUT_mountmode
            // 
            this.BUT_mountmode.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_mountmode.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_mountmode.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_mountmode, "BUT_mountmode");
            this.BUT_mountmode.Name = "BUT_mountmode";
            this.BUT_mountmode.TextColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.BUT_mountmode, resources.GetString("BUT_mountmode.ToolTip"));
            this.BUT_mountmode.UseVisualStyleBackColor = true;
            this.BUT_mountmode.Click += new System.EventHandler(this.BUT_mountmode_Click);
            // 
            // CMB_action
            // 
            this.CMB_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_action.DropDownWidth = 150;
            this.CMB_action.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_action, "CMB_action");
            this.CMB_action.Name = "CMB_action";
            // 
            // BUT_RAWSensor
            // 
            this.BUT_RAWSensor.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_RAWSensor.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_RAWSensor.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_RAWSensor, "BUT_RAWSensor");
            this.BUT_RAWSensor.Name = "BUT_RAWSensor";
            this.BUT_RAWSensor.TextColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.BUT_RAWSensor, resources.GetString("BUT_RAWSensor.ToolTip"));
            this.BUT_RAWSensor.UseVisualStyleBackColor = true;
            this.BUT_RAWSensor.Click += new System.EventHandler(this.BUT_RAWSensor_Click);
            // 
            // BUTactiondo
            // 
            this.BUTactiondo.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUTactiondo.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUTactiondo.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUTactiondo, "BUTactiondo");
            this.BUTactiondo.Name = "BUTactiondo";
            this.BUTactiondo.TextColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.BUTactiondo, resources.GetString("BUTactiondo.ToolTip"));
            this.BUTactiondo.UseVisualStyleBackColor = true;
            this.BUTactiondo.Click += new System.EventHandler(this.BUTactiondo_Click);
            // 
            // tabActionsSimple
            // 
            this.tabActionsSimple.Controls.Add(this.myButton1);
            this.tabActionsSimple.Controls.Add(this.myButton2);
            this.tabActionsSimple.Controls.Add(this.myButton3);
            resources.ApplyResources(this.tabActionsSimple, "tabActionsSimple");
            this.tabActionsSimple.Name = "tabActionsSimple";
            this.tabActionsSimple.UseVisualStyleBackColor = true;
            // 
            // myButton1
            // 
            this.myButton1.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton1.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton1.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.Name = "myButton1";
            this.myButton1.TextColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.myButton1, resources.GetString("myButton1.ToolTip"));
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // myButton2
            // 
            this.myButton2.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton2.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton2.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.myButton2.TextColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.myButton2, resources.GetString("myButton2.ToolTip"));
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // myButton3
            // 
            this.myButton3.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton3.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton3.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton3, "myButton3");
            this.myButton3.Name = "myButton3";
            this.myButton3.TextColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.myButton3, resources.GetString("myButton3.ToolTip"));
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // tabPagePreFlight
            // 
            this.tabPagePreFlight.Controls.Add(this.checkListControl1);
            resources.ApplyResources(this.tabPagePreFlight, "tabPagePreFlight");
            this.tabPagePreFlight.Name = "tabPagePreFlight";
            this.tabPagePreFlight.UseVisualStyleBackColor = true;
            // 
            // tabGauges
            // 
            this.tabGauges.Controls.Add(this.Gvspeed);
            this.tabGauges.Controls.Add(this.Gheading);
            this.tabGauges.Controls.Add(this.Galt);
            this.tabGauges.Controls.Add(this.Gspeed);
            resources.ApplyResources(this.tabGauges, "tabGauges");
            this.tabGauges.Name = "tabGauges";
            this.tabGauges.UseVisualStyleBackColor = true;
            this.tabGauges.Resize += new System.EventHandler(this.tabPage1_Resize);
            // 
            // Gvspeed
            // 
            this.Gvspeed.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Gvspeed, "Gvspeed");
            this.Gvspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gvspeed.BaseArcRadius = 60;
            this.Gvspeed.BaseArcStart = 20;
            this.Gvspeed.BaseArcSweep = 320;
            this.Gvspeed.BaseArcWidth = 2;
            this.Gvspeed.Cap_Idx = ((byte)(0));
            this.Gvspeed.CapColor = System.Drawing.Color.White;
            this.Gvspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gvspeed.CapPosition = new System.Drawing.Point(65, 85);
            this.Gvspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(65, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gvspeed.CapsText = new string[] {
        "VSI",
        "",
        "",
        "",
        ""};
            this.Gvspeed.CapText = "VSI";
            this.Gvspeed.Center = new System.Drawing.Point(75, 75);
            this.Gvspeed.MaxValue = 10F;
            this.Gvspeed.MinValue = -10F;
            this.Gvspeed.Name = "Gvspeed";
            this.Gvspeed.Need_Idx = ((byte)(3));
            this.Gvspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gvspeed.NeedleColor2 = System.Drawing.Color.White;
            this.Gvspeed.NeedleEnabled = false;
            this.Gvspeed.NeedleRadius = 80;
            this.Gvspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gvspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.Gvspeed.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.Gvspeed.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Gvspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gvspeed.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Gvspeed.NeedleType = 0;
            this.Gvspeed.NeedleWidth = 2;
            this.Gvspeed.Range_Idx = ((byte)(0));
            this.Gvspeed.RangeColor = System.Drawing.Color.LightGreen;
            this.Gvspeed.RangeEnabled = false;
            this.Gvspeed.RangeEndValue = 360F;
            this.Gvspeed.RangeInnerRadius = 1;
            this.Gvspeed.RangeOuterRadius = 60;
            this.Gvspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gvspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gvspeed.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Gvspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gvspeed.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Gvspeed.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Gvspeed.RangeStartValue = 0F;
            this.Gvspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesInterInnerRadius = 52;
            this.Gvspeed.ScaleLinesInterOuterRadius = 60;
            this.Gvspeed.ScaleLinesInterWidth = 1;
            this.Gvspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gvspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMajorStepValue = 2F;
            this.Gvspeed.ScaleLinesMajorWidth = 2;
            this.Gvspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gvspeed.ScaleLinesMinorNumOf = 9;
            this.Gvspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMinorWidth = 1;
            this.Gvspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleNumbersFormat = "";
            this.Gvspeed.ScaleNumbersRadius = 42;
            this.Gvspeed.ScaleNumbersRotation = 0;
            this.Gvspeed.ScaleNumbersStartScaleLine = 1;
            this.Gvspeed.ScaleNumbersStepScaleLines = 1;
            this.Gvspeed.Value = 0F;
            this.Gvspeed.Value0 = 0F;
            this.Gvspeed.Value1 = 0F;
            this.Gvspeed.Value2 = 0F;
            this.Gvspeed.Value3 = 0F;
            // 
            // Gheading
            // 
            this.Gheading.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Gheading, "Gheading");
            this.Gheading.Heading = 0;
            this.Gheading.Name = "Gheading";
            this.Gheading.NavHeading = 0;
            // 
            // Galt
            // 
            this.Galt.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Galt, "Galt");
            this.Galt.BaseArcColor = System.Drawing.Color.Transparent;
            this.Galt.BaseArcRadius = 60;
            this.Galt.BaseArcStart = 270;
            this.Galt.BaseArcSweep = 360;
            this.Galt.BaseArcWidth = 2;
            this.Galt.Cap_Idx = ((byte)(0));
            this.Galt.CapColor = System.Drawing.Color.White;
            this.Galt.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Galt.CapPosition = new System.Drawing.Point(68, 85);
            this.Galt.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(68, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Galt.CapsText = new string[] {
        "Alt",
        "",
        "",
        "",
        ""};
            this.Galt.CapText = "Alt";
            this.Galt.Center = new System.Drawing.Point(75, 75);
            this.Galt.MaxValue = 9.99F;
            this.Galt.MinValue = 0F;
            this.Galt.Name = "Galt";
            this.Galt.Need_Idx = ((byte)(3));
            this.Galt.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Galt.NeedleColor2 = System.Drawing.Color.White;
            this.Galt.NeedleEnabled = false;
            this.Galt.NeedleRadius = 80;
            this.Galt.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Galt.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.Galt.NeedlesEnabled = new bool[] {
        true,
        true,
        true,
        false};
            this.Galt.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Galt.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Galt.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Galt.NeedleType = 0;
            this.Galt.NeedleWidth = 2;
            this.Galt.Range_Idx = ((byte)(0));
            this.Galt.RangeColor = System.Drawing.Color.LightGreen;
            this.Galt.RangeEnabled = false;
            this.Galt.RangeEndValue = 360F;
            this.Galt.RangeInnerRadius = 1;
            this.Galt.RangeOuterRadius = 60;
            this.Galt.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Galt.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Galt.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Galt.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Galt.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Galt.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Galt.RangeStartValue = 0F;
            this.Galt.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesInterInnerRadius = 52;
            this.Galt.ScaleLinesInterOuterRadius = 60;
            this.Galt.ScaleLinesInterWidth = 1;
            this.Galt.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMajorInnerRadius = 50;
            this.Galt.ScaleLinesMajorOuterRadius = 60;
            this.Galt.ScaleLinesMajorStepValue = 1F;
            this.Galt.ScaleLinesMajorWidth = 2;
            this.Galt.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMinorInnerRadius = 55;
            this.Galt.ScaleLinesMinorNumOf = 9;
            this.Galt.ScaleLinesMinorOuterRadius = 60;
            this.Galt.ScaleLinesMinorWidth = 1;
            this.Galt.ScaleNumbersColor = System.Drawing.Color.White;
            this.Galt.ScaleNumbersFormat = "";
            this.Galt.ScaleNumbersRadius = 42;
            this.Galt.ScaleNumbersRotation = 0;
            this.Galt.ScaleNumbersStartScaleLine = 1;
            this.Galt.ScaleNumbersStepScaleLines = 1;
            this.Galt.Value = 0F;
            this.Galt.Value0 = 0F;
            this.Galt.Value1 = 0F;
            this.Galt.Value2 = 0F;
            this.Galt.Value3 = 0F;
            // 
            // Gspeed
            // 
            this.Gspeed.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Gspeed, "Gspeed");
            this.Gspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gspeed.BaseArcRadius = 70;
            this.Gspeed.BaseArcStart = 135;
            this.Gspeed.BaseArcSweep = 270;
            this.Gspeed.BaseArcWidth = 2;
            this.Gspeed.Cap_Idx = ((byte)(0));
            this.Gspeed.CapColor = System.Drawing.Color.White;
            this.Gspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gspeed.CapPosition = new System.Drawing.Point(58, 85);
            this.Gspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gspeed.CapsText = new string[] {
        "Speed",
        "",
        "",
        "",
        ""};
            this.Gspeed.CapText = "Speed";
            this.Gspeed.Center = new System.Drawing.Point(75, 75);
            this.Gspeed.MaxValue = 60F;
            this.Gspeed.MinValue = 0F;
            this.Gspeed.Name = "Gspeed";
            this.Gspeed.Need_Idx = ((byte)(3));
            this.Gspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gspeed.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gspeed.NeedleEnabled = false;
            this.Gspeed.NeedleRadius = 70;
            this.Gspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gspeed.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gspeed.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gspeed.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gspeed.NeedleType = 0;
            this.Gspeed.NeedleWidth = 2;
            this.Gspeed.Range_Idx = ((byte)(2));
            this.Gspeed.RangeColor = System.Drawing.Color.Orange;
            this.Gspeed.RangeEnabled = false;
            this.Gspeed.RangeEndValue = 50F;
            this.Gspeed.RangeInnerRadius = 1;
            this.Gspeed.RangeOuterRadius = 70;
            this.Gspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gspeed.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gspeed.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gspeed.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gspeed.RangeStartValue = 35F;
            this.Gspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesInterInnerRadius = 52;
            this.Gspeed.ScaleLinesInterOuterRadius = 60;
            this.Gspeed.ScaleLinesInterWidth = 1;
            this.Gspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gspeed.ScaleLinesMajorStepValue = 10F;
            this.Gspeed.ScaleLinesMajorWidth = 2;
            this.Gspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gspeed.ScaleLinesMinorNumOf = 9;
            this.Gspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gspeed.ScaleLinesMinorWidth = 1;
            this.Gspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gspeed.ScaleNumbersFormat = null;
            this.Gspeed.ScaleNumbersRadius = 42;
            this.Gspeed.ScaleNumbersRotation = 0;
            this.Gspeed.ScaleNumbersStartScaleLine = 1;
            this.Gspeed.ScaleNumbersStepScaleLines = 1;
            this.toolTip1.SetToolTip(this.Gspeed, resources.GetString("Gspeed.ToolTip"));
            this.Gspeed.Value = 0F;
            this.Gspeed.Value0 = 0F;
            this.Gspeed.Value1 = 0F;
            this.Gspeed.Value2 = 0F;
            this.Gspeed.Value3 = 0F;
            this.Gspeed.DoubleClick += new System.EventHandler(this.Gspeed_DoubleClick);
            // 
            // tabStatus
            // 
            resources.ApplyResources(this.tabStatus, "tabStatus");
            this.tabStatus.Name = "tabStatus";
            // 
            // tabServo
            // 
            this.tabServo.Controls.Add(this.flowLayoutPanelServos);
            resources.ApplyResources(this.tabServo, "tabServo");
            this.tabServo.Name = "tabServo";
            this.tabServo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelServos
            // 
            resources.ApplyResources(this.flowLayoutPanelServos, "flowLayoutPanelServos");
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions1);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions2);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions3);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions4);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions5);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions6);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions7);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions8);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions9);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions10);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions1);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions2);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions3);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions4);
            this.flowLayoutPanelServos.Name = "flowLayoutPanelServos";
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
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPaneltlogs, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.BUT_DFMavlink, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.BUT_matlab, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.but_bintolog, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.but_dflogtokml, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.BUT_loganalysis, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.BUT_logbrowse, 1, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // BUT_DFMavlink
            // 
            resources.ApplyResources(this.BUT_DFMavlink, "BUT_DFMavlink");
            this.BUT_DFMavlink.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_DFMavlink.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.Name = "BUT_DFMavlink";
            this.BUT_DFMavlink.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_DFMavlink.TextColor = System.Drawing.Color.Black;
            this.BUT_DFMavlink.UseVisualStyleBackColor = true;
            // 
            // BUT_matlab
            // 
            resources.ApplyResources(this.BUT_matlab, "BUT_matlab");
            this.BUT_matlab.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_matlab.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_matlab.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_matlab.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_matlab.Name = "BUT_matlab";
            this.BUT_matlab.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_matlab.TextColor = System.Drawing.Color.Black;
            this.BUT_matlab.UseVisualStyleBackColor = true;
            // 
            // but_bintolog
            // 
            resources.ApplyResources(this.but_bintolog, "but_bintolog");
            this.but_bintolog.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.but_bintolog.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_bintolog.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_bintolog.ColorNotEnabled = System.Drawing.Color.Empty;
            this.but_bintolog.Name = "but_bintolog";
            this.but_bintolog.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.but_bintolog.TextColor = System.Drawing.Color.Black;
            this.but_bintolog.UseVisualStyleBackColor = true;
            // 
            // but_dflogtokml
            // 
            resources.ApplyResources(this.but_dflogtokml, "but_dflogtokml");
            this.but_dflogtokml.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.but_dflogtokml.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_dflogtokml.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_dflogtokml.ColorNotEnabled = System.Drawing.Color.Empty;
            this.but_dflogtokml.Name = "but_dflogtokml";
            this.but_dflogtokml.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.but_dflogtokml.TextColor = System.Drawing.Color.Black;
            this.but_dflogtokml.UseVisualStyleBackColor = true;
            // 
            // BUT_loganalysis
            // 
            resources.ApplyResources(this.BUT_loganalysis, "BUT_loganalysis");
            this.BUT_loganalysis.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_loganalysis.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loganalysis.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loganalysis.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_loganalysis.Name = "BUT_loganalysis";
            this.BUT_loganalysis.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_loganalysis.TextColor = System.Drawing.Color.Black;
            this.BUT_loganalysis.UseVisualStyleBackColor = true;
            // 
            // BUT_logbrowse
            // 
            resources.ApplyResources(this.BUT_logbrowse, "BUT_logbrowse");
            this.BUT_logbrowse.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_logbrowse.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_logbrowse.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_logbrowse.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_logbrowse.Name = "BUT_logbrowse";
            this.BUT_logbrowse.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_logbrowse.TextColor = System.Drawing.Color.Black;
            this.BUT_logbrowse.UseVisualStyleBackColor = true;
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
            // tablogbrowse
            // 
            resources.ApplyResources(this.tablogbrowse, "tablogbrowse");
            this.tablogbrowse.Name = "tablogbrowse";
            this.tablogbrowse.UseVisualStyleBackColor = true;
            // 
            // tabScripts
            // 
            this.tabScripts.Controls.Add(this.checkBoxRedirectOutput);
            this.tabScripts.Controls.Add(this.BUT_edit_selected);
            this.tabScripts.Controls.Add(this.labelSelectedScript);
            this.tabScripts.Controls.Add(this.BUT_run_script);
            this.tabScripts.Controls.Add(this.BUT_abort_script);
            this.tabScripts.Controls.Add(this.labelScriptStatus);
            this.tabScripts.Controls.Add(this.BUT_select_script);
            resources.ApplyResources(this.tabScripts, "tabScripts");
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // checkBoxRedirectOutput
            // 
            resources.ApplyResources(this.checkBoxRedirectOutput, "checkBoxRedirectOutput");
            this.checkBoxRedirectOutput.Checked = true;
            this.checkBoxRedirectOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRedirectOutput.Name = "checkBoxRedirectOutput";
            this.checkBoxRedirectOutput.UseVisualStyleBackColor = true;
            // 
            // BUT_edit_selected
            // 
            this.BUT_edit_selected.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_edit_selected.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_edit_selected.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_edit_selected, "BUT_edit_selected");
            this.BUT_edit_selected.Name = "BUT_edit_selected";
            this.BUT_edit_selected.TextColor = System.Drawing.Color.Empty;
            this.BUT_edit_selected.UseVisualStyleBackColor = true;
            this.BUT_edit_selected.Click += new System.EventHandler(this.BUT_edit_selected_Click);
            // 
            // labelSelectedScript
            // 
            resources.ApplyResources(this.labelSelectedScript, "labelSelectedScript");
            this.labelSelectedScript.Name = "labelSelectedScript";
            // 
            // BUT_run_script
            // 
            this.BUT_run_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_run_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_run_script.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_run_script, "BUT_run_script");
            this.BUT_run_script.Name = "BUT_run_script";
            this.BUT_run_script.TextColor = System.Drawing.Color.Empty;
            this.BUT_run_script.UseVisualStyleBackColor = true;
            this.BUT_run_script.Click += new System.EventHandler(this.BUT_run_script_Click);
            // 
            // BUT_abort_script
            // 
            this.BUT_abort_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_abort_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_abort_script.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_abort_script, "BUT_abort_script");
            this.BUT_abort_script.Name = "BUT_abort_script";
            this.BUT_abort_script.TextColor = System.Drawing.Color.Empty;
            this.BUT_abort_script.UseVisualStyleBackColor = true;
            this.BUT_abort_script.Click += new System.EventHandler(this.BUT_abort_script_Click);
            // 
            // labelScriptStatus
            // 
            resources.ApplyResources(this.labelScriptStatus, "labelScriptStatus");
            this.labelScriptStatus.Name = "labelScriptStatus";
            // 
            // BUT_select_script
            // 
            this.BUT_select_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_select_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_select_script.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_select_script, "BUT_select_script");
            this.BUT_select_script.Name = "BUT_select_script";
            this.BUT_select_script.TextColor = System.Drawing.Color.Empty;
            this.BUT_select_script.UseVisualStyleBackColor = true;
            this.BUT_select_script.Click += new System.EventHandler(this.BUT_select_script_Click);
            // 
            // tabPagemessages
            // 
            this.tabPagemessages.Controls.Add(this.txt_messagebox);
            resources.ApplyResources(this.tabPagemessages, "tabPagemessages");
            this.tabPagemessages.Name = "tabPagemessages";
            this.tabPagemessages.UseVisualStyleBackColor = true;
            // 
            // txt_messagebox
            // 
            resources.ApplyResources(this.txt_messagebox, "txt_messagebox");
            this.txt_messagebox.Name = "txt_messagebox";
            // 
            // tabPayload
            // 
            this.tabPayload.Controls.Add(this.BUT_PayloadFolder);
            this.tabPayload.Controls.Add(this.groupBoxRoll);
            this.tabPayload.Controls.Add(this.groupBoxYaw);
            this.tabPayload.Controls.Add(this.BUT_resetGimbalPos);
            this.tabPayload.Controls.Add(this.groupBoxPitch);
            resources.ApplyResources(this.tabPayload, "tabPayload");
            this.tabPayload.Name = "tabPayload";
            this.tabPayload.UseVisualStyleBackColor = true;
            // 
            // BUT_PayloadFolder
            // 
            this.BUT_PayloadFolder.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BUT_PayloadFolder, "BUT_PayloadFolder");
            this.BUT_PayloadFolder.Name = "BUT_PayloadFolder";
            this.BUT_PayloadFolder.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_PayloadFolder.TextColor = System.Drawing.Color.Black;
            this.BUT_PayloadFolder.UseVisualStyleBackColor = true;
            // 
            // groupBoxRoll
            // 
            this.groupBoxRoll.Controls.Add(this.TXT_gimbalRollPos);
            this.groupBoxRoll.Controls.Add(this.trackBarRoll);
            resources.ApplyResources(this.groupBoxRoll, "groupBoxRoll");
            this.groupBoxRoll.Name = "groupBoxRoll";
            this.groupBoxRoll.TabStop = false;
            // 
            // TXT_gimbalRollPos
            // 
            this.TXT_gimbalRollPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointb", true));
            resources.ApplyResources(this.TXT_gimbalRollPos, "TXT_gimbalRollPos");
            this.TXT_gimbalRollPos.Name = "TXT_gimbalRollPos";
            // 
            // bindingSourcePayloadTab
            // 
            this.bindingSourcePayloadTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // trackBarRoll
            // 
            resources.ApplyResources(this.trackBarRoll, "trackBarRoll");
            this.trackBarRoll.LargeChange = 10;
            this.trackBarRoll.Maximum = 45;
            this.trackBarRoll.Minimum = -45;
            this.trackBarRoll.Name = "trackBarRoll";
            this.trackBarRoll.TickFrequency = 10;
            this.trackBarRoll.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // groupBoxYaw
            // 
            this.groupBoxYaw.Controls.Add(this.TXT_gimbalYawPos);
            this.groupBoxYaw.Controls.Add(this.trackBarYaw);
            resources.ApplyResources(this.groupBoxYaw, "groupBoxYaw");
            this.groupBoxYaw.Name = "groupBoxYaw";
            this.groupBoxYaw.TabStop = false;
            // 
            // TXT_gimbalYawPos
            // 
            this.TXT_gimbalYawPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointc", true));
            resources.ApplyResources(this.TXT_gimbalYawPos, "TXT_gimbalYawPos");
            this.TXT_gimbalYawPos.Name = "TXT_gimbalYawPos";
            // 
            // trackBarYaw
            // 
            resources.ApplyResources(this.trackBarYaw, "trackBarYaw");
            this.trackBarYaw.LargeChange = 10;
            this.trackBarYaw.Maximum = 45;
            this.trackBarYaw.Minimum = -45;
            this.trackBarYaw.Name = "trackBarYaw";
            this.trackBarYaw.TickFrequency = 10;
            this.trackBarYaw.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // BUT_resetGimbalPos
            // 
            this.BUT_resetGimbalPos.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BUT_resetGimbalPos, "BUT_resetGimbalPos");
            this.BUT_resetGimbalPos.Name = "BUT_resetGimbalPos";
            this.BUT_resetGimbalPos.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_resetGimbalPos.TextColor = System.Drawing.Color.Black;
            this.BUT_resetGimbalPos.UseVisualStyleBackColor = true;
            this.BUT_resetGimbalPos.Click += new System.EventHandler(this.BUT_resetGimbalPos_Click);
            // 
            // groupBoxPitch
            // 
            this.groupBoxPitch.Controls.Add(this.trackBarPitch);
            this.groupBoxPitch.Controls.Add(this.TXT_gimbalPitchPos);
            resources.ApplyResources(this.groupBoxPitch, "groupBoxPitch");
            this.groupBoxPitch.Name = "groupBoxPitch";
            this.groupBoxPitch.TabStop = false;
            // 
            // trackBarPitch
            // 
            resources.ApplyResources(this.trackBarPitch, "trackBarPitch");
            this.trackBarPitch.LargeChange = 10;
            this.trackBarPitch.Maximum = 45;
            this.trackBarPitch.Minimum = -45;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.SmallChange = 5;
            this.trackBarPitch.TickFrequency = 10;
            this.trackBarPitch.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // TXT_gimbalPitchPos
            // 
            this.TXT_gimbalPitchPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointa", true));
            resources.ApplyResources(this.TXT_gimbalPitchPos, "TXT_gimbalPitchPos");
            this.TXT_gimbalPitchPos.Name = "TXT_gimbalPitchPos";
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
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groundspeedDataGridViewTextBoxColumn,
            this.wpdistDataGridViewTextBoxColumn,
            this.distToHomeDataGridViewTextBoxColumn,
            this.rangefinder1DataGridViewTextBoxColumn,
            this.parentDataGridViewTextBoxColumn,
            this.rollDataGridViewTextBoxColumn,
            this.pitchDataGridViewTextBoxColumn,
            this.yawDataGridViewTextBoxColumn,
            this.sSADataGridViewTextBoxColumn,
            this.aOADataGridViewTextBoxColumn,
            this.groundcourseDataGridViewTextBoxColumn,
            this.latDataGridViewTextBoxColumn,
            this.lngDataGridViewTextBoxColumn,
            this.altDataGridViewTextBoxColumn,
            this.altaslDataGridViewTextBoxColumn,
            this.horizondistDataGridViewTextBoxColumn,
            this.vxDataGridViewTextBoxColumn,
            this.vyDataGridViewTextBoxColumn,
            this.vzDataGridViewTextBoxColumn,
            this.vlenDataGridViewTextBoxColumn,
            this.altoffsethomeDataGridViewTextBoxColumn,
            this.gpsstatusDataGridViewTextBoxColumn,
            this.gpshdopDataGridViewTextBoxColumn,
            this.satcountDataGridViewTextBoxColumn,
            this.gpshaccDataGridViewTextBoxColumn,
            this.gpsvaccDataGridViewTextBoxColumn,
            this.gpsvelaccDataGridViewTextBoxColumn,
            this.gpshdgaccDataGridViewTextBoxColumn,
            this.lat2DataGridViewTextBoxColumn,
            this.lng2DataGridViewTextBoxColumn,
            this.altasl2DataGridViewTextBoxColumn,
            this.gpsstatus2DataGridViewTextBoxColumn,
            this.gpshdop2DataGridViewTextBoxColumn,
            this.satcount2DataGridViewTextBoxColumn,
            this.groundspeed2DataGridViewTextBoxColumn,
            this.groundcourse2DataGridViewTextBoxColumn,
            this.satcountBDataGridViewTextBoxColumn,
            this.gpstimeDataGridViewTextBoxColumn,
            this.altd1000DataGridViewTextBoxColumn,
            this.altd100DataGridViewTextBoxColumn,
            this.airspeedDataGridViewTextBoxColumn,
            this.targetairspeedDataGridViewTextBoxColumn,
            this.lowairspeedDataGridViewCheckBoxColumn,
            this.asratioDataGridViewTextBoxColumn,
            this.axDataGridViewTextBoxColumn,
            this.ayDataGridViewTextBoxColumn,
            this.azDataGridViewTextBoxColumn,
            this.accelsqDataGridViewTextBoxColumn,
            this.gxDataGridViewTextBoxColumn,
            this.gyDataGridViewTextBoxColumn,
            this.gzDataGridViewTextBoxColumn,
            this.gyrosqDataGridViewTextBoxColumn,
            this.mxDataGridViewTextBoxColumn,
            this.myDataGridViewTextBoxColumn,
            this.mzDataGridViewTextBoxColumn,
            this.magfieldDataGridViewTextBoxColumn,
            this.ax2DataGridViewTextBoxColumn,
            this.ay2DataGridViewTextBoxColumn,
            this.az2DataGridViewTextBoxColumn,
            this.accelsq2DataGridViewTextBoxColumn,
            this.gx2DataGridViewTextBoxColumn,
            this.gy2DataGridViewTextBoxColumn,
            this.gz2DataGridViewTextBoxColumn,
            this.gyrosq2DataGridViewTextBoxColumn,
            this.mx2DataGridViewTextBoxColumn,
            this.my2DataGridViewTextBoxColumn,
            this.mz2DataGridViewTextBoxColumn,
            this.magfield2DataGridViewTextBoxColumn,
            this.ax3DataGridViewTextBoxColumn,
            this.ay3DataGridViewTextBoxColumn,
            this.az3DataGridViewTextBoxColumn,
            this.accelsq3DataGridViewTextBoxColumn,
            this.gx3DataGridViewTextBoxColumn,
            this.gy3DataGridViewTextBoxColumn,
            this.gz3DataGridViewTextBoxColumn,
            this.gyrosq3DataGridViewTextBoxColumn,
            this.mx3DataGridViewTextBoxColumn,
            this.my3DataGridViewTextBoxColumn,
            this.mz3DataGridViewTextBoxColumn,
            this.magfield3DataGridViewTextBoxColumn,
            this.ch1inDataGridViewTextBoxColumn,
            this.ch2inDataGridViewTextBoxColumn,
            this.ch3inDataGridViewTextBoxColumn,
            this.ch4inDataGridViewTextBoxColumn,
            this.ch5inDataGridViewTextBoxColumn,
            this.ch6inDataGridViewTextBoxColumn,
            this.ch7inDataGridViewTextBoxColumn,
            this.ch8inDataGridViewTextBoxColumn,
            this.ch9inDataGridViewTextBoxColumn,
            this.ch10inDataGridViewTextBoxColumn,
            this.ch11inDataGridViewTextBoxColumn,
            this.ch12inDataGridViewTextBoxColumn,
            this.ch13inDataGridViewTextBoxColumn,
            this.ch14inDataGridViewTextBoxColumn,
            this.ch15inDataGridViewTextBoxColumn,
            this.ch16inDataGridViewTextBoxColumn,
            this.ch1outDataGridViewTextBoxColumn,
            this.ch2outDataGridViewTextBoxColumn,
            this.ch3outDataGridViewTextBoxColumn,
            this.ch4outDataGridViewTextBoxColumn,
            this.ch5outDataGridViewTextBoxColumn,
            this.ch6outDataGridViewTextBoxColumn,
            this.ch7outDataGridViewTextBoxColumn,
            this.ch8outDataGridViewTextBoxColumn,
            this.ch9outDataGridViewTextBoxColumn,
            this.ch10outDataGridViewTextBoxColumn,
            this.ch11outDataGridViewTextBoxColumn,
            this.ch12outDataGridViewTextBoxColumn,
            this.ch13outDataGridViewTextBoxColumn,
            this.ch14outDataGridViewTextBoxColumn,
            this.ch15outDataGridViewTextBoxColumn,
            this.ch16outDataGridViewTextBoxColumn,
            this.esc1voltDataGridViewTextBoxColumn,
            this.esc1currDataGridViewTextBoxColumn,
            this.esc1rpmDataGridViewTextBoxColumn,
            this.esc1tempDataGridViewTextBoxColumn,
            this.esc2voltDataGridViewTextBoxColumn,
            this.esc2currDataGridViewTextBoxColumn,
            this.esc2rpmDataGridViewTextBoxColumn,
            this.esc2tempDataGridViewTextBoxColumn,
            this.esc3voltDataGridViewTextBoxColumn,
            this.esc3currDataGridViewTextBoxColumn,
            this.esc3rpmDataGridViewTextBoxColumn,
            this.esc3tempDataGridViewTextBoxColumn,
            this.esc4voltDataGridViewTextBoxColumn,
            this.esc4currDataGridViewTextBoxColumn,
            this.esc4rpmDataGridViewTextBoxColumn,
            this.esc4tempDataGridViewTextBoxColumn,
            this.esc5voltDataGridViewTextBoxColumn,
            this.esc5currDataGridViewTextBoxColumn,
            this.esc5rpmDataGridViewTextBoxColumn,
            this.esc5tempDataGridViewTextBoxColumn,
            this.esc6voltDataGridViewTextBoxColumn,
            this.esc6currDataGridViewTextBoxColumn,
            this.esc6rpmDataGridViewTextBoxColumn,
            this.esc6tempDataGridViewTextBoxColumn,
            this.esc7voltDataGridViewTextBoxColumn,
            this.esc7currDataGridViewTextBoxColumn,
            this.esc7rpmDataGridViewTextBoxColumn,
            this.esc7tempDataGridViewTextBoxColumn,
            this.esc8voltDataGridViewTextBoxColumn,
            this.esc8currDataGridViewTextBoxColumn,
            this.esc8rpmDataGridViewTextBoxColumn,
            this.esc8tempDataGridViewTextBoxColumn,
            this.ch3percentDataGridViewTextBoxColumn,
            this.failsafeDataGridViewCheckBoxColumn,
            this.rxrssiDataGridViewTextBoxColumn,
            this.critAOADataGridViewTextBoxColumn,
            this.lowgroundspeedDataGridViewCheckBoxColumn,
            this.verticalspeedDataGridViewTextBoxColumn,
            this.verticalspeedfpmDataGridViewTextBoxColumn,
            this.glideratioDataGridViewTextBoxColumn,
            this.navrollDataGridViewTextBoxColumn,
            this.navpitchDataGridViewTextBoxColumn,
            this.navbearingDataGridViewTextBoxColumn,
            this.targetbearingDataGridViewTextBoxColumn,
            this.alterrorDataGridViewTextBoxColumn,
            this.bererrorDataGridViewTextBoxColumn,
            this.aspderrorDataGridViewTextBoxColumn,
            this.xtrackerrorDataGridViewTextBoxColumn,
            this.wpnoDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.climbrateDataGridViewTextBoxColumn,
            this.totDataGridViewTextBoxColumn,
            this.tohDataGridViewTextBoxColumn,
            this.distTraveledDataGridViewTextBoxColumn,
            this.timeSinceArmInAirDataGridViewTextBoxColumn,
            this.timeInAirDataGridViewTextBoxColumn,
            this.timeInAirMinSecDataGridViewTextBoxColumn,
            this.turnrateDataGridViewTextBoxColumn,
            this.turngDataGridViewTextBoxColumn,
            this.radiusDataGridViewTextBoxColumn,
            this.qNHDataGridViewTextBoxColumn,
            this.winddirDataGridViewTextBoxColumn,
            this.windvelDataGridViewTextBoxColumn,
            this.targetaltd100DataGridViewTextBoxColumn,
            this.targetaltDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.messageHighDataGridViewTextBoxColumn,
            this.messageHighTimeDataGridViewTextBoxColumn,
            this.batteryvoltageDataGridViewTextBoxColumn,
            this.batteryvoltage3DataGridViewTextBoxColumn,
            this.batteryvoltage4DataGridViewTextBoxColumn,
            this.batteryvoltage5DataGridViewTextBoxColumn,
            this.batteryvoltage6DataGridViewTextBoxColumn,
            this.batteryvoltage7DataGridViewTextBoxColumn,
            this.batteryvoltage8DataGridViewTextBoxColumn,
            this.batteryremainingDataGridViewTextBoxColumn,
            this.batteryremaining2DataGridViewTextBoxColumn,
            this.batteryremaining3DataGridViewTextBoxColumn,
            this.batteryremaining4DataGridViewTextBoxColumn,
            this.batteryremaining5DataGridViewTextBoxColumn,
            this.batteryremaining6DataGridViewTextBoxColumn,
            this.batteryremaining7DataGridViewTextBoxColumn,
            this.batteryremaining8DataGridViewTextBoxColumn,
            this.currentDataGridViewTextBoxColumn,
            this.current2DataGridViewTextBoxColumn,
            this.current3DataGridViewTextBoxColumn,
            this.current4DataGridViewTextBoxColumn,
            this.current5DataGridViewTextBoxColumn,
            this.current6DataGridViewTextBoxColumn,
            this.current7DataGridViewTextBoxColumn,
            this.current8DataGridViewTextBoxColumn,
            this.wattsDataGridViewTextBoxColumn,
            this.batterymahperkmDataGridViewTextBoxColumn,
            this.batterykmleftDataGridViewTextBoxColumn,
            this.batteryusedmahDataGridViewTextBoxColumn,
            this.batterycell1DataGridViewTextBoxColumn,
            this.batterycell2DataGridViewTextBoxColumn,
            this.batterycell3DataGridViewTextBoxColumn,
            this.batterycell4DataGridViewTextBoxColumn,
            this.batterycell5DataGridViewTextBoxColumn,
            this.batterycell6DataGridViewTextBoxColumn,
            this.batterytempDataGridViewTextBoxColumn,
            this.batteryusedmah2DataGridViewTextBoxColumn,
            this.batteryusedmah3DataGridViewTextBoxColumn,
            this.batteryusedmah4DataGridViewTextBoxColumn,
            this.batteryusedmah5DataGridViewTextBoxColumn,
            this.batteryusedmah6DataGridViewTextBoxColumn,
            this.batteryusedmah7DataGridViewTextBoxColumn,
            this.batteryusedmah8DataGridViewTextBoxColumn,
            this.batteryvoltage2DataGridViewTextBoxColumn,
            this.homeAltDataGridViewTextBoxColumn,
            this.homeLocationDataGridViewTextBoxColumn,
            this.movingBaseDataGridViewTextBoxColumn,
            this.trackerLocationDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.targetLocationDataGridViewTextBoxColumn,
            this.distFromMovingBaseDataGridViewTextBoxColumn,
            this.eLToMAVDataGridViewTextBoxColumn,
            this.aZToMAVDataGridViewTextBoxColumn,
            this.sonarrangeDataGridViewTextBoxColumn,
            this.sonarvoltageDataGridViewTextBoxColumn,
            this.rangefinder2DataGridViewTextBoxColumn,
            this.rangefinder3DataGridViewTextBoxColumn,
            this.freememDataGridViewTextBoxColumn,
            this.loadDataGridViewTextBoxColumn,
            this.brklevelDataGridViewTextBoxColumn,
            this.armedDataGridViewCheckBoxColumn,
            this.rssiDataGridViewTextBoxColumn,
            this.remrssiDataGridViewTextBoxColumn,
            this.txbufferDataGridViewTextBoxColumn,
            this.noiseDataGridViewTextBoxColumn,
            this.remnoiseDataGridViewTextBoxColumn,
            this.rxerrorsDataGridViewTextBoxColumn,
            this.fixedpDataGridViewTextBoxColumn,
            this.localsnrdbDataGridViewTextBoxColumn,
            this.remotesnrdbDataGridViewTextBoxColumn,
            this.distRSSIRemainDataGridViewTextBoxColumn,
            this.packetdropremoteDataGridViewTextBoxColumn,
            this.linkqualitygcsDataGridViewTextBoxColumn,
            this.hwvoltageDataGridViewTextBoxColumn,
            this.boardvoltageDataGridViewTextBoxColumn,
            this.servovoltageDataGridViewTextBoxColumn,
            this.voltageflagDataGridViewTextBoxColumn,
            this.i2cerrorsDataGridViewTextBoxColumn,
            this.timesincelastshotDataGridViewTextBoxColumn,
            this.pressabsDataGridViewTextBoxColumn,
            this.presstempDataGridViewTextBoxColumn,
            this.pressabs2DataGridViewTextBoxColumn,
            this.presstemp2DataGridViewTextBoxColumn,
            this.magofsxDataGridViewTextBoxColumn,
            this.magofsyDataGridViewTextBoxColumn,
            this.magofszDataGridViewTextBoxColumn,
            this.magdeclinationDataGridViewTextBoxColumn,
            this.rawpressDataGridViewTextBoxColumn,
            this.rawtempDataGridViewTextBoxColumn,
            this.gyrocalxDataGridViewTextBoxColumn,
            this.gyrocalyDataGridViewTextBoxColumn,
            this.gyrocalzDataGridViewTextBoxColumn,
            this.accelcalxDataGridViewTextBoxColumn,
            this.accelcalyDataGridViewTextBoxColumn,
            this.accelcalzDataGridViewTextBoxColumn,
            this.rateattitudeDataGridViewTextBoxColumn,
            this.ratepositionDataGridViewTextBoxColumn,
            this.ratestatusDataGridViewTextBoxColumn,
            this.ratesensorsDataGridViewTextBoxColumn,
            this.ratercDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn,
            this.connectedDataGridViewCheckBoxColumn,
            this.campointaDataGridViewTextBoxColumn,
            this.campointbDataGridViewTextBoxColumn,
            this.campointcDataGridViewTextBoxColumn,
            this.gimbalPointDataGridViewTextBoxColumn,
            this.gimballatDataGridViewTextBoxColumn,
            this.gimballngDataGridViewTextBoxColumn,
            this.landedDataGridViewCheckBoxColumn,
            this.terrainactiveDataGridViewCheckBoxColumn,
            this.tercuraltDataGridViewTextBoxColumn,
            this.teraltDataGridViewTextBoxColumn,
            this.terloadDataGridViewTextBoxColumn,
            this.terpendDataGridViewTextBoxColumn,
            this.terspaceDataGridViewTextBoxColumn,
            this.kIndexDataGridViewTextBoxColumn,
            this.optmxDataGridViewTextBoxColumn,
            this.optmyDataGridViewTextBoxColumn,
            this.optxDataGridViewTextBoxColumn,
            this.optyDataGridViewTextBoxColumn,
            this.optquaDataGridViewTextBoxColumn,
            this.ekfstatusDataGridViewTextBoxColumn,
            this.ekfflagsDataGridViewTextBoxColumn,
            this.ekfvelvDataGridViewTextBoxColumn,
            this.ekfcompvDataGridViewTextBoxColumn,
            this.ekfposhorDataGridViewTextBoxColumn,
            this.ekfposvertDataGridViewTextBoxColumn,
            this.ekfteraltDataGridViewTextBoxColumn,
            this.pidffDataGridViewTextBoxColumn,
            this.pidPDataGridViewTextBoxColumn,
            this.pidIDataGridViewTextBoxColumn,
            this.pidDDataGridViewTextBoxColumn,
            this.pidaxisDataGridViewTextBoxColumn,
            this.piddesiredDataGridViewTextBoxColumn,
            this.pidachievedDataGridViewTextBoxColumn,
            this.vibeclip0DataGridViewTextBoxColumn,
            this.vibeclip1DataGridViewTextBoxColumn,
            this.vibeclip2DataGridViewTextBoxColumn,
            this.vibexDataGridViewTextBoxColumn,
            this.vibeyDataGridViewTextBoxColumn,
            this.vibezDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.rpm1DataGridViewTextBoxColumn,
            this.rpm2DataGridViewTextBoxColumn,
            this.capabilitiesDataGridViewTextBoxColumn,
            this.speedupDataGridViewTextBoxColumn,
            this.vtolstateDataGridViewTextBoxColumn,
            this.landedstateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceQuickTab;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // groundspeedDataGridViewTextBoxColumn
            // 
            this.groundspeedDataGridViewTextBoxColumn.DataPropertyName = "groundspeed";
            resources.ApplyResources(this.groundspeedDataGridViewTextBoxColumn, "groundspeedDataGridViewTextBoxColumn");
            this.groundspeedDataGridViewTextBoxColumn.Name = "groundspeedDataGridViewTextBoxColumn";
            // 
            // wpdistDataGridViewTextBoxColumn
            // 
            this.wpdistDataGridViewTextBoxColumn.DataPropertyName = "wp_dist";
            resources.ApplyResources(this.wpdistDataGridViewTextBoxColumn, "wpdistDataGridViewTextBoxColumn");
            this.wpdistDataGridViewTextBoxColumn.Name = "wpdistDataGridViewTextBoxColumn";
            // 
            // distToHomeDataGridViewTextBoxColumn
            // 
            this.distToHomeDataGridViewTextBoxColumn.DataPropertyName = "DistToHome";
            resources.ApplyResources(this.distToHomeDataGridViewTextBoxColumn, "distToHomeDataGridViewTextBoxColumn");
            this.distToHomeDataGridViewTextBoxColumn.Name = "distToHomeDataGridViewTextBoxColumn";
            this.distToHomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rangefinder1DataGridViewTextBoxColumn
            // 
            this.rangefinder1DataGridViewTextBoxColumn.DataPropertyName = "rangefinder1";
            resources.ApplyResources(this.rangefinder1DataGridViewTextBoxColumn, "rangefinder1DataGridViewTextBoxColumn");
            this.rangefinder1DataGridViewTextBoxColumn.Name = "rangefinder1DataGridViewTextBoxColumn";
            // 
            // parentDataGridViewTextBoxColumn
            // 
            this.parentDataGridViewTextBoxColumn.DataPropertyName = "parent";
            resources.ApplyResources(this.parentDataGridViewTextBoxColumn, "parentDataGridViewTextBoxColumn");
            this.parentDataGridViewTextBoxColumn.Name = "parentDataGridViewTextBoxColumn";
            // 
            // rollDataGridViewTextBoxColumn
            // 
            this.rollDataGridViewTextBoxColumn.DataPropertyName = "roll";
            resources.ApplyResources(this.rollDataGridViewTextBoxColumn, "rollDataGridViewTextBoxColumn");
            this.rollDataGridViewTextBoxColumn.Name = "rollDataGridViewTextBoxColumn";
            // 
            // pitchDataGridViewTextBoxColumn
            // 
            this.pitchDataGridViewTextBoxColumn.DataPropertyName = "pitch";
            resources.ApplyResources(this.pitchDataGridViewTextBoxColumn, "pitchDataGridViewTextBoxColumn");
            this.pitchDataGridViewTextBoxColumn.Name = "pitchDataGridViewTextBoxColumn";
            // 
            // yawDataGridViewTextBoxColumn
            // 
            this.yawDataGridViewTextBoxColumn.DataPropertyName = "yaw";
            resources.ApplyResources(this.yawDataGridViewTextBoxColumn, "yawDataGridViewTextBoxColumn");
            this.yawDataGridViewTextBoxColumn.Name = "yawDataGridViewTextBoxColumn";
            // 
            // sSADataGridViewTextBoxColumn
            // 
            this.sSADataGridViewTextBoxColumn.DataPropertyName = "SSA";
            resources.ApplyResources(this.sSADataGridViewTextBoxColumn, "sSADataGridViewTextBoxColumn");
            this.sSADataGridViewTextBoxColumn.Name = "sSADataGridViewTextBoxColumn";
            // 
            // aOADataGridViewTextBoxColumn
            // 
            this.aOADataGridViewTextBoxColumn.DataPropertyName = "AOA";
            resources.ApplyResources(this.aOADataGridViewTextBoxColumn, "aOADataGridViewTextBoxColumn");
            this.aOADataGridViewTextBoxColumn.Name = "aOADataGridViewTextBoxColumn";
            // 
            // groundcourseDataGridViewTextBoxColumn
            // 
            this.groundcourseDataGridViewTextBoxColumn.DataPropertyName = "groundcourse";
            resources.ApplyResources(this.groundcourseDataGridViewTextBoxColumn, "groundcourseDataGridViewTextBoxColumn");
            this.groundcourseDataGridViewTextBoxColumn.Name = "groundcourseDataGridViewTextBoxColumn";
            // 
            // latDataGridViewTextBoxColumn
            // 
            this.latDataGridViewTextBoxColumn.DataPropertyName = "lat";
            resources.ApplyResources(this.latDataGridViewTextBoxColumn, "latDataGridViewTextBoxColumn");
            this.latDataGridViewTextBoxColumn.Name = "latDataGridViewTextBoxColumn";
            // 
            // lngDataGridViewTextBoxColumn
            // 
            this.lngDataGridViewTextBoxColumn.DataPropertyName = "lng";
            resources.ApplyResources(this.lngDataGridViewTextBoxColumn, "lngDataGridViewTextBoxColumn");
            this.lngDataGridViewTextBoxColumn.Name = "lngDataGridViewTextBoxColumn";
            // 
            // altDataGridViewTextBoxColumn
            // 
            this.altDataGridViewTextBoxColumn.DataPropertyName = "alt";
            resources.ApplyResources(this.altDataGridViewTextBoxColumn, "altDataGridViewTextBoxColumn");
            this.altDataGridViewTextBoxColumn.Name = "altDataGridViewTextBoxColumn";
            // 
            // altaslDataGridViewTextBoxColumn
            // 
            this.altaslDataGridViewTextBoxColumn.DataPropertyName = "altasl";
            resources.ApplyResources(this.altaslDataGridViewTextBoxColumn, "altaslDataGridViewTextBoxColumn");
            this.altaslDataGridViewTextBoxColumn.Name = "altaslDataGridViewTextBoxColumn";
            // 
            // horizondistDataGridViewTextBoxColumn
            // 
            this.horizondistDataGridViewTextBoxColumn.DataPropertyName = "horizondist";
            resources.ApplyResources(this.horizondistDataGridViewTextBoxColumn, "horizondistDataGridViewTextBoxColumn");
            this.horizondistDataGridViewTextBoxColumn.Name = "horizondistDataGridViewTextBoxColumn";
            this.horizondistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vxDataGridViewTextBoxColumn
            // 
            this.vxDataGridViewTextBoxColumn.DataPropertyName = "vx";
            resources.ApplyResources(this.vxDataGridViewTextBoxColumn, "vxDataGridViewTextBoxColumn");
            this.vxDataGridViewTextBoxColumn.Name = "vxDataGridViewTextBoxColumn";
            // 
            // vyDataGridViewTextBoxColumn
            // 
            this.vyDataGridViewTextBoxColumn.DataPropertyName = "vy";
            resources.ApplyResources(this.vyDataGridViewTextBoxColumn, "vyDataGridViewTextBoxColumn");
            this.vyDataGridViewTextBoxColumn.Name = "vyDataGridViewTextBoxColumn";
            // 
            // vzDataGridViewTextBoxColumn
            // 
            this.vzDataGridViewTextBoxColumn.DataPropertyName = "vz";
            resources.ApplyResources(this.vzDataGridViewTextBoxColumn, "vzDataGridViewTextBoxColumn");
            this.vzDataGridViewTextBoxColumn.Name = "vzDataGridViewTextBoxColumn";
            // 
            // vlenDataGridViewTextBoxColumn
            // 
            this.vlenDataGridViewTextBoxColumn.DataPropertyName = "vlen";
            resources.ApplyResources(this.vlenDataGridViewTextBoxColumn, "vlenDataGridViewTextBoxColumn");
            this.vlenDataGridViewTextBoxColumn.Name = "vlenDataGridViewTextBoxColumn";
            this.vlenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // altoffsethomeDataGridViewTextBoxColumn
            // 
            this.altoffsethomeDataGridViewTextBoxColumn.DataPropertyName = "altoffsethome";
            resources.ApplyResources(this.altoffsethomeDataGridViewTextBoxColumn, "altoffsethomeDataGridViewTextBoxColumn");
            this.altoffsethomeDataGridViewTextBoxColumn.Name = "altoffsethomeDataGridViewTextBoxColumn";
            // 
            // gpsstatusDataGridViewTextBoxColumn
            // 
            this.gpsstatusDataGridViewTextBoxColumn.DataPropertyName = "gpsstatus";
            resources.ApplyResources(this.gpsstatusDataGridViewTextBoxColumn, "gpsstatusDataGridViewTextBoxColumn");
            this.gpsstatusDataGridViewTextBoxColumn.Name = "gpsstatusDataGridViewTextBoxColumn";
            // 
            // gpshdopDataGridViewTextBoxColumn
            // 
            this.gpshdopDataGridViewTextBoxColumn.DataPropertyName = "gpshdop";
            resources.ApplyResources(this.gpshdopDataGridViewTextBoxColumn, "gpshdopDataGridViewTextBoxColumn");
            this.gpshdopDataGridViewTextBoxColumn.Name = "gpshdopDataGridViewTextBoxColumn";
            // 
            // satcountDataGridViewTextBoxColumn
            // 
            this.satcountDataGridViewTextBoxColumn.DataPropertyName = "satcount";
            resources.ApplyResources(this.satcountDataGridViewTextBoxColumn, "satcountDataGridViewTextBoxColumn");
            this.satcountDataGridViewTextBoxColumn.Name = "satcountDataGridViewTextBoxColumn";
            // 
            // gpshaccDataGridViewTextBoxColumn
            // 
            this.gpshaccDataGridViewTextBoxColumn.DataPropertyName = "gpsh_acc";
            resources.ApplyResources(this.gpshaccDataGridViewTextBoxColumn, "gpshaccDataGridViewTextBoxColumn");
            this.gpshaccDataGridViewTextBoxColumn.Name = "gpshaccDataGridViewTextBoxColumn";
            this.gpshaccDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gpsvaccDataGridViewTextBoxColumn
            // 
            this.gpsvaccDataGridViewTextBoxColumn.DataPropertyName = "gpsv_acc";
            resources.ApplyResources(this.gpsvaccDataGridViewTextBoxColumn, "gpsvaccDataGridViewTextBoxColumn");
            this.gpsvaccDataGridViewTextBoxColumn.Name = "gpsvaccDataGridViewTextBoxColumn";
            this.gpsvaccDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gpsvelaccDataGridViewTextBoxColumn
            // 
            this.gpsvelaccDataGridViewTextBoxColumn.DataPropertyName = "gpsvel_acc";
            resources.ApplyResources(this.gpsvelaccDataGridViewTextBoxColumn, "gpsvelaccDataGridViewTextBoxColumn");
            this.gpsvelaccDataGridViewTextBoxColumn.Name = "gpsvelaccDataGridViewTextBoxColumn";
            this.gpsvelaccDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gpshdgaccDataGridViewTextBoxColumn
            // 
            this.gpshdgaccDataGridViewTextBoxColumn.DataPropertyName = "gpshdg_acc";
            resources.ApplyResources(this.gpshdgaccDataGridViewTextBoxColumn, "gpshdgaccDataGridViewTextBoxColumn");
            this.gpshdgaccDataGridViewTextBoxColumn.Name = "gpshdgaccDataGridViewTextBoxColumn";
            this.gpshdgaccDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lat2DataGridViewTextBoxColumn
            // 
            this.lat2DataGridViewTextBoxColumn.DataPropertyName = "lat2";
            resources.ApplyResources(this.lat2DataGridViewTextBoxColumn, "lat2DataGridViewTextBoxColumn");
            this.lat2DataGridViewTextBoxColumn.Name = "lat2DataGridViewTextBoxColumn";
            // 
            // lng2DataGridViewTextBoxColumn
            // 
            this.lng2DataGridViewTextBoxColumn.DataPropertyName = "lng2";
            resources.ApplyResources(this.lng2DataGridViewTextBoxColumn, "lng2DataGridViewTextBoxColumn");
            this.lng2DataGridViewTextBoxColumn.Name = "lng2DataGridViewTextBoxColumn";
            // 
            // altasl2DataGridViewTextBoxColumn
            // 
            this.altasl2DataGridViewTextBoxColumn.DataPropertyName = "altasl2";
            resources.ApplyResources(this.altasl2DataGridViewTextBoxColumn, "altasl2DataGridViewTextBoxColumn");
            this.altasl2DataGridViewTextBoxColumn.Name = "altasl2DataGridViewTextBoxColumn";
            // 
            // gpsstatus2DataGridViewTextBoxColumn
            // 
            this.gpsstatus2DataGridViewTextBoxColumn.DataPropertyName = "gpsstatus2";
            resources.ApplyResources(this.gpsstatus2DataGridViewTextBoxColumn, "gpsstatus2DataGridViewTextBoxColumn");
            this.gpsstatus2DataGridViewTextBoxColumn.Name = "gpsstatus2DataGridViewTextBoxColumn";
            // 
            // gpshdop2DataGridViewTextBoxColumn
            // 
            this.gpshdop2DataGridViewTextBoxColumn.DataPropertyName = "gpshdop2";
            resources.ApplyResources(this.gpshdop2DataGridViewTextBoxColumn, "gpshdop2DataGridViewTextBoxColumn");
            this.gpshdop2DataGridViewTextBoxColumn.Name = "gpshdop2DataGridViewTextBoxColumn";
            // 
            // satcount2DataGridViewTextBoxColumn
            // 
            this.satcount2DataGridViewTextBoxColumn.DataPropertyName = "satcount2";
            resources.ApplyResources(this.satcount2DataGridViewTextBoxColumn, "satcount2DataGridViewTextBoxColumn");
            this.satcount2DataGridViewTextBoxColumn.Name = "satcount2DataGridViewTextBoxColumn";
            // 
            // groundspeed2DataGridViewTextBoxColumn
            // 
            this.groundspeed2DataGridViewTextBoxColumn.DataPropertyName = "groundspeed2";
            resources.ApplyResources(this.groundspeed2DataGridViewTextBoxColumn, "groundspeed2DataGridViewTextBoxColumn");
            this.groundspeed2DataGridViewTextBoxColumn.Name = "groundspeed2DataGridViewTextBoxColumn";
            // 
            // groundcourse2DataGridViewTextBoxColumn
            // 
            this.groundcourse2DataGridViewTextBoxColumn.DataPropertyName = "groundcourse2";
            resources.ApplyResources(this.groundcourse2DataGridViewTextBoxColumn, "groundcourse2DataGridViewTextBoxColumn");
            this.groundcourse2DataGridViewTextBoxColumn.Name = "groundcourse2DataGridViewTextBoxColumn";
            // 
            // satcountBDataGridViewTextBoxColumn
            // 
            this.satcountBDataGridViewTextBoxColumn.DataPropertyName = "satcountB";
            resources.ApplyResources(this.satcountBDataGridViewTextBoxColumn, "satcountBDataGridViewTextBoxColumn");
            this.satcountBDataGridViewTextBoxColumn.Name = "satcountBDataGridViewTextBoxColumn";
            this.satcountBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gpstimeDataGridViewTextBoxColumn
            // 
            this.gpstimeDataGridViewTextBoxColumn.DataPropertyName = "gpstime";
            resources.ApplyResources(this.gpstimeDataGridViewTextBoxColumn, "gpstimeDataGridViewTextBoxColumn");
            this.gpstimeDataGridViewTextBoxColumn.Name = "gpstimeDataGridViewTextBoxColumn";
            // 
            // altd1000DataGridViewTextBoxColumn
            // 
            this.altd1000DataGridViewTextBoxColumn.DataPropertyName = "altd1000";
            resources.ApplyResources(this.altd1000DataGridViewTextBoxColumn, "altd1000DataGridViewTextBoxColumn");
            this.altd1000DataGridViewTextBoxColumn.Name = "altd1000DataGridViewTextBoxColumn";
            this.altd1000DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // altd100DataGridViewTextBoxColumn
            // 
            this.altd100DataGridViewTextBoxColumn.DataPropertyName = "altd100";
            resources.ApplyResources(this.altd100DataGridViewTextBoxColumn, "altd100DataGridViewTextBoxColumn");
            this.altd100DataGridViewTextBoxColumn.Name = "altd100DataGridViewTextBoxColumn";
            this.altd100DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // airspeedDataGridViewTextBoxColumn
            // 
            this.airspeedDataGridViewTextBoxColumn.DataPropertyName = "airspeed";
            resources.ApplyResources(this.airspeedDataGridViewTextBoxColumn, "airspeedDataGridViewTextBoxColumn");
            this.airspeedDataGridViewTextBoxColumn.Name = "airspeedDataGridViewTextBoxColumn";
            // 
            // targetairspeedDataGridViewTextBoxColumn
            // 
            this.targetairspeedDataGridViewTextBoxColumn.DataPropertyName = "targetairspeed";
            resources.ApplyResources(this.targetairspeedDataGridViewTextBoxColumn, "targetairspeedDataGridViewTextBoxColumn");
            this.targetairspeedDataGridViewTextBoxColumn.Name = "targetairspeedDataGridViewTextBoxColumn";
            this.targetairspeedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lowairspeedDataGridViewCheckBoxColumn
            // 
            this.lowairspeedDataGridViewCheckBoxColumn.DataPropertyName = "lowairspeed";
            resources.ApplyResources(this.lowairspeedDataGridViewCheckBoxColumn, "lowairspeedDataGridViewCheckBoxColumn");
            this.lowairspeedDataGridViewCheckBoxColumn.Name = "lowairspeedDataGridViewCheckBoxColumn";
            // 
            // asratioDataGridViewTextBoxColumn
            // 
            this.asratioDataGridViewTextBoxColumn.DataPropertyName = "asratio";
            resources.ApplyResources(this.asratioDataGridViewTextBoxColumn, "asratioDataGridViewTextBoxColumn");
            this.asratioDataGridViewTextBoxColumn.Name = "asratioDataGridViewTextBoxColumn";
            // 
            // axDataGridViewTextBoxColumn
            // 
            this.axDataGridViewTextBoxColumn.DataPropertyName = "ax";
            resources.ApplyResources(this.axDataGridViewTextBoxColumn, "axDataGridViewTextBoxColumn");
            this.axDataGridViewTextBoxColumn.Name = "axDataGridViewTextBoxColumn";
            // 
            // ayDataGridViewTextBoxColumn
            // 
            this.ayDataGridViewTextBoxColumn.DataPropertyName = "ay";
            resources.ApplyResources(this.ayDataGridViewTextBoxColumn, "ayDataGridViewTextBoxColumn");
            this.ayDataGridViewTextBoxColumn.Name = "ayDataGridViewTextBoxColumn";
            // 
            // azDataGridViewTextBoxColumn
            // 
            this.azDataGridViewTextBoxColumn.DataPropertyName = "az";
            resources.ApplyResources(this.azDataGridViewTextBoxColumn, "azDataGridViewTextBoxColumn");
            this.azDataGridViewTextBoxColumn.Name = "azDataGridViewTextBoxColumn";
            // 
            // accelsqDataGridViewTextBoxColumn
            // 
            this.accelsqDataGridViewTextBoxColumn.DataPropertyName = "accelsq";
            resources.ApplyResources(this.accelsqDataGridViewTextBoxColumn, "accelsqDataGridViewTextBoxColumn");
            this.accelsqDataGridViewTextBoxColumn.Name = "accelsqDataGridViewTextBoxColumn";
            this.accelsqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gxDataGridViewTextBoxColumn
            // 
            this.gxDataGridViewTextBoxColumn.DataPropertyName = "gx";
            resources.ApplyResources(this.gxDataGridViewTextBoxColumn, "gxDataGridViewTextBoxColumn");
            this.gxDataGridViewTextBoxColumn.Name = "gxDataGridViewTextBoxColumn";
            // 
            // gyDataGridViewTextBoxColumn
            // 
            this.gyDataGridViewTextBoxColumn.DataPropertyName = "gy";
            resources.ApplyResources(this.gyDataGridViewTextBoxColumn, "gyDataGridViewTextBoxColumn");
            this.gyDataGridViewTextBoxColumn.Name = "gyDataGridViewTextBoxColumn";
            // 
            // gzDataGridViewTextBoxColumn
            // 
            this.gzDataGridViewTextBoxColumn.DataPropertyName = "gz";
            resources.ApplyResources(this.gzDataGridViewTextBoxColumn, "gzDataGridViewTextBoxColumn");
            this.gzDataGridViewTextBoxColumn.Name = "gzDataGridViewTextBoxColumn";
            // 
            // gyrosqDataGridViewTextBoxColumn
            // 
            this.gyrosqDataGridViewTextBoxColumn.DataPropertyName = "gyrosq";
            resources.ApplyResources(this.gyrosqDataGridViewTextBoxColumn, "gyrosqDataGridViewTextBoxColumn");
            this.gyrosqDataGridViewTextBoxColumn.Name = "gyrosqDataGridViewTextBoxColumn";
            this.gyrosqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mxDataGridViewTextBoxColumn
            // 
            this.mxDataGridViewTextBoxColumn.DataPropertyName = "mx";
            resources.ApplyResources(this.mxDataGridViewTextBoxColumn, "mxDataGridViewTextBoxColumn");
            this.mxDataGridViewTextBoxColumn.Name = "mxDataGridViewTextBoxColumn";
            // 
            // myDataGridViewTextBoxColumn
            // 
            this.myDataGridViewTextBoxColumn.DataPropertyName = "my";
            resources.ApplyResources(this.myDataGridViewTextBoxColumn, "myDataGridViewTextBoxColumn");
            this.myDataGridViewTextBoxColumn.Name = "myDataGridViewTextBoxColumn";
            // 
            // mzDataGridViewTextBoxColumn
            // 
            this.mzDataGridViewTextBoxColumn.DataPropertyName = "mz";
            resources.ApplyResources(this.mzDataGridViewTextBoxColumn, "mzDataGridViewTextBoxColumn");
            this.mzDataGridViewTextBoxColumn.Name = "mzDataGridViewTextBoxColumn";
            // 
            // magfieldDataGridViewTextBoxColumn
            // 
            this.magfieldDataGridViewTextBoxColumn.DataPropertyName = "magfield";
            resources.ApplyResources(this.magfieldDataGridViewTextBoxColumn, "magfieldDataGridViewTextBoxColumn");
            this.magfieldDataGridViewTextBoxColumn.Name = "magfieldDataGridViewTextBoxColumn";
            this.magfieldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ax2DataGridViewTextBoxColumn
            // 
            this.ax2DataGridViewTextBoxColumn.DataPropertyName = "ax2";
            resources.ApplyResources(this.ax2DataGridViewTextBoxColumn, "ax2DataGridViewTextBoxColumn");
            this.ax2DataGridViewTextBoxColumn.Name = "ax2DataGridViewTextBoxColumn";
            // 
            // ay2DataGridViewTextBoxColumn
            // 
            this.ay2DataGridViewTextBoxColumn.DataPropertyName = "ay2";
            resources.ApplyResources(this.ay2DataGridViewTextBoxColumn, "ay2DataGridViewTextBoxColumn");
            this.ay2DataGridViewTextBoxColumn.Name = "ay2DataGridViewTextBoxColumn";
            // 
            // az2DataGridViewTextBoxColumn
            // 
            this.az2DataGridViewTextBoxColumn.DataPropertyName = "az2";
            resources.ApplyResources(this.az2DataGridViewTextBoxColumn, "az2DataGridViewTextBoxColumn");
            this.az2DataGridViewTextBoxColumn.Name = "az2DataGridViewTextBoxColumn";
            // 
            // accelsq2DataGridViewTextBoxColumn
            // 
            this.accelsq2DataGridViewTextBoxColumn.DataPropertyName = "accelsq2";
            resources.ApplyResources(this.accelsq2DataGridViewTextBoxColumn, "accelsq2DataGridViewTextBoxColumn");
            this.accelsq2DataGridViewTextBoxColumn.Name = "accelsq2DataGridViewTextBoxColumn";
            this.accelsq2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gx2DataGridViewTextBoxColumn
            // 
            this.gx2DataGridViewTextBoxColumn.DataPropertyName = "gx2";
            resources.ApplyResources(this.gx2DataGridViewTextBoxColumn, "gx2DataGridViewTextBoxColumn");
            this.gx2DataGridViewTextBoxColumn.Name = "gx2DataGridViewTextBoxColumn";
            // 
            // gy2DataGridViewTextBoxColumn
            // 
            this.gy2DataGridViewTextBoxColumn.DataPropertyName = "gy2";
            resources.ApplyResources(this.gy2DataGridViewTextBoxColumn, "gy2DataGridViewTextBoxColumn");
            this.gy2DataGridViewTextBoxColumn.Name = "gy2DataGridViewTextBoxColumn";
            // 
            // gz2DataGridViewTextBoxColumn
            // 
            this.gz2DataGridViewTextBoxColumn.DataPropertyName = "gz2";
            resources.ApplyResources(this.gz2DataGridViewTextBoxColumn, "gz2DataGridViewTextBoxColumn");
            this.gz2DataGridViewTextBoxColumn.Name = "gz2DataGridViewTextBoxColumn";
            // 
            // gyrosq2DataGridViewTextBoxColumn
            // 
            this.gyrosq2DataGridViewTextBoxColumn.DataPropertyName = "gyrosq2";
            resources.ApplyResources(this.gyrosq2DataGridViewTextBoxColumn, "gyrosq2DataGridViewTextBoxColumn");
            this.gyrosq2DataGridViewTextBoxColumn.Name = "gyrosq2DataGridViewTextBoxColumn";
            this.gyrosq2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mx2DataGridViewTextBoxColumn
            // 
            this.mx2DataGridViewTextBoxColumn.DataPropertyName = "mx2";
            resources.ApplyResources(this.mx2DataGridViewTextBoxColumn, "mx2DataGridViewTextBoxColumn");
            this.mx2DataGridViewTextBoxColumn.Name = "mx2DataGridViewTextBoxColumn";
            // 
            // my2DataGridViewTextBoxColumn
            // 
            this.my2DataGridViewTextBoxColumn.DataPropertyName = "my2";
            resources.ApplyResources(this.my2DataGridViewTextBoxColumn, "my2DataGridViewTextBoxColumn");
            this.my2DataGridViewTextBoxColumn.Name = "my2DataGridViewTextBoxColumn";
            // 
            // mz2DataGridViewTextBoxColumn
            // 
            this.mz2DataGridViewTextBoxColumn.DataPropertyName = "mz2";
            resources.ApplyResources(this.mz2DataGridViewTextBoxColumn, "mz2DataGridViewTextBoxColumn");
            this.mz2DataGridViewTextBoxColumn.Name = "mz2DataGridViewTextBoxColumn";
            // 
            // magfield2DataGridViewTextBoxColumn
            // 
            this.magfield2DataGridViewTextBoxColumn.DataPropertyName = "magfield2";
            resources.ApplyResources(this.magfield2DataGridViewTextBoxColumn, "magfield2DataGridViewTextBoxColumn");
            this.magfield2DataGridViewTextBoxColumn.Name = "magfield2DataGridViewTextBoxColumn";
            this.magfield2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ax3DataGridViewTextBoxColumn
            // 
            this.ax3DataGridViewTextBoxColumn.DataPropertyName = "ax3";
            resources.ApplyResources(this.ax3DataGridViewTextBoxColumn, "ax3DataGridViewTextBoxColumn");
            this.ax3DataGridViewTextBoxColumn.Name = "ax3DataGridViewTextBoxColumn";
            // 
            // ay3DataGridViewTextBoxColumn
            // 
            this.ay3DataGridViewTextBoxColumn.DataPropertyName = "ay3";
            resources.ApplyResources(this.ay3DataGridViewTextBoxColumn, "ay3DataGridViewTextBoxColumn");
            this.ay3DataGridViewTextBoxColumn.Name = "ay3DataGridViewTextBoxColumn";
            // 
            // az3DataGridViewTextBoxColumn
            // 
            this.az3DataGridViewTextBoxColumn.DataPropertyName = "az3";
            resources.ApplyResources(this.az3DataGridViewTextBoxColumn, "az3DataGridViewTextBoxColumn");
            this.az3DataGridViewTextBoxColumn.Name = "az3DataGridViewTextBoxColumn";
            // 
            // accelsq3DataGridViewTextBoxColumn
            // 
            this.accelsq3DataGridViewTextBoxColumn.DataPropertyName = "accelsq3";
            resources.ApplyResources(this.accelsq3DataGridViewTextBoxColumn, "accelsq3DataGridViewTextBoxColumn");
            this.accelsq3DataGridViewTextBoxColumn.Name = "accelsq3DataGridViewTextBoxColumn";
            this.accelsq3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gx3DataGridViewTextBoxColumn
            // 
            this.gx3DataGridViewTextBoxColumn.DataPropertyName = "gx3";
            resources.ApplyResources(this.gx3DataGridViewTextBoxColumn, "gx3DataGridViewTextBoxColumn");
            this.gx3DataGridViewTextBoxColumn.Name = "gx3DataGridViewTextBoxColumn";
            // 
            // gy3DataGridViewTextBoxColumn
            // 
            this.gy3DataGridViewTextBoxColumn.DataPropertyName = "gy3";
            resources.ApplyResources(this.gy3DataGridViewTextBoxColumn, "gy3DataGridViewTextBoxColumn");
            this.gy3DataGridViewTextBoxColumn.Name = "gy3DataGridViewTextBoxColumn";
            // 
            // gz3DataGridViewTextBoxColumn
            // 
            this.gz3DataGridViewTextBoxColumn.DataPropertyName = "gz3";
            resources.ApplyResources(this.gz3DataGridViewTextBoxColumn, "gz3DataGridViewTextBoxColumn");
            this.gz3DataGridViewTextBoxColumn.Name = "gz3DataGridViewTextBoxColumn";
            // 
            // gyrosq3DataGridViewTextBoxColumn
            // 
            this.gyrosq3DataGridViewTextBoxColumn.DataPropertyName = "gyrosq3";
            resources.ApplyResources(this.gyrosq3DataGridViewTextBoxColumn, "gyrosq3DataGridViewTextBoxColumn");
            this.gyrosq3DataGridViewTextBoxColumn.Name = "gyrosq3DataGridViewTextBoxColumn";
            this.gyrosq3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mx3DataGridViewTextBoxColumn
            // 
            this.mx3DataGridViewTextBoxColumn.DataPropertyName = "mx3";
            resources.ApplyResources(this.mx3DataGridViewTextBoxColumn, "mx3DataGridViewTextBoxColumn");
            this.mx3DataGridViewTextBoxColumn.Name = "mx3DataGridViewTextBoxColumn";
            // 
            // my3DataGridViewTextBoxColumn
            // 
            this.my3DataGridViewTextBoxColumn.DataPropertyName = "my3";
            resources.ApplyResources(this.my3DataGridViewTextBoxColumn, "my3DataGridViewTextBoxColumn");
            this.my3DataGridViewTextBoxColumn.Name = "my3DataGridViewTextBoxColumn";
            // 
            // mz3DataGridViewTextBoxColumn
            // 
            this.mz3DataGridViewTextBoxColumn.DataPropertyName = "mz3";
            resources.ApplyResources(this.mz3DataGridViewTextBoxColumn, "mz3DataGridViewTextBoxColumn");
            this.mz3DataGridViewTextBoxColumn.Name = "mz3DataGridViewTextBoxColumn";
            // 
            // magfield3DataGridViewTextBoxColumn
            // 
            this.magfield3DataGridViewTextBoxColumn.DataPropertyName = "magfield3";
            resources.ApplyResources(this.magfield3DataGridViewTextBoxColumn, "magfield3DataGridViewTextBoxColumn");
            this.magfield3DataGridViewTextBoxColumn.Name = "magfield3DataGridViewTextBoxColumn";
            this.magfield3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ch1inDataGridViewTextBoxColumn
            // 
            this.ch1inDataGridViewTextBoxColumn.DataPropertyName = "ch1in";
            resources.ApplyResources(this.ch1inDataGridViewTextBoxColumn, "ch1inDataGridViewTextBoxColumn");
            this.ch1inDataGridViewTextBoxColumn.Name = "ch1inDataGridViewTextBoxColumn";
            // 
            // ch2inDataGridViewTextBoxColumn
            // 
            this.ch2inDataGridViewTextBoxColumn.DataPropertyName = "ch2in";
            resources.ApplyResources(this.ch2inDataGridViewTextBoxColumn, "ch2inDataGridViewTextBoxColumn");
            this.ch2inDataGridViewTextBoxColumn.Name = "ch2inDataGridViewTextBoxColumn";
            // 
            // ch3inDataGridViewTextBoxColumn
            // 
            this.ch3inDataGridViewTextBoxColumn.DataPropertyName = "ch3in";
            resources.ApplyResources(this.ch3inDataGridViewTextBoxColumn, "ch3inDataGridViewTextBoxColumn");
            this.ch3inDataGridViewTextBoxColumn.Name = "ch3inDataGridViewTextBoxColumn";
            // 
            // ch4inDataGridViewTextBoxColumn
            // 
            this.ch4inDataGridViewTextBoxColumn.DataPropertyName = "ch4in";
            resources.ApplyResources(this.ch4inDataGridViewTextBoxColumn, "ch4inDataGridViewTextBoxColumn");
            this.ch4inDataGridViewTextBoxColumn.Name = "ch4inDataGridViewTextBoxColumn";
            // 
            // ch5inDataGridViewTextBoxColumn
            // 
            this.ch5inDataGridViewTextBoxColumn.DataPropertyName = "ch5in";
            resources.ApplyResources(this.ch5inDataGridViewTextBoxColumn, "ch5inDataGridViewTextBoxColumn");
            this.ch5inDataGridViewTextBoxColumn.Name = "ch5inDataGridViewTextBoxColumn";
            // 
            // ch6inDataGridViewTextBoxColumn
            // 
            this.ch6inDataGridViewTextBoxColumn.DataPropertyName = "ch6in";
            resources.ApplyResources(this.ch6inDataGridViewTextBoxColumn, "ch6inDataGridViewTextBoxColumn");
            this.ch6inDataGridViewTextBoxColumn.Name = "ch6inDataGridViewTextBoxColumn";
            // 
            // ch7inDataGridViewTextBoxColumn
            // 
            this.ch7inDataGridViewTextBoxColumn.DataPropertyName = "ch7in";
            resources.ApplyResources(this.ch7inDataGridViewTextBoxColumn, "ch7inDataGridViewTextBoxColumn");
            this.ch7inDataGridViewTextBoxColumn.Name = "ch7inDataGridViewTextBoxColumn";
            // 
            // ch8inDataGridViewTextBoxColumn
            // 
            this.ch8inDataGridViewTextBoxColumn.DataPropertyName = "ch8in";
            resources.ApplyResources(this.ch8inDataGridViewTextBoxColumn, "ch8inDataGridViewTextBoxColumn");
            this.ch8inDataGridViewTextBoxColumn.Name = "ch8inDataGridViewTextBoxColumn";
            // 
            // ch9inDataGridViewTextBoxColumn
            // 
            this.ch9inDataGridViewTextBoxColumn.DataPropertyName = "ch9in";
            resources.ApplyResources(this.ch9inDataGridViewTextBoxColumn, "ch9inDataGridViewTextBoxColumn");
            this.ch9inDataGridViewTextBoxColumn.Name = "ch9inDataGridViewTextBoxColumn";
            // 
            // ch10inDataGridViewTextBoxColumn
            // 
            this.ch10inDataGridViewTextBoxColumn.DataPropertyName = "ch10in";
            resources.ApplyResources(this.ch10inDataGridViewTextBoxColumn, "ch10inDataGridViewTextBoxColumn");
            this.ch10inDataGridViewTextBoxColumn.Name = "ch10inDataGridViewTextBoxColumn";
            // 
            // ch11inDataGridViewTextBoxColumn
            // 
            this.ch11inDataGridViewTextBoxColumn.DataPropertyName = "ch11in";
            resources.ApplyResources(this.ch11inDataGridViewTextBoxColumn, "ch11inDataGridViewTextBoxColumn");
            this.ch11inDataGridViewTextBoxColumn.Name = "ch11inDataGridViewTextBoxColumn";
            // 
            // ch12inDataGridViewTextBoxColumn
            // 
            this.ch12inDataGridViewTextBoxColumn.DataPropertyName = "ch12in";
            resources.ApplyResources(this.ch12inDataGridViewTextBoxColumn, "ch12inDataGridViewTextBoxColumn");
            this.ch12inDataGridViewTextBoxColumn.Name = "ch12inDataGridViewTextBoxColumn";
            // 
            // ch13inDataGridViewTextBoxColumn
            // 
            this.ch13inDataGridViewTextBoxColumn.DataPropertyName = "ch13in";
            resources.ApplyResources(this.ch13inDataGridViewTextBoxColumn, "ch13inDataGridViewTextBoxColumn");
            this.ch13inDataGridViewTextBoxColumn.Name = "ch13inDataGridViewTextBoxColumn";
            // 
            // ch14inDataGridViewTextBoxColumn
            // 
            this.ch14inDataGridViewTextBoxColumn.DataPropertyName = "ch14in";
            resources.ApplyResources(this.ch14inDataGridViewTextBoxColumn, "ch14inDataGridViewTextBoxColumn");
            this.ch14inDataGridViewTextBoxColumn.Name = "ch14inDataGridViewTextBoxColumn";
            // 
            // ch15inDataGridViewTextBoxColumn
            // 
            this.ch15inDataGridViewTextBoxColumn.DataPropertyName = "ch15in";
            resources.ApplyResources(this.ch15inDataGridViewTextBoxColumn, "ch15inDataGridViewTextBoxColumn");
            this.ch15inDataGridViewTextBoxColumn.Name = "ch15inDataGridViewTextBoxColumn";
            // 
            // ch16inDataGridViewTextBoxColumn
            // 
            this.ch16inDataGridViewTextBoxColumn.DataPropertyName = "ch16in";
            resources.ApplyResources(this.ch16inDataGridViewTextBoxColumn, "ch16inDataGridViewTextBoxColumn");
            this.ch16inDataGridViewTextBoxColumn.Name = "ch16inDataGridViewTextBoxColumn";
            // 
            // ch1outDataGridViewTextBoxColumn
            // 
            this.ch1outDataGridViewTextBoxColumn.DataPropertyName = "ch1out";
            resources.ApplyResources(this.ch1outDataGridViewTextBoxColumn, "ch1outDataGridViewTextBoxColumn");
            this.ch1outDataGridViewTextBoxColumn.Name = "ch1outDataGridViewTextBoxColumn";
            // 
            // ch2outDataGridViewTextBoxColumn
            // 
            this.ch2outDataGridViewTextBoxColumn.DataPropertyName = "ch2out";
            resources.ApplyResources(this.ch2outDataGridViewTextBoxColumn, "ch2outDataGridViewTextBoxColumn");
            this.ch2outDataGridViewTextBoxColumn.Name = "ch2outDataGridViewTextBoxColumn";
            // 
            // ch3outDataGridViewTextBoxColumn
            // 
            this.ch3outDataGridViewTextBoxColumn.DataPropertyName = "ch3out";
            resources.ApplyResources(this.ch3outDataGridViewTextBoxColumn, "ch3outDataGridViewTextBoxColumn");
            this.ch3outDataGridViewTextBoxColumn.Name = "ch3outDataGridViewTextBoxColumn";
            // 
            // ch4outDataGridViewTextBoxColumn
            // 
            this.ch4outDataGridViewTextBoxColumn.DataPropertyName = "ch4out";
            resources.ApplyResources(this.ch4outDataGridViewTextBoxColumn, "ch4outDataGridViewTextBoxColumn");
            this.ch4outDataGridViewTextBoxColumn.Name = "ch4outDataGridViewTextBoxColumn";
            // 
            // ch5outDataGridViewTextBoxColumn
            // 
            this.ch5outDataGridViewTextBoxColumn.DataPropertyName = "ch5out";
            resources.ApplyResources(this.ch5outDataGridViewTextBoxColumn, "ch5outDataGridViewTextBoxColumn");
            this.ch5outDataGridViewTextBoxColumn.Name = "ch5outDataGridViewTextBoxColumn";
            // 
            // ch6outDataGridViewTextBoxColumn
            // 
            this.ch6outDataGridViewTextBoxColumn.DataPropertyName = "ch6out";
            resources.ApplyResources(this.ch6outDataGridViewTextBoxColumn, "ch6outDataGridViewTextBoxColumn");
            this.ch6outDataGridViewTextBoxColumn.Name = "ch6outDataGridViewTextBoxColumn";
            // 
            // ch7outDataGridViewTextBoxColumn
            // 
            this.ch7outDataGridViewTextBoxColumn.DataPropertyName = "ch7out";
            resources.ApplyResources(this.ch7outDataGridViewTextBoxColumn, "ch7outDataGridViewTextBoxColumn");
            this.ch7outDataGridViewTextBoxColumn.Name = "ch7outDataGridViewTextBoxColumn";
            // 
            // ch8outDataGridViewTextBoxColumn
            // 
            this.ch8outDataGridViewTextBoxColumn.DataPropertyName = "ch8out";
            resources.ApplyResources(this.ch8outDataGridViewTextBoxColumn, "ch8outDataGridViewTextBoxColumn");
            this.ch8outDataGridViewTextBoxColumn.Name = "ch8outDataGridViewTextBoxColumn";
            // 
            // ch9outDataGridViewTextBoxColumn
            // 
            this.ch9outDataGridViewTextBoxColumn.DataPropertyName = "ch9out";
            resources.ApplyResources(this.ch9outDataGridViewTextBoxColumn, "ch9outDataGridViewTextBoxColumn");
            this.ch9outDataGridViewTextBoxColumn.Name = "ch9outDataGridViewTextBoxColumn";
            // 
            // ch10outDataGridViewTextBoxColumn
            // 
            this.ch10outDataGridViewTextBoxColumn.DataPropertyName = "ch10out";
            resources.ApplyResources(this.ch10outDataGridViewTextBoxColumn, "ch10outDataGridViewTextBoxColumn");
            this.ch10outDataGridViewTextBoxColumn.Name = "ch10outDataGridViewTextBoxColumn";
            // 
            // ch11outDataGridViewTextBoxColumn
            // 
            this.ch11outDataGridViewTextBoxColumn.DataPropertyName = "ch11out";
            resources.ApplyResources(this.ch11outDataGridViewTextBoxColumn, "ch11outDataGridViewTextBoxColumn");
            this.ch11outDataGridViewTextBoxColumn.Name = "ch11outDataGridViewTextBoxColumn";
            // 
            // ch12outDataGridViewTextBoxColumn
            // 
            this.ch12outDataGridViewTextBoxColumn.DataPropertyName = "ch12out";
            resources.ApplyResources(this.ch12outDataGridViewTextBoxColumn, "ch12outDataGridViewTextBoxColumn");
            this.ch12outDataGridViewTextBoxColumn.Name = "ch12outDataGridViewTextBoxColumn";
            // 
            // ch13outDataGridViewTextBoxColumn
            // 
            this.ch13outDataGridViewTextBoxColumn.DataPropertyName = "ch13out";
            resources.ApplyResources(this.ch13outDataGridViewTextBoxColumn, "ch13outDataGridViewTextBoxColumn");
            this.ch13outDataGridViewTextBoxColumn.Name = "ch13outDataGridViewTextBoxColumn";
            // 
            // ch14outDataGridViewTextBoxColumn
            // 
            this.ch14outDataGridViewTextBoxColumn.DataPropertyName = "ch14out";
            resources.ApplyResources(this.ch14outDataGridViewTextBoxColumn, "ch14outDataGridViewTextBoxColumn");
            this.ch14outDataGridViewTextBoxColumn.Name = "ch14outDataGridViewTextBoxColumn";
            // 
            // ch15outDataGridViewTextBoxColumn
            // 
            this.ch15outDataGridViewTextBoxColumn.DataPropertyName = "ch15out";
            resources.ApplyResources(this.ch15outDataGridViewTextBoxColumn, "ch15outDataGridViewTextBoxColumn");
            this.ch15outDataGridViewTextBoxColumn.Name = "ch15outDataGridViewTextBoxColumn";
            // 
            // ch16outDataGridViewTextBoxColumn
            // 
            this.ch16outDataGridViewTextBoxColumn.DataPropertyName = "ch16out";
            resources.ApplyResources(this.ch16outDataGridViewTextBoxColumn, "ch16outDataGridViewTextBoxColumn");
            this.ch16outDataGridViewTextBoxColumn.Name = "ch16outDataGridViewTextBoxColumn";
            // 
            // esc1voltDataGridViewTextBoxColumn
            // 
            this.esc1voltDataGridViewTextBoxColumn.DataPropertyName = "esc1_volt";
            resources.ApplyResources(this.esc1voltDataGridViewTextBoxColumn, "esc1voltDataGridViewTextBoxColumn");
            this.esc1voltDataGridViewTextBoxColumn.Name = "esc1voltDataGridViewTextBoxColumn";
            // 
            // esc1currDataGridViewTextBoxColumn
            // 
            this.esc1currDataGridViewTextBoxColumn.DataPropertyName = "esc1_curr";
            resources.ApplyResources(this.esc1currDataGridViewTextBoxColumn, "esc1currDataGridViewTextBoxColumn");
            this.esc1currDataGridViewTextBoxColumn.Name = "esc1currDataGridViewTextBoxColumn";
            // 
            // esc1rpmDataGridViewTextBoxColumn
            // 
            this.esc1rpmDataGridViewTextBoxColumn.DataPropertyName = "esc1_rpm";
            resources.ApplyResources(this.esc1rpmDataGridViewTextBoxColumn, "esc1rpmDataGridViewTextBoxColumn");
            this.esc1rpmDataGridViewTextBoxColumn.Name = "esc1rpmDataGridViewTextBoxColumn";
            // 
            // esc1tempDataGridViewTextBoxColumn
            // 
            this.esc1tempDataGridViewTextBoxColumn.DataPropertyName = "esc1_temp";
            resources.ApplyResources(this.esc1tempDataGridViewTextBoxColumn, "esc1tempDataGridViewTextBoxColumn");
            this.esc1tempDataGridViewTextBoxColumn.Name = "esc1tempDataGridViewTextBoxColumn";
            // 
            // esc2voltDataGridViewTextBoxColumn
            // 
            this.esc2voltDataGridViewTextBoxColumn.DataPropertyName = "esc2_volt";
            resources.ApplyResources(this.esc2voltDataGridViewTextBoxColumn, "esc2voltDataGridViewTextBoxColumn");
            this.esc2voltDataGridViewTextBoxColumn.Name = "esc2voltDataGridViewTextBoxColumn";
            // 
            // esc2currDataGridViewTextBoxColumn
            // 
            this.esc2currDataGridViewTextBoxColumn.DataPropertyName = "esc2_curr";
            resources.ApplyResources(this.esc2currDataGridViewTextBoxColumn, "esc2currDataGridViewTextBoxColumn");
            this.esc2currDataGridViewTextBoxColumn.Name = "esc2currDataGridViewTextBoxColumn";
            // 
            // esc2rpmDataGridViewTextBoxColumn
            // 
            this.esc2rpmDataGridViewTextBoxColumn.DataPropertyName = "esc2_rpm";
            resources.ApplyResources(this.esc2rpmDataGridViewTextBoxColumn, "esc2rpmDataGridViewTextBoxColumn");
            this.esc2rpmDataGridViewTextBoxColumn.Name = "esc2rpmDataGridViewTextBoxColumn";
            // 
            // esc2tempDataGridViewTextBoxColumn
            // 
            this.esc2tempDataGridViewTextBoxColumn.DataPropertyName = "esc2_temp";
            resources.ApplyResources(this.esc2tempDataGridViewTextBoxColumn, "esc2tempDataGridViewTextBoxColumn");
            this.esc2tempDataGridViewTextBoxColumn.Name = "esc2tempDataGridViewTextBoxColumn";
            // 
            // esc3voltDataGridViewTextBoxColumn
            // 
            this.esc3voltDataGridViewTextBoxColumn.DataPropertyName = "esc3_volt";
            resources.ApplyResources(this.esc3voltDataGridViewTextBoxColumn, "esc3voltDataGridViewTextBoxColumn");
            this.esc3voltDataGridViewTextBoxColumn.Name = "esc3voltDataGridViewTextBoxColumn";
            // 
            // esc3currDataGridViewTextBoxColumn
            // 
            this.esc3currDataGridViewTextBoxColumn.DataPropertyName = "esc3_curr";
            resources.ApplyResources(this.esc3currDataGridViewTextBoxColumn, "esc3currDataGridViewTextBoxColumn");
            this.esc3currDataGridViewTextBoxColumn.Name = "esc3currDataGridViewTextBoxColumn";
            // 
            // esc3rpmDataGridViewTextBoxColumn
            // 
            this.esc3rpmDataGridViewTextBoxColumn.DataPropertyName = "esc3_rpm";
            resources.ApplyResources(this.esc3rpmDataGridViewTextBoxColumn, "esc3rpmDataGridViewTextBoxColumn");
            this.esc3rpmDataGridViewTextBoxColumn.Name = "esc3rpmDataGridViewTextBoxColumn";
            // 
            // esc3tempDataGridViewTextBoxColumn
            // 
            this.esc3tempDataGridViewTextBoxColumn.DataPropertyName = "esc3_temp";
            resources.ApplyResources(this.esc3tempDataGridViewTextBoxColumn, "esc3tempDataGridViewTextBoxColumn");
            this.esc3tempDataGridViewTextBoxColumn.Name = "esc3tempDataGridViewTextBoxColumn";
            // 
            // esc4voltDataGridViewTextBoxColumn
            // 
            this.esc4voltDataGridViewTextBoxColumn.DataPropertyName = "esc4_volt";
            resources.ApplyResources(this.esc4voltDataGridViewTextBoxColumn, "esc4voltDataGridViewTextBoxColumn");
            this.esc4voltDataGridViewTextBoxColumn.Name = "esc4voltDataGridViewTextBoxColumn";
            // 
            // esc4currDataGridViewTextBoxColumn
            // 
            this.esc4currDataGridViewTextBoxColumn.DataPropertyName = "esc4_curr";
            resources.ApplyResources(this.esc4currDataGridViewTextBoxColumn, "esc4currDataGridViewTextBoxColumn");
            this.esc4currDataGridViewTextBoxColumn.Name = "esc4currDataGridViewTextBoxColumn";
            // 
            // esc4rpmDataGridViewTextBoxColumn
            // 
            this.esc4rpmDataGridViewTextBoxColumn.DataPropertyName = "esc4_rpm";
            resources.ApplyResources(this.esc4rpmDataGridViewTextBoxColumn, "esc4rpmDataGridViewTextBoxColumn");
            this.esc4rpmDataGridViewTextBoxColumn.Name = "esc4rpmDataGridViewTextBoxColumn";
            // 
            // esc4tempDataGridViewTextBoxColumn
            // 
            this.esc4tempDataGridViewTextBoxColumn.DataPropertyName = "esc4_temp";
            resources.ApplyResources(this.esc4tempDataGridViewTextBoxColumn, "esc4tempDataGridViewTextBoxColumn");
            this.esc4tempDataGridViewTextBoxColumn.Name = "esc4tempDataGridViewTextBoxColumn";
            // 
            // esc5voltDataGridViewTextBoxColumn
            // 
            this.esc5voltDataGridViewTextBoxColumn.DataPropertyName = "esc5_volt";
            resources.ApplyResources(this.esc5voltDataGridViewTextBoxColumn, "esc5voltDataGridViewTextBoxColumn");
            this.esc5voltDataGridViewTextBoxColumn.Name = "esc5voltDataGridViewTextBoxColumn";
            // 
            // esc5currDataGridViewTextBoxColumn
            // 
            this.esc5currDataGridViewTextBoxColumn.DataPropertyName = "esc5_curr";
            resources.ApplyResources(this.esc5currDataGridViewTextBoxColumn, "esc5currDataGridViewTextBoxColumn");
            this.esc5currDataGridViewTextBoxColumn.Name = "esc5currDataGridViewTextBoxColumn";
            // 
            // esc5rpmDataGridViewTextBoxColumn
            // 
            this.esc5rpmDataGridViewTextBoxColumn.DataPropertyName = "esc5_rpm";
            resources.ApplyResources(this.esc5rpmDataGridViewTextBoxColumn, "esc5rpmDataGridViewTextBoxColumn");
            this.esc5rpmDataGridViewTextBoxColumn.Name = "esc5rpmDataGridViewTextBoxColumn";
            // 
            // esc5tempDataGridViewTextBoxColumn
            // 
            this.esc5tempDataGridViewTextBoxColumn.DataPropertyName = "esc5_temp";
            resources.ApplyResources(this.esc5tempDataGridViewTextBoxColumn, "esc5tempDataGridViewTextBoxColumn");
            this.esc5tempDataGridViewTextBoxColumn.Name = "esc5tempDataGridViewTextBoxColumn";
            // 
            // esc6voltDataGridViewTextBoxColumn
            // 
            this.esc6voltDataGridViewTextBoxColumn.DataPropertyName = "esc6_volt";
            resources.ApplyResources(this.esc6voltDataGridViewTextBoxColumn, "esc6voltDataGridViewTextBoxColumn");
            this.esc6voltDataGridViewTextBoxColumn.Name = "esc6voltDataGridViewTextBoxColumn";
            // 
            // esc6currDataGridViewTextBoxColumn
            // 
            this.esc6currDataGridViewTextBoxColumn.DataPropertyName = "esc6_curr";
            resources.ApplyResources(this.esc6currDataGridViewTextBoxColumn, "esc6currDataGridViewTextBoxColumn");
            this.esc6currDataGridViewTextBoxColumn.Name = "esc6currDataGridViewTextBoxColumn";
            // 
            // esc6rpmDataGridViewTextBoxColumn
            // 
            this.esc6rpmDataGridViewTextBoxColumn.DataPropertyName = "esc6_rpm";
            resources.ApplyResources(this.esc6rpmDataGridViewTextBoxColumn, "esc6rpmDataGridViewTextBoxColumn");
            this.esc6rpmDataGridViewTextBoxColumn.Name = "esc6rpmDataGridViewTextBoxColumn";
            // 
            // esc6tempDataGridViewTextBoxColumn
            // 
            this.esc6tempDataGridViewTextBoxColumn.DataPropertyName = "esc6_temp";
            resources.ApplyResources(this.esc6tempDataGridViewTextBoxColumn, "esc6tempDataGridViewTextBoxColumn");
            this.esc6tempDataGridViewTextBoxColumn.Name = "esc6tempDataGridViewTextBoxColumn";
            // 
            // esc7voltDataGridViewTextBoxColumn
            // 
            this.esc7voltDataGridViewTextBoxColumn.DataPropertyName = "esc7_volt";
            resources.ApplyResources(this.esc7voltDataGridViewTextBoxColumn, "esc7voltDataGridViewTextBoxColumn");
            this.esc7voltDataGridViewTextBoxColumn.Name = "esc7voltDataGridViewTextBoxColumn";
            // 
            // esc7currDataGridViewTextBoxColumn
            // 
            this.esc7currDataGridViewTextBoxColumn.DataPropertyName = "esc7_curr";
            resources.ApplyResources(this.esc7currDataGridViewTextBoxColumn, "esc7currDataGridViewTextBoxColumn");
            this.esc7currDataGridViewTextBoxColumn.Name = "esc7currDataGridViewTextBoxColumn";
            // 
            // esc7rpmDataGridViewTextBoxColumn
            // 
            this.esc7rpmDataGridViewTextBoxColumn.DataPropertyName = "esc7_rpm";
            resources.ApplyResources(this.esc7rpmDataGridViewTextBoxColumn, "esc7rpmDataGridViewTextBoxColumn");
            this.esc7rpmDataGridViewTextBoxColumn.Name = "esc7rpmDataGridViewTextBoxColumn";
            // 
            // esc7tempDataGridViewTextBoxColumn
            // 
            this.esc7tempDataGridViewTextBoxColumn.DataPropertyName = "esc7_temp";
            resources.ApplyResources(this.esc7tempDataGridViewTextBoxColumn, "esc7tempDataGridViewTextBoxColumn");
            this.esc7tempDataGridViewTextBoxColumn.Name = "esc7tempDataGridViewTextBoxColumn";
            // 
            // esc8voltDataGridViewTextBoxColumn
            // 
            this.esc8voltDataGridViewTextBoxColumn.DataPropertyName = "esc8_volt";
            resources.ApplyResources(this.esc8voltDataGridViewTextBoxColumn, "esc8voltDataGridViewTextBoxColumn");
            this.esc8voltDataGridViewTextBoxColumn.Name = "esc8voltDataGridViewTextBoxColumn";
            // 
            // esc8currDataGridViewTextBoxColumn
            // 
            this.esc8currDataGridViewTextBoxColumn.DataPropertyName = "esc8_curr";
            resources.ApplyResources(this.esc8currDataGridViewTextBoxColumn, "esc8currDataGridViewTextBoxColumn");
            this.esc8currDataGridViewTextBoxColumn.Name = "esc8currDataGridViewTextBoxColumn";
            // 
            // esc8rpmDataGridViewTextBoxColumn
            // 
            this.esc8rpmDataGridViewTextBoxColumn.DataPropertyName = "esc8_rpm";
            resources.ApplyResources(this.esc8rpmDataGridViewTextBoxColumn, "esc8rpmDataGridViewTextBoxColumn");
            this.esc8rpmDataGridViewTextBoxColumn.Name = "esc8rpmDataGridViewTextBoxColumn";
            // 
            // esc8tempDataGridViewTextBoxColumn
            // 
            this.esc8tempDataGridViewTextBoxColumn.DataPropertyName = "esc8_temp";
            resources.ApplyResources(this.esc8tempDataGridViewTextBoxColumn, "esc8tempDataGridViewTextBoxColumn");
            this.esc8tempDataGridViewTextBoxColumn.Name = "esc8tempDataGridViewTextBoxColumn";
            // 
            // ch3percentDataGridViewTextBoxColumn
            // 
            this.ch3percentDataGridViewTextBoxColumn.DataPropertyName = "ch3percent";
            resources.ApplyResources(this.ch3percentDataGridViewTextBoxColumn, "ch3percentDataGridViewTextBoxColumn");
            this.ch3percentDataGridViewTextBoxColumn.Name = "ch3percentDataGridViewTextBoxColumn";
            // 
            // failsafeDataGridViewCheckBoxColumn
            // 
            this.failsafeDataGridViewCheckBoxColumn.DataPropertyName = "failsafe";
            resources.ApplyResources(this.failsafeDataGridViewCheckBoxColumn, "failsafeDataGridViewCheckBoxColumn");
            this.failsafeDataGridViewCheckBoxColumn.Name = "failsafeDataGridViewCheckBoxColumn";
            // 
            // rxrssiDataGridViewTextBoxColumn
            // 
            this.rxrssiDataGridViewTextBoxColumn.DataPropertyName = "rxrssi";
            resources.ApplyResources(this.rxrssiDataGridViewTextBoxColumn, "rxrssiDataGridViewTextBoxColumn");
            this.rxrssiDataGridViewTextBoxColumn.Name = "rxrssiDataGridViewTextBoxColumn";
            // 
            // critAOADataGridViewTextBoxColumn
            // 
            this.critAOADataGridViewTextBoxColumn.DataPropertyName = "crit_AOA";
            resources.ApplyResources(this.critAOADataGridViewTextBoxColumn, "critAOADataGridViewTextBoxColumn");
            this.critAOADataGridViewTextBoxColumn.Name = "critAOADataGridViewTextBoxColumn";
            // 
            // lowgroundspeedDataGridViewCheckBoxColumn
            // 
            this.lowgroundspeedDataGridViewCheckBoxColumn.DataPropertyName = "lowgroundspeed";
            resources.ApplyResources(this.lowgroundspeedDataGridViewCheckBoxColumn, "lowgroundspeedDataGridViewCheckBoxColumn");
            this.lowgroundspeedDataGridViewCheckBoxColumn.Name = "lowgroundspeedDataGridViewCheckBoxColumn";
            // 
            // verticalspeedDataGridViewTextBoxColumn
            // 
            this.verticalspeedDataGridViewTextBoxColumn.DataPropertyName = "verticalspeed";
            resources.ApplyResources(this.verticalspeedDataGridViewTextBoxColumn, "verticalspeedDataGridViewTextBoxColumn");
            this.verticalspeedDataGridViewTextBoxColumn.Name = "verticalspeedDataGridViewTextBoxColumn";
            // 
            // verticalspeedfpmDataGridViewTextBoxColumn
            // 
            this.verticalspeedfpmDataGridViewTextBoxColumn.DataPropertyName = "verticalspeed_fpm";
            resources.ApplyResources(this.verticalspeedfpmDataGridViewTextBoxColumn, "verticalspeedfpmDataGridViewTextBoxColumn");
            this.verticalspeedfpmDataGridViewTextBoxColumn.Name = "verticalspeedfpmDataGridViewTextBoxColumn";
            this.verticalspeedfpmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // glideratioDataGridViewTextBoxColumn
            // 
            this.glideratioDataGridViewTextBoxColumn.DataPropertyName = "glide_ratio";
            resources.ApplyResources(this.glideratioDataGridViewTextBoxColumn, "glideratioDataGridViewTextBoxColumn");
            this.glideratioDataGridViewTextBoxColumn.Name = "glideratioDataGridViewTextBoxColumn";
            this.glideratioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // navrollDataGridViewTextBoxColumn
            // 
            this.navrollDataGridViewTextBoxColumn.DataPropertyName = "nav_roll";
            resources.ApplyResources(this.navrollDataGridViewTextBoxColumn, "navrollDataGridViewTextBoxColumn");
            this.navrollDataGridViewTextBoxColumn.Name = "navrollDataGridViewTextBoxColumn";
            // 
            // navpitchDataGridViewTextBoxColumn
            // 
            this.navpitchDataGridViewTextBoxColumn.DataPropertyName = "nav_pitch";
            resources.ApplyResources(this.navpitchDataGridViewTextBoxColumn, "navpitchDataGridViewTextBoxColumn");
            this.navpitchDataGridViewTextBoxColumn.Name = "navpitchDataGridViewTextBoxColumn";
            // 
            // navbearingDataGridViewTextBoxColumn
            // 
            this.navbearingDataGridViewTextBoxColumn.DataPropertyName = "nav_bearing";
            resources.ApplyResources(this.navbearingDataGridViewTextBoxColumn, "navbearingDataGridViewTextBoxColumn");
            this.navbearingDataGridViewTextBoxColumn.Name = "navbearingDataGridViewTextBoxColumn";
            // 
            // targetbearingDataGridViewTextBoxColumn
            // 
            this.targetbearingDataGridViewTextBoxColumn.DataPropertyName = "target_bearing";
            resources.ApplyResources(this.targetbearingDataGridViewTextBoxColumn, "targetbearingDataGridViewTextBoxColumn");
            this.targetbearingDataGridViewTextBoxColumn.Name = "targetbearingDataGridViewTextBoxColumn";
            // 
            // alterrorDataGridViewTextBoxColumn
            // 
            this.alterrorDataGridViewTextBoxColumn.DataPropertyName = "alt_error";
            resources.ApplyResources(this.alterrorDataGridViewTextBoxColumn, "alterrorDataGridViewTextBoxColumn");
            this.alterrorDataGridViewTextBoxColumn.Name = "alterrorDataGridViewTextBoxColumn";
            // 
            // bererrorDataGridViewTextBoxColumn
            // 
            this.bererrorDataGridViewTextBoxColumn.DataPropertyName = "ber_error";
            resources.ApplyResources(this.bererrorDataGridViewTextBoxColumn, "bererrorDataGridViewTextBoxColumn");
            this.bererrorDataGridViewTextBoxColumn.Name = "bererrorDataGridViewTextBoxColumn";
            // 
            // aspderrorDataGridViewTextBoxColumn
            // 
            this.aspderrorDataGridViewTextBoxColumn.DataPropertyName = "aspd_error";
            resources.ApplyResources(this.aspderrorDataGridViewTextBoxColumn, "aspderrorDataGridViewTextBoxColumn");
            this.aspderrorDataGridViewTextBoxColumn.Name = "aspderrorDataGridViewTextBoxColumn";
            // 
            // xtrackerrorDataGridViewTextBoxColumn
            // 
            this.xtrackerrorDataGridViewTextBoxColumn.DataPropertyName = "xtrack_error";
            resources.ApplyResources(this.xtrackerrorDataGridViewTextBoxColumn, "xtrackerrorDataGridViewTextBoxColumn");
            this.xtrackerrorDataGridViewTextBoxColumn.Name = "xtrackerrorDataGridViewTextBoxColumn";
            // 
            // wpnoDataGridViewTextBoxColumn
            // 
            this.wpnoDataGridViewTextBoxColumn.DataPropertyName = "wpno";
            resources.ApplyResources(this.wpnoDataGridViewTextBoxColumn, "wpnoDataGridViewTextBoxColumn");
            this.wpnoDataGridViewTextBoxColumn.Name = "wpnoDataGridViewTextBoxColumn";
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "mode";
            resources.ApplyResources(this.modeDataGridViewTextBoxColumn, "modeDataGridViewTextBoxColumn");
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            // 
            // climbrateDataGridViewTextBoxColumn
            // 
            this.climbrateDataGridViewTextBoxColumn.DataPropertyName = "climbrate";
            resources.ApplyResources(this.climbrateDataGridViewTextBoxColumn, "climbrateDataGridViewTextBoxColumn");
            this.climbrateDataGridViewTextBoxColumn.Name = "climbrateDataGridViewTextBoxColumn";
            // 
            // totDataGridViewTextBoxColumn
            // 
            this.totDataGridViewTextBoxColumn.DataPropertyName = "tot";
            resources.ApplyResources(this.totDataGridViewTextBoxColumn, "totDataGridViewTextBoxColumn");
            this.totDataGridViewTextBoxColumn.Name = "totDataGridViewTextBoxColumn";
            this.totDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tohDataGridViewTextBoxColumn
            // 
            this.tohDataGridViewTextBoxColumn.DataPropertyName = "toh";
            resources.ApplyResources(this.tohDataGridViewTextBoxColumn, "tohDataGridViewTextBoxColumn");
            this.tohDataGridViewTextBoxColumn.Name = "tohDataGridViewTextBoxColumn";
            this.tohDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distTraveledDataGridViewTextBoxColumn
            // 
            this.distTraveledDataGridViewTextBoxColumn.DataPropertyName = "distTraveled";
            resources.ApplyResources(this.distTraveledDataGridViewTextBoxColumn, "distTraveledDataGridViewTextBoxColumn");
            this.distTraveledDataGridViewTextBoxColumn.Name = "distTraveledDataGridViewTextBoxColumn";
            // 
            // timeSinceArmInAirDataGridViewTextBoxColumn
            // 
            this.timeSinceArmInAirDataGridViewTextBoxColumn.DataPropertyName = "timeSinceArmInAir";
            resources.ApplyResources(this.timeSinceArmInAirDataGridViewTextBoxColumn, "timeSinceArmInAirDataGridViewTextBoxColumn");
            this.timeSinceArmInAirDataGridViewTextBoxColumn.Name = "timeSinceArmInAirDataGridViewTextBoxColumn";
            // 
            // timeInAirDataGridViewTextBoxColumn
            // 
            this.timeInAirDataGridViewTextBoxColumn.DataPropertyName = "timeInAir";
            resources.ApplyResources(this.timeInAirDataGridViewTextBoxColumn, "timeInAirDataGridViewTextBoxColumn");
            this.timeInAirDataGridViewTextBoxColumn.Name = "timeInAirDataGridViewTextBoxColumn";
            // 
            // timeInAirMinSecDataGridViewTextBoxColumn
            // 
            this.timeInAirMinSecDataGridViewTextBoxColumn.DataPropertyName = "timeInAirMinSec";
            resources.ApplyResources(this.timeInAirMinSecDataGridViewTextBoxColumn, "timeInAirMinSecDataGridViewTextBoxColumn");
            this.timeInAirMinSecDataGridViewTextBoxColumn.Name = "timeInAirMinSecDataGridViewTextBoxColumn";
            this.timeInAirMinSecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnrateDataGridViewTextBoxColumn
            // 
            this.turnrateDataGridViewTextBoxColumn.DataPropertyName = "turnrate";
            resources.ApplyResources(this.turnrateDataGridViewTextBoxColumn, "turnrateDataGridViewTextBoxColumn");
            this.turnrateDataGridViewTextBoxColumn.Name = "turnrateDataGridViewTextBoxColumn";
            this.turnrateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turngDataGridViewTextBoxColumn
            // 
            this.turngDataGridViewTextBoxColumn.DataPropertyName = "turng";
            resources.ApplyResources(this.turngDataGridViewTextBoxColumn, "turngDataGridViewTextBoxColumn");
            this.turngDataGridViewTextBoxColumn.Name = "turngDataGridViewTextBoxColumn";
            this.turngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radiusDataGridViewTextBoxColumn
            // 
            this.radiusDataGridViewTextBoxColumn.DataPropertyName = "radius";
            resources.ApplyResources(this.radiusDataGridViewTextBoxColumn, "radiusDataGridViewTextBoxColumn");
            this.radiusDataGridViewTextBoxColumn.Name = "radiusDataGridViewTextBoxColumn";
            this.radiusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qNHDataGridViewTextBoxColumn
            // 
            this.qNHDataGridViewTextBoxColumn.DataPropertyName = "QNH";
            resources.ApplyResources(this.qNHDataGridViewTextBoxColumn, "qNHDataGridViewTextBoxColumn");
            this.qNHDataGridViewTextBoxColumn.Name = "qNHDataGridViewTextBoxColumn";
            this.qNHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // winddirDataGridViewTextBoxColumn
            // 
            this.winddirDataGridViewTextBoxColumn.DataPropertyName = "wind_dir";
            resources.ApplyResources(this.winddirDataGridViewTextBoxColumn, "winddirDataGridViewTextBoxColumn");
            this.winddirDataGridViewTextBoxColumn.Name = "winddirDataGridViewTextBoxColumn";
            // 
            // windvelDataGridViewTextBoxColumn
            // 
            this.windvelDataGridViewTextBoxColumn.DataPropertyName = "wind_vel";
            resources.ApplyResources(this.windvelDataGridViewTextBoxColumn, "windvelDataGridViewTextBoxColumn");
            this.windvelDataGridViewTextBoxColumn.Name = "windvelDataGridViewTextBoxColumn";
            // 
            // targetaltd100DataGridViewTextBoxColumn
            // 
            this.targetaltd100DataGridViewTextBoxColumn.DataPropertyName = "targetaltd100";
            resources.ApplyResources(this.targetaltd100DataGridViewTextBoxColumn, "targetaltd100DataGridViewTextBoxColumn");
            this.targetaltd100DataGridViewTextBoxColumn.Name = "targetaltd100DataGridViewTextBoxColumn";
            this.targetaltd100DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // targetaltDataGridViewTextBoxColumn
            // 
            this.targetaltDataGridViewTextBoxColumn.DataPropertyName = "targetalt";
            resources.ApplyResources(this.targetaltDataGridViewTextBoxColumn, "targetaltDataGridViewTextBoxColumn");
            this.targetaltDataGridViewTextBoxColumn.Name = "targetaltDataGridViewTextBoxColumn";
            this.targetaltDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "message";
            resources.ApplyResources(this.messageDataGridViewTextBoxColumn, "messageDataGridViewTextBoxColumn");
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageHighDataGridViewTextBoxColumn
            // 
            this.messageHighDataGridViewTextBoxColumn.DataPropertyName = "messageHigh";
            resources.ApplyResources(this.messageHighDataGridViewTextBoxColumn, "messageHighDataGridViewTextBoxColumn");
            this.messageHighDataGridViewTextBoxColumn.Name = "messageHighDataGridViewTextBoxColumn";
            // 
            // messageHighTimeDataGridViewTextBoxColumn
            // 
            this.messageHighTimeDataGridViewTextBoxColumn.DataPropertyName = "messageHighTime";
            resources.ApplyResources(this.messageHighTimeDataGridViewTextBoxColumn, "messageHighTimeDataGridViewTextBoxColumn");
            this.messageHighTimeDataGridViewTextBoxColumn.Name = "messageHighTimeDataGridViewTextBoxColumn";
            // 
            // batteryvoltageDataGridViewTextBoxColumn
            // 
            this.batteryvoltageDataGridViewTextBoxColumn.DataPropertyName = "battery_voltage";
            resources.ApplyResources(this.batteryvoltageDataGridViewTextBoxColumn, "batteryvoltageDataGridViewTextBoxColumn");
            this.batteryvoltageDataGridViewTextBoxColumn.Name = "batteryvoltageDataGridViewTextBoxColumn";
            // 
            // batteryvoltage3DataGridViewTextBoxColumn
            // 
            this.batteryvoltage3DataGridViewTextBoxColumn.DataPropertyName = "battery_voltage3";
            resources.ApplyResources(this.batteryvoltage3DataGridViewTextBoxColumn, "batteryvoltage3DataGridViewTextBoxColumn");
            this.batteryvoltage3DataGridViewTextBoxColumn.Name = "batteryvoltage3DataGridViewTextBoxColumn";
            // 
            // batteryvoltage4DataGridViewTextBoxColumn
            // 
            this.batteryvoltage4DataGridViewTextBoxColumn.DataPropertyName = "battery_voltage4";
            resources.ApplyResources(this.batteryvoltage4DataGridViewTextBoxColumn, "batteryvoltage4DataGridViewTextBoxColumn");
            this.batteryvoltage4DataGridViewTextBoxColumn.Name = "batteryvoltage4DataGridViewTextBoxColumn";
            // 
            // batteryvoltage5DataGridViewTextBoxColumn
            // 
            this.batteryvoltage5DataGridViewTextBoxColumn.DataPropertyName = "battery_voltage5";
            resources.ApplyResources(this.batteryvoltage5DataGridViewTextBoxColumn, "batteryvoltage5DataGridViewTextBoxColumn");
            this.batteryvoltage5DataGridViewTextBoxColumn.Name = "batteryvoltage5DataGridViewTextBoxColumn";
            // 
            // batteryvoltage6DataGridViewTextBoxColumn
            // 
            this.batteryvoltage6DataGridViewTextBoxColumn.DataPropertyName = "battery_voltage6";
            resources.ApplyResources(this.batteryvoltage6DataGridViewTextBoxColumn, "batteryvoltage6DataGridViewTextBoxColumn");
            this.batteryvoltage6DataGridViewTextBoxColumn.Name = "batteryvoltage6DataGridViewTextBoxColumn";
            // 
            // batteryvoltage7DataGridViewTextBoxColumn
            // 
            this.batteryvoltage7DataGridViewTextBoxColumn.DataPropertyName = "battery_voltage7";
            resources.ApplyResources(this.batteryvoltage7DataGridViewTextBoxColumn, "batteryvoltage7DataGridViewTextBoxColumn");
            this.batteryvoltage7DataGridViewTextBoxColumn.Name = "batteryvoltage7DataGridViewTextBoxColumn";
            // 
            // batteryvoltage8DataGridViewTextBoxColumn
            // 
            this.batteryvoltage8DataGridViewTextBoxColumn.DataPropertyName = "battery_voltage8";
            resources.ApplyResources(this.batteryvoltage8DataGridViewTextBoxColumn, "batteryvoltage8DataGridViewTextBoxColumn");
            this.batteryvoltage8DataGridViewTextBoxColumn.Name = "batteryvoltage8DataGridViewTextBoxColumn";
            // 
            // batteryremainingDataGridViewTextBoxColumn
            // 
            this.batteryremainingDataGridViewTextBoxColumn.DataPropertyName = "battery_remaining";
            resources.ApplyResources(this.batteryremainingDataGridViewTextBoxColumn, "batteryremainingDataGridViewTextBoxColumn");
            this.batteryremainingDataGridViewTextBoxColumn.Name = "batteryremainingDataGridViewTextBoxColumn";
            // 
            // batteryremaining2DataGridViewTextBoxColumn
            // 
            this.batteryremaining2DataGridViewTextBoxColumn.DataPropertyName = "battery_remaining2";
            resources.ApplyResources(this.batteryremaining2DataGridViewTextBoxColumn, "batteryremaining2DataGridViewTextBoxColumn");
            this.batteryremaining2DataGridViewTextBoxColumn.Name = "batteryremaining2DataGridViewTextBoxColumn";
            // 
            // batteryremaining3DataGridViewTextBoxColumn
            // 
            this.batteryremaining3DataGridViewTextBoxColumn.DataPropertyName = "battery_remaining3";
            resources.ApplyResources(this.batteryremaining3DataGridViewTextBoxColumn, "batteryremaining3DataGridViewTextBoxColumn");
            this.batteryremaining3DataGridViewTextBoxColumn.Name = "batteryremaining3DataGridViewTextBoxColumn";
            // 
            // batteryremaining4DataGridViewTextBoxColumn
            // 
            this.batteryremaining4DataGridViewTextBoxColumn.DataPropertyName = "battery_remaining4";
            resources.ApplyResources(this.batteryremaining4DataGridViewTextBoxColumn, "batteryremaining4DataGridViewTextBoxColumn");
            this.batteryremaining4DataGridViewTextBoxColumn.Name = "batteryremaining4DataGridViewTextBoxColumn";
            // 
            // batteryremaining5DataGridViewTextBoxColumn
            // 
            this.batteryremaining5DataGridViewTextBoxColumn.DataPropertyName = "battery_remaining5";
            resources.ApplyResources(this.batteryremaining5DataGridViewTextBoxColumn, "batteryremaining5DataGridViewTextBoxColumn");
            this.batteryremaining5DataGridViewTextBoxColumn.Name = "batteryremaining5DataGridViewTextBoxColumn";
            // 
            // batteryremaining6DataGridViewTextBoxColumn
            // 
            this.batteryremaining6DataGridViewTextBoxColumn.DataPropertyName = "battery_remaining6";
            resources.ApplyResources(this.batteryremaining6DataGridViewTextBoxColumn, "batteryremaining6DataGridViewTextBoxColumn");
            this.batteryremaining6DataGridViewTextBoxColumn.Name = "batteryremaining6DataGridViewTextBoxColumn";
            // 
            // batteryremaining7DataGridViewTextBoxColumn
            // 
            this.batteryremaining7DataGridViewTextBoxColumn.DataPropertyName = "battery_remaining7";
            resources.ApplyResources(this.batteryremaining7DataGridViewTextBoxColumn, "batteryremaining7DataGridViewTextBoxColumn");
            this.batteryremaining7DataGridViewTextBoxColumn.Name = "batteryremaining7DataGridViewTextBoxColumn";
            // 
            // batteryremaining8DataGridViewTextBoxColumn
            // 
            this.batteryremaining8DataGridViewTextBoxColumn.DataPropertyName = "battery_remaining8";
            resources.ApplyResources(this.batteryremaining8DataGridViewTextBoxColumn, "batteryremaining8DataGridViewTextBoxColumn");
            this.batteryremaining8DataGridViewTextBoxColumn.Name = "batteryremaining8DataGridViewTextBoxColumn";
            // 
            // currentDataGridViewTextBoxColumn
            // 
            this.currentDataGridViewTextBoxColumn.DataPropertyName = "current";
            resources.ApplyResources(this.currentDataGridViewTextBoxColumn, "currentDataGridViewTextBoxColumn");
            this.currentDataGridViewTextBoxColumn.Name = "currentDataGridViewTextBoxColumn";
            // 
            // current2DataGridViewTextBoxColumn
            // 
            this.current2DataGridViewTextBoxColumn.DataPropertyName = "current2";
            resources.ApplyResources(this.current2DataGridViewTextBoxColumn, "current2DataGridViewTextBoxColumn");
            this.current2DataGridViewTextBoxColumn.Name = "current2DataGridViewTextBoxColumn";
            // 
            // current3DataGridViewTextBoxColumn
            // 
            this.current3DataGridViewTextBoxColumn.DataPropertyName = "current3";
            resources.ApplyResources(this.current3DataGridViewTextBoxColumn, "current3DataGridViewTextBoxColumn");
            this.current3DataGridViewTextBoxColumn.Name = "current3DataGridViewTextBoxColumn";
            // 
            // current4DataGridViewTextBoxColumn
            // 
            this.current4DataGridViewTextBoxColumn.DataPropertyName = "current4";
            resources.ApplyResources(this.current4DataGridViewTextBoxColumn, "current4DataGridViewTextBoxColumn");
            this.current4DataGridViewTextBoxColumn.Name = "current4DataGridViewTextBoxColumn";
            // 
            // current5DataGridViewTextBoxColumn
            // 
            this.current5DataGridViewTextBoxColumn.DataPropertyName = "current5";
            resources.ApplyResources(this.current5DataGridViewTextBoxColumn, "current5DataGridViewTextBoxColumn");
            this.current5DataGridViewTextBoxColumn.Name = "current5DataGridViewTextBoxColumn";
            // 
            // current6DataGridViewTextBoxColumn
            // 
            this.current6DataGridViewTextBoxColumn.DataPropertyName = "current6";
            resources.ApplyResources(this.current6DataGridViewTextBoxColumn, "current6DataGridViewTextBoxColumn");
            this.current6DataGridViewTextBoxColumn.Name = "current6DataGridViewTextBoxColumn";
            // 
            // current7DataGridViewTextBoxColumn
            // 
            this.current7DataGridViewTextBoxColumn.DataPropertyName = "current7";
            resources.ApplyResources(this.current7DataGridViewTextBoxColumn, "current7DataGridViewTextBoxColumn");
            this.current7DataGridViewTextBoxColumn.Name = "current7DataGridViewTextBoxColumn";
            // 
            // current8DataGridViewTextBoxColumn
            // 
            this.current8DataGridViewTextBoxColumn.DataPropertyName = "current8";
            resources.ApplyResources(this.current8DataGridViewTextBoxColumn, "current8DataGridViewTextBoxColumn");
            this.current8DataGridViewTextBoxColumn.Name = "current8DataGridViewTextBoxColumn";
            // 
            // wattsDataGridViewTextBoxColumn
            // 
            this.wattsDataGridViewTextBoxColumn.DataPropertyName = "watts";
            resources.ApplyResources(this.wattsDataGridViewTextBoxColumn, "wattsDataGridViewTextBoxColumn");
            this.wattsDataGridViewTextBoxColumn.Name = "wattsDataGridViewTextBoxColumn";
            this.wattsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batterymahperkmDataGridViewTextBoxColumn
            // 
            this.batterymahperkmDataGridViewTextBoxColumn.DataPropertyName = "battery_mahperkm";
            resources.ApplyResources(this.batterymahperkmDataGridViewTextBoxColumn, "batterymahperkmDataGridViewTextBoxColumn");
            this.batterymahperkmDataGridViewTextBoxColumn.Name = "batterymahperkmDataGridViewTextBoxColumn";
            this.batterymahperkmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batterykmleftDataGridViewTextBoxColumn
            // 
            this.batterykmleftDataGridViewTextBoxColumn.DataPropertyName = "battery_kmleft";
            resources.ApplyResources(this.batterykmleftDataGridViewTextBoxColumn, "batterykmleftDataGridViewTextBoxColumn");
            this.batterykmleftDataGridViewTextBoxColumn.Name = "batterykmleftDataGridViewTextBoxColumn";
            this.batterykmleftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batteryusedmahDataGridViewTextBoxColumn
            // 
            this.batteryusedmahDataGridViewTextBoxColumn.DataPropertyName = "battery_usedmah";
            resources.ApplyResources(this.batteryusedmahDataGridViewTextBoxColumn, "batteryusedmahDataGridViewTextBoxColumn");
            this.batteryusedmahDataGridViewTextBoxColumn.Name = "batteryusedmahDataGridViewTextBoxColumn";
            // 
            // batterycell1DataGridViewTextBoxColumn
            // 
            this.batterycell1DataGridViewTextBoxColumn.DataPropertyName = "battery_cell1";
            resources.ApplyResources(this.batterycell1DataGridViewTextBoxColumn, "batterycell1DataGridViewTextBoxColumn");
            this.batterycell1DataGridViewTextBoxColumn.Name = "batterycell1DataGridViewTextBoxColumn";
            // 
            // batterycell2DataGridViewTextBoxColumn
            // 
            this.batterycell2DataGridViewTextBoxColumn.DataPropertyName = "battery_cell2";
            resources.ApplyResources(this.batterycell2DataGridViewTextBoxColumn, "batterycell2DataGridViewTextBoxColumn");
            this.batterycell2DataGridViewTextBoxColumn.Name = "batterycell2DataGridViewTextBoxColumn";
            // 
            // batterycell3DataGridViewTextBoxColumn
            // 
            this.batterycell3DataGridViewTextBoxColumn.DataPropertyName = "battery_cell3";
            resources.ApplyResources(this.batterycell3DataGridViewTextBoxColumn, "batterycell3DataGridViewTextBoxColumn");
            this.batterycell3DataGridViewTextBoxColumn.Name = "batterycell3DataGridViewTextBoxColumn";
            // 
            // batterycell4DataGridViewTextBoxColumn
            // 
            this.batterycell4DataGridViewTextBoxColumn.DataPropertyName = "battery_cell4";
            resources.ApplyResources(this.batterycell4DataGridViewTextBoxColumn, "batterycell4DataGridViewTextBoxColumn");
            this.batterycell4DataGridViewTextBoxColumn.Name = "batterycell4DataGridViewTextBoxColumn";
            // 
            // batterycell5DataGridViewTextBoxColumn
            // 
            this.batterycell5DataGridViewTextBoxColumn.DataPropertyName = "battery_cell5";
            resources.ApplyResources(this.batterycell5DataGridViewTextBoxColumn, "batterycell5DataGridViewTextBoxColumn");
            this.batterycell5DataGridViewTextBoxColumn.Name = "batterycell5DataGridViewTextBoxColumn";
            // 
            // batterycell6DataGridViewTextBoxColumn
            // 
            this.batterycell6DataGridViewTextBoxColumn.DataPropertyName = "battery_cell6";
            resources.ApplyResources(this.batterycell6DataGridViewTextBoxColumn, "batterycell6DataGridViewTextBoxColumn");
            this.batterycell6DataGridViewTextBoxColumn.Name = "batterycell6DataGridViewTextBoxColumn";
            // 
            // batterytempDataGridViewTextBoxColumn
            // 
            this.batterytempDataGridViewTextBoxColumn.DataPropertyName = "battery_temp";
            resources.ApplyResources(this.batterytempDataGridViewTextBoxColumn, "batterytempDataGridViewTextBoxColumn");
            this.batterytempDataGridViewTextBoxColumn.Name = "batterytempDataGridViewTextBoxColumn";
            // 
            // batteryusedmah2DataGridViewTextBoxColumn
            // 
            this.batteryusedmah2DataGridViewTextBoxColumn.DataPropertyName = "battery_usedmah2";
            resources.ApplyResources(this.batteryusedmah2DataGridViewTextBoxColumn, "batteryusedmah2DataGridViewTextBoxColumn");
            this.batteryusedmah2DataGridViewTextBoxColumn.Name = "batteryusedmah2DataGridViewTextBoxColumn";
            // 
            // batteryusedmah3DataGridViewTextBoxColumn
            // 
            this.batteryusedmah3DataGridViewTextBoxColumn.DataPropertyName = "battery_usedmah3";
            resources.ApplyResources(this.batteryusedmah3DataGridViewTextBoxColumn, "batteryusedmah3DataGridViewTextBoxColumn");
            this.batteryusedmah3DataGridViewTextBoxColumn.Name = "batteryusedmah3DataGridViewTextBoxColumn";
            // 
            // batteryusedmah4DataGridViewTextBoxColumn
            // 
            this.batteryusedmah4DataGridViewTextBoxColumn.DataPropertyName = "battery_usedmah4";
            resources.ApplyResources(this.batteryusedmah4DataGridViewTextBoxColumn, "batteryusedmah4DataGridViewTextBoxColumn");
            this.batteryusedmah4DataGridViewTextBoxColumn.Name = "batteryusedmah4DataGridViewTextBoxColumn";
            // 
            // batteryusedmah5DataGridViewTextBoxColumn
            // 
            this.batteryusedmah5DataGridViewTextBoxColumn.DataPropertyName = "battery_usedmah5";
            resources.ApplyResources(this.batteryusedmah5DataGridViewTextBoxColumn, "batteryusedmah5DataGridViewTextBoxColumn");
            this.batteryusedmah5DataGridViewTextBoxColumn.Name = "batteryusedmah5DataGridViewTextBoxColumn";
            // 
            // batteryusedmah6DataGridViewTextBoxColumn
            // 
            this.batteryusedmah6DataGridViewTextBoxColumn.DataPropertyName = "battery_usedmah6";
            resources.ApplyResources(this.batteryusedmah6DataGridViewTextBoxColumn, "batteryusedmah6DataGridViewTextBoxColumn");
            this.batteryusedmah6DataGridViewTextBoxColumn.Name = "batteryusedmah6DataGridViewTextBoxColumn";
            // 
            // batteryusedmah7DataGridViewTextBoxColumn
            // 
            this.batteryusedmah7DataGridViewTextBoxColumn.DataPropertyName = "battery_usedmah7";
            resources.ApplyResources(this.batteryusedmah7DataGridViewTextBoxColumn, "batteryusedmah7DataGridViewTextBoxColumn");
            this.batteryusedmah7DataGridViewTextBoxColumn.Name = "batteryusedmah7DataGridViewTextBoxColumn";
            // 
            // batteryusedmah8DataGridViewTextBoxColumn
            // 
            this.batteryusedmah8DataGridViewTextBoxColumn.DataPropertyName = "battery_usedmah8";
            resources.ApplyResources(this.batteryusedmah8DataGridViewTextBoxColumn, "batteryusedmah8DataGridViewTextBoxColumn");
            this.batteryusedmah8DataGridViewTextBoxColumn.Name = "batteryusedmah8DataGridViewTextBoxColumn";
            // 
            // batteryvoltage2DataGridViewTextBoxColumn
            // 
            this.batteryvoltage2DataGridViewTextBoxColumn.DataPropertyName = "battery_voltage2";
            resources.ApplyResources(this.batteryvoltage2DataGridViewTextBoxColumn, "batteryvoltage2DataGridViewTextBoxColumn");
            this.batteryvoltage2DataGridViewTextBoxColumn.Name = "batteryvoltage2DataGridViewTextBoxColumn";
            // 
            // homeAltDataGridViewTextBoxColumn
            // 
            this.homeAltDataGridViewTextBoxColumn.DataPropertyName = "HomeAlt";
            resources.ApplyResources(this.homeAltDataGridViewTextBoxColumn, "homeAltDataGridViewTextBoxColumn");
            this.homeAltDataGridViewTextBoxColumn.Name = "homeAltDataGridViewTextBoxColumn";
            // 
            // homeLocationDataGridViewTextBoxColumn
            // 
            this.homeLocationDataGridViewTextBoxColumn.DataPropertyName = "HomeLocation";
            resources.ApplyResources(this.homeLocationDataGridViewTextBoxColumn, "homeLocationDataGridViewTextBoxColumn");
            this.homeLocationDataGridViewTextBoxColumn.Name = "homeLocationDataGridViewTextBoxColumn";
            // 
            // movingBaseDataGridViewTextBoxColumn
            // 
            this.movingBaseDataGridViewTextBoxColumn.DataPropertyName = "MovingBase";
            resources.ApplyResources(this.movingBaseDataGridViewTextBoxColumn, "movingBaseDataGridViewTextBoxColumn");
            this.movingBaseDataGridViewTextBoxColumn.Name = "movingBaseDataGridViewTextBoxColumn";
            // 
            // trackerLocationDataGridViewTextBoxColumn
            // 
            this.trackerLocationDataGridViewTextBoxColumn.DataPropertyName = "TrackerLocation";
            resources.ApplyResources(this.trackerLocationDataGridViewTextBoxColumn, "trackerLocationDataGridViewTextBoxColumn");
            this.trackerLocationDataGridViewTextBoxColumn.Name = "trackerLocationDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            resources.ApplyResources(this.locationDataGridViewTextBoxColumn, "locationDataGridViewTextBoxColumn");
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // targetLocationDataGridViewTextBoxColumn
            // 
            this.targetLocationDataGridViewTextBoxColumn.DataPropertyName = "TargetLocation";
            resources.ApplyResources(this.targetLocationDataGridViewTextBoxColumn, "targetLocationDataGridViewTextBoxColumn");
            this.targetLocationDataGridViewTextBoxColumn.Name = "targetLocationDataGridViewTextBoxColumn";
            // 
            // distFromMovingBaseDataGridViewTextBoxColumn
            // 
            this.distFromMovingBaseDataGridViewTextBoxColumn.DataPropertyName = "DistFromMovingBase";
            resources.ApplyResources(this.distFromMovingBaseDataGridViewTextBoxColumn, "distFromMovingBaseDataGridViewTextBoxColumn");
            this.distFromMovingBaseDataGridViewTextBoxColumn.Name = "distFromMovingBaseDataGridViewTextBoxColumn";
            this.distFromMovingBaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eLToMAVDataGridViewTextBoxColumn
            // 
            this.eLToMAVDataGridViewTextBoxColumn.DataPropertyName = "ELToMAV";
            resources.ApplyResources(this.eLToMAVDataGridViewTextBoxColumn, "eLToMAVDataGridViewTextBoxColumn");
            this.eLToMAVDataGridViewTextBoxColumn.Name = "eLToMAVDataGridViewTextBoxColumn";
            this.eLToMAVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aZToMAVDataGridViewTextBoxColumn
            // 
            this.aZToMAVDataGridViewTextBoxColumn.DataPropertyName = "AZToMAV";
            resources.ApplyResources(this.aZToMAVDataGridViewTextBoxColumn, "aZToMAVDataGridViewTextBoxColumn");
            this.aZToMAVDataGridViewTextBoxColumn.Name = "aZToMAVDataGridViewTextBoxColumn";
            this.aZToMAVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sonarrangeDataGridViewTextBoxColumn
            // 
            this.sonarrangeDataGridViewTextBoxColumn.DataPropertyName = "sonarrange";
            resources.ApplyResources(this.sonarrangeDataGridViewTextBoxColumn, "sonarrangeDataGridViewTextBoxColumn");
            this.sonarrangeDataGridViewTextBoxColumn.Name = "sonarrangeDataGridViewTextBoxColumn";
            // 
            // sonarvoltageDataGridViewTextBoxColumn
            // 
            this.sonarvoltageDataGridViewTextBoxColumn.DataPropertyName = "sonarvoltage";
            resources.ApplyResources(this.sonarvoltageDataGridViewTextBoxColumn, "sonarvoltageDataGridViewTextBoxColumn");
            this.sonarvoltageDataGridViewTextBoxColumn.Name = "sonarvoltageDataGridViewTextBoxColumn";
            // 
            // rangefinder2DataGridViewTextBoxColumn
            // 
            this.rangefinder2DataGridViewTextBoxColumn.DataPropertyName = "rangefinder2";
            resources.ApplyResources(this.rangefinder2DataGridViewTextBoxColumn, "rangefinder2DataGridViewTextBoxColumn");
            this.rangefinder2DataGridViewTextBoxColumn.Name = "rangefinder2DataGridViewTextBoxColumn";
            // 
            // rangefinder3DataGridViewTextBoxColumn
            // 
            this.rangefinder3DataGridViewTextBoxColumn.DataPropertyName = "rangefinder3";
            resources.ApplyResources(this.rangefinder3DataGridViewTextBoxColumn, "rangefinder3DataGridViewTextBoxColumn");
            this.rangefinder3DataGridViewTextBoxColumn.Name = "rangefinder3DataGridViewTextBoxColumn";
            // 
            // freememDataGridViewTextBoxColumn
            // 
            this.freememDataGridViewTextBoxColumn.DataPropertyName = "freemem";
            resources.ApplyResources(this.freememDataGridViewTextBoxColumn, "freememDataGridViewTextBoxColumn");
            this.freememDataGridViewTextBoxColumn.Name = "freememDataGridViewTextBoxColumn";
            // 
            // loadDataGridViewTextBoxColumn
            // 
            this.loadDataGridViewTextBoxColumn.DataPropertyName = "load";
            resources.ApplyResources(this.loadDataGridViewTextBoxColumn, "loadDataGridViewTextBoxColumn");
            this.loadDataGridViewTextBoxColumn.Name = "loadDataGridViewTextBoxColumn";
            // 
            // brklevelDataGridViewTextBoxColumn
            // 
            this.brklevelDataGridViewTextBoxColumn.DataPropertyName = "brklevel";
            resources.ApplyResources(this.brklevelDataGridViewTextBoxColumn, "brklevelDataGridViewTextBoxColumn");
            this.brklevelDataGridViewTextBoxColumn.Name = "brklevelDataGridViewTextBoxColumn";
            // 
            // armedDataGridViewCheckBoxColumn
            // 
            this.armedDataGridViewCheckBoxColumn.DataPropertyName = "armed";
            resources.ApplyResources(this.armedDataGridViewCheckBoxColumn, "armedDataGridViewCheckBoxColumn");
            this.armedDataGridViewCheckBoxColumn.Name = "armedDataGridViewCheckBoxColumn";
            // 
            // rssiDataGridViewTextBoxColumn
            // 
            this.rssiDataGridViewTextBoxColumn.DataPropertyName = "rssi";
            resources.ApplyResources(this.rssiDataGridViewTextBoxColumn, "rssiDataGridViewTextBoxColumn");
            this.rssiDataGridViewTextBoxColumn.Name = "rssiDataGridViewTextBoxColumn";
            // 
            // remrssiDataGridViewTextBoxColumn
            // 
            this.remrssiDataGridViewTextBoxColumn.DataPropertyName = "remrssi";
            resources.ApplyResources(this.remrssiDataGridViewTextBoxColumn, "remrssiDataGridViewTextBoxColumn");
            this.remrssiDataGridViewTextBoxColumn.Name = "remrssiDataGridViewTextBoxColumn";
            // 
            // txbufferDataGridViewTextBoxColumn
            // 
            this.txbufferDataGridViewTextBoxColumn.DataPropertyName = "txbuffer";
            resources.ApplyResources(this.txbufferDataGridViewTextBoxColumn, "txbufferDataGridViewTextBoxColumn");
            this.txbufferDataGridViewTextBoxColumn.Name = "txbufferDataGridViewTextBoxColumn";
            // 
            // noiseDataGridViewTextBoxColumn
            // 
            this.noiseDataGridViewTextBoxColumn.DataPropertyName = "noise";
            resources.ApplyResources(this.noiseDataGridViewTextBoxColumn, "noiseDataGridViewTextBoxColumn");
            this.noiseDataGridViewTextBoxColumn.Name = "noiseDataGridViewTextBoxColumn";
            // 
            // remnoiseDataGridViewTextBoxColumn
            // 
            this.remnoiseDataGridViewTextBoxColumn.DataPropertyName = "remnoise";
            resources.ApplyResources(this.remnoiseDataGridViewTextBoxColumn, "remnoiseDataGridViewTextBoxColumn");
            this.remnoiseDataGridViewTextBoxColumn.Name = "remnoiseDataGridViewTextBoxColumn";
            // 
            // rxerrorsDataGridViewTextBoxColumn
            // 
            this.rxerrorsDataGridViewTextBoxColumn.DataPropertyName = "rxerrors";
            resources.ApplyResources(this.rxerrorsDataGridViewTextBoxColumn, "rxerrorsDataGridViewTextBoxColumn");
            this.rxerrorsDataGridViewTextBoxColumn.Name = "rxerrorsDataGridViewTextBoxColumn";
            // 
            // fixedpDataGridViewTextBoxColumn
            // 
            this.fixedpDataGridViewTextBoxColumn.DataPropertyName = "fixedp";
            resources.ApplyResources(this.fixedpDataGridViewTextBoxColumn, "fixedpDataGridViewTextBoxColumn");
            this.fixedpDataGridViewTextBoxColumn.Name = "fixedpDataGridViewTextBoxColumn";
            // 
            // localsnrdbDataGridViewTextBoxColumn
            // 
            this.localsnrdbDataGridViewTextBoxColumn.DataPropertyName = "localsnrdb";
            resources.ApplyResources(this.localsnrdbDataGridViewTextBoxColumn, "localsnrdbDataGridViewTextBoxColumn");
            this.localsnrdbDataGridViewTextBoxColumn.Name = "localsnrdbDataGridViewTextBoxColumn";
            this.localsnrdbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remotesnrdbDataGridViewTextBoxColumn
            // 
            this.remotesnrdbDataGridViewTextBoxColumn.DataPropertyName = "remotesnrdb";
            resources.ApplyResources(this.remotesnrdbDataGridViewTextBoxColumn, "remotesnrdbDataGridViewTextBoxColumn");
            this.remotesnrdbDataGridViewTextBoxColumn.Name = "remotesnrdbDataGridViewTextBoxColumn";
            this.remotesnrdbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distRSSIRemainDataGridViewTextBoxColumn
            // 
            this.distRSSIRemainDataGridViewTextBoxColumn.DataPropertyName = "DistRSSIRemain";
            resources.ApplyResources(this.distRSSIRemainDataGridViewTextBoxColumn, "distRSSIRemainDataGridViewTextBoxColumn");
            this.distRSSIRemainDataGridViewTextBoxColumn.Name = "distRSSIRemainDataGridViewTextBoxColumn";
            this.distRSSIRemainDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packetdropremoteDataGridViewTextBoxColumn
            // 
            this.packetdropremoteDataGridViewTextBoxColumn.DataPropertyName = "packetdropremote";
            resources.ApplyResources(this.packetdropremoteDataGridViewTextBoxColumn, "packetdropremoteDataGridViewTextBoxColumn");
            this.packetdropremoteDataGridViewTextBoxColumn.Name = "packetdropremoteDataGridViewTextBoxColumn";
            // 
            // linkqualitygcsDataGridViewTextBoxColumn
            // 
            this.linkqualitygcsDataGridViewTextBoxColumn.DataPropertyName = "linkqualitygcs";
            resources.ApplyResources(this.linkqualitygcsDataGridViewTextBoxColumn, "linkqualitygcsDataGridViewTextBoxColumn");
            this.linkqualitygcsDataGridViewTextBoxColumn.Name = "linkqualitygcsDataGridViewTextBoxColumn";
            // 
            // hwvoltageDataGridViewTextBoxColumn
            // 
            this.hwvoltageDataGridViewTextBoxColumn.DataPropertyName = "hwvoltage";
            resources.ApplyResources(this.hwvoltageDataGridViewTextBoxColumn, "hwvoltageDataGridViewTextBoxColumn");
            this.hwvoltageDataGridViewTextBoxColumn.Name = "hwvoltageDataGridViewTextBoxColumn";
            // 
            // boardvoltageDataGridViewTextBoxColumn
            // 
            this.boardvoltageDataGridViewTextBoxColumn.DataPropertyName = "boardvoltage";
            resources.ApplyResources(this.boardvoltageDataGridViewTextBoxColumn, "boardvoltageDataGridViewTextBoxColumn");
            this.boardvoltageDataGridViewTextBoxColumn.Name = "boardvoltageDataGridViewTextBoxColumn";
            // 
            // servovoltageDataGridViewTextBoxColumn
            // 
            this.servovoltageDataGridViewTextBoxColumn.DataPropertyName = "servovoltage";
            resources.ApplyResources(this.servovoltageDataGridViewTextBoxColumn, "servovoltageDataGridViewTextBoxColumn");
            this.servovoltageDataGridViewTextBoxColumn.Name = "servovoltageDataGridViewTextBoxColumn";
            // 
            // voltageflagDataGridViewTextBoxColumn
            // 
            this.voltageflagDataGridViewTextBoxColumn.DataPropertyName = "voltageflag";
            resources.ApplyResources(this.voltageflagDataGridViewTextBoxColumn, "voltageflagDataGridViewTextBoxColumn");
            this.voltageflagDataGridViewTextBoxColumn.Name = "voltageflagDataGridViewTextBoxColumn";
            // 
            // i2cerrorsDataGridViewTextBoxColumn
            // 
            this.i2cerrorsDataGridViewTextBoxColumn.DataPropertyName = "i2cerrors";
            resources.ApplyResources(this.i2cerrorsDataGridViewTextBoxColumn, "i2cerrorsDataGridViewTextBoxColumn");
            this.i2cerrorsDataGridViewTextBoxColumn.Name = "i2cerrorsDataGridViewTextBoxColumn";
            // 
            // timesincelastshotDataGridViewTextBoxColumn
            // 
            this.timesincelastshotDataGridViewTextBoxColumn.DataPropertyName = "timesincelastshot";
            resources.ApplyResources(this.timesincelastshotDataGridViewTextBoxColumn, "timesincelastshotDataGridViewTextBoxColumn");
            this.timesincelastshotDataGridViewTextBoxColumn.Name = "timesincelastshotDataGridViewTextBoxColumn";
            // 
            // pressabsDataGridViewTextBoxColumn
            // 
            this.pressabsDataGridViewTextBoxColumn.DataPropertyName = "press_abs";
            resources.ApplyResources(this.pressabsDataGridViewTextBoxColumn, "pressabsDataGridViewTextBoxColumn");
            this.pressabsDataGridViewTextBoxColumn.Name = "pressabsDataGridViewTextBoxColumn";
            // 
            // presstempDataGridViewTextBoxColumn
            // 
            this.presstempDataGridViewTextBoxColumn.DataPropertyName = "press_temp";
            resources.ApplyResources(this.presstempDataGridViewTextBoxColumn, "presstempDataGridViewTextBoxColumn");
            this.presstempDataGridViewTextBoxColumn.Name = "presstempDataGridViewTextBoxColumn";
            // 
            // pressabs2DataGridViewTextBoxColumn
            // 
            this.pressabs2DataGridViewTextBoxColumn.DataPropertyName = "press_abs2";
            resources.ApplyResources(this.pressabs2DataGridViewTextBoxColumn, "pressabs2DataGridViewTextBoxColumn");
            this.pressabs2DataGridViewTextBoxColumn.Name = "pressabs2DataGridViewTextBoxColumn";
            // 
            // presstemp2DataGridViewTextBoxColumn
            // 
            this.presstemp2DataGridViewTextBoxColumn.DataPropertyName = "press_temp2";
            resources.ApplyResources(this.presstemp2DataGridViewTextBoxColumn, "presstemp2DataGridViewTextBoxColumn");
            this.presstemp2DataGridViewTextBoxColumn.Name = "presstemp2DataGridViewTextBoxColumn";
            // 
            // magofsxDataGridViewTextBoxColumn
            // 
            this.magofsxDataGridViewTextBoxColumn.DataPropertyName = "mag_ofs_x";
            resources.ApplyResources(this.magofsxDataGridViewTextBoxColumn, "magofsxDataGridViewTextBoxColumn");
            this.magofsxDataGridViewTextBoxColumn.Name = "magofsxDataGridViewTextBoxColumn";
            // 
            // magofsyDataGridViewTextBoxColumn
            // 
            this.magofsyDataGridViewTextBoxColumn.DataPropertyName = "mag_ofs_y";
            resources.ApplyResources(this.magofsyDataGridViewTextBoxColumn, "magofsyDataGridViewTextBoxColumn");
            this.magofsyDataGridViewTextBoxColumn.Name = "magofsyDataGridViewTextBoxColumn";
            // 
            // magofszDataGridViewTextBoxColumn
            // 
            this.magofszDataGridViewTextBoxColumn.DataPropertyName = "mag_ofs_z";
            resources.ApplyResources(this.magofszDataGridViewTextBoxColumn, "magofszDataGridViewTextBoxColumn");
            this.magofszDataGridViewTextBoxColumn.Name = "magofszDataGridViewTextBoxColumn";
            // 
            // magdeclinationDataGridViewTextBoxColumn
            // 
            this.magdeclinationDataGridViewTextBoxColumn.DataPropertyName = "mag_declination";
            resources.ApplyResources(this.magdeclinationDataGridViewTextBoxColumn, "magdeclinationDataGridViewTextBoxColumn");
            this.magdeclinationDataGridViewTextBoxColumn.Name = "magdeclinationDataGridViewTextBoxColumn";
            // 
            // rawpressDataGridViewTextBoxColumn
            // 
            this.rawpressDataGridViewTextBoxColumn.DataPropertyName = "raw_press";
            resources.ApplyResources(this.rawpressDataGridViewTextBoxColumn, "rawpressDataGridViewTextBoxColumn");
            this.rawpressDataGridViewTextBoxColumn.Name = "rawpressDataGridViewTextBoxColumn";
            // 
            // rawtempDataGridViewTextBoxColumn
            // 
            this.rawtempDataGridViewTextBoxColumn.DataPropertyName = "raw_temp";
            resources.ApplyResources(this.rawtempDataGridViewTextBoxColumn, "rawtempDataGridViewTextBoxColumn");
            this.rawtempDataGridViewTextBoxColumn.Name = "rawtempDataGridViewTextBoxColumn";
            // 
            // gyrocalxDataGridViewTextBoxColumn
            // 
            this.gyrocalxDataGridViewTextBoxColumn.DataPropertyName = "gyro_cal_x";
            resources.ApplyResources(this.gyrocalxDataGridViewTextBoxColumn, "gyrocalxDataGridViewTextBoxColumn");
            this.gyrocalxDataGridViewTextBoxColumn.Name = "gyrocalxDataGridViewTextBoxColumn";
            // 
            // gyrocalyDataGridViewTextBoxColumn
            // 
            this.gyrocalyDataGridViewTextBoxColumn.DataPropertyName = "gyro_cal_y";
            resources.ApplyResources(this.gyrocalyDataGridViewTextBoxColumn, "gyrocalyDataGridViewTextBoxColumn");
            this.gyrocalyDataGridViewTextBoxColumn.Name = "gyrocalyDataGridViewTextBoxColumn";
            // 
            // gyrocalzDataGridViewTextBoxColumn
            // 
            this.gyrocalzDataGridViewTextBoxColumn.DataPropertyName = "gyro_cal_z";
            resources.ApplyResources(this.gyrocalzDataGridViewTextBoxColumn, "gyrocalzDataGridViewTextBoxColumn");
            this.gyrocalzDataGridViewTextBoxColumn.Name = "gyrocalzDataGridViewTextBoxColumn";
            // 
            // accelcalxDataGridViewTextBoxColumn
            // 
            this.accelcalxDataGridViewTextBoxColumn.DataPropertyName = "accel_cal_x";
            resources.ApplyResources(this.accelcalxDataGridViewTextBoxColumn, "accelcalxDataGridViewTextBoxColumn");
            this.accelcalxDataGridViewTextBoxColumn.Name = "accelcalxDataGridViewTextBoxColumn";
            // 
            // accelcalyDataGridViewTextBoxColumn
            // 
            this.accelcalyDataGridViewTextBoxColumn.DataPropertyName = "accel_cal_y";
            resources.ApplyResources(this.accelcalyDataGridViewTextBoxColumn, "accelcalyDataGridViewTextBoxColumn");
            this.accelcalyDataGridViewTextBoxColumn.Name = "accelcalyDataGridViewTextBoxColumn";
            // 
            // accelcalzDataGridViewTextBoxColumn
            // 
            this.accelcalzDataGridViewTextBoxColumn.DataPropertyName = "accel_cal_z";
            resources.ApplyResources(this.accelcalzDataGridViewTextBoxColumn, "accelcalzDataGridViewTextBoxColumn");
            this.accelcalzDataGridViewTextBoxColumn.Name = "accelcalzDataGridViewTextBoxColumn";
            // 
            // rateattitudeDataGridViewTextBoxColumn
            // 
            this.rateattitudeDataGridViewTextBoxColumn.DataPropertyName = "rateattitude";
            resources.ApplyResources(this.rateattitudeDataGridViewTextBoxColumn, "rateattitudeDataGridViewTextBoxColumn");
            this.rateattitudeDataGridViewTextBoxColumn.Name = "rateattitudeDataGridViewTextBoxColumn";
            // 
            // ratepositionDataGridViewTextBoxColumn
            // 
            this.ratepositionDataGridViewTextBoxColumn.DataPropertyName = "rateposition";
            resources.ApplyResources(this.ratepositionDataGridViewTextBoxColumn, "ratepositionDataGridViewTextBoxColumn");
            this.ratepositionDataGridViewTextBoxColumn.Name = "ratepositionDataGridViewTextBoxColumn";
            // 
            // ratestatusDataGridViewTextBoxColumn
            // 
            this.ratestatusDataGridViewTextBoxColumn.DataPropertyName = "ratestatus";
            resources.ApplyResources(this.ratestatusDataGridViewTextBoxColumn, "ratestatusDataGridViewTextBoxColumn");
            this.ratestatusDataGridViewTextBoxColumn.Name = "ratestatusDataGridViewTextBoxColumn";
            // 
            // ratesensorsDataGridViewTextBoxColumn
            // 
            this.ratesensorsDataGridViewTextBoxColumn.DataPropertyName = "ratesensors";
            resources.ApplyResources(this.ratesensorsDataGridViewTextBoxColumn, "ratesensorsDataGridViewTextBoxColumn");
            this.ratesensorsDataGridViewTextBoxColumn.Name = "ratesensorsDataGridViewTextBoxColumn";
            // 
            // ratercDataGridViewTextBoxColumn
            // 
            this.ratercDataGridViewTextBoxColumn.DataPropertyName = "raterc";
            resources.ApplyResources(this.ratercDataGridViewTextBoxColumn, "ratercDataGridViewTextBoxColumn");
            this.ratercDataGridViewTextBoxColumn.Name = "ratercDataGridViewTextBoxColumn";
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            resources.ApplyResources(this.datetimeDataGridViewTextBoxColumn, "datetimeDataGridViewTextBoxColumn");
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            // 
            // connectedDataGridViewCheckBoxColumn
            // 
            this.connectedDataGridViewCheckBoxColumn.DataPropertyName = "connected";
            resources.ApplyResources(this.connectedDataGridViewCheckBoxColumn, "connectedDataGridViewCheckBoxColumn");
            this.connectedDataGridViewCheckBoxColumn.Name = "connectedDataGridViewCheckBoxColumn";
            this.connectedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // campointaDataGridViewTextBoxColumn
            // 
            this.campointaDataGridViewTextBoxColumn.DataPropertyName = "campointa";
            resources.ApplyResources(this.campointaDataGridViewTextBoxColumn, "campointaDataGridViewTextBoxColumn");
            this.campointaDataGridViewTextBoxColumn.Name = "campointaDataGridViewTextBoxColumn";
            // 
            // campointbDataGridViewTextBoxColumn
            // 
            this.campointbDataGridViewTextBoxColumn.DataPropertyName = "campointb";
            resources.ApplyResources(this.campointbDataGridViewTextBoxColumn, "campointbDataGridViewTextBoxColumn");
            this.campointbDataGridViewTextBoxColumn.Name = "campointbDataGridViewTextBoxColumn";
            // 
            // campointcDataGridViewTextBoxColumn
            // 
            this.campointcDataGridViewTextBoxColumn.DataPropertyName = "campointc";
            resources.ApplyResources(this.campointcDataGridViewTextBoxColumn, "campointcDataGridViewTextBoxColumn");
            this.campointcDataGridViewTextBoxColumn.Name = "campointcDataGridViewTextBoxColumn";
            // 
            // gimbalPointDataGridViewTextBoxColumn
            // 
            this.gimbalPointDataGridViewTextBoxColumn.DataPropertyName = "GimbalPoint";
            resources.ApplyResources(this.gimbalPointDataGridViewTextBoxColumn, "gimbalPointDataGridViewTextBoxColumn");
            this.gimbalPointDataGridViewTextBoxColumn.Name = "gimbalPointDataGridViewTextBoxColumn";
            // 
            // gimballatDataGridViewTextBoxColumn
            // 
            this.gimballatDataGridViewTextBoxColumn.DataPropertyName = "gimballat";
            resources.ApplyResources(this.gimballatDataGridViewTextBoxColumn, "gimballatDataGridViewTextBoxColumn");
            this.gimballatDataGridViewTextBoxColumn.Name = "gimballatDataGridViewTextBoxColumn";
            this.gimballatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gimballngDataGridViewTextBoxColumn
            // 
            this.gimballngDataGridViewTextBoxColumn.DataPropertyName = "gimballng";
            resources.ApplyResources(this.gimballngDataGridViewTextBoxColumn, "gimballngDataGridViewTextBoxColumn");
            this.gimballngDataGridViewTextBoxColumn.Name = "gimballngDataGridViewTextBoxColumn";
            this.gimballngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // landedDataGridViewCheckBoxColumn
            // 
            this.landedDataGridViewCheckBoxColumn.DataPropertyName = "landed";
            resources.ApplyResources(this.landedDataGridViewCheckBoxColumn, "landedDataGridViewCheckBoxColumn");
            this.landedDataGridViewCheckBoxColumn.Name = "landedDataGridViewCheckBoxColumn";
            // 
            // terrainactiveDataGridViewCheckBoxColumn
            // 
            this.terrainactiveDataGridViewCheckBoxColumn.DataPropertyName = "terrainactive";
            resources.ApplyResources(this.terrainactiveDataGridViewCheckBoxColumn, "terrainactiveDataGridViewCheckBoxColumn");
            this.terrainactiveDataGridViewCheckBoxColumn.Name = "terrainactiveDataGridViewCheckBoxColumn";
            // 
            // tercuraltDataGridViewTextBoxColumn
            // 
            this.tercuraltDataGridViewTextBoxColumn.DataPropertyName = "ter_curalt";
            resources.ApplyResources(this.tercuraltDataGridViewTextBoxColumn, "tercuraltDataGridViewTextBoxColumn");
            this.tercuraltDataGridViewTextBoxColumn.Name = "tercuraltDataGridViewTextBoxColumn";
            // 
            // teraltDataGridViewTextBoxColumn
            // 
            this.teraltDataGridViewTextBoxColumn.DataPropertyName = "ter_alt";
            resources.ApplyResources(this.teraltDataGridViewTextBoxColumn, "teraltDataGridViewTextBoxColumn");
            this.teraltDataGridViewTextBoxColumn.Name = "teraltDataGridViewTextBoxColumn";
            // 
            // terloadDataGridViewTextBoxColumn
            // 
            this.terloadDataGridViewTextBoxColumn.DataPropertyName = "ter_load";
            resources.ApplyResources(this.terloadDataGridViewTextBoxColumn, "terloadDataGridViewTextBoxColumn");
            this.terloadDataGridViewTextBoxColumn.Name = "terloadDataGridViewTextBoxColumn";
            // 
            // terpendDataGridViewTextBoxColumn
            // 
            this.terpendDataGridViewTextBoxColumn.DataPropertyName = "ter_pend";
            resources.ApplyResources(this.terpendDataGridViewTextBoxColumn, "terpendDataGridViewTextBoxColumn");
            this.terpendDataGridViewTextBoxColumn.Name = "terpendDataGridViewTextBoxColumn";
            // 
            // terspaceDataGridViewTextBoxColumn
            // 
            this.terspaceDataGridViewTextBoxColumn.DataPropertyName = "ter_space";
            resources.ApplyResources(this.terspaceDataGridViewTextBoxColumn, "terspaceDataGridViewTextBoxColumn");
            this.terspaceDataGridViewTextBoxColumn.Name = "terspaceDataGridViewTextBoxColumn";
            // 
            // kIndexDataGridViewTextBoxColumn
            // 
            this.kIndexDataGridViewTextBoxColumn.DataPropertyName = "KIndex";
            resources.ApplyResources(this.kIndexDataGridViewTextBoxColumn, "kIndexDataGridViewTextBoxColumn");
            this.kIndexDataGridViewTextBoxColumn.Name = "kIndexDataGridViewTextBoxColumn";
            this.kIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optmxDataGridViewTextBoxColumn
            // 
            this.optmxDataGridViewTextBoxColumn.DataPropertyName = "opt_m_x";
            resources.ApplyResources(this.optmxDataGridViewTextBoxColumn, "optmxDataGridViewTextBoxColumn");
            this.optmxDataGridViewTextBoxColumn.Name = "optmxDataGridViewTextBoxColumn";
            // 
            // optmyDataGridViewTextBoxColumn
            // 
            this.optmyDataGridViewTextBoxColumn.DataPropertyName = "opt_m_y";
            resources.ApplyResources(this.optmyDataGridViewTextBoxColumn, "optmyDataGridViewTextBoxColumn");
            this.optmyDataGridViewTextBoxColumn.Name = "optmyDataGridViewTextBoxColumn";
            // 
            // optxDataGridViewTextBoxColumn
            // 
            this.optxDataGridViewTextBoxColumn.DataPropertyName = "opt_x";
            resources.ApplyResources(this.optxDataGridViewTextBoxColumn, "optxDataGridViewTextBoxColumn");
            this.optxDataGridViewTextBoxColumn.Name = "optxDataGridViewTextBoxColumn";
            // 
            // optyDataGridViewTextBoxColumn
            // 
            this.optyDataGridViewTextBoxColumn.DataPropertyName = "opt_y";
            resources.ApplyResources(this.optyDataGridViewTextBoxColumn, "optyDataGridViewTextBoxColumn");
            this.optyDataGridViewTextBoxColumn.Name = "optyDataGridViewTextBoxColumn";
            // 
            // optquaDataGridViewTextBoxColumn
            // 
            this.optquaDataGridViewTextBoxColumn.DataPropertyName = "opt_qua";
            resources.ApplyResources(this.optquaDataGridViewTextBoxColumn, "optquaDataGridViewTextBoxColumn");
            this.optquaDataGridViewTextBoxColumn.Name = "optquaDataGridViewTextBoxColumn";
            // 
            // ekfstatusDataGridViewTextBoxColumn
            // 
            this.ekfstatusDataGridViewTextBoxColumn.DataPropertyName = "ekfstatus";
            resources.ApplyResources(this.ekfstatusDataGridViewTextBoxColumn, "ekfstatusDataGridViewTextBoxColumn");
            this.ekfstatusDataGridViewTextBoxColumn.Name = "ekfstatusDataGridViewTextBoxColumn";
            // 
            // ekfflagsDataGridViewTextBoxColumn
            // 
            this.ekfflagsDataGridViewTextBoxColumn.DataPropertyName = "ekfflags";
            resources.ApplyResources(this.ekfflagsDataGridViewTextBoxColumn, "ekfflagsDataGridViewTextBoxColumn");
            this.ekfflagsDataGridViewTextBoxColumn.Name = "ekfflagsDataGridViewTextBoxColumn";
            // 
            // ekfvelvDataGridViewTextBoxColumn
            // 
            this.ekfvelvDataGridViewTextBoxColumn.DataPropertyName = "ekfvelv";
            resources.ApplyResources(this.ekfvelvDataGridViewTextBoxColumn, "ekfvelvDataGridViewTextBoxColumn");
            this.ekfvelvDataGridViewTextBoxColumn.Name = "ekfvelvDataGridViewTextBoxColumn";
            // 
            // ekfcompvDataGridViewTextBoxColumn
            // 
            this.ekfcompvDataGridViewTextBoxColumn.DataPropertyName = "ekfcompv";
            resources.ApplyResources(this.ekfcompvDataGridViewTextBoxColumn, "ekfcompvDataGridViewTextBoxColumn");
            this.ekfcompvDataGridViewTextBoxColumn.Name = "ekfcompvDataGridViewTextBoxColumn";
            // 
            // ekfposhorDataGridViewTextBoxColumn
            // 
            this.ekfposhorDataGridViewTextBoxColumn.DataPropertyName = "ekfposhor";
            resources.ApplyResources(this.ekfposhorDataGridViewTextBoxColumn, "ekfposhorDataGridViewTextBoxColumn");
            this.ekfposhorDataGridViewTextBoxColumn.Name = "ekfposhorDataGridViewTextBoxColumn";
            // 
            // ekfposvertDataGridViewTextBoxColumn
            // 
            this.ekfposvertDataGridViewTextBoxColumn.DataPropertyName = "ekfposvert";
            resources.ApplyResources(this.ekfposvertDataGridViewTextBoxColumn, "ekfposvertDataGridViewTextBoxColumn");
            this.ekfposvertDataGridViewTextBoxColumn.Name = "ekfposvertDataGridViewTextBoxColumn";
            // 
            // ekfteraltDataGridViewTextBoxColumn
            // 
            this.ekfteraltDataGridViewTextBoxColumn.DataPropertyName = "ekfteralt";
            resources.ApplyResources(this.ekfteraltDataGridViewTextBoxColumn, "ekfteraltDataGridViewTextBoxColumn");
            this.ekfteraltDataGridViewTextBoxColumn.Name = "ekfteraltDataGridViewTextBoxColumn";
            // 
            // pidffDataGridViewTextBoxColumn
            // 
            this.pidffDataGridViewTextBoxColumn.DataPropertyName = "pidff";
            resources.ApplyResources(this.pidffDataGridViewTextBoxColumn, "pidffDataGridViewTextBoxColumn");
            this.pidffDataGridViewTextBoxColumn.Name = "pidffDataGridViewTextBoxColumn";
            // 
            // pidPDataGridViewTextBoxColumn
            // 
            this.pidPDataGridViewTextBoxColumn.DataPropertyName = "pidP";
            resources.ApplyResources(this.pidPDataGridViewTextBoxColumn, "pidPDataGridViewTextBoxColumn");
            this.pidPDataGridViewTextBoxColumn.Name = "pidPDataGridViewTextBoxColumn";
            // 
            // pidIDataGridViewTextBoxColumn
            // 
            this.pidIDataGridViewTextBoxColumn.DataPropertyName = "pidI";
            resources.ApplyResources(this.pidIDataGridViewTextBoxColumn, "pidIDataGridViewTextBoxColumn");
            this.pidIDataGridViewTextBoxColumn.Name = "pidIDataGridViewTextBoxColumn";
            // 
            // pidDDataGridViewTextBoxColumn
            // 
            this.pidDDataGridViewTextBoxColumn.DataPropertyName = "pidD";
            resources.ApplyResources(this.pidDDataGridViewTextBoxColumn, "pidDDataGridViewTextBoxColumn");
            this.pidDDataGridViewTextBoxColumn.Name = "pidDDataGridViewTextBoxColumn";
            // 
            // pidaxisDataGridViewTextBoxColumn
            // 
            this.pidaxisDataGridViewTextBoxColumn.DataPropertyName = "pidaxis";
            resources.ApplyResources(this.pidaxisDataGridViewTextBoxColumn, "pidaxisDataGridViewTextBoxColumn");
            this.pidaxisDataGridViewTextBoxColumn.Name = "pidaxisDataGridViewTextBoxColumn";
            // 
            // piddesiredDataGridViewTextBoxColumn
            // 
            this.piddesiredDataGridViewTextBoxColumn.DataPropertyName = "piddesired";
            resources.ApplyResources(this.piddesiredDataGridViewTextBoxColumn, "piddesiredDataGridViewTextBoxColumn");
            this.piddesiredDataGridViewTextBoxColumn.Name = "piddesiredDataGridViewTextBoxColumn";
            // 
            // pidachievedDataGridViewTextBoxColumn
            // 
            this.pidachievedDataGridViewTextBoxColumn.DataPropertyName = "pidachieved";
            resources.ApplyResources(this.pidachievedDataGridViewTextBoxColumn, "pidachievedDataGridViewTextBoxColumn");
            this.pidachievedDataGridViewTextBoxColumn.Name = "pidachievedDataGridViewTextBoxColumn";
            // 
            // vibeclip0DataGridViewTextBoxColumn
            // 
            this.vibeclip0DataGridViewTextBoxColumn.DataPropertyName = "vibeclip0";
            resources.ApplyResources(this.vibeclip0DataGridViewTextBoxColumn, "vibeclip0DataGridViewTextBoxColumn");
            this.vibeclip0DataGridViewTextBoxColumn.Name = "vibeclip0DataGridViewTextBoxColumn";
            // 
            // vibeclip1DataGridViewTextBoxColumn
            // 
            this.vibeclip1DataGridViewTextBoxColumn.DataPropertyName = "vibeclip1";
            resources.ApplyResources(this.vibeclip1DataGridViewTextBoxColumn, "vibeclip1DataGridViewTextBoxColumn");
            this.vibeclip1DataGridViewTextBoxColumn.Name = "vibeclip1DataGridViewTextBoxColumn";
            // 
            // vibeclip2DataGridViewTextBoxColumn
            // 
            this.vibeclip2DataGridViewTextBoxColumn.DataPropertyName = "vibeclip2";
            resources.ApplyResources(this.vibeclip2DataGridViewTextBoxColumn, "vibeclip2DataGridViewTextBoxColumn");
            this.vibeclip2DataGridViewTextBoxColumn.Name = "vibeclip2DataGridViewTextBoxColumn";
            // 
            // vibexDataGridViewTextBoxColumn
            // 
            this.vibexDataGridViewTextBoxColumn.DataPropertyName = "vibex";
            resources.ApplyResources(this.vibexDataGridViewTextBoxColumn, "vibexDataGridViewTextBoxColumn");
            this.vibexDataGridViewTextBoxColumn.Name = "vibexDataGridViewTextBoxColumn";
            // 
            // vibeyDataGridViewTextBoxColumn
            // 
            this.vibeyDataGridViewTextBoxColumn.DataPropertyName = "vibey";
            resources.ApplyResources(this.vibeyDataGridViewTextBoxColumn, "vibeyDataGridViewTextBoxColumn");
            this.vibeyDataGridViewTextBoxColumn.Name = "vibeyDataGridViewTextBoxColumn";
            // 
            // vibezDataGridViewTextBoxColumn
            // 
            this.vibezDataGridViewTextBoxColumn.DataPropertyName = "vibez";
            resources.ApplyResources(this.vibezDataGridViewTextBoxColumn, "vibezDataGridViewTextBoxColumn");
            this.vibezDataGridViewTextBoxColumn.Name = "vibezDataGridViewTextBoxColumn";
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "version";
            resources.ApplyResources(this.versionDataGridViewTextBoxColumn, "versionDataGridViewTextBoxColumn");
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            // 
            // rpm1DataGridViewTextBoxColumn
            // 
            this.rpm1DataGridViewTextBoxColumn.DataPropertyName = "rpm1";
            resources.ApplyResources(this.rpm1DataGridViewTextBoxColumn, "rpm1DataGridViewTextBoxColumn");
            this.rpm1DataGridViewTextBoxColumn.Name = "rpm1DataGridViewTextBoxColumn";
            // 
            // rpm2DataGridViewTextBoxColumn
            // 
            this.rpm2DataGridViewTextBoxColumn.DataPropertyName = "rpm2";
            resources.ApplyResources(this.rpm2DataGridViewTextBoxColumn, "rpm2DataGridViewTextBoxColumn");
            this.rpm2DataGridViewTextBoxColumn.Name = "rpm2DataGridViewTextBoxColumn";
            // 
            // capabilitiesDataGridViewTextBoxColumn
            // 
            this.capabilitiesDataGridViewTextBoxColumn.DataPropertyName = "capabilities";
            resources.ApplyResources(this.capabilitiesDataGridViewTextBoxColumn, "capabilitiesDataGridViewTextBoxColumn");
            this.capabilitiesDataGridViewTextBoxColumn.Name = "capabilitiesDataGridViewTextBoxColumn";
            // 
            // speedupDataGridViewTextBoxColumn
            // 
            this.speedupDataGridViewTextBoxColumn.DataPropertyName = "speedup";
            resources.ApplyResources(this.speedupDataGridViewTextBoxColumn, "speedupDataGridViewTextBoxColumn");
            this.speedupDataGridViewTextBoxColumn.Name = "speedupDataGridViewTextBoxColumn";
            // 
            // vtolstateDataGridViewTextBoxColumn
            // 
            this.vtolstateDataGridViewTextBoxColumn.DataPropertyName = "vtol_state";
            resources.ApplyResources(this.vtolstateDataGridViewTextBoxColumn, "vtolstateDataGridViewTextBoxColumn");
            this.vtolstateDataGridViewTextBoxColumn.Name = "vtolstateDataGridViewTextBoxColumn";
            this.vtolstateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // landedstateDataGridViewTextBoxColumn
            // 
            this.landedstateDataGridViewTextBoxColumn.DataPropertyName = "landed_state";
            resources.ApplyResources(this.landedstateDataGridViewTextBoxColumn, "landedstateDataGridViewTextBoxColumn");
            this.landedstateDataGridViewTextBoxColumn.Name = "landedstateDataGridViewTextBoxColumn";
            this.landedstateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceQuickTab
            // 
            this.bindingSourceQuickTab.DataSource = typeof(MissionPlanner.CurrentState);
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
            // windDir1
            // 
            this.windDir1.BackColor = System.Drawing.Color.Transparent;
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Direction", this.bindingSource1, "wind_dir", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Speed", this.bindingSource1, "wind_vel", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.Direction = 360D;
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
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.comboBoxMapTypeData);
            this.panel1.Controls.Add(this.coords1);
            this.panel1.Controls.Add(this.Zoomlevel);
            this.panel1.Controls.Add(this.CHK_autopan);
            this.panel1.Controls.Add(this.CB_tuning);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.LBLSignal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblconexwifi, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_2);
            // 
            // LBLSignal
            // 
            resources.ApplyResources(this.LBLSignal, "LBLSignal");
            this.LBLSignal.Name = "LBLSignal";
            // 
            // lblconexwifi
            // 
            resources.ApplyResources(this.lblconexwifi, "lblconexwifi");
            this.lblconexwifi.Name = "lblconexwifi";
            // 
            // comboBoxMapTypeData
            // 
            this.comboBoxMapTypeData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapTypeData.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMapTypeData, "comboBoxMapTypeData");
            this.comboBoxMapTypeData.Name = "comboBoxMapTypeData";
            this.toolTip1.SetToolTip(this.comboBoxMapTypeData, resources.GetString("comboBoxMapTypeData.ToolTip"));
            this.comboBoxMapTypeData.SelectedIndexChanged += new System.EventHandler(this.comboBoxMapTypeData_SelectedIndexChanged);
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
            // contextMenuStripactionstab
            // 
            this.contextMenuStripactionstab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem});
            this.contextMenuStripactionstab.Name = "contextMenuStripactionstab";
            resources.ApplyResources(this.contextMenuStripactionstab, "contextMenuStripactionstab");
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            resources.ApplyResources(this.customizeToolStripMenuItem, "customizeToolStripMenuItem");
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // bindingSourceGaugesTab
            // 
            this.bindingSourceGaugesTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // contextMenuStripQuickView
            // 
            this.contextMenuStripQuickView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setViewCountToolStripMenuItem});
            this.contextMenuStripQuickView.Name = "contextMenuStripQuickView";
            resources.ApplyResources(this.contextMenuStripQuickView, "contextMenuStripQuickView");
            // 
            // setViewCountToolStripMenuItem
            // 
            this.setViewCountToolStripMenuItem.Name = "setViewCountToolStripMenuItem";
            resources.ApplyResources(this.setViewCountToolStripMenuItem, "setViewCountToolStripMenuItem");
            this.setViewCountToolStripMenuItem.Click += new System.EventHandler(this.setViewCountToolStripMenuItem_Click);
            // 
            // ZedGraphTimer
            // 
            this.ZedGraphTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openScriptDialog
            // 
            resources.ApplyResources(this.openScriptDialog, "openScriptDialog");
            this.openScriptDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openScriptDialog_FileOk);
            // 
            // scriptChecker
            // 
            this.scriptChecker.Tick += new System.EventHandler(this.scriptChecker_Tick);
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
            // Messagetabtimer
            // 
            this.Messagetabtimer.Interval = 200;
            this.Messagetabtimer.Tick += new System.EventHandler(this.Messagetabtimer_Tick);
            // 
            // bindingSourceStatusTab
            // 
            this.bindingSourceStatusTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // RecargaLbl
            // 
            this.RecargaLbl.Enabled = true;
            this.RecargaLbl.Tick += new System.EventHandler(this.timer1_Tick_2);
            // 
            // TimerAlertEchosounder
            // 
            this.TimerAlertEchosounder.Interval = 1000;
            this.TimerAlertEchosounder.Tick += new System.EventHandler(this.TimerAlertEchosounder_Tick);
            // 
            // modifyandSetSpeed
            // 
            resources.ApplyResources(this.modifyandSetSpeed, "modifyandSetSpeed");
            this.modifyandSetSpeed.ButtonText = "Change Speed";
            this.modifyandSetSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.modifyandSetSpeed.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetSpeed.Name = "modifyandSetSpeed";
            this.modifyandSetSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetSpeed.Click += new System.EventHandler(this.modifyandSetSpeed_Click);
            this.modifyandSetSpeed.Load += new System.EventHandler(this.modifyandSetSpeed_Load);
            this.modifyandSetSpeed.ParentChanged += new System.EventHandler(this.modifyandSetSpeed_ParentChanged);
            // 
            // modifyandSetLoiterRad
            // 
            this.modifyandSetLoiterRad.ButtonText = "Set Loiter Rad";
            resources.ApplyResources(this.modifyandSetLoiterRad, "modifyandSetLoiterRad");
            this.modifyandSetLoiterRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.modifyandSetLoiterRad.Name = "modifyandSetLoiterRad";
            this.modifyandSetLoiterRad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Click += new System.EventHandler(this.modifyandSetLoiterRad_Click);
            // 
            // modifyandSetAlt
            // 
            this.modifyandSetAlt.ButtonText = "Change Alt";
            resources.ApplyResources(this.modifyandSetAlt, "modifyandSetAlt");
            this.modifyandSetAlt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.modifyandSetAlt.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetAlt.Name = "modifyandSetAlt";
            this.modifyandSetAlt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetAlt.Click += new System.EventHandler(this.modifyandSetAlt_Click);
            // 
            // checkListControl1
            // 
            resources.ApplyResources(this.checkListControl1, "checkListControl1");
            this.checkListControl1.Name = "checkListControl1";
            // 
            // servoOptions1
            // 
            resources.ApplyResources(this.servoOptions1, "servoOptions1");
            this.servoOptions1.Name = "servoOptions1";
            this.servoOptions1.thisservo = 5;
            // 
            // servoOptions2
            // 
            resources.ApplyResources(this.servoOptions2, "servoOptions2");
            this.servoOptions2.Name = "servoOptions2";
            this.servoOptions2.thisservo = 6;
            // 
            // servoOptions3
            // 
            resources.ApplyResources(this.servoOptions3, "servoOptions3");
            this.servoOptions3.Name = "servoOptions3";
            this.servoOptions3.thisservo = 7;
            // 
            // servoOptions4
            // 
            resources.ApplyResources(this.servoOptions4, "servoOptions4");
            this.servoOptions4.Name = "servoOptions4";
            this.servoOptions4.thisservo = 8;
            // 
            // servoOptions5
            // 
            resources.ApplyResources(this.servoOptions5, "servoOptions5");
            this.servoOptions5.Name = "servoOptions5";
            this.servoOptions5.thisservo = 9;
            // 
            // servoOptions6
            // 
            resources.ApplyResources(this.servoOptions6, "servoOptions6");
            this.servoOptions6.Name = "servoOptions6";
            this.servoOptions6.thisservo = 10;
            // 
            // servoOptions7
            // 
            resources.ApplyResources(this.servoOptions7, "servoOptions7");
            this.servoOptions7.Name = "servoOptions7";
            this.servoOptions7.thisservo = 11;
            // 
            // servoOptions8
            // 
            resources.ApplyResources(this.servoOptions8, "servoOptions8");
            this.servoOptions8.Name = "servoOptions8";
            this.servoOptions8.thisservo = 12;
            // 
            // servoOptions9
            // 
            resources.ApplyResources(this.servoOptions9, "servoOptions9");
            this.servoOptions9.Name = "servoOptions9";
            this.servoOptions9.thisservo = 13;
            // 
            // servoOptions10
            // 
            resources.ApplyResources(this.servoOptions10, "servoOptions10");
            this.servoOptions10.Name = "servoOptions10";
            this.servoOptions10.thisservo = 14;
            // 
            // relayOptions1
            // 
            resources.ApplyResources(this.relayOptions1, "relayOptions1");
            this.relayOptions1.Name = "relayOptions1";
            this.relayOptions1.thisrelay = 0;
            // 
            // relayOptions2
            // 
            resources.ApplyResources(this.relayOptions2, "relayOptions2");
            this.relayOptions2.Name = "relayOptions2";
            this.relayOptions2.thisrelay = 1;
            // 
            // relayOptions3
            // 
            resources.ApplyResources(this.relayOptions3, "relayOptions3");
            this.relayOptions3.Name = "relayOptions3";
            this.relayOptions3.thisrelay = 2;
            // 
            // relayOptions4
            // 
            resources.ApplyResources(this.relayOptions4, "relayOptions4");
            this.relayOptions4.Name = "relayOptions4";
            this.relayOptions4.thisrelay = 3;
            // 
            // distanceBar1
            // 
            resources.ApplyResources(this.distanceBar1, "distanceBar1");
            this.distanceBar1.BackColor = System.Drawing.Color.Transparent;
            this.distanceBar1.Name = "distanceBar1";
            this.distanceBar1.totaldist = 100F;
            this.distanceBar1.traveleddist = 0F;
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
            this.tabQuick.ResumeLayout(false);
            this.tableLayoutPanelQuick.ResumeLayout(false);
            this.tableLayoutPanelQuick.PerformLayout();
            this.tabActions.ResumeLayout(false);
            this.tabActions.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tabActionsSimple.ResumeLayout(false);
            this.tabPagePreFlight.ResumeLayout(false);
            this.tabGauges.ResumeLayout(false);
            this.tabServo.ResumeLayout(false);
            this.flowLayoutPanelServos.ResumeLayout(false);
            this.tabTLogs.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPaneltlogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabScripts.ResumeLayout(false);
            this.tabScripts.PerformLayout();
            this.tabPagemessages.ResumeLayout(false);
            this.tabPagemessages.PerformLayout();
            this.tabPayload.ResumeLayout(false);
            this.groupBoxRoll.ResumeLayout(false);
            this.groupBoxRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).EndInit();
            this.groupBoxYaw.ResumeLayout(false);
            this.groupBoxYaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).EndInit();
            this.groupBoxPitch.ResumeLayout(false);
            this.groupBoxPitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            this.tableMap.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).EndInit();
            this.contextMenuStripactionstab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).EndInit();
            this.contextMenuStripQuickView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).EndInit();
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
        private Controls.MyButton BUT_RAWSensor;
        private Controls.MyButton BUTactiondo;
        private Controls.MyButton BUTrestartmission;
        private System.Windows.Forms.ComboBox CMB_action;
        private Controls.MyButton BUT_Homealt;
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
        public System.Windows.Forms.TabPage tabStatus;
        public System.Windows.Forms.TabPage tabActions;
        public System.Windows.Forms.TabPage tabTLogs;
        private System.Windows.Forms.ComboBox CMB_modes;
        private Controls.MyButton BUT_setmode;
        private System.Windows.Forms.ComboBox CMB_setwp;
        private Controls.MyButton BUT_quickrtl;
        private Controls.MyButton BUT_quickauto;
        private Controls.MyButton BUT_log2kml;
        private Controls.MyButton BUT_joystick_settings;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controls.MyLabel lbl_logpercent;
        private System.Windows.Forms.ToolStripMenuItem pointCameraHereToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.MyLabel lbl_hdop;
        private Controls.MyLabel lbl_sats;
        private Controls.MyLabel lbl_playbackspeed;
        public System.Windows.Forms.TabPage tabQuick;
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
        private Controls.ModifyandSet modifyandSetAlt;
        private System.Windows.Forms.ToolStripMenuItem triggerCameraToolStripMenuItem;
        private Controls.MyTrackBar TRK_zoom;
        private Controls.MyLabel LBL_logfn;
        public System.Windows.Forms.TabPage tabServo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelServos;
        private Controls.ServoOptions servoOptions1;
        private Controls.ServoOptions servoOptions2;
        private Controls.ServoOptions servoOptions3;
        private Controls.ServoOptions servoOptions4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneltlogs;
        private Controls.ServoOptions servoOptions5;
        private Controls.ServoOptions servoOptions6;
        private Controls.ServoOptions servoOptions7;
        private Controls.ServoOptions servoOptions8;
        private Controls.ServoOptions servoOptions9;
        private Controls.ServoOptions servoOptions10;
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
        public System.Windows.Forms.TabPage tablogbrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
        private System.Windows.Forms.Timer scriptChecker;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.BindingSource bindingSourceQuickTab;
        private System.Windows.Forms.BindingSource bindingSourceStatusTab;
        private System.Windows.Forms.BindingSource bindingSourceGaugesTab;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem;
        private MissionPlanner.Controls.Coords coords1;
        private System.Windows.Forms.ComboBox CMB_mountmode;
        private Controls.MyButton BUT_mountmode;
        public Controls.WindDir windDir1;
        public System.Windows.Forms.TabPage tabPagemessages;
        private System.Windows.Forms.TextBox txt_messagebox;
        private System.Windows.Forms.Timer Messagetabtimer;
        public System.Windows.Forms.TabPage tabActionsSimple;
        private Controls.MyButton myButton1;
        private Controls.MyButton myButton2;
        private Controls.MyButton myButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripactionstab;
        private System.Windows.Forms.ToolStripMenuItem addPoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private Controls.DistanceBar distanceBar1;
        private System.Windows.Forms.ToolStripMenuItem takeOffToolStripMenuItem;
        public System.Windows.Forms.TabPage tabPagePreFlight;
        private Controls.PreFlight.CheckListControl checkListControl1;
        private Controls.MyButton BUT_abortland;
        private Controls.MyButton but_disablejoystick;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PointCameraCoordsToolStripMenuItem1;
        private Controls.ModifyandSet modifyandSetLoiterRad;
        private System.Windows.Forms.ToolStripMenuItem onOffCameraOverlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altitudeAngelSettingsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQuickView;
        private System.Windows.Forms.ToolStripMenuItem setViewCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEKFHomeHereToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPayload;
        private System.Windows.Forms.BindingSource bindingSourcePayloadTab;
        private System.Windows.Forms.TrackBar trackBarYaw;
        private System.Windows.Forms.TrackBar trackBarRoll;
        private System.Windows.Forms.TrackBar trackBarPitch;
        private Controls.MyButton BUT_resetGimbalPos;
        private System.Windows.Forms.TextBox TXT_gimbalPitchPos;
        private System.Windows.Forms.TextBox TXT_gimbalYawPos;
        private System.Windows.Forms.TextBox TXT_gimbalRollPos;
        private System.Windows.Forms.GroupBox groupBoxRoll;
        private System.Windows.Forms.GroupBox groupBoxYaw;
        private System.Windows.Forms.GroupBox groupBoxPitch;
        private Controls.MyButton BUT_PayloadFolder;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem1;
        private Controls.RelayOptions relayOptions1;
        private Controls.RelayOptions relayOptions2;
        private Controls.RelayOptions relayOptions3;
        private Controls.RelayOptions relayOptions4;
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
        public System.Windows.Forms.TabPage tabGauges;
        private AGaugeApp.AGauge Gvspeed;
        private Controls.HSI Gheading;
        private AGaugeApp.AGauge Galt;
        private AGaugeApp.AGauge Gspeed;
        public System.Windows.Forms.TabPage tabScripts;
        private System.Windows.Forms.CheckBox checkBoxRedirectOutput;
        private Controls.MyButton BUT_edit_selected;
        private System.Windows.Forms.Label labelSelectedScript;
        private Controls.MyButton BUT_run_script;
        private Controls.MyButton BUT_abort_script;
        private System.Windows.Forms.Label labelScriptStatus;
        private Controls.MyButton BUT_select_script;
        private Controls.MyButton BUT_quickmanual;
        private Controls.MyButton BUT_setwp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Controls.ModifyandSet modifyandSetSpeed;
        private Controls.MyButton BUT_resumemis;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private Controls.MyButton BUT_DFMavlink;
        private Controls.MyButton BUT_matlab;
        private Controls.MyButton but_bintolog;
        private Controls.MyButton but_dflogtokml;
        private Controls.MyButton BUT_loganalysis;
        private Controls.MyButton BUT_logbrowse;
        private System.Windows.Forms.ComboBox COMBJOY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuick;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer RecargaLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpdistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distToHomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangefinder1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aOADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundcourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altaslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horizondistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altoffsethomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpshdopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpshaccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsvaccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsvelaccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpshdgaccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lat2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lng2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altasl2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsstatus2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpshdop2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satcount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundspeed2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundcourse2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satcountBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpstimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altd1000DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altd100DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetairspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lowairspeedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asratioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn azDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelsqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrosqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn myDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magfieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ax2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ay2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn az2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelsq2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gx2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gy2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gz2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrosq2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mx2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn my2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mz2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magfield2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ax3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ay3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn az3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelsq3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gx3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gy3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gz3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrosq3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mx3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn my3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mz3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magfield3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch1inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch2inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch3inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch4inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch5inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch6inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch7inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch8inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch9inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch10inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch11inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch12inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch13inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch14inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch15inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch16inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch1outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch2outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch3outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch4outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch5outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch6outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch7outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch8outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch9outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch10outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch11outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch12outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch13outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch14outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch15outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch16outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc1voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc1currDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc1rpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc1tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc2voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc2currDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc2rpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc2tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc3voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc3currDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc3rpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc3tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc4voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc4currDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc4rpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc4tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc5voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc5currDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc5rpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc5tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc6voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc6currDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc6rpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc6tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc7voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc7currDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc7rpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc7tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc8voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc8currDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc8rpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc8tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch3percentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn failsafeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rxrssiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn critAOADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lowgroundspeedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticalspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticalspeedfpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glideratioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn navrollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn navpitchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn navbearingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetbearingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alterrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bererrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aspderrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtrackerrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn climbrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tohDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distTraveledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSinceArmInAirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInAirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInAirMinSecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radiusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winddirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windvelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetaltd100DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetaltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageHighTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn current2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn current3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn current4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn current5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn current6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn current7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn current8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wattsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterymahperkmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterykmleftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterytempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movingBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackerLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distFromMovingBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLToMAVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aZToMAVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonarrangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonarvoltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangefinder2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangefinder3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freememDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brklevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn armedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rssiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remrssiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbufferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remnoiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rxerrorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localsnrdbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remotesnrdbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distRSSIRemainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packetdropremoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkqualitygcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hwvoltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardvoltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servovoltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageflagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn i2cerrorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timesincelastshotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressabsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presstempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressabs2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presstemp2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magofsxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magofsyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magofszDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magdeclinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawpressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawtempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrocalxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrocalyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrocalzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelcalxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelcalyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelcalzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateattitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratepositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratestatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratesensorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratercDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn connectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campointaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campointbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campointcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gimbalPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gimballatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gimballngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn landedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn terrainactiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tercuraltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teraltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terloadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terpendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terspaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optmxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optquaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfflagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfvelvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfcompvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfposhorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfposvertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfteraltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidaxisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piddesiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidachievedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibeclip0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibeclip1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibeclip2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibezDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpm1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpm2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capabilitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtolstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landedstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBLrangefinder1;
        private System.Windows.Forms.Label LBLDistToHome;
        private System.Windows.Forms.Label LBLwp_dist;
        private System.Windows.Forms.Label LBLgroundspeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblindicadores;
        private Controls.MyButton ButJoyOn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label LBLSignal;
        private System.Windows.Forms.Label lblconexwifi;
        private System.Windows.Forms.Timer TimerAlertEchosounder;
    }
}