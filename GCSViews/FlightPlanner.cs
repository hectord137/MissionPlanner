using MissionPlanner.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class FlightPlanner : MyUserControl, IDeactivate, IActivate
    {

        private readonly FlightPlannerBase _flightPlannerBase;

        public FlightPlanner()
        {
            InitializeComponent();

            _flightPlannerBase = new FlightPlannerBase(this);
            modifyMain();
        }

        public FlightPlannerBase FlightPlannerBase
        {
            get { return _flightPlannerBase; }
        }

        public void Activate()
        {
            _flightPlannerBase.Activate();
        }

        public void Deactivate()
        {
            _flightPlannerBase.Deactivate();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var ans =  _flightPlannerBase.ProcessCmdKey(ref msg, keyData);

            if (ans == false)
                ans = base.ProcessCmdKey(ref msg, keyData);

            return ans;
        }

        private void ButKMLOverlay_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.kmloverlay();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void ButMeasureContext_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.measurecontext();
          
        }

        private void setHomeHereToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void cmb_missiontype_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
        public bool bloqWP = false;
        public void BUT_insertWP_Click(object sender, System.EventArgs e)
        {
            if (bloqWP)
            {
                bloqWP = false; 
                BUT_insertWP.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                bloqWP = true;
                BUT_insertWP.BackColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void addPolygonPointToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        
        private void ButInsertPol_Click(object sender, System.EventArgs e)
        {
            ButClearPol.Enabled = true;
            bloqWP = true;
            BtSavePol.Enabled = true;
            _flightPlannerBase.addPolygonPointToolStripMenuItem_Click(sender, e);
        }

        private void modifyMain() {
            ButClearPol.Enabled = false;
            BtSavePol.Enabled = false;
            contextMenuStripPoly.Visible = false;
        }

        private void ButClearPol_Click(object sender, System.EventArgs e)
        {
                DialogResult boton = MessageBox.Show("Clear Polygon?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (boton == DialogResult.OK)
                {
                    _flightPlannerBase.clearPolygonToolStripMenuItem_Click(Events, e);
                ButClearPol.Enabled = false;
                bloqWP = false;
                BtSavePol.Enabled = false;
            }
                else { }
           
        }

        private void BtSavePol_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.savePolygonToolStripMenuItem_Click(sender, e);
        }

        private void ButLoadPol_Click_1(object sender, System.EventArgs e)
        {
            ButClearPol.Enabled = true;
            _flightPlannerBase.loadPolygonToolStripMenuItem_Click(sender, e);
        }

        private void BUT_write_Click(object sender, System.EventArgs e)
        {

        }

        private void CMB_altmode_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void LBL_WPRad_Click(object sender, System.EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, System.EventArgs e)
        {

        }

        private void TXT_WPRad_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void setRallyPointToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
        public bool bloqRallyPoint = false;
        private void myButton1_Click(object sender, System.EventArgs e) {

            if (bloqRallyPoint)
            {
                bloqRallyPoint = false;
                myButton1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                bloqRallyPoint = true;
                myButton1.BackColor = Color.FromArgb(0, 0, 0);
            }
  
        }

        private void myButton6_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.getRallyPointsToolStripMenuItem_Click(sender, e);
        }

        private void myButton3_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.saveRallyPointsToolStripMenuItem_Click(sender, e);
        }

        private void myButton5_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.clearRallyPointsToolStripMenuItem_Click(sender, e);
        }

        private void myButton4_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.saveToFileToolStripMenuItem1_Click(sender, e);
        }

        private void myButton2_Click(object sender, System.EventArgs e)
        {
            _flightPlannerBase.loadFromFileToolStripMenuItem1_Click(sender, e);
        }
    }
}