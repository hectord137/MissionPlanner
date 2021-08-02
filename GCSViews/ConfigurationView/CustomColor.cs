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
        public static void SetActiveMode(MyButton btn)
        {
            if (btn != null)
            {
                btn.BGGradBot = Color.FromArgb(207, 185, 23);
                btn.BGGradTop = Color.FromArgb(207, 185, 23);
                btn.Outline = Color.FromArgb(207, 150, 18);
            }
        }

        public static void SetDisarmColor(MyButton btn)
        {
            if (btn != null)
            {
                btn.BGGradBot = Color.FromArgb(255, 128, 128);
                btn.BGGradTop = Color.FromArgb(255, 192, 192);
                btn.Outline = Color.FromArgb(0, 0, 0);
            }
        }

        public static void RestoreColor(MyButton btn)
        {
            if (btn != null)
            {
                btn.BGGradBot = Color.FromArgb(148, 193, 31);
                btn.BGGradTop = Color.FromArgb(148, 193, 31);
                btn.Outline = Color.FromArgb(148, 170, 50);
            }
        }

        public static void SetRecordColor(MyButton btn)
        {
            if (btn != null)
            {
                btn.BGGradBot = Color.FromArgb(255, 128, 128);
                btn.BGGradTop = Color.FromArgb(255, 0, 0);
                btn.Outline = Color.FromArgb(0, 0, 0);
            }
        }
    }
}
