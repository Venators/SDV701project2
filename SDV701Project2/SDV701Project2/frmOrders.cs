using System;
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

        private async void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            string lcKey;
            clsOrders lcOrder = lstOrders.SelectedValue as clsOrders;

            lcKey = Convert.ToString(lcOrder.OrderID);
            bool OrderDeleted = await clsJSONConnection.DeleteOrder(lcKey);
            if(OrderDeleted == true)
            {
                MessageBox.Show("Order " + lcKey + " has been deleted.");
                UpdateDisplay();
            }
        }

        private void btnManageBeverages_Click(object sender, EventArgs e)
        {
            Form frmBeverages = new frmBeansList();
            frmBeverages.Show();
        }
        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
