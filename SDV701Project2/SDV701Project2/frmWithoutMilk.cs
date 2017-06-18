using System.Windows.Forms;

namespace SDV701Project2
{
    public partial class frmWithoutMilk : frmCoffee
    {
        public static readonly frmWithoutMilk Instance = new frmWithoutMilk();

        public frmWithoutMilk()
        {
            InitializeComponent();
        }

        public static void Run(clsWithoutMilk prWithoutMilk)
        {
            Instance.SetDetails(prWithoutMilk);
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            clsWithoutMilk lcCoffee = (clsWithoutMilk)this._Coffee;
            ckbxHotWater.CheckState = (lcCoffee.HotWater == 1) ? CheckState.Checked : CheckState.Unchecked;
        }

        protected override void PushData()
        {
            int lcHotWaterValue;
            base.PushData();
            clsWithoutMilk lcCoffee = (clsWithoutMilk)_Coffee;
            lcHotWaterValue = (ckbxHotWater.Checked == true) ? 1 : 0;
            lcCoffee.HotWater = lcHotWaterValue;
            lcCoffee.type = "SDV701Project2.clsWithoutMilk, SDV701Project2";
        }
    }
}
