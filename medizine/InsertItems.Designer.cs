﻿namespace medizine
{
    partial class InsertItems
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertItems));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxNonExpiry = new System.Windows.Forms.CheckBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtWholeSalePrice = new System.Windows.Forms.TextBox();
            this.dateTimePickerExp = new System.Windows.Forms.DateTimePicker();
            this.txtQtyRemaining = new System.Windows.Forms.TextBox();
            this.txtQtySold = new System.Windows.Forms.TextBox();
            this.txtQtyAvailable = new System.Windows.Forms.TextBox();
            this.comboBoxPackSize = new System.Windows.Forms.ComboBox();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxGenericName = new System.Windows.Forms.ComboBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblUserName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(416, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory - Add Items";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 522);
            this.panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(411, 147);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 25);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnFind.Location = new System.Drawing.Point(411, 74);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(82, 25);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(411, 112);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 25);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit and save";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightGreen;
            this.btnInsert.Location = new System.Drawing.Point(411, 38);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(82, 25);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.checkBoxNonExpiry);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.txtRetailPrice);
            this.groupBox1.Controls.Add(this.txtWholeSalePrice);
            this.groupBox1.Controls.Add(this.dateTimePickerExp);
            this.groupBox1.Controls.Add(this.txtQtyRemaining);
            this.groupBox1.Controls.Add(this.txtQtySold);
            this.groupBox1.Controls.Add(this.txtQtyAvailable);
            this.groupBox1.Controls.Add(this.comboBoxPackSize);
            this.groupBox1.Controls.Add(this.comboBoxSupplier);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.comboBoxGenericName);
            this.groupBox1.Controls.Add(this.txtBrandName);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(379, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Items";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxNonExpiry
            // 
            this.checkBoxNonExpiry.AutoSize = true;
            this.checkBoxNonExpiry.Location = new System.Drawing.Point(274, 323);
            this.checkBoxNonExpiry.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxNonExpiry.Name = "checkBoxNonExpiry";
            this.checkBoxNonExpiry.Size = new System.Drawing.Size(91, 19);
            this.checkBoxNonExpiry.TabIndex = 11;
            this.checkBoxNonExpiry.Text = "Non - expiry";
            this.checkBoxNonExpiry.UseVisualStyleBackColor = true;
            this.checkBoxNonExpiry.Click += new System.EventHandler(this.checkBoxNonExpiry_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(94, 439);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(164, 21);
            this.txtDiscount.TabIndex = 14;
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Location = new System.Drawing.Point(94, 401);
            this.txtRetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(164, 21);
            this.txtRetailPrice.TabIndex = 13;
            // 
            // txtWholeSalePrice
            // 
            this.txtWholeSalePrice.Location = new System.Drawing.Point(94, 358);
            this.txtWholeSalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtWholeSalePrice.Name = "txtWholeSalePrice";
            this.txtWholeSalePrice.Size = new System.Drawing.Size(164, 21);
            this.txtWholeSalePrice.TabIndex = 12;
            // 
            // dateTimePickerExp
            // 
            this.dateTimePickerExp.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExp.Location = new System.Drawing.Point(94, 322);
            this.dateTimePickerExp.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerExp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerExp.Name = "dateTimePickerExp";
            this.dateTimePickerExp.Size = new System.Drawing.Size(164, 21);
            this.dateTimePickerExp.TabIndex = 10;
            this.dateTimePickerExp.Value = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            // 
            // txtQtyRemaining
            // 
            this.txtQtyRemaining.Location = new System.Drawing.Point(94, 286);
            this.txtQtyRemaining.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtyRemaining.Name = "txtQtyRemaining";
            this.txtQtyRemaining.Size = new System.Drawing.Size(164, 21);
            this.txtQtyRemaining.TabIndex = 9;
            // 
            // txtQtySold
            // 
            this.txtQtySold.Location = new System.Drawing.Point(94, 254);
            this.txtQtySold.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtySold.Name = "txtQtySold";
            this.txtQtySold.Size = new System.Drawing.Size(164, 21);
            this.txtQtySold.TabIndex = 8;
            // 
            // txtQtyAvailable
            // 
            this.txtQtyAvailable.Location = new System.Drawing.Point(94, 223);
            this.txtQtyAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtyAvailable.Name = "txtQtyAvailable";
            this.txtQtyAvailable.Size = new System.Drawing.Size(164, 21);
            this.txtQtyAvailable.TabIndex = 7;
            // 
            // comboBoxPackSize
            // 
            this.comboBoxPackSize.FormattingEnabled = true;
            this.comboBoxPackSize.Location = new System.Drawing.Point(94, 188);
            this.comboBoxPackSize.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPackSize.Name = "comboBoxPackSize";
            this.comboBoxPackSize.Size = new System.Drawing.Size(164, 23);
            this.comboBoxPackSize.TabIndex = 6;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(94, 154);
            this.comboBoxSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(164, 23);
            this.comboBoxSupplier.TabIndex = 5;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(94, 119);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(164, 23);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // comboBoxGenericName
            // 
            this.comboBoxGenericName.FormattingEnabled = true;
            this.comboBoxGenericName.Location = new System.Drawing.Point(94, 87);
            this.comboBoxGenericName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGenericName.Name = "comboBoxGenericName";
            this.comboBoxGenericName.Size = new System.Drawing.Size(164, 23);
            this.comboBoxGenericName.TabIndex = 3;
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(94, 57);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(164, 21);
            this.txtBrandName.TabIndex = 2;
            this.txtBrandName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrandName_KeyPress);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(94, 27);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(164, 21);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 443);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Discount (%)  : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 401);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "Retail\r\nPrice (Rs)  : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 358);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "WholeSale\r\nPrice (Rs)  : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 326);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Exp. Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 286);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Qty. Remaining :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Qty. Sold :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Qty. Available :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pack Size :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Supplier :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Generic Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Brand Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barcode:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblUserName.Location = new System.Drawing.Point(900, 65);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new System.Windows.Forms.Padding(0, 4, 8, 0);
            this.lblUserName.Size = new System.Drawing.Size(85, 23);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "username";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Right;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label16.Location = new System.Drawing.Point(848, 65);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 4, 8, 0);
            this.label16.Size = new System.Drawing.Size(52, 23);
            this.label16.TabIndex = 10;
            this.label16.Text = "User :";
            // 
            // InsertItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 587);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertItems";
            this.Text = "Minhaj Pharmacy - Insert Items";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxGenericName;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.CheckBox checkBoxNonExpiry;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtWholeSalePrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerExp;
        private System.Windows.Forms.TextBox txtQtyRemaining;
        private System.Windows.Forms.TextBox txtQtySold;
        private System.Windows.Forms.TextBox txtQtyAvailable;
        private System.Windows.Forms.ComboBox comboBoxPackSize;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label16;
    }
}