using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SDV701Project2
{
    [DataContract]
    [KnownType(typeof(clsWithoutMilk))]
    [KnownType(typeof(clsWithMilk))]
    [KnownType(typeof(clsWithFlavours))]
    public abstract class clsCoffees
    {
        public clsCoffees() { }

        public static readonly string FACTORY_PROMPT = "Enter 1 for Coffees w/o Milk, 2 for Coffees With Milk or 3 for Coffees With Flavour";

        public static clsCoffees NewCoffee(char prChoice)
        {
            switch (char.ToUpper(prChoice))
            {
                case '1': return new clsWithoutMilk();
                case '2': return new clsWithMilk();
                case '3': return new clsWithFlavours();
                default: return null;
            }
        }

        public abstract void EditDetails();
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public int CoffeeID { get; set; }
        [DataMember]
        public string CoffeeName { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string DateModified{ get; set; }
        [DataMember]
        public string NumberOfShots { get; set; }
        [DataMember]
        public int BeanID { get; set; }

        //public override string ToString()
        //{
        //    return CoffeeID.ToString() + " " + CoffeeName + " " + DateModified;
        //}

    }
}
