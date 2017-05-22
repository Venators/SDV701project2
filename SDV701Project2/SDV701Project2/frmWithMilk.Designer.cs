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
            this.txtbxSteamedMilk = new System.Windows.Forms.TextBox();
            this.txtbxFrothyMilk = new System.Windows.Forms.TextBox();
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
            this.lblFrothyMilk.Size = new System.Drawing.Size(58, 13);
            this.lblFrothyMilk.TabIndex = 11;
            this.lblFrothyMilk.Text = "Frothy Milk";
            // 
            // txtbxSteamedMilk
            // 
            this.txtbxSteamedMilk.Location = new System.Drawing.Point(91, 112);
            this.txtbxSteamedMilk.Name = "txtbxSteamedMilk";
            this.txtbxSteamedMilk.Size = new System.Drawing.Size(100, 20);
            this.txtbxSteamedMilk.TabIndex = 12;
            // 
            // txtbxFrothyMilk
            // 
            this.txtbxFrothyMilk.Location = new System.Drawing.Point(91, 138);
            this.txtbxFrothyMilk.Name = "txtbxFrothyMilk";
            this.txtbxFrothyMilk.Size = new System.Drawing.Size(100, 20);
            this.txtbxFrothyMilk.TabIndex = 13;
            // 
            // frmWithMilk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.txtbxFrothyMilk);
            this.Controls.Add(this.txtbxSteamedMilk);
            this.Controls.Add(this.lblFrothyMilk);
            this.Controls.Add(this.lblSteamedMilk);
            this.Name = "frmWithMilk";
            this.Text = "Coffee With Milk";
            this.Controls.SetChildIndex(this.lblSteamedMilk, 0);
            this.Controls.SetChildIndex(this.lblFrothyMilk, 0);
            this.Controls.SetChildIndex(this.txtbxSteamedMilk, 0);
            this.Controls.SetChildIndex(this.txtbxFrothyMilk, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSteamedMilk;
        private System.Windows.Forms.Label lblFrothyMilk;
        private System.Windows.Forms.TextBox txtbxSteamedMilk;
        private System.Windows.Forms.TextBox txtbxFrothyMilk;
    }
}
