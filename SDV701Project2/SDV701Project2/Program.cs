using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV701Project2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmOrders());
            Application.Run(new frmBeverages());
            Application.Run(new frmBeans());
            Application.Run(new frmCoffee());
            Application.Run(new frmWithoutMilk());
            Application.Run(new frmWithMilk());
            Application.Run(new frmWithFlavour());
            Application.Run(new InputBox());
        }
    }
}
