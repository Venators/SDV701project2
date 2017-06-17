namespace SDV701Project2
{
    partial class frmCoffee
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
            this.lblCoffeeName = new System.Windows.Forms.Label();
            this.lblCoffeePrice = new System.Windows.Forms.Label();
            this.lblDateModified = new System.Windows.Forms.Label();
            this.txtboxCoffeeName = new System.Windows.Forms.TextBox();
            this.txtbxCoffeePrice = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cobxNumberShots = new System.Windows.Forms.ComboBox();
            this.lblNumberShots = new System.Windows.Forms.Label();
            this.lblDateDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCoffeeName
            // 
            this.lblCoffeeName.AutoSize = true;
            this.lblCoffeeName.Location = new System.Drawing.Point(12, 9);
            this.lblCoffeeName.Name = "lblCoffeeName";
            this.lblCoffeeName.Size = new System.Drawing.Size(69, 13);
            this.lblCoffeeName.TabIndex = 0;
            this.lblCoffeeName.Text = "Coffee Name";
            // 
            // lblCoffeePrice
            // 
            this.lblCoffeePrice.AutoSize = true;
            this.lblCoffeePrice.Location = new System.Drawing.Point(12, 36);
            this.lblCoffeePrice.Name = "lblCoffeePrice";
            this.lblCoffeePrice.Size = new System.Drawing.Size(65, 13);
            this.lblCoffeePrice.TabIndex = 1;
            this.lblCoffeePrice.Text = "Coffee Price";
            // 
            // lblDateModified
            // 
            this.lblDateModified.AutoSize = true;
            this.lblDateModified.Location = new System.Drawing.Point(12, 62);
            this.lblDateModified.Name = "lblDateModified";
            this.lblDateModified.Size = new System.Drawing.Size(73, 13);
            this.lblDateModified.TabIndex = 2;
            this.lblDateModified.Text = "Date Modified";
            // 
            // txtboxCoffeeName
            // 
            this.txtboxCoffeeName.Location = new System.Drawing.Point(91, 6);
            this.txtboxCoffeeName.Name = "txtboxCoffeeName";
            this.txtboxCoffeeName.Size = new System.Drawing.Size(100, 20);
            this.txtboxCoffeeName.TabIndex = 3;
            // 
            // txtbxCoffeePrice
            // 
            this.txtbxCoffeePrice.Location = new System.Drawing.Point(91, 33);
            this.txtbxCoffeePrice.Name = "txtbxCoffeePrice";
            this.txtbxCoffeePrice.Size = new System.Drawing.Size(100, 20);
            this.txtbxCoffeePrice.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(197, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cobxNumberShots
            // 
            this.cobxNumberShots.FormattingEnabled = true;
            this.cobxNumberShots.Location = new System.Drawing.Point(91, 85);
            this.cobxNumberShots.Name = "cobxNumberShots";
            this.cobxNumberShots.Size = new System.Drawing.Size(100, 21);
            this.cobxNumberShots.TabIndex = 8;
            // 
            // lblNumberShots
            // 
            this.lblNumberShots.AutoSize = true;
            this.lblNumberShots.Location = new System.Drawing.Point(12, 88);
            this.lblNumberShots.Name = "lblNumberShots";
            this.lblNumberShots.Size = new System.Drawing.Size(44, 13);
            this.lblNumberShots.TabIndex = 9;
            this.lblNumberShots.Text = "# Shots";
            // 
            // lblDateDisplay
            // 
            this.lblDateDisplay.AutoSize = true;
            this.lblDateDisplay.Location = new System.Drawing.Point(91, 62);
            this.lblDateDisplay.Name = "lblDateDisplay";
            this.lblDateDisplay.Size = new System.Drawing.Size(67, 13);
            this.lblDateDisplay.TabIndex = 10;
            this.lblDateDisplay.Text = "Date Display";
            // 
            // frmCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.lblDateDisplay);
            this.Controls.Add(this.lblNumberShots);
            this.Controls.Add(this.cobxNumberShots);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtbxCoffeePrice);
            this.Controls.Add(this.txtboxCoffeeName);
            this.Controls.Add(this.lblDateModified);
            this.Controls.Add(this.lblCoffeePrice);
            this.Controls.Add(this.lblCoffeeName);
            this.Name = "frmCoffee";
            this.Text = "Coffee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoffeeName;
        private System.Windows.Forms.Label lblCoffeePrice;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.TextBox txtboxCoffeeName;
        private System.Windows.Forms.TextBox txtbxCoffeePrice;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cobxNumberShots;
        private System.Windows.Forms.Label lblNumberShots;
        private System.Windows.Forms.Label lblDateDisplay;
    }
}