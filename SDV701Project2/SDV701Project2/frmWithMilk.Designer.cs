namespace SDV701Project2
{
    partial class frmWithMilk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSteamedMilk = new System.Windows.Forms.Label();
            this.lblFrothyMilk = new System.Windows.Forms.Label();
            this.ckbxSteamedMilk = new System.Windows.Forms.CheckBox();
            this.ckbxFrothedMilk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSteamedMilk
            // 
            this.lblSteamedMilk.AutoSize = true;
            this.lblSteamedMilk.Location = new System.Drawing.Point(12, 115);
            this.lblSteamedMilk.Name = "lblSteamedMilk";
            this.lblSteamedMilk.Size = new System.Drawing.Size(71, 13);
            this.lblSteamedMilk.TabIndex = 10;
            this.lblSteamedMilk.Text = "Steamed Milk";
            // 
            // lblFrothyMilk
            // 
            this.lblFrothyMilk.AutoSize = true;
            this.lblFrothyMilk.Location = new System.Drawing.Point(12, 141);
            this.lblFrothyMilk.Name = "lblFrothyMilk";
            this.lblFrothyMilk.Size = new System.Drawing.Size(65, 13);
            this.lblFrothyMilk.TabIndex = 11;
            this.lblFrothyMilk.Text = "Frothed Milk";
            // 
            // ckbxSteamedMilk
            // 
            this.ckbxSteamedMilk.AutoSize = true;
            this.ckbxSteamedMilk.Location = new System.Drawing.Point(91, 114);
            this.ckbxSteamedMilk.Name = "ckbxSteamedMilk";
            this.ckbxSteamedMilk.Size = new System.Drawing.Size(44, 17);
            this.ckbxSteamedMilk.TabIndex = 12;
            this.ckbxSteamedMilk.Text = "Yes";
            this.ckbxSteamedMilk.UseVisualStyleBackColor = true;
            // 
            // ckbxFrothedMilk
            // 
            this.ckbxFrothedMilk.AutoSize = true;
            this.ckbxFrothedMilk.Location = new System.Drawing.Point(91, 140);
            this.ckbxFrothedMilk.Name = "ckbxFrothedMilk";
            this.ckbxFrothedMilk.Size = new System.Drawing.Size(44, 17);
            this.ckbxFrothedMilk.TabIndex = 13;
            this.ckbxFrothedMilk.Text = "Yes";
            this.ckbxFrothedMilk.UseVisualStyleBackColor = true;
            // 
            // frmWithMilk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.ckbxFrothedMilk);
            this.Controls.Add(this.ckbxSteamedMilk);
            this.Controls.Add(this.lblFrothyMilk);
            this.Controls.Add(this.lblSteamedMilk);
            this.Name = "frmWithMilk";
            this.Text = "Coffee With Milk";
            this.Controls.SetChildIndex(this.lblSteamedMilk, 0);
            this.Controls.SetChildIndex(this.lblFrothyMilk, 0);
            this.Controls.SetChildIndex(this.ckbxSteamedMilk, 0);
            this.Controls.SetChildIndex(this.ckbxFrothedMilk, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSteamedMilk;
        private System.Windows.Forms.Label lblFrothyMilk;
        private System.Windows.Forms.CheckBox ckbxSteamedMilk;
        private System.Windows.Forms.CheckBox ckbxFrothedMilk;
    }
}
