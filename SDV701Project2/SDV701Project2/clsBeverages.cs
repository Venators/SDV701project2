using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV701Project2
{
    class clsBeverages
    {
        public clsBeverages() { }

        public int BeanID { get; set; }
        public string BeanType { get; set; }
        public string RoastType { get; set; }
        public int Quantity { get; set; }
        public string CountryOfOrigin { get; set; }

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
            return BeanType + " " + RoastType + " " + Quantity.ToString() + " " + CountryOfOrigin;
        }
    }
}
