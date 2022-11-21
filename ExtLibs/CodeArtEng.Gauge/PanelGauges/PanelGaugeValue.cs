using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeArtEng.Gauge.PanelGauges
{
    public enum GaugeLabelContent
    {
        Value,
        Minimim,
        Maximum,
        Unit
    }

    /// <summary>
    /// Value for GaugePanel
    /// </summary>
    public class PanelGaugeValue : PanelGaugeComponentBase
    {
        #region [ Appearance ]

        [Category("Appearance")]
        [Description("Text Position")]
        [DefaultValue(typeof(ContentAlignment), "TopLeft")]
        public ContentAlignment TextAlign
        {
            get => _TextAlign;
#if Freeware
            private
#endif
            set => SetValue(ref _TextAlign, value);
        }
        private ContentAlignment _TextAlign = ContentAlignment.TopLeft;

        [Category("Appearance")]
        [Description("Content to display.")]
        [DefaultValue(typeof(GaugeLabelContent), "Value")]
        public GaugeLabelContent Content
        {
            get => _Content;
            set => SetValue(ref _Content, value);
        }
        private GaugeLabelContent _Content = GaugeLabelContent.Value;

        #endregion

        [DefaultValue(typeof(Font), "Courier New, 15pt, style=Bold")]
        public override Font Font { get => base.Font; set => base.Font = value; }

        public PanelGaugeValue() : base()
        {
            Font = new Font("Courier New", 15, FontStyle.Bold);
            Size = new Size(50, 20);
        }

        internal override void OnPaintComponent(GaugePaintEventArgs e, Point StartPos)
        {
            string contentString;
            switch (Content)
            {
                default:
                case GaugeLabelContent.Value:
                    contentString = DrawValueStr;
                    break;

                case GaugeLabelContent.Minimim:
                    contentString = Minimum.ToString();
                    break;
                case GaugeLabelContent.Maximum:
                    contentString = Maximum.ToString();
                    break;

                case GaugeLabelContent.Unit:
                    contentString = Unit;
                    break;
            }

            SizeF textSize = e.Graphics.MeasureString(contentString, Font);
            Rectangle textRect = new Rectangle(0, 0, (int)textSize.Width, (int)textSize.Height);
            Rectangle CompRegion = new Rectangle(StartPos.X, StartPos.Y, Width, Height);

            DrawingEx.AlignRectangle(CompRegion, ref textRect, TextAlign);
            TextRenderer.DrawText(e.Graphics, contentString, Font, textRect.Location, e.TextColor);
        }
    }
}
