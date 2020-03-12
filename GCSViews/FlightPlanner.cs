﻿
using BitMiracle.LibTiff.Classic;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MissionPlanner.Controls;
using MissionPlanner.GCSViews.ConfigurationView;
using MissionPlanner.Grid;
using MissionPlanner.Plugin;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace MissionPlanner.GCSViews
{
    public partial class FlightPlanner : MyUserControl, IDeactivate, IActivate
    {

        private readonly FlightPlannerBase _flightPlannerBase;
        public static FlightPlanner instance;

        public FlightPlanner()
        {
            InitializeComponent();
            //MainMap.MouseWheel += MainMap.MouseWheel;
            _flightPlannerBase = new FlightPlannerBase(this);
            modifyMain();
            PaneMenu.Visible = false;
            instance = this;
            tracksroll = (double)trackBar1.Value;

            BtnTiff.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            this.TXT_WPRad.AutoSize = false;
            this.TXT_WPRad.Size = new System.Drawing.Size(366, 25);

            this.TXT_loiterrad.AutoSize = false;
            this.TXT_loiterrad.Size = new System.Drawing.Size(366, 25);

            this.TXT_WPRad.AutoSize = false;
            this.TXT_WPRad.Size = new System.Drawing.Size(366, 25);

        }


        public FlightPlannerBase FlightPlannerBase
        {
            get { return _flightPlannerBase; }
        }

        public object Points { get; private set; }

    

        public void Activate()
        {
            _flightPlannerBase.Activate();
        }

        public void Deactivate()
        {
            _flightPlannerBase.Deactivate();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var ans = _flightPlannerBase.ProcessCmdKey(ref msg, keyData);

            if (ans == false)
                ans = base.ProcessCmdKey(ref msg, keyData);

            return ans;
        }

        private void ButKMLOverlay_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }


        private void setHomeHereToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void cmb_missiontype_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmb_missiontype.Text == "RALLY")
            {
                tableLayoutPanel7.Visible = true;
                BUT_insertWP.Enabled = false;
                Commands.Rows.Clear();
                //_flightPlannerBase.insertrelay = true;
                ButDelwp_Click(sender, e);
                ///al crear waypoint y posterior crear rallypoint, los waypoint se siguen insertando en la continuidad de el ultimo rallypoint sin mostrarse
            }
            else {
                tableLayoutPanel7.Visible = false;
                BUT_insertWP.Enabled = true;
                
            }
            if (bloqWP) {
                BUT_insertWP_Click(sender, e);
            }
        }




        //bloqWP <- variable que activa o desactiva el evento click en el mapa -- FlightPlannerBase
        public bool bloqWP = false;
        int contador_delete = 0;
        public bool Del_relay_home_last = false;
        public void BUT_insertWP_Click(object sender, System.EventArgs e)
        {
            if (bloqWP)
            {
                _flightPlannerBase.polygongridmode = false;
                CustomColor.instance.Normalcolor(BUT_insertWP);
                Commands.Columns["Delete"].Visible = false;
                bloqWP = false;
                ButInsertPol.Enabled = true;
                ButDelwp.Enabled = true;
                BUT_write.Enabled = true;
                myButton7.Enabled = true;
                tableLayoutPanel5.Enabled = true;

                if (_flightPlannerBase.pointers != 0)
                {
                    contador_delete = _flightPlannerBase.AddCommand(MAVLink.MAV_CMD.DO_SET_RELAY, 1, 0, 0, 0, 0, 0, 0);
                    _flightPlannerBase.AddCommand(MAVLink.MAV_CMD.RETURN_TO_LAUNCH, 0, 0, 0, 0, 0, 0, 0);

                    _flightPlannerBase.pointers = 0;
                    Del_relay_home_last = true;

                }
                else {
                    Del_relay_home_last = false;
                }

            }
            else
            {
                tableLayoutPanel5.Enabled = false;

                bloqWP = true;
                ButInsertPol.Enabled = false;
                CustomColor.instance.activecolor(BUT_insertWP);
                Commands.Columns["Delete"].Visible = true;
                if (Del_relay_home_last && bloqRallyPoint)
                {
                    this.Commands.Rows.RemoveAt(contador_delete);
                    this.Commands.Rows.RemoveAt(contador_delete++);

                }
                BUT_write.Enabled = false;
                myButton7.Enabled = false;
            }
        }

        private void addPolygonPointToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }


        private void modifyMain()
        {
            ButClearPol.Enabled = false;
            BtSavePol.Enabled = false;
            contextMenuStripPoly.Visible = false;
            But_SurveyGrid.Visible = false;
            CustomColor.instance.Normalcolor(But_SurveyGrid);
        }

  

        public bool Estado_btn_insert_poly = false;
        public void ButInsertPol_Click(object sender, System.EventArgs e)
        {
            if (Estado_btn_insert_poly)
            {
                CustomColor.instance.Normalcolor(ButInsertPol);
                bloqWP = false;
                Estado_btn_insert_poly = false;
                _flightPlannerBase.addmarkerpoly = false;
                _flightPlannerBase.polygongridmode = false;
                tableLayoutPanel2.Enabled = true;
            }
            else
            {
                But_SurveyGrid.Visible = true;
                ButClearPol.Enabled = true;
                BtSavePol.Enabled = true;
                tableLayoutPanel2.Enabled = false;

                Estado_btn_insert_poly = true;
                CustomColor.instance.activecolor(ButInsertPol);
                _flightPlannerBase.addPolygonPointToolStripMenuItem_Click(sender, e);
            }
        }



        public void ButClearPol_Click(object sender, System.EventArgs e)   
        {

            try
            {
                FlightPlannerBase.instance.clearPolygonToolStripMenuItem_Click(sender, e);
                GridUI.instance.clear_routes_poly();
                ButDelwp_Click(sender, e);
                But_SurveyGrid.Visible = false;
                cont_wps = 0;
            }
            catch { }
       }

        private void BtSavePol_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.savePolygonToolStripMenuItem_Click(sender, e);
        }

        private void ButLoadPol_Click_1(object sender, System.EventArgs e)
        {
            ButClearPol.Enabled = true;
            _flightPlannerBase.loadPolygonToolStripMenuItem_Click(sender, e);
            ButInsertPol_Click(sender, e);
        }

        private void BUT_write_Click(object sender, System.EventArgs e)
        {

        }

        private void CMB_altmode_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void LBL_WPRad_Click(object sender, System.EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, System.EventArgs e)
        {

        }

        private void TXT_WPRad_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void setRallyPointToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }


        //rallypoint
        public bool bloqRallyPoint = false;
        private void myButton1_Click(object sender, System.EventArgs e)
        {
            if (Estado_btn_insert_poly) {

                ButInsertPol_Click(sender, e);
            }
          
            string get_cmb_miss_type = cmb_missiontype.Text;
            if (get_cmb_miss_type == "RALLY")
            {
                bloqWP = true;
                if (bloqRallyPoint)
                {
                    bloqRallyPoint = false;
                    CustomColor.instance.Normalcolor(myButton1);
                    bloqWP = false;
                }
                else
                {
                    bloqRallyPoint = true;
                    CustomColor.instance.activecolor(myButton1);
                }
            }
        }

        private void myButton6_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.getRallyPointsToolStripMenuItem_Click(sender, e);
        }

        private void myButton3_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.saveRallyPointsToolStripMenuItem_Click(sender, e);
        }

        private void myButton5_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.clearRallyPointsToolStripMenuItem_Click(sender, e);
            ButDelwp_Click(sender, e);
        }

        private void myButton4_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.saveToFileToolStripMenuItem1_Click(sender, e);
        }

        private void myButton2_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.loadFromFileToolStripMenuItem1_Click(sender, e);
        }

        private void lblLat_Click(object sender, System.EventArgs e)
        {

        }

        private void ButDelwp_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.clearMissionToolStripMenuItem_Click(sender, e);
            _flightPlannerBase.insertrelay = false;
            ButInsertPol.Enabled = true;
            Del_relay_home_last = false;
            cierra_sinEliminar_poly();


        }

        private void label4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }



        private void button2_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.label4_LinkClicked(sender, e);
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TXT_homelat_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {

        }

        private void BUTCLEARKML_Click(object sender, System.EventArgs e)
        {

        }

        private void label11_Click(object sender, System.EventArgs e)
        {

        }


        private void label7_Click(object sender, System.EventArgs e)
        {

        }

        private void label8_Click(object sender, System.EventArgs e)
        {

        }

        private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void savePolygonToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click_2(object sender, System.EventArgs e)
        {




        }

        private void BUT_read_Click(object sender, System.EventArgs e)
        {

        }

        private void BUT_saveWPFile_Click(object sender, System.EventArgs e)
        {

        }



        private void but_writewpfast_Click(object sender, System.EventArgs e)
        {



        }


        private static void MultiplyScanLineAs16BitSamples(byte[] scanline, ushort[] temp, ushort factor, int row)
        {
            if (scanline.Length % 2 != 0)
            {
                // each two bytes define one sample so there should be even number of bytes
                throw new ArgumentException();
            }

            Buffer.BlockCopy(scanline, 0, temp, 0, scanline.Length);

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] *= factor;
                MessageBox.Show("Row:" + row.ToString() + "Column:" + (i / 2).ToString() + "Value:" + temp[i].ToString());
            }
        }

        public IEnumerable<object> GeetCoordTiff(string ruta)
        {
            using (Tiff tiff = Tiff.Open(ruta, "r"))
            {
                int height = tiff.GetField(TiffTag.IMAGELENGTH)[0].ToInt();
                FieldValue[] modelPixelScaleTag = tiff.GetField((TiffTag)33550);
                FieldValue[] modelTiepointTag = tiff.GetField((TiffTag)33922);

                byte[] modelPixelScale = modelPixelScaleTag[1].GetBytes();
                double pixelSizeX = BitConverter.ToDouble(modelPixelScale, 0);
                double pixelSizeY = BitConverter.ToDouble(modelPixelScale, 8) * -1;

                byte[] modelTransformation = modelTiepointTag[1].GetBytes();
                double originLon = BitConverter.ToDouble(modelTransformation, 24);
                double originLat = BitConverter.ToDouble(modelTransformation, 32);

                double startLat = originLat + (pixelSizeY / 2.0);
                double startLon = originLon + (pixelSizeX / 2.0);

                var scanline = new byte[tiff.ScanlineSize()];

                //TODO: Check if band is stored in 1 byte or 2 bytes
                //If 2, the following code would be required
                //var scanline16Bit = new ushort[tiff.ScanlineSize() / 2];
                //Buffer.BlockCopy(scanline, 0, scanline16Bit, 0, scanline.Length);

                double currentLat = startLat;
                double currentLon = startLon;
                object geodata = null;

                for (int i = 0; i < height; i++)
                {
                    tiff.ReadScanline(scanline, i); //Loading ith Line            

                    var latitude = currentLat + (pixelSizeY * i);
                    for (var j = 0; j < scanline.Length; j++)
                    {
                        var longitude = currentLon + (pixelSizeX * j);
                        geodata = new[] { longitude, latitude };
                        object value = scanline[j];

                        //... process each data item

                        yield return geodata;
                    }
                }
            }
        }


        public bool btnsethome = false;
        private void BUt_sethome_Click(object sender, System.EventArgs e)
        {
            CustomColor.instance.activecolor(BUt_sethome);
            btnsethome = true;
            //if (btnsethome)
            //{
            //    btnsethome = false;
            //    BUt_sethome.BGGradTop = SystemColors.ActiveBorder;
            //}
            //else
            //{

            //    BUt_sethome.BGGradTop = Color.GreenYellow;
            //}


        }

        private void comboBoxMapType_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public double tracksroll { get; set; }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tracksroll = (double)trackBar1.Value;
        }

        public Image CambiarTamano(Image pImagen, int pAncho, int pAlto)
        {
            try
            {
                //creamos un bitmap con el nuevo tamaño
                Bitmap vBitmap = new Bitmap(pAncho, pAlto);
                //creamos un graphics tomando como base el nuevo Bitmap
                using (Graphics vGraphics = Graphics.FromImage((Image)vBitmap))
                {
                    //especificamos el tipo de transformación, se escoge esta para no perder calidad.
                    vGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    //Se dibuja la nueva imagen
                    vGraphics.DrawImage(pImagen, 0, 0, pAncho, pAlto);
                }
                //retornamos la nueva imagen
                return (Image)vBitmap;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.ToString());
                return null;
            }
            return null;
        }


        private void button1_Click_3(object sender, EventArgs e, PaintEventArgs PE)
        {



        }

        private void MainMap_MouseHover(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.

        }


        private void myGMAP1_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(0x00, 0xAA, 0x00, 0xFF);


        }

        private void coords1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Paint(object sender, PaintEventArgs e, EventArgs ea)
        {
            ;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            FlightPlannerBase.instance.loadimgtiff(sender, e);
            BtnDelTiff.Visible = true;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMap.Overlays.Clear();
            try
            {
                System.IO.File.Delete(@"C:\IMGtmp.tiff");
                BtnDelTiff.Visible = false;
                _flightPlannerBase.Kill_Em_all();
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }

        private void FlightPlanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            _flightPlannerBase.Kill_Em_all();
        }

        private void BtnTiff_Click(object sender, EventArgs e)
        {
            CustomColor.instance.activecolor(BtnTiff);
            FlightPlannerBase.instance.loadimgtiff(sender, e);
            BtnDelTiff.Visible = true;
        }

        private void BtnDelTiff_Click(object sender, EventArgs e)
        {
            MainMap.Overlays.Clear();
            try
            {
                System.IO.File.Delete(@"C:\IMGtmp.tiff");
                BtnDelTiff.Visible = false;
                _flightPlannerBase.Kill_Em_all();
                CustomColor.instance.Normalcolor(BtnTiff);
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        public bool distancia = false;
        private void myButton8_Click(object sender, EventArgs e)
        {


            if (distancia)
            {
                CustomColor.instance.Normalcolor(Buttmeasurecontext);
                distancia = false;
            }
            else
            {

                CustomColor.instance.activecolor(Buttmeasurecontext);
                distancia = true;
            }
        }

        private void BtnKMLOverlay_Click(object sender, EventArgs e)
        {
            _flightPlannerBase.kmloverlay();
        }

        private void BtnClearKml_Click(object sender, EventArgs e)
        {
            _flightPlannerBase.kmlpolygonsoverlay.Clear();
            _flightPlannerBase.kmlpolygonsoverlay.Polygons.Clear();
            _flightPlannerBase.kmlpolygonsoverlay.Routes.Clear();
            _flightPlannerBase.kmlpolygonsoverlay.Markers.Clear();

            FlightData.kmlpolygons.Routes.Clear();
            FlightData.kmlpolygons.Polygons.Clear();
            FlightData.kmlpolygons.Markers.Clear();
            FlightData.kmlpolygons.Clear();
            FlightData.rallypointoverlay.Clear();
        }

        private void myButton8_Click_1(object sender, EventArgs e)
        {
            _flightPlannerBase.label4_LinkClicked(sender, e);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BUT_loadwpfile_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {


        }
        public bool estadomenu = false;
        public int cont_wps;

        public void cierra_sinEliminar_poly() {
            estadomenu = false;
            CustomColor.instance.Normalcolor(But_SurveyGrid);  
            PaneMenu.Visible = false;
        }
        public bool statusSurveyGrid = false;
        private void myButton9_Click(object sender, EventArgs e)
        {
            if (cont_wps > 0)
            {
                if (CustomMessageBox.Show("¿Crear nuevos WP?", "Mission created", MessageBoxButtons.YesNo) == (int)DialogResult.Yes)
                {
                    CustomColor.instance.activecolor(ButInsertPol);
                    ButDelwp_Click(sender, e);
                    cierra_sinEliminar_poly();
                    cont_wps = 0;
                    BUT_insertWP.Enabled = false;
                    Estado_btn_insert_poly = false;
                    ButInsertPol_Click(sender, e);
                    GridUI.instance.clear_routes_poly();
                    ButInsertPol_Click(sender, e);
                    statusSurveyGrid = false;
                    ButInsertPol.Enabled = true;
                }
            }
            else
            {

                if (estadomenu)
                {
                    cierra_sinEliminar_poly();
                   GridUI.instance.clear_routes_poly();
                    ButInsertPol_Click(sender, e);
                    statusSurveyGrid = false;
                }
                else
                {
                    CustomColor.instance.activecolor(But_SurveyGrid);
                    FlightPlannerBase.surveyGridToolStripMenuItem_Click(sender, e);
                    bloqWP = false;
                    estadomenu = true;
                    statusSurveyGrid = true;

                }
            }

            
        }

    


        private void panelWaypoints_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Commands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void myButton9_Click_1(object sender, EventArgs e)
        {
  
        }
        private void MainMap_MouseMove(object sender, MouseEventArgs e)
        {
            GridPlugin gridplugin = new GridPlugin();
            gridplugin.mousemove(sender, e);
        }

        private void MainMap_MouseDown(object sender, MouseEventArgs e)
        {
            GridPlugin gridplugin = new GridPlugin();
            gridplugin.mousedown(sender, e);
        
        }

        private void MainMap_Load(object sender, EventArgs e)
        {
        }
    }



}



