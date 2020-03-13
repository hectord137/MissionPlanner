using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews
{
    partial class FlightPlanner
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

            if (FlightPlannerBase.currentMarker != null) FlightPlannerBase.currentMarker.Dispose();
            if (FlightPlannerBase.drawnpolygon != null) FlightPlannerBase.drawnpolygon.Dispose();
            if (FlightPlannerBase.kmlpolygonsoverlay != null) FlightPlannerBase.kmlpolygonsoverlay.Dispose();
            if (FlightPlannerBase.wppolygon != null) FlightPlannerBase.wppolygon.Dispose();
            if (FlightPlannerBase.top != null) FlightPlannerBase.top.Dispose();
            if (FlightPlannerBase.geofencepolygon != null) FlightPlannerBase.geofencepolygon.Dispose();
            if (FlightPlannerBase.geofenceoverlay != null) FlightPlannerBase.geofenceoverlay.Dispose();
            if (FlightPlannerBase.drawnpolygonsoverlay != null) FlightPlannerBase.drawnpolygonsoverlay.Dispose();
            if (FlightPlannerBase.center != null) FlightPlannerBase.center.Dispose(); 

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CHK_verifyheight = new System.Windows.Forms.CheckBox();
            this.TXT_WPRad = new System.Windows.Forms.TextBox();
            this.TXT_DefaultAlt = new System.Windows.Forms.TextBox();
            this.LBL_WPRad = new System.Windows.Forms.Label();
            this.LBL_defalutalt = new System.Windows.Forms.Label();
            this.TXT_loiterrad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BUT_write = new MissionPlanner.Controls.MyButton();
            this.BUT_read = new MissionPlanner.Controls.MyButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.lbl_status = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton8 = new MissionPlanner.Controls.MyButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_Add = new MissionPlanner.Controls.MyButton();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.CMB_altmode = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelAction = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_wpfile = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_missiontype = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDelTiff = new MissionPlanner.Controls.MyButton();
            this.myButton7 = new MissionPlanner.Controls.MyButton();
            this.BtnTiff = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnKMLOverlay = new MissionPlanner.Controls.MyButton();
            this.Buttmeasurecontext = new MissionPlanner.Controls.MyButton();
            this.BUt_sethome = new MissionPlanner.Controls.MyButton();
            this.BtnClearKml = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ButInsertPol = new MissionPlanner.Controls.MyButton();
            this.ButClearPol = new MissionPlanner.Controls.MyButton();
            this.BtSavePol = new MissionPlanner.Controls.MyButton();
            this.ButLoadPol = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton5 = new MissionPlanner.Controls.MyButton();
            this.myButton4 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.myButton6 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_loadwpfile = new MissionPlanner.Controls.MyButton();
            this.BUT_insertWP = new MissionPlanner.Controls.MyButton();
            this.ButDelwp = new MissionPlanner.Controls.MyButton();
            this.BUT_saveWPFile = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.lnk_kml = new System.Windows.Forms.LinkLabel();
            this.chk_grid = new System.Windows.Forms.CheckBox();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.lblmaps = new System.Windows.Forms.Label();
            this.LBLarea = new System.Windows.Forms.Label();
            this.label4s = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelMap = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.But_SurveyGrid = new MissionPlanner.Controls.MyButton();
            this.PaneMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.lblestm = new System.Windows.Forms.Label();
            this.lblnstrips = new System.Windows.Forms.Label();
            this.lblbetween = new System.Windows.Forms.Label();
            this.label9s = new System.Windows.Forms.Label();
            this.lbldistancia = new System.Windows.Forms.Label();
            this.LBLdist = new System.Windows.Forms.Label();
            this.label10s = new System.Windows.Forms.Label();
            this.lblstrips = new System.Windows.Forms.Label();
            this.splitter3 = new BSE.Windows.Forms.Splitter();
            this.lbl_homedist = new System.Windows.Forms.Label();
            this.lbl_prevdist = new System.Windows.Forms.Label();
            this.trackBar1 = new MissionPlanner.Controls.MyTrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.MainMap = new MissionPlanner.Controls.myGMAP();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertWpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSplineWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterForeverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitercirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpwPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.geoFenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.GeoFenceuploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoFencedownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReturnLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRallyPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWpCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSplineCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCircleSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchWPPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLOverlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevationGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseWPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLoadSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSHPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poiaddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poideleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poieditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterUTMCoordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchDockingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBASE = new System.Windows.Forms.Panel();
            this.panelWaypoints = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripPoly = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fenceInclusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenceExclusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawAPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Commands = new MissionPlanner.Controls.MyDataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frame = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.coordZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordEasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordNorthing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MGRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelAction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.PaneMenu.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelBASE.SuspendLayout();
            this.panelWaypoints.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.contextMenuStripPoly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.SuspendLayout();
            // 
            // CHK_verifyheight
            // 
            resources.ApplyResources(this.CHK_verifyheight, "CHK_verifyheight");
            this.CHK_verifyheight.Name = "CHK_verifyheight";
            this.CHK_verifyheight.UseVisualStyleBackColor = true;
            // 
            // TXT_WPRad
            // 
            resources.ApplyResources(this.TXT_WPRad, "TXT_WPRad");
            this.TXT_WPRad.Name = "TXT_WPRad";
            this.TXT_WPRad.TextChanged += new System.EventHandler(this.TXT_WPRad_TextChanged);
            // 
            // TXT_DefaultAlt
            // 
            resources.ApplyResources(this.TXT_DefaultAlt, "TXT_DefaultAlt");
            this.TXT_DefaultAlt.Name = "TXT_DefaultAlt";
            // 
            // LBL_WPRad
            // 
            resources.ApplyResources(this.LBL_WPRad, "LBL_WPRad");
            this.LBL_WPRad.Name = "LBL_WPRad";
            this.LBL_WPRad.Click += new System.EventHandler(this.LBL_WPRad_Click);
            // 
            // LBL_defalutalt
            // 
            resources.ApplyResources(this.LBL_defalutalt, "LBL_defalutalt");
            this.LBL_defalutalt.Name = "LBL_defalutalt";
            // 
            // TXT_loiterrad
            // 
            resources.ApplyResources(this.TXT_loiterrad, "TXT_loiterrad");
            this.TXT_loiterrad.Name = "TXT_loiterrad";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // BUT_write
            // 
            this.BUT_write.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_write.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_write.ColorMouseDown = System.Drawing.Color.Transparent;
            this.BUT_write.ColorMouseOver = System.Drawing.Color.Transparent;
            this.BUT_write.ColorNotEnabled = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BUT_write, "BUT_write");
            this.BUT_write.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_write.Name = "BUT_write";
            this.BUT_write.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_write.TextColor = System.Drawing.Color.Black;
            this.BUT_write.UseVisualStyleBackColor = false;
            this.BUT_write.Click += new System.EventHandler(this.BUT_write_Click);
            // 
            // BUT_read
            // 
            this.BUT_read.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_read.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_read.ColorMouseDown = System.Drawing.Color.Transparent;
            this.BUT_read.ColorMouseOver = System.Drawing.Color.Transparent;
            this.BUT_read.ColorNotEnabled = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BUT_read, "BUT_read");
            this.BUT_read.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_read.Name = "BUT_read";
            this.BUT_read.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_read.TextColor = System.Drawing.Color.Black;
            this.BUT_read.UseVisualStyleBackColor = false;
            this.BUT_read.Click += new System.EventHandler(this.BUT_read_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            this.coords1.Name = "coords1";
            this.coords1.Vertical = true;
            this.coords1.Load += new System.EventHandler(this.coords1_Load);
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // tableLayoutPanel11
            // 
            resources.ApplyResources(this.tableLayoutPanel11, "tableLayoutPanel11");
            this.tableLayoutPanel11.Controls.Add(this.myButton8, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.Label1, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.TXT_homelat, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.TXT_homelng, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            // 
            // myButton8
            // 
            resources.ApplyResources(this.myButton8, "myButton8");
            this.myButton8.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.myButton8.Name = "myButton8";
            this.myButton8.TextColor = System.Drawing.Color.White;
            this.myButton8.UseVisualStyleBackColor = true;
            this.myButton8.Click += new System.EventHandler(this.myButton8_Click_1);
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // TXT_homelat
            // 
            resources.ApplyResources(this.TXT_homelat, "TXT_homelat");
            this.TXT_homelat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_homelat.Name = "TXT_homelat";
            this.TXT_homelat.TextChanged += new System.EventHandler(this.TXT_homelat_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXT_homelng
            // 
            resources.ApplyResources(this.TXT_homelng, "TXT_homelng");
            this.TXT_homelng.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_homelng.Name = "TXT_homelng";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TXT_homealt
            // 
            resources.ApplyResources(this.TXT_homealt, "TXT_homealt");
            this.TXT_homealt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_homealt.Name = "TXT_homealt";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.TXT_WPRad, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.BUT_Add, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.CHK_splinedefault, 7, 1);
            this.tableLayoutPanel9.Controls.Add(this.LBL_WPRad, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.TXT_homealt, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.numericUpDown1, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.label17, 6, 0);
            this.tableLayoutPanel9.Controls.Add(this.TXT_altwarn, 6, 1);
            this.tableLayoutPanel9.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.CHK_verifyheight, 4, 1);
            this.tableLayoutPanel9.Controls.Add(this.LBL_defalutalt, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.TXT_loiterrad, 5, 1);
            this.tableLayoutPanel9.Controls.Add(this.TXT_DefaultAlt, 3, 1);
            this.tableLayoutPanel9.Controls.Add(this.CMB_altmode, 2, 1);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // BUT_Add
            // 
            this.BUT_Add.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_Add.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.BUT_Add.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.BUT_Add.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BUT_Add, "BUT_Add");
            this.BUT_Add.Name = "BUT_Add";
            this.BUT_Add.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_Add.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolTip1.SetToolTip(this.BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            this.BUT_Add.UseVisualStyleBackColor = true;
            // 
            // CHK_splinedefault
            // 
            resources.ApplyResources(this.CHK_splinedefault, "CHK_splinedefault");
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.CHK_splinedefault.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // TXT_altwarn
            // 
            resources.ApplyResources(this.TXT_altwarn, "TXT_altwarn");
            this.TXT_altwarn.Name = "TXT_altwarn";
            // 
            // CMB_altmode
            // 
            this.CMB_altmode.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_altmode, "CMB_altmode");
            this.CMB_altmode.Name = "CMB_altmode";
            this.CMB_altmode.SelectedIndexChanged += new System.EventHandler(this.CMB_altmode_SelectedIndexChanged);
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.panelAction, "panelAction");
            this.panelAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAction.Name = "panelAction";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_wpfile);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lbl_wpfile
            // 
            resources.ApplyResources(this.lbl_wpfile, "lbl_wpfile");
            this.lbl_wpfile.Name = "lbl_wpfile";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.coords1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmb_missiontype, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // cmb_missiontype
            // 
            resources.ApplyResources(this.cmb_missiontype, "cmb_missiontype");
            this.cmb_missiontype.FormattingEnabled = true;
            this.cmb_missiontype.Items.AddRange(new object[] {
            resources.GetString("cmb_missiontype.Items"),
            resources.GetString("cmb_missiontype.Items1"),
            resources.GetString("cmb_missiontype.Items2")});
            this.cmb_missiontype.Name = "cmb_missiontype";
            this.cmb_missiontype.SelectedIndexChanged += new System.EventHandler(this.cmb_missiontype_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.BtnDelTiff, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.myButton7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BUT_write, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BUT_read, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnTiff, 1, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // BtnDelTiff
            // 
            this.BtnDelTiff.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BtnDelTiff, "BtnDelTiff");
            this.BtnDelTiff.Name = "BtnDelTiff";
            this.BtnDelTiff.TextColor = System.Drawing.Color.White;
            this.BtnDelTiff.UseVisualStyleBackColor = true;
            this.BtnDelTiff.Click += new System.EventHandler(this.BtnDelTiff_Click);
            // 
            // myButton7
            // 
            this.myButton7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton7.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.myButton7.ColorMouseDown = System.Drawing.Color.Transparent;
            this.myButton7.ColorMouseOver = System.Drawing.Color.Transparent;
            this.myButton7.ColorNotEnabled = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.myButton7, "myButton7");
            this.myButton7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton7.Name = "myButton7";
            this.myButton7.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.myButton7.TextColor = System.Drawing.Color.Black;
            this.myButton7.UseVisualStyleBackColor = false;
            // 
            // BtnTiff
            // 
            this.BtnTiff.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BtnTiff, "BtnTiff");
            this.BtnTiff.Name = "BtnTiff";
            this.BtnTiff.TextColor = System.Drawing.Color.White;
            this.BtnTiff.UseVisualStyleBackColor = true;
            this.BtnTiff.Click += new System.EventHandler(this.BtnTiff_Click);
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.BtnKMLOverlay, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.Buttmeasurecontext, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.BUt_sethome, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.BtnClearKml, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // BtnKMLOverlay
            // 
            this.BtnKMLOverlay.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BtnKMLOverlay, "BtnKMLOverlay");
            this.BtnKMLOverlay.Name = "BtnKMLOverlay";
            this.BtnKMLOverlay.TextColor = System.Drawing.Color.White;
            this.BtnKMLOverlay.UseVisualStyleBackColor = true;
            this.BtnKMLOverlay.Click += new System.EventHandler(this.BtnKMLOverlay_Click);
            // 
            // Buttmeasurecontext
            // 
            this.Buttmeasurecontext.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.Buttmeasurecontext, "Buttmeasurecontext");
            this.Buttmeasurecontext.Name = "Buttmeasurecontext";
            this.Buttmeasurecontext.TextColor = System.Drawing.Color.White;
            this.Buttmeasurecontext.UseVisualStyleBackColor = true;
            this.Buttmeasurecontext.Click += new System.EventHandler(this.myButton8_Click);
            // 
            // BUt_sethome
            // 
            this.BUt_sethome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BUt_sethome.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUt_sethome.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.BUt_sethome.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.BUt_sethome.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BUt_sethome, "BUt_sethome");
            this.BUt_sethome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUt_sethome.Name = "BUt_sethome";
            this.BUt_sethome.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUt_sethome.TextColor = System.Drawing.Color.Black;
            this.BUt_sethome.UseVisualStyleBackColor = false;
            this.BUt_sethome.Click += new System.EventHandler(this.BUt_sethome_Click);
            // 
            // BtnClearKml
            // 
            this.BtnClearKml.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BtnClearKml, "BtnClearKml");
            this.BtnClearKml.Name = "BtnClearKml";
            this.BtnClearKml.TextColor = System.Drawing.Color.White;
            this.BtnClearKml.UseVisualStyleBackColor = true;
            this.BtnClearKml.Click += new System.EventHandler(this.BtnClearKml_Click);
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.ButInsertPol, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ButClearPol, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtSavePol, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.ButLoadPol, 1, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // ButInsertPol
            // 
            this.ButInsertPol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButInsertPol.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.ButInsertPol.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.ButInsertPol.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.ButInsertPol.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.ButInsertPol, "ButInsertPol");
            this.ButInsertPol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButInsertPol.Name = "ButInsertPol";
            this.ButInsertPol.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.ButInsertPol.TextColor = System.Drawing.Color.Black;
            this.ButInsertPol.UseVisualStyleBackColor = false;
            this.ButInsertPol.Click += new System.EventHandler(this.ButInsertPol_Click);
            // 
            // ButClearPol
            // 
            this.ButClearPol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButClearPol.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.ButClearPol.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.ButClearPol.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.ButClearPol.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.ButClearPol, "ButClearPol");
            this.ButClearPol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButClearPol.Name = "ButClearPol";
            this.ButClearPol.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.ButClearPol.TextColor = System.Drawing.Color.Black;
            this.ButClearPol.UseVisualStyleBackColor = false;
            this.ButClearPol.Click += new System.EventHandler(this.ButClearPol_Click);
            // 
            // BtSavePol
            // 
            this.BtSavePol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtSavePol.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BtSavePol.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.BtSavePol.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.BtSavePol.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtSavePol, "BtSavePol");
            this.BtSavePol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtSavePol.Name = "BtSavePol";
            this.BtSavePol.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BtSavePol.TextColor = System.Drawing.Color.Black;
            this.BtSavePol.UseVisualStyleBackColor = false;
            this.BtSavePol.Click += new System.EventHandler(this.BtSavePol_Click);
            // 
            // ButLoadPol
            // 
            this.ButLoadPol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButLoadPol.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.ButLoadPol.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.ButLoadPol.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.ButLoadPol.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.ButLoadPol, "ButLoadPol");
            this.ButLoadPol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButLoadPol.Name = "ButLoadPol";
            this.ButLoadPol.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.ButLoadPol.TextColor = System.Drawing.Color.Black;
            this.ButLoadPol.UseVisualStyleBackColor = false;
            this.ButLoadPol.Click += new System.EventHandler(this.ButLoadPol_Click_1);
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.myButton5, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.myButton4, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.myButton2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.myButton1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.myButton6, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.myButton3, 2, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // myButton5
            // 
            this.myButton5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton5.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.myButton5.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.myButton5.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.myButton5.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.myButton5, "myButton5");
            this.myButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton5.Name = "myButton5";
            this.myButton5.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.myButton5.TextColor = System.Drawing.Color.Black;
            this.myButton5.UseVisualStyleBackColor = false;
            this.myButton5.Click += new System.EventHandler(this.myButton5_Click);
            // 
            // myButton4
            // 
            this.myButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton4.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.myButton4.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.myButton4.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.myButton4.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.myButton4, "myButton4");
            this.myButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton4.Name = "myButton4";
            this.myButton4.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.myButton4.TextColor = System.Drawing.Color.Black;
            this.myButton4.UseVisualStyleBackColor = false;
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton2.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.myButton2.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.myButton2.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.myButton2.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton2.Name = "myButton2";
            this.myButton2.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.myButton2.TextColor = System.Drawing.Color.Black;
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton1.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.myButton1.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.myButton1.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.myButton1.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton1.Name = "myButton1";
            this.myButton1.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.myButton1.TextColor = System.Drawing.Color.Black;
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButton6
            // 
            this.myButton6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton6.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.myButton6.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.myButton6.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.myButton6.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.myButton6, "myButton6");
            this.myButton6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton6.Name = "myButton6";
            this.myButton6.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.myButton6.TextColor = System.Drawing.Color.Black;
            this.myButton6.UseVisualStyleBackColor = false;
            this.myButton6.Click += new System.EventHandler(this.myButton6_Click);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton3.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.myButton3.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.myButton3.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.myButton3.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.myButton3, "myButton3");
            this.myButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myButton3.Name = "myButton3";
            this.myButton3.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.myButton3.TextColor = System.Drawing.Color.Black;
            this.myButton3.UseVisualStyleBackColor = false;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::MissionPlanner.Properties.Resources.ZKZg;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BUT_loadwpfile, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BUT_insertWP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButDelwp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BUT_saveWPFile, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // BUT_loadwpfile
            // 
            this.BUT_loadwpfile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_loadwpfile.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BUT_loadwpfile, "BUT_loadwpfile");
            this.BUT_loadwpfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_loadwpfile.Name = "BUT_loadwpfile";
            this.BUT_loadwpfile.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_loadwpfile.TextColor = System.Drawing.Color.Black;
            this.BUT_loadwpfile.UseVisualStyleBackColor = false;
            this.BUT_loadwpfile.Click += new System.EventHandler(this.BUT_loadwpfile_Click);
            // 
            // BUT_insertWP
            // 
            this.BUT_insertWP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_insertWP.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_insertWP.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.BUT_insertWP.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.BUT_insertWP.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BUT_insertWP, "BUT_insertWP");
            this.BUT_insertWP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_insertWP.Name = "BUT_insertWP";
            this.BUT_insertWP.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_insertWP.TextColor = System.Drawing.Color.Black;
            this.BUT_insertWP.UseVisualStyleBackColor = false;
            this.BUT_insertWP.Click += new System.EventHandler(this.BUT_insertWP_Click);
            // 
            // ButDelwp
            // 
            this.ButDelwp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButDelwp.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.ButDelwp.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.ButDelwp.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.ButDelwp.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.ButDelwp, "ButDelwp");
            this.ButDelwp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButDelwp.Name = "ButDelwp";
            this.ButDelwp.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.ButDelwp.TextColor = System.Drawing.Color.Black;
            this.ButDelwp.UseVisualStyleBackColor = false;
            this.ButDelwp.Click += new System.EventHandler(this.ButDelwp_Click);
            // 
            // BUT_saveWPFile
            // 
            this.BUT_saveWPFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_saveWPFile.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_saveWPFile.ColorMouseDown = System.Drawing.SystemColors.ButtonFace;
            this.BUT_saveWPFile.ColorMouseOver = System.Drawing.SystemColors.ButtonFace;
            this.BUT_saveWPFile.ColorNotEnabled = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BUT_saveWPFile, "BUT_saveWPFile");
            this.BUT_saveWPFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_saveWPFile.Name = "BUT_saveWPFile";
            this.BUT_saveWPFile.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(50)))));
            this.BUT_saveWPFile.TextColor = System.Drawing.Color.Black;
            this.BUT_saveWPFile.UseVisualStyleBackColor = false;
            this.BUT_saveWPFile.Click += new System.EventHandler(this.BUT_saveWPFile_Click);
            // 
            // tableLayoutPanel14
            // 
            resources.ApplyResources(this.tableLayoutPanel14, "tableLayoutPanel14");
            this.tableLayoutPanel14.Controls.Add(this.lnk_kml, 0, 4);
            this.tableLayoutPanel14.Controls.Add(this.lbl_status, 0, 3);
            this.tableLayoutPanel14.Controls.Add(this.chk_grid, 0, 2);
            this.tableLayoutPanel14.Controls.Add(this.comboBoxMapType, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.lblmaps, 0, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            // 
            // lnk_kml
            // 
            resources.ApplyResources(this.lnk_kml, "lnk_kml");
            this.lnk_kml.Name = "lnk_kml";
            this.lnk_kml.TabStop = true;
            // 
            // chk_grid
            // 
            resources.ApplyResources(this.chk_grid, "chk_grid");
            this.chk_grid.Name = "chk_grid";
            this.chk_grid.UseVisualStyleBackColor = true;
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMapType, "comboBoxMapType");
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.toolTip1.SetToolTip(this.comboBoxMapType, resources.GetString("comboBoxMapType.ToolTip"));
            this.comboBoxMapType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMapType_SelectedIndexChanged);
            // 
            // lblmaps
            // 
            resources.ApplyResources(this.lblmaps, "lblmaps");
            this.lblmaps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(172)))), ((int)(((byte)(24)))));
            this.lblmaps.Name = "lblmaps";
            // 
            // LBLarea
            // 
            resources.ApplyResources(this.LBLarea, "LBLarea");
            this.LBLarea.Name = "LBLarea";
            // 
            // label4s
            // 
            resources.ApplyResources(this.label4s, "label4s");
            this.label4s.Name = "label4s";
            // 
            // splitter2
            // 
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.tableLayoutPanel9);
            this.panelMap.Controls.Add(this.tableLayoutPanel10);
            this.panelMap.Controls.Add(this.PaneMenu);
            this.panelMap.Controls.Add(this.splitter3);
            this.panelMap.Controls.Add(this.lbl_homedist);
            this.panelMap.Controls.Add(this.lbl_prevdist);
            this.panelMap.Controls.Add(this.trackBar1);
            this.panelMap.Controls.Add(this.label11);
            this.panelMap.Controls.Add(this.lbl_distance);
            this.panelMap.Controls.Add(this.MainMap);
            resources.ApplyResources(this.panelMap, "panelMap");
            this.panelMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMap.Name = "panelMap";
            // 
            // tableLayoutPanel10
            // 
            resources.ApplyResources(this.tableLayoutPanel10, "tableLayoutPanel10");
            this.tableLayoutPanel10.Controls.Add(this.But_SurveyGrid, 0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            // 
            // But_SurveyGrid
            // 
            resources.ApplyResources(this.But_SurveyGrid, "But_SurveyGrid");
            this.But_SurveyGrid.Name = "But_SurveyGrid";
            this.But_SurveyGrid.TextColor = System.Drawing.Color.White;
            this.But_SurveyGrid.UseVisualStyleBackColor = true;
            this.But_SurveyGrid.Click += new System.EventHandler(this.myButton9_Click);
            // 
            // PaneMenu
            // 
            this.PaneMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PaneMenu.Controls.Add(this.tableLayoutPanel12);
            this.PaneMenu.Controls.Add(this.tableLayoutPanel13);
            resources.ApplyResources(this.PaneMenu, "PaneMenu");
            this.PaneMenu.Name = "PaneMenu";
            // 
            // tableLayoutPanel12
            // 
            resources.ApplyResources(this.tableLayoutPanel12, "tableLayoutPanel12");
            this.tableLayoutPanel12.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel12_Paint);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tableLayoutPanel13
            // 
            resources.ApplyResources(this.tableLayoutPanel13, "tableLayoutPanel13");
            this.tableLayoutPanel13.Controls.Add(this.lblestm, 1, 4);
            this.tableLayoutPanel13.Controls.Add(this.lblnstrips, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.lblbetween, 1, 3);
            this.tableLayoutPanel13.Controls.Add(this.label9s, 0, 3);
            this.tableLayoutPanel13.Controls.Add(this.label4s, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.LBLarea, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.lbldistancia, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.LBLdist, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.label10s, 0, 4);
            this.tableLayoutPanel13.Controls.Add(this.lblstrips, 1, 2);
            this.tableLayoutPanel13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            // 
            // lblestm
            // 
            resources.ApplyResources(this.lblestm, "lblestm");
            this.lblestm.Name = "lblestm";
            // 
            // lblnstrips
            // 
            resources.ApplyResources(this.lblnstrips, "lblnstrips");
            this.lblnstrips.Name = "lblnstrips";
            this.lblnstrips.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblbetween
            // 
            resources.ApplyResources(this.lblbetween, "lblbetween");
            this.lblbetween.Name = "lblbetween";
            // 
            // label9s
            // 
            resources.ApplyResources(this.label9s, "label9s");
            this.label9s.Name = "label9s";
            // 
            // lbldistancia
            // 
            resources.ApplyResources(this.lbldistancia, "lbldistancia");
            this.lbldistancia.Name = "lbldistancia";
            this.lbldistancia.Click += new System.EventHandler(this.label8_Click);
            // 
            // LBLdist
            // 
            resources.ApplyResources(this.LBLdist, "LBLdist");
            this.LBLdist.Name = "LBLdist";
            // 
            // label10s
            // 
            resources.ApplyResources(this.label10s, "label10s");
            this.label10s.Name = "label10s";
            // 
            // lblstrips
            // 
            resources.ApplyResources(this.lblstrips, "lblstrips");
            this.lblstrips.Name = "lblstrips";
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitter3, "splitter3");
            this.splitter3.Name = "splitter3";
            this.splitter3.TabStop = false;
            // 
            // lbl_homedist
            // 
            resources.ApplyResources(this.lbl_homedist, "lbl_homedist");
            this.lbl_homedist.Name = "lbl_homedist";
            // 
            // lbl_prevdist
            // 
            resources.ApplyResources(this.lbl_prevdist, "lbl_prevdist");
            this.lbl_prevdist.Name = "lbl_prevdist";
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 0.005F;
            this.trackBar1.Maximum = 24F;
            this.trackBar1.Minimum = 1F;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 0.001F;
            this.trackBar1.TickFrequency = 1F;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 2F;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbl_distance
            // 
            resources.ApplyResources(this.lbl_distance, "lbl_distance");
            this.lbl_distance.Name = "lbl_distance";
            // 
            // MainMap
            // 
            resources.ApplyResources(this.MainMap, "MainMap");
            this.MainMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.ContextMenuStrip = this.contextMenuStrip1;
            this.MainMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Gray;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.HoldInvalidation = false;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 19;
            this.MainMap.MinZoom = 0;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = false;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Zoom = 0D;
            this.MainMap.Load += new System.EventHandler(this.MainMap_Load);
            this.MainMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseDown);
            this.MainMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteWPToolStripMenuItem,
            this.insertWpToolStripMenuItem,
            this.insertSplineWPToolStripMenuItem,
            this.loiterToolStripMenuItem,
            this.jumpToolStripMenuItem,
            this.rTLToolStripMenuItem,
            this.landToolStripMenuItem,
            this.takeoffToolStripMenuItem,
            this.setROIToolStripMenuItem,
            this.clearMissionToolStripMenuItem,
            this.toolStripSeparator1,
            this.geoFenceToolStripMenuItem,
            this.rallyPointsToolStripMenuItem,
            this.autoWPToolStripMenuItem,
            this.mapToolToolStripMenuItem,
            this.fileLoadSaveToolStripMenuItem,
            this.pOIToolStripMenuItem,
            this.trackerHomeToolStripMenuItem,
            this.modifyAltToolStripMenuItem,
            this.enterUTMCoordToolStripMenuItem,
            this.switchDockingToolStripMenuItem,
            this.setHomeHereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // deleteWPToolStripMenuItem
            // 
            this.deleteWPToolStripMenuItem.Name = "deleteWPToolStripMenuItem";
            resources.ApplyResources(this.deleteWPToolStripMenuItem, "deleteWPToolStripMenuItem");
            // 
            // insertWpToolStripMenuItem
            // 
            this.insertWpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentPositionToolStripMenuItem});
            this.insertWpToolStripMenuItem.Name = "insertWpToolStripMenuItem";
            resources.ApplyResources(this.insertWpToolStripMenuItem, "insertWpToolStripMenuItem");
            // 
            // currentPositionToolStripMenuItem
            // 
            this.currentPositionToolStripMenuItem.Name = "currentPositionToolStripMenuItem";
            resources.ApplyResources(this.currentPositionToolStripMenuItem, "currentPositionToolStripMenuItem");
            // 
            // insertSplineWPToolStripMenuItem
            // 
            this.insertSplineWPToolStripMenuItem.Name = "insertSplineWPToolStripMenuItem";
            resources.ApplyResources(this.insertSplineWPToolStripMenuItem, "insertSplineWPToolStripMenuItem");
            // 
            // loiterToolStripMenuItem
            // 
            this.loiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loiterForeverToolStripMenuItem,
            this.loitertimeToolStripMenuItem,
            this.loitercirclesToolStripMenuItem});
            this.loiterToolStripMenuItem.Name = "loiterToolStripMenuItem";
            resources.ApplyResources(this.loiterToolStripMenuItem, "loiterToolStripMenuItem");
            // 
            // loiterForeverToolStripMenuItem
            // 
            this.loiterForeverToolStripMenuItem.Name = "loiterForeverToolStripMenuItem";
            resources.ApplyResources(this.loiterForeverToolStripMenuItem, "loiterForeverToolStripMenuItem");
            // 
            // loitertimeToolStripMenuItem
            // 
            this.loitertimeToolStripMenuItem.Name = "loitertimeToolStripMenuItem";
            resources.ApplyResources(this.loitertimeToolStripMenuItem, "loitertimeToolStripMenuItem");
            // 
            // loitercirclesToolStripMenuItem
            // 
            this.loitercirclesToolStripMenuItem.Name = "loitercirclesToolStripMenuItem";
            resources.ApplyResources(this.loitercirclesToolStripMenuItem, "loitercirclesToolStripMenuItem");
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpstartToolStripMenuItem,
            this.jumpwPToolStripMenuItem});
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            resources.ApplyResources(this.jumpToolStripMenuItem, "jumpToolStripMenuItem");
            // 
            // jumpstartToolStripMenuItem
            // 
            this.jumpstartToolStripMenuItem.Name = "jumpstartToolStripMenuItem";
            resources.ApplyResources(this.jumpstartToolStripMenuItem, "jumpstartToolStripMenuItem");
            // 
            // jumpwPToolStripMenuItem
            // 
            this.jumpwPToolStripMenuItem.Name = "jumpwPToolStripMenuItem";
            resources.ApplyResources(this.jumpwPToolStripMenuItem, "jumpwPToolStripMenuItem");
            // 
            // rTLToolStripMenuItem
            // 
            this.rTLToolStripMenuItem.Name = "rTLToolStripMenuItem";
            resources.ApplyResources(this.rTLToolStripMenuItem, "rTLToolStripMenuItem");
            // 
            // landToolStripMenuItem
            // 
            this.landToolStripMenuItem.Name = "landToolStripMenuItem";
            resources.ApplyResources(this.landToolStripMenuItem, "landToolStripMenuItem");
            // 
            // takeoffToolStripMenuItem
            // 
            this.takeoffToolStripMenuItem.Name = "takeoffToolStripMenuItem";
            resources.ApplyResources(this.takeoffToolStripMenuItem, "takeoffToolStripMenuItem");
            // 
            // setROIToolStripMenuItem
            // 
            this.setROIToolStripMenuItem.Name = "setROIToolStripMenuItem";
            resources.ApplyResources(this.setROIToolStripMenuItem, "setROIToolStripMenuItem");
            // 
            // clearMissionToolStripMenuItem
            // 
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            resources.ApplyResources(this.clearMissionToolStripMenuItem, "clearMissionToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // geoFenceToolStripMenuItem
            // 
            this.geoFenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator4,
            this.GeoFenceuploadToolStripMenuItem,
            this.GeoFencedownloadToolStripMenuItem,
            this.setReturnLocationToolStripMenuItem,
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.geoFenceToolStripMenuItem.Name = "geoFenceToolStripMenuItem";
            resources.ApplyResources(this.geoFenceToolStripMenuItem, "geoFenceToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // GeoFenceuploadToolStripMenuItem
            // 
            this.GeoFenceuploadToolStripMenuItem.Name = "GeoFenceuploadToolStripMenuItem";
            resources.ApplyResources(this.GeoFenceuploadToolStripMenuItem, "GeoFenceuploadToolStripMenuItem");
            // 
            // GeoFencedownloadToolStripMenuItem
            // 
            this.GeoFencedownloadToolStripMenuItem.Name = "GeoFencedownloadToolStripMenuItem";
            resources.ApplyResources(this.GeoFencedownloadToolStripMenuItem, "GeoFencedownloadToolStripMenuItem");
            // 
            // setReturnLocationToolStripMenuItem
            // 
            this.setReturnLocationToolStripMenuItem.Name = "setReturnLocationToolStripMenuItem";
            resources.ApplyResources(this.setReturnLocationToolStripMenuItem, "setReturnLocationToolStripMenuItem");
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem, "loadFromFileToolStripMenuItem");
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            resources.ApplyResources(this.saveToFileToolStripMenuItem, "saveToFileToolStripMenuItem");
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            // 
            // rallyPointsToolStripMenuItem
            // 
            this.rallyPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRallyPointToolStripMenuItem,
            this.getRallyPointsToolStripMenuItem,
            this.saveRallyPointsToolStripMenuItem,
            this.clearRallyPointsToolStripMenuItem,
            this.saveToFileToolStripMenuItem1,
            this.loadFromFileToolStripMenuItem1});
            this.rallyPointsToolStripMenuItem.Name = "rallyPointsToolStripMenuItem";
            resources.ApplyResources(this.rallyPointsToolStripMenuItem, "rallyPointsToolStripMenuItem");
            // 
            // setRallyPointToolStripMenuItem
            // 
            this.setRallyPointToolStripMenuItem.Name = "setRallyPointToolStripMenuItem";
            resources.ApplyResources(this.setRallyPointToolStripMenuItem, "setRallyPointToolStripMenuItem");
            this.setRallyPointToolStripMenuItem.Click += new System.EventHandler(this.setRallyPointToolStripMenuItem_Click);
            // 
            // getRallyPointsToolStripMenuItem
            // 
            this.getRallyPointsToolStripMenuItem.Name = "getRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.getRallyPointsToolStripMenuItem, "getRallyPointsToolStripMenuItem");
            // 
            // saveRallyPointsToolStripMenuItem
            // 
            this.saveRallyPointsToolStripMenuItem.Name = "saveRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.saveRallyPointsToolStripMenuItem, "saveRallyPointsToolStripMenuItem");
            // 
            // clearRallyPointsToolStripMenuItem
            // 
            this.clearRallyPointsToolStripMenuItem.Name = "clearRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.clearRallyPointsToolStripMenuItem, "clearRallyPointsToolStripMenuItem");
            // 
            // saveToFileToolStripMenuItem1
            // 
            this.saveToFileToolStripMenuItem1.Name = "saveToFileToolStripMenuItem1";
            resources.ApplyResources(this.saveToFileToolStripMenuItem1, "saveToFileToolStripMenuItem1");
            // 
            // loadFromFileToolStripMenuItem1
            // 
            this.loadFromFileToolStripMenuItem1.Name = "loadFromFileToolStripMenuItem1";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem1, "loadFromFileToolStripMenuItem1");
            // 
            // autoWPToolStripMenuItem
            // 
            this.autoWPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createWpCircleToolStripMenuItem,
            this.createSplineCircleToolStripMenuItem,
            this.areaToolStripMenuItem1,
            this.textToolStripMenuItem,
            this.createCircleSurveyToolStripMenuItem,
            this.surveyGridToolStripMenuItem});
            this.autoWPToolStripMenuItem.Name = "autoWPToolStripMenuItem";
            resources.ApplyResources(this.autoWPToolStripMenuItem, "autoWPToolStripMenuItem");
            // 
            // createWpCircleToolStripMenuItem
            // 
            this.createWpCircleToolStripMenuItem.Name = "createWpCircleToolStripMenuItem";
            resources.ApplyResources(this.createWpCircleToolStripMenuItem, "createWpCircleToolStripMenuItem");
            // 
            // createSplineCircleToolStripMenuItem
            // 
            this.createSplineCircleToolStripMenuItem.Name = "createSplineCircleToolStripMenuItem";
            resources.ApplyResources(this.createSplineCircleToolStripMenuItem, "createSplineCircleToolStripMenuItem");
            // 
            // areaToolStripMenuItem1
            // 
            this.areaToolStripMenuItem1.Name = "areaToolStripMenuItem1";
            resources.ApplyResources(this.areaToolStripMenuItem1, "areaToolStripMenuItem1");
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            resources.ApplyResources(this.textToolStripMenuItem, "textToolStripMenuItem");
            // 
            // createCircleSurveyToolStripMenuItem
            // 
            this.createCircleSurveyToolStripMenuItem.Name = "createCircleSurveyToolStripMenuItem";
            resources.ApplyResources(this.createCircleSurveyToolStripMenuItem, "createCircleSurveyToolStripMenuItem");
            // 
            // surveyGridToolStripMenuItem
            // 
            this.surveyGridToolStripMenuItem.Name = "surveyGridToolStripMenuItem";
            resources.ApplyResources(this.surveyGridToolStripMenuItem, "surveyGridToolStripMenuItem");
            // 
            // mapToolToolStripMenuItem
            // 
            this.mapToolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMeasure,
            this.rotateMapToolStripMenuItem,
            this.zoomToToolStripMenuItem,
            this.prefetchToolStripMenuItem,
            this.prefetchWPPathToolStripMenuItem,
            this.kMLOverlayToolStripMenuItem,
            this.elevationGraphToolStripMenuItem,
            this.reverseWPsToolStripMenuItem});
            this.mapToolToolStripMenuItem.Name = "mapToolToolStripMenuItem";
            resources.ApplyResources(this.mapToolToolStripMenuItem, "mapToolToolStripMenuItem");
            // 
            // ContextMeasure
            // 
            this.ContextMeasure.Name = "ContextMeasure";
            resources.ApplyResources(this.ContextMeasure, "ContextMeasure");
            // 
            // rotateMapToolStripMenuItem
            // 
            this.rotateMapToolStripMenuItem.Name = "rotateMapToolStripMenuItem";
            resources.ApplyResources(this.rotateMapToolStripMenuItem, "rotateMapToolStripMenuItem");
            // 
            // zoomToToolStripMenuItem
            // 
            this.zoomToToolStripMenuItem.Name = "zoomToToolStripMenuItem";
            resources.ApplyResources(this.zoomToToolStripMenuItem, "zoomToToolStripMenuItem");
            // 
            // prefetchToolStripMenuItem
            // 
            this.prefetchToolStripMenuItem.Name = "prefetchToolStripMenuItem";
            resources.ApplyResources(this.prefetchToolStripMenuItem, "prefetchToolStripMenuItem");
            // 
            // prefetchWPPathToolStripMenuItem
            // 
            this.prefetchWPPathToolStripMenuItem.Name = "prefetchWPPathToolStripMenuItem";
            resources.ApplyResources(this.prefetchWPPathToolStripMenuItem, "prefetchWPPathToolStripMenuItem");
            // 
            // kMLOverlayToolStripMenuItem
            // 
            this.kMLOverlayToolStripMenuItem.Name = "kMLOverlayToolStripMenuItem";
            resources.ApplyResources(this.kMLOverlayToolStripMenuItem, "kMLOverlayToolStripMenuItem");
            // 
            // elevationGraphToolStripMenuItem
            // 
            this.elevationGraphToolStripMenuItem.Name = "elevationGraphToolStripMenuItem";
            resources.ApplyResources(this.elevationGraphToolStripMenuItem, "elevationGraphToolStripMenuItem");
            // 
            // reverseWPsToolStripMenuItem
            // 
            this.reverseWPsToolStripMenuItem.Name = "reverseWPsToolStripMenuItem";
            resources.ApplyResources(this.reverseWPsToolStripMenuItem, "reverseWPsToolStripMenuItem");
            // 
            // fileLoadSaveToolStripMenuItem
            // 
            this.fileLoadSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWPFileToolStripMenuItem,
            this.loadAndAppendToolStripMenuItem,
            this.saveWPFileToolStripMenuItem,
            this.loadKMLFileToolStripMenuItem,
            this.loadSHPFileToolStripMenuItem});
            this.fileLoadSaveToolStripMenuItem.Name = "fileLoadSaveToolStripMenuItem";
            resources.ApplyResources(this.fileLoadSaveToolStripMenuItem, "fileLoadSaveToolStripMenuItem");
            // 
            // loadWPFileToolStripMenuItem
            // 
            this.loadWPFileToolStripMenuItem.Name = "loadWPFileToolStripMenuItem";
            resources.ApplyResources(this.loadWPFileToolStripMenuItem, "loadWPFileToolStripMenuItem");
            // 
            // loadAndAppendToolStripMenuItem
            // 
            this.loadAndAppendToolStripMenuItem.Name = "loadAndAppendToolStripMenuItem";
            resources.ApplyResources(this.loadAndAppendToolStripMenuItem, "loadAndAppendToolStripMenuItem");
            // 
            // saveWPFileToolStripMenuItem
            // 
            this.saveWPFileToolStripMenuItem.Name = "saveWPFileToolStripMenuItem";
            resources.ApplyResources(this.saveWPFileToolStripMenuItem, "saveWPFileToolStripMenuItem");
            // 
            // loadKMLFileToolStripMenuItem
            // 
            this.loadKMLFileToolStripMenuItem.Name = "loadKMLFileToolStripMenuItem";
            resources.ApplyResources(this.loadKMLFileToolStripMenuItem, "loadKMLFileToolStripMenuItem");
            // 
            // loadSHPFileToolStripMenuItem
            // 
            this.loadSHPFileToolStripMenuItem.Name = "loadSHPFileToolStripMenuItem";
            resources.ApplyResources(this.loadSHPFileToolStripMenuItem, "loadSHPFileToolStripMenuItem");
            // 
            // pOIToolStripMenuItem
            // 
            this.pOIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poiaddToolStripMenuItem,
            this.poideleteToolStripMenuItem,
            this.poieditToolStripMenuItem});
            this.pOIToolStripMenuItem.Name = "pOIToolStripMenuItem";
            resources.ApplyResources(this.pOIToolStripMenuItem, "pOIToolStripMenuItem");
            // 
            // poiaddToolStripMenuItem
            // 
            this.poiaddToolStripMenuItem.Name = "poiaddToolStripMenuItem";
            resources.ApplyResources(this.poiaddToolStripMenuItem, "poiaddToolStripMenuItem");
            // 
            // poideleteToolStripMenuItem
            // 
            this.poideleteToolStripMenuItem.Name = "poideleteToolStripMenuItem";
            resources.ApplyResources(this.poideleteToolStripMenuItem, "poideleteToolStripMenuItem");
            // 
            // poieditToolStripMenuItem
            // 
            this.poieditToolStripMenuItem.Name = "poieditToolStripMenuItem";
            resources.ApplyResources(this.poieditToolStripMenuItem, "poieditToolStripMenuItem");
            // 
            // trackerHomeToolStripMenuItem
            // 
            this.trackerHomeToolStripMenuItem.Name = "trackerHomeToolStripMenuItem";
            resources.ApplyResources(this.trackerHomeToolStripMenuItem, "trackerHomeToolStripMenuItem");
            // 
            // modifyAltToolStripMenuItem
            // 
            this.modifyAltToolStripMenuItem.Name = "modifyAltToolStripMenuItem";
            resources.ApplyResources(this.modifyAltToolStripMenuItem, "modifyAltToolStripMenuItem");
            // 
            // enterUTMCoordToolStripMenuItem
            // 
            this.enterUTMCoordToolStripMenuItem.Name = "enterUTMCoordToolStripMenuItem";
            resources.ApplyResources(this.enterUTMCoordToolStripMenuItem, "enterUTMCoordToolStripMenuItem");
            // 
            // switchDockingToolStripMenuItem
            // 
            this.switchDockingToolStripMenuItem.Name = "switchDockingToolStripMenuItem";
            resources.ApplyResources(this.switchDockingToolStripMenuItem, "switchDockingToolStripMenuItem");
            // 
            // setHomeHereToolStripMenuItem
            // 
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            this.setHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // addPolygonPointToolStripMenuItem
            // 
            this.addPolygonPointToolStripMenuItem.Name = "addPolygonPointToolStripMenuItem";
            resources.ApplyResources(this.addPolygonPointToolStripMenuItem, "addPolygonPointToolStripMenuItem");
            this.addPolygonPointToolStripMenuItem.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // clearPolygonToolStripMenuItem
            // 
            this.clearPolygonToolStripMenuItem.Name = "clearPolygonToolStripMenuItem";
            resources.ApplyResources(this.clearPolygonToolStripMenuItem, "clearPolygonToolStripMenuItem");
            // 
            // savePolygonToolStripMenuItem
            // 
            this.savePolygonToolStripMenuItem.Name = "savePolygonToolStripMenuItem";
            resources.ApplyResources(this.savePolygonToolStripMenuItem, "savePolygonToolStripMenuItem");
            this.savePolygonToolStripMenuItem.Click += new System.EventHandler(this.savePolygonToolStripMenuItem_Click);
            // 
            // loadPolygonToolStripMenuItem
            // 
            this.loadPolygonToolStripMenuItem.Name = "loadPolygonToolStripMenuItem";
            resources.ApplyResources(this.loadPolygonToolStripMenuItem, "loadPolygonToolStripMenuItem");
            // 
            // fromSHPToolStripMenuItem
            // 
            this.fromSHPToolStripMenuItem.Name = "fromSHPToolStripMenuItem";
            resources.ApplyResources(this.fromSHPToolStripMenuItem, "fromSHPToolStripMenuItem");
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            resources.ApplyResources(this.areaToolStripMenuItem, "areaToolStripMenuItem");
            // 
            // panelBASE
            // 
            this.panelBASE.Controls.Add(this.splitter2);
            this.panelBASE.Controls.Add(this.splitter1);
            this.panelBASE.Controls.Add(this.panelMap);
            this.panelBASE.Controls.Add(this.panelWaypoints);
            this.panelBASE.Controls.Add(this.panelAction);
            this.panelBASE.Controls.Add(this.label6);
            resources.ApplyResources(this.panelBASE, "panelBASE");
            this.panelBASE.Name = "panelBASE";
            // 
            // panelWaypoints
            // 
            this.panelWaypoints.Controls.Add(this.tableLayoutPanel8);
            resources.ApplyResources(this.panelWaypoints, "panelWaypoints");
            this.panelWaypoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWaypoints.Name = "panelWaypoints";
            this.panelWaypoints.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWaypoints_Paint);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.Commands, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel11, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel14, 3, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            // 
            // contextMenuStripPoly
            // 
            this.contextMenuStripPoly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolygonPointToolStripMenuItem,
            this.clearPolygonToolStripMenuItem,
            this.savePolygonToolStripMenuItem,
            this.loadPolygonToolStripMenuItem,
            this.fromSHPToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.fenceInclusionToolStripMenuItem,
            this.fenceExclusionToolStripMenuItem});
            this.contextMenuStripPoly.Name = "contextMenuStripPoly";
            resources.ApplyResources(this.contextMenuStripPoly, "contextMenuStripPoly");
            // 
            // fenceInclusionToolStripMenuItem
            // 
            this.fenceInclusionToolStripMenuItem.Name = "fenceInclusionToolStripMenuItem";
            resources.ApplyResources(this.fenceInclusionToolStripMenuItem, "fenceInclusionToolStripMenuItem");
            // 
            // fenceExclusionToolStripMenuItem
            // 
            this.fenceExclusionToolStripMenuItem.Name = "fenceExclusionToolStripMenuItem";
            resources.ApplyResources(this.fenceExclusionToolStripMenuItem, "fenceExclusionToolStripMenuItem");
            // 
            // drawAPolygonToolStripMenuItem
            // 
            this.drawAPolygonToolStripMenuItem.Name = "drawAPolygonToolStripMenuItem";
            resources.ApplyResources(this.drawAPolygonToolStripMenuItem, "drawAPolygonToolStripMenuItem");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Commands
            // 
            this.Commands.AllowUserToAddRows = false;
            this.Commands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Commands.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.Commands, "Commands");
            this.Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4,
            this.Lat,
            this.Lon,
            this.Alt,
            this.Frame,
            this.coordZone,
            this.coordEasting,
            this.coordNorthing,
            this.MGRS,
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Angle,
            this.Dist,
            this.AZ,
            this.TagData});
            this.Commands.Name = "Commands";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = "0";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.Commands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellContentClick);
            // 
            // Command
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.Command.DefaultCellStyle = dataGridViewCellStyle12;
            this.Command.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(this.Command, "Command");
            this.Command.Name = "Command";
            // 
            // Param1
            // 
            resources.ApplyResources(this.Param1, "Param1");
            this.Param1.Name = "Param1";
            this.Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param2
            // 
            resources.ApplyResources(this.Param2, "Param2");
            this.Param2.Name = "Param2";
            this.Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param3
            // 
            resources.ApplyResources(this.Param3, "Param3");
            this.Param3.Name = "Param3";
            this.Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param4
            // 
            resources.ApplyResources(this.Param4, "Param4");
            this.Param4.Name = "Param4";
            this.Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lat
            // 
            resources.ApplyResources(this.Lat, "Lat");
            this.Lat.Name = "Lat";
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lon
            // 
            resources.ApplyResources(this.Lon, "Lon");
            this.Lon.Name = "Lon";
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Alt
            // 
            resources.ApplyResources(this.Alt, "Alt");
            this.Alt.Name = "Alt";
            this.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Frame
            // 
            this.Frame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Frame, "Frame");
            this.Frame.Name = "Frame";
            // 
            // coordZone
            // 
            resources.ApplyResources(this.coordZone, "coordZone");
            this.coordZone.Name = "coordZone";
            // 
            // coordEasting
            // 
            resources.ApplyResources(this.coordEasting, "coordEasting");
            this.coordEasting.Name = "coordEasting";
            // 
            // coordNorthing
            // 
            resources.ApplyResources(this.coordNorthing, "coordNorthing");
            this.coordNorthing.Name = "coordNorthing";
            // 
            // MGRS
            // 
            resources.ApplyResources(this.MGRS, "MGRS");
            this.MGRS.Name = "MGRS";
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            // 
            // Up
            // 
            this.Up.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Up.DefaultCellStyle = dataGridViewCellStyle13;
            this.Up.FillWeight = 80F;
            resources.ApplyResources(this.Up, "Up");
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Up.Name = "Up";
            this.Up.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Down
            // 
            this.Down.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Down.DefaultCellStyle = dataGridViewCellStyle14;
            this.Down.FillWeight = 80F;
            resources.ApplyResources(this.Down, "Down");
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Down.Name = "Down";
            this.Down.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Grad
            // 
            resources.ApplyResources(this.Grad, "Grad");
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Angle
            // 
            resources.ApplyResources(this.Angle, "Angle");
            this.Angle.Name = "Angle";
            this.Angle.ReadOnly = true;
            this.Angle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dist
            // 
            resources.ApplyResources(this.Dist, "Dist");
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AZ
            // 
            resources.ApplyResources(this.AZ, "AZ");
            this.AZ.Name = "AZ";
            this.AZ.ReadOnly = true;
            this.AZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TagData
            // 
            resources.ApplyResources(this.TagData, "TagData");
            this.TagData.Name = "TagData";
            this.TagData.ReadOnly = true;
            // 
            // FlightPlanner
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBASE);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightPlanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightPlanner_FormClosing);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.PaneMenu.ResumeLayout(false);
            this.PaneMenu.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelBASE.ResumeLayout(false);
            this.panelWaypoints.ResumeLayout(false);
            this.panelWaypoints.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.contextMenuStripPoly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        public Panel panelAction;
        public Controls.myGMAP MainMap;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.CheckBox CHK_verifyheight;
        public System.Windows.Forms.TextBox TXT_WPRad;
        public System.Windows.Forms.TextBox TXT_DefaultAlt;
        public System.Windows.Forms.TextBox TXT_loiterrad;
        public System.Windows.Forms.CheckBox CHK_splinedefault;
        public System.Windows.Forms.ComboBox CMB_altmode;
        public MyButton BUT_read;
        public MyButton BUT_write;
        public DataGridViewImageColumn dataGridViewImageColumn1;
        public DataGridViewImageColumn dataGridViewImageColumn2;
        public Label label6;
        public Label lbl_status;
        public MyButton BUT_Add;
        public Label LBL_WPRad;
        public Label LBL_defalutalt;
        public Label label5;
        public Panel panelMap;
        public MyTrackBar trackBar1;
        public Label label11;
        public Label lbl_distance;
        public Label lbl_prevdist;
        public Splitter splitter1;
        public Panel panelBASE;
        public Label lbl_homedist;
        public ToolTip toolTip1;
        public ToolStripMenuItem clearMissionToolStripMenuItem;
        public ToolStripMenuItem addPolygonPointToolStripMenuItem;
        public ToolStripMenuItem clearPolygonToolStripMenuItem;
        public ToolStripMenuItem loiterToolStripMenuItem;
        public ToolStripMenuItem loiterForeverToolStripMenuItem;
        public ToolStripMenuItem loitertimeToolStripMenuItem;
        public ToolStripMenuItem loitercirclesToolStripMenuItem;
        public ToolStripMenuItem jumpToolStripMenuItem;
        public ToolStripMenuItem jumpstartToolStripMenuItem;
        public ToolStripMenuItem jumpwPToolStripMenuItem;
        public ToolStripSeparator toolStripSeparator1;
        public ToolStripMenuItem deleteWPToolStripMenuItem;
        public Timer timer1;
        public ToolStripMenuItem setROIToolStripMenuItem;
        public ToolStripMenuItem mapToolToolStripMenuItem;
        public ToolStripMenuItem ContextMeasure;
        public ToolStripMenuItem rotateMapToolStripMenuItem;
        public ToolStripMenuItem zoomToToolStripMenuItem;
        public ToolStripMenuItem prefetchToolStripMenuItem;
        public ToolStripMenuItem kMLOverlayToolStripMenuItem;
        public ToolStripMenuItem elevationGraphToolStripMenuItem;
        public ToolStripMenuItem rTLToolStripMenuItem;
        public ToolStripMenuItem landToolStripMenuItem;
        public ToolStripMenuItem takeoffToolStripMenuItem;
        public ToolStripMenuItem fileLoadSaveToolStripMenuItem;
        public ToolStripMenuItem loadWPFileToolStripMenuItem;
        public ToolStripMenuItem saveWPFileToolStripMenuItem;
        public ToolStripMenuItem trackerHomeToolStripMenuItem;
        public ToolStripMenuItem reverseWPsToolStripMenuItem;
        public ToolStripMenuItem loadAndAppendToolStripMenuItem;
        public ToolStripMenuItem savePolygonToolStripMenuItem;
        public ToolStripMenuItem loadPolygonToolStripMenuItem;
        public CheckBox chk_grid;
        public ToolStripMenuItem insertWpToolStripMenuItem;
        public ToolStripMenuItem loadKMLFileToolStripMenuItem;
        public LinkLabel lnk_kml;
        public ToolStripMenuItem modifyAltToolStripMenuItem;
        public ToolStripMenuItem prefetchWPPathToolStripMenuItem;
        public Label label17;
        public TextBox TXT_altwarn;
        public ToolStripMenuItem pOIToolStripMenuItem;
        public ToolStripMenuItem poiaddToolStripMenuItem;
        public ToolStripMenuItem poideleteToolStripMenuItem;
        public ToolStripMenuItem poieditToolStripMenuItem;
        public ToolStripMenuItem enterUTMCoordToolStripMenuItem;
        public ToolStripMenuItem loadSHPFileToolStripMenuItem;
        public Coords coords1;
        public MyButton BUT_loadwpfile;
        public MyButton BUT_saveWPFile;
        public ToolStripMenuItem switchDockingToolStripMenuItem;
        public Splitter splitter2;
        public ToolStripMenuItem insertSplineWPToolStripMenuItem;
        public ToolStripMenuItem fromSHPToolStripMenuItem;
        public ToolStripMenuItem areaToolStripMenuItem;
        public ToolStripMenuItem setHomeHereToolStripMenuItem;
        public ToolStripMenuItem currentPositionToolStripMenuItem;
        public ComboBox cmb_missiontype;
        public ContextMenuStrip contextMenuStripPoly;
        public ToolStripMenuItem drawAPolygonToolStripMenuItem;
        public ToolStripMenuItem fenceInclusionToolStripMenuItem;
        public ToolStripMenuItem fenceExclusionToolStripMenuItem;
        public ToolStripMenuItem autoWPToolStripMenuItem;
        public ToolStripMenuItem createWpCircleToolStripMenuItem;
        public ToolStripMenuItem createSplineCircleToolStripMenuItem;
        public ToolStripMenuItem areaToolStripMenuItem1;
        public ToolStripMenuItem textToolStripMenuItem;
        public ToolStripMenuItem createCircleSurveyToolStripMenuItem;
        public ToolStripMenuItem surveyGridToolStripMenuItem;
        public ToolStripMenuItem geoFenceToolStripMenuItem;
        public ToolStripMenuItem toolStripMenuItem1;
        public ToolStripSeparator toolStripSeparator4;
        public ToolStripMenuItem GeoFenceuploadToolStripMenuItem;
        public ToolStripMenuItem GeoFencedownloadToolStripMenuItem;
        public ToolStripMenuItem setReturnLocationToolStripMenuItem;
        public ToolStripMenuItem loadFromFileToolStripMenuItem;
        public ToolStripMenuItem saveToFileToolStripMenuItem;
        public ToolStripMenuItem clearToolStripMenuItem;
        public ToolStripMenuItem rallyPointsToolStripMenuItem;
        public ToolStripMenuItem setRallyPointToolStripMenuItem;
        public ToolStripMenuItem getRallyPointsToolStripMenuItem;
        public ToolStripMenuItem saveRallyPointsToolStripMenuItem;
        public ToolStripMenuItem clearRallyPointsToolStripMenuItem;
        public ToolStripMenuItem saveToFileToolStripMenuItem1;
        public ToolStripMenuItem loadFromFileToolStripMenuItem1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        public MyButton BUT_insertWP;
        public MyButton ButInsertPol;
        public MyButton ButClearPol;
        public MyButton BtSavePol;
        public MyButton ButLoadPol;
        public MyButton ButDelwp;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        public MyButton myButton5;
        public MyButton myButton4;
        public MyButton myButton2;
        public MyButton myButton1;
        public MyButton myButton6;
        public MyButton myButton3;
        public MyDataGridView Commands;
        public Label label3;
        public Label label2;
        public TextBox TXT_homealt;
        public TextBox TXT_homelng;
        public TextBox TXT_homelat;
        private TableLayoutPanel tableLayoutPanel9;
        public Label Label1;
        private TableLayoutPanel tableLayoutPanel11;
        private BSE.Windows.Forms.Splitter splitter3;
        public Panel PaneMenu;
        private TableLayoutPanel tableLayoutPanel10;
        private NumericUpDown numericUpDown1;
        public Label LBLarea;
        private Label label4s;
        private Label lblnstrips;
        private TableLayoutPanel tableLayoutPanel13;
        public Label lblstrips;
        public Label lbldistancia;
        public Label LBLdist;
        public Label lblestm;
        public Label lblbetween;
        private Label label9s;
        private Label label10s;
        public TableLayoutPanel tableLayoutPanel12;
        public MyButton myButton7;
        public MyButton BUt_sethome;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        public ComboBox comboBoxMapType;
    
        public MyButton BtnTiff;
        public MyButton BtnDelTiff;
        public MyButton Buttmeasurecontext;
        public MyButton BtnKMLOverlay;
        public MyButton BtnClearKml;
        private MyButton myButton8;
        private TableLayoutPanel tableLayoutPanel14;
        private Label lblmaps;
        public PictureBox pictureBox2;
        public MyButton But_SurveyGrid;
        public Panel panelWaypoints;
        private TableLayoutPanel tableLayoutPanel8;
        public Panel panel3;
        public Label lbl_wpfile;
        private DataGridViewComboBoxColumn Command;
        private DataGridViewTextBoxColumn Param1;
        private DataGridViewTextBoxColumn Param2;
        private DataGridViewTextBoxColumn Param3;
        private DataGridViewTextBoxColumn Param4;
        private DataGridViewTextBoxColumn Lat;
        private DataGridViewTextBoxColumn Lon;
        private DataGridViewTextBoxColumn Alt;
        private DataGridViewComboBoxColumn Frame;
        private DataGridViewTextBoxColumn coordZone;
        private DataGridViewTextBoxColumn coordEasting;
        private DataGridViewTextBoxColumn coordNorthing;
        private DataGridViewTextBoxColumn MGRS;
        private DataGridViewButtonColumn Delete;
        private DataGridViewImageColumn Up;
        private DataGridViewImageColumn Down;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Angle;
        private DataGridViewTextBoxColumn Dist;
        private DataGridViewTextBoxColumn AZ;
        private DataGridViewTextBoxColumn TagData;
        public TableLayoutPanel tableLayoutPanel2;
    }
}