using System;
using System.Net;
using System.Windows.Forms;

namespace SDV701Project2
{
    public partial class frmBeansList : Form
    {
        public frmBeansList()
        {
            InitializeComponent();
        }

        private void frmBeverages_Load(object sender, EventArgs e)
        {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddBean_Click(object sender, EventArgs e)
        {

        }

        private void lstBeans_DoubleClick(object sender, EventArgs e)
        {
            ViewSelectedBean();
        }

        private void btnViewBean_Click(object sender, EventArgs e)
        {
            ViewSelectedBean();
        }

        private void ViewSelectedBean()
        {
            string lcKey;
            clsBeansList lcBean = lstBeans.SelectedValue as clsBeansList;

            lcKey = Convert.ToString(lcBean.BeanID);
            frmBeans.Run(lcKey);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
