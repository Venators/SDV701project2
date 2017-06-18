using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        private bool ValidateData()
        {
            List<string> ErrorList = new List<string>();
            if (txtboxCoffeeName.Text.Length >= 16)
            {
                ErrorList.Add("Please keep your coffee name under 15 characters, ");
            }
            if (txtbxCoffeePrice.Text != null)
            {
                string lcPrice = txtbxCoffeePrice.Text;
                lcPrice = lcPrice.Replace(".", "");
                bool IsNumerical = lcPrice.All(char.IsDigit);
                if (IsNumerical == false)
                {
                    ErrorList.Add("Please enter only numbers into price");
                }
            }
            if (ErrorList.Count >= 1)
            {
                var message = string.Join(Environment.NewLine, ErrorList);
                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            bool Result = ValidateData();
            if (Result == true)
            {
                PushData();
                if (txtboxCoffeeName.Enabled == true)
                {
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
                    string UpdatedCoffee = await clsJSONConnection.EditCoffee(_Coffee);
                    if (UpdatedCoffee == "true")
                    {
                        await clsJSONConnection.LockToggle("Coffee", _Coffee.CoffeeID, 0);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

