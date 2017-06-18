using System.Windows.Forms;

namespace SDV701Project2
{
    public partial class frmWithMilk : frmCoffee
    {
        public static readonly frmWithMilk Instance = new frmWithMilk();

        public frmWithMilk()
        {
            InitializeComponent();
        }

        public static void Run(clsWithMilk prWithMilk)
        {
            Instance.SetDetails(prWithMilk);
        }
        protected override void UpdateForm()
        {
            base.UpdateForm();
            clsWithMilk lcCoffee = (clsWithMilk)this._Coffee;
            ckbxSteamedMilk.CheckState = (lcCoffee.SteamedMilk == 1) ? CheckState.Checked : CheckState.Unchecked;
            ckbxFrothedMilk.CheckState = (lcCoffee.FrothedMilk == 1) ? CheckState.Checked : CheckState.Unchecked;
        }

        protected override void PushData()
        {
            base.PushData();
            clsWithMilk lcCoffee = (clsWithMilk)_Coffee;
            lcCoffee.SteamedMilk = (ckbxSteamedMilk.Checked) ? 1 : 0;
            lcCoffee.FrothedMilk = (ckbxFrothedMilk.Checked) ? 1 : 0;
            lcCoffee.type = "SDV701Project2.clsWithMilk, SDV701Project2";
        }
    }
}
