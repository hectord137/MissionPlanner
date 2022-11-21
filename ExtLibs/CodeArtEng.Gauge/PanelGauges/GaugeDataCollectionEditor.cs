using System;
using System.ComponentModel.Design;

namespace CodeArtEng.Gauge.PanelGauges
{
    /// <summary>
    /// Design time. Collection editor for <see cref="GaugePanel.GaugeDatas"/>
    /// </summary>
    internal class GaugeDataCollectionEditor : CollectionEditor
    {
        public GaugeDataCollectionEditor(Type type) : base(type) { }

        protected override Type CreateCollectionItemType()
        {
            return typeof(GaugeData);
        }

    }
}
