using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SDV701Project2
{
    [DataContract]
    public class clsWithoutMilk : clsCoffees
    {

        public delegate void LoadWithoutMilkFormDelegate(clsWithoutMilk prcoffee);
        public static LoadWithoutMilkFormDelegate WithoutMilkFormForm;

        [DataMember]
        public int HotWater { get; set; }

        public override void EditDetails()
        {
            WithoutMilkFormForm(this);
        }

        public override string ToString()
        {
            return CoffeeID + " " + CoffeeName + "\t" + Price.ToString() + "\t" + DateModified;
        }
    }
}

