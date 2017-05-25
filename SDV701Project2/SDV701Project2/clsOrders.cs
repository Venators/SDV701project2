using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV701Project2
{
    public class clsOrders
    {
        public clsOrders() { }
        public string TrayRequ = null;
        public string SleeveRequ = null;

        public int OrderID { get; set; }
        public string BeanType { get; set; }
        public string RoastType { get; set; }
        public string CoffeeName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string OrderDateTime { get; set; }
        public string CupSize { get; set; }
        public int NeedsCarryTray { get; set; }
        public int NeedsCupSleeve { get; set; }
        public int TableNumber { get; set; }
        public string CustomerName { get; set; }
        public override string ToString()
        {
            if (NeedsCarryTray == 1)
            {
               TrayRequ = "Needs Tray";
            }

            if (NeedsCupSleeve == 1)
            {
                SleeveRequ = "Needs Sleeve";
            }

            if (TableNumber != 0)
            {
                return CustomerName + " " + BeanType + " " + RoastType + " " + CoffeeName + " " + "x" + Quantity.ToString() + " " + "$" + (Price * Quantity).ToString() + " " + CupSize + " " + "Table " + TableNumber.ToString();
            }
            else
            {
                return CustomerName + " " + BeanType + " " + RoastType + " " + CoffeeName + " " + "x" + Quantity.ToString() + " " + "$" + (Price * Quantity).ToString() + " " + CupSize + " " + TrayRequ + " " + SleeveRequ;
            }
        }
    }
}
