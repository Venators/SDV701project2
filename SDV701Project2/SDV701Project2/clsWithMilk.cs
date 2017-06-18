using System.Runtime.Serialization;

namespace SDV701Project2
{
    [DataContract]
    public class clsWithMilk : clsCoffees
    {

        public delegate void LoadWithMilkFormDelegate(clsWithMilk prcoffee);
        public static LoadWithMilkFormDelegate WithMilkForm;

        [DataMember]
        public int SteamedMilk { get; set; }
        [DataMember]
        public int FrothedMilk { get; set; }

        public override void EditDetails()
        {
            WithMilkForm(this);
        }

        public override string ToString()
        {
            return CoffeeID + " " + CoffeeName + "\t" + Price.ToString() + "\t" + DateModified;
        }
    }
}
