using System.Windows.Forms;
using MissionPlanner.Controls;
using Timer = System.Windows.Forms.Timer;

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

            if (currentMarker != null) currentMarker.Dispose();
            if (drawnpolygon != null) drawnpolygon.Dispose();
            if (kmlpolygonsoverlay != null) kmlpolygonsoverlay.Dispose();
            if (wppolygon != null) wppolygon.Dispose();
            if (top != null) top.Dispose();
            if (geofencepolygon != null) geofencepolygon.Dispose();
            if (geofenceoverlay != null) geofenceoverlay.Dispose();
            if (drawnpolygonsoverlay != null) drawnpolygonsoverlay.Dispose();
            if (center != null) center.Dispose();

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanner));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            but_writewpfast = new MyButton();
            BUT_write = new MyButton();
            BUT_read = new MyButton();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            Label1 = new Label();
            TXT_homealt = new TextBox();
            TXT_homelng = new TextBox();
            TXT_homelat = new TextBox();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            label6 = new Label();
            coords1 = new Coords();
            lbl_status = new Label();
            panelWaypoints = new Panel();
            but_mincommands = new MyButton();
            Commands = new MyDataGridView();
            Command = new DataGridViewComboBoxColumn();
            Param1 = new DataGridViewTextBoxColumn();
            Param2 = new DataGridViewTextBoxColumn();
            Param3 = new DataGridViewTextBoxColumn();
            Param4 = new DataGridViewTextBoxColumn();
            Lat = new DataGridViewTextBoxColumn();
            Lon = new DataGridViewTextBoxColumn();
            Alt = new DataGridViewTextBoxColumn();
            Frame = new DataGridViewComboBoxColumn();
            coordZone = new DataGridViewTextBoxColumn();
            coordEasting = new DataGridViewTextBoxColumn();
            coordNorthing = new DataGridViewTextBoxColumn();
            MGRS = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Up = new DataGridViewImageColumn();
            Down = new DataGridViewImageColumn();
            Grad = new DataGridViewTextBoxColumn();
            Angle = new DataGridViewTextBoxColumn();
            Dist = new DataGridViewTextBoxColumn();
            AZ = new DataGridViewTextBoxColumn();
            TagData = new DataGridViewTextBoxColumn();
            BUT_Add = new MyButton();
            splitter1 = new Splitter();
            panelAction = new Panel();
            panel2 = new Panel();
            GP_MapOptions = new GroupBox();
            label4 = new Label();
            panel3 = new Panel();
            LBL_Map_origin = new Label();
            chk_grid = new CheckBox();
            comboBoxMapType = new ComboBox();
            lnk_kml = new LinkLabel();
            GP_Zoom_Options = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            BUT_Zoom_Vehicle = new Button();
            imageList1 = new ImageList(components);
            BUT_Zoom_Mission = new Button();
            GP_Home_Options = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            BUT_Set_Home_On_Map = new Button();
            BTU_Set_Home_On_Vehicle = new Button();
            GP_WP_Tools = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            BUT_loadwpfile = new Button();
            BUT_saveWPFile = new Button();
            BUT_Clear_WP = new Button();
            BUT_WP_Mode = new Button();
            lbl_wpfile = new Label();
            GP_Polygon_Tools = new GroupBox();
            BUT_Grid_Mode = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            BUT_Load_Poly = new Button();
            BUT_Save_Poly = new Button();
            BUT_Poly_Mode = new Button();
            BUT_Clear_Poly = new Button();
            GP_Layer_Options = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            BUT_Clear_Echosounder = new Button();
            BUT_Plot_EchoSounder = new Button();
            BUT_Clear_GeoTiff = new Button();
            BUT_Clear_KML = new Button();
            BUT_Load_GeoTiff = new Button();
            BUT_Load_KML = new Button();
            splitter2 = new Splitter();
            panelMap = new Panel();
            Panel_Legend = new Panel();
            IMG_GradDepth = new PictureBox();
            LBL_Max_Depth = new Label();
            label7 = new Label();
            IMG_Tiff_Loading = new PictureBox();
            lbl_homedist = new Label();
            lbl_prevdist = new Label();
            trackBar1 = new MyTrackBar();
            label11 = new Label();
            lbl_distance = new Label();
            cmb_missiontype = new ComboBox();
            MainMap = new myGMAP();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteWPToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            geoFenceToolStripMenuItem = new ToolStripMenuItem();
            GeoFenceuploadToolStripMenuItem = new ToolStripMenuItem();
            GeoFencedownloadToolStripMenuItem = new ToolStripMenuItem();
            setReturnLocationToolStripMenuItem = new ToolStripMenuItem();
            loadFromFileToolStripMenuItem = new ToolStripMenuItem();
            saveToFileToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            pOIToolStripMenuItem = new ToolStripMenuItem();
            poiaddToolStripMenuItem = new ToolStripMenuItem();
            poideleteToolStripMenuItem = new ToolStripMenuItem();
            poieditToolStripMenuItem = new ToolStripMenuItem();
            enterUTMCoordToolStripMenuItem = new ToolStripMenuItem();
            setHomeHereToolStripMenuItem = new ToolStripMenuItem();
            addPolygonPointToolStripMenuItem = new ToolStripMenuItem();
            clearPolygonToolStripMenuItem = new ToolStripMenuItem();
            savePolygonToolStripMenuItem = new ToolStripMenuItem();
            loadPolygonToolStripMenuItem = new ToolStripMenuItem();
            fromSHPToolStripMenuItem = new ToolStripMenuItem();
            areaToolStripMenuItem = new ToolStripMenuItem();
            fenceInclusionToolStripMenuItem = new ToolStripMenuItem();
            fenceExclusionToolStripMenuItem = new ToolStripMenuItem();
            panelBASE = new Panel();
            toolTip1 = new ToolTip(components);
            timer1 = new Timer(components);
            contextMenuStripPoly = new ContextMenuStrip(components);
            drawAPolygonToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripZoom = new ContextMenuStrip(components);
            zoomToVehicleToolStripMenuItem = new ToolStripMenuItem();
            zoomToMissionToolStripMenuItem = new ToolStripMenuItem();
            zoomToHomeToolStripMenuItem = new ToolStripMenuItem();
            Timer_Update_Button_State = new Timer(components);
            panel1.SuspendLayout();
            panelWaypoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Commands).BeginInit();
            panelAction.SuspendLayout();
            panel2.SuspendLayout();
            GP_MapOptions.SuspendLayout();
            panel3.SuspendLayout();
            GP_Zoom_Options.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            GP_Home_Options.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            GP_WP_Tools.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            GP_Polygon_Tools.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            GP_Layer_Options.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panelMap.SuspendLayout();
            Panel_Legend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IMG_GradDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IMG_Tiff_Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panelBASE.SuspendLayout();
            contextMenuStripPoly.SuspendLayout();
            contextMenuStripZoom.SuspendLayout();
            SuspendLayout();
            // 
            // but_writewpfast
            // 
            but_writewpfast.BGGradBot = Color.FromArgb(255, 128, 128);
            but_writewpfast.BGGradTop = Color.FromArgb(255, 192, 192);
            resources.ApplyResources(but_writewpfast, "but_writewpfast");
            but_writewpfast.Name = "but_writewpfast";
            but_writewpfast.Outline = Color.Black;
            but_writewpfast.TextColor = Color.Black;
            but_writewpfast.TextColorNotEnabled = Color.Black;
            but_writewpfast.UseVisualStyleBackColor = true;
            but_writewpfast.Click += but_writewpfast_Click;
            // 
            // BUT_write
            // 
            BUT_write.BGGradBot = Color.FromArgb(255, 128, 128);
            BUT_write.BGGradTop = Color.FromArgb(255, 192, 192);
            resources.ApplyResources(BUT_write, "BUT_write");
            BUT_write.Name = "BUT_write";
            BUT_write.Outline = Color.Black;
            BUT_write.TextColor = Color.Black;
            BUT_write.TextColorNotEnabled = Color.Black;
            BUT_write.UseVisualStyleBackColor = true;
            BUT_write.Click += BUT_write_Click;
            // 
            // BUT_read
            // 
            BUT_read.BGGradBot = Color.FromArgb(255, 128, 128);
            BUT_read.BGGradTop = Color.FromArgb(255, 192, 192);
            resources.ApplyResources(BUT_read, "BUT_read");
            BUT_read.Name = "BUT_read";
            BUT_read.Outline = Color.Black;
            BUT_read.TextColor = Color.Black;
            BUT_read.TextColorNotEnabled = Color.Black;
            BUT_read.UseVisualStyleBackColor = true;
            BUT_read.Click += BUT_read_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Label1);
            panel1.Controls.Add(TXT_homealt);
            panel1.Controls.Add(TXT_homelng);
            panel1.Controls.Add(TXT_homelat);
            panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // Label1
            // 
            resources.ApplyResources(Label1, "Label1");
            Label1.Name = "Label1";
            // 
            // TXT_homealt
            // 
            resources.ApplyResources(TXT_homealt, "TXT_homealt");
            TXT_homealt.Name = "TXT_homealt";
            TXT_homealt.TextChanged += TXT_homealt_TextChanged;
            // 
            // TXT_homelng
            // 
            resources.ApplyResources(TXT_homelng, "TXT_homelng");
            TXT_homelng.Name = "TXT_homelng";
            TXT_homelng.TextChanged += TXT_homelng_TextChanged;
            // 
            // TXT_homelat
            // 
            resources.ApplyResources(TXT_homelat, "TXT_homelat");
            TXT_homelat.Name = "TXT_homelat";
            TXT_homelat.TextChanged += TXT_homelat_TextChanged;
            TXT_homelat.Enter += TXT_homelat_Enter;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(dataGridViewImageColumn1, "dataGridViewImageColumn1");
            dataGridViewImageColumn1.Image = (Image)resources.GetObject("dataGridViewImageColumn1.Image");
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(dataGridViewImageColumn2, "dataGridViewImageColumn2");
            dataGridViewImageColumn2.Image = (Image)resources.GetObject("dataGridViewImageColumn2.Image");
            dataGridViewImageColumn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // coords1
            // 
            coords1.Alt = 0D;
            coords1.AltSource = "";
            coords1.AltUnit = "m";
            resources.ApplyResources(coords1, "coords1");
            coords1.Lat = 0D;
            coords1.Lng = 0D;
            coords1.Name = "coords1";
            coords1.Vertical = true;
            coords1.SystemChanged += coords1_SystemChanged;
            // 
            // lbl_status
            // 
            resources.ApplyResources(lbl_status, "lbl_status");
            lbl_status.Name = "lbl_status";
            // 
            // panelWaypoints
            // 
            panelWaypoints.Controls.Add(but_mincommands);
            panelWaypoints.Controls.Add(Commands);
            panelWaypoints.Controls.Add(BUT_Add);
            resources.ApplyResources(panelWaypoints, "panelWaypoints");
            panelWaypoints.ForeColor = SystemColors.ControlText;
            panelWaypoints.Name = "panelWaypoints";
            // 
            // but_mincommands
            // 
            resources.ApplyResources(but_mincommands, "but_mincommands");
            but_mincommands.Name = "but_mincommands";
            but_mincommands.TextColor = Color.White;
            but_mincommands.TextColorNotEnabled = Color.White;
            but_mincommands.UseVisualStyleBackColor = true;
            but_mincommands.Click += but_mincommands_Click;
            // 
            // Commands
            // 
            Commands.AllowUserToAddRows = false;
            resources.ApplyResources(Commands, "Commands");
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Commands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Commands.Columns.AddRange(new DataGridViewColumn[] { Command, Param1, Param2, Param3, Param4, Lat, Lon, Alt, Frame, coordZone, coordEasting, coordNorthing, MGRS, Delete, Up, Down, Grad, Angle, Dist, AZ, TagData });
            Commands.Name = "Commands";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            Commands.RowsDefaultCellStyle = dataGridViewCellStyle8;
            Commands.CellContentClick += Commands_CellContentClick;
            Commands.CellEndEdit += Commands_CellEndEdit;
            Commands.DataError += Commands_DataError;
            Commands.DefaultValuesNeeded += Commands_DefaultValuesNeeded;
            Commands.EditingControlShowing += Commands_EditingControlShowing;
            Commands.RowEnter += Commands_RowEnter;
            Commands.RowsAdded += Commands_RowsAdded;
            Commands.RowsRemoved += Commands_RowsRemoved;
            Commands.RowValidating += Commands_RowValidating;
            // 
            // Command
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(67, 68, 69);
            dataGridViewCellStyle4.ForeColor = Color.White;
            Command.DefaultCellStyle = dataGridViewCellStyle4;
            Command.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(Command, "Command");
            Command.Name = "Command";
            // 
            // Param1
            // 
            resources.ApplyResources(Param1, "Param1");
            Param1.Name = "Param1";
            Param1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Param2
            // 
            resources.ApplyResources(Param2, "Param2");
            Param2.Name = "Param2";
            Param2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Param3
            // 
            resources.ApplyResources(Param3, "Param3");
            Param3.Name = "Param3";
            Param3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Param4
            // 
            resources.ApplyResources(Param4, "Param4");
            Param4.Name = "Param4";
            Param4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Lat
            // 
            resources.ApplyResources(Lat, "Lat");
            Lat.Name = "Lat";
            Lat.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Lon
            // 
            resources.ApplyResources(Lon, "Lon");
            Lon.Name = "Lon";
            Lon.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Alt
            // 
            resources.ApplyResources(Alt, "Alt");
            Alt.Name = "Alt";
            Alt.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Frame
            // 
            resources.ApplyResources(Frame, "Frame");
            Frame.Name = "Frame";
            // 
            // coordZone
            // 
            resources.ApplyResources(coordZone, "coordZone");
            coordZone.Name = "coordZone";
            // 
            // coordEasting
            // 
            resources.ApplyResources(coordEasting, "coordEasting");
            coordEasting.Name = "coordEasting";
            // 
            // coordNorthing
            // 
            resources.ApplyResources(coordNorthing, "coordNorthing");
            coordNorthing.Name = "coordNorthing";
            // 
            // MGRS
            // 
            resources.ApplyResources(MGRS, "MGRS");
            MGRS.Name = "MGRS";
            // 
            // Delete
            // 
            resources.ApplyResources(Delete, "Delete");
            Delete.Name = "Delete";
            Delete.Text = "X";
            // 
            // Up
            // 
            Up.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(Up, "Up");
            Up.Image = (Image)resources.GetObject("Up.Image");
            Up.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Up.Name = "Up";
            // 
            // Down
            // 
            Down.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(Down, "Down");
            Down.Image = (Image)resources.GetObject("Down.Image");
            Down.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Down.Name = "Down";
            // 
            // Grad
            // 
            resources.ApplyResources(Grad, "Grad");
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            Grad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Angle
            // 
            resources.ApplyResources(Angle, "Angle");
            Angle.Name = "Angle";
            Angle.ReadOnly = true;
            Angle.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Dist
            // 
            resources.ApplyResources(Dist, "Dist");
            Dist.Name = "Dist";
            Dist.ReadOnly = true;
            Dist.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AZ
            // 
            resources.ApplyResources(AZ, "AZ");
            AZ.Name = "AZ";
            AZ.ReadOnly = true;
            AZ.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // TagData
            // 
            resources.ApplyResources(TagData, "TagData");
            TagData.Name = "TagData";
            TagData.ReadOnly = true;
            // 
            // BUT_Add
            // 
            resources.ApplyResources(BUT_Add, "BUT_Add");
            BUT_Add.Name = "BUT_Add";
            BUT_Add.TextColor = Color.White;
            BUT_Add.TextColorNotEnabled = Color.White;
            toolTip1.SetToolTip(BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            BUT_Add.UseVisualStyleBackColor = true;
            BUT_Add.Click += BUT_Add_Click;
            // 
            // splitter1
            // 
            resources.ApplyResources(splitter1, "splitter1");
            splitter1.Name = "splitter1";
            splitter1.TabStop = false;
            // 
            // panelAction
            // 
            panelAction.Controls.Add(panel2);
            resources.ApplyResources(panelAction, "panelAction");
            panelAction.ForeColor = SystemColors.ControlText;
            panelAction.Name = "panelAction";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(GP_MapOptions);
            panel2.Controls.Add(GP_Zoom_Options);
            panel2.Controls.Add(GP_Home_Options);
            panel2.Controls.Add(GP_WP_Tools);
            panel2.Controls.Add(GP_Polygon_Tools);
            panel2.Controls.Add(GP_Layer_Options);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // GP_MapOptions
            // 
            GP_MapOptions.Controls.Add(label4);
            GP_MapOptions.Controls.Add(coords1);
            GP_MapOptions.Controls.Add(panel3);
            resources.ApplyResources(GP_MapOptions, "GP_MapOptions");
            GP_MapOptions.Name = "GP_MapOptions";
            GP_MapOptions.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Controls.Add(LBL_Map_origin);
            panel3.Controls.Add(chk_grid);
            panel3.Controls.Add(lbl_status);
            panel3.Controls.Add(comboBoxMapType);
            panel3.Controls.Add(lnk_kml);
            panel3.Name = "panel3";
            // 
            // LBL_Map_origin
            // 
            resources.ApplyResources(LBL_Map_origin, "LBL_Map_origin");
            LBL_Map_origin.Name = "LBL_Map_origin";
            // 
            // chk_grid
            // 
            resources.ApplyResources(chk_grid, "chk_grid");
            chk_grid.Name = "chk_grid";
            chk_grid.UseVisualStyleBackColor = true;
            chk_grid.CheckedChanged += chk_grid_CheckedChanged;
            // 
            // comboBoxMapType
            // 
            resources.ApplyResources(comboBoxMapType, "comboBoxMapType");
            comboBoxMapType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMapType.FormattingEnabled = true;
            comboBoxMapType.Name = "comboBoxMapType";
            toolTip1.SetToolTip(comboBoxMapType, resources.GetString("comboBoxMapType.ToolTip"));
            // 
            // lnk_kml
            // 
            resources.ApplyResources(lnk_kml, "lnk_kml");
            lnk_kml.Name = "lnk_kml";
            lnk_kml.TabStop = true;
            lnk_kml.LinkClicked += lnk_kml_LinkClicked;
            // 
            // GP_Zoom_Options
            // 
            GP_Zoom_Options.Controls.Add(tableLayoutPanel2);
            resources.ApplyResources(GP_Zoom_Options, "GP_Zoom_Options");
            GP_Zoom_Options.Name = "GP_Zoom_Options";
            GP_Zoom_Options.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(BUT_Zoom_Vehicle, 0, 0);
            tableLayoutPanel2.Controls.Add(BUT_Zoom_Mission, 0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // BUT_Zoom_Vehicle
            // 
            BUT_Zoom_Vehicle.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Zoom_Vehicle, "BUT_Zoom_Vehicle");
            BUT_Zoom_Vehicle.ImageList = imageList1;
            BUT_Zoom_Vehicle.Name = "BUT_Zoom_Vehicle";
            BUT_Zoom_Vehicle.UseVisualStyleBackColor = false;
            BUT_Zoom_Vehicle.Click += zoomToVehicleToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Poly-icon.png");
            imageList1.Images.SetKeyName(1, "Clear-icon.png");
            imageList1.Images.SetKeyName(2, "Load-icon.png");
            imageList1.Images.SetKeyName(3, "Save-icon.png");
            imageList1.Images.SetKeyName(4, "Route-icon.png");
            imageList1.Images.SetKeyName(5, "marker_02.png");
            imageList1.Images.SetKeyName(6, "HomeGPS-icon.png");
            imageList1.Images.SetKeyName(7, "HomeMap-icon.png");
            imageList1.Images.SetKeyName(8, "KML-icon.png");
            imageList1.Images.SetKeyName(9, "TIFF-icon.png");
            imageList1.Images.SetKeyName(10, "ZoomVehicle-icon.png");
            imageList1.Images.SetKeyName(11, "ZoomMission.png");
            imageList1.Images.SetKeyName(12, "PlotEcho-icon.png");
            // 
            // BUT_Zoom_Mission
            // 
            BUT_Zoom_Mission.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Zoom_Mission, "BUT_Zoom_Mission");
            BUT_Zoom_Mission.ImageList = imageList1;
            BUT_Zoom_Mission.Name = "BUT_Zoom_Mission";
            BUT_Zoom_Mission.UseVisualStyleBackColor = false;
            BUT_Zoom_Mission.Click += zoomToMissionToolStripMenuItem_Click;
            // 
            // GP_Home_Options
            // 
            GP_Home_Options.Controls.Add(tableLayoutPanel3);
            GP_Home_Options.Controls.Add(panel1);
            resources.ApplyResources(GP_Home_Options, "GP_Home_Options");
            GP_Home_Options.Name = "GP_Home_Options";
            GP_Home_Options.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(BUT_Set_Home_On_Map, 0, 0);
            tableLayoutPanel3.Controls.Add(BTU_Set_Home_On_Vehicle, 0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // BUT_Set_Home_On_Map
            // 
            BUT_Set_Home_On_Map.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Set_Home_On_Map, "BUT_Set_Home_On_Map");
            BUT_Set_Home_On_Map.ImageList = imageList1;
            BUT_Set_Home_On_Map.Name = "BUT_Set_Home_On_Map";
            BUT_Set_Home_On_Map.UseVisualStyleBackColor = false;
            BUT_Set_Home_On_Map.Click += TXT_homelat_Enter;
            // 
            // BTU_Set_Home_On_Vehicle
            // 
            BTU_Set_Home_On_Vehicle.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BTU_Set_Home_On_Vehicle, "BTU_Set_Home_On_Vehicle");
            BTU_Set_Home_On_Vehicle.ImageList = imageList1;
            BTU_Set_Home_On_Vehicle.Name = "BTU_Set_Home_On_Vehicle";
            BTU_Set_Home_On_Vehicle.UseVisualStyleBackColor = false;
            BTU_Set_Home_On_Vehicle.Click += BTU_Set_Home_On_Vehicle_Click;
            // 
            // GP_WP_Tools
            // 
            GP_WP_Tools.Controls.Add(tableLayoutPanel5);
            GP_WP_Tools.Controls.Add(tableLayoutPanel1);
            GP_WP_Tools.Controls.Add(lbl_wpfile);
            resources.ApplyResources(GP_WP_Tools, "GP_WP_Tools");
            GP_WP_Tools.Name = "GP_WP_Tools";
            GP_WP_Tools.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(tableLayoutPanel5, "tableLayoutPanel5");
            tableLayoutPanel5.Controls.Add(BUT_read, 2, 0);
            tableLayoutPanel5.Controls.Add(but_writewpfast, 1, 0);
            tableLayoutPanel5.Controls.Add(BUT_write, 0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(BUT_loadwpfile, 0, 1);
            tableLayoutPanel1.Controls.Add(BUT_saveWPFile, 0, 1);
            tableLayoutPanel1.Controls.Add(BUT_Clear_WP, 1, 0);
            tableLayoutPanel1.Controls.Add(BUT_WP_Mode, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // BUT_loadwpfile
            // 
            BUT_loadwpfile.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_loadwpfile, "BUT_loadwpfile");
            BUT_loadwpfile.ImageList = imageList1;
            BUT_loadwpfile.Name = "BUT_loadwpfile";
            BUT_loadwpfile.UseVisualStyleBackColor = false;
            BUT_loadwpfile.Click += BUT_loadwpfile_Click;
            // 
            // BUT_saveWPFile
            // 
            BUT_saveWPFile.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_saveWPFile, "BUT_saveWPFile");
            BUT_saveWPFile.ImageList = imageList1;
            BUT_saveWPFile.Name = "BUT_saveWPFile";
            BUT_saveWPFile.UseVisualStyleBackColor = false;
            BUT_saveWPFile.Click += BUT_saveWPFile_Click;
            // 
            // BUT_Clear_WP
            // 
            BUT_Clear_WP.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Clear_WP, "BUT_Clear_WP");
            BUT_Clear_WP.ImageList = imageList1;
            BUT_Clear_WP.Name = "BUT_Clear_WP";
            BUT_Clear_WP.UseVisualStyleBackColor = false;
            BUT_Clear_WP.Click += clearMissionToolStripMenuItem_Click;
            // 
            // BUT_WP_Mode
            // 
            BUT_WP_Mode.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_WP_Mode, "BUT_WP_Mode");
            BUT_WP_Mode.ImageList = imageList1;
            BUT_WP_Mode.Name = "BUT_WP_Mode";
            BUT_WP_Mode.UseVisualStyleBackColor = false;
            BUT_WP_Mode.Click += BUT_WP_Mode_Click;
            // 
            // lbl_wpfile
            // 
            resources.ApplyResources(lbl_wpfile, "lbl_wpfile");
            lbl_wpfile.Name = "lbl_wpfile";
            // 
            // GP_Polygon_Tools
            // 
            GP_Polygon_Tools.Controls.Add(BUT_Grid_Mode);
            GP_Polygon_Tools.Controls.Add(tableLayoutPanel4);
            resources.ApplyResources(GP_Polygon_Tools, "GP_Polygon_Tools");
            GP_Polygon_Tools.Name = "GP_Polygon_Tools";
            GP_Polygon_Tools.TabStop = false;
            // 
            // BUT_Grid_Mode
            // 
            resources.ApplyResources(BUT_Grid_Mode, "BUT_Grid_Mode");
            BUT_Grid_Mode.BackColor = Color.FromArgb(148, 193, 31);
            BUT_Grid_Mode.ImageList = imageList1;
            BUT_Grid_Mode.Name = "BUT_Grid_Mode";
            BUT_Grid_Mode.UseVisualStyleBackColor = false;
            BUT_Grid_Mode.Click += surveyGridToolStripMenuItem_Click;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.Controls.Add(BUT_Load_Poly, 0, 1);
            tableLayoutPanel4.Controls.Add(BUT_Save_Poly, 0, 1);
            tableLayoutPanel4.Controls.Add(BUT_Poly_Mode, 0, 0);
            tableLayoutPanel4.Controls.Add(BUT_Clear_Poly, 1, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // BUT_Load_Poly
            // 
            BUT_Load_Poly.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Load_Poly, "BUT_Load_Poly");
            BUT_Load_Poly.ImageList = imageList1;
            BUT_Load_Poly.Name = "BUT_Load_Poly";
            BUT_Load_Poly.UseVisualStyleBackColor = false;
            BUT_Load_Poly.Click += loadPolygonToolStripMenuItem_Click;
            // 
            // BUT_Save_Poly
            // 
            BUT_Save_Poly.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Save_Poly, "BUT_Save_Poly");
            BUT_Save_Poly.ImageList = imageList1;
            BUT_Save_Poly.Name = "BUT_Save_Poly";
            BUT_Save_Poly.UseVisualStyleBackColor = false;
            BUT_Save_Poly.Click += savePolygonToolStripMenuItem_Click;
            // 
            // BUT_Poly_Mode
            // 
            BUT_Poly_Mode.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Poly_Mode, "BUT_Poly_Mode");
            BUT_Poly_Mode.ImageList = imageList1;
            BUT_Poly_Mode.Name = "BUT_Poly_Mode";
            BUT_Poly_Mode.UseVisualStyleBackColor = false;
            BUT_Poly_Mode.Click += BUT_Poly_Mode_Click;
            // 
            // BUT_Clear_Poly
            // 
            BUT_Clear_Poly.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Clear_Poly, "BUT_Clear_Poly");
            BUT_Clear_Poly.ImageList = imageList1;
            BUT_Clear_Poly.Name = "BUT_Clear_Poly";
            BUT_Clear_Poly.UseVisualStyleBackColor = false;
            BUT_Clear_Poly.Click += clearPolygonToolStripMenuItem_Click;
            // 
            // GP_Layer_Options
            // 
            GP_Layer_Options.Controls.Add(tableLayoutPanel6);
            resources.ApplyResources(GP_Layer_Options, "GP_Layer_Options");
            GP_Layer_Options.Name = "GP_Layer_Options";
            GP_Layer_Options.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(tableLayoutPanel6, "tableLayoutPanel6");
            tableLayoutPanel6.Controls.Add(BUT_Clear_Echosounder, 1, 2);
            tableLayoutPanel6.Controls.Add(BUT_Plot_EchoSounder, 0, 2);
            tableLayoutPanel6.Controls.Add(BUT_Clear_GeoTiff, 1, 0);
            tableLayoutPanel6.Controls.Add(BUT_Clear_KML, 1, 1);
            tableLayoutPanel6.Controls.Add(BUT_Load_GeoTiff, 0, 0);
            tableLayoutPanel6.Controls.Add(BUT_Load_KML, 0, 1);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // BUT_Clear_Echosounder
            // 
            BUT_Clear_Echosounder.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Clear_Echosounder, "BUT_Clear_Echosounder");
            BUT_Clear_Echosounder.ImageList = imageList1;
            BUT_Clear_Echosounder.Name = "BUT_Clear_Echosounder";
            BUT_Clear_Echosounder.UseVisualStyleBackColor = false;
            BUT_Clear_Echosounder.Click += BUT_Clear_Echosounder_Click;
            // 
            // BUT_Plot_EchoSounder
            // 
            BUT_Plot_EchoSounder.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Plot_EchoSounder, "BUT_Plot_EchoSounder");
            BUT_Plot_EchoSounder.ImageList = imageList1;
            BUT_Plot_EchoSounder.Name = "BUT_Plot_EchoSounder";
            BUT_Plot_EchoSounder.UseVisualStyleBackColor = false;
            BUT_Plot_EchoSounder.Click += BUT_Plot_EchoSounder_Click;
            // 
            // BUT_Clear_GeoTiff
            // 
            BUT_Clear_GeoTiff.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Clear_GeoTiff, "BUT_Clear_GeoTiff");
            BUT_Clear_GeoTiff.ImageList = imageList1;
            BUT_Clear_GeoTiff.Name = "BUT_Clear_GeoTiff";
            BUT_Clear_GeoTiff.UseVisualStyleBackColor = false;
            BUT_Clear_GeoTiff.Click += BUT_Clear_GeoTiff_Click;
            // 
            // BUT_Clear_KML
            // 
            BUT_Clear_KML.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Clear_KML, "BUT_Clear_KML");
            BUT_Clear_KML.ImageList = imageList1;
            BUT_Clear_KML.Name = "BUT_Clear_KML";
            BUT_Clear_KML.UseVisualStyleBackColor = false;
            BUT_Clear_KML.Click += BUT_Clear_KML_Click;
            // 
            // BUT_Load_GeoTiff
            // 
            BUT_Load_GeoTiff.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Load_GeoTiff, "BUT_Load_GeoTiff");
            BUT_Load_GeoTiff.ImageList = imageList1;
            BUT_Load_GeoTiff.Name = "BUT_Load_GeoTiff";
            BUT_Load_GeoTiff.UseVisualStyleBackColor = false;
            BUT_Load_GeoTiff.Click += BUT_Load_GeoTiff_Click;
            // 
            // BUT_Load_KML
            // 
            BUT_Load_KML.BackColor = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Load_KML, "BUT_Load_KML");
            BUT_Load_KML.ImageList = imageList1;
            BUT_Load_KML.Name = "BUT_Load_KML";
            BUT_Load_KML.UseVisualStyleBackColor = false;
            // 
            // splitter2
            // 
            resources.ApplyResources(splitter2, "splitter2");
            splitter2.Name = "splitter2";
            splitter2.TabStop = false;
            // 
            // panelMap
            // 
            panelMap.Controls.Add(Panel_Legend);
            panelMap.Controls.Add(IMG_Tiff_Loading);
            panelMap.Controls.Add(lbl_homedist);
            panelMap.Controls.Add(lbl_prevdist);
            panelMap.Controls.Add(trackBar1);
            panelMap.Controls.Add(label11);
            panelMap.Controls.Add(lbl_distance);
            panelMap.Controls.Add(cmb_missiontype);
            panelMap.Controls.Add(MainMap);
            resources.ApplyResources(panelMap, "panelMap");
            panelMap.ForeColor = SystemColors.ControlText;
            panelMap.Name = "panelMap";
            panelMap.Resize += panelMap_Resize;
            // 
            // Panel_Legend
            // 
            resources.ApplyResources(Panel_Legend, "Panel_Legend");
            Panel_Legend.Controls.Add(IMG_GradDepth);
            Panel_Legend.Controls.Add(LBL_Max_Depth);
            Panel_Legend.Controls.Add(label7);
            Panel_Legend.Name = "Panel_Legend";
            // 
            // IMG_GradDepth
            // 
            IMG_GradDepth.Image = Properties.Resources.GradDepth;
            resources.ApplyResources(IMG_GradDepth, "IMG_GradDepth");
            IMG_GradDepth.Name = "IMG_GradDepth";
            IMG_GradDepth.TabStop = false;
            // 
            // LBL_Max_Depth
            // 
            resources.ApplyResources(LBL_Max_Depth, "LBL_Max_Depth");
            LBL_Max_Depth.Name = "LBL_Max_Depth";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // IMG_Tiff_Loading
            // 
            resources.ApplyResources(IMG_Tiff_Loading, "IMG_Tiff_Loading");
            IMG_Tiff_Loading.Image = Properties.Resources.ZKZg;
            IMG_Tiff_Loading.Name = "IMG_Tiff_Loading";
            IMG_Tiff_Loading.TabStop = false;
            // 
            // lbl_homedist
            // 
            resources.ApplyResources(lbl_homedist, "lbl_homedist");
            lbl_homedist.Name = "lbl_homedist";
            // 
            // lbl_prevdist
            // 
            resources.ApplyResources(lbl_prevdist, "lbl_prevdist");
            lbl_prevdist.Name = "lbl_prevdist";
            // 
            // trackBar1
            // 
            resources.ApplyResources(trackBar1, "trackBar1");
            trackBar1.LargeChange = 0.005F;
            trackBar1.Maximum = 24F;
            trackBar1.Minimum = 1F;
            trackBar1.Name = "trackBar1";
            trackBar1.SmallChange = 0.001F;
            trackBar1.TickFrequency = 1F;
            trackBar1.TickStyle = TickStyle.TopLeft;
            trackBar1.Value = 2F;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // lbl_distance
            // 
            resources.ApplyResources(lbl_distance, "lbl_distance");
            lbl_distance.Name = "lbl_distance";
            // 
            // cmb_missiontype
            // 
            resources.ApplyResources(cmb_missiontype, "cmb_missiontype");
            cmb_missiontype.FormattingEnabled = true;
            cmb_missiontype.Items.AddRange(new object[] { resources.GetString("cmb_missiontype.Items"), resources.GetString("cmb_missiontype.Items1"), resources.GetString("cmb_missiontype.Items2") });
            cmb_missiontype.Name = "cmb_missiontype";
            cmb_missiontype.SelectedIndexChanged += Cmb_missiontype_SelectedIndexChanged;
            // 
            // MainMap
            // 
            resources.ApplyResources(MainMap, "MainMap");
            MainMap.BackColor = Color.FromArgb(38, 39, 40);
            MainMap.Bearing = 0F;
            MainMap.CanDragMap = true;
            MainMap.ContextMenuStrip = contextMenuStrip1;
            MainMap.EmptyTileColor = Color.Gray;
            MainMap.GrayScaleMode = false;
            MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            MainMap.HoldInvalidation = false;
            MainMap.LevelsKeepInMemmory = 5;
            MainMap.MarkersEnabled = true;
            MainMap.MaxZoom = 19;
            MainMap.MinZoom = 0;
            MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            MainMap.Name = "MainMap";
            MainMap.NegativeMode = false;
            MainMap.PolygonsEnabled = true;
            MainMap.RetryLoadTile = 0;
            MainMap.RoutesEnabled = true;
            MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            MainMap.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            MainMap.ShowTileGridLines = false;
            MainMap.Zoom = 0D;
            MainMap.Paint += MainMap_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(18, 18);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteWPToolStripMenuItem, toolStripSeparator1, geoFenceToolStripMenuItem, pOIToolStripMenuItem, enterUTMCoordToolStripMenuItem, setHomeHereToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowImageMargin = false;
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            contextMenuStrip1.Closed += contextMenuStrip1_Closed;
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // deleteWPToolStripMenuItem
            // 
            deleteWPToolStripMenuItem.Name = "deleteWPToolStripMenuItem";
            resources.ApplyResources(deleteWPToolStripMenuItem, "deleteWPToolStripMenuItem");
            deleteWPToolStripMenuItem.Click += deleteWPToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // geoFenceToolStripMenuItem
            // 
            geoFenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GeoFenceuploadToolStripMenuItem, GeoFencedownloadToolStripMenuItem, setReturnLocationToolStripMenuItem, loadFromFileToolStripMenuItem, saveToFileToolStripMenuItem, clearToolStripMenuItem });
            geoFenceToolStripMenuItem.Name = "geoFenceToolStripMenuItem";
            resources.ApplyResources(geoFenceToolStripMenuItem, "geoFenceToolStripMenuItem");
            // 
            // GeoFenceuploadToolStripMenuItem
            // 
            GeoFenceuploadToolStripMenuItem.Name = "GeoFenceuploadToolStripMenuItem";
            resources.ApplyResources(GeoFenceuploadToolStripMenuItem, "GeoFenceuploadToolStripMenuItem");
            GeoFenceuploadToolStripMenuItem.Click += GeoFenceuploadToolStripMenuItem_Click;
            // 
            // GeoFencedownloadToolStripMenuItem
            // 
            GeoFencedownloadToolStripMenuItem.Name = "GeoFencedownloadToolStripMenuItem";
            resources.ApplyResources(GeoFencedownloadToolStripMenuItem, "GeoFencedownloadToolStripMenuItem");
            GeoFencedownloadToolStripMenuItem.Click += GeoFencedownloadToolStripMenuItem_Click;
            // 
            // setReturnLocationToolStripMenuItem
            // 
            setReturnLocationToolStripMenuItem.Name = "setReturnLocationToolStripMenuItem";
            resources.ApplyResources(setReturnLocationToolStripMenuItem, "setReturnLocationToolStripMenuItem");
            setReturnLocationToolStripMenuItem.Click += setReturnLocationToolStripMenuItem_Click;
            // 
            // loadFromFileToolStripMenuItem
            // 
            loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            resources.ApplyResources(loadFromFileToolStripMenuItem, "loadFromFileToolStripMenuItem");
            loadFromFileToolStripMenuItem.Click += loadFromFileToolStripMenuItem_Click;
            // 
            // saveToFileToolStripMenuItem
            // 
            saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            resources.ApplyResources(saveToFileToolStripMenuItem, "saveToFileToolStripMenuItem");
            saveToFileToolStripMenuItem.Click += saveToFileToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(clearToolStripMenuItem, "clearToolStripMenuItem");
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // pOIToolStripMenuItem
            // 
            pOIToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { poiaddToolStripMenuItem, poideleteToolStripMenuItem, poieditToolStripMenuItem });
            pOIToolStripMenuItem.Name = "pOIToolStripMenuItem";
            resources.ApplyResources(pOIToolStripMenuItem, "pOIToolStripMenuItem");
            // 
            // poiaddToolStripMenuItem
            // 
            poiaddToolStripMenuItem.Name = "poiaddToolStripMenuItem";
            resources.ApplyResources(poiaddToolStripMenuItem, "poiaddToolStripMenuItem");
            poiaddToolStripMenuItem.Click += poiaddToolStripMenuItem_Click;
            // 
            // poideleteToolStripMenuItem
            // 
            poideleteToolStripMenuItem.Name = "poideleteToolStripMenuItem";
            resources.ApplyResources(poideleteToolStripMenuItem, "poideleteToolStripMenuItem");
            poideleteToolStripMenuItem.Click += poideleteToolStripMenuItem_Click;
            // 
            // poieditToolStripMenuItem
            // 
            poieditToolStripMenuItem.Name = "poieditToolStripMenuItem";
            resources.ApplyResources(poieditToolStripMenuItem, "poieditToolStripMenuItem");
            poieditToolStripMenuItem.Click += poieditToolStripMenuItem_Click;
            // 
            // enterUTMCoordToolStripMenuItem
            // 
            enterUTMCoordToolStripMenuItem.Name = "enterUTMCoordToolStripMenuItem";
            resources.ApplyResources(enterUTMCoordToolStripMenuItem, "enterUTMCoordToolStripMenuItem");
            enterUTMCoordToolStripMenuItem.Click += enterUTMCoordToolStripMenuItem_Click;
            // 
            // setHomeHereToolStripMenuItem
            // 
            setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            resources.ApplyResources(setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            setHomeHereToolStripMenuItem.Click += setHomeHereToolStripMenuItem_Click;
            // 
            // addPolygonPointToolStripMenuItem
            // 
            addPolygonPointToolStripMenuItem.Name = "addPolygonPointToolStripMenuItem";
            resources.ApplyResources(addPolygonPointToolStripMenuItem, "addPolygonPointToolStripMenuItem");
            addPolygonPointToolStripMenuItem.Click += addPolygonPointToolStripMenuItem_Click;
            // 
            // clearPolygonToolStripMenuItem
            // 
            clearPolygonToolStripMenuItem.Name = "clearPolygonToolStripMenuItem";
            resources.ApplyResources(clearPolygonToolStripMenuItem, "clearPolygonToolStripMenuItem");
            clearPolygonToolStripMenuItem.Click += clearPolygonToolStripMenuItem_Click;
            // 
            // savePolygonToolStripMenuItem
            // 
            savePolygonToolStripMenuItem.Name = "savePolygonToolStripMenuItem";
            resources.ApplyResources(savePolygonToolStripMenuItem, "savePolygonToolStripMenuItem");
            savePolygonToolStripMenuItem.Click += savePolygonToolStripMenuItem_Click;
            // 
            // loadPolygonToolStripMenuItem
            // 
            loadPolygonToolStripMenuItem.Name = "loadPolygonToolStripMenuItem";
            resources.ApplyResources(loadPolygonToolStripMenuItem, "loadPolygonToolStripMenuItem");
            loadPolygonToolStripMenuItem.Click += loadPolygonToolStripMenuItem_Click;
            // 
            // fromSHPToolStripMenuItem
            // 
            fromSHPToolStripMenuItem.Name = "fromSHPToolStripMenuItem";
            resources.ApplyResources(fromSHPToolStripMenuItem, "fromSHPToolStripMenuItem");
            // 
            // areaToolStripMenuItem
            // 
            areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            resources.ApplyResources(areaToolStripMenuItem, "areaToolStripMenuItem");
            areaToolStripMenuItem.Click += areaToolStripMenuItem_Click;
            // 
            // fenceInclusionToolStripMenuItem
            // 
            fenceInclusionToolStripMenuItem.Name = "fenceInclusionToolStripMenuItem";
            resources.ApplyResources(fenceInclusionToolStripMenuItem, "fenceInclusionToolStripMenuItem");
            fenceInclusionToolStripMenuItem.Click += FenceInclusionToolStripMenuItem_Click;
            // 
            // fenceExclusionToolStripMenuItem
            // 
            fenceExclusionToolStripMenuItem.Name = "fenceExclusionToolStripMenuItem";
            resources.ApplyResources(fenceExclusionToolStripMenuItem, "fenceExclusionToolStripMenuItem");
            fenceExclusionToolStripMenuItem.Click += FenceExclusionToolStripMenuItem_Click;
            // 
            // panelBASE
            // 
            panelBASE.Controls.Add(splitter2);
            panelBASE.Controls.Add(splitter1);
            panelBASE.Controls.Add(panelMap);
            panelBASE.Controls.Add(panelWaypoints);
            panelBASE.Controls.Add(panelAction);
            panelBASE.Controls.Add(label6);
            resources.ApplyResources(panelBASE, "panelBASE");
            panelBASE.Name = "panelBASE";
            // 
            // timer1
            // 
            timer1.Interval = 1200;
            timer1.Tick += timer1_Tick;
            // 
            // contextMenuStripPoly
            // 
            contextMenuStripPoly.ImageScalingSize = new Size(18, 18);
            contextMenuStripPoly.Items.AddRange(new ToolStripItem[] { addPolygonPointToolStripMenuItem, clearPolygonToolStripMenuItem, savePolygonToolStripMenuItem, loadPolygonToolStripMenuItem, fromSHPToolStripMenuItem, areaToolStripMenuItem, fenceInclusionToolStripMenuItem, fenceExclusionToolStripMenuItem });
            contextMenuStripPoly.Name = "contextMenuStripPoly";
            contextMenuStripPoly.ShowImageMargin = false;
            resources.ApplyResources(contextMenuStripPoly, "contextMenuStripPoly");
            contextMenuStripPoly.Opening += ContextMenuStripPoly_Opening;
            // 
            // drawAPolygonToolStripMenuItem
            // 
            drawAPolygonToolStripMenuItem.Name = "drawAPolygonToolStripMenuItem";
            resources.ApplyResources(drawAPolygonToolStripMenuItem, "drawAPolygonToolStripMenuItem");
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            resources.ApplyResources(testToolStripMenuItem, "testToolStripMenuItem");
            // 
            // contextMenuStripZoom
            // 
            contextMenuStripZoom.ImageScalingSize = new Size(18, 18);
            contextMenuStripZoom.Items.AddRange(new ToolStripItem[] { zoomToVehicleToolStripMenuItem, zoomToMissionToolStripMenuItem, zoomToHomeToolStripMenuItem });
            contextMenuStripZoom.Name = "contextMenuStripZoom";
            resources.ApplyResources(contextMenuStripZoom, "contextMenuStripZoom");
            // 
            // zoomToVehicleToolStripMenuItem
            // 
            zoomToVehicleToolStripMenuItem.Name = "zoomToVehicleToolStripMenuItem";
            resources.ApplyResources(zoomToVehicleToolStripMenuItem, "zoomToVehicleToolStripMenuItem");
            zoomToVehicleToolStripMenuItem.Click += zoomToVehicleToolStripMenuItem_Click;
            // 
            // zoomToMissionToolStripMenuItem
            // 
            zoomToMissionToolStripMenuItem.Name = "zoomToMissionToolStripMenuItem";
            resources.ApplyResources(zoomToMissionToolStripMenuItem, "zoomToMissionToolStripMenuItem");
            zoomToMissionToolStripMenuItem.Click += zoomToMissionToolStripMenuItem_Click;
            // 
            // zoomToHomeToolStripMenuItem
            // 
            zoomToHomeToolStripMenuItem.Name = "zoomToHomeToolStripMenuItem";
            resources.ApplyResources(zoomToHomeToolStripMenuItem, "zoomToHomeToolStripMenuItem");
            zoomToHomeToolStripMenuItem.Click += zoomToHomeToolStripMenuItem_Click;
            // 
            // Timer_Update_Button_State
            // 
            Timer_Update_Button_State.Enabled = true;
            Timer_Update_Button_State.Tick += Timer_Update_Button_State_Tick;
            // 
            // FlightPlanner
            // 
            BackColor = SystemColors.Control;
            Controls.Add(panelBASE);
            resources.ApplyResources(this, "$this");
            Name = "FlightPlanner";
            FormClosing += FlightPlanner_FormClosing;
            Load += FlightPlanner_Load;
            Resize += Planner_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelWaypoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Commands).EndInit();
            panelAction.ResumeLayout(false);
            panel2.ResumeLayout(false);
            GP_MapOptions.ResumeLayout(false);
            GP_MapOptions.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            GP_Zoom_Options.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            GP_Home_Options.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            GP_WP_Tools.ResumeLayout(false);
            GP_WP_Tools.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            GP_Polygon_Tools.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            GP_Layer_Options.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panelMap.ResumeLayout(false);
            panelMap.PerformLayout();
            Panel_Legend.ResumeLayout(false);
            Panel_Legend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IMG_GradDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)IMG_Tiff_Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panelBASE.ResumeLayout(false);
            contextMenuStripPoly.ResumeLayout(false);
            contextMenuStripZoom.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion
        public Panel panelWaypoints;
        public Panel panelAction;
        public Controls.myGMAP MainMap;
        public ContextMenuStrip contextMenuStrip1;
        public MyButton BUT_read;
        public MyButton BUT_write;
        public Panel panel1;
        public Label label3;
        public Label label2;
        public Label Label1;
        public TextBox TXT_homealt;
        public TextBox TXT_homelng;
        public TextBox TXT_homelat;
        public DataGridViewImageColumn dataGridViewImageColumn1;
        public DataGridViewImageColumn dataGridViewImageColumn2;
        public Label label6;
        public Label lbl_status;
        public MyDataGridView Commands;
        public MyButton BUT_Add;
        public Panel panelMap;
        public MyTrackBar trackBar1;
        public Label label11;
        public Label lbl_distance;
        public Label lbl_prevdist;
        public Splitter splitter1;
        public Panel panelBASE;
        public Label lbl_homedist;
        public ToolTip toolTip1;
        public ToolStripMenuItem addPolygonPointToolStripMenuItem;
        public ToolStripMenuItem clearPolygonToolStripMenuItem;
        public ToolStripSeparator toolStripSeparator1;
        public ToolStripMenuItem deleteWPToolStripMenuItem;
        public Timer timer1;
        public ComboBox comboBoxMapType;
        public ToolStripMenuItem savePolygonToolStripMenuItem;
        public ToolStripMenuItem loadPolygonToolStripMenuItem;
        public CheckBox chk_grid;
        public LinkLabel lnk_kml;
        public ToolStripMenuItem pOIToolStripMenuItem;
        public ToolStripMenuItem poiaddToolStripMenuItem;
        public ToolStripMenuItem poideleteToolStripMenuItem;
        public ToolStripMenuItem poieditToolStripMenuItem;
        public ToolStripMenuItem enterUTMCoordToolStripMenuItem;
        public Coords coords1;
        public Panel panel3;
        public Splitter splitter2;
        public ToolStripMenuItem fromSHPToolStripMenuItem;
        public Label lbl_wpfile;
        public ToolStripMenuItem areaToolStripMenuItem;
        public ToolStripMenuItem setHomeHereToolStripMenuItem;
        public MyButton but_writewpfast;
        public ComboBox cmb_missiontype;
        public ContextMenuStrip contextMenuStripPoly;
        public ToolStripMenuItem drawAPolygonToolStripMenuItem;
        public ToolStripMenuItem fenceInclusionToolStripMenuItem;
        public ToolStripMenuItem fenceExclusionToolStripMenuItem;
        public ToolStripMenuItem geoFenceToolStripMenuItem;
        public ToolStripMenuItem GeoFenceuploadToolStripMenuItem;
        public ToolStripMenuItem GeoFencedownloadToolStripMenuItem;
        public ToolStripMenuItem setReturnLocationToolStripMenuItem;
        public ToolStripMenuItem loadFromFileToolStripMenuItem;
        public ToolStripMenuItem saveToFileToolStripMenuItem;
        public ToolStripMenuItem clearToolStripMenuItem;
        public MyButton but_mincommands;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem testToolStripMenuItem;
        private ContextMenuStrip contextMenuStripZoom;
        private ToolStripMenuItem zoomToVehicleToolStripMenuItem;
        private ToolStripMenuItem zoomToMissionToolStripMenuItem;
        private ToolStripMenuItem zoomToHomeToolStripMenuItem;
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
        private GroupBox GP_WP_Tools;
        private GroupBox GP_Home_Options;
        private Button BUT_WP_Mode;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BUT_Clear_Poly;
        private Button BUT_Poly_Mode;
        private Button BUT_Clear_WP;
        private Button BUT_Grid_Mode;
        private Button BUT_saveWPFile;
        private GroupBox GP_Zoom_Options;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BUT_Zoom_Vehicle;
        private Button BUT_Zoom_Mission;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BUT_Set_Home_On_Map;
        private Button BTU_Set_Home_On_Vehicle;
        private GroupBox GP_Polygon_Tools;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BUT_Load_Poly;
        private Button BUT_Save_Poly;
        private Button BUT_loadwpfile;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox GP_Layer_Options;
        private TableLayoutPanel tableLayoutPanel6;
        private Button BUT_Clear_GeoTiff;
        private Button BUT_Load_KML;
        private Button BUT_Clear_KML;
        private Button BUT_Load_GeoTiff;
        private ImageList imageList1;
        public Label LBL_Map_origin;
        public Label label4;
        private Panel panel2;
        private PictureBox IMG_Tiff_Loading;
        private Timer Timer_Update_Button_State;
        private Button BUT_Plot_EchoSounder;
        private Button BUT_Clear_Echosounder;
        public Label LBL_Max_Depth;
        private PictureBox IMG_GradDepth;
        public Label label7;
        private Panel Panel_Legend;
        private GroupBox GP_MapOptions;
    }
}