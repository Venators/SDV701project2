using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV701Project2
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
            UpdateDisplay();
        }
        public async void UpdateDisplay()
        {
            var json_data = string.Empty;
            using (var w = new WebClient())
                json_data = w.DownloadString("http://localhost:8080/CafedesPensees/API/ViewOrders/");
            MessageBox.Show(json_data);
            try
            {
                lstOrders.DataSource = null;
                lstOrders.DataSource = await clsJSONConnection.ViewOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnManageBeverages_Click(object sender, EventArgs e)
        {
            Form frmBeverages = new frmBeverages();
            frmBeverages.Show();
        }
        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
