using MissionPlanner.GCSViews;
using MissionPlanner.GCSViews.ConfigurationView;
using System;
using System.Windows.Forms;

namespace MissionPlanner.Grid
{
    public class GridPlugin : MissionPlanner.Plugin.Plugin
    {

        ToolStripMenuItem but;

        public override string Name
        {
            get { return "Grid"; }
        }

        public override string Version
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public override string Author
        {
            get { return ""; }
        }

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridUI));
            var temp = (string)(resources.GetObject("$this.Text"));

            but = new ToolStripMenuItem(temp);
            but.Click += but_Click;

            bool hit = false;
            ToolStripItemCollection col = Host.FPMenuMap.Items;
            int index = col.Count;
            foreach (ToolStripItem item in col)
            {
                if (item.Text.Equals(Strings.AutoWP))
                {
                    index = col.IndexOf(item);
                    ((ToolStripMenuItem)item).DropDownItems.Add(but);
                    hit = true;
                    break;
                }
            }

            if (hit == false)
                col.Add(but);

            return true;

        }

        public bool haypoly = false;
        public void but_Click(object sender, EventArgs e)
        {
            using (var gridui = new GridUI(this))
            {
                MissionPlanner.Utilities.ThemeManager.ApplyThemeTo(gridui);

                if (Host.FPDrawnPolygon != null && Host.FPDrawnPolygon.Points.Count > 2)
                {
                    FlightPlannerBase.instance._flightPlanner.tableLayoutPanel12.Controls.Clear();
                    FlightPlannerBase.instance._flightPlanner.tableLayoutPanel12.Controls.Add(gridui.tabControl1);  //Agrego la instancia al panel y listo.
                    gridui.GridUI_Load(sender, e);
                    haypoly = true;
                    FlightPlanner.instance.PaneMenu.Visible = true;
                }
                else
                {
                    if (
                        CustomMessageBox.Show("No polygon defined. Load a file?", "Load File", MessageBoxButtons.YesNo) ==
                        (int)DialogResult.Yes)
                        
                    {

                        gridui.LoadGrid();
                        FlightPlannerBase.instance._flightPlanner.tableLayoutPanel12.Controls.Clear();
                        FlightPlannerBase.instance._flightPlanner.tableLayoutPanel12.Controls.Add(gridui.tabControl1);
                        haypoly = true;
                        FlightPlanner.instance.PaneMenu.Visible = true;
                    }
                    else
                    {
                        CustomMessageBox.Show("Please define a polygon.", "Error");
                        FlightPlannerBase.instance._flightPlanner.estadomenu = false;
                        haypoly = false;
                        FlightPlanner.instance.PaneMenu.Visible = false;
                        FlightPlanner.instance.Estado_btn_insert_poly = true;
                        FlightPlanner.instance.ButInsertPol_Click(sender, e);
                        CustomColor.instance.Normalcolor(FlightPlanner.instance.But_SurveyGrid);


                    }
                }
            }
        }


        public override bool Exit()
        {
            return true;
        }
    }
}
