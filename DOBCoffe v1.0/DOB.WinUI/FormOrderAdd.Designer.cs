namespace DOB.WinUI
{
    partial class FormOrderAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.grbShoppingcart = new System.Windows.Forms.GroupBox();
            this.lstshoppingcart = new System.Windows.Forms.ListBox();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.cmbproductype = new System.Windows.Forms.ComboBox();
            this.cmProductSub = new System.Windows.Forms.ComboBox();
            this.nudDrinks = new System.Windows.Forms.NumericUpDown();
            this.grpExtra = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnListBoxAdd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbShoppingcart.SuspendLayout();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).BeginInit();
            this.grpExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 63);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 33.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 55);
            this.label7.TabIndex = 1;
            this.label7.Text = "DOB Coffee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::DOB.WinUI.Properties.Resources._14b37d68_e1a9_43ef_8f08_3fd2293ba29b;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.cmbBranch);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevumuz :)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(81, 40);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(203, 20);
            this.dtpOrderDate.TabIndex = 1;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(81, 76);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(203, 21);
            this.cmbBranch.TabIndex = 0;
            // 
            // grbShoppingcart
            // 
            this.grbShoppingcart.Controls.Add(this.lstshoppingcart);
            this.grbShoppingcart.Location = new System.Drawing.Point(493, 81);
            this.grbShoppingcart.Name = "grbShoppingcart";
            this.grbShoppingcart.Size = new System.Drawing.Size(290, 395);
            this.grbShoppingcart.TabIndex = 2;
            this.grbShoppingcart.TabStop = false;
            this.grbShoppingcart.Text = "Sepetim";
            // 
            // lstshoppingcart
            // 
            this.lstshoppingcart.FormattingEnabled = true;
            this.lstshoppingcart.Location = new System.Drawing.Point(7, 20);
            this.lstshoppingcart.Name = "lstshoppingcart";
            this.lstshoppingcart.Size = new System.Drawing.Size(283, 368);
            this.lstshoppingcart.TabIndex = 0;
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.cmbproductype);
            this.grpProducts.Controls.Add(this.cmProductSub);
            this.grpProducts.Controls.Add(this.nudDrinks);
            this.grpProducts.Location = new System.Drawing.Point(6, 206);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(481, 141);
            this.grpProducts.TabIndex = 3;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Ürünler";
            // 
            // cmbproductype
            // 
            this.cmbproductype.FormattingEnabled = true;
            this.cmbproductype.Location = new System.Drawing.Point(28, 32);
            this.cmbproductype.Name = "cmbproductype";
            this.cmbproductype.Size = new System.Drawing.Size(121, 21);
            this.cmbproductype.TabIndex = 13;
            this.cmbproductype.SelectedIndexChanged += new System.EventHandler(this.Cmbproductype_SelectedIndexChanged);
            // 
            // cmProductSub
            // 
            this.cmProductSub.FormattingEnabled = true;
            this.cmProductSub.Location = new System.Drawing.Point(169, 33);
            this.cmProductSub.Name = "cmProductSub";
            this.cmProductSub.Size = new System.Drawing.Size(228, 21);
            this.cmProductSub.TabIndex = 11;
            // 
            // nudDrinks
            // 
            this.nudDrinks.Location = new System.Drawing.Point(403, 33);
            this.nudDrinks.Name = "nudDrinks";
            this.nudDrinks.Size = new System.Drawing.Size(59, 20);
            this.nudDrinks.TabIndex = 7;
            // 
            // grpExtra
            // 
            this.grpExtra.Controls.Add(this.comboBox2);
            this.grpExtra.Controls.Add(this.comboBox1);
            this.grpExtra.Controls.Add(this.label6);
            this.grpExtra.Controls.Add(this.label5);
            this.grpExtra.Location = new System.Drawing.Point(6, 353);
            this.grpExtra.Name = "grpExtra";
            this.grpExtra.Size = new System.Drawing.Size(481, 123);
            this.grpExtra.TabIndex = 4;
            this.grpExtra.TabStop = false;
            this.grpExtra.Text = "Extralar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Süt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shot";
            // 
            // btnListBoxAdd
            // 
            this.btnListBoxAdd.Location = new System.Drawing.Point(6, 481);
            this.btnListBoxAdd.Name = "btnListBoxAdd";
            this.btnListBoxAdd.Size = new System.Drawing.Size(138, 23);
            this.btnListBoxAdd.TabIndex = 5;
            this.btnListBoxAdd.Text = "Sepete Ekle";
            this.btnListBoxAdd.UseVisualStyleBackColor = true;
            this.btnListBoxAdd.Click += new System.EventHandler(this.BtnListBoxAdd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(645, 481);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(138, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Onayla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(76, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // FormOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 511);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnListBoxAdd);
            this.Controls.Add(this.grpExtra);
            this.Controls.Add(this.grpProducts);
            this.Controls.Add(this.grbShoppingcart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrderAdd";
            this.Text = "Siparis Ekle";
            this.Load += new System.EventHandler(this.FormOrderAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbShoppingcart.ResumeLayout(false);
            this.grpProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).EndInit();
            this.grpExtra.ResumeLayout(false);
            this.grpExtra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbShoppingcart;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.GroupBox grpExtra;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDrinks;
        private System.Windows.Forms.ComboBox cmProductSub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnListBoxAdd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstshoppingcart;
        private System.Windows.Forms.ComboBox cmbproductype;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}