using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV701Project2
{
    public partial class frmCoffee : Form
    {
        protected clsCoffees _Coffee;
        protected List<string> comboSource;
        public frmCoffee()
        {
            InitializeComponent();
            comboSource = new List<string>();
            comboSource.Add("1/2");
            comboSource.Add("1");
            comboSource.Add("2");
        }

        public void SetDetails(clsCoffees prCoffee)
        {
            _Coffee = prCoffee;
            txtboxCoffeeName.Enabled = string.IsNullOrEmpty(_Coffee.CoffeeName);
            UpdateForm();
            ShowDialog();
        }

        protected virtual void UpdateForm()
        {
            txtboxCoffeeName.Text = _Coffee.CoffeeName;
            txtbxCoffeePrice.Text = _Coffee.Price.ToString();
            lblDateDisplay.Text = DateTime.Today.ToString("dd/MM/yyy");
            cobxNumberShots.DataSource = comboSource;
            cobxNumberShots.SelectedItem = _Coffee.NumberOfShots;
        }

        protected virtual void PushData()
        {
        _Coffee.CoffeeName = txtboxCoffeeName.Text;
        decimal D = decimal.Parse(txtbxCoffeePrice.Text);
        _Coffee.Price = D;
        _Coffee.DateModified = lblDateDisplay.Text;
        _Coffee.NumberOfShots = cobxNumberShots.SelectedItem.ToString();
        //_Coffee.BeanID = null;
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            PushData();
            if (txtboxCoffeeName.Enabled == true)
            {
                //Call Json Add
                int NewCoffeeID = await clsJSONConnection.AddCoffee(_Coffee);
                if (NewCoffeeID != 0)
                {
                    MessageBox.Show("New Coffee " + NewCoffeeID + " added");
                    UpdateForm();
                }
                else
                {
                    MessageBox.Show("Coffee couldn't be added");
                }
            }
            else
            {
                //Call Json Update
                string UpdatedCoffee = await clsJSONConnection.EditCoffee(_Coffee);
                if (UpdatedCoffee == "true")
                {
                    MessageBox.Show("Coffee " + _Coffee.CoffeeID + " edited");
                    UpdateForm();
                }
                else
                {
                    MessageBox.Show("Coffee " + _Coffee.CoffeeID + " couldn't be edited");
                }
            }
            Close();
        }
    }
}

