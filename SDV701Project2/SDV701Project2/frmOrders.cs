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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
            UpdateDisplay();
        }
        public async void UpdateDisplay()
        {
            lstOrders.DataSource = null;
            lstOrders.DataSource = await clsJSONConnection.GetArtistNamesAsync();
            var message = string.Join(Environment.NewLine, lstOrders.DataSource);
            MessageBox.Show(message);
        }
    }
}
