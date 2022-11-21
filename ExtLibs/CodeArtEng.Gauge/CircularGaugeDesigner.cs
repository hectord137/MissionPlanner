using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.AxHost;

namespace CodeArtEng.Gauge
{
#if !Freeware
    internal class CircularGaugeDesigner : ControlDesigner
    {
        private DesignerActionListCollection actionList;

        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (actionList == null)
                {
                    actionList = new DesignerActionListCollection();
                    actionList.Add(new CircularGaugeDesignerActionList(this.Component));
                }
                return actionList;
            }
        }
    }

    public class CircularGaugeDesignerActionList : DesignerActionList
    {
        private CircularGauge Parent;
        private DesignerActionUIService DesignerService;
        public CircularGaugeDesignerActionList(IComponent component) : base(component)
        {
            Parent = component as CircularGauge;
            DesignerService = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionHeaderItem("Gauge Layout"));
            items.Add(new DesignerActionPropertyItem("NeedleVisible", "Needle", "Gauge Layout"));
            items.Add(new DesignerActionPropertyItem("ScaleVisible", "Scale", "Gauge Layout"));
            items.Add(new DesignerActionPropertyItem("MajorTicksVisible", "Major Ticks", "Gauge Layout"));
            items.Add(new DesignerActionPropertyItem("MinorTicksVisible", "Minor Ticks", "Gauge Layout"));
            items.Add(new DesignerActionPropertyItem("PeakMarkerVisible", "Peak", "Gauge Layout"));

            items.Add(new DesignerActionHeaderItem("Gauge Appearance"));
            items.Add(new DesignerActionPropertyItem("Theme", "Theme", "Gauge Appearance"));

            items.Add(new DesignerActionHeaderItem("Design"));
            items.Add(new DesignerActionMethodItem(this, "AutoScale", "Auto Scale", "Design"));
            return items;
        }

        public bool NeedleVisible { get => Parent.NeedleVisible; set => Parent.NeedleVisible = value; }
        public bool ScaleVisible { get => Parent.ScaleLabel.Visible; set => Parent.ScaleLabel.Visible = value; }
        public bool MajorTicksVisible { get => Parent.MajorTicks.Visible; set => Parent.MajorTicks.Visible = value; }
        public bool MinorTicksVisible { get => Parent.MinorTicks.Visible; set => Parent.MinorTicks.Visible = value; }
        public bool PeakMarkerVisible { get => Parent.PeakVisible; set => Parent.PeakVisible = value; }
        public GaugeTheme Theme { get => Parent.Theme; set => Parent.Theme = value; }

        public void AutoScale()
        {
            double deltaAngle = Math.Abs(Parent.PointerStartAngle - Parent.PointerEndAngle);
            double deltaValue = Parent.Maximum - Parent.Minimum;

            int estLabelCount = (int)Math.Floor(deltaAngle / 45);
            double estInterval = Math.Ceiling(deltaValue / estLabelCount);
            double bestInterval = EstimateBestLabelFormat(estInterval);

            Parent.ScaleLabel.Interval = bestInterval;
            Parent.MajorTicks.Interval = bestInterval;
            Parent.MinorTicks.Interval = bestInterval / 4;

            ScaleVisible = true;
            MajorTicksVisible = true;
            MinorTicksVisible = true;

        }

        private double EstimateBestLabelFormat(double interval)
        {
            //Reference from MSChartExtension AdjustAxisIntervalOffset
            double value = interval;
            double[] unit_base = new double[] { 1.0, 2.0, 2.5, 5.0 };
            double unit = 1;

            //find best expression label format, we restrict all label unit
            // be one of unit_base[] value  * 10^n n is integer
            double scale = (int)Math.Log10(value);
            value = value / Math.Pow(10.0, scale);
            if (value < 0.5)
            {
                scale -= 1;
                value *= 10.0;
            }
            else if (value > 5.0)
            {
                scale += 1;
                value *= 0.1;
            }
            for (int i = 0; i < unit_base.Length; ++i)
            {
                if (unit_base[i] >= value)
                {
                    unit = unit_base[i] * Math.Pow(10.0, scale);
                    break;
                }
            }
            return unit;
        }
    }
#endif
}
