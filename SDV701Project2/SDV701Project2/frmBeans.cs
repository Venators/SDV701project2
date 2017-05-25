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
        private static Dictionary<clsBeans, frmBeans> _BeansFormList;
        public frmBeans()
        {
            InitializeComponent();
        }

        private clsBeans _Beans;

        public static void Run(clsBeans prBean)
        {
            frmBeans lcBeansForm;
            if (!_BeansFormList.TryGetValue(prBean, out lcBeansForm))
            {
                lcBeansForm = new frmBeans();
                _BeansFormList.Add(prBean, lcBeansForm);
                lcBeansForm.SetDetails(prBean);
            }
            else
            {
                lcBeansForm.Show();
                lcBeansForm.Activate();
            }
        }

        private async void UpdateDisplay()
        {
            //private prBeanID = _Beans.BeanID.ToString();
            string lcBeanID = _Beans.BeanID.ToString();
            lstbxCoffees.DataSource = null;
            lstbxCoffees.DataSource = await clsJSONConnection.ViewCoffees(lcBeanID);
        }

        private void UpdateForm()
        {
            txtbxBeanType.Text = _Beans.BeanType;
            txtbxRoastType.Text = _Beans.RoastType;
            txtbxQuantity.Text = _Beans.Quantity.ToString();
            txtbxCountryofOrigin.Text = _Beans.CountryOfOrigin;
            UpdateDisplay();
        }

        public void SetDetails(clsBeans prBean)
        {
            _Beans = prBean;
            txtbxBeanType.Enabled = string.IsNullOrEmpty(_Beans.BeanType);
            UpdateForm();
            UpdateDisplay();
            Show();

        }
    }
}
