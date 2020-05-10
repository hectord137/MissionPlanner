using System.Windows.Forms;
namespace MissionPlanner.Controls
{

    public class VerticalProgressBar2 : HorizontalProgressBar2
    {
        [System.ComponentModel.Description("Draw the bar from Up to Down")]
        public bool Inverted { set; get; }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(!Inverted)
            {
                e.Graphics.TranslateTransform(0, e.Graphics.ClipBounds.Height);
                e.Graphics.RotateTransform(270);
            }
            else
            {
                e.Graphics.TranslateTransform(e.Graphics.ClipBounds.Width, 0);
                e.Graphics.RotateTransform(90);
            }

            e.Graphics.ScaleTransform((float)this.Height / (float)this.Width, (float)this.Width / (float)this.Height);
            
            base.OnPaint(e);
        }
    }
}
