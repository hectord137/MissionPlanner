using BitMiracle.LibTiff.Classic;
using GMap.NET;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using static MissionPlanner.Utilities.GeoTiff;


namespace MissionPlanner.Utilities
{
    class ReadGeotiff
    {
        public double latitud { get; set; }
        public double longitud { get; set; }
        public double scalex { get; set; }
        public double scaley { get; set; }


        private string FileName;
        private int width;
        private int height;
        private int bits;
        private RectLatLng Area;
        private double i;
        private double j;
        private double k;
        private double x;
        private double y;
        private double z;
        private double xscale;
        private double yscale;
        private double zscale;
        private bool cacheable { get { return new FileInfo(FileName).Length < 1024 * 1024 * 1000; } }


        private static readonly ILog log =
    LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static Dictionary<string, float[,]> cache = new Dictionary<string, float[,]>();

        public static List<geotiffdata> index = new List<geotiffdata>();




        public void getlonlatutm(string filename)
        {
            try
            {

                FileName = filename;

                log.InfoFormat("GeoTiff {0}", filename);

                using (Tiff tiff = Tiff.Open(filename, "r"))
                {
                    width = tiff.GetField(TiffTag.IMAGEWIDTH)[0].ToInt();
                    int middleW = width / 2;
                    height = tiff.GetField(TiffTag.IMAGELENGTH)[0].ToInt();
                    int middleH = height / 2;
                    bits = tiff.GetField(TiffTag.BITSPERSAMPLE)[0].ToInt();


           // tiff.CurrentRow();
                    var modelscale = tiff.GetField(TiffTag.GEOTIFF_MODELPIXELSCALETAG);
                    var tiepoint = tiff.GetField(TiffTag.GEOTIFF_MODELTIEPOINTTAG);

                    i = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0);
                    j = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 8);
                    k = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 16);
                    x = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 24);
                    y = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 32);
                    z = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 40);

                 



                    log.InfoFormat("Tie Point ({0},{1},{2}) --> ({3},{4},{5})", i, j, k, x, y, z);

                    xscale = BitConverter.ToDouble(modelscale[1].ToByteArray(), 0);
                    yscale = BitConverter.ToDouble(modelscale[1].ToByteArray(), 0 + 8);
                    zscale = BitConverter.ToDouble(modelscale[1].ToByteArray(), 0 + 16);

                    log.InfoFormat("Scale ({0},{1},{2})", xscale, yscale, zscale);

                    Area = new RectLatLng(y, x, width * xscale, height * yscale);

          

                    //

                    scalex = width * xscale;
                    scaley = height * yscale;

                   
                  
                    double latmiddle = x + scalex / 2; 
                    double lngmiddle = y - scaley / 2;

                    var utm_to_latlng = PointLatLngAlt.FromUTM(19, latmiddle, lngmiddle);
                    latitud = utm_to_latlng.Lat;
                    longitud = utm_to_latlng.Lng;

                    log.InfoFormat("Coverage {0}", Area.ToString());

                    log.InfoFormat("CacheAble {0}", cacheable.ToString());

                    // starts from top left so x + y -
                    scalex += xscale / 2.0;
                    scaley -= yscale / 2.0;


                
                    

                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Geotiff Error", "Upload Fail" + ex);

            }


        }

       

    }
}
