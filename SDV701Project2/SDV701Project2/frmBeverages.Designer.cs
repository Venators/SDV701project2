namespace SDV701Project2
{
    partial class frmBeverages
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
            this.lstBeans = new System.Windows.Forms.ListBox();
            this.lblBeverages = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuantityVar = new System.Windows.Forms.Label();
            this.btnAddBean = new System.Windows.Forms.Button();
            this.btnDeleteBean = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBeans
            // 
            this.lstBeans.FormattingEnabled = true;
            this.lstBeans.Location = new System.Drawing.Point(16, 29);
            this.lstBeans.Name = "lstBeans";
            this.lstBeans.Size = new System.Drawing.Size(173, 160);
            this.lstBeans.TabIndex = 0;
            // 
            // lblBeverages
            // 
            this.lblBeverages.AutoSize = true;
            this.lblBeverages.Location = new System.Drawing.Point(13, 13);
            this.lblBeverages.Name = "lblBeverages";
            this.lblBeverages.Size = new System.Drawing.Size(58, 13);
            this.lblBeverages.TabIndex = 1;
            this.lblBeverages.Text = "Beverages";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(13, 196);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblQuantityVar
            // 
            this.lblQuantityVar.AutoSize = true;
            this.lblQuantityVar.Location = new System.Drawing.Point(71, 196);
            this.lblQuantityVar.Name = "lblQuantityVar";
            this.lblQuantityVar.Size = new System.Drawing.Size(35, 13);
            this.lblQuantityVar.TabIndex = 3;
            this.lblQuantityVar.Text = "label3";
            // 
            // btnAddBean
            // 
            this.btnAddBean.Location = new System.Drawing.Point(195, 29);
            this.btnAddBean.Name = "btnAddBean";
            this.btnAddBean.Size = new System.Drawing.Size(75, 23);
            this.btnAddBean.TabIndex = 4;
            this.btnAddBean.Text = "Add";
            this.btnAddBean.UseVisualStyleBackColor = true;
            this.btnAddBean.Click += new System.EventHandler(this.btnAddBean_Click);
            // 
            // btnDeleteBean
            // 
            this.btnDeleteBean.Location = new System.Drawing.Point(195, 58);
            this.btnDeleteBean.Name = "btnDeleteBean";
            this.btnDeleteBean.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBean.TabIndex = 6;
            this.btnDeleteBean.Text = "Delete";
            this.btnDeleteBean.UseVisualStyleBackColor = true;
            this.btnDeleteBean.Click += new System.EventHandler(this.btnDeleteBean_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(195, 196);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBeverages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 228);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteBean);
            this.Controls.Add(this.btnAddBean);
            this.Controls.Add(this.lblQuantityVar);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBeverages);
            this.Controls.Add(this.lstBeans);
            this.Name = "frmBeverages";
            this.Text = "Beverages";
            this.Load += new System.EventHandler(this.frmBeverages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBeans;
        private System.Windows.Forms.Label lblBeverages;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuantityVar;
        private System.Windows.Forms.Button btnAddBean;
        private System.Windows.Forms.Button btnDeleteBean;
        private System.Windows.Forms.Button btnClose;
    }
}

