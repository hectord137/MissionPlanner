using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class Config_wifi : Form
    {
        private ConexWifi wifi;
        private ConfigPlanner configplanner;
        public Config_wifi()
        {
            wifi = new ConexWifi();
            configplanner = new ConfigPlanner();
            InitializeComponent();
            ComboRed.DataSource = wifi.FindWifi().Item3;
            comboInterfaz.DataSource = wifi.GetInterfaces().Item2;
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            string red = ComboRed.Text;
            string interfaz = comboInterfaz.Text;
            string pass = txtpass.Text;
            if (pass != "")
            {
                wifi.removeWifi(red);
                wifi.interfaz = interfaz;
                wifi.Name_wifi = red;
                wifi.password = pass;
                wifi.conectwifi();
                this.Hide();

                CustomColor.instance.activecolor(configplanner.myButton1);
            }
            else {
                CustomMessageBox.Show("Contraseña vacia", "Error");
            }
        }
    }
}
