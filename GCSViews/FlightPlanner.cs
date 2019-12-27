
using BitMiracle.LibTiff.Classic;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MissionPlanner.Controls;
using MissionPlanner.Grid;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
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

            _flightPlannerBase = new FlightPlannerBase(this);
            modifyMain();
            PaneMenu.Visible = false;
            instance = this;
        }

        public FlightPlannerBase FlightPlannerBase
        {
            get { return _flightPlannerBase; }
        }

        public object Points { get; private set; }

        private GridPlugin plugin;

        public void test(object sender, System.EventArgs e)
        {
            GridUI grid = new GridUI(plugin);
            grid.domainUpDown1_ValueChanged(sender, e);
        }

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
            _flightPlannerBase.kmloverlay();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
        public bool distancia = false;
        public void ButMeasureContext_Click(object sender, System.EventArgs e)
        {
            //_flightPlannerBase.measurecontext();

            if (distancia)
            {
                ButMeasureContext.BackColor = Color.White;
                distancia = false;
            }
            else
            {
                ButMeasureContext.BackColor = Color.GreenYellow;
                distancia = true;
            }

        }

        private void setHomeHereToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void cmb_missiontype_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }





        public bool bloqWP = false;
        public void BUT_insertWP_Click(object sender, System.EventArgs e)
        {
            if (bloqWP)
            {
                bloqWP = false;
                ButInsertPol.Enabled = true;
                BUT_insertWP.BGGradBot = SystemColors.ActiveBorder;
                ButDelwp.Enabled = true;
            }
            else
            {
                bloqWP = true;
                ButInsertPol.Enabled = false;
                BUT_insertWP.BGGradBot = Color.GreenYellow;
                ButDelwp.Enabled = false;
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
            ButClearPol.Enabled = true;
            But_SurveyGrid.Visible = false;
        }


        public bool setPol = false;
        private void ButInsertPol_Click(object sender, System.EventArgs e)
        {
            if (setPol)
            {
                ButClearPol.Enabled = true;
                BUT_insertWP.Enabled = true;
                BtSavePol.Enabled = false;
                bloqWP = false;
                _flightPlannerBase.addPolygonPointToolStripMenuItem_Click(null, null);
                setPol = false;
                _flightPlannerBase.polygongridmode = false;
                ButInsertPol.BGGradBot = SystemColors.ActiveBorder;
                But_SurveyGrid.Visible = false;
            }
            else
            {
                ButClearPol.Enabled = false;
                BUT_insertWP.Enabled = false;
                bloqWP = true;
                BtSavePol.Enabled = true;
                setPol = true;
                ButInsertPol.BGGradBot = Color.GreenYellow;
                _flightPlannerBase.addPolygonPointToolStripMenuItem_Click(sender, e);
                But_SurveyGrid.Visible = true;

            }

        }



        private void ButClearPol_Click(object sender, System.EventArgs e)
        {
            DialogResult boton = MessageBox.Show("Clear Polygon?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                //ButInsertPol_Click(sender, e);
                FlightPlannerBase.drawnpolygonsoverlay.Markers.Clear();
                ButClearPol.Enabled = false;
                bloqWP = false;
                BtSavePol.Enabled = false;
                BUT_insertWP.Enabled = true;
                _flightPlannerBase.drawnpolygon.Points.Clear();
                //// remove full loop is exists
                _flightPlannerBase.polygongridmode = false;
                if (_flightPlannerBase.drawnpolygon.Points.Count > 1 &&
                _flightPlannerBase.drawnpolygon.Points[0] == _flightPlannerBase.drawnpolygon.Points[_flightPlannerBase.drawnpolygon.Points.Count - 1])
                    _flightPlannerBase.drawnpolygon.Points.RemoveAt(_flightPlannerBase.drawnpolygon.Points.Count - 1); // unmake a full loop
            }
            else { }

        }

        private void BtSavePol_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.savePolygonToolStripMenuItem_Click(sender, e);
        }

        private void ButLoadPol_Click_1(object sender, System.EventArgs e)
        {
            ButClearPol.Enabled = true;
            _flightPlannerBase.loadPolygonToolStripMenuItem_Click(sender, e);
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

            if (bloqRallyPoint)
            {
                bloqRallyPoint = false;
                myButton1.BGGradBot = SystemColors.ActiveBorder;
            }
            else
            {
                bloqRallyPoint = true;
                myButton1.BGGradBot = Color.GreenYellow;
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
            ButInsertPol.Enabled = true;

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
        public bool estadomenu = false;
        public bool menu = false;
        private void button1_Click_2(object sender, System.EventArgs e)
        {
            if (estadomenu == true)
            {
                //clear point
                estadomenu = false;
                Grid.GridUI.instance.myButton1_Click(sender, e);
            }
            else
            {
                estadomenu = true;
                FlightPlannerBase.surveyGridToolStripMenuItem_Click(sender, e);

            }




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
        public double tracksroll {get; set;}
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tracksroll = (double)trackBar1.Size.Width;

            CustomMessageBox.Show(tracksroll.ToString()+ " map ");
           
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ReadGeotiff geotiff = new ReadGeotiff();
                geotiff.getlonlatutm(dialog.FileName);
                double Latitud = geotiff.latitud;
                double Longitud = geotiff.longitud;

                Image imagen = Image.FromFile(dialog.FileName);
                Image la_imagen = CambiarTamanoImagen(imagen, (Convert.ToInt32(panelMap.Size.Width.ToString())) - Convert.ToInt32(geotiff.scalex), (Convert.ToInt32(panelMap.Size.Width.ToString())) - Convert.ToInt32(geotiff.scaley));



                GMapOverlay markers = new GMapOverlay("markers");
                GMarkerGoogle imgtiff = new GMarkerGoogle(
                    new PointLatLng(Latitud, Longitud),
                    new Bitmap(la_imagen)
                    );



                MainMap.Overlays.Add(markers);
                markers.Markers.Add(imgtiff);

                MainMap.PerformLayout();


            }

        }

        private void MainMap_MouseHover(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
           
        }

        public Image CambiarTamanoImagen(Image pImagen, int pAncho, int pAlto)
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
            catch (Exception ex) {
                CustomMessageBox.Show(ex.ToString());
                return null;
            }
            return null;
        }

        private void myGMAP1_Load(object sender, EventArgs e)
        {
            
            this.BackColor = Color.FromArgb(0x00, 0xAA, 0x00, 0xFF);
     

        }

        private void coords1_Load(object sender, EventArgs e)
        {

        }
    }

    

    }



