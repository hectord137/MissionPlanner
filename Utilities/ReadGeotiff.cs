using BitMiracle.LibTiff.Classic;
using GMap.NET;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;


namespace MissionPlanner.Utilities
{
    class ReadGeotiff
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        //public double CenterLatitude { get; private set; }
        //public double CenterLongitude { get; private set; }
        public double Width_px { get; private set; }
        public double Height_px { get; private set; }
        public double Width_m { get; private set; }
        public double Height_m { get; private set; }
        public double PixelSizeXdeg { get; private set; }
        public double PixelSizeYdeg { get; private set; }


        private string FileName;

        private int bits;
        private double i;
        private double j;
        private double k;
        private double x;
        private double y;
        private double z;
        private double xscale;
        private double yscale;
        private double zscale;

        public void LoadImageTiff(string filename)
        {
            try
            {

                FileName = filename;

                using (Tiff tiff = Tiff.Open(filename, "r"))
                {
                    Width_px = tiff.GetField(TiffTag.IMAGEWIDTH)[0].ToDouble();              
                    Height_px = tiff.GetField(TiffTag.IMAGELENGTH)[0].ToDouble();
                    bits = tiff.GetField(TiffTag.BITSPERSAMPLE)[0].ToInt();

                    var modelscale = tiff.GetField(TiffTag.GEOTIFF_MODELPIXELSCALETAG);
                    var tiepoint = tiff.GetField(TiffTag.GEOTIFF_MODELTIEPOINTTAG);

                    i = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0);
                    j = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 8);
                    k = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 16);
                    x = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 24);
                    y = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 32);
                    z = BitConverter.ToDouble(tiepoint[1].ToByteArray(), 0 + 40);

                    xscale = BitConverter.ToDouble(modelscale[1].ToByteArray(), 0);
                    yscale = BitConverter.ToDouble(modelscale[1].ToByteArray(), 0 + 8);
                    zscale = BitConverter.ToDouble(modelscale[1].ToByteArray(), 0 + 16);

                    Longitude = x;
                    Latitude = y;

                    PixelSizeXdeg = xscale;
                    PixelSizeYdeg = yscale;

                    //CenterLatitude = Latitude - ((PixelSizeYdeg * Height_px) / 2);
                    //CenterLongitude = Longitude + ((PixelSizeXdeg * Width_px) / 2);

                    PointLatLngAlt p = new PointLatLngAlt(Latitude, Longitude);
                    Width_m = p.GetDistance(new PointLatLngAlt(Latitude, Longitude + (PixelSizeXdeg * Width_px)));
                    Height_m = p.GetDistance(new PointLatLngAlt(Latitude - (PixelSizeYdeg * Height_px), Longitude));


                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Geotiff Error", "Upload Fail" + ex);

            }


        }

       

    }
}
