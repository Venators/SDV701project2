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
    public partial class frmBeverages : Form
    {
        public frmBeverages()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        public async void UpdateDisplay()
        {
            var json_data = string.Empty;
            using (var w = new WebClient())
                json_data = w.DownloadString("http://localhost:8080/CafedesPensees/API/ViewBeverages/");
            MessageBox.Show(json_data);
            try
            {
                lstBeans.DataSource = null;
                lstBeans.DataSource = await clsJSONConnection.ViewBeverages();
                //lblQuantityVar.DataBindings = clsBeverages.GetTotalValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnAddBean_Click(object sender, EventArgs e)
        {

        }

        /*private void lstBeans_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string lcKey;
                lcKey = Convert.ToString(lstBeans.SelectedItem);

                if(lcKey != null)
                {
                    frmBeans.Run(_BeanList[lcKey]);
                    UpdateDisplay();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void btnDeleteBean_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
