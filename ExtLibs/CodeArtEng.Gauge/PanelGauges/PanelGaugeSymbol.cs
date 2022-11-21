using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeArtEng.Gauge.ImageProcessing;

namespace CodeArtEng.Gauge.PanelGauges
{
    public class PanelGaugeSymbol : PanelGaugeComponentBase
    {
        /// <summary>
        /// Grayscale image, Black (Object) on White (Background)
        /// </summary>
        private GrayScaleImage ImageBuffer;

        private Image _Image = null;
        /// <summary>
        /// Gauge image symbol. Expecting black symbol on white background.
        /// </summary>
        [Category("Gauge Data")]
        [Description("Gauge image symbol.Expecting black symbol on white background.")]
        public Image Image
        {
            get => _Image;
            set
            {
                _Image = value;
                if (_Image == null) return;

                ImageBuffer = new ColorImage(_Image).ToGrayScaleImage().Threshold(128);
            }
        }

        /// <summary>
        /// Define state where symbol should light up using color defined by theme.
        /// If user defined theme is selected, symbol painted using <see cref="GaugeBase.PointerColor"/>
        /// </summary>
        [Category("Gauge Data")]
        [Description("Define state where symbol should light up using color defined by theme. " +
            " If user defined theme is selected, symbol painted using PointerColor.")]
        public GaugeValueState ActiveOn { get; set; } = GaugeValueState.Error;

        public PanelGaugeSymbol() : base()
        {
            Size = new Size(25, 25);
        }

        internal override void OnPaintComponent(GaugePaintEventArgs e, Point StartPos)
        {
            Rectangle drawRectangle = new Rectangle(StartPos, Size);

            if (Image == null)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 128, 0)), drawRectangle);
                return;
            }

            //Draw image at center of control
            Point origin = new Point(StartPos.X + (Width - ImageBuffer.Width) / 2, 
                                    StartPos.Y + (Height - ImageBuffer.Height) / 2);

            ColorImage paintBuffer = ImageBuffer.ToColorimage();
            Color backColor = BackColor;
            Color symbolColor = Color.Gray; //Symbol OFF color

            //Decide if symbol should on
            if (ActiveOn.HasFlag(DrawValueState()) && Enabled)
                symbolColor = e.PointerColor;

            //Recolor Gauge
            for (int h = 0; h < ImageBuffer.Height; h++)
            {
                for (int w = 0; w < ImageBuffer.Width; w++)
                {
                    if (paintBuffer.Pixels[h, w].R == 255)
                        paintBuffer.Pixels[h, w].Assign(backColor);
                    else
                        paintBuffer.Pixels[h, w].Assign(symbolColor);
                }
            }

            //Paint Symbol
            e.Graphics.DrawImage(paintBuffer.ToImage(), origin);
        }
    }
}
