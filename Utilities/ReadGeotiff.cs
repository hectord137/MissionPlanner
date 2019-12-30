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
                    height = tiff.GetField(TiffTag.IMAGELENGTH)[0].ToInt();
                    bits = tiff.GetField(TiffTag.BITSPERSAMPLE)[0].ToInt();

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

                    log.InfoFormat("Coverage {0}", Area.ToString());

                    log.InfoFormat("CacheAble {0}", cacheable.ToString());

                    // starts from top left so x + y -
                    x += xscale / 2.0;
                    y -= yscale / 2.0;


                    convertUtmToLatLng(x, y, 19, "S");


                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Geotiff Error", "Upload Fail" + ex);

            }


        }

        // Same as EUREF89 
        double eccSquared = 0.00669438;
        double a = 6378137;

        public void convertUtmToLatLng(double UTMEasting, double UTMNorthing, int UTMZoneNumber, String UTMZoneLetter)
        {


            var e1 = (1 - Math.Sqrt(1 - this.eccSquared)) / (1 + Math.Sqrt(1 - this.eccSquared));
            var x = UTMEasting - 500000.0; //remove 500,000 meter offset for longitude
            var y = UTMNorthing;
            var ZoneNumber = UTMZoneNumber;
            var ZoneLetter = UTMZoneLetter;
            int NorthernHemisphere;

            if ("N" == ZoneLetter)
            {
                NorthernHemisphere = 1;
            }
            else
            {
                NorthernHemisphere = 0;
                y -= 10000000.0;
            }

            var LongOrigin = (ZoneNumber - 1) * 6 - 180 + 3;

            var eccPrimeSquared = (this.eccSquared) / (1 - this.eccSquared);

            double M = y / 0.9996;
            var mu = M / (this.a * (1 - this.eccSquared / 4 - 3 * this.eccSquared * this.eccSquared / 64 - 5 * this.eccSquared * this.eccSquared * this.eccSquared / 256));

            var phi1Rad = mu + (3 * e1 / 2 - 27 * e1 * e1 * e1 / 32) * Math.Sin(2 * mu)
                    + (21 * e1 * e1 / 16 - 55 * e1 * e1 * e1 * e1 / 32) * Math.Sin(4 * mu)
                    + (151 * e1 * e1 * e1 / 96) * Math.Sin(6 * mu);
            var phi1 = this.toDegrees(phi1Rad);

            var N1 = this.a / Math.Sqrt(1 - this.eccSquared * Math.Sin(phi1Rad) * Math.Sin(phi1Rad));
            var T1 = Math.Tan(phi1Rad) * Math.Tan(phi1Rad);
            var C1 = eccPrimeSquared * Math.Cos(phi1Rad) * Math.Cos(phi1Rad);
            var R1 = this.a * (1 - this.eccSquared) / Math.Pow(1 - this.eccSquared * Math.Sin(phi1Rad) * Math.Sin(phi1Rad), 1.5);
            var D = x / (N1 * 0.9996);

            var Lat = phi1Rad - (N1 * Math.Tan(phi1Rad) / R1) * (D * D / 2 - (5 + 3 * T1 + 10 * C1 - 4 * C1 * C1 - 9 * eccPrimeSquared) * D * D * D * D / 24
                    + (61 + 90 * T1 + 298 * C1 + 45 * T1 * T1 - 252 * eccPrimeSquared - 3 * C1 * C1) * D * D * D * D * D * D / 720);
            Lat = this.toDegrees(Lat);

            var Long = (D - (1 + 2 * T1 + C1) * D * D * D / 6 + (5 - 2 * C1 + 28 * T1 - 3 * C1 * C1 + 8 * eccPrimeSquared + 24 * T1 * T1)
                    * D * D * D * D * D / 120) / Math.Cos(phi1Rad);
            Long = LongOrigin + this.toDegrees(Long);

            latitud = Lat;
            longitud = Long;
        }

        private double toDegrees(double rad)
        {
            return rad / Math.PI * 180;
        }


    }
}
