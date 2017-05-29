using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV701Project2
{
    public partial class frmBeans : Form
    {
        public frmBeans()
        {
            InitializeComponent();
        }

        private static Dictionary<string, frmBeans> _BeansFormList = new Dictionary<string, frmBeans>();
        private static clsBeans _Beans; //= new clsBeans();

        public static void Run(string prKey)
        {
            frmBeans lcBeansForm;
            if (string.IsNullOrEmpty(prKey) || !_BeansFormList.TryGetValue(prKey, out lcBeansForm))
            {
                lcBeansForm = new frmBeans();
                _BeansFormList.Add(prKey, lcBeansForm);
                lcBeansForm.RefreshData(prKey);
            }
            else
            {
                lcBeansForm.Show();
                lcBeansForm.Activate();
            }
        }

        async void RefreshData(string prKey)
        {
            _Beans = await clsJSONConnection.ViewBeanCoffees(prKey);
            SetDetails(_Beans);
        }

        /*private void UpdateDisplay()
        {
            private prBeanID = _Beans.BeanID.ToString();
            string lcBeanID = _Beans.BeanID.ToString();

            lstbxCoffees.DataSource = await clsJSONConnection.ViewCoffees(lcBeanID);
        }*/

        private void UpdateDisplay()
        {
            txtbxBeanType.Text = _Beans.BeanType;
            txtbxRoastType.Text = _Beans.RoastType;
            txtbxQuantity.Text = _Beans.Quantity.ToString();
            txtbxCountryofOrigin.Text = _Beans.CountryOfOrigin;
            lstbxCoffees.DataSource = null;
            lstbxCoffees.DataSource = _Beans.BeanCoffees;
        }

        public void SetDetails(clsBeans prBean)
        {
            txtbxBeanType.Enabled = string.IsNullOrEmpty(_Beans.BeanType);
            //UpdateForm();
            UpdateDisplay();
            Show();

        }

        private void btnAddCoffee_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCoffee_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCoffee_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseBeans_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
