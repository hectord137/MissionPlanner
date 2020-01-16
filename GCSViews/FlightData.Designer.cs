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
            this.contextMenuStripactionstab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabQuick = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelQuick = new System.Windows.Forms.TableLayoutPanel();
            this.s = new System.Windows.Forms.Label();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.LBLwp_dist = new System.Windows.Forms.Label();
            this.LBLrangefinder1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LBLgroundspeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LBLDistToHome = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_quickauto = new MissionPlanner.Controls.MyButton();
            this.BUT_quickrtl = new MissionPlanner.Controls.MyButton();
            this.BUT_resumemis = new MissionPlanner.Controls.MyButton();
            this.BUT_quickmanual = new MissionPlanner.Controls.MyButton();
            this.ButJoyOn = new MissionPlanner.Controls.MyButton();
            this.BUTrestartmission = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_setwp = new MissionPlanner.Controls.MyButton();
            this.CMB_setwp = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.CMB_modes = new System.Windows.Forms.ComboBox();
            this.BUT_setmode = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_clear_track = new MissionPlanner.Controls.MyButton();
            this.BUT_ARM = new MissionPlanner.Controls.MyButton();
            this.lblindicadores = new System.Windows.Forms.Label();
            this.BUT_Homealt = new MissionPlanner.Controls.MyButton();
            this.BUT_abortland = new MissionPlanner.Controls.MyButton();
            this.BUT_joystick = new MissionPlanner.Controls.MyButton();
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
            this.goHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.comboBoxMapTypeData = new System.Windows.Forms.ComboBox();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.Zoomlevel = new System.Windows.Forms.NumericUpDown();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
            this.CB_tuning = new System.Windows.Forms.CheckBox();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.parentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yawDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aOADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groundcourseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lngDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altaslDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horizondistDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vzDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altoffsethomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsstatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpshdopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satcountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpshaccDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsvaccDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsvelaccDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpshdgaccDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lat2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lng2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altasl2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsstatus2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpshdop2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satcount2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groundspeed2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groundcourse2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satcountBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpstimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altd1000DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altd100DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airspeedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetairspeedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowairspeedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.asratioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groundspeedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.azDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelsqDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gzDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrosqDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mzDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magfieldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ax2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ay2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.az2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelsq2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gx2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gy2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gz2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrosq2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mx2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.my2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mz2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magfield2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ax3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ay3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.az3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelsq3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gx3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gy3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gz3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrosq3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mx3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.my3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mz3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magfield3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch1inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch2inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch3inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch4inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch5inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch6inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch7inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch8inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch9inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch10inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch11inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch12inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch13inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch14inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch15inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch16inDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch1outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch2outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch3outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch4outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch5outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch6outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch7outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch8outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch9outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch10outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch11outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch12outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch13outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch14outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch15outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch16outDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc1voltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc1currDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc1rpmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc1tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc2voltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc2currDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc2rpmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc2tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc3voltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc3currDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc3rpmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc3tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc4voltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc4currDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc4rpmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc4tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc5voltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc5currDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc5rpmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc5tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc6voltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc6currDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc6rpmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc6tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc7voltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc7currDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc7rpmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc7tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc8voltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc8currDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc8rpmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esc8tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch3percentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failsafeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rxrssiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.critAOADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowgroundspeedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.verticalspeedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verticalspeedfpmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glideratioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navrollDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navpitchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navbearingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetbearingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wpdistDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alterrorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bererrorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aspderrorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtrackerrorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wpnoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.climbrateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tohDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distTraveledDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSinceArmInAirDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInAirDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInAirMinSecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnrateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turngDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qNHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winddirDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windvelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetaltd100DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetaltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageHighDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageHighTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage4DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage5DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage6DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage7DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage8DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremainingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining4DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining5DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining6DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining7DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryremaining8DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current4DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current5DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current6DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current7DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current8DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wattsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterymahperkmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterykmleftDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmahDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell4DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell5DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterycell6DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterytempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah4DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah5DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah6DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah7DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryusedmah8DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batteryvoltage2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeLocationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movingBaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackerLocationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetLocationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distToHomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distFromMovingBaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLToMAVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aZToMAVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonarrangeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonarvoltageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangefinder1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangefinder2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangefinder3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freememDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brklevelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rssiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remrssiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbufferDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remnoiseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rxerrorsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localsnrdbDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remotesnrdbDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distRSSIRemainDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packetdropremoteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkqualitygcsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hwvoltageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardvoltageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servovoltageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageflagDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i2cerrorsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timesincelastshotDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressabsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presstempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressabs2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presstemp2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magofsxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magofsyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magofszDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magdeclinationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawpressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawtempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrocalxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrocalyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrocalzDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelcalxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelcalyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelcalzDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateattitudeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratepositionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratestatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratesensorsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratercDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.campointaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campointbDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campointcDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gimbalPointDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gimballatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gimballngDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.terrainactiveDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tercuraltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teraltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terloadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terpendDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terspaceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kIndexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optmxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optmyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optquaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfstatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfflagsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfvelvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfcompvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfposhorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfposvertDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekfteraltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidffDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidaxisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piddesiredDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidachievedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibeclip0DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibeclip1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibeclip2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibeyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibezDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpm1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpm2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capabilitiesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtolstateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landedstateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.contextMenuStripactionstab.SuspendLayout();
            this.tabQuick.SuspendLayout();
            this.tableLayoutPanelQuick.SuspendLayout();
            this.tabActions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).BeginInit();
            this.contextMenuStripQuickView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            resources.ApplyResources(this.hud1, "hud1");
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
            this.tabControlactions.ContextMenuStrip = this.contextMenuStripactionstab;
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
            resources.ApplyResources(this.tabControlactions, "tabControlactions");
            this.tabControlactions.Multiline = true;
            this.tabControlactions.Name = "tabControlactions";
            this.tabControlactions.SelectedIndex = 0;
            this.tabControlactions.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlactions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControlactions.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.tableLayoutPanelQuick.Controls.Add(this.s, 0, 0);
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
            this.tabActions.Controls.Add(this.tableLayoutPanel1);
            this.tabActions.Controls.Add(this.BUT_Homealt);
            this.tabActions.Controls.Add(this.BUT_abortland);
            this.tabActions.Controls.Add(this.BUT_joystick);
            this.tabActions.Controls.Add(this.CMB_mountmode);
            this.tabActions.Controls.Add(this.BUT_mountmode);
            this.tabActions.Controls.Add(this.CMB_action);
            this.tabActions.Controls.Add(this.BUT_RAWSensor);
            this.tabActions.Controls.Add(this.BUTactiondo);
            this.tabActions.Controls.Add(this.modifyandSetLoiterRad);
            this.tabActions.Controls.Add(this.modifyandSetAlt);
            resources.ApplyResources(this.tabActions, "tabActions");
            this.tabActions.Name = "tabActions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblindicadores, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // tableLayoutPanel10
            // 
            resources.ApplyResources(this.tableLayoutPanel10, "tableLayoutPanel10");
            this.tableLayoutPanel10.Controls.Add(this.LBLwp_dist, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.LBLrangefinder1, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.label11, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.LBLgroundspeed, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.LBLDistToHome, 0, 1);
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
            // LBLgroundspeed
            // 
            resources.ApplyResources(this.LBLgroundspeed, "LBLgroundspeed");
            this.LBLgroundspeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(188)))), ((int)(((byte)(224)))));
            this.LBLgroundspeed.Name = "LBLgroundspeed";
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
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.BUT_clear_track, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.BUT_ARM, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
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
            // lblindicadores
            // 
            resources.ApplyResources(this.lblindicadores, "lblindicadores");
            this.lblindicadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(172)))), ((int)(((byte)(24)))));
            this.lblindicadores.Name = "lblindicadores";
            this.lblindicadores.Click += new System.EventHandler(this.lblindicadores_Click);
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
            // BUT_joystick
            // 
            resources.ApplyResources(this.BUT_joystick, "BUT_joystick");
            this.BUT_joystick.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_joystick.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_joystick.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_joystick.Name = "BUT_joystick";
            this.BUT_joystick.TextColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.BUT_joystick, resources.GetString("BUT_joystick.ToolTip"));
            this.BUT_joystick.UseVisualStyleBackColor = true;
            this.BUT_joystick.Click += new System.EventHandler(this.BUT_joystick_Click);
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
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
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
            this.goHereToolStripMenuItem,
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
            // goHereToolStripMenuItem
            // 
            this.goHereToolStripMenuItem.Name = "goHereToolStripMenuItem";
            resources.ApplyResources(this.goHereToolStripMenuItem, "goHereToolStripMenuItem");
            this.goHereToolStripMenuItem.Click += new System.EventHandler(this.goHereToolStripMenuItem_Click);
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
            this.windDir1.Direction = 0D;
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
            this.panel1.Controls.Add(this.comboBoxMapTypeData);
            this.panel1.Controls.Add(this.coords1);
            this.panel1.Controls.Add(this.Zoomlevel);
            this.panel1.Controls.Add(this.CHK_autopan);
            this.panel1.Controls.Add(this.CB_tuning);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parentDataGridViewTextBoxColumn1,
            this.rollDataGridViewTextBoxColumn1,
            this.pitchDataGridViewTextBoxColumn1,
            this.yawDataGridViewTextBoxColumn1,
            this.sSADataGridViewTextBoxColumn1,
            this.aOADataGridViewTextBoxColumn1,
            this.groundcourseDataGridViewTextBoxColumn1,
            this.latDataGridViewTextBoxColumn1,
            this.lngDataGridViewTextBoxColumn1,
            this.altDataGridViewTextBoxColumn1,
            this.altaslDataGridViewTextBoxColumn1,
            this.horizondistDataGridViewTextBoxColumn1,
            this.vxDataGridViewTextBoxColumn1,
            this.vyDataGridViewTextBoxColumn1,
            this.vzDataGridViewTextBoxColumn1,
            this.vlenDataGridViewTextBoxColumn1,
            this.altoffsethomeDataGridViewTextBoxColumn1,
            this.gpsstatusDataGridViewTextBoxColumn1,
            this.gpshdopDataGridViewTextBoxColumn1,
            this.satcountDataGridViewTextBoxColumn1,
            this.gpshaccDataGridViewTextBoxColumn1,
            this.gpsvaccDataGridViewTextBoxColumn1,
            this.gpsvelaccDataGridViewTextBoxColumn1,
            this.gpshdgaccDataGridViewTextBoxColumn1,
            this.lat2DataGridViewTextBoxColumn1,
            this.lng2DataGridViewTextBoxColumn1,
            this.altasl2DataGridViewTextBoxColumn1,
            this.gpsstatus2DataGridViewTextBoxColumn1,
            this.gpshdop2DataGridViewTextBoxColumn1,
            this.satcount2DataGridViewTextBoxColumn1,
            this.groundspeed2DataGridViewTextBoxColumn1,
            this.groundcourse2DataGridViewTextBoxColumn1,
            this.satcountBDataGridViewTextBoxColumn1,
            this.gpstimeDataGridViewTextBoxColumn1,
            this.altd1000DataGridViewTextBoxColumn1,
            this.altd100DataGridViewTextBoxColumn1,
            this.airspeedDataGridViewTextBoxColumn1,
            this.targetairspeedDataGridViewTextBoxColumn1,
            this.lowairspeedDataGridViewCheckBoxColumn1,
            this.asratioDataGridViewTextBoxColumn1,
            this.groundspeedDataGridViewTextBoxColumn1,
            this.axDataGridViewTextBoxColumn1,
            this.ayDataGridViewTextBoxColumn1,
            this.azDataGridViewTextBoxColumn1,
            this.accelsqDataGridViewTextBoxColumn1,
            this.gxDataGridViewTextBoxColumn1,
            this.gyDataGridViewTextBoxColumn1,
            this.gzDataGridViewTextBoxColumn1,
            this.gyrosqDataGridViewTextBoxColumn1,
            this.mxDataGridViewTextBoxColumn1,
            this.myDataGridViewTextBoxColumn1,
            this.mzDataGridViewTextBoxColumn1,
            this.magfieldDataGridViewTextBoxColumn1,
            this.ax2DataGridViewTextBoxColumn1,
            this.ay2DataGridViewTextBoxColumn1,
            this.az2DataGridViewTextBoxColumn1,
            this.accelsq2DataGridViewTextBoxColumn1,
            this.gx2DataGridViewTextBoxColumn1,
            this.gy2DataGridViewTextBoxColumn1,
            this.gz2DataGridViewTextBoxColumn1,
            this.gyrosq2DataGridViewTextBoxColumn1,
            this.mx2DataGridViewTextBoxColumn1,
            this.my2DataGridViewTextBoxColumn1,
            this.mz2DataGridViewTextBoxColumn1,
            this.magfield2DataGridViewTextBoxColumn1,
            this.ax3DataGridViewTextBoxColumn1,
            this.ay3DataGridViewTextBoxColumn1,
            this.az3DataGridViewTextBoxColumn1,
            this.accelsq3DataGridViewTextBoxColumn1,
            this.gx3DataGridViewTextBoxColumn1,
            this.gy3DataGridViewTextBoxColumn1,
            this.gz3DataGridViewTextBoxColumn1,
            this.gyrosq3DataGridViewTextBoxColumn1,
            this.mx3DataGridViewTextBoxColumn1,
            this.my3DataGridViewTextBoxColumn1,
            this.mz3DataGridViewTextBoxColumn1,
            this.magfield3DataGridViewTextBoxColumn1,
            this.ch1inDataGridViewTextBoxColumn1,
            this.ch2inDataGridViewTextBoxColumn1,
            this.ch3inDataGridViewTextBoxColumn1,
            this.ch4inDataGridViewTextBoxColumn1,
            this.ch5inDataGridViewTextBoxColumn1,
            this.ch6inDataGridViewTextBoxColumn1,
            this.ch7inDataGridViewTextBoxColumn1,
            this.ch8inDataGridViewTextBoxColumn1,
            this.ch9inDataGridViewTextBoxColumn1,
            this.ch10inDataGridViewTextBoxColumn1,
            this.ch11inDataGridViewTextBoxColumn1,
            this.ch12inDataGridViewTextBoxColumn1,
            this.ch13inDataGridViewTextBoxColumn1,
            this.ch14inDataGridViewTextBoxColumn1,
            this.ch15inDataGridViewTextBoxColumn1,
            this.ch16inDataGridViewTextBoxColumn1,
            this.ch1outDataGridViewTextBoxColumn1,
            this.ch2outDataGridViewTextBoxColumn1,
            this.ch3outDataGridViewTextBoxColumn1,
            this.ch4outDataGridViewTextBoxColumn1,
            this.ch5outDataGridViewTextBoxColumn1,
            this.ch6outDataGridViewTextBoxColumn1,
            this.ch7outDataGridViewTextBoxColumn1,
            this.ch8outDataGridViewTextBoxColumn1,
            this.ch9outDataGridViewTextBoxColumn1,
            this.ch10outDataGridViewTextBoxColumn1,
            this.ch11outDataGridViewTextBoxColumn1,
            this.ch12outDataGridViewTextBoxColumn1,
            this.ch13outDataGridViewTextBoxColumn1,
            this.ch14outDataGridViewTextBoxColumn1,
            this.ch15outDataGridViewTextBoxColumn1,
            this.ch16outDataGridViewTextBoxColumn1,
            this.esc1voltDataGridViewTextBoxColumn1,
            this.esc1currDataGridViewTextBoxColumn1,
            this.esc1rpmDataGridViewTextBoxColumn1,
            this.esc1tempDataGridViewTextBoxColumn1,
            this.esc2voltDataGridViewTextBoxColumn1,
            this.esc2currDataGridViewTextBoxColumn1,
            this.esc2rpmDataGridViewTextBoxColumn1,
            this.esc2tempDataGridViewTextBoxColumn1,
            this.esc3voltDataGridViewTextBoxColumn1,
            this.esc3currDataGridViewTextBoxColumn1,
            this.esc3rpmDataGridViewTextBoxColumn1,
            this.esc3tempDataGridViewTextBoxColumn1,
            this.esc4voltDataGridViewTextBoxColumn1,
            this.esc4currDataGridViewTextBoxColumn1,
            this.esc4rpmDataGridViewTextBoxColumn1,
            this.esc4tempDataGridViewTextBoxColumn1,
            this.esc5voltDataGridViewTextBoxColumn1,
            this.esc5currDataGridViewTextBoxColumn1,
            this.esc5rpmDataGridViewTextBoxColumn1,
            this.esc5tempDataGridViewTextBoxColumn1,
            this.esc6voltDataGridViewTextBoxColumn1,
            this.esc6currDataGridViewTextBoxColumn1,
            this.esc6rpmDataGridViewTextBoxColumn1,
            this.esc6tempDataGridViewTextBoxColumn1,
            this.esc7voltDataGridViewTextBoxColumn1,
            this.esc7currDataGridViewTextBoxColumn1,
            this.esc7rpmDataGridViewTextBoxColumn1,
            this.esc7tempDataGridViewTextBoxColumn1,
            this.esc8voltDataGridViewTextBoxColumn1,
            this.esc8currDataGridViewTextBoxColumn1,
            this.esc8rpmDataGridViewTextBoxColumn1,
            this.esc8tempDataGridViewTextBoxColumn1,
            this.ch3percentDataGridViewTextBoxColumn1,
            this.failsafeDataGridViewCheckBoxColumn1,
            this.rxrssiDataGridViewTextBoxColumn1,
            this.critAOADataGridViewTextBoxColumn1,
            this.lowgroundspeedDataGridViewCheckBoxColumn1,
            this.verticalspeedDataGridViewTextBoxColumn1,
            this.verticalspeedfpmDataGridViewTextBoxColumn1,
            this.glideratioDataGridViewTextBoxColumn1,
            this.navrollDataGridViewTextBoxColumn1,
            this.navpitchDataGridViewTextBoxColumn1,
            this.navbearingDataGridViewTextBoxColumn1,
            this.targetbearingDataGridViewTextBoxColumn1,
            this.wpdistDataGridViewTextBoxColumn1,
            this.alterrorDataGridViewTextBoxColumn1,
            this.bererrorDataGridViewTextBoxColumn1,
            this.aspderrorDataGridViewTextBoxColumn1,
            this.xtrackerrorDataGridViewTextBoxColumn1,
            this.wpnoDataGridViewTextBoxColumn1,
            this.modeDataGridViewTextBoxColumn1,
            this.climbrateDataGridViewTextBoxColumn1,
            this.totDataGridViewTextBoxColumn1,
            this.tohDataGridViewTextBoxColumn1,
            this.distTraveledDataGridViewTextBoxColumn1,
            this.timeSinceArmInAirDataGridViewTextBoxColumn1,
            this.timeInAirDataGridViewTextBoxColumn1,
            this.timeInAirMinSecDataGridViewTextBoxColumn1,
            this.turnrateDataGridViewTextBoxColumn1,
            this.turngDataGridViewTextBoxColumn1,
            this.radiusDataGridViewTextBoxColumn1,
            this.qNHDataGridViewTextBoxColumn1,
            this.winddirDataGridViewTextBoxColumn1,
            this.windvelDataGridViewTextBoxColumn1,
            this.targetaltd100DataGridViewTextBoxColumn1,
            this.targetaltDataGridViewTextBoxColumn1,
            this.messageDataGridViewTextBoxColumn1,
            this.messageHighDataGridViewTextBoxColumn1,
            this.messageHighTimeDataGridViewTextBoxColumn1,
            this.batteryvoltageDataGridViewTextBoxColumn1,
            this.batteryvoltage3DataGridViewTextBoxColumn1,
            this.batteryvoltage4DataGridViewTextBoxColumn1,
            this.batteryvoltage5DataGridViewTextBoxColumn1,
            this.batteryvoltage6DataGridViewTextBoxColumn1,
            this.batteryvoltage7DataGridViewTextBoxColumn1,
            this.batteryvoltage8DataGridViewTextBoxColumn1,
            this.batteryremainingDataGridViewTextBoxColumn1,
            this.batteryremaining2DataGridViewTextBoxColumn1,
            this.batteryremaining3DataGridViewTextBoxColumn1,
            this.batteryremaining4DataGridViewTextBoxColumn1,
            this.batteryremaining5DataGridViewTextBoxColumn1,
            this.batteryremaining6DataGridViewTextBoxColumn1,
            this.batteryremaining7DataGridViewTextBoxColumn1,
            this.batteryremaining8DataGridViewTextBoxColumn1,
            this.currentDataGridViewTextBoxColumn1,
            this.current2DataGridViewTextBoxColumn1,
            this.current3DataGridViewTextBoxColumn1,
            this.current4DataGridViewTextBoxColumn1,
            this.current5DataGridViewTextBoxColumn1,
            this.current6DataGridViewTextBoxColumn1,
            this.current7DataGridViewTextBoxColumn1,
            this.current8DataGridViewTextBoxColumn1,
            this.wattsDataGridViewTextBoxColumn1,
            this.batterymahperkmDataGridViewTextBoxColumn1,
            this.batterykmleftDataGridViewTextBoxColumn1,
            this.batteryusedmahDataGridViewTextBoxColumn1,
            this.batterycell1DataGridViewTextBoxColumn1,
            this.batterycell2DataGridViewTextBoxColumn1,
            this.batterycell3DataGridViewTextBoxColumn1,
            this.batterycell4DataGridViewTextBoxColumn1,
            this.batterycell5DataGridViewTextBoxColumn1,
            this.batterycell6DataGridViewTextBoxColumn1,
            this.batterytempDataGridViewTextBoxColumn1,
            this.batteryusedmah2DataGridViewTextBoxColumn1,
            this.batteryusedmah3DataGridViewTextBoxColumn1,
            this.batteryusedmah4DataGridViewTextBoxColumn1,
            this.batteryusedmah5DataGridViewTextBoxColumn1,
            this.batteryusedmah6DataGridViewTextBoxColumn1,
            this.batteryusedmah7DataGridViewTextBoxColumn1,
            this.batteryusedmah8DataGridViewTextBoxColumn1,
            this.batteryvoltage2DataGridViewTextBoxColumn1,
            this.homeAltDataGridViewTextBoxColumn1,
            this.homeLocationDataGridViewTextBoxColumn1,
            this.movingBaseDataGridViewTextBoxColumn1,
            this.trackerLocationDataGridViewTextBoxColumn1,
            this.locationDataGridViewTextBoxColumn1,
            this.targetLocationDataGridViewTextBoxColumn1,
            this.distToHomeDataGridViewTextBoxColumn1,
            this.distFromMovingBaseDataGridViewTextBoxColumn1,
            this.eLToMAVDataGridViewTextBoxColumn1,
            this.aZToMAVDataGridViewTextBoxColumn1,
            this.sonarrangeDataGridViewTextBoxColumn1,
            this.sonarvoltageDataGridViewTextBoxColumn1,
            this.rangefinder1DataGridViewTextBoxColumn1,
            this.rangefinder2DataGridViewTextBoxColumn1,
            this.rangefinder3DataGridViewTextBoxColumn1,
            this.freememDataGridViewTextBoxColumn1,
            this.loadDataGridViewTextBoxColumn1,
            this.brklevelDataGridViewTextBoxColumn1,
            this.armedDataGridViewCheckBoxColumn1,
            this.rssiDataGridViewTextBoxColumn1,
            this.remrssiDataGridViewTextBoxColumn1,
            this.txbufferDataGridViewTextBoxColumn1,
            this.noiseDataGridViewTextBoxColumn1,
            this.remnoiseDataGridViewTextBoxColumn1,
            this.rxerrorsDataGridViewTextBoxColumn1,
            this.fixedpDataGridViewTextBoxColumn1,
            this.localsnrdbDataGridViewTextBoxColumn1,
            this.remotesnrdbDataGridViewTextBoxColumn1,
            this.distRSSIRemainDataGridViewTextBoxColumn1,
            this.packetdropremoteDataGridViewTextBoxColumn1,
            this.linkqualitygcsDataGridViewTextBoxColumn1,
            this.hwvoltageDataGridViewTextBoxColumn1,
            this.boardvoltageDataGridViewTextBoxColumn1,
            this.servovoltageDataGridViewTextBoxColumn1,
            this.voltageflagDataGridViewTextBoxColumn1,
            this.i2cerrorsDataGridViewTextBoxColumn1,
            this.timesincelastshotDataGridViewTextBoxColumn1,
            this.pressabsDataGridViewTextBoxColumn1,
            this.presstempDataGridViewTextBoxColumn1,
            this.pressabs2DataGridViewTextBoxColumn1,
            this.presstemp2DataGridViewTextBoxColumn1,
            this.magofsxDataGridViewTextBoxColumn1,
            this.magofsyDataGridViewTextBoxColumn1,
            this.magofszDataGridViewTextBoxColumn1,
            this.magdeclinationDataGridViewTextBoxColumn1,
            this.rawpressDataGridViewTextBoxColumn1,
            this.rawtempDataGridViewTextBoxColumn1,
            this.gyrocalxDataGridViewTextBoxColumn1,
            this.gyrocalyDataGridViewTextBoxColumn1,
            this.gyrocalzDataGridViewTextBoxColumn1,
            this.accelcalxDataGridViewTextBoxColumn1,
            this.accelcalyDataGridViewTextBoxColumn1,
            this.accelcalzDataGridViewTextBoxColumn1,
            this.rateattitudeDataGridViewTextBoxColumn1,
            this.ratepositionDataGridViewTextBoxColumn1,
            this.ratestatusDataGridViewTextBoxColumn1,
            this.ratesensorsDataGridViewTextBoxColumn1,
            this.ratercDataGridViewTextBoxColumn1,
            this.datetimeDataGridViewTextBoxColumn1,
            this.connectedDataGridViewCheckBoxColumn1,
            this.campointaDataGridViewTextBoxColumn1,
            this.campointbDataGridViewTextBoxColumn1,
            this.campointcDataGridViewTextBoxColumn1,
            this.gimbalPointDataGridViewTextBoxColumn1,
            this.gimballatDataGridViewTextBoxColumn1,
            this.gimballngDataGridViewTextBoxColumn1,
            this.landedDataGridViewCheckBoxColumn1,
            this.terrainactiveDataGridViewCheckBoxColumn1,
            this.tercuraltDataGridViewTextBoxColumn1,
            this.teraltDataGridViewTextBoxColumn1,
            this.terloadDataGridViewTextBoxColumn1,
            this.terpendDataGridViewTextBoxColumn1,
            this.terspaceDataGridViewTextBoxColumn1,
            this.kIndexDataGridViewTextBoxColumn1,
            this.optmxDataGridViewTextBoxColumn1,
            this.optmyDataGridViewTextBoxColumn1,
            this.optxDataGridViewTextBoxColumn1,
            this.optyDataGridViewTextBoxColumn1,
            this.optquaDataGridViewTextBoxColumn1,
            this.ekfstatusDataGridViewTextBoxColumn1,
            this.ekfflagsDataGridViewTextBoxColumn1,
            this.ekfvelvDataGridViewTextBoxColumn1,
            this.ekfcompvDataGridViewTextBoxColumn1,
            this.ekfposhorDataGridViewTextBoxColumn1,
            this.ekfposvertDataGridViewTextBoxColumn1,
            this.ekfteraltDataGridViewTextBoxColumn1,
            this.pidffDataGridViewTextBoxColumn1,
            this.pidPDataGridViewTextBoxColumn1,
            this.pidIDataGridViewTextBoxColumn1,
            this.pidDDataGridViewTextBoxColumn1,
            this.pidaxisDataGridViewTextBoxColumn1,
            this.piddesiredDataGridViewTextBoxColumn1,
            this.pidachievedDataGridViewTextBoxColumn1,
            this.vibeclip0DataGridViewTextBoxColumn1,
            this.vibeclip1DataGridViewTextBoxColumn1,
            this.vibeclip2DataGridViewTextBoxColumn1,
            this.vibexDataGridViewTextBoxColumn1,
            this.vibeyDataGridViewTextBoxColumn1,
            this.vibezDataGridViewTextBoxColumn1,
            this.versionDataGridViewTextBoxColumn1,
            this.rpm1DataGridViewTextBoxColumn1,
            this.rpm2DataGridViewTextBoxColumn1,
            this.capabilitiesDataGridViewTextBoxColumn1,
            this.speedupDataGridViewTextBoxColumn1,
            this.vtolstateDataGridViewTextBoxColumn1,
            this.landedstateDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bindingSourceHud;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            // 
            // parentDataGridViewTextBoxColumn1
            // 
            this.parentDataGridViewTextBoxColumn1.DataPropertyName = "parent";
            resources.ApplyResources(this.parentDataGridViewTextBoxColumn1, "parentDataGridViewTextBoxColumn1");
            this.parentDataGridViewTextBoxColumn1.Name = "parentDataGridViewTextBoxColumn1";
            // 
            // rollDataGridViewTextBoxColumn1
            // 
            this.rollDataGridViewTextBoxColumn1.DataPropertyName = "roll";
            resources.ApplyResources(this.rollDataGridViewTextBoxColumn1, "rollDataGridViewTextBoxColumn1");
            this.rollDataGridViewTextBoxColumn1.Name = "rollDataGridViewTextBoxColumn1";
            // 
            // pitchDataGridViewTextBoxColumn1
            // 
            this.pitchDataGridViewTextBoxColumn1.DataPropertyName = "pitch";
            resources.ApplyResources(this.pitchDataGridViewTextBoxColumn1, "pitchDataGridViewTextBoxColumn1");
            this.pitchDataGridViewTextBoxColumn1.Name = "pitchDataGridViewTextBoxColumn1";
            // 
            // yawDataGridViewTextBoxColumn1
            // 
            this.yawDataGridViewTextBoxColumn1.DataPropertyName = "yaw";
            resources.ApplyResources(this.yawDataGridViewTextBoxColumn1, "yawDataGridViewTextBoxColumn1");
            this.yawDataGridViewTextBoxColumn1.Name = "yawDataGridViewTextBoxColumn1";
            // 
            // sSADataGridViewTextBoxColumn1
            // 
            this.sSADataGridViewTextBoxColumn1.DataPropertyName = "SSA";
            resources.ApplyResources(this.sSADataGridViewTextBoxColumn1, "sSADataGridViewTextBoxColumn1");
            this.sSADataGridViewTextBoxColumn1.Name = "sSADataGridViewTextBoxColumn1";
            // 
            // aOADataGridViewTextBoxColumn1
            // 
            this.aOADataGridViewTextBoxColumn1.DataPropertyName = "AOA";
            resources.ApplyResources(this.aOADataGridViewTextBoxColumn1, "aOADataGridViewTextBoxColumn1");
            this.aOADataGridViewTextBoxColumn1.Name = "aOADataGridViewTextBoxColumn1";
            // 
            // groundcourseDataGridViewTextBoxColumn1
            // 
            this.groundcourseDataGridViewTextBoxColumn1.DataPropertyName = "groundcourse";
            resources.ApplyResources(this.groundcourseDataGridViewTextBoxColumn1, "groundcourseDataGridViewTextBoxColumn1");
            this.groundcourseDataGridViewTextBoxColumn1.Name = "groundcourseDataGridViewTextBoxColumn1";
            // 
            // latDataGridViewTextBoxColumn1
            // 
            this.latDataGridViewTextBoxColumn1.DataPropertyName = "lat";
            resources.ApplyResources(this.latDataGridViewTextBoxColumn1, "latDataGridViewTextBoxColumn1");
            this.latDataGridViewTextBoxColumn1.Name = "latDataGridViewTextBoxColumn1";
            // 
            // lngDataGridViewTextBoxColumn1
            // 
            this.lngDataGridViewTextBoxColumn1.DataPropertyName = "lng";
            resources.ApplyResources(this.lngDataGridViewTextBoxColumn1, "lngDataGridViewTextBoxColumn1");
            this.lngDataGridViewTextBoxColumn1.Name = "lngDataGridViewTextBoxColumn1";
            // 
            // altDataGridViewTextBoxColumn1
            // 
            this.altDataGridViewTextBoxColumn1.DataPropertyName = "alt";
            resources.ApplyResources(this.altDataGridViewTextBoxColumn1, "altDataGridViewTextBoxColumn1");
            this.altDataGridViewTextBoxColumn1.Name = "altDataGridViewTextBoxColumn1";
            // 
            // altaslDataGridViewTextBoxColumn1
            // 
            this.altaslDataGridViewTextBoxColumn1.DataPropertyName = "altasl";
            resources.ApplyResources(this.altaslDataGridViewTextBoxColumn1, "altaslDataGridViewTextBoxColumn1");
            this.altaslDataGridViewTextBoxColumn1.Name = "altaslDataGridViewTextBoxColumn1";
            // 
            // horizondistDataGridViewTextBoxColumn1
            // 
            this.horizondistDataGridViewTextBoxColumn1.DataPropertyName = "horizondist";
            resources.ApplyResources(this.horizondistDataGridViewTextBoxColumn1, "horizondistDataGridViewTextBoxColumn1");
            this.horizondistDataGridViewTextBoxColumn1.Name = "horizondistDataGridViewTextBoxColumn1";
            this.horizondistDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vxDataGridViewTextBoxColumn1
            // 
            this.vxDataGridViewTextBoxColumn1.DataPropertyName = "vx";
            resources.ApplyResources(this.vxDataGridViewTextBoxColumn1, "vxDataGridViewTextBoxColumn1");
            this.vxDataGridViewTextBoxColumn1.Name = "vxDataGridViewTextBoxColumn1";
            // 
            // vyDataGridViewTextBoxColumn1
            // 
            this.vyDataGridViewTextBoxColumn1.DataPropertyName = "vy";
            resources.ApplyResources(this.vyDataGridViewTextBoxColumn1, "vyDataGridViewTextBoxColumn1");
            this.vyDataGridViewTextBoxColumn1.Name = "vyDataGridViewTextBoxColumn1";
            // 
            // vzDataGridViewTextBoxColumn1
            // 
            this.vzDataGridViewTextBoxColumn1.DataPropertyName = "vz";
            resources.ApplyResources(this.vzDataGridViewTextBoxColumn1, "vzDataGridViewTextBoxColumn1");
            this.vzDataGridViewTextBoxColumn1.Name = "vzDataGridViewTextBoxColumn1";
            // 
            // vlenDataGridViewTextBoxColumn1
            // 
            this.vlenDataGridViewTextBoxColumn1.DataPropertyName = "vlen";
            resources.ApplyResources(this.vlenDataGridViewTextBoxColumn1, "vlenDataGridViewTextBoxColumn1");
            this.vlenDataGridViewTextBoxColumn1.Name = "vlenDataGridViewTextBoxColumn1";
            this.vlenDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // altoffsethomeDataGridViewTextBoxColumn1
            // 
            this.altoffsethomeDataGridViewTextBoxColumn1.DataPropertyName = "altoffsethome";
            resources.ApplyResources(this.altoffsethomeDataGridViewTextBoxColumn1, "altoffsethomeDataGridViewTextBoxColumn1");
            this.altoffsethomeDataGridViewTextBoxColumn1.Name = "altoffsethomeDataGridViewTextBoxColumn1";
            // 
            // gpsstatusDataGridViewTextBoxColumn1
            // 
            this.gpsstatusDataGridViewTextBoxColumn1.DataPropertyName = "gpsstatus";
            resources.ApplyResources(this.gpsstatusDataGridViewTextBoxColumn1, "gpsstatusDataGridViewTextBoxColumn1");
            this.gpsstatusDataGridViewTextBoxColumn1.Name = "gpsstatusDataGridViewTextBoxColumn1";
            // 
            // gpshdopDataGridViewTextBoxColumn1
            // 
            this.gpshdopDataGridViewTextBoxColumn1.DataPropertyName = "gpshdop";
            resources.ApplyResources(this.gpshdopDataGridViewTextBoxColumn1, "gpshdopDataGridViewTextBoxColumn1");
            this.gpshdopDataGridViewTextBoxColumn1.Name = "gpshdopDataGridViewTextBoxColumn1";
            // 
            // satcountDataGridViewTextBoxColumn1
            // 
            this.satcountDataGridViewTextBoxColumn1.DataPropertyName = "satcount";
            resources.ApplyResources(this.satcountDataGridViewTextBoxColumn1, "satcountDataGridViewTextBoxColumn1");
            this.satcountDataGridViewTextBoxColumn1.Name = "satcountDataGridViewTextBoxColumn1";
            // 
            // gpshaccDataGridViewTextBoxColumn1
            // 
            this.gpshaccDataGridViewTextBoxColumn1.DataPropertyName = "gpsh_acc";
            resources.ApplyResources(this.gpshaccDataGridViewTextBoxColumn1, "gpshaccDataGridViewTextBoxColumn1");
            this.gpshaccDataGridViewTextBoxColumn1.Name = "gpshaccDataGridViewTextBoxColumn1";
            this.gpshaccDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gpsvaccDataGridViewTextBoxColumn1
            // 
            this.gpsvaccDataGridViewTextBoxColumn1.DataPropertyName = "gpsv_acc";
            resources.ApplyResources(this.gpsvaccDataGridViewTextBoxColumn1, "gpsvaccDataGridViewTextBoxColumn1");
            this.gpsvaccDataGridViewTextBoxColumn1.Name = "gpsvaccDataGridViewTextBoxColumn1";
            this.gpsvaccDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gpsvelaccDataGridViewTextBoxColumn1
            // 
            this.gpsvelaccDataGridViewTextBoxColumn1.DataPropertyName = "gpsvel_acc";
            resources.ApplyResources(this.gpsvelaccDataGridViewTextBoxColumn1, "gpsvelaccDataGridViewTextBoxColumn1");
            this.gpsvelaccDataGridViewTextBoxColumn1.Name = "gpsvelaccDataGridViewTextBoxColumn1";
            this.gpsvelaccDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gpshdgaccDataGridViewTextBoxColumn1
            // 
            this.gpshdgaccDataGridViewTextBoxColumn1.DataPropertyName = "gpshdg_acc";
            resources.ApplyResources(this.gpshdgaccDataGridViewTextBoxColumn1, "gpshdgaccDataGridViewTextBoxColumn1");
            this.gpshdgaccDataGridViewTextBoxColumn1.Name = "gpshdgaccDataGridViewTextBoxColumn1";
            this.gpshdgaccDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lat2DataGridViewTextBoxColumn1
            // 
            this.lat2DataGridViewTextBoxColumn1.DataPropertyName = "lat2";
            resources.ApplyResources(this.lat2DataGridViewTextBoxColumn1, "lat2DataGridViewTextBoxColumn1");
            this.lat2DataGridViewTextBoxColumn1.Name = "lat2DataGridViewTextBoxColumn1";
            // 
            // lng2DataGridViewTextBoxColumn1
            // 
            this.lng2DataGridViewTextBoxColumn1.DataPropertyName = "lng2";
            resources.ApplyResources(this.lng2DataGridViewTextBoxColumn1, "lng2DataGridViewTextBoxColumn1");
            this.lng2DataGridViewTextBoxColumn1.Name = "lng2DataGridViewTextBoxColumn1";
            // 
            // altasl2DataGridViewTextBoxColumn1
            // 
            this.altasl2DataGridViewTextBoxColumn1.DataPropertyName = "altasl2";
            resources.ApplyResources(this.altasl2DataGridViewTextBoxColumn1, "altasl2DataGridViewTextBoxColumn1");
            this.altasl2DataGridViewTextBoxColumn1.Name = "altasl2DataGridViewTextBoxColumn1";
            // 
            // gpsstatus2DataGridViewTextBoxColumn1
            // 
            this.gpsstatus2DataGridViewTextBoxColumn1.DataPropertyName = "gpsstatus2";
            resources.ApplyResources(this.gpsstatus2DataGridViewTextBoxColumn1, "gpsstatus2DataGridViewTextBoxColumn1");
            this.gpsstatus2DataGridViewTextBoxColumn1.Name = "gpsstatus2DataGridViewTextBoxColumn1";
            // 
            // gpshdop2DataGridViewTextBoxColumn1
            // 
            this.gpshdop2DataGridViewTextBoxColumn1.DataPropertyName = "gpshdop2";
            resources.ApplyResources(this.gpshdop2DataGridViewTextBoxColumn1, "gpshdop2DataGridViewTextBoxColumn1");
            this.gpshdop2DataGridViewTextBoxColumn1.Name = "gpshdop2DataGridViewTextBoxColumn1";
            // 
            // satcount2DataGridViewTextBoxColumn1
            // 
            this.satcount2DataGridViewTextBoxColumn1.DataPropertyName = "satcount2";
            resources.ApplyResources(this.satcount2DataGridViewTextBoxColumn1, "satcount2DataGridViewTextBoxColumn1");
            this.satcount2DataGridViewTextBoxColumn1.Name = "satcount2DataGridViewTextBoxColumn1";
            // 
            // groundspeed2DataGridViewTextBoxColumn1
            // 
            this.groundspeed2DataGridViewTextBoxColumn1.DataPropertyName = "groundspeed2";
            resources.ApplyResources(this.groundspeed2DataGridViewTextBoxColumn1, "groundspeed2DataGridViewTextBoxColumn1");
            this.groundspeed2DataGridViewTextBoxColumn1.Name = "groundspeed2DataGridViewTextBoxColumn1";
            // 
            // groundcourse2DataGridViewTextBoxColumn1
            // 
            this.groundcourse2DataGridViewTextBoxColumn1.DataPropertyName = "groundcourse2";
            resources.ApplyResources(this.groundcourse2DataGridViewTextBoxColumn1, "groundcourse2DataGridViewTextBoxColumn1");
            this.groundcourse2DataGridViewTextBoxColumn1.Name = "groundcourse2DataGridViewTextBoxColumn1";
            // 
            // satcountBDataGridViewTextBoxColumn1
            // 
            this.satcountBDataGridViewTextBoxColumn1.DataPropertyName = "satcountB";
            resources.ApplyResources(this.satcountBDataGridViewTextBoxColumn1, "satcountBDataGridViewTextBoxColumn1");
            this.satcountBDataGridViewTextBoxColumn1.Name = "satcountBDataGridViewTextBoxColumn1";
            this.satcountBDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gpstimeDataGridViewTextBoxColumn1
            // 
            this.gpstimeDataGridViewTextBoxColumn1.DataPropertyName = "gpstime";
            resources.ApplyResources(this.gpstimeDataGridViewTextBoxColumn1, "gpstimeDataGridViewTextBoxColumn1");
            this.gpstimeDataGridViewTextBoxColumn1.Name = "gpstimeDataGridViewTextBoxColumn1";
            // 
            // altd1000DataGridViewTextBoxColumn1
            // 
            this.altd1000DataGridViewTextBoxColumn1.DataPropertyName = "altd1000";
            resources.ApplyResources(this.altd1000DataGridViewTextBoxColumn1, "altd1000DataGridViewTextBoxColumn1");
            this.altd1000DataGridViewTextBoxColumn1.Name = "altd1000DataGridViewTextBoxColumn1";
            this.altd1000DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // altd100DataGridViewTextBoxColumn1
            // 
            this.altd100DataGridViewTextBoxColumn1.DataPropertyName = "altd100";
            resources.ApplyResources(this.altd100DataGridViewTextBoxColumn1, "altd100DataGridViewTextBoxColumn1");
            this.altd100DataGridViewTextBoxColumn1.Name = "altd100DataGridViewTextBoxColumn1";
            this.altd100DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // airspeedDataGridViewTextBoxColumn1
            // 
            this.airspeedDataGridViewTextBoxColumn1.DataPropertyName = "airspeed";
            resources.ApplyResources(this.airspeedDataGridViewTextBoxColumn1, "airspeedDataGridViewTextBoxColumn1");
            this.airspeedDataGridViewTextBoxColumn1.Name = "airspeedDataGridViewTextBoxColumn1";
            // 
            // targetairspeedDataGridViewTextBoxColumn1
            // 
            this.targetairspeedDataGridViewTextBoxColumn1.DataPropertyName = "targetairspeed";
            resources.ApplyResources(this.targetairspeedDataGridViewTextBoxColumn1, "targetairspeedDataGridViewTextBoxColumn1");
            this.targetairspeedDataGridViewTextBoxColumn1.Name = "targetairspeedDataGridViewTextBoxColumn1";
            this.targetairspeedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lowairspeedDataGridViewCheckBoxColumn1
            // 
            this.lowairspeedDataGridViewCheckBoxColumn1.DataPropertyName = "lowairspeed";
            resources.ApplyResources(this.lowairspeedDataGridViewCheckBoxColumn1, "lowairspeedDataGridViewCheckBoxColumn1");
            this.lowairspeedDataGridViewCheckBoxColumn1.Name = "lowairspeedDataGridViewCheckBoxColumn1";
            // 
            // asratioDataGridViewTextBoxColumn1
            // 
            this.asratioDataGridViewTextBoxColumn1.DataPropertyName = "asratio";
            resources.ApplyResources(this.asratioDataGridViewTextBoxColumn1, "asratioDataGridViewTextBoxColumn1");
            this.asratioDataGridViewTextBoxColumn1.Name = "asratioDataGridViewTextBoxColumn1";
            // 
            // groundspeedDataGridViewTextBoxColumn1
            // 
            this.groundspeedDataGridViewTextBoxColumn1.DataPropertyName = "groundspeed";
            resources.ApplyResources(this.groundspeedDataGridViewTextBoxColumn1, "groundspeedDataGridViewTextBoxColumn1");
            this.groundspeedDataGridViewTextBoxColumn1.Name = "groundspeedDataGridViewTextBoxColumn1";
            // 
            // axDataGridViewTextBoxColumn1
            // 
            this.axDataGridViewTextBoxColumn1.DataPropertyName = "ax";
            resources.ApplyResources(this.axDataGridViewTextBoxColumn1, "axDataGridViewTextBoxColumn1");
            this.axDataGridViewTextBoxColumn1.Name = "axDataGridViewTextBoxColumn1";
            // 
            // ayDataGridViewTextBoxColumn1
            // 
            this.ayDataGridViewTextBoxColumn1.DataPropertyName = "ay";
            resources.ApplyResources(this.ayDataGridViewTextBoxColumn1, "ayDataGridViewTextBoxColumn1");
            this.ayDataGridViewTextBoxColumn1.Name = "ayDataGridViewTextBoxColumn1";
            // 
            // azDataGridViewTextBoxColumn1
            // 
            this.azDataGridViewTextBoxColumn1.DataPropertyName = "az";
            resources.ApplyResources(this.azDataGridViewTextBoxColumn1, "azDataGridViewTextBoxColumn1");
            this.azDataGridViewTextBoxColumn1.Name = "azDataGridViewTextBoxColumn1";
            // 
            // accelsqDataGridViewTextBoxColumn1
            // 
            this.accelsqDataGridViewTextBoxColumn1.DataPropertyName = "accelsq";
            resources.ApplyResources(this.accelsqDataGridViewTextBoxColumn1, "accelsqDataGridViewTextBoxColumn1");
            this.accelsqDataGridViewTextBoxColumn1.Name = "accelsqDataGridViewTextBoxColumn1";
            this.accelsqDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gxDataGridViewTextBoxColumn1
            // 
            this.gxDataGridViewTextBoxColumn1.DataPropertyName = "gx";
            resources.ApplyResources(this.gxDataGridViewTextBoxColumn1, "gxDataGridViewTextBoxColumn1");
            this.gxDataGridViewTextBoxColumn1.Name = "gxDataGridViewTextBoxColumn1";
            // 
            // gyDataGridViewTextBoxColumn1
            // 
            this.gyDataGridViewTextBoxColumn1.DataPropertyName = "gy";
            resources.ApplyResources(this.gyDataGridViewTextBoxColumn1, "gyDataGridViewTextBoxColumn1");
            this.gyDataGridViewTextBoxColumn1.Name = "gyDataGridViewTextBoxColumn1";
            // 
            // gzDataGridViewTextBoxColumn1
            // 
            this.gzDataGridViewTextBoxColumn1.DataPropertyName = "gz";
            resources.ApplyResources(this.gzDataGridViewTextBoxColumn1, "gzDataGridViewTextBoxColumn1");
            this.gzDataGridViewTextBoxColumn1.Name = "gzDataGridViewTextBoxColumn1";
            // 
            // gyrosqDataGridViewTextBoxColumn1
            // 
            this.gyrosqDataGridViewTextBoxColumn1.DataPropertyName = "gyrosq";
            resources.ApplyResources(this.gyrosqDataGridViewTextBoxColumn1, "gyrosqDataGridViewTextBoxColumn1");
            this.gyrosqDataGridViewTextBoxColumn1.Name = "gyrosqDataGridViewTextBoxColumn1";
            this.gyrosqDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mxDataGridViewTextBoxColumn1
            // 
            this.mxDataGridViewTextBoxColumn1.DataPropertyName = "mx";
            resources.ApplyResources(this.mxDataGridViewTextBoxColumn1, "mxDataGridViewTextBoxColumn1");
            this.mxDataGridViewTextBoxColumn1.Name = "mxDataGridViewTextBoxColumn1";
            // 
            // myDataGridViewTextBoxColumn1
            // 
            this.myDataGridViewTextBoxColumn1.DataPropertyName = "my";
            resources.ApplyResources(this.myDataGridViewTextBoxColumn1, "myDataGridViewTextBoxColumn1");
            this.myDataGridViewTextBoxColumn1.Name = "myDataGridViewTextBoxColumn1";
            // 
            // mzDataGridViewTextBoxColumn1
            // 
            this.mzDataGridViewTextBoxColumn1.DataPropertyName = "mz";
            resources.ApplyResources(this.mzDataGridViewTextBoxColumn1, "mzDataGridViewTextBoxColumn1");
            this.mzDataGridViewTextBoxColumn1.Name = "mzDataGridViewTextBoxColumn1";
            // 
            // magfieldDataGridViewTextBoxColumn1
            // 
            this.magfieldDataGridViewTextBoxColumn1.DataPropertyName = "magfield";
            resources.ApplyResources(this.magfieldDataGridViewTextBoxColumn1, "magfieldDataGridViewTextBoxColumn1");
            this.magfieldDataGridViewTextBoxColumn1.Name = "magfieldDataGridViewTextBoxColumn1";
            this.magfieldDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ax2DataGridViewTextBoxColumn1
            // 
            this.ax2DataGridViewTextBoxColumn1.DataPropertyName = "ax2";
            resources.ApplyResources(this.ax2DataGridViewTextBoxColumn1, "ax2DataGridViewTextBoxColumn1");
            this.ax2DataGridViewTextBoxColumn1.Name = "ax2DataGridViewTextBoxColumn1";
            // 
            // ay2DataGridViewTextBoxColumn1
            // 
            this.ay2DataGridViewTextBoxColumn1.DataPropertyName = "ay2";
            resources.ApplyResources(this.ay2DataGridViewTextBoxColumn1, "ay2DataGridViewTextBoxColumn1");
            this.ay2DataGridViewTextBoxColumn1.Name = "ay2DataGridViewTextBoxColumn1";
            // 
            // az2DataGridViewTextBoxColumn1
            // 
            this.az2DataGridViewTextBoxColumn1.DataPropertyName = "az2";
            resources.ApplyResources(this.az2DataGridViewTextBoxColumn1, "az2DataGridViewTextBoxColumn1");
            this.az2DataGridViewTextBoxColumn1.Name = "az2DataGridViewTextBoxColumn1";
            // 
            // accelsq2DataGridViewTextBoxColumn1
            // 
            this.accelsq2DataGridViewTextBoxColumn1.DataPropertyName = "accelsq2";
            resources.ApplyResources(this.accelsq2DataGridViewTextBoxColumn1, "accelsq2DataGridViewTextBoxColumn1");
            this.accelsq2DataGridViewTextBoxColumn1.Name = "accelsq2DataGridViewTextBoxColumn1";
            this.accelsq2DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gx2DataGridViewTextBoxColumn1
            // 
            this.gx2DataGridViewTextBoxColumn1.DataPropertyName = "gx2";
            resources.ApplyResources(this.gx2DataGridViewTextBoxColumn1, "gx2DataGridViewTextBoxColumn1");
            this.gx2DataGridViewTextBoxColumn1.Name = "gx2DataGridViewTextBoxColumn1";
            // 
            // gy2DataGridViewTextBoxColumn1
            // 
            this.gy2DataGridViewTextBoxColumn1.DataPropertyName = "gy2";
            resources.ApplyResources(this.gy2DataGridViewTextBoxColumn1, "gy2DataGridViewTextBoxColumn1");
            this.gy2DataGridViewTextBoxColumn1.Name = "gy2DataGridViewTextBoxColumn1";
            // 
            // gz2DataGridViewTextBoxColumn1
            // 
            this.gz2DataGridViewTextBoxColumn1.DataPropertyName = "gz2";
            resources.ApplyResources(this.gz2DataGridViewTextBoxColumn1, "gz2DataGridViewTextBoxColumn1");
            this.gz2DataGridViewTextBoxColumn1.Name = "gz2DataGridViewTextBoxColumn1";
            // 
            // gyrosq2DataGridViewTextBoxColumn1
            // 
            this.gyrosq2DataGridViewTextBoxColumn1.DataPropertyName = "gyrosq2";
            resources.ApplyResources(this.gyrosq2DataGridViewTextBoxColumn1, "gyrosq2DataGridViewTextBoxColumn1");
            this.gyrosq2DataGridViewTextBoxColumn1.Name = "gyrosq2DataGridViewTextBoxColumn1";
            this.gyrosq2DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mx2DataGridViewTextBoxColumn1
            // 
            this.mx2DataGridViewTextBoxColumn1.DataPropertyName = "mx2";
            resources.ApplyResources(this.mx2DataGridViewTextBoxColumn1, "mx2DataGridViewTextBoxColumn1");
            this.mx2DataGridViewTextBoxColumn1.Name = "mx2DataGridViewTextBoxColumn1";
            // 
            // my2DataGridViewTextBoxColumn1
            // 
            this.my2DataGridViewTextBoxColumn1.DataPropertyName = "my2";
            resources.ApplyResources(this.my2DataGridViewTextBoxColumn1, "my2DataGridViewTextBoxColumn1");
            this.my2DataGridViewTextBoxColumn1.Name = "my2DataGridViewTextBoxColumn1";
            // 
            // mz2DataGridViewTextBoxColumn1
            // 
            this.mz2DataGridViewTextBoxColumn1.DataPropertyName = "mz2";
            resources.ApplyResources(this.mz2DataGridViewTextBoxColumn1, "mz2DataGridViewTextBoxColumn1");
            this.mz2DataGridViewTextBoxColumn1.Name = "mz2DataGridViewTextBoxColumn1";
            // 
            // magfield2DataGridViewTextBoxColumn1
            // 
            this.magfield2DataGridViewTextBoxColumn1.DataPropertyName = "magfield2";
            resources.ApplyResources(this.magfield2DataGridViewTextBoxColumn1, "magfield2DataGridViewTextBoxColumn1");
            this.magfield2DataGridViewTextBoxColumn1.Name = "magfield2DataGridViewTextBoxColumn1";
            this.magfield2DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ax3DataGridViewTextBoxColumn1
            // 
            this.ax3DataGridViewTextBoxColumn1.DataPropertyName = "ax3";
            resources.ApplyResources(this.ax3DataGridViewTextBoxColumn1, "ax3DataGridViewTextBoxColumn1");
            this.ax3DataGridViewTextBoxColumn1.Name = "ax3DataGridViewTextBoxColumn1";
            // 
            // ay3DataGridViewTextBoxColumn1
            // 
            this.ay3DataGridViewTextBoxColumn1.DataPropertyName = "ay3";
            resources.ApplyResources(this.ay3DataGridViewTextBoxColumn1, "ay3DataGridViewTextBoxColumn1");
            this.ay3DataGridViewTextBoxColumn1.Name = "ay3DataGridViewTextBoxColumn1";
            // 
            // az3DataGridViewTextBoxColumn1
            // 
            this.az3DataGridViewTextBoxColumn1.DataPropertyName = "az3";
            resources.ApplyResources(this.az3DataGridViewTextBoxColumn1, "az3DataGridViewTextBoxColumn1");
            this.az3DataGridViewTextBoxColumn1.Name = "az3DataGridViewTextBoxColumn1";
            // 
            // accelsq3DataGridViewTextBoxColumn1
            // 
            this.accelsq3DataGridViewTextBoxColumn1.DataPropertyName = "accelsq3";
            resources.ApplyResources(this.accelsq3DataGridViewTextBoxColumn1, "accelsq3DataGridViewTextBoxColumn1");
            this.accelsq3DataGridViewTextBoxColumn1.Name = "accelsq3DataGridViewTextBoxColumn1";
            this.accelsq3DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gx3DataGridViewTextBoxColumn1
            // 
            this.gx3DataGridViewTextBoxColumn1.DataPropertyName = "gx3";
            resources.ApplyResources(this.gx3DataGridViewTextBoxColumn1, "gx3DataGridViewTextBoxColumn1");
            this.gx3DataGridViewTextBoxColumn1.Name = "gx3DataGridViewTextBoxColumn1";
            // 
            // gy3DataGridViewTextBoxColumn1
            // 
            this.gy3DataGridViewTextBoxColumn1.DataPropertyName = "gy3";
            resources.ApplyResources(this.gy3DataGridViewTextBoxColumn1, "gy3DataGridViewTextBoxColumn1");
            this.gy3DataGridViewTextBoxColumn1.Name = "gy3DataGridViewTextBoxColumn1";
            // 
            // gz3DataGridViewTextBoxColumn1
            // 
            this.gz3DataGridViewTextBoxColumn1.DataPropertyName = "gz3";
            resources.ApplyResources(this.gz3DataGridViewTextBoxColumn1, "gz3DataGridViewTextBoxColumn1");
            this.gz3DataGridViewTextBoxColumn1.Name = "gz3DataGridViewTextBoxColumn1";
            // 
            // gyrosq3DataGridViewTextBoxColumn1
            // 
            this.gyrosq3DataGridViewTextBoxColumn1.DataPropertyName = "gyrosq3";
            resources.ApplyResources(this.gyrosq3DataGridViewTextBoxColumn1, "gyrosq3DataGridViewTextBoxColumn1");
            this.gyrosq3DataGridViewTextBoxColumn1.Name = "gyrosq3DataGridViewTextBoxColumn1";
            this.gyrosq3DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mx3DataGridViewTextBoxColumn1
            // 
            this.mx3DataGridViewTextBoxColumn1.DataPropertyName = "mx3";
            resources.ApplyResources(this.mx3DataGridViewTextBoxColumn1, "mx3DataGridViewTextBoxColumn1");
            this.mx3DataGridViewTextBoxColumn1.Name = "mx3DataGridViewTextBoxColumn1";
            // 
            // my3DataGridViewTextBoxColumn1
            // 
            this.my3DataGridViewTextBoxColumn1.DataPropertyName = "my3";
            resources.ApplyResources(this.my3DataGridViewTextBoxColumn1, "my3DataGridViewTextBoxColumn1");
            this.my3DataGridViewTextBoxColumn1.Name = "my3DataGridViewTextBoxColumn1";
            // 
            // mz3DataGridViewTextBoxColumn1
            // 
            this.mz3DataGridViewTextBoxColumn1.DataPropertyName = "mz3";
            resources.ApplyResources(this.mz3DataGridViewTextBoxColumn1, "mz3DataGridViewTextBoxColumn1");
            this.mz3DataGridViewTextBoxColumn1.Name = "mz3DataGridViewTextBoxColumn1";
            // 
            // magfield3DataGridViewTextBoxColumn1
            // 
            this.magfield3DataGridViewTextBoxColumn1.DataPropertyName = "magfield3";
            resources.ApplyResources(this.magfield3DataGridViewTextBoxColumn1, "magfield3DataGridViewTextBoxColumn1");
            this.magfield3DataGridViewTextBoxColumn1.Name = "magfield3DataGridViewTextBoxColumn1";
            this.magfield3DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ch1inDataGridViewTextBoxColumn1
            // 
            this.ch1inDataGridViewTextBoxColumn1.DataPropertyName = "ch1in";
            resources.ApplyResources(this.ch1inDataGridViewTextBoxColumn1, "ch1inDataGridViewTextBoxColumn1");
            this.ch1inDataGridViewTextBoxColumn1.Name = "ch1inDataGridViewTextBoxColumn1";
            // 
            // ch2inDataGridViewTextBoxColumn1
            // 
            this.ch2inDataGridViewTextBoxColumn1.DataPropertyName = "ch2in";
            resources.ApplyResources(this.ch2inDataGridViewTextBoxColumn1, "ch2inDataGridViewTextBoxColumn1");
            this.ch2inDataGridViewTextBoxColumn1.Name = "ch2inDataGridViewTextBoxColumn1";
            // 
            // ch3inDataGridViewTextBoxColumn1
            // 
            this.ch3inDataGridViewTextBoxColumn1.DataPropertyName = "ch3in";
            resources.ApplyResources(this.ch3inDataGridViewTextBoxColumn1, "ch3inDataGridViewTextBoxColumn1");
            this.ch3inDataGridViewTextBoxColumn1.Name = "ch3inDataGridViewTextBoxColumn1";
            // 
            // ch4inDataGridViewTextBoxColumn1
            // 
            this.ch4inDataGridViewTextBoxColumn1.DataPropertyName = "ch4in";
            resources.ApplyResources(this.ch4inDataGridViewTextBoxColumn1, "ch4inDataGridViewTextBoxColumn1");
            this.ch4inDataGridViewTextBoxColumn1.Name = "ch4inDataGridViewTextBoxColumn1";
            // 
            // ch5inDataGridViewTextBoxColumn1
            // 
            this.ch5inDataGridViewTextBoxColumn1.DataPropertyName = "ch5in";
            resources.ApplyResources(this.ch5inDataGridViewTextBoxColumn1, "ch5inDataGridViewTextBoxColumn1");
            this.ch5inDataGridViewTextBoxColumn1.Name = "ch5inDataGridViewTextBoxColumn1";
            // 
            // ch6inDataGridViewTextBoxColumn1
            // 
            this.ch6inDataGridViewTextBoxColumn1.DataPropertyName = "ch6in";
            resources.ApplyResources(this.ch6inDataGridViewTextBoxColumn1, "ch6inDataGridViewTextBoxColumn1");
            this.ch6inDataGridViewTextBoxColumn1.Name = "ch6inDataGridViewTextBoxColumn1";
            // 
            // ch7inDataGridViewTextBoxColumn1
            // 
            this.ch7inDataGridViewTextBoxColumn1.DataPropertyName = "ch7in";
            resources.ApplyResources(this.ch7inDataGridViewTextBoxColumn1, "ch7inDataGridViewTextBoxColumn1");
            this.ch7inDataGridViewTextBoxColumn1.Name = "ch7inDataGridViewTextBoxColumn1";
            // 
            // ch8inDataGridViewTextBoxColumn1
            // 
            this.ch8inDataGridViewTextBoxColumn1.DataPropertyName = "ch8in";
            resources.ApplyResources(this.ch8inDataGridViewTextBoxColumn1, "ch8inDataGridViewTextBoxColumn1");
            this.ch8inDataGridViewTextBoxColumn1.Name = "ch8inDataGridViewTextBoxColumn1";
            // 
            // ch9inDataGridViewTextBoxColumn1
            // 
            this.ch9inDataGridViewTextBoxColumn1.DataPropertyName = "ch9in";
            resources.ApplyResources(this.ch9inDataGridViewTextBoxColumn1, "ch9inDataGridViewTextBoxColumn1");
            this.ch9inDataGridViewTextBoxColumn1.Name = "ch9inDataGridViewTextBoxColumn1";
            // 
            // ch10inDataGridViewTextBoxColumn1
            // 
            this.ch10inDataGridViewTextBoxColumn1.DataPropertyName = "ch10in";
            resources.ApplyResources(this.ch10inDataGridViewTextBoxColumn1, "ch10inDataGridViewTextBoxColumn1");
            this.ch10inDataGridViewTextBoxColumn1.Name = "ch10inDataGridViewTextBoxColumn1";
            // 
            // ch11inDataGridViewTextBoxColumn1
            // 
            this.ch11inDataGridViewTextBoxColumn1.DataPropertyName = "ch11in";
            resources.ApplyResources(this.ch11inDataGridViewTextBoxColumn1, "ch11inDataGridViewTextBoxColumn1");
            this.ch11inDataGridViewTextBoxColumn1.Name = "ch11inDataGridViewTextBoxColumn1";
            // 
            // ch12inDataGridViewTextBoxColumn1
            // 
            this.ch12inDataGridViewTextBoxColumn1.DataPropertyName = "ch12in";
            resources.ApplyResources(this.ch12inDataGridViewTextBoxColumn1, "ch12inDataGridViewTextBoxColumn1");
            this.ch12inDataGridViewTextBoxColumn1.Name = "ch12inDataGridViewTextBoxColumn1";
            // 
            // ch13inDataGridViewTextBoxColumn1
            // 
            this.ch13inDataGridViewTextBoxColumn1.DataPropertyName = "ch13in";
            resources.ApplyResources(this.ch13inDataGridViewTextBoxColumn1, "ch13inDataGridViewTextBoxColumn1");
            this.ch13inDataGridViewTextBoxColumn1.Name = "ch13inDataGridViewTextBoxColumn1";
            // 
            // ch14inDataGridViewTextBoxColumn1
            // 
            this.ch14inDataGridViewTextBoxColumn1.DataPropertyName = "ch14in";
            resources.ApplyResources(this.ch14inDataGridViewTextBoxColumn1, "ch14inDataGridViewTextBoxColumn1");
            this.ch14inDataGridViewTextBoxColumn1.Name = "ch14inDataGridViewTextBoxColumn1";
            // 
            // ch15inDataGridViewTextBoxColumn1
            // 
            this.ch15inDataGridViewTextBoxColumn1.DataPropertyName = "ch15in";
            resources.ApplyResources(this.ch15inDataGridViewTextBoxColumn1, "ch15inDataGridViewTextBoxColumn1");
            this.ch15inDataGridViewTextBoxColumn1.Name = "ch15inDataGridViewTextBoxColumn1";
            // 
            // ch16inDataGridViewTextBoxColumn1
            // 
            this.ch16inDataGridViewTextBoxColumn1.DataPropertyName = "ch16in";
            resources.ApplyResources(this.ch16inDataGridViewTextBoxColumn1, "ch16inDataGridViewTextBoxColumn1");
            this.ch16inDataGridViewTextBoxColumn1.Name = "ch16inDataGridViewTextBoxColumn1";
            // 
            // ch1outDataGridViewTextBoxColumn1
            // 
            this.ch1outDataGridViewTextBoxColumn1.DataPropertyName = "ch1out";
            resources.ApplyResources(this.ch1outDataGridViewTextBoxColumn1, "ch1outDataGridViewTextBoxColumn1");
            this.ch1outDataGridViewTextBoxColumn1.Name = "ch1outDataGridViewTextBoxColumn1";
            // 
            // ch2outDataGridViewTextBoxColumn1
            // 
            this.ch2outDataGridViewTextBoxColumn1.DataPropertyName = "ch2out";
            resources.ApplyResources(this.ch2outDataGridViewTextBoxColumn1, "ch2outDataGridViewTextBoxColumn1");
            this.ch2outDataGridViewTextBoxColumn1.Name = "ch2outDataGridViewTextBoxColumn1";
            // 
            // ch3outDataGridViewTextBoxColumn1
            // 
            this.ch3outDataGridViewTextBoxColumn1.DataPropertyName = "ch3out";
            resources.ApplyResources(this.ch3outDataGridViewTextBoxColumn1, "ch3outDataGridViewTextBoxColumn1");
            this.ch3outDataGridViewTextBoxColumn1.Name = "ch3outDataGridViewTextBoxColumn1";
            // 
            // ch4outDataGridViewTextBoxColumn1
            // 
            this.ch4outDataGridViewTextBoxColumn1.DataPropertyName = "ch4out";
            resources.ApplyResources(this.ch4outDataGridViewTextBoxColumn1, "ch4outDataGridViewTextBoxColumn1");
            this.ch4outDataGridViewTextBoxColumn1.Name = "ch4outDataGridViewTextBoxColumn1";
            // 
            // ch5outDataGridViewTextBoxColumn1
            // 
            this.ch5outDataGridViewTextBoxColumn1.DataPropertyName = "ch5out";
            resources.ApplyResources(this.ch5outDataGridViewTextBoxColumn1, "ch5outDataGridViewTextBoxColumn1");
            this.ch5outDataGridViewTextBoxColumn1.Name = "ch5outDataGridViewTextBoxColumn1";
            // 
            // ch6outDataGridViewTextBoxColumn1
            // 
            this.ch6outDataGridViewTextBoxColumn1.DataPropertyName = "ch6out";
            resources.ApplyResources(this.ch6outDataGridViewTextBoxColumn1, "ch6outDataGridViewTextBoxColumn1");
            this.ch6outDataGridViewTextBoxColumn1.Name = "ch6outDataGridViewTextBoxColumn1";
            // 
            // ch7outDataGridViewTextBoxColumn1
            // 
            this.ch7outDataGridViewTextBoxColumn1.DataPropertyName = "ch7out";
            resources.ApplyResources(this.ch7outDataGridViewTextBoxColumn1, "ch7outDataGridViewTextBoxColumn1");
            this.ch7outDataGridViewTextBoxColumn1.Name = "ch7outDataGridViewTextBoxColumn1";
            // 
            // ch8outDataGridViewTextBoxColumn1
            // 
            this.ch8outDataGridViewTextBoxColumn1.DataPropertyName = "ch8out";
            resources.ApplyResources(this.ch8outDataGridViewTextBoxColumn1, "ch8outDataGridViewTextBoxColumn1");
            this.ch8outDataGridViewTextBoxColumn1.Name = "ch8outDataGridViewTextBoxColumn1";
            // 
            // ch9outDataGridViewTextBoxColumn1
            // 
            this.ch9outDataGridViewTextBoxColumn1.DataPropertyName = "ch9out";
            resources.ApplyResources(this.ch9outDataGridViewTextBoxColumn1, "ch9outDataGridViewTextBoxColumn1");
            this.ch9outDataGridViewTextBoxColumn1.Name = "ch9outDataGridViewTextBoxColumn1";
            // 
            // ch10outDataGridViewTextBoxColumn1
            // 
            this.ch10outDataGridViewTextBoxColumn1.DataPropertyName = "ch10out";
            resources.ApplyResources(this.ch10outDataGridViewTextBoxColumn1, "ch10outDataGridViewTextBoxColumn1");
            this.ch10outDataGridViewTextBoxColumn1.Name = "ch10outDataGridViewTextBoxColumn1";
            // 
            // ch11outDataGridViewTextBoxColumn1
            // 
            this.ch11outDataGridViewTextBoxColumn1.DataPropertyName = "ch11out";
            resources.ApplyResources(this.ch11outDataGridViewTextBoxColumn1, "ch11outDataGridViewTextBoxColumn1");
            this.ch11outDataGridViewTextBoxColumn1.Name = "ch11outDataGridViewTextBoxColumn1";
            // 
            // ch12outDataGridViewTextBoxColumn1
            // 
            this.ch12outDataGridViewTextBoxColumn1.DataPropertyName = "ch12out";
            resources.ApplyResources(this.ch12outDataGridViewTextBoxColumn1, "ch12outDataGridViewTextBoxColumn1");
            this.ch12outDataGridViewTextBoxColumn1.Name = "ch12outDataGridViewTextBoxColumn1";
            // 
            // ch13outDataGridViewTextBoxColumn1
            // 
            this.ch13outDataGridViewTextBoxColumn1.DataPropertyName = "ch13out";
            resources.ApplyResources(this.ch13outDataGridViewTextBoxColumn1, "ch13outDataGridViewTextBoxColumn1");
            this.ch13outDataGridViewTextBoxColumn1.Name = "ch13outDataGridViewTextBoxColumn1";
            // 
            // ch14outDataGridViewTextBoxColumn1
            // 
            this.ch14outDataGridViewTextBoxColumn1.DataPropertyName = "ch14out";
            resources.ApplyResources(this.ch14outDataGridViewTextBoxColumn1, "ch14outDataGridViewTextBoxColumn1");
            this.ch14outDataGridViewTextBoxColumn1.Name = "ch14outDataGridViewTextBoxColumn1";
            // 
            // ch15outDataGridViewTextBoxColumn1
            // 
            this.ch15outDataGridViewTextBoxColumn1.DataPropertyName = "ch15out";
            resources.ApplyResources(this.ch15outDataGridViewTextBoxColumn1, "ch15outDataGridViewTextBoxColumn1");
            this.ch15outDataGridViewTextBoxColumn1.Name = "ch15outDataGridViewTextBoxColumn1";
            // 
            // ch16outDataGridViewTextBoxColumn1
            // 
            this.ch16outDataGridViewTextBoxColumn1.DataPropertyName = "ch16out";
            resources.ApplyResources(this.ch16outDataGridViewTextBoxColumn1, "ch16outDataGridViewTextBoxColumn1");
            this.ch16outDataGridViewTextBoxColumn1.Name = "ch16outDataGridViewTextBoxColumn1";
            // 
            // esc1voltDataGridViewTextBoxColumn1
            // 
            this.esc1voltDataGridViewTextBoxColumn1.DataPropertyName = "esc1_volt";
            resources.ApplyResources(this.esc1voltDataGridViewTextBoxColumn1, "esc1voltDataGridViewTextBoxColumn1");
            this.esc1voltDataGridViewTextBoxColumn1.Name = "esc1voltDataGridViewTextBoxColumn1";
            // 
            // esc1currDataGridViewTextBoxColumn1
            // 
            this.esc1currDataGridViewTextBoxColumn1.DataPropertyName = "esc1_curr";
            resources.ApplyResources(this.esc1currDataGridViewTextBoxColumn1, "esc1currDataGridViewTextBoxColumn1");
            this.esc1currDataGridViewTextBoxColumn1.Name = "esc1currDataGridViewTextBoxColumn1";
            // 
            // esc1rpmDataGridViewTextBoxColumn1
            // 
            this.esc1rpmDataGridViewTextBoxColumn1.DataPropertyName = "esc1_rpm";
            resources.ApplyResources(this.esc1rpmDataGridViewTextBoxColumn1, "esc1rpmDataGridViewTextBoxColumn1");
            this.esc1rpmDataGridViewTextBoxColumn1.Name = "esc1rpmDataGridViewTextBoxColumn1";
            // 
            // esc1tempDataGridViewTextBoxColumn1
            // 
            this.esc1tempDataGridViewTextBoxColumn1.DataPropertyName = "esc1_temp";
            resources.ApplyResources(this.esc1tempDataGridViewTextBoxColumn1, "esc1tempDataGridViewTextBoxColumn1");
            this.esc1tempDataGridViewTextBoxColumn1.Name = "esc1tempDataGridViewTextBoxColumn1";
            // 
            // esc2voltDataGridViewTextBoxColumn1
            // 
            this.esc2voltDataGridViewTextBoxColumn1.DataPropertyName = "esc2_volt";
            resources.ApplyResources(this.esc2voltDataGridViewTextBoxColumn1, "esc2voltDataGridViewTextBoxColumn1");
            this.esc2voltDataGridViewTextBoxColumn1.Name = "esc2voltDataGridViewTextBoxColumn1";
            // 
            // esc2currDataGridViewTextBoxColumn1
            // 
            this.esc2currDataGridViewTextBoxColumn1.DataPropertyName = "esc2_curr";
            resources.ApplyResources(this.esc2currDataGridViewTextBoxColumn1, "esc2currDataGridViewTextBoxColumn1");
            this.esc2currDataGridViewTextBoxColumn1.Name = "esc2currDataGridViewTextBoxColumn1";
            // 
            // esc2rpmDataGridViewTextBoxColumn1
            // 
            this.esc2rpmDataGridViewTextBoxColumn1.DataPropertyName = "esc2_rpm";
            resources.ApplyResources(this.esc2rpmDataGridViewTextBoxColumn1, "esc2rpmDataGridViewTextBoxColumn1");
            this.esc2rpmDataGridViewTextBoxColumn1.Name = "esc2rpmDataGridViewTextBoxColumn1";
            // 
            // esc2tempDataGridViewTextBoxColumn1
            // 
            this.esc2tempDataGridViewTextBoxColumn1.DataPropertyName = "esc2_temp";
            resources.ApplyResources(this.esc2tempDataGridViewTextBoxColumn1, "esc2tempDataGridViewTextBoxColumn1");
            this.esc2tempDataGridViewTextBoxColumn1.Name = "esc2tempDataGridViewTextBoxColumn1";
            // 
            // esc3voltDataGridViewTextBoxColumn1
            // 
            this.esc3voltDataGridViewTextBoxColumn1.DataPropertyName = "esc3_volt";
            resources.ApplyResources(this.esc3voltDataGridViewTextBoxColumn1, "esc3voltDataGridViewTextBoxColumn1");
            this.esc3voltDataGridViewTextBoxColumn1.Name = "esc3voltDataGridViewTextBoxColumn1";
            // 
            // esc3currDataGridViewTextBoxColumn1
            // 
            this.esc3currDataGridViewTextBoxColumn1.DataPropertyName = "esc3_curr";
            resources.ApplyResources(this.esc3currDataGridViewTextBoxColumn1, "esc3currDataGridViewTextBoxColumn1");
            this.esc3currDataGridViewTextBoxColumn1.Name = "esc3currDataGridViewTextBoxColumn1";
            // 
            // esc3rpmDataGridViewTextBoxColumn1
            // 
            this.esc3rpmDataGridViewTextBoxColumn1.DataPropertyName = "esc3_rpm";
            resources.ApplyResources(this.esc3rpmDataGridViewTextBoxColumn1, "esc3rpmDataGridViewTextBoxColumn1");
            this.esc3rpmDataGridViewTextBoxColumn1.Name = "esc3rpmDataGridViewTextBoxColumn1";
            // 
            // esc3tempDataGridViewTextBoxColumn1
            // 
            this.esc3tempDataGridViewTextBoxColumn1.DataPropertyName = "esc3_temp";
            resources.ApplyResources(this.esc3tempDataGridViewTextBoxColumn1, "esc3tempDataGridViewTextBoxColumn1");
            this.esc3tempDataGridViewTextBoxColumn1.Name = "esc3tempDataGridViewTextBoxColumn1";
            // 
            // esc4voltDataGridViewTextBoxColumn1
            // 
            this.esc4voltDataGridViewTextBoxColumn1.DataPropertyName = "esc4_volt";
            resources.ApplyResources(this.esc4voltDataGridViewTextBoxColumn1, "esc4voltDataGridViewTextBoxColumn1");
            this.esc4voltDataGridViewTextBoxColumn1.Name = "esc4voltDataGridViewTextBoxColumn1";
            // 
            // esc4currDataGridViewTextBoxColumn1
            // 
            this.esc4currDataGridViewTextBoxColumn1.DataPropertyName = "esc4_curr";
            resources.ApplyResources(this.esc4currDataGridViewTextBoxColumn1, "esc4currDataGridViewTextBoxColumn1");
            this.esc4currDataGridViewTextBoxColumn1.Name = "esc4currDataGridViewTextBoxColumn1";
            // 
            // esc4rpmDataGridViewTextBoxColumn1
            // 
            this.esc4rpmDataGridViewTextBoxColumn1.DataPropertyName = "esc4_rpm";
            resources.ApplyResources(this.esc4rpmDataGridViewTextBoxColumn1, "esc4rpmDataGridViewTextBoxColumn1");
            this.esc4rpmDataGridViewTextBoxColumn1.Name = "esc4rpmDataGridViewTextBoxColumn1";
            // 
            // esc4tempDataGridViewTextBoxColumn1
            // 
            this.esc4tempDataGridViewTextBoxColumn1.DataPropertyName = "esc4_temp";
            resources.ApplyResources(this.esc4tempDataGridViewTextBoxColumn1, "esc4tempDataGridViewTextBoxColumn1");
            this.esc4tempDataGridViewTextBoxColumn1.Name = "esc4tempDataGridViewTextBoxColumn1";
            // 
            // esc5voltDataGridViewTextBoxColumn1
            // 
            this.esc5voltDataGridViewTextBoxColumn1.DataPropertyName = "esc5_volt";
            resources.ApplyResources(this.esc5voltDataGridViewTextBoxColumn1, "esc5voltDataGridViewTextBoxColumn1");
            this.esc5voltDataGridViewTextBoxColumn1.Name = "esc5voltDataGridViewTextBoxColumn1";
            // 
            // esc5currDataGridViewTextBoxColumn1
            // 
            this.esc5currDataGridViewTextBoxColumn1.DataPropertyName = "esc5_curr";
            resources.ApplyResources(this.esc5currDataGridViewTextBoxColumn1, "esc5currDataGridViewTextBoxColumn1");
            this.esc5currDataGridViewTextBoxColumn1.Name = "esc5currDataGridViewTextBoxColumn1";
            // 
            // esc5rpmDataGridViewTextBoxColumn1
            // 
            this.esc5rpmDataGridViewTextBoxColumn1.DataPropertyName = "esc5_rpm";
            resources.ApplyResources(this.esc5rpmDataGridViewTextBoxColumn1, "esc5rpmDataGridViewTextBoxColumn1");
            this.esc5rpmDataGridViewTextBoxColumn1.Name = "esc5rpmDataGridViewTextBoxColumn1";
            // 
            // esc5tempDataGridViewTextBoxColumn1
            // 
            this.esc5tempDataGridViewTextBoxColumn1.DataPropertyName = "esc5_temp";
            resources.ApplyResources(this.esc5tempDataGridViewTextBoxColumn1, "esc5tempDataGridViewTextBoxColumn1");
            this.esc5tempDataGridViewTextBoxColumn1.Name = "esc5tempDataGridViewTextBoxColumn1";
            // 
            // esc6voltDataGridViewTextBoxColumn1
            // 
            this.esc6voltDataGridViewTextBoxColumn1.DataPropertyName = "esc6_volt";
            resources.ApplyResources(this.esc6voltDataGridViewTextBoxColumn1, "esc6voltDataGridViewTextBoxColumn1");
            this.esc6voltDataGridViewTextBoxColumn1.Name = "esc6voltDataGridViewTextBoxColumn1";
            // 
            // esc6currDataGridViewTextBoxColumn1
            // 
            this.esc6currDataGridViewTextBoxColumn1.DataPropertyName = "esc6_curr";
            resources.ApplyResources(this.esc6currDataGridViewTextBoxColumn1, "esc6currDataGridViewTextBoxColumn1");
            this.esc6currDataGridViewTextBoxColumn1.Name = "esc6currDataGridViewTextBoxColumn1";
            // 
            // esc6rpmDataGridViewTextBoxColumn1
            // 
            this.esc6rpmDataGridViewTextBoxColumn1.DataPropertyName = "esc6_rpm";
            resources.ApplyResources(this.esc6rpmDataGridViewTextBoxColumn1, "esc6rpmDataGridViewTextBoxColumn1");
            this.esc6rpmDataGridViewTextBoxColumn1.Name = "esc6rpmDataGridViewTextBoxColumn1";
            // 
            // esc6tempDataGridViewTextBoxColumn1
            // 
            this.esc6tempDataGridViewTextBoxColumn1.DataPropertyName = "esc6_temp";
            resources.ApplyResources(this.esc6tempDataGridViewTextBoxColumn1, "esc6tempDataGridViewTextBoxColumn1");
            this.esc6tempDataGridViewTextBoxColumn1.Name = "esc6tempDataGridViewTextBoxColumn1";
            // 
            // esc7voltDataGridViewTextBoxColumn1
            // 
            this.esc7voltDataGridViewTextBoxColumn1.DataPropertyName = "esc7_volt";
            resources.ApplyResources(this.esc7voltDataGridViewTextBoxColumn1, "esc7voltDataGridViewTextBoxColumn1");
            this.esc7voltDataGridViewTextBoxColumn1.Name = "esc7voltDataGridViewTextBoxColumn1";
            // 
            // esc7currDataGridViewTextBoxColumn1
            // 
            this.esc7currDataGridViewTextBoxColumn1.DataPropertyName = "esc7_curr";
            resources.ApplyResources(this.esc7currDataGridViewTextBoxColumn1, "esc7currDataGridViewTextBoxColumn1");
            this.esc7currDataGridViewTextBoxColumn1.Name = "esc7currDataGridViewTextBoxColumn1";
            // 
            // esc7rpmDataGridViewTextBoxColumn1
            // 
            this.esc7rpmDataGridViewTextBoxColumn1.DataPropertyName = "esc7_rpm";
            resources.ApplyResources(this.esc7rpmDataGridViewTextBoxColumn1, "esc7rpmDataGridViewTextBoxColumn1");
            this.esc7rpmDataGridViewTextBoxColumn1.Name = "esc7rpmDataGridViewTextBoxColumn1";
            // 
            // esc7tempDataGridViewTextBoxColumn1
            // 
            this.esc7tempDataGridViewTextBoxColumn1.DataPropertyName = "esc7_temp";
            resources.ApplyResources(this.esc7tempDataGridViewTextBoxColumn1, "esc7tempDataGridViewTextBoxColumn1");
            this.esc7tempDataGridViewTextBoxColumn1.Name = "esc7tempDataGridViewTextBoxColumn1";
            // 
            // esc8voltDataGridViewTextBoxColumn1
            // 
            this.esc8voltDataGridViewTextBoxColumn1.DataPropertyName = "esc8_volt";
            resources.ApplyResources(this.esc8voltDataGridViewTextBoxColumn1, "esc8voltDataGridViewTextBoxColumn1");
            this.esc8voltDataGridViewTextBoxColumn1.Name = "esc8voltDataGridViewTextBoxColumn1";
            // 
            // esc8currDataGridViewTextBoxColumn1
            // 
            this.esc8currDataGridViewTextBoxColumn1.DataPropertyName = "esc8_curr";
            resources.ApplyResources(this.esc8currDataGridViewTextBoxColumn1, "esc8currDataGridViewTextBoxColumn1");
            this.esc8currDataGridViewTextBoxColumn1.Name = "esc8currDataGridViewTextBoxColumn1";
            // 
            // esc8rpmDataGridViewTextBoxColumn1
            // 
            this.esc8rpmDataGridViewTextBoxColumn1.DataPropertyName = "esc8_rpm";
            resources.ApplyResources(this.esc8rpmDataGridViewTextBoxColumn1, "esc8rpmDataGridViewTextBoxColumn1");
            this.esc8rpmDataGridViewTextBoxColumn1.Name = "esc8rpmDataGridViewTextBoxColumn1";
            // 
            // esc8tempDataGridViewTextBoxColumn1
            // 
            this.esc8tempDataGridViewTextBoxColumn1.DataPropertyName = "esc8_temp";
            resources.ApplyResources(this.esc8tempDataGridViewTextBoxColumn1, "esc8tempDataGridViewTextBoxColumn1");
            this.esc8tempDataGridViewTextBoxColumn1.Name = "esc8tempDataGridViewTextBoxColumn1";
            // 
            // ch3percentDataGridViewTextBoxColumn1
            // 
            this.ch3percentDataGridViewTextBoxColumn1.DataPropertyName = "ch3percent";
            resources.ApplyResources(this.ch3percentDataGridViewTextBoxColumn1, "ch3percentDataGridViewTextBoxColumn1");
            this.ch3percentDataGridViewTextBoxColumn1.Name = "ch3percentDataGridViewTextBoxColumn1";
            // 
            // failsafeDataGridViewCheckBoxColumn1
            // 
            this.failsafeDataGridViewCheckBoxColumn1.DataPropertyName = "failsafe";
            resources.ApplyResources(this.failsafeDataGridViewCheckBoxColumn1, "failsafeDataGridViewCheckBoxColumn1");
            this.failsafeDataGridViewCheckBoxColumn1.Name = "failsafeDataGridViewCheckBoxColumn1";
            // 
            // rxrssiDataGridViewTextBoxColumn1
            // 
            this.rxrssiDataGridViewTextBoxColumn1.DataPropertyName = "rxrssi";
            resources.ApplyResources(this.rxrssiDataGridViewTextBoxColumn1, "rxrssiDataGridViewTextBoxColumn1");
            this.rxrssiDataGridViewTextBoxColumn1.Name = "rxrssiDataGridViewTextBoxColumn1";
            // 
            // critAOADataGridViewTextBoxColumn1
            // 
            this.critAOADataGridViewTextBoxColumn1.DataPropertyName = "crit_AOA";
            resources.ApplyResources(this.critAOADataGridViewTextBoxColumn1, "critAOADataGridViewTextBoxColumn1");
            this.critAOADataGridViewTextBoxColumn1.Name = "critAOADataGridViewTextBoxColumn1";
            // 
            // lowgroundspeedDataGridViewCheckBoxColumn1
            // 
            this.lowgroundspeedDataGridViewCheckBoxColumn1.DataPropertyName = "lowgroundspeed";
            resources.ApplyResources(this.lowgroundspeedDataGridViewCheckBoxColumn1, "lowgroundspeedDataGridViewCheckBoxColumn1");
            this.lowgroundspeedDataGridViewCheckBoxColumn1.Name = "lowgroundspeedDataGridViewCheckBoxColumn1";
            // 
            // verticalspeedDataGridViewTextBoxColumn1
            // 
            this.verticalspeedDataGridViewTextBoxColumn1.DataPropertyName = "verticalspeed";
            resources.ApplyResources(this.verticalspeedDataGridViewTextBoxColumn1, "verticalspeedDataGridViewTextBoxColumn1");
            this.verticalspeedDataGridViewTextBoxColumn1.Name = "verticalspeedDataGridViewTextBoxColumn1";
            // 
            // verticalspeedfpmDataGridViewTextBoxColumn1
            // 
            this.verticalspeedfpmDataGridViewTextBoxColumn1.DataPropertyName = "verticalspeed_fpm";
            resources.ApplyResources(this.verticalspeedfpmDataGridViewTextBoxColumn1, "verticalspeedfpmDataGridViewTextBoxColumn1");
            this.verticalspeedfpmDataGridViewTextBoxColumn1.Name = "verticalspeedfpmDataGridViewTextBoxColumn1";
            this.verticalspeedfpmDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // glideratioDataGridViewTextBoxColumn1
            // 
            this.glideratioDataGridViewTextBoxColumn1.DataPropertyName = "glide_ratio";
            resources.ApplyResources(this.glideratioDataGridViewTextBoxColumn1, "glideratioDataGridViewTextBoxColumn1");
            this.glideratioDataGridViewTextBoxColumn1.Name = "glideratioDataGridViewTextBoxColumn1";
            this.glideratioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // navrollDataGridViewTextBoxColumn1
            // 
            this.navrollDataGridViewTextBoxColumn1.DataPropertyName = "nav_roll";
            resources.ApplyResources(this.navrollDataGridViewTextBoxColumn1, "navrollDataGridViewTextBoxColumn1");
            this.navrollDataGridViewTextBoxColumn1.Name = "navrollDataGridViewTextBoxColumn1";
            // 
            // navpitchDataGridViewTextBoxColumn1
            // 
            this.navpitchDataGridViewTextBoxColumn1.DataPropertyName = "nav_pitch";
            resources.ApplyResources(this.navpitchDataGridViewTextBoxColumn1, "navpitchDataGridViewTextBoxColumn1");
            this.navpitchDataGridViewTextBoxColumn1.Name = "navpitchDataGridViewTextBoxColumn1";
            // 
            // navbearingDataGridViewTextBoxColumn1
            // 
            this.navbearingDataGridViewTextBoxColumn1.DataPropertyName = "nav_bearing";
            resources.ApplyResources(this.navbearingDataGridViewTextBoxColumn1, "navbearingDataGridViewTextBoxColumn1");
            this.navbearingDataGridViewTextBoxColumn1.Name = "navbearingDataGridViewTextBoxColumn1";
            // 
            // targetbearingDataGridViewTextBoxColumn1
            // 
            this.targetbearingDataGridViewTextBoxColumn1.DataPropertyName = "target_bearing";
            resources.ApplyResources(this.targetbearingDataGridViewTextBoxColumn1, "targetbearingDataGridViewTextBoxColumn1");
            this.targetbearingDataGridViewTextBoxColumn1.Name = "targetbearingDataGridViewTextBoxColumn1";
            // 
            // wpdistDataGridViewTextBoxColumn1
            // 
            this.wpdistDataGridViewTextBoxColumn1.DataPropertyName = "wp_dist";
            resources.ApplyResources(this.wpdistDataGridViewTextBoxColumn1, "wpdistDataGridViewTextBoxColumn1");
            this.wpdistDataGridViewTextBoxColumn1.Name = "wpdistDataGridViewTextBoxColumn1";
            // 
            // alterrorDataGridViewTextBoxColumn1
            // 
            this.alterrorDataGridViewTextBoxColumn1.DataPropertyName = "alt_error";
            resources.ApplyResources(this.alterrorDataGridViewTextBoxColumn1, "alterrorDataGridViewTextBoxColumn1");
            this.alterrorDataGridViewTextBoxColumn1.Name = "alterrorDataGridViewTextBoxColumn1";
            // 
            // bererrorDataGridViewTextBoxColumn1
            // 
            this.bererrorDataGridViewTextBoxColumn1.DataPropertyName = "ber_error";
            resources.ApplyResources(this.bererrorDataGridViewTextBoxColumn1, "bererrorDataGridViewTextBoxColumn1");
            this.bererrorDataGridViewTextBoxColumn1.Name = "bererrorDataGridViewTextBoxColumn1";
            // 
            // aspderrorDataGridViewTextBoxColumn1
            // 
            this.aspderrorDataGridViewTextBoxColumn1.DataPropertyName = "aspd_error";
            resources.ApplyResources(this.aspderrorDataGridViewTextBoxColumn1, "aspderrorDataGridViewTextBoxColumn1");
            this.aspderrorDataGridViewTextBoxColumn1.Name = "aspderrorDataGridViewTextBoxColumn1";
            // 
            // xtrackerrorDataGridViewTextBoxColumn1
            // 
            this.xtrackerrorDataGridViewTextBoxColumn1.DataPropertyName = "xtrack_error";
            resources.ApplyResources(this.xtrackerrorDataGridViewTextBoxColumn1, "xtrackerrorDataGridViewTextBoxColumn1");
            this.xtrackerrorDataGridViewTextBoxColumn1.Name = "xtrackerrorDataGridViewTextBoxColumn1";
            // 
            // wpnoDataGridViewTextBoxColumn1
            // 
            this.wpnoDataGridViewTextBoxColumn1.DataPropertyName = "wpno";
            resources.ApplyResources(this.wpnoDataGridViewTextBoxColumn1, "wpnoDataGridViewTextBoxColumn1");
            this.wpnoDataGridViewTextBoxColumn1.Name = "wpnoDataGridViewTextBoxColumn1";
            // 
            // modeDataGridViewTextBoxColumn1
            // 
            this.modeDataGridViewTextBoxColumn1.DataPropertyName = "mode";
            resources.ApplyResources(this.modeDataGridViewTextBoxColumn1, "modeDataGridViewTextBoxColumn1");
            this.modeDataGridViewTextBoxColumn1.Name = "modeDataGridViewTextBoxColumn1";
            // 
            // climbrateDataGridViewTextBoxColumn1
            // 
            this.climbrateDataGridViewTextBoxColumn1.DataPropertyName = "climbrate";
            resources.ApplyResources(this.climbrateDataGridViewTextBoxColumn1, "climbrateDataGridViewTextBoxColumn1");
            this.climbrateDataGridViewTextBoxColumn1.Name = "climbrateDataGridViewTextBoxColumn1";
            // 
            // totDataGridViewTextBoxColumn1
            // 
            this.totDataGridViewTextBoxColumn1.DataPropertyName = "tot";
            resources.ApplyResources(this.totDataGridViewTextBoxColumn1, "totDataGridViewTextBoxColumn1");
            this.totDataGridViewTextBoxColumn1.Name = "totDataGridViewTextBoxColumn1";
            this.totDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tohDataGridViewTextBoxColumn1
            // 
            this.tohDataGridViewTextBoxColumn1.DataPropertyName = "toh";
            resources.ApplyResources(this.tohDataGridViewTextBoxColumn1, "tohDataGridViewTextBoxColumn1");
            this.tohDataGridViewTextBoxColumn1.Name = "tohDataGridViewTextBoxColumn1";
            this.tohDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // distTraveledDataGridViewTextBoxColumn1
            // 
            this.distTraveledDataGridViewTextBoxColumn1.DataPropertyName = "distTraveled";
            resources.ApplyResources(this.distTraveledDataGridViewTextBoxColumn1, "distTraveledDataGridViewTextBoxColumn1");
            this.distTraveledDataGridViewTextBoxColumn1.Name = "distTraveledDataGridViewTextBoxColumn1";
            // 
            // timeSinceArmInAirDataGridViewTextBoxColumn1
            // 
            this.timeSinceArmInAirDataGridViewTextBoxColumn1.DataPropertyName = "timeSinceArmInAir";
            resources.ApplyResources(this.timeSinceArmInAirDataGridViewTextBoxColumn1, "timeSinceArmInAirDataGridViewTextBoxColumn1");
            this.timeSinceArmInAirDataGridViewTextBoxColumn1.Name = "timeSinceArmInAirDataGridViewTextBoxColumn1";
            // 
            // timeInAirDataGridViewTextBoxColumn1
            // 
            this.timeInAirDataGridViewTextBoxColumn1.DataPropertyName = "timeInAir";
            resources.ApplyResources(this.timeInAirDataGridViewTextBoxColumn1, "timeInAirDataGridViewTextBoxColumn1");
            this.timeInAirDataGridViewTextBoxColumn1.Name = "timeInAirDataGridViewTextBoxColumn1";
            // 
            // timeInAirMinSecDataGridViewTextBoxColumn1
            // 
            this.timeInAirMinSecDataGridViewTextBoxColumn1.DataPropertyName = "timeInAirMinSec";
            resources.ApplyResources(this.timeInAirMinSecDataGridViewTextBoxColumn1, "timeInAirMinSecDataGridViewTextBoxColumn1");
            this.timeInAirMinSecDataGridViewTextBoxColumn1.Name = "timeInAirMinSecDataGridViewTextBoxColumn1";
            this.timeInAirMinSecDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // turnrateDataGridViewTextBoxColumn1
            // 
            this.turnrateDataGridViewTextBoxColumn1.DataPropertyName = "turnrate";
            resources.ApplyResources(this.turnrateDataGridViewTextBoxColumn1, "turnrateDataGridViewTextBoxColumn1");
            this.turnrateDataGridViewTextBoxColumn1.Name = "turnrateDataGridViewTextBoxColumn1";
            this.turnrateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // turngDataGridViewTextBoxColumn1
            // 
            this.turngDataGridViewTextBoxColumn1.DataPropertyName = "turng";
            resources.ApplyResources(this.turngDataGridViewTextBoxColumn1, "turngDataGridViewTextBoxColumn1");
            this.turngDataGridViewTextBoxColumn1.Name = "turngDataGridViewTextBoxColumn1";
            this.turngDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // radiusDataGridViewTextBoxColumn1
            // 
            this.radiusDataGridViewTextBoxColumn1.DataPropertyName = "radius";
            resources.ApplyResources(this.radiusDataGridViewTextBoxColumn1, "radiusDataGridViewTextBoxColumn1");
            this.radiusDataGridViewTextBoxColumn1.Name = "radiusDataGridViewTextBoxColumn1";
            this.radiusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // qNHDataGridViewTextBoxColumn1
            // 
            this.qNHDataGridViewTextBoxColumn1.DataPropertyName = "QNH";
            resources.ApplyResources(this.qNHDataGridViewTextBoxColumn1, "qNHDataGridViewTextBoxColumn1");
            this.qNHDataGridViewTextBoxColumn1.Name = "qNHDataGridViewTextBoxColumn1";
            this.qNHDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // winddirDataGridViewTextBoxColumn1
            // 
            this.winddirDataGridViewTextBoxColumn1.DataPropertyName = "wind_dir";
            resources.ApplyResources(this.winddirDataGridViewTextBoxColumn1, "winddirDataGridViewTextBoxColumn1");
            this.winddirDataGridViewTextBoxColumn1.Name = "winddirDataGridViewTextBoxColumn1";
            // 
            // windvelDataGridViewTextBoxColumn1
            // 
            this.windvelDataGridViewTextBoxColumn1.DataPropertyName = "wind_vel";
            resources.ApplyResources(this.windvelDataGridViewTextBoxColumn1, "windvelDataGridViewTextBoxColumn1");
            this.windvelDataGridViewTextBoxColumn1.Name = "windvelDataGridViewTextBoxColumn1";
            // 
            // targetaltd100DataGridViewTextBoxColumn1
            // 
            this.targetaltd100DataGridViewTextBoxColumn1.DataPropertyName = "targetaltd100";
            resources.ApplyResources(this.targetaltd100DataGridViewTextBoxColumn1, "targetaltd100DataGridViewTextBoxColumn1");
            this.targetaltd100DataGridViewTextBoxColumn1.Name = "targetaltd100DataGridViewTextBoxColumn1";
            this.targetaltd100DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // targetaltDataGridViewTextBoxColumn1
            // 
            this.targetaltDataGridViewTextBoxColumn1.DataPropertyName = "targetalt";
            resources.ApplyResources(this.targetaltDataGridViewTextBoxColumn1, "targetaltDataGridViewTextBoxColumn1");
            this.targetaltDataGridViewTextBoxColumn1.Name = "targetaltDataGridViewTextBoxColumn1";
            this.targetaltDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn1
            // 
            this.messageDataGridViewTextBoxColumn1.DataPropertyName = "message";
            resources.ApplyResources(this.messageDataGridViewTextBoxColumn1, "messageDataGridViewTextBoxColumn1");
            this.messageDataGridViewTextBoxColumn1.Name = "messageDataGridViewTextBoxColumn1";
            this.messageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // messageHighDataGridViewTextBoxColumn1
            // 
            this.messageHighDataGridViewTextBoxColumn1.DataPropertyName = "messageHigh";
            resources.ApplyResources(this.messageHighDataGridViewTextBoxColumn1, "messageHighDataGridViewTextBoxColumn1");
            this.messageHighDataGridViewTextBoxColumn1.Name = "messageHighDataGridViewTextBoxColumn1";
            // 
            // messageHighTimeDataGridViewTextBoxColumn1
            // 
            this.messageHighTimeDataGridViewTextBoxColumn1.DataPropertyName = "messageHighTime";
            resources.ApplyResources(this.messageHighTimeDataGridViewTextBoxColumn1, "messageHighTimeDataGridViewTextBoxColumn1");
            this.messageHighTimeDataGridViewTextBoxColumn1.Name = "messageHighTimeDataGridViewTextBoxColumn1";
            // 
            // batteryvoltageDataGridViewTextBoxColumn1
            // 
            this.batteryvoltageDataGridViewTextBoxColumn1.DataPropertyName = "battery_voltage";
            resources.ApplyResources(this.batteryvoltageDataGridViewTextBoxColumn1, "batteryvoltageDataGridViewTextBoxColumn1");
            this.batteryvoltageDataGridViewTextBoxColumn1.Name = "batteryvoltageDataGridViewTextBoxColumn1";
            // 
            // batteryvoltage3DataGridViewTextBoxColumn1
            // 
            this.batteryvoltage3DataGridViewTextBoxColumn1.DataPropertyName = "battery_voltage3";
            resources.ApplyResources(this.batteryvoltage3DataGridViewTextBoxColumn1, "batteryvoltage3DataGridViewTextBoxColumn1");
            this.batteryvoltage3DataGridViewTextBoxColumn1.Name = "batteryvoltage3DataGridViewTextBoxColumn1";
            // 
            // batteryvoltage4DataGridViewTextBoxColumn1
            // 
            this.batteryvoltage4DataGridViewTextBoxColumn1.DataPropertyName = "battery_voltage4";
            resources.ApplyResources(this.batteryvoltage4DataGridViewTextBoxColumn1, "batteryvoltage4DataGridViewTextBoxColumn1");
            this.batteryvoltage4DataGridViewTextBoxColumn1.Name = "batteryvoltage4DataGridViewTextBoxColumn1";
            // 
            // batteryvoltage5DataGridViewTextBoxColumn1
            // 
            this.batteryvoltage5DataGridViewTextBoxColumn1.DataPropertyName = "battery_voltage5";
            resources.ApplyResources(this.batteryvoltage5DataGridViewTextBoxColumn1, "batteryvoltage5DataGridViewTextBoxColumn1");
            this.batteryvoltage5DataGridViewTextBoxColumn1.Name = "batteryvoltage5DataGridViewTextBoxColumn1";
            // 
            // batteryvoltage6DataGridViewTextBoxColumn1
            // 
            this.batteryvoltage6DataGridViewTextBoxColumn1.DataPropertyName = "battery_voltage6";
            resources.ApplyResources(this.batteryvoltage6DataGridViewTextBoxColumn1, "batteryvoltage6DataGridViewTextBoxColumn1");
            this.batteryvoltage6DataGridViewTextBoxColumn1.Name = "batteryvoltage6DataGridViewTextBoxColumn1";
            // 
            // batteryvoltage7DataGridViewTextBoxColumn1
            // 
            this.batteryvoltage7DataGridViewTextBoxColumn1.DataPropertyName = "battery_voltage7";
            resources.ApplyResources(this.batteryvoltage7DataGridViewTextBoxColumn1, "batteryvoltage7DataGridViewTextBoxColumn1");
            this.batteryvoltage7DataGridViewTextBoxColumn1.Name = "batteryvoltage7DataGridViewTextBoxColumn1";
            // 
            // batteryvoltage8DataGridViewTextBoxColumn1
            // 
            this.batteryvoltage8DataGridViewTextBoxColumn1.DataPropertyName = "battery_voltage8";
            resources.ApplyResources(this.batteryvoltage8DataGridViewTextBoxColumn1, "batteryvoltage8DataGridViewTextBoxColumn1");
            this.batteryvoltage8DataGridViewTextBoxColumn1.Name = "batteryvoltage8DataGridViewTextBoxColumn1";
            // 
            // batteryremainingDataGridViewTextBoxColumn1
            // 
            this.batteryremainingDataGridViewTextBoxColumn1.DataPropertyName = "battery_remaining";
            resources.ApplyResources(this.batteryremainingDataGridViewTextBoxColumn1, "batteryremainingDataGridViewTextBoxColumn1");
            this.batteryremainingDataGridViewTextBoxColumn1.Name = "batteryremainingDataGridViewTextBoxColumn1";
            // 
            // batteryremaining2DataGridViewTextBoxColumn1
            // 
            this.batteryremaining2DataGridViewTextBoxColumn1.DataPropertyName = "battery_remaining2";
            resources.ApplyResources(this.batteryremaining2DataGridViewTextBoxColumn1, "batteryremaining2DataGridViewTextBoxColumn1");
            this.batteryremaining2DataGridViewTextBoxColumn1.Name = "batteryremaining2DataGridViewTextBoxColumn1";
            // 
            // batteryremaining3DataGridViewTextBoxColumn1
            // 
            this.batteryremaining3DataGridViewTextBoxColumn1.DataPropertyName = "battery_remaining3";
            resources.ApplyResources(this.batteryremaining3DataGridViewTextBoxColumn1, "batteryremaining3DataGridViewTextBoxColumn1");
            this.batteryremaining3DataGridViewTextBoxColumn1.Name = "batteryremaining3DataGridViewTextBoxColumn1";
            // 
            // batteryremaining4DataGridViewTextBoxColumn1
            // 
            this.batteryremaining4DataGridViewTextBoxColumn1.DataPropertyName = "battery_remaining4";
            resources.ApplyResources(this.batteryremaining4DataGridViewTextBoxColumn1, "batteryremaining4DataGridViewTextBoxColumn1");
            this.batteryremaining4DataGridViewTextBoxColumn1.Name = "batteryremaining4DataGridViewTextBoxColumn1";
            // 
            // batteryremaining5DataGridViewTextBoxColumn1
            // 
            this.batteryremaining5DataGridViewTextBoxColumn1.DataPropertyName = "battery_remaining5";
            resources.ApplyResources(this.batteryremaining5DataGridViewTextBoxColumn1, "batteryremaining5DataGridViewTextBoxColumn1");
            this.batteryremaining5DataGridViewTextBoxColumn1.Name = "batteryremaining5DataGridViewTextBoxColumn1";
            // 
            // batteryremaining6DataGridViewTextBoxColumn1
            // 
            this.batteryremaining6DataGridViewTextBoxColumn1.DataPropertyName = "battery_remaining6";
            resources.ApplyResources(this.batteryremaining6DataGridViewTextBoxColumn1, "batteryremaining6DataGridViewTextBoxColumn1");
            this.batteryremaining6DataGridViewTextBoxColumn1.Name = "batteryremaining6DataGridViewTextBoxColumn1";
            // 
            // batteryremaining7DataGridViewTextBoxColumn1
            // 
            this.batteryremaining7DataGridViewTextBoxColumn1.DataPropertyName = "battery_remaining7";
            resources.ApplyResources(this.batteryremaining7DataGridViewTextBoxColumn1, "batteryremaining7DataGridViewTextBoxColumn1");
            this.batteryremaining7DataGridViewTextBoxColumn1.Name = "batteryremaining7DataGridViewTextBoxColumn1";
            // 
            // batteryremaining8DataGridViewTextBoxColumn1
            // 
            this.batteryremaining8DataGridViewTextBoxColumn1.DataPropertyName = "battery_remaining8";
            resources.ApplyResources(this.batteryremaining8DataGridViewTextBoxColumn1, "batteryremaining8DataGridViewTextBoxColumn1");
            this.batteryremaining8DataGridViewTextBoxColumn1.Name = "batteryremaining8DataGridViewTextBoxColumn1";
            // 
            // currentDataGridViewTextBoxColumn1
            // 
            this.currentDataGridViewTextBoxColumn1.DataPropertyName = "current";
            resources.ApplyResources(this.currentDataGridViewTextBoxColumn1, "currentDataGridViewTextBoxColumn1");
            this.currentDataGridViewTextBoxColumn1.Name = "currentDataGridViewTextBoxColumn1";
            // 
            // current2DataGridViewTextBoxColumn1
            // 
            this.current2DataGridViewTextBoxColumn1.DataPropertyName = "current2";
            resources.ApplyResources(this.current2DataGridViewTextBoxColumn1, "current2DataGridViewTextBoxColumn1");
            this.current2DataGridViewTextBoxColumn1.Name = "current2DataGridViewTextBoxColumn1";
            // 
            // current3DataGridViewTextBoxColumn1
            // 
            this.current3DataGridViewTextBoxColumn1.DataPropertyName = "current3";
            resources.ApplyResources(this.current3DataGridViewTextBoxColumn1, "current3DataGridViewTextBoxColumn1");
            this.current3DataGridViewTextBoxColumn1.Name = "current3DataGridViewTextBoxColumn1";
            // 
            // current4DataGridViewTextBoxColumn1
            // 
            this.current4DataGridViewTextBoxColumn1.DataPropertyName = "current4";
            resources.ApplyResources(this.current4DataGridViewTextBoxColumn1, "current4DataGridViewTextBoxColumn1");
            this.current4DataGridViewTextBoxColumn1.Name = "current4DataGridViewTextBoxColumn1";
            // 
            // current5DataGridViewTextBoxColumn1
            // 
            this.current5DataGridViewTextBoxColumn1.DataPropertyName = "current5";
            resources.ApplyResources(this.current5DataGridViewTextBoxColumn1, "current5DataGridViewTextBoxColumn1");
            this.current5DataGridViewTextBoxColumn1.Name = "current5DataGridViewTextBoxColumn1";
            // 
            // current6DataGridViewTextBoxColumn1
            // 
            this.current6DataGridViewTextBoxColumn1.DataPropertyName = "current6";
            resources.ApplyResources(this.current6DataGridViewTextBoxColumn1, "current6DataGridViewTextBoxColumn1");
            this.current6DataGridViewTextBoxColumn1.Name = "current6DataGridViewTextBoxColumn1";
            // 
            // current7DataGridViewTextBoxColumn1
            // 
            this.current7DataGridViewTextBoxColumn1.DataPropertyName = "current7";
            resources.ApplyResources(this.current7DataGridViewTextBoxColumn1, "current7DataGridViewTextBoxColumn1");
            this.current7DataGridViewTextBoxColumn1.Name = "current7DataGridViewTextBoxColumn1";
            // 
            // current8DataGridViewTextBoxColumn1
            // 
            this.current8DataGridViewTextBoxColumn1.DataPropertyName = "current8";
            resources.ApplyResources(this.current8DataGridViewTextBoxColumn1, "current8DataGridViewTextBoxColumn1");
            this.current8DataGridViewTextBoxColumn1.Name = "current8DataGridViewTextBoxColumn1";
            // 
            // wattsDataGridViewTextBoxColumn1
            // 
            this.wattsDataGridViewTextBoxColumn1.DataPropertyName = "watts";
            resources.ApplyResources(this.wattsDataGridViewTextBoxColumn1, "wattsDataGridViewTextBoxColumn1");
            this.wattsDataGridViewTextBoxColumn1.Name = "wattsDataGridViewTextBoxColumn1";
            this.wattsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // batterymahperkmDataGridViewTextBoxColumn1
            // 
            this.batterymahperkmDataGridViewTextBoxColumn1.DataPropertyName = "battery_mahperkm";
            resources.ApplyResources(this.batterymahperkmDataGridViewTextBoxColumn1, "batterymahperkmDataGridViewTextBoxColumn1");
            this.batterymahperkmDataGridViewTextBoxColumn1.Name = "batterymahperkmDataGridViewTextBoxColumn1";
            this.batterymahperkmDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // batterykmleftDataGridViewTextBoxColumn1
            // 
            this.batterykmleftDataGridViewTextBoxColumn1.DataPropertyName = "battery_kmleft";
            resources.ApplyResources(this.batterykmleftDataGridViewTextBoxColumn1, "batterykmleftDataGridViewTextBoxColumn1");
            this.batterykmleftDataGridViewTextBoxColumn1.Name = "batterykmleftDataGridViewTextBoxColumn1";
            this.batterykmleftDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // batteryusedmahDataGridViewTextBoxColumn1
            // 
            this.batteryusedmahDataGridViewTextBoxColumn1.DataPropertyName = "battery_usedmah";
            resources.ApplyResources(this.batteryusedmahDataGridViewTextBoxColumn1, "batteryusedmahDataGridViewTextBoxColumn1");
            this.batteryusedmahDataGridViewTextBoxColumn1.Name = "batteryusedmahDataGridViewTextBoxColumn1";
            // 
            // batterycell1DataGridViewTextBoxColumn1
            // 
            this.batterycell1DataGridViewTextBoxColumn1.DataPropertyName = "battery_cell1";
            resources.ApplyResources(this.batterycell1DataGridViewTextBoxColumn1, "batterycell1DataGridViewTextBoxColumn1");
            this.batterycell1DataGridViewTextBoxColumn1.Name = "batterycell1DataGridViewTextBoxColumn1";
            // 
            // batterycell2DataGridViewTextBoxColumn1
            // 
            this.batterycell2DataGridViewTextBoxColumn1.DataPropertyName = "battery_cell2";
            resources.ApplyResources(this.batterycell2DataGridViewTextBoxColumn1, "batterycell2DataGridViewTextBoxColumn1");
            this.batterycell2DataGridViewTextBoxColumn1.Name = "batterycell2DataGridViewTextBoxColumn1";
            // 
            // batterycell3DataGridViewTextBoxColumn1
            // 
            this.batterycell3DataGridViewTextBoxColumn1.DataPropertyName = "battery_cell3";
            resources.ApplyResources(this.batterycell3DataGridViewTextBoxColumn1, "batterycell3DataGridViewTextBoxColumn1");
            this.batterycell3DataGridViewTextBoxColumn1.Name = "batterycell3DataGridViewTextBoxColumn1";
            // 
            // batterycell4DataGridViewTextBoxColumn1
            // 
            this.batterycell4DataGridViewTextBoxColumn1.DataPropertyName = "battery_cell4";
            resources.ApplyResources(this.batterycell4DataGridViewTextBoxColumn1, "batterycell4DataGridViewTextBoxColumn1");
            this.batterycell4DataGridViewTextBoxColumn1.Name = "batterycell4DataGridViewTextBoxColumn1";
            // 
            // batterycell5DataGridViewTextBoxColumn1
            // 
            this.batterycell5DataGridViewTextBoxColumn1.DataPropertyName = "battery_cell5";
            resources.ApplyResources(this.batterycell5DataGridViewTextBoxColumn1, "batterycell5DataGridViewTextBoxColumn1");
            this.batterycell5DataGridViewTextBoxColumn1.Name = "batterycell5DataGridViewTextBoxColumn1";
            // 
            // batterycell6DataGridViewTextBoxColumn1
            // 
            this.batterycell6DataGridViewTextBoxColumn1.DataPropertyName = "battery_cell6";
            resources.ApplyResources(this.batterycell6DataGridViewTextBoxColumn1, "batterycell6DataGridViewTextBoxColumn1");
            this.batterycell6DataGridViewTextBoxColumn1.Name = "batterycell6DataGridViewTextBoxColumn1";
            // 
            // batterytempDataGridViewTextBoxColumn1
            // 
            this.batterytempDataGridViewTextBoxColumn1.DataPropertyName = "battery_temp";
            resources.ApplyResources(this.batterytempDataGridViewTextBoxColumn1, "batterytempDataGridViewTextBoxColumn1");
            this.batterytempDataGridViewTextBoxColumn1.Name = "batterytempDataGridViewTextBoxColumn1";
            // 
            // batteryusedmah2DataGridViewTextBoxColumn1
            // 
            this.batteryusedmah2DataGridViewTextBoxColumn1.DataPropertyName = "battery_usedmah2";
            resources.ApplyResources(this.batteryusedmah2DataGridViewTextBoxColumn1, "batteryusedmah2DataGridViewTextBoxColumn1");
            this.batteryusedmah2DataGridViewTextBoxColumn1.Name = "batteryusedmah2DataGridViewTextBoxColumn1";
            // 
            // batteryusedmah3DataGridViewTextBoxColumn1
            // 
            this.batteryusedmah3DataGridViewTextBoxColumn1.DataPropertyName = "battery_usedmah3";
            resources.ApplyResources(this.batteryusedmah3DataGridViewTextBoxColumn1, "batteryusedmah3DataGridViewTextBoxColumn1");
            this.batteryusedmah3DataGridViewTextBoxColumn1.Name = "batteryusedmah3DataGridViewTextBoxColumn1";
            // 
            // batteryusedmah4DataGridViewTextBoxColumn1
            // 
            this.batteryusedmah4DataGridViewTextBoxColumn1.DataPropertyName = "battery_usedmah4";
            resources.ApplyResources(this.batteryusedmah4DataGridViewTextBoxColumn1, "batteryusedmah4DataGridViewTextBoxColumn1");
            this.batteryusedmah4DataGridViewTextBoxColumn1.Name = "batteryusedmah4DataGridViewTextBoxColumn1";
            // 
            // batteryusedmah5DataGridViewTextBoxColumn1
            // 
            this.batteryusedmah5DataGridViewTextBoxColumn1.DataPropertyName = "battery_usedmah5";
            resources.ApplyResources(this.batteryusedmah5DataGridViewTextBoxColumn1, "batteryusedmah5DataGridViewTextBoxColumn1");
            this.batteryusedmah5DataGridViewTextBoxColumn1.Name = "batteryusedmah5DataGridViewTextBoxColumn1";
            // 
            // batteryusedmah6DataGridViewTextBoxColumn1
            // 
            this.batteryusedmah6DataGridViewTextBoxColumn1.DataPropertyName = "battery_usedmah6";
            resources.ApplyResources(this.batteryusedmah6DataGridViewTextBoxColumn1, "batteryusedmah6DataGridViewTextBoxColumn1");
            this.batteryusedmah6DataGridViewTextBoxColumn1.Name = "batteryusedmah6DataGridViewTextBoxColumn1";
            // 
            // batteryusedmah7DataGridViewTextBoxColumn1
            // 
            this.batteryusedmah7DataGridViewTextBoxColumn1.DataPropertyName = "battery_usedmah7";
            resources.ApplyResources(this.batteryusedmah7DataGridViewTextBoxColumn1, "batteryusedmah7DataGridViewTextBoxColumn1");
            this.batteryusedmah7DataGridViewTextBoxColumn1.Name = "batteryusedmah7DataGridViewTextBoxColumn1";
            // 
            // batteryusedmah8DataGridViewTextBoxColumn1
            // 
            this.batteryusedmah8DataGridViewTextBoxColumn1.DataPropertyName = "battery_usedmah8";
            resources.ApplyResources(this.batteryusedmah8DataGridViewTextBoxColumn1, "batteryusedmah8DataGridViewTextBoxColumn1");
            this.batteryusedmah8DataGridViewTextBoxColumn1.Name = "batteryusedmah8DataGridViewTextBoxColumn1";
            // 
            // batteryvoltage2DataGridViewTextBoxColumn1
            // 
            this.batteryvoltage2DataGridViewTextBoxColumn1.DataPropertyName = "battery_voltage2";
            resources.ApplyResources(this.batteryvoltage2DataGridViewTextBoxColumn1, "batteryvoltage2DataGridViewTextBoxColumn1");
            this.batteryvoltage2DataGridViewTextBoxColumn1.Name = "batteryvoltage2DataGridViewTextBoxColumn1";
            // 
            // homeAltDataGridViewTextBoxColumn1
            // 
            this.homeAltDataGridViewTextBoxColumn1.DataPropertyName = "HomeAlt";
            resources.ApplyResources(this.homeAltDataGridViewTextBoxColumn1, "homeAltDataGridViewTextBoxColumn1");
            this.homeAltDataGridViewTextBoxColumn1.Name = "homeAltDataGridViewTextBoxColumn1";
            // 
            // homeLocationDataGridViewTextBoxColumn1
            // 
            this.homeLocationDataGridViewTextBoxColumn1.DataPropertyName = "HomeLocation";
            resources.ApplyResources(this.homeLocationDataGridViewTextBoxColumn1, "homeLocationDataGridViewTextBoxColumn1");
            this.homeLocationDataGridViewTextBoxColumn1.Name = "homeLocationDataGridViewTextBoxColumn1";
            // 
            // movingBaseDataGridViewTextBoxColumn1
            // 
            this.movingBaseDataGridViewTextBoxColumn1.DataPropertyName = "MovingBase";
            resources.ApplyResources(this.movingBaseDataGridViewTextBoxColumn1, "movingBaseDataGridViewTextBoxColumn1");
            this.movingBaseDataGridViewTextBoxColumn1.Name = "movingBaseDataGridViewTextBoxColumn1";
            // 
            // trackerLocationDataGridViewTextBoxColumn1
            // 
            this.trackerLocationDataGridViewTextBoxColumn1.DataPropertyName = "TrackerLocation";
            resources.ApplyResources(this.trackerLocationDataGridViewTextBoxColumn1, "trackerLocationDataGridViewTextBoxColumn1");
            this.trackerLocationDataGridViewTextBoxColumn1.Name = "trackerLocationDataGridViewTextBoxColumn1";
            // 
            // locationDataGridViewTextBoxColumn1
            // 
            this.locationDataGridViewTextBoxColumn1.DataPropertyName = "Location";
            resources.ApplyResources(this.locationDataGridViewTextBoxColumn1, "locationDataGridViewTextBoxColumn1");
            this.locationDataGridViewTextBoxColumn1.Name = "locationDataGridViewTextBoxColumn1";
            this.locationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // targetLocationDataGridViewTextBoxColumn1
            // 
            this.targetLocationDataGridViewTextBoxColumn1.DataPropertyName = "TargetLocation";
            resources.ApplyResources(this.targetLocationDataGridViewTextBoxColumn1, "targetLocationDataGridViewTextBoxColumn1");
            this.targetLocationDataGridViewTextBoxColumn1.Name = "targetLocationDataGridViewTextBoxColumn1";
            // 
            // distToHomeDataGridViewTextBoxColumn1
            // 
            this.distToHomeDataGridViewTextBoxColumn1.DataPropertyName = "DistToHome";
            resources.ApplyResources(this.distToHomeDataGridViewTextBoxColumn1, "distToHomeDataGridViewTextBoxColumn1");
            this.distToHomeDataGridViewTextBoxColumn1.Name = "distToHomeDataGridViewTextBoxColumn1";
            this.distToHomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // distFromMovingBaseDataGridViewTextBoxColumn1
            // 
            this.distFromMovingBaseDataGridViewTextBoxColumn1.DataPropertyName = "DistFromMovingBase";
            resources.ApplyResources(this.distFromMovingBaseDataGridViewTextBoxColumn1, "distFromMovingBaseDataGridViewTextBoxColumn1");
            this.distFromMovingBaseDataGridViewTextBoxColumn1.Name = "distFromMovingBaseDataGridViewTextBoxColumn1";
            this.distFromMovingBaseDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // eLToMAVDataGridViewTextBoxColumn1
            // 
            this.eLToMAVDataGridViewTextBoxColumn1.DataPropertyName = "ELToMAV";
            resources.ApplyResources(this.eLToMAVDataGridViewTextBoxColumn1, "eLToMAVDataGridViewTextBoxColumn1");
            this.eLToMAVDataGridViewTextBoxColumn1.Name = "eLToMAVDataGridViewTextBoxColumn1";
            this.eLToMAVDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aZToMAVDataGridViewTextBoxColumn1
            // 
            this.aZToMAVDataGridViewTextBoxColumn1.DataPropertyName = "AZToMAV";
            resources.ApplyResources(this.aZToMAVDataGridViewTextBoxColumn1, "aZToMAVDataGridViewTextBoxColumn1");
            this.aZToMAVDataGridViewTextBoxColumn1.Name = "aZToMAVDataGridViewTextBoxColumn1";
            this.aZToMAVDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sonarrangeDataGridViewTextBoxColumn1
            // 
            this.sonarrangeDataGridViewTextBoxColumn1.DataPropertyName = "sonarrange";
            resources.ApplyResources(this.sonarrangeDataGridViewTextBoxColumn1, "sonarrangeDataGridViewTextBoxColumn1");
            this.sonarrangeDataGridViewTextBoxColumn1.Name = "sonarrangeDataGridViewTextBoxColumn1";
            // 
            // sonarvoltageDataGridViewTextBoxColumn1
            // 
            this.sonarvoltageDataGridViewTextBoxColumn1.DataPropertyName = "sonarvoltage";
            resources.ApplyResources(this.sonarvoltageDataGridViewTextBoxColumn1, "sonarvoltageDataGridViewTextBoxColumn1");
            this.sonarvoltageDataGridViewTextBoxColumn1.Name = "sonarvoltageDataGridViewTextBoxColumn1";
            // 
            // rangefinder1DataGridViewTextBoxColumn1
            // 
            this.rangefinder1DataGridViewTextBoxColumn1.DataPropertyName = "rangefinder1";
            resources.ApplyResources(this.rangefinder1DataGridViewTextBoxColumn1, "rangefinder1DataGridViewTextBoxColumn1");
            this.rangefinder1DataGridViewTextBoxColumn1.Name = "rangefinder1DataGridViewTextBoxColumn1";
            // 
            // rangefinder2DataGridViewTextBoxColumn1
            // 
            this.rangefinder2DataGridViewTextBoxColumn1.DataPropertyName = "rangefinder2";
            resources.ApplyResources(this.rangefinder2DataGridViewTextBoxColumn1, "rangefinder2DataGridViewTextBoxColumn1");
            this.rangefinder2DataGridViewTextBoxColumn1.Name = "rangefinder2DataGridViewTextBoxColumn1";
            // 
            // rangefinder3DataGridViewTextBoxColumn1
            // 
            this.rangefinder3DataGridViewTextBoxColumn1.DataPropertyName = "rangefinder3";
            resources.ApplyResources(this.rangefinder3DataGridViewTextBoxColumn1, "rangefinder3DataGridViewTextBoxColumn1");
            this.rangefinder3DataGridViewTextBoxColumn1.Name = "rangefinder3DataGridViewTextBoxColumn1";
            // 
            // freememDataGridViewTextBoxColumn1
            // 
            this.freememDataGridViewTextBoxColumn1.DataPropertyName = "freemem";
            resources.ApplyResources(this.freememDataGridViewTextBoxColumn1, "freememDataGridViewTextBoxColumn1");
            this.freememDataGridViewTextBoxColumn1.Name = "freememDataGridViewTextBoxColumn1";
            // 
            // loadDataGridViewTextBoxColumn1
            // 
            this.loadDataGridViewTextBoxColumn1.DataPropertyName = "load";
            resources.ApplyResources(this.loadDataGridViewTextBoxColumn1, "loadDataGridViewTextBoxColumn1");
            this.loadDataGridViewTextBoxColumn1.Name = "loadDataGridViewTextBoxColumn1";
            // 
            // brklevelDataGridViewTextBoxColumn1
            // 
            this.brklevelDataGridViewTextBoxColumn1.DataPropertyName = "brklevel";
            resources.ApplyResources(this.brklevelDataGridViewTextBoxColumn1, "brklevelDataGridViewTextBoxColumn1");
            this.brklevelDataGridViewTextBoxColumn1.Name = "brklevelDataGridViewTextBoxColumn1";
            // 
            // armedDataGridViewCheckBoxColumn1
            // 
            this.armedDataGridViewCheckBoxColumn1.DataPropertyName = "armed";
            resources.ApplyResources(this.armedDataGridViewCheckBoxColumn1, "armedDataGridViewCheckBoxColumn1");
            this.armedDataGridViewCheckBoxColumn1.Name = "armedDataGridViewCheckBoxColumn1";
            // 
            // rssiDataGridViewTextBoxColumn1
            // 
            this.rssiDataGridViewTextBoxColumn1.DataPropertyName = "rssi";
            resources.ApplyResources(this.rssiDataGridViewTextBoxColumn1, "rssiDataGridViewTextBoxColumn1");
            this.rssiDataGridViewTextBoxColumn1.Name = "rssiDataGridViewTextBoxColumn1";
            // 
            // remrssiDataGridViewTextBoxColumn1
            // 
            this.remrssiDataGridViewTextBoxColumn1.DataPropertyName = "remrssi";
            resources.ApplyResources(this.remrssiDataGridViewTextBoxColumn1, "remrssiDataGridViewTextBoxColumn1");
            this.remrssiDataGridViewTextBoxColumn1.Name = "remrssiDataGridViewTextBoxColumn1";
            // 
            // txbufferDataGridViewTextBoxColumn1
            // 
            this.txbufferDataGridViewTextBoxColumn1.DataPropertyName = "txbuffer";
            resources.ApplyResources(this.txbufferDataGridViewTextBoxColumn1, "txbufferDataGridViewTextBoxColumn1");
            this.txbufferDataGridViewTextBoxColumn1.Name = "txbufferDataGridViewTextBoxColumn1";
            // 
            // noiseDataGridViewTextBoxColumn1
            // 
            this.noiseDataGridViewTextBoxColumn1.DataPropertyName = "noise";
            resources.ApplyResources(this.noiseDataGridViewTextBoxColumn1, "noiseDataGridViewTextBoxColumn1");
            this.noiseDataGridViewTextBoxColumn1.Name = "noiseDataGridViewTextBoxColumn1";
            // 
            // remnoiseDataGridViewTextBoxColumn1
            // 
            this.remnoiseDataGridViewTextBoxColumn1.DataPropertyName = "remnoise";
            resources.ApplyResources(this.remnoiseDataGridViewTextBoxColumn1, "remnoiseDataGridViewTextBoxColumn1");
            this.remnoiseDataGridViewTextBoxColumn1.Name = "remnoiseDataGridViewTextBoxColumn1";
            // 
            // rxerrorsDataGridViewTextBoxColumn1
            // 
            this.rxerrorsDataGridViewTextBoxColumn1.DataPropertyName = "rxerrors";
            resources.ApplyResources(this.rxerrorsDataGridViewTextBoxColumn1, "rxerrorsDataGridViewTextBoxColumn1");
            this.rxerrorsDataGridViewTextBoxColumn1.Name = "rxerrorsDataGridViewTextBoxColumn1";
            // 
            // fixedpDataGridViewTextBoxColumn1
            // 
            this.fixedpDataGridViewTextBoxColumn1.DataPropertyName = "fixedp";
            resources.ApplyResources(this.fixedpDataGridViewTextBoxColumn1, "fixedpDataGridViewTextBoxColumn1");
            this.fixedpDataGridViewTextBoxColumn1.Name = "fixedpDataGridViewTextBoxColumn1";
            // 
            // localsnrdbDataGridViewTextBoxColumn1
            // 
            this.localsnrdbDataGridViewTextBoxColumn1.DataPropertyName = "localsnrdb";
            resources.ApplyResources(this.localsnrdbDataGridViewTextBoxColumn1, "localsnrdbDataGridViewTextBoxColumn1");
            this.localsnrdbDataGridViewTextBoxColumn1.Name = "localsnrdbDataGridViewTextBoxColumn1";
            this.localsnrdbDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // remotesnrdbDataGridViewTextBoxColumn1
            // 
            this.remotesnrdbDataGridViewTextBoxColumn1.DataPropertyName = "remotesnrdb";
            resources.ApplyResources(this.remotesnrdbDataGridViewTextBoxColumn1, "remotesnrdbDataGridViewTextBoxColumn1");
            this.remotesnrdbDataGridViewTextBoxColumn1.Name = "remotesnrdbDataGridViewTextBoxColumn1";
            this.remotesnrdbDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // distRSSIRemainDataGridViewTextBoxColumn1
            // 
            this.distRSSIRemainDataGridViewTextBoxColumn1.DataPropertyName = "DistRSSIRemain";
            resources.ApplyResources(this.distRSSIRemainDataGridViewTextBoxColumn1, "distRSSIRemainDataGridViewTextBoxColumn1");
            this.distRSSIRemainDataGridViewTextBoxColumn1.Name = "distRSSIRemainDataGridViewTextBoxColumn1";
            this.distRSSIRemainDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // packetdropremoteDataGridViewTextBoxColumn1
            // 
            this.packetdropremoteDataGridViewTextBoxColumn1.DataPropertyName = "packetdropremote";
            resources.ApplyResources(this.packetdropremoteDataGridViewTextBoxColumn1, "packetdropremoteDataGridViewTextBoxColumn1");
            this.packetdropremoteDataGridViewTextBoxColumn1.Name = "packetdropremoteDataGridViewTextBoxColumn1";
            // 
            // linkqualitygcsDataGridViewTextBoxColumn1
            // 
            this.linkqualitygcsDataGridViewTextBoxColumn1.DataPropertyName = "linkqualitygcs";
            resources.ApplyResources(this.linkqualitygcsDataGridViewTextBoxColumn1, "linkqualitygcsDataGridViewTextBoxColumn1");
            this.linkqualitygcsDataGridViewTextBoxColumn1.Name = "linkqualitygcsDataGridViewTextBoxColumn1";
            // 
            // hwvoltageDataGridViewTextBoxColumn1
            // 
            this.hwvoltageDataGridViewTextBoxColumn1.DataPropertyName = "hwvoltage";
            resources.ApplyResources(this.hwvoltageDataGridViewTextBoxColumn1, "hwvoltageDataGridViewTextBoxColumn1");
            this.hwvoltageDataGridViewTextBoxColumn1.Name = "hwvoltageDataGridViewTextBoxColumn1";
            // 
            // boardvoltageDataGridViewTextBoxColumn1
            // 
            this.boardvoltageDataGridViewTextBoxColumn1.DataPropertyName = "boardvoltage";
            resources.ApplyResources(this.boardvoltageDataGridViewTextBoxColumn1, "boardvoltageDataGridViewTextBoxColumn1");
            this.boardvoltageDataGridViewTextBoxColumn1.Name = "boardvoltageDataGridViewTextBoxColumn1";
            // 
            // servovoltageDataGridViewTextBoxColumn1
            // 
            this.servovoltageDataGridViewTextBoxColumn1.DataPropertyName = "servovoltage";
            resources.ApplyResources(this.servovoltageDataGridViewTextBoxColumn1, "servovoltageDataGridViewTextBoxColumn1");
            this.servovoltageDataGridViewTextBoxColumn1.Name = "servovoltageDataGridViewTextBoxColumn1";
            // 
            // voltageflagDataGridViewTextBoxColumn1
            // 
            this.voltageflagDataGridViewTextBoxColumn1.DataPropertyName = "voltageflag";
            resources.ApplyResources(this.voltageflagDataGridViewTextBoxColumn1, "voltageflagDataGridViewTextBoxColumn1");
            this.voltageflagDataGridViewTextBoxColumn1.Name = "voltageflagDataGridViewTextBoxColumn1";
            // 
            // i2cerrorsDataGridViewTextBoxColumn1
            // 
            this.i2cerrorsDataGridViewTextBoxColumn1.DataPropertyName = "i2cerrors";
            resources.ApplyResources(this.i2cerrorsDataGridViewTextBoxColumn1, "i2cerrorsDataGridViewTextBoxColumn1");
            this.i2cerrorsDataGridViewTextBoxColumn1.Name = "i2cerrorsDataGridViewTextBoxColumn1";
            // 
            // timesincelastshotDataGridViewTextBoxColumn1
            // 
            this.timesincelastshotDataGridViewTextBoxColumn1.DataPropertyName = "timesincelastshot";
            resources.ApplyResources(this.timesincelastshotDataGridViewTextBoxColumn1, "timesincelastshotDataGridViewTextBoxColumn1");
            this.timesincelastshotDataGridViewTextBoxColumn1.Name = "timesincelastshotDataGridViewTextBoxColumn1";
            // 
            // pressabsDataGridViewTextBoxColumn1
            // 
            this.pressabsDataGridViewTextBoxColumn1.DataPropertyName = "press_abs";
            resources.ApplyResources(this.pressabsDataGridViewTextBoxColumn1, "pressabsDataGridViewTextBoxColumn1");
            this.pressabsDataGridViewTextBoxColumn1.Name = "pressabsDataGridViewTextBoxColumn1";
            // 
            // presstempDataGridViewTextBoxColumn1
            // 
            this.presstempDataGridViewTextBoxColumn1.DataPropertyName = "press_temp";
            resources.ApplyResources(this.presstempDataGridViewTextBoxColumn1, "presstempDataGridViewTextBoxColumn1");
            this.presstempDataGridViewTextBoxColumn1.Name = "presstempDataGridViewTextBoxColumn1";
            // 
            // pressabs2DataGridViewTextBoxColumn1
            // 
            this.pressabs2DataGridViewTextBoxColumn1.DataPropertyName = "press_abs2";
            resources.ApplyResources(this.pressabs2DataGridViewTextBoxColumn1, "pressabs2DataGridViewTextBoxColumn1");
            this.pressabs2DataGridViewTextBoxColumn1.Name = "pressabs2DataGridViewTextBoxColumn1";
            // 
            // presstemp2DataGridViewTextBoxColumn1
            // 
            this.presstemp2DataGridViewTextBoxColumn1.DataPropertyName = "press_temp2";
            resources.ApplyResources(this.presstemp2DataGridViewTextBoxColumn1, "presstemp2DataGridViewTextBoxColumn1");
            this.presstemp2DataGridViewTextBoxColumn1.Name = "presstemp2DataGridViewTextBoxColumn1";
            // 
            // magofsxDataGridViewTextBoxColumn1
            // 
            this.magofsxDataGridViewTextBoxColumn1.DataPropertyName = "mag_ofs_x";
            resources.ApplyResources(this.magofsxDataGridViewTextBoxColumn1, "magofsxDataGridViewTextBoxColumn1");
            this.magofsxDataGridViewTextBoxColumn1.Name = "magofsxDataGridViewTextBoxColumn1";
            // 
            // magofsyDataGridViewTextBoxColumn1
            // 
            this.magofsyDataGridViewTextBoxColumn1.DataPropertyName = "mag_ofs_y";
            resources.ApplyResources(this.magofsyDataGridViewTextBoxColumn1, "magofsyDataGridViewTextBoxColumn1");
            this.magofsyDataGridViewTextBoxColumn1.Name = "magofsyDataGridViewTextBoxColumn1";
            // 
            // magofszDataGridViewTextBoxColumn1
            // 
            this.magofszDataGridViewTextBoxColumn1.DataPropertyName = "mag_ofs_z";
            resources.ApplyResources(this.magofszDataGridViewTextBoxColumn1, "magofszDataGridViewTextBoxColumn1");
            this.magofszDataGridViewTextBoxColumn1.Name = "magofszDataGridViewTextBoxColumn1";
            // 
            // magdeclinationDataGridViewTextBoxColumn1
            // 
            this.magdeclinationDataGridViewTextBoxColumn1.DataPropertyName = "mag_declination";
            resources.ApplyResources(this.magdeclinationDataGridViewTextBoxColumn1, "magdeclinationDataGridViewTextBoxColumn1");
            this.magdeclinationDataGridViewTextBoxColumn1.Name = "magdeclinationDataGridViewTextBoxColumn1";
            // 
            // rawpressDataGridViewTextBoxColumn1
            // 
            this.rawpressDataGridViewTextBoxColumn1.DataPropertyName = "raw_press";
            resources.ApplyResources(this.rawpressDataGridViewTextBoxColumn1, "rawpressDataGridViewTextBoxColumn1");
            this.rawpressDataGridViewTextBoxColumn1.Name = "rawpressDataGridViewTextBoxColumn1";
            // 
            // rawtempDataGridViewTextBoxColumn1
            // 
            this.rawtempDataGridViewTextBoxColumn1.DataPropertyName = "raw_temp";
            resources.ApplyResources(this.rawtempDataGridViewTextBoxColumn1, "rawtempDataGridViewTextBoxColumn1");
            this.rawtempDataGridViewTextBoxColumn1.Name = "rawtempDataGridViewTextBoxColumn1";
            // 
            // gyrocalxDataGridViewTextBoxColumn1
            // 
            this.gyrocalxDataGridViewTextBoxColumn1.DataPropertyName = "gyro_cal_x";
            resources.ApplyResources(this.gyrocalxDataGridViewTextBoxColumn1, "gyrocalxDataGridViewTextBoxColumn1");
            this.gyrocalxDataGridViewTextBoxColumn1.Name = "gyrocalxDataGridViewTextBoxColumn1";
            // 
            // gyrocalyDataGridViewTextBoxColumn1
            // 
            this.gyrocalyDataGridViewTextBoxColumn1.DataPropertyName = "gyro_cal_y";
            resources.ApplyResources(this.gyrocalyDataGridViewTextBoxColumn1, "gyrocalyDataGridViewTextBoxColumn1");
            this.gyrocalyDataGridViewTextBoxColumn1.Name = "gyrocalyDataGridViewTextBoxColumn1";
            // 
            // gyrocalzDataGridViewTextBoxColumn1
            // 
            this.gyrocalzDataGridViewTextBoxColumn1.DataPropertyName = "gyro_cal_z";
            resources.ApplyResources(this.gyrocalzDataGridViewTextBoxColumn1, "gyrocalzDataGridViewTextBoxColumn1");
            this.gyrocalzDataGridViewTextBoxColumn1.Name = "gyrocalzDataGridViewTextBoxColumn1";
            // 
            // accelcalxDataGridViewTextBoxColumn1
            // 
            this.accelcalxDataGridViewTextBoxColumn1.DataPropertyName = "accel_cal_x";
            resources.ApplyResources(this.accelcalxDataGridViewTextBoxColumn1, "accelcalxDataGridViewTextBoxColumn1");
            this.accelcalxDataGridViewTextBoxColumn1.Name = "accelcalxDataGridViewTextBoxColumn1";
            // 
            // accelcalyDataGridViewTextBoxColumn1
            // 
            this.accelcalyDataGridViewTextBoxColumn1.DataPropertyName = "accel_cal_y";
            resources.ApplyResources(this.accelcalyDataGridViewTextBoxColumn1, "accelcalyDataGridViewTextBoxColumn1");
            this.accelcalyDataGridViewTextBoxColumn1.Name = "accelcalyDataGridViewTextBoxColumn1";
            // 
            // accelcalzDataGridViewTextBoxColumn1
            // 
            this.accelcalzDataGridViewTextBoxColumn1.DataPropertyName = "accel_cal_z";
            resources.ApplyResources(this.accelcalzDataGridViewTextBoxColumn1, "accelcalzDataGridViewTextBoxColumn1");
            this.accelcalzDataGridViewTextBoxColumn1.Name = "accelcalzDataGridViewTextBoxColumn1";
            // 
            // rateattitudeDataGridViewTextBoxColumn1
            // 
            this.rateattitudeDataGridViewTextBoxColumn1.DataPropertyName = "rateattitude";
            resources.ApplyResources(this.rateattitudeDataGridViewTextBoxColumn1, "rateattitudeDataGridViewTextBoxColumn1");
            this.rateattitudeDataGridViewTextBoxColumn1.Name = "rateattitudeDataGridViewTextBoxColumn1";
            // 
            // ratepositionDataGridViewTextBoxColumn1
            // 
            this.ratepositionDataGridViewTextBoxColumn1.DataPropertyName = "rateposition";
            resources.ApplyResources(this.ratepositionDataGridViewTextBoxColumn1, "ratepositionDataGridViewTextBoxColumn1");
            this.ratepositionDataGridViewTextBoxColumn1.Name = "ratepositionDataGridViewTextBoxColumn1";
            // 
            // ratestatusDataGridViewTextBoxColumn1
            // 
            this.ratestatusDataGridViewTextBoxColumn1.DataPropertyName = "ratestatus";
            resources.ApplyResources(this.ratestatusDataGridViewTextBoxColumn1, "ratestatusDataGridViewTextBoxColumn1");
            this.ratestatusDataGridViewTextBoxColumn1.Name = "ratestatusDataGridViewTextBoxColumn1";
            // 
            // ratesensorsDataGridViewTextBoxColumn1
            // 
            this.ratesensorsDataGridViewTextBoxColumn1.DataPropertyName = "ratesensors";
            resources.ApplyResources(this.ratesensorsDataGridViewTextBoxColumn1, "ratesensorsDataGridViewTextBoxColumn1");
            this.ratesensorsDataGridViewTextBoxColumn1.Name = "ratesensorsDataGridViewTextBoxColumn1";
            // 
            // ratercDataGridViewTextBoxColumn1
            // 
            this.ratercDataGridViewTextBoxColumn1.DataPropertyName = "raterc";
            resources.ApplyResources(this.ratercDataGridViewTextBoxColumn1, "ratercDataGridViewTextBoxColumn1");
            this.ratercDataGridViewTextBoxColumn1.Name = "ratercDataGridViewTextBoxColumn1";
            // 
            // datetimeDataGridViewTextBoxColumn1
            // 
            this.datetimeDataGridViewTextBoxColumn1.DataPropertyName = "datetime";
            resources.ApplyResources(this.datetimeDataGridViewTextBoxColumn1, "datetimeDataGridViewTextBoxColumn1");
            this.datetimeDataGridViewTextBoxColumn1.Name = "datetimeDataGridViewTextBoxColumn1";
            // 
            // connectedDataGridViewCheckBoxColumn1
            // 
            this.connectedDataGridViewCheckBoxColumn1.DataPropertyName = "connected";
            resources.ApplyResources(this.connectedDataGridViewCheckBoxColumn1, "connectedDataGridViewCheckBoxColumn1");
            this.connectedDataGridViewCheckBoxColumn1.Name = "connectedDataGridViewCheckBoxColumn1";
            this.connectedDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // campointaDataGridViewTextBoxColumn1
            // 
            this.campointaDataGridViewTextBoxColumn1.DataPropertyName = "campointa";
            resources.ApplyResources(this.campointaDataGridViewTextBoxColumn1, "campointaDataGridViewTextBoxColumn1");
            this.campointaDataGridViewTextBoxColumn1.Name = "campointaDataGridViewTextBoxColumn1";
            // 
            // campointbDataGridViewTextBoxColumn1
            // 
            this.campointbDataGridViewTextBoxColumn1.DataPropertyName = "campointb";
            resources.ApplyResources(this.campointbDataGridViewTextBoxColumn1, "campointbDataGridViewTextBoxColumn1");
            this.campointbDataGridViewTextBoxColumn1.Name = "campointbDataGridViewTextBoxColumn1";
            // 
            // campointcDataGridViewTextBoxColumn1
            // 
            this.campointcDataGridViewTextBoxColumn1.DataPropertyName = "campointc";
            resources.ApplyResources(this.campointcDataGridViewTextBoxColumn1, "campointcDataGridViewTextBoxColumn1");
            this.campointcDataGridViewTextBoxColumn1.Name = "campointcDataGridViewTextBoxColumn1";
            // 
            // gimbalPointDataGridViewTextBoxColumn1
            // 
            this.gimbalPointDataGridViewTextBoxColumn1.DataPropertyName = "GimbalPoint";
            resources.ApplyResources(this.gimbalPointDataGridViewTextBoxColumn1, "gimbalPointDataGridViewTextBoxColumn1");
            this.gimbalPointDataGridViewTextBoxColumn1.Name = "gimbalPointDataGridViewTextBoxColumn1";
            // 
            // gimballatDataGridViewTextBoxColumn1
            // 
            this.gimballatDataGridViewTextBoxColumn1.DataPropertyName = "gimballat";
            resources.ApplyResources(this.gimballatDataGridViewTextBoxColumn1, "gimballatDataGridViewTextBoxColumn1");
            this.gimballatDataGridViewTextBoxColumn1.Name = "gimballatDataGridViewTextBoxColumn1";
            this.gimballatDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gimballngDataGridViewTextBoxColumn1
            // 
            this.gimballngDataGridViewTextBoxColumn1.DataPropertyName = "gimballng";
            resources.ApplyResources(this.gimballngDataGridViewTextBoxColumn1, "gimballngDataGridViewTextBoxColumn1");
            this.gimballngDataGridViewTextBoxColumn1.Name = "gimballngDataGridViewTextBoxColumn1";
            this.gimballngDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // landedDataGridViewCheckBoxColumn1
            // 
            this.landedDataGridViewCheckBoxColumn1.DataPropertyName = "landed";
            resources.ApplyResources(this.landedDataGridViewCheckBoxColumn1, "landedDataGridViewCheckBoxColumn1");
            this.landedDataGridViewCheckBoxColumn1.Name = "landedDataGridViewCheckBoxColumn1";
            // 
            // terrainactiveDataGridViewCheckBoxColumn1
            // 
            this.terrainactiveDataGridViewCheckBoxColumn1.DataPropertyName = "terrainactive";
            resources.ApplyResources(this.terrainactiveDataGridViewCheckBoxColumn1, "terrainactiveDataGridViewCheckBoxColumn1");
            this.terrainactiveDataGridViewCheckBoxColumn1.Name = "terrainactiveDataGridViewCheckBoxColumn1";
            // 
            // tercuraltDataGridViewTextBoxColumn1
            // 
            this.tercuraltDataGridViewTextBoxColumn1.DataPropertyName = "ter_curalt";
            resources.ApplyResources(this.tercuraltDataGridViewTextBoxColumn1, "tercuraltDataGridViewTextBoxColumn1");
            this.tercuraltDataGridViewTextBoxColumn1.Name = "tercuraltDataGridViewTextBoxColumn1";
            // 
            // teraltDataGridViewTextBoxColumn1
            // 
            this.teraltDataGridViewTextBoxColumn1.DataPropertyName = "ter_alt";
            resources.ApplyResources(this.teraltDataGridViewTextBoxColumn1, "teraltDataGridViewTextBoxColumn1");
            this.teraltDataGridViewTextBoxColumn1.Name = "teraltDataGridViewTextBoxColumn1";
            // 
            // terloadDataGridViewTextBoxColumn1
            // 
            this.terloadDataGridViewTextBoxColumn1.DataPropertyName = "ter_load";
            resources.ApplyResources(this.terloadDataGridViewTextBoxColumn1, "terloadDataGridViewTextBoxColumn1");
            this.terloadDataGridViewTextBoxColumn1.Name = "terloadDataGridViewTextBoxColumn1";
            // 
            // terpendDataGridViewTextBoxColumn1
            // 
            this.terpendDataGridViewTextBoxColumn1.DataPropertyName = "ter_pend";
            resources.ApplyResources(this.terpendDataGridViewTextBoxColumn1, "terpendDataGridViewTextBoxColumn1");
            this.terpendDataGridViewTextBoxColumn1.Name = "terpendDataGridViewTextBoxColumn1";
            // 
            // terspaceDataGridViewTextBoxColumn1
            // 
            this.terspaceDataGridViewTextBoxColumn1.DataPropertyName = "ter_space";
            resources.ApplyResources(this.terspaceDataGridViewTextBoxColumn1, "terspaceDataGridViewTextBoxColumn1");
            this.terspaceDataGridViewTextBoxColumn1.Name = "terspaceDataGridViewTextBoxColumn1";
            // 
            // kIndexDataGridViewTextBoxColumn1
            // 
            this.kIndexDataGridViewTextBoxColumn1.DataPropertyName = "KIndex";
            resources.ApplyResources(this.kIndexDataGridViewTextBoxColumn1, "kIndexDataGridViewTextBoxColumn1");
            this.kIndexDataGridViewTextBoxColumn1.Name = "kIndexDataGridViewTextBoxColumn1";
            this.kIndexDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // optmxDataGridViewTextBoxColumn1
            // 
            this.optmxDataGridViewTextBoxColumn1.DataPropertyName = "opt_m_x";
            resources.ApplyResources(this.optmxDataGridViewTextBoxColumn1, "optmxDataGridViewTextBoxColumn1");
            this.optmxDataGridViewTextBoxColumn1.Name = "optmxDataGridViewTextBoxColumn1";
            // 
            // optmyDataGridViewTextBoxColumn1
            // 
            this.optmyDataGridViewTextBoxColumn1.DataPropertyName = "opt_m_y";
            resources.ApplyResources(this.optmyDataGridViewTextBoxColumn1, "optmyDataGridViewTextBoxColumn1");
            this.optmyDataGridViewTextBoxColumn1.Name = "optmyDataGridViewTextBoxColumn1";
            // 
            // optxDataGridViewTextBoxColumn1
            // 
            this.optxDataGridViewTextBoxColumn1.DataPropertyName = "opt_x";
            resources.ApplyResources(this.optxDataGridViewTextBoxColumn1, "optxDataGridViewTextBoxColumn1");
            this.optxDataGridViewTextBoxColumn1.Name = "optxDataGridViewTextBoxColumn1";
            // 
            // optyDataGridViewTextBoxColumn1
            // 
            this.optyDataGridViewTextBoxColumn1.DataPropertyName = "opt_y";
            resources.ApplyResources(this.optyDataGridViewTextBoxColumn1, "optyDataGridViewTextBoxColumn1");
            this.optyDataGridViewTextBoxColumn1.Name = "optyDataGridViewTextBoxColumn1";
            // 
            // optquaDataGridViewTextBoxColumn1
            // 
            this.optquaDataGridViewTextBoxColumn1.DataPropertyName = "opt_qua";
            resources.ApplyResources(this.optquaDataGridViewTextBoxColumn1, "optquaDataGridViewTextBoxColumn1");
            this.optquaDataGridViewTextBoxColumn1.Name = "optquaDataGridViewTextBoxColumn1";
            // 
            // ekfstatusDataGridViewTextBoxColumn1
            // 
            this.ekfstatusDataGridViewTextBoxColumn1.DataPropertyName = "ekfstatus";
            resources.ApplyResources(this.ekfstatusDataGridViewTextBoxColumn1, "ekfstatusDataGridViewTextBoxColumn1");
            this.ekfstatusDataGridViewTextBoxColumn1.Name = "ekfstatusDataGridViewTextBoxColumn1";
            // 
            // ekfflagsDataGridViewTextBoxColumn1
            // 
            this.ekfflagsDataGridViewTextBoxColumn1.DataPropertyName = "ekfflags";
            resources.ApplyResources(this.ekfflagsDataGridViewTextBoxColumn1, "ekfflagsDataGridViewTextBoxColumn1");
            this.ekfflagsDataGridViewTextBoxColumn1.Name = "ekfflagsDataGridViewTextBoxColumn1";
            // 
            // ekfvelvDataGridViewTextBoxColumn1
            // 
            this.ekfvelvDataGridViewTextBoxColumn1.DataPropertyName = "ekfvelv";
            resources.ApplyResources(this.ekfvelvDataGridViewTextBoxColumn1, "ekfvelvDataGridViewTextBoxColumn1");
            this.ekfvelvDataGridViewTextBoxColumn1.Name = "ekfvelvDataGridViewTextBoxColumn1";
            // 
            // ekfcompvDataGridViewTextBoxColumn1
            // 
            this.ekfcompvDataGridViewTextBoxColumn1.DataPropertyName = "ekfcompv";
            resources.ApplyResources(this.ekfcompvDataGridViewTextBoxColumn1, "ekfcompvDataGridViewTextBoxColumn1");
            this.ekfcompvDataGridViewTextBoxColumn1.Name = "ekfcompvDataGridViewTextBoxColumn1";
            // 
            // ekfposhorDataGridViewTextBoxColumn1
            // 
            this.ekfposhorDataGridViewTextBoxColumn1.DataPropertyName = "ekfposhor";
            resources.ApplyResources(this.ekfposhorDataGridViewTextBoxColumn1, "ekfposhorDataGridViewTextBoxColumn1");
            this.ekfposhorDataGridViewTextBoxColumn1.Name = "ekfposhorDataGridViewTextBoxColumn1";
            // 
            // ekfposvertDataGridViewTextBoxColumn1
            // 
            this.ekfposvertDataGridViewTextBoxColumn1.DataPropertyName = "ekfposvert";
            resources.ApplyResources(this.ekfposvertDataGridViewTextBoxColumn1, "ekfposvertDataGridViewTextBoxColumn1");
            this.ekfposvertDataGridViewTextBoxColumn1.Name = "ekfposvertDataGridViewTextBoxColumn1";
            // 
            // ekfteraltDataGridViewTextBoxColumn1
            // 
            this.ekfteraltDataGridViewTextBoxColumn1.DataPropertyName = "ekfteralt";
            resources.ApplyResources(this.ekfteraltDataGridViewTextBoxColumn1, "ekfteraltDataGridViewTextBoxColumn1");
            this.ekfteraltDataGridViewTextBoxColumn1.Name = "ekfteraltDataGridViewTextBoxColumn1";
            // 
            // pidffDataGridViewTextBoxColumn1
            // 
            this.pidffDataGridViewTextBoxColumn1.DataPropertyName = "pidff";
            resources.ApplyResources(this.pidffDataGridViewTextBoxColumn1, "pidffDataGridViewTextBoxColumn1");
            this.pidffDataGridViewTextBoxColumn1.Name = "pidffDataGridViewTextBoxColumn1";
            // 
            // pidPDataGridViewTextBoxColumn1
            // 
            this.pidPDataGridViewTextBoxColumn1.DataPropertyName = "pidP";
            resources.ApplyResources(this.pidPDataGridViewTextBoxColumn1, "pidPDataGridViewTextBoxColumn1");
            this.pidPDataGridViewTextBoxColumn1.Name = "pidPDataGridViewTextBoxColumn1";
            // 
            // pidIDataGridViewTextBoxColumn1
            // 
            this.pidIDataGridViewTextBoxColumn1.DataPropertyName = "pidI";
            resources.ApplyResources(this.pidIDataGridViewTextBoxColumn1, "pidIDataGridViewTextBoxColumn1");
            this.pidIDataGridViewTextBoxColumn1.Name = "pidIDataGridViewTextBoxColumn1";
            // 
            // pidDDataGridViewTextBoxColumn1
            // 
            this.pidDDataGridViewTextBoxColumn1.DataPropertyName = "pidD";
            resources.ApplyResources(this.pidDDataGridViewTextBoxColumn1, "pidDDataGridViewTextBoxColumn1");
            this.pidDDataGridViewTextBoxColumn1.Name = "pidDDataGridViewTextBoxColumn1";
            // 
            // pidaxisDataGridViewTextBoxColumn1
            // 
            this.pidaxisDataGridViewTextBoxColumn1.DataPropertyName = "pidaxis";
            resources.ApplyResources(this.pidaxisDataGridViewTextBoxColumn1, "pidaxisDataGridViewTextBoxColumn1");
            this.pidaxisDataGridViewTextBoxColumn1.Name = "pidaxisDataGridViewTextBoxColumn1";
            // 
            // piddesiredDataGridViewTextBoxColumn1
            // 
            this.piddesiredDataGridViewTextBoxColumn1.DataPropertyName = "piddesired";
            resources.ApplyResources(this.piddesiredDataGridViewTextBoxColumn1, "piddesiredDataGridViewTextBoxColumn1");
            this.piddesiredDataGridViewTextBoxColumn1.Name = "piddesiredDataGridViewTextBoxColumn1";
            // 
            // pidachievedDataGridViewTextBoxColumn1
            // 
            this.pidachievedDataGridViewTextBoxColumn1.DataPropertyName = "pidachieved";
            resources.ApplyResources(this.pidachievedDataGridViewTextBoxColumn1, "pidachievedDataGridViewTextBoxColumn1");
            this.pidachievedDataGridViewTextBoxColumn1.Name = "pidachievedDataGridViewTextBoxColumn1";
            // 
            // vibeclip0DataGridViewTextBoxColumn1
            // 
            this.vibeclip0DataGridViewTextBoxColumn1.DataPropertyName = "vibeclip0";
            resources.ApplyResources(this.vibeclip0DataGridViewTextBoxColumn1, "vibeclip0DataGridViewTextBoxColumn1");
            this.vibeclip0DataGridViewTextBoxColumn1.Name = "vibeclip0DataGridViewTextBoxColumn1";
            // 
            // vibeclip1DataGridViewTextBoxColumn1
            // 
            this.vibeclip1DataGridViewTextBoxColumn1.DataPropertyName = "vibeclip1";
            resources.ApplyResources(this.vibeclip1DataGridViewTextBoxColumn1, "vibeclip1DataGridViewTextBoxColumn1");
            this.vibeclip1DataGridViewTextBoxColumn1.Name = "vibeclip1DataGridViewTextBoxColumn1";
            // 
            // vibeclip2DataGridViewTextBoxColumn1
            // 
            this.vibeclip2DataGridViewTextBoxColumn1.DataPropertyName = "vibeclip2";
            resources.ApplyResources(this.vibeclip2DataGridViewTextBoxColumn1, "vibeclip2DataGridViewTextBoxColumn1");
            this.vibeclip2DataGridViewTextBoxColumn1.Name = "vibeclip2DataGridViewTextBoxColumn1";
            // 
            // vibexDataGridViewTextBoxColumn1
            // 
            this.vibexDataGridViewTextBoxColumn1.DataPropertyName = "vibex";
            resources.ApplyResources(this.vibexDataGridViewTextBoxColumn1, "vibexDataGridViewTextBoxColumn1");
            this.vibexDataGridViewTextBoxColumn1.Name = "vibexDataGridViewTextBoxColumn1";
            // 
            // vibeyDataGridViewTextBoxColumn1
            // 
            this.vibeyDataGridViewTextBoxColumn1.DataPropertyName = "vibey";
            resources.ApplyResources(this.vibeyDataGridViewTextBoxColumn1, "vibeyDataGridViewTextBoxColumn1");
            this.vibeyDataGridViewTextBoxColumn1.Name = "vibeyDataGridViewTextBoxColumn1";
            // 
            // vibezDataGridViewTextBoxColumn1
            // 
            this.vibezDataGridViewTextBoxColumn1.DataPropertyName = "vibez";
            resources.ApplyResources(this.vibezDataGridViewTextBoxColumn1, "vibezDataGridViewTextBoxColumn1");
            this.vibezDataGridViewTextBoxColumn1.Name = "vibezDataGridViewTextBoxColumn1";
            // 
            // versionDataGridViewTextBoxColumn1
            // 
            this.versionDataGridViewTextBoxColumn1.DataPropertyName = "version";
            resources.ApplyResources(this.versionDataGridViewTextBoxColumn1, "versionDataGridViewTextBoxColumn1");
            this.versionDataGridViewTextBoxColumn1.Name = "versionDataGridViewTextBoxColumn1";
            // 
            // rpm1DataGridViewTextBoxColumn1
            // 
            this.rpm1DataGridViewTextBoxColumn1.DataPropertyName = "rpm1";
            resources.ApplyResources(this.rpm1DataGridViewTextBoxColumn1, "rpm1DataGridViewTextBoxColumn1");
            this.rpm1DataGridViewTextBoxColumn1.Name = "rpm1DataGridViewTextBoxColumn1";
            // 
            // rpm2DataGridViewTextBoxColumn1
            // 
            this.rpm2DataGridViewTextBoxColumn1.DataPropertyName = "rpm2";
            resources.ApplyResources(this.rpm2DataGridViewTextBoxColumn1, "rpm2DataGridViewTextBoxColumn1");
            this.rpm2DataGridViewTextBoxColumn1.Name = "rpm2DataGridViewTextBoxColumn1";
            // 
            // capabilitiesDataGridViewTextBoxColumn1
            // 
            this.capabilitiesDataGridViewTextBoxColumn1.DataPropertyName = "capabilities";
            resources.ApplyResources(this.capabilitiesDataGridViewTextBoxColumn1, "capabilitiesDataGridViewTextBoxColumn1");
            this.capabilitiesDataGridViewTextBoxColumn1.Name = "capabilitiesDataGridViewTextBoxColumn1";
            // 
            // speedupDataGridViewTextBoxColumn1
            // 
            this.speedupDataGridViewTextBoxColumn1.DataPropertyName = "speedup";
            resources.ApplyResources(this.speedupDataGridViewTextBoxColumn1, "speedupDataGridViewTextBoxColumn1");
            this.speedupDataGridViewTextBoxColumn1.Name = "speedupDataGridViewTextBoxColumn1";
            // 
            // vtolstateDataGridViewTextBoxColumn1
            // 
            this.vtolstateDataGridViewTextBoxColumn1.DataPropertyName = "vtol_state";
            resources.ApplyResources(this.vtolstateDataGridViewTextBoxColumn1, "vtolstateDataGridViewTextBoxColumn1");
            this.vtolstateDataGridViewTextBoxColumn1.Name = "vtolstateDataGridViewTextBoxColumn1";
            this.vtolstateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // landedstateDataGridViewTextBoxColumn1
            // 
            this.landedstateDataGridViewTextBoxColumn1.DataPropertyName = "landed_state";
            resources.ApplyResources(this.landedstateDataGridViewTextBoxColumn1, "landedstateDataGridViewTextBoxColumn1");
            this.landedstateDataGridViewTextBoxColumn1.Name = "landedstateDataGridViewTextBoxColumn1";
            this.landedstateDataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.SubMainLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).EndInit();
            this.SubMainLeft.ResumeLayout(false);
            this.contextMenuStripHud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).EndInit();
            this.tabControlactions.ResumeLayout(false);
            this.contextMenuStripactionstab.ResumeLayout(false);
            this.tabQuick.ResumeLayout(false);
            this.tableLayoutPanelQuick.ResumeLayout(false);
            this.tableLayoutPanelQuick.PerformLayout();
            this.tabActions.ResumeLayout(false);
            this.tabActions.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).EndInit();
            this.contextMenuStripQuickView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private System.Windows.Forms.SplitContainer MainH;
        private System.Windows.Forms.SplitContainer SubMainLeft;
        private System.Windows.Forms.ToolStripMenuItem goHereToolStripMenuItem;
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
        private Controls.MyButton BUT_joystick;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yawDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aOADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundcourseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn latDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lngDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn altDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn altaslDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horizondistDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vzDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn altoffsethomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsstatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpshdopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn satcountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpshaccDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsvaccDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsvelaccDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpshdgaccDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lat2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lng2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn altasl2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsstatus2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpshdop2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn satcount2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundspeed2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundcourse2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn satcountBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpstimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn altd1000DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn altd100DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn airspeedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetairspeedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lowairspeedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asratioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundspeedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn axDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn azDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelsqDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gzDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrosqDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn myDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mzDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magfieldDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ax2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ay2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn az2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelsq2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gx2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gy2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gz2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrosq2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mx2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn my2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mz2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magfield2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ax3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ay3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn az3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelsq3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gx3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gy3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gz3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrosq3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mx3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn my3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mz3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magfield3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch1inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch2inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch3inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch4inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch5inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch6inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch7inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch8inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch9inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch10inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch11inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch12inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch13inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch14inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch15inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch16inDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch1outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch2outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch3outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch4outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch5outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch6outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch7outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch8outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch9outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch10outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch11outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch12outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch13outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch14outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch15outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch16outDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc1voltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc1currDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc1rpmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc1tempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc2voltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc2currDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc2rpmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc2tempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc3voltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc3currDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc3rpmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc3tempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc4voltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc4currDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc4rpmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc4tempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc5voltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc5currDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc5rpmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc5tempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc6voltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc6currDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc6rpmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc6tempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc7voltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc7currDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc7rpmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc7tempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc8voltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc8currDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc8rpmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esc8tempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch3percentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn failsafeDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rxrssiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn critAOADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lowgroundspeedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticalspeedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticalspeedfpmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn glideratioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn navrollDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn navpitchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn navbearingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetbearingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpdistDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alterrorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bererrorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aspderrorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtrackerrorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpnoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn climbrateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tohDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distTraveledDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSinceArmInAirDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInAirDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInAirMinSecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnrateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn turngDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn radiusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qNHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn winddirDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn windvelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetaltd100DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetaltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageHighDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageHighTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage4DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage5DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage6DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage7DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage8DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremainingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining4DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining5DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining6DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining7DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryremaining8DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn current2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn current3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn current4DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn current5DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn current6DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn current7DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn current8DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wattsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterymahperkmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterykmleftDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmahDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell4DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell5DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterycell6DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterytempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah4DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah5DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah6DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah7DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryusedmah8DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batteryvoltage2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeLocationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movingBaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackerLocationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetLocationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distToHomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distFromMovingBaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLToMAVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aZToMAVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonarrangeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonarvoltageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangefinder1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangefinder2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangefinder3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn freememDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brklevelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn armedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rssiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remrssiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbufferDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remnoiseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rxerrorsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedpDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn localsnrdbDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remotesnrdbDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distRSSIRemainDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packetdropremoteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkqualitygcsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hwvoltageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardvoltageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn servovoltageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageflagDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn i2cerrorsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timesincelastshotDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressabsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn presstempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressabs2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn presstemp2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magofsxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magofsyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magofszDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magdeclinationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawpressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawtempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrocalxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrocalyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrocalzDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelcalxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelcalyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelcalzDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateattitudeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratepositionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratestatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratesensorsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratercDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn connectedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn campointaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn campointbDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn campointcDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gimbalPointDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gimballatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gimballngDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn landedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn terrainactiveDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tercuraltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teraltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn terloadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn terpendDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn terspaceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIndexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn optmxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn optmyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn optxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn optyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn optquaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfstatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfflagsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfvelvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfcompvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfposhorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfposvertDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekfteraltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidffDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidaxisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn piddesiredDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidachievedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibeclip0DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibeclip1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibeclip2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibeyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibezDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpm1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpm2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn capabilitiesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtolstateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn landedstateDataGridViewTextBoxColumn1;
    }
}