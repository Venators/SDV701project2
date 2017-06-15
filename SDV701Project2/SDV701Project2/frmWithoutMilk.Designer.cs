namespace SDV701Project2
{
    partial class frmWithoutMilk
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
            this.lblHotWater = new System.Windows.Forms.Label();
            this.ckbxHotWater = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblHotWater
            // 
            this.lblHotWater.AutoSize = true;
            this.lblHotWater.Location = new System.Drawing.Point(12, 115);
            this.lblHotWater.Name = "lblHotWater";
            this.lblHotWater.Size = new System.Drawing.Size(56, 13);
            this.lblHotWater.TabIndex = 10;
            this.lblHotWater.Text = "Hot Water";
            // 
            // ckbxHotWater
            // 
            this.ckbxHotWater.AutoSize = true;
            this.ckbxHotWater.Location = new System.Drawing.Point(91, 114);
            this.ckbxHotWater.Name = "ckbxHotWater";
            this.ckbxHotWater.Size = new System.Drawing.Size(44, 17);
            this.ckbxHotWater.TabIndex = 11;
            this.ckbxHotWater.Text = "Yes";
            this.ckbxHotWater.UseVisualStyleBackColor = true;
            // 
            // frmWithoutMilk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.ckbxHotWater);
            this.Controls.Add(this.lblHotWater);
            this.Name = "frmWithoutMilk";
            this.Text = "Coffee Without Milk";
            this.Controls.SetChildIndex(this.lblHotWater, 0);
            this.Controls.SetChildIndex(this.ckbxHotWater, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHotWater;
        private System.Windows.Forms.CheckBox ckbxHotWater;
    }
}
