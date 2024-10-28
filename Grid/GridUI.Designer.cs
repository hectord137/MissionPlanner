namespace MissionPlanner.Grid
{
    partial class GridUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridUI));
            groupBox5 = new GroupBox();
            lbl_flighttime = new Label();
            label31 = new Label();
            lbl_distbetweenlines = new Label();
            label25 = new Label();
            lbl_strips = new Label();
            label33 = new Label();
            lbl_distance = new Label();
            lbl_area = new Label();
            label23 = new Label();
            label22 = new Label();
            TRK_zoom = new Controls.MyTrackBar();
            map = new Controls.myGMAP();
            groupBox7 = new GroupBox();
            LBL_Lane_Dist = new Label();
            NUM_Lane_Dist = new NumericUpDown();
            label28 = new Label();
            groupBox1 = new GroupBox();
            BUT_Accept = new Controls.MyButton();
            NUM_altitude = new NumericUpDown();
            NUM_UpDownFlySpeed = new NumericUpDown();
            label38 = new Label();
            label1 = new Label();
            label24 = new Label();
            groupBox4 = new GroupBox();
            CHK_footprints = new CheckBox();
            CHK_internals = new CheckBox();
            CHK_grid = new CheckBox();
            CHK_markers = new CheckBox();
            CHK_boundary = new CheckBox();
            CHK_toandland_RTL = new CheckBox();
            groupBox2 = new GroupBox();
            chk_crossgrid = new CheckBox();
            num_corridorwidth = new NumericUpDown();
            chk_spiral = new CheckBox();
            label43 = new Label();
            chk_Corridor = new CheckBox();
            NUM_angle = new NumericUpDown();
            label4 = new Label();
            label32 = new Label();
            NUM_leadin = new NumericUpDown();
            label7 = new Label();
            NUM_overshoot2 = new NumericUpDown();
            label6 = new Label();
            CMB_startfrom = new ComboBox();
            label5 = new Label();
            NUM_overshoot = new NumericUpDown();
            label2 = new Label();
            NUM_Distance = new NumericUpDown();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TRK_zoom).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUM_Lane_Dist).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUM_altitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUM_UpDownFlySpeed).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_corridorwidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUM_angle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUM_leadin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUM_overshoot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUM_overshoot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUM_Distance).BeginInit();
            SuspendLayout();
            // 
            // groupBox5
            // 
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.Controls.Add(lbl_flighttime);
            groupBox5.Controls.Add(label31);
            groupBox5.Controls.Add(lbl_distbetweenlines);
            groupBox5.Controls.Add(label25);
            groupBox5.Controls.Add(lbl_strips);
            groupBox5.Controls.Add(label33);
            groupBox5.Controls.Add(lbl_distance);
            groupBox5.Controls.Add(lbl_area);
            groupBox5.Controls.Add(label23);
            groupBox5.Controls.Add(label22);
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // lbl_flighttime
            // 
            resources.ApplyResources(lbl_flighttime, "lbl_flighttime");
            lbl_flighttime.Name = "lbl_flighttime";
            // 
            // label31
            // 
            resources.ApplyResources(label31, "label31");
            label31.Name = "label31";
            // 
            // lbl_distbetweenlines
            // 
            resources.ApplyResources(lbl_distbetweenlines, "lbl_distbetweenlines");
            lbl_distbetweenlines.Name = "lbl_distbetweenlines";
            // 
            // label25
            // 
            resources.ApplyResources(label25, "label25");
            label25.Name = "label25";
            // 
            // lbl_strips
            // 
            resources.ApplyResources(lbl_strips, "lbl_strips");
            lbl_strips.Name = "lbl_strips";
            // 
            // label33
            // 
            resources.ApplyResources(label33, "label33");
            label33.Name = "label33";
            // 
            // lbl_distance
            // 
            resources.ApplyResources(lbl_distance, "lbl_distance");
            lbl_distance.Name = "lbl_distance";
            // 
            // lbl_area
            // 
            resources.ApplyResources(lbl_area, "lbl_area");
            lbl_area.Name = "lbl_area";
            // 
            // label23
            // 
            resources.ApplyResources(label23, "label23");
            label23.Name = "label23";
            // 
            // label22
            // 
            resources.ApplyResources(label22, "label22");
            label22.Name = "label22";
            // 
            // TRK_zoom
            // 
            resources.ApplyResources(TRK_zoom, "TRK_zoom");
            TRK_zoom.LargeChange = 0.005F;
            TRK_zoom.Maximum = 22F;
            TRK_zoom.Minimum = 2F;
            TRK_zoom.Name = "TRK_zoom";
            TRK_zoom.SmallChange = 0.001F;
            TRK_zoom.TickFrequency = 1F;
            TRK_zoom.TickStyle = TickStyle.TopLeft;
            TRK_zoom.Value = 2F;
            TRK_zoom.Scroll += trackBar1_Scroll;
            // 
            // map
            // 
            resources.ApplyResources(map, "map");
            map.Bearing = 0F;
            map.CanDragMap = true;
            map.EmptyTileColor = Color.Gray;
            map.GrayScaleMode = false;
            map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            map.HoldInvalidation = false;
            map.LevelsKeepInMemmory = 5;
            map.MarkersEnabled = true;
            map.MaxZoom = 19;
            map.MinZoom = 2;
            map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            map.Name = "map";
            map.NegativeMode = false;
            map.PolygonsEnabled = true;
            map.RetryLoadTile = 0;
            map.RoutesEnabled = true;
            map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            map.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            map.ShowTileGridLines = false;
            map.Zoom = 3D;
            map.MouseDown += map_MouseDown;
            map.MouseMove += map_MouseMove;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(LBL_Lane_Dist);
            groupBox7.Controls.Add(NUM_Lane_Dist);
            groupBox7.Controls.Add(label28);
            resources.ApplyResources(groupBox7, "groupBox7");
            groupBox7.Name = "groupBox7";
            groupBox7.TabStop = false;
            // 
            // LBL_Lane_Dist
            // 
            resources.ApplyResources(LBL_Lane_Dist, "LBL_Lane_Dist");
            LBL_Lane_Dist.Name = "LBL_Lane_Dist";
            // 
            // NUM_Lane_Dist
            // 
            resources.ApplyResources(NUM_Lane_Dist, "NUM_Lane_Dist");
            NUM_Lane_Dist.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            NUM_Lane_Dist.Name = "NUM_Lane_Dist";
            NUM_Lane_Dist.ValueChanged += NUM_Lane_Dist_ValueChanged;
            // 
            // label28
            // 
            resources.ApplyResources(label28, "label28");
            label28.Name = "label28";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BUT_Accept);
            groupBox1.Controls.Add(NUM_altitude);
            groupBox1.Controls.Add(NUM_UpDownFlySpeed);
            groupBox1.Controls.Add(label38);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(CHK_toandland_RTL);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Controls.Add(NUM_angle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label32);
            groupBox1.Controls.Add(NUM_leadin);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(NUM_overshoot2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(CMB_startfrom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(NUM_overshoot);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NUM_Distance);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // BUT_Accept
            // 
            BUT_Accept.BGGradBot = Color.FromArgb(148, 193, 31);
            resources.ApplyResources(BUT_Accept, "BUT_Accept");
            BUT_Accept.Name = "BUT_Accept";
            BUT_Accept.Outline = Color.FromArgb(148, 193, 50);
            BUT_Accept.TextColor = Color.Black;
            BUT_Accept.TextColorNotEnabled = Color.Black;
            BUT_Accept.UseVisualStyleBackColor = true;
            BUT_Accept.Click += BUT_Accept_Click;
            // 
            // NUM_altitude
            // 
            resources.ApplyResources(NUM_altitude, "NUM_altitude");
            NUM_altitude.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            NUM_altitude.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            NUM_altitude.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUM_altitude.Name = "NUM_altitude";
            NUM_altitude.Value = new decimal(new int[] { 100, 0, 0, 0 });
            NUM_altitude.ValueChanged += domainUpDown1_ValueChanged;
            // 
            // NUM_UpDownFlySpeed
            // 
            resources.ApplyResources(NUM_UpDownFlySpeed, "NUM_UpDownFlySpeed");
            NUM_UpDownFlySpeed.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            NUM_UpDownFlySpeed.Name = "NUM_UpDownFlySpeed";
            NUM_UpDownFlySpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NUM_UpDownFlySpeed.ValueChanged += domainUpDown1_ValueChanged;
            // 
            // label38
            // 
            resources.ApplyResources(label38, "label38");
            label38.Name = "label38";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label24
            // 
            resources.ApplyResources(label24, "label24");
            label24.Name = "label24";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(CHK_footprints);
            groupBox4.Controls.Add(CHK_internals);
            groupBox4.Controls.Add(CHK_grid);
            groupBox4.Controls.Add(CHK_markers);
            groupBox4.Controls.Add(CHK_boundary);
            resources.ApplyResources(groupBox4, "groupBox4");
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // CHK_footprints
            // 
            resources.ApplyResources(CHK_footprints, "CHK_footprints");
            CHK_footprints.Name = "CHK_footprints";
            CHK_footprints.UseVisualStyleBackColor = true;
            CHK_footprints.CheckedChanged += domainUpDown1_ValueChanged;
            // 
            // CHK_internals
            // 
            resources.ApplyResources(CHK_internals, "CHK_internals");
            CHK_internals.Name = "CHK_internals";
            CHK_internals.UseVisualStyleBackColor = true;
            CHK_internals.CheckedChanged += domainUpDown1_ValueChanged;
            // 
            // CHK_grid
            // 
            resources.ApplyResources(CHK_grid, "CHK_grid");
            CHK_grid.Checked = true;
            CHK_grid.CheckState = CheckState.Checked;
            CHK_grid.Name = "CHK_grid";
            CHK_grid.UseVisualStyleBackColor = true;
            CHK_grid.CheckedChanged += domainUpDown1_ValueChanged;
            // 
            // CHK_markers
            // 
            resources.ApplyResources(CHK_markers, "CHK_markers");
            CHK_markers.Checked = true;
            CHK_markers.CheckState = CheckState.Checked;
            CHK_markers.Name = "CHK_markers";
            CHK_markers.UseVisualStyleBackColor = true;
            CHK_markers.CheckedChanged += domainUpDown1_ValueChanged;
            // 
            // CHK_boundary
            // 
            resources.ApplyResources(CHK_boundary, "CHK_boundary");
            CHK_boundary.Checked = true;
            CHK_boundary.CheckState = CheckState.Checked;
            CHK_boundary.Name = "CHK_boundary";
            CHK_boundary.UseVisualStyleBackColor = true;
            CHK_boundary.CheckedChanged += domainUpDown1_ValueChanged;
            // 
            // CHK_toandland_RTL
            // 
            resources.ApplyResources(CHK_toandland_RTL, "CHK_toandland_RTL");
            CHK_toandland_RTL.Checked = true;
            CHK_toandland_RTL.CheckState = CheckState.Checked;
            CHK_toandland_RTL.Name = "CHK_toandland_RTL";
            CHK_toandland_RTL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chk_crossgrid);
            groupBox2.Controls.Add(num_corridorwidth);
            groupBox2.Controls.Add(chk_spiral);
            groupBox2.Controls.Add(label43);
            groupBox2.Controls.Add(chk_Corridor);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // chk_crossgrid
            // 
            resources.ApplyResources(chk_crossgrid, "chk_crossgrid");
            chk_crossgrid.Name = "chk_crossgrid";
            chk_crossgrid.UseVisualStyleBackColor = true;
            chk_crossgrid.Click += domainUpDown1_ValueChanged;
            // 
            // num_corridorwidth
            // 
            num_corridorwidth.DecimalPlaces = 1;
            resources.ApplyResources(num_corridorwidth, "num_corridorwidth");
            num_corridorwidth.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_corridorwidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_corridorwidth.Name = "num_corridorwidth";
            num_corridorwidth.Value = new decimal(new int[] { 100, 0, 0, 0 });
            num_corridorwidth.ValueChanged += domainUpDown1_ValueChanged;
            // 
            // chk_spiral
            // 
            resources.ApplyResources(chk_spiral, "chk_spiral");
            chk_spiral.Name = "chk_spiral";
            chk_spiral.UseVisualStyleBackColor = true;
            chk_spiral.Click += domainUpDown1_ValueChanged;
            // 
            // label43
            // 
            resources.ApplyResources(label43, "label43");
            label43.Name = "label43";
            // 
            // chk_Corridor
            // 
            resources.ApplyResources(chk_Corridor, "chk_Corridor");
            chk_Corridor.Name = "chk_Corridor";
            chk_Corridor.UseVisualStyleBackColor = true;
            chk_Corridor.Click += domainUpDown1_ValueChanged;
            // 
            // NUM_angle
            // 
            resources.ApplyResources(NUM_angle, "NUM_angle");
            NUM_angle.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            NUM_angle.Name = "NUM_angle";
            NUM_angle.ValueChanged += domainUpDown1_ValueChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label32
            // 
            resources.ApplyResources(label32, "label32");
            label32.Name = "label32";
            // 
            // NUM_leadin
            // 
            resources.ApplyResources(NUM_leadin, "NUM_leadin");
            NUM_leadin.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            NUM_leadin.Name = "NUM_leadin";
            NUM_leadin.ValueChanged += domainUpDown1_ValueChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // NUM_overshoot2
            // 
            resources.ApplyResources(NUM_overshoot2, "NUM_overshoot2");
            NUM_overshoot2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            NUM_overshoot2.Name = "NUM_overshoot2";
            NUM_overshoot2.ValueChanged += domainUpDown1_ValueChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // CMB_startfrom
            // 
            CMB_startfrom.FormattingEnabled = true;
            resources.ApplyResources(CMB_startfrom, "CMB_startfrom");
            CMB_startfrom.Name = "CMB_startfrom";
            CMB_startfrom.SelectedIndexChanged += domainUpDown1_ValueChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // NUM_overshoot
            // 
            resources.ApplyResources(NUM_overshoot, "NUM_overshoot");
            NUM_overshoot.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            NUM_overshoot.Name = "NUM_overshoot";
            NUM_overshoot.ValueChanged += domainUpDown1_ValueChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // NUM_Distance
            // 
            NUM_Distance.DecimalPlaces = 2;
            resources.ApplyResources(NUM_Distance, "NUM_Distance");
            NUM_Distance.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            NUM_Distance.Minimum = new decimal(new int[] { 3, 0, 0, 65536 });
            NUM_Distance.Name = "NUM_Distance";
            NUM_Distance.Value = new decimal(new int[] { 50, 0, 0, 0 });
            NUM_Distance.ValueChanged += domainUpDown1_ValueChanged;
            // 
            // GridUI
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(groupBox1);
            Controls.Add(TRK_zoom);
            Controls.Add(map);
            Controls.Add(groupBox5);
            Name = "GridUI";
            Load += GridUI_Load;
            Resize += GridUI_Resize;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TRK_zoom).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUM_Lane_Dist).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUM_altitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUM_UpDownFlySpeed).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_corridorwidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUM_angle).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUM_leadin).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUM_overshoot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUM_overshoot).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUM_Distance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.myGMAP map;
        private GroupBox groupBox5;
        private Label label22;
        private Label label23;
        private Label lbl_distance;
        private Label lbl_area;
        private Label lbl_distbetweenlines;
        private Label label25;
        private Label lbl_strips;
        private Label label33;
        private Label lbl_flighttime;
        private Label label31;
        private Controls.MyTrackBar TRK_zoom;
        private GroupBox groupBox7;
        private Label LBL_Lane_Dist;
        private NumericUpDown NUM_Lane_Dist;
        private Label label28;
        private GroupBox groupBox1;
        private CheckBox chk_spiral;
        private CheckBox chk_Corridor;
        private Label label43;
        private NumericUpDown num_corridorwidth;
        private CheckBox chk_crossgrid;
        private Label label32;
        private NumericUpDown NUM_leadin;
        private Label label7;
        private NumericUpDown NUM_overshoot2;
        private Label label6;
        private ComboBox CMB_startfrom;
        private Label label5;
        private NumericUpDown NUM_overshoot;
        private Label label2;
        private NumericUpDown NUM_Distance;
        private Label label38;
        private CheckBox CHK_toandland_RTL;
        private Label label24;
        private NumericUpDown NUM_UpDownFlySpeed;
        private Label label4;
        private NumericUpDown NUM_angle;
        private Label label1;
        private GroupBox groupBox4;
        private CheckBox CHK_footprints;
        private CheckBox CHK_internals;
        private CheckBox CHK_grid;
        private CheckBox CHK_markers;
        private CheckBox CHK_boundary;
        private Controls.MyButton BUT_Accept;
        private NumericUpDown NUM_altitude;
        private GroupBox groupBox2;
    }
}