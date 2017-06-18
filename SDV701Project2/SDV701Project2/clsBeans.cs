using System.Collections.Generic;

namespace SDV701Project2
{
    public class clsBeans
    {
        public void EditCoffee(int prKey)
        {
            clsCoffees lcCoffee = BeanCoffees[prKey];
            lcCoffee.EditDetails();
        }
        public clsBeans() { }

        public int BeanID { get; set; }
        public string BeanType { get; set; }
        public string RoastType { get; set; }
        public int Quantity { get; set; }
        public string CountryOfOrigin { get; set; }
        public IList<clsCoffees> BeanCoffees { get; set; }

        public override string ToString()
        {
            return BeanID.ToString() + " " + BeanType + " " + RoastType + " " + Quantity.ToString() + " " + CountryOfOrigin;
        }
    }
}
