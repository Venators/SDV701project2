using System.Runtime.Serialization;

namespace SDV701Project2
{
    [DataContract]
    public class clsWithoutMilk : clsCoffees
    {

        public delegate void LoadWithoutMilkFormDelegate(clsWithoutMilk prcoffee);
        public static LoadWithoutMilkFormDelegate WithoutMilkForm;

        [DataMember]
        public int HotWater { get; set; }

        public override void EditDetails()
        {
            WithoutMilkForm(this);
        }

        public override string ToString()
        {
            return CoffeeID + " " + CoffeeName + "\t" + Price.ToString() + "\t" + DateModified;
        }
    }
}

