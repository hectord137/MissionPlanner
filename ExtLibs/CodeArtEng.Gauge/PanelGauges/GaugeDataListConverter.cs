using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace CodeArtEng.Gauge.PanelGauges
{
    /// <summary>
    /// Type Converter for GaugeData property selection on design time
    /// </summary>
    public class GaugeDataListConverter : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(GetParentDatas(context));
        }

        public GaugeData[] GetParentDatas(ITypeDescriptorContext context)
        {
            GaugeBase gauge = context.Instance as GaugeBase;
            if (gauge == null) return null;

            GaugePanel panel = gauge.Parent as GaugePanel;
            if (panel == null) return null;

            return panel.GaugeDatas.ToArray();
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType == typeof(string) || sourceType == typeof(GaugeData));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string stringValue = value as string;
            if (string.IsNullOrEmpty(stringValue)) return null;

            GaugeData[] datas = GetParentDatas(context);
            GaugeData selectedData = datas.FirstOrDefault(x => x.Name == stringValue);

            return selectedData;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return base.CanConvertTo(context, destinationType);
        }
    }
}
