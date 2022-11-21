using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace CodeArtEng.Gauge.Themes
{
    internal class ThemeColorsTypeConverter : TypeConverter
    {

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(ThemeColors));
        }
    }


    [TypeConverter(typeof(ThemeColorsTypeConverter))]
    public class ThemeColors : ICloneable
    {
        /// <summary>
        /// Display for Designer property
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Expand...";
        }

        private Control Parent;
        public ThemeColors(Control parent) : this() { Parent = parent; }

        public ThemeColors()
        {
            PointerBackColor = Color.Silver;
            PointerColor = Color.Green;
            PanelBackColor = Color.Silver;
            PanelBorderColor = Color.Transparent;
            TextForeColor = ScaleLabelColor = MajorTickLineColor = MinorTickLineColor = Color.Black;
            NeedleColor = PeakMarkerColor = Color.Red;
        }

        [Description("Text Color")]
        [DefaultValue(typeof(Color), "Black")]
        public Color TextForeColor { get => _TextForeColor; set => SetValue(ref _TextForeColor, value); }
        internal Color _TextForeColor;

        [Description("Scale Label Color")]
        [DefaultValue(typeof(Color), "Black")]
        public Color ScaleLabelColor { get => _ScaleLabelColor; set => SetValue(ref _ScaleLabelColor, value); }
        internal Color _ScaleLabelColor;

        [Description("Scale Label Color")]
        [DefaultValue(typeof(Color), "Black")]
        public Color MajorTickLineColor { get => _MajorTickLineColor; set => SetValue(ref _MajorTickLineColor, value); }
        internal Color _MajorTickLineColor;

        [Description("Scale Label Color")]
        [DefaultValue(typeof(Color), "Black")]
        public Color MinorTickLineColor { get => _MinorTickLineColor; set => SetValue(ref _MinorTickLineColor, value); }
        internal Color _MinorTickLineColor;

        [Description("Pointer Background Color")]
        [DefaultValue(typeof(Color), "Silver")]
        public Color PointerBackColor { get => _PointerBackColor; set => SetValue(ref _PointerBackColor, value); }
        internal Color _PointerBackColor;

        [Description("Pointer Color")]
        [DefaultValue(typeof(Color), "Green")]
        public Color PointerColor { get => _PointerColor; set => SetValue(ref _PointerColor, value); }
        internal Color _PointerColor;

        [Description("Panel Background Color")]
        [DefaultValue(typeof(Color), "Silver")]
        public Color PanelBackColor { get => _PanelBackColor; set => SetValue(ref _PanelBackColor, value); }
        internal Color _PanelBackColor;

        [Description("Panel Border Color")]
        [DefaultValue(typeof(Color), "Transparent")]
        public Color PanelBorderColor { get => _PanelBorderColor; set => SetValue(ref _PanelBorderColor, value); }
        internal Color _PanelBorderColor;

        [Description("Needle Color")]
        [DefaultValue(typeof(Color), "Red")]
        public Color NeedleColor { get => _NeedleColor; set => SetValue(ref _NeedleColor, value); }
        internal Color _NeedleColor;

        [Description("Peak Marker Color")]
        [DefaultValue(typeof(Color), "Red")]
        public Color PeakMarkerColor { get => _PeakMarkerColor; set => SetValue(ref _PeakMarkerColor, value); }
        internal Color _PeakMarkerColor;

        private void SetValue<T>(ref T property, T value)
        {
            if (property.Equals(value)) return;
            property = value;
            Parent?.Refresh();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
