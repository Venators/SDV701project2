﻿namespace SDV701Project2
{
    partial class frmBeans
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
            this.lblBeanType = new System.Windows.Forms.Label();
            this.lblRoastType = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtbxBeanType = new System.Windows.Forms.TextBox();
            this.txtbxRoastType = new System.Windows.Forms.TextBox();
            this.txtbxQuantity = new System.Windows.Forms.TextBox();
            this.lblCountryOfOrigin = new System.Windows.Forms.Label();
            this.txtbxCountryofOrigin = new System.Windows.Forms.TextBox();
            this.gpbxSorting = new System.Windows.Forms.GroupBox();
            this.lstbxCoffees = new System.Windows.Forms.ListBox();
            this.lblCoffees = new System.Windows.Forms.Label();
            this.btnAddCoffee = new System.Windows.Forms.Button();
            this.btnEditCoffee = new System.Windows.Forms.Button();
            this.btnDeleteCoffee = new System.Windows.Forms.Button();
            this.btnCloseBeans = new System.Windows.Forms.Button();
            this.rbtnSortName = new System.Windows.Forms.RadioButton();
            this.rbtnSortDate = new System.Windows.Forms.RadioButton();
            this.gpbxSorting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBeanType
            // 
            this.lblBeanType.AutoSize = true;
            this.lblBeanType.Location = new System.Drawing.Point(13, 20);
            this.lblBeanType.Name = "lblBeanType";
            this.lblBeanType.Size = new System.Drawing.Size(59, 13);
            this.lblBeanType.TabIndex = 0;
            this.lblBeanType.Text = "Bean Type";
            // 
            // lblRoastType
            // 
            this.lblRoastType.AutoSize = true;
            this.lblRoastType.Location = new System.Drawing.Point(13, 44);
            this.lblRoastType.Name = "lblRoastType";
            this.lblRoastType.Size = new System.Drawing.Size(62, 13);
            this.lblRoastType.TabIndex = 1;
            this.lblRoastType.Text = "Roast Type";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(13, 69);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity (grams)";
            // 
            // txtbxBeanType
            // 
            this.txtbxBeanType.Location = new System.Drawing.Point(103, 17);
            this.txtbxBeanType.Name = "txtbxBeanType";
            this.txtbxBeanType.Size = new System.Drawing.Size(115, 20);
            this.txtbxBeanType.TabIndex = 3;
            // 
            // txtbxRoastType
            // 
            this.txtbxRoastType.Location = new System.Drawing.Point(103, 41);
            this.txtbxRoastType.Name = "txtbxRoastType";
            this.txtbxRoastType.Size = new System.Drawing.Size(115, 20);
            this.txtbxRoastType.TabIndex = 4;
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.Location = new System.Drawing.Point(103, 65);
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.Size = new System.Drawing.Size(115, 20);
            this.txtbxQuantity.TabIndex = 5;
            // 
            // lblCountryOfOrigin
            // 
            this.lblCountryOfOrigin.AutoSize = true;
            this.lblCountryOfOrigin.Location = new System.Drawing.Point(12, 94);
            this.lblCountryOfOrigin.Name = "lblCountryOfOrigin";
            this.lblCountryOfOrigin.Size = new System.Drawing.Size(85, 13);
            this.lblCountryOfOrigin.TabIndex = 6;
            this.lblCountryOfOrigin.Text = "Country of Origin";
            // 
            // txtbxCountryofOrigin
            // 
            this.txtbxCountryofOrigin.Location = new System.Drawing.Point(103, 91);
            this.txtbxCountryofOrigin.Name = "txtbxCountryofOrigin";
            this.txtbxCountryofOrigin.Size = new System.Drawing.Size(115, 20);
            this.txtbxCountryofOrigin.TabIndex = 7;
            // 
            // gpbxSorting
            // 
            this.gpbxSorting.Controls.Add(this.rbtnSortDate);
            this.gpbxSorting.Controls.Add(this.rbtnSortName);
            this.gpbxSorting.Location = new System.Drawing.Point(251, 24);
            this.gpbxSorting.Name = "gpbxSorting";
            this.gpbxSorting.Size = new System.Drawing.Size(157, 74);
            this.gpbxSorting.TabIndex = 8;
            this.gpbxSorting.TabStop = false;
            this.gpbxSorting.Text = "Sort By";
            // 
            // lstbxCoffees
            // 
            this.lstbxCoffees.FormattingEnabled = true;
            this.lstbxCoffees.Location = new System.Drawing.Point(12, 135);
            this.lstbxCoffees.Name = "lstbxCoffees";
            this.lstbxCoffees.Size = new System.Drawing.Size(276, 108);
            this.lstbxCoffees.TabIndex = 9;
            // 
            // lblCoffees
            // 
            this.lblCoffees.AutoSize = true;
            this.lblCoffees.Location = new System.Drawing.Point(12, 119);
            this.lblCoffees.Name = "lblCoffees";
            this.lblCoffees.Size = new System.Drawing.Size(43, 13);
            this.lblCoffees.TabIndex = 10;
            this.lblCoffees.Text = "Coffees";
            // 
            // btnAddCoffee
            // 
            this.btnAddCoffee.Location = new System.Drawing.Point(323, 135);
            this.btnAddCoffee.Name = "btnAddCoffee";
            this.btnAddCoffee.Size = new System.Drawing.Size(75, 23);
            this.btnAddCoffee.TabIndex = 11;
            this.btnAddCoffee.Text = "Add";
            this.btnAddCoffee.UseVisualStyleBackColor = true;
            // 
            // btnEditCoffee
            // 
            this.btnEditCoffee.Location = new System.Drawing.Point(323, 164);
            this.btnEditCoffee.Name = "btnEditCoffee";
            this.btnEditCoffee.Size = new System.Drawing.Size(75, 23);
            this.btnEditCoffee.TabIndex = 12;
            this.btnEditCoffee.Text = "Edit";
            this.btnEditCoffee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCoffee
            // 
            this.btnDeleteCoffee.Location = new System.Drawing.Point(323, 193);
            this.btnDeleteCoffee.Name = "btnDeleteCoffee";
            this.btnDeleteCoffee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCoffee.TabIndex = 13;
            this.btnDeleteCoffee.Text = "Delete";
            this.btnDeleteCoffee.UseVisualStyleBackColor = true;
            // 
            // btnCloseBeans
            // 
            this.btnCloseBeans.Location = new System.Drawing.Point(323, 222);
            this.btnCloseBeans.Name = "btnCloseBeans";
            this.btnCloseBeans.Size = new System.Drawing.Size(75, 23);
            this.btnCloseBeans.TabIndex = 14;
            this.btnCloseBeans.Text = "Close";
            this.btnCloseBeans.UseVisualStyleBackColor = true;
            // 
            // rbtnSortName
            // 
            this.rbtnSortName.AutoSize = true;
            this.rbtnSortName.Location = new System.Drawing.Point(34, 20);
            this.rbtnSortName.Name = "rbtnSortName";
            this.rbtnSortName.Size = new System.Drawing.Size(87, 17);
            this.rbtnSortName.TabIndex = 0;
            this.rbtnSortName.TabStop = true;
            this.rbtnSortName.Text = "Coffee Name";
            this.rbtnSortName.UseVisualStyleBackColor = true;
            // 
            // rbtnSortDate
            // 
            this.rbtnSortDate.AutoSize = true;
            this.rbtnSortDate.Location = new System.Drawing.Point(34, 43);
            this.rbtnSortDate.Name = "rbtnSortDate";
            this.rbtnSortDate.Size = new System.Drawing.Size(93, 17);
            this.rbtnSortDate.TabIndex = 1;
            this.rbtnSortDate.TabStop = true;
            this.rbtnSortDate.Text = "Date of Listing";
            this.rbtnSortDate.UseVisualStyleBackColor = true;
            // 
            // frmBeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.btnCloseBeans);
            this.Controls.Add(this.btnDeleteCoffee);
            this.Controls.Add(this.btnEditCoffee);
            this.Controls.Add(this.btnAddCoffee);
            this.Controls.Add(this.lblCoffees);
            this.Controls.Add(this.lstbxCoffees);
            this.Controls.Add(this.gpbxSorting);
            this.Controls.Add(this.txtbxCountryofOrigin);
            this.Controls.Add(this.lblCountryOfOrigin);
            this.Controls.Add(this.txtbxQuantity);
            this.Controls.Add(this.txtbxRoastType);
            this.Controls.Add(this.txtbxBeanType);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblRoastType);
            this.Controls.Add(this.lblBeanType);
            this.Name = "frmBeans";
            this.Text = "Beans";
            this.gpbxSorting.ResumeLayout(false);
            this.gpbxSorting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeanType;
        private System.Windows.Forms.Label lblRoastType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtbxBeanType;
        private System.Windows.Forms.TextBox txtbxRoastType;
        private System.Windows.Forms.TextBox txtbxQuantity;
        private System.Windows.Forms.Label lblCountryOfOrigin;
        private System.Windows.Forms.TextBox txtbxCountryofOrigin;
        private System.Windows.Forms.GroupBox gpbxSorting;
        private System.Windows.Forms.RadioButton rbtnSortDate;
        private System.Windows.Forms.RadioButton rbtnSortName;
        private System.Windows.Forms.ListBox lstbxCoffees;
        private System.Windows.Forms.Label lblCoffees;
        private System.Windows.Forms.Button btnAddCoffee;
        private System.Windows.Forms.Button btnEditCoffee;
        private System.Windows.Forms.Button btnDeleteCoffee;
        private System.Windows.Forms.Button btnCloseBeans;
    }
}