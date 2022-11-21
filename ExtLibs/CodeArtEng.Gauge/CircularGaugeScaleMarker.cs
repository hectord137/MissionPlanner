using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArtEng.Gauge
{
    internal class CircularGaugeScaleMarkerTypeConverter : TypeConverter
    {

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(CircularGaugeScaleMarker));
        }
    }

    [TypeConverter(typeof(CircularGaugeScaleMarkerTypeConverter))]
    public class CircularGaugeScaleMarker
    {
        private CircularGauge Parent;
        public CircularGaugeScaleMarker(CircularGauge parent)
        {
            Parent = parent;
        }

        private void SetValue<T>(ref T property, T value)
        {
            Parent?.SetValue<T>(ref property, value);
        }

        /// <summary>
        /// Display for Designer property
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Expand...";
        }

        [Description("Show / hide scale label")]
        [DefaultValue(false)]
        public bool Visible
        {
            get => _Visible;
            set => SetValue(ref _Visible, value);
        }
        private bool _Visible = false;

        [Description("Offset from label outer radius.")]
        [DefaultValue(0)]
        public int Padding
        {
            get => _Padding;
            set => SetValue(ref _Padding, value);
        }
        private int _Padding = 0;

        [Description("Width of marker line.")]
        [DefaultValue(2)]
        public int MarkerWidth
        {
            get => _MarkerWidth;
            set => SetValue(ref _MarkerWidth, value);
        }
        private int _MarkerWidth = 1;

        [Description("Length of marker.")]
        public int MarkerLength
        {
            get => _MarkerLength;
            set => SetValue(ref _MarkerLength, value);
        } 
        private int _MarkerLength = 5;

        [Description("Delta between 2 marker.")]
        [DefaultValue(0)]
        public double Interval
        {
            get => _Interval;
            set => SetValue(ref _Interval, Math.Max(0, value));
        }
        private double _Interval = 0;

    }
}
