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
        private clsCoffees _Coffees;

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
            SetDetails();
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

        public void SetDetails()
        {
            txtbxBeanType.Enabled = string.IsNullOrEmpty(_Beans.BeanType);
            //UpdateForm();
            UpdateDisplay();
            Show();

        }

        private void btnAddCoffee_Click(object sender, EventArgs e)
        {
            string lcReply = new InputBox(clsCoffees.FACTORY_PROMPT).Answer;
            if (!string.IsNullOrEmpty(lcReply))
            {
                clsCoffees lcCoffee = clsCoffees.NewCoffee(lcReply[0]);
                if (lcCoffee != null)
                {
                    lcCoffee.BeanID = _Beans.BeanID;
                    lcCoffee.EditDetails();
                    if (!string.IsNullOrEmpty(lcCoffee.CoffeeName))
                    {
                        SetDetails();
                    }
                    string lcKey = lcCoffee.BeanID.ToString();
                    RefreshData(lcKey);
                }
            }
        }

        private async void btnEditCoffee_Click(object sender, EventArgs e)
        {
            var lcCoffee = lstbxCoffees.SelectedValue as clsCoffees;
            int IsLocked = await clsJSONConnection.CheckLockStatus("Coffee", lcCoffee.CoffeeID);
            if (IsLocked == 0)
            {
                await clsJSONConnection.LockToggle("Coffee", lcCoffee.CoffeeID, 1);
                try
                {
                    (lstbxCoffees.SelectedValue as clsCoffees).EditDetails();
                    SetDetails();
                    /*if (lcKey >= 0)
                    {
                        _Beans.EditCoffee(lcKey);
                    }*/
                }
                catch
                {
                    await clsJSONConnection.LockToggle("Coffee", lcCoffee.CoffeeID, 0);
                    throw new Exception("Sorry no coffee selected #" + Convert.ToString(lstbxCoffees.SelectedValue));
                }
            }
            else
            {
                MessageBox.Show("Record is locked - please try again later");
            }  
        }

        private async void btnDeleteCoffee_Click(object sender, EventArgs e)
        {
            string lcKey;
            clsCoffees lcCoffee = lstbxCoffees.SelectedValue as clsCoffees;

            lcKey = Convert.ToString(lcCoffee.CoffeeID);
            bool CoffeeDeleted = await clsJSONConnection.DeleteCoffee(lcKey);
            if (CoffeeDeleted == true)
            {
                MessageBox.Show("Coffee " + lcKey + " has been deleted.");
                string lcBeanKey = lcCoffee.BeanID.ToString();
                RefreshData(lcBeanKey);
            }
        }

        private void btnCloseBeans_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
