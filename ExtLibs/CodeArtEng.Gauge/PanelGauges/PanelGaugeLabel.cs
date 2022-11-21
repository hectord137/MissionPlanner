using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace CodeArtEng.Gauge.PanelGauges
{
    /// <summary>
    /// Text Label for GaugePanel
    /// </summary>
    public class PanelGaugeLabel : PanelGaugeComponentBase
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

        #endregion

        public PanelGaugeLabel() : base()
        {
            Size = new Size(110, 20);
        }

        /// <summary>
        /// Label Text
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                Refresh();
            }
        }

        internal override void OnPaintComponent(GaugePaintEventArgs e, Point StartPos)
        {
            SizeF textSize = e.Graphics.MeasureString(Text, Font);
            Rectangle textRect = new Rectangle(0, 0, (int)textSize.Width, (int)textSize.Height);
            Rectangle CompRegion = new Rectangle(StartPos.X + Padding.Left, StartPos.Y + Padding.Top, 
                Width - Padding.Left - Padding.Right, 
                Height - Padding.Top - Padding.Bottom);

            DrawingEx.AlignRectangle(CompRegion, ref textRect, TextAlign);
            TextRenderer.DrawText(e.Graphics, Text, Font, textRect.Location, e.TextColor);
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Refresh();
        }
    }
}
