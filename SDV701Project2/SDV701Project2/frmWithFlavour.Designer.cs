namespace SDV701Project2
{
    partial class frmWithFlavour
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
            this.lblChocolate = new System.Windows.Forms.Label();
            this.lblChocolateDusting = new System.Windows.Forms.Label();
            this.lblFlavoured = new System.Windows.Forms.Label();
            this.txtbxChocolate = new System.Windows.Forms.TextBox();
            this.txtbxChocolateDusting = new System.Windows.Forms.TextBox();
            this.txtbxFlavouring = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblChocolate
            // 
            this.lblChocolate.AutoSize = true;
            this.lblChocolate.Location = new System.Drawing.Point(12, 167);
            this.lblChocolate.Name = "lblChocolate";
            this.lblChocolate.Size = new System.Drawing.Size(55, 13);
            this.lblChocolate.TabIndex = 14;
            this.lblChocolate.Text = "Chocolate";
            // 
            // lblChocolateDusting
            // 
            this.lblChocolateDusting.AutoSize = true;
            this.lblChocolateDusting.Location = new System.Drawing.Point(12, 193);
            this.lblChocolateDusting.Name = "lblChocolateDusting";
            this.lblChocolateDusting.Size = new System.Drawing.Size(77, 13);
            this.lblChocolateDusting.TabIndex = 15;
            this.lblChocolateDusting.Text = "Choco Dusting";
            // 
            // lblFlavoured
            // 
            this.lblFlavoured.AutoSize = true;
            this.lblFlavoured.Location = new System.Drawing.Point(12, 219);
            this.lblFlavoured.Name = "lblFlavoured";
            this.lblFlavoured.Size = new System.Drawing.Size(54, 13);
            this.lblFlavoured.TabIndex = 16;
            this.lblFlavoured.Text = "Flavoured";
            // 
            // txtbxChocolate
            // 
            this.txtbxChocolate.Location = new System.Drawing.Point(91, 164);
            this.txtbxChocolate.Name = "txtbxChocolate";
            this.txtbxChocolate.Size = new System.Drawing.Size(100, 20);
            this.txtbxChocolate.TabIndex = 17;
            // 
            // txtbxChocolateDusting
            // 
            this.txtbxChocolateDusting.Location = new System.Drawing.Point(91, 190);
            this.txtbxChocolateDusting.Name = "txtbxChocolateDusting";
            this.txtbxChocolateDusting.Size = new System.Drawing.Size(100, 20);
            this.txtbxChocolateDusting.TabIndex = 18;
            // 
            // txtbxFlavouring
            // 
            this.txtbxFlavouring.Location = new System.Drawing.Point(91, 216);
            this.txtbxFlavouring.Name = "txtbxFlavouring";
            this.txtbxFlavouring.Size = new System.Drawing.Size(100, 20);
            this.txtbxFlavouring.TabIndex = 19;
            // 
            // frmWithFlavour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.txtbxFlavouring);
            this.Controls.Add(this.txtbxChocolateDusting);
            this.Controls.Add(this.txtbxChocolate);
            this.Controls.Add(this.lblFlavoured);
            this.Controls.Add(this.lblChocolateDusting);
            this.Controls.Add(this.lblChocolate);
            this.Name = "frmWithFlavour";
            this.Text = "Coffee With Flavour";
            this.Controls.SetChildIndex(this.lblChocolate, 0);
            this.Controls.SetChildIndex(this.lblChocolateDusting, 0);
            this.Controls.SetChildIndex(this.lblFlavoured, 0);
            this.Controls.SetChildIndex(this.txtbxChocolate, 0);
            this.Controls.SetChildIndex(this.txtbxChocolateDusting, 0);
            this.Controls.SetChildIndex(this.txtbxFlavouring, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChocolate;
        private System.Windows.Forms.Label lblChocolateDusting;
        private System.Windows.Forms.Label lblFlavoured;
        private System.Windows.Forms.TextBox txtbxChocolate;
        private System.Windows.Forms.TextBox txtbxChocolateDusting;
        private System.Windows.Forms.TextBox txtbxFlavouring;
    }
}
