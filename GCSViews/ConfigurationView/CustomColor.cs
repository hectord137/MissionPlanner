using MissionPlanner.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    class CustomColor
    {
        public static CustomColor instance;

        public CustomColor() {

            instance = this;
        }
        

        public void activecolor(MyButton butname)
        {
            if (butname != null)
            {
                butname.BGGradBot = Color.FromArgb(207, 185, 23);
                butname.BGGradTop = Color.FromArgb(207, 185, 23);
                butname.Outline = Color.FromArgb(207, 150, 18);
            }
        }


        public void Normalcolor(MyButton btn)
        {
            if (btn != null)
            {
                btn.BGGradBot = Color.FromArgb(148, 193, 31);
                btn.BGGradTop = Color.FromArgb(148, 193, 31);
                btn.Outline = Color.FromArgb(148, 170, 50);
            }
        }
    }
}
