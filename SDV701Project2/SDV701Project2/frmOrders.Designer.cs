namespace SDV701Project2
{
    partial class frmOrders
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
            this.lblOrders = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnManageBeverages = new System.Windows.Forms.Button();
            this.btnQuitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(13, 13);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(38, 13);
            this.lblOrders.TabIndex = 0;
            this.lblOrders.Text = "Orders";
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(16, 29);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(442, 160);
            this.lstOrders.TabIndex = 1;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(143, 195);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnManageBeverages
            // 
            this.btnManageBeverages.Location = new System.Drawing.Point(224, 195);
            this.btnManageBeverages.Name = "btnManageBeverages";
            this.btnManageBeverages.Size = new System.Drawing.Size(112, 23);
            this.btnManageBeverages.TabIndex = 3;
            this.btnManageBeverages.Text = "Manage Beverages";
            this.btnManageBeverages.UseVisualStyleBackColor = true;
            this.btnManageBeverages.Click += new System.EventHandler(this.btnManageBeverages_Click);
            // 
            // btnQuitApp
            // 
            this.btnQuitApp.Location = new System.Drawing.Point(197, 226);
            this.btnQuitApp.Name = "btnQuitApp";
            this.btnQuitApp.Size = new System.Drawing.Size(75, 23);
            this.btnQuitApp.TabIndex = 4;
            this.btnQuitApp.Text = "Quit";
            this.btnQuitApp.UseVisualStyleBackColor = true;
            this.btnQuitApp.Click += new System.EventHandler(this.btnQuitApp_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.btnQuitApp);
            this.Controls.Add(this.btnManageBeverages);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.lblOrders);
            this.Name = "frmOrders";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnManageBeverages;
        private System.Windows.Forms.Button btnQuitApp;
    }
}