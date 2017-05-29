using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV701Project2
{
    public class clsBeans
    {
        public clsBeans() { }

        public int BeanID { get; set; }
        public string BeanType { get; set; }
        public string RoastType { get; set; }
        public int Quantity { get; set; }
        public string CountryOfOrigin { get; set; }
        public ICollection<clsCoffees> BeanCoffees { get; set; }
        /*public int GetTotalValue()
        {
            int lcTotal = 0;
            foreach (clsBeverages clsBeverages in )
            {
                lcTotal += clsBeverages.Quantity;
            }
            return lcTotal;
        }*/

        public override string ToString()
        {
            return BeanID.ToString() + " " + BeanType + " " + RoastType + " " + Quantity.ToString() + " " + CountryOfOrigin;
        }
    }
}
