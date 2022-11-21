using CodeArtEng.Gauge.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeArtEng.Gauge
{
#if !Freeware
    internal class CircularGaugeScaleLabelTypeConverter : TypeConverter
    {

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(CircularGaugeScaleLabel));
        }
    }

    [TypeConverter(typeof(CircularGaugeScaleLabelTypeConverter))]
    public class CircularGaugeScaleLabel
    {
        private CircularGauge Parent;
        public CircularGaugeScaleLabel(CircularGauge parent)
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

        [Description("Set to TRUE to rotate label relative to the arc.")]
        [DefaultValue(false)]
        public bool AutoRotate
        {
            get => _AutoRotate;
            set => SetValue(ref _AutoRotate, value);
        }
        private bool _AutoRotate = false;

        [Description("Label Font")]
        [DefaultValue(typeof(Font), "Microsoft Sans Serif, 10pt")]
        public Font Font { get; set; } = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

        [Description("Offset from label outer radius.")]
        [DefaultValue(20)]
        public int Padding
        {
            get => _Padding;
            set => SetValue(ref _Padding, value);
        }
        private int _Padding = 20;

        [Description("Delta between 2 label.")]
        [DefaultValue(10)]
        public double Interval
        {
            get => _Interval;
            set => SetValue(ref _Interval, Math.Max(1, value));
        }
        private double _Interval = 10;

        [Description("Label string format")]
        [DefaultValue("")]
        public string Format
        {
            get => _Format;
            set => SetValue(ref _Format, value);
        }
        private string _Format = String.Empty;

        internal string ValueToStringFormat(double value)
        {
            if (string.IsNullOrEmpty(_Format)) return value.ToString();
            try { return value.ToString(_Format); }
            catch { return value.ToString(); }
        }

    }
#endif
}
