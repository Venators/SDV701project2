using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
                //int[] lcDisplayList = new int[_BeansList.Count];

                lstBeans.DataSource = null;
                //_BeansList.Keys.CopyTo(lcDisplayList, 0);
                //lstBeans.DataSource = lcDisplayList;
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

        private void lstBeans_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;
            clsBeansList lcBean = lstBeans.SelectedValue as clsBeansList;

            lcKey = Convert.ToString(lcBean.BeanID);
            frmBeans.Run(lcKey);
        }

        private void btnDeleteBean_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
