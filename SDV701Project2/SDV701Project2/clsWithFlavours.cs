using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SDV701Project2
{
    [DataContract]
    public class clsWithFlavours : clsCoffees
    {

        public delegate void LoadWithFlavoursFormDelegate(clsWithFlavours prcoffee);
        public static LoadWithFlavoursFormDelegate WithFlavoursForm;

        [DataMember]
        public int SteamedMilk { get; set; }
        [DataMember]
        public int FrothedMilk { get; set; }
        [DataMember]
        public int Chocolate { get; set; }
        [DataMember]
        public int ChocolateDusting { get; set; }
        [DataMember]
        public string FlavourType { get; set; }

        public override void EditDetails()
        {
            WithFlavoursForm(this);
        }

        public override string ToString()
        {
            return CoffeeID + " " + CoffeeName + "\t" + Price.ToString() + "\t" + DateModified;
        }
    }
}
