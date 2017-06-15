using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SDV701Project2
{
    public partial class frmWithFlavour : SDV701Project2.frmCoffee
    {
        public static readonly frmWithFlavour Instance = new frmWithFlavour();
        protected List<string> cobxFlavouredSource;
        public frmWithFlavour()
        {
            InitializeComponent();
            cobxFlavouredSource = new List<string>();
            cobxFlavouredSource.Add("None");
            cobxFlavouredSource.Add("Vanilla");
            cobxFlavouredSource.Add("Caramel");
            cobxFlavouredSource.Add("Mint");
            cobxFlavouredSource.Add("Raspberry");
            cobxFlavoured.DataSource = cobxFlavouredSource;
        }

        public static void Run(clsWithFlavours prWithFlavours)
        {
            Instance.SetDetails(prWithFlavours);
        }
        protected override void UpdateForm()
        {
            base.UpdateForm();
            clsWithFlavours lcCoffee = (clsWithFlavours)this._Coffee;
            ckbxSteamedMilk.CheckState = (lcCoffee.SteamedMilk == 1) ? CheckState.Checked : CheckState.Unchecked;
            ckbxFrothedMilk.CheckState = (lcCoffee.FrothedMilk == 1) ? CheckState.Checked : CheckState.Unchecked;
            ckbxChocolate.CheckState = (lcCoffee.Chocolate == 1) ? CheckState.Checked : CheckState.Unchecked;
            ckbxChocolateDusting.CheckState = (lcCoffee.ChocolateDusting == 1) ? CheckState.Checked : CheckState.Unchecked;
            cobxFlavoured.SelectedItem = lcCoffee.FlavourType;
        }

        protected override void PushData()
        {
            base.PushData();
            clsWithFlavours lcCoffee = (clsWithFlavours)_Coffee;
            lcCoffee.SteamedMilk = (ckbxSteamedMilk.Checked) ? 1 : 0 ;
            lcCoffee.FrothedMilk = (ckbxFrothedMilk.Checked) ? 1 : 0 ;
            lcCoffee.Chocolate = (ckbxChocolate.Checked) ? 1 : 0 ;
            lcCoffee.ChocolateDusting = (ckbxChocolateDusting.Checked) ? 1 : 0 ;
            lcCoffee.FlavourType = cobxFlavoured.SelectedItem.ToString();
            lcCoffee.type = "SDV701Project2.clsWithFlavours, SDV701Project2";
        }
    }
}
