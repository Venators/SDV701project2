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
            UpdateForm();
            ShowDialog();
        }

        protected virtual void UpdateForm()
        {
            txtboxCoffeeName.Text = _Coffee.CoffeeName;
            txtbxCoffeePrice.Text = _Coffee.Price.ToString();
            txtbxDateModified.Text = _Coffee.DateModified;
            cobxNumberShots.DataSource = comboSource;
            cobxNumberShots.SelectedItem = _Coffee.NumberOfShots;
        }

        protected virtual void PushData()
        {
        _Coffee.CoffeeName = txtboxCoffeeName.Text;
        decimal D = decimal.Parse(txtbxCoffeePrice.Text);
        _Coffee.Price = D;
        _Coffee.DateModified = txtbxDateModified.Text;
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
                MessageBox.Show("New Coffe " + NewCoffeeID + " added");
            }
            else
            {
                //Call Json Update
            }
            Close();
        }
    }
}

