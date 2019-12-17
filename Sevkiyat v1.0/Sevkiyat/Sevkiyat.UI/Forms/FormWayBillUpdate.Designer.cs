namespace Sevkiyat.UI
{
    partial class FormWayBillUpdate
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
            this.lw_products = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmb_sender = new System.Windows.Forms.ComboBox();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cmb_billType = new System.Windows.Forms.ComboBox();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_shipmentDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_receiver = new System.Windows.Forms.ComboBox();
            this.cmb_product = new System.Windows.Forms.ComboBox();
            this.cmb_vechile = new System.Windows.Forms.ComboBox();
            this.cmb_driver = new System.Windows.Forms.ComboBox();
            this.lbl_billType = new System.Windows.Forms.Label();
            this.lbl_deliveryDate = new System.Windows.Forms.Label();
            this.lbl_shipmentDate = new System.Windows.Forms.Label();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_vechile = new System.Windows.Forms.Label();
            this.lbl_driver = new System.Windows.Forms.Label();
            this.txtWaybillID = new System.Windows.Forms.TextBox();
            this.lblWaybillID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn_update_Add = new System.Windows.Forms.Button();
            this.nud_adet = new System.Windows.Forms.NumericUpDown();
            this.chc_delivery = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_senderCompany = new System.Windows.Forms.TextBox();
            this.txt_senderPhone = new System.Windows.Forms.TextBox();
            this.txt_senderAdress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_receiverAdress = new System.Windows.Forms.TextBox();
            this.txt_receiverPhone = new System.Windows.Forms.TextBox();
            this.txt_receiverCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lw_products
            // 
            this.lw_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3});
            this.lw_products.GridLines = true;
            this.lw_products.HideSelection = false;
            this.lw_products.Location = new System.Drawing.Point(11, 322);
            this.lw_products.Margin = new System.Windows.Forms.Padding(2);
            this.lw_products.Name = "lw_products";
            this.lw_products.Size = new System.Drawing.Size(876, 204);
            this.lw_products.TabIndex = 41;
            this.lw_products.UseCompatibleStateImageBehavior = false;
            this.lw_products.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 348;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Miktar Cinsi";
            this.columnHeader4.Width = 283;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 161;
            // 
            // cmb_sender
            // 
            this.cmb_sender.FormattingEnabled = true;
            this.cmb_sender.Location = new System.Drawing.Point(247, 69);
            this.cmb_sender.Name = "cmb_sender";
            this.cmb_sender.Size = new System.Drawing.Size(121, 21);
            this.cmb_sender.TabIndex = 38;
            this.cmb_sender.SelectedIndexChanged += new System.EventHandler(this.Cmb_sender_SelectedIndexChanged);
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sender.Location = new System.Drawing.Point(11, 69);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(78, 17);
            this.lbl_sender.TabIndex = 37;
            this.lbl_sender.Text = "Gönderici";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(767, 252);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(120, 25);
            this.btn_kaydet.TabIndex = 36;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // cmb_billType
            // 
            this.cmb_billType.FormattingEnabled = true;
            this.cmb_billType.Items.AddRange(new object[] {
            "Entry",
            "Out"});
            this.cmb_billType.Location = new System.Drawing.Point(247, 42);
            this.cmb_billType.Name = "cmb_billType";
            this.cmb_billType.Size = new System.Drawing.Size(121, 21);
            this.cmb_billType.TabIndex = 33;
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.Location = new System.Drawing.Point(629, 220);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(121, 20);
            this.dtp_deliveryDate.TabIndex = 32;
            // 
            // dtp_shipmentDate
            // 
            this.dtp_shipmentDate.Location = new System.Drawing.Point(247, 216);
            this.dtp_shipmentDate.Name = "dtp_shipmentDate";
            this.dtp_shipmentDate.Size = new System.Drawing.Size(121, 20);
            this.dtp_shipmentDate.TabIndex = 31;
            // 
            // cmb_receiver
            // 
            this.cmb_receiver.FormattingEnabled = true;
            this.cmb_receiver.Location = new System.Drawing.Point(629, 66);
            this.cmb_receiver.Name = "cmb_receiver";
            this.cmb_receiver.Size = new System.Drawing.Size(121, 21);
            this.cmb_receiver.TabIndex = 30;
            this.cmb_receiver.SelectedIndexChanged += new System.EventHandler(this.Cmb_receiver_SelectedIndexChanged);
            // 
            // cmb_product
            // 
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Location = new System.Drawing.Point(512, 255);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(248, 21);
            this.cmb_product.TabIndex = 29;
            // 
            // cmb_vechile
            // 
            this.cmb_vechile.FormattingEnabled = true;
            this.cmb_vechile.Location = new System.Drawing.Point(247, 287);
            this.cmb_vechile.Name = "cmb_vechile";
            this.cmb_vechile.Size = new System.Drawing.Size(121, 21);
            this.cmb_vechile.TabIndex = 28;
            // 
            // cmb_driver
            // 
            this.cmb_driver.FormattingEnabled = true;
            this.cmb_driver.Location = new System.Drawing.Point(247, 251);
            this.cmb_driver.Name = "cmb_driver";
            this.cmb_driver.Size = new System.Drawing.Size(121, 21);
            this.cmb_driver.TabIndex = 27;
            // 
            // lbl_billType
            // 
            this.lbl_billType.AutoSize = true;
            this.lbl_billType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_billType.Location = new System.Drawing.Point(11, 42);
            this.lbl_billType.Name = "lbl_billType";
            this.lbl_billType.Size = new System.Drawing.Size(92, 17);
            this.lbl_billType.TabIndex = 26;
            this.lbl_billType.Text = "İrsaliye Tipi";
            // 
            // lbl_deliveryDate
            // 
            this.lbl_deliveryDate.AutoSize = true;
            this.lbl_deliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deliveryDate.Location = new System.Drawing.Point(457, 220);
            this.lbl_deliveryDate.Name = "lbl_deliveryDate";
            this.lbl_deliveryDate.Size = new System.Drawing.Size(103, 17);
            this.lbl_deliveryDate.TabIndex = 25;
            this.lbl_deliveryDate.Text = "Ulaşım Tarihi";
            // 
            // lbl_shipmentDate
            // 
            this.lbl_shipmentDate.AutoSize = true;
            this.lbl_shipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shipmentDate.Location = new System.Drawing.Point(11, 220);
            this.lbl_shipmentDate.Name = "lbl_shipmentDate";
            this.lbl_shipmentDate.Size = new System.Drawing.Size(113, 17);
            this.lbl_shipmentDate.TabIndex = 24;
            this.lbl_shipmentDate.Text = "Gönderi Tarihi";
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_receiver.Location = new System.Drawing.Point(457, 69);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(38, 17);
            this.lbl_receiver.TabIndex = 23;
            this.lbl_receiver.Text = "Alıcı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(458, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ürün";
            // 
            // lbl_vechile
            // 
            this.lbl_vechile.AutoSize = true;
            this.lbl_vechile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vechile.Location = new System.Drawing.Point(11, 287);
            this.lbl_vechile.Name = "lbl_vechile";
            this.lbl_vechile.Size = new System.Drawing.Size(41, 17);
            this.lbl_vechile.TabIndex = 22;
            this.lbl_vechile.Text = "Araç";
            // 
            // lbl_driver
            // 
            this.lbl_driver.AutoSize = true;
            this.lbl_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_driver.Location = new System.Drawing.Point(11, 255);
            this.lbl_driver.Name = "lbl_driver";
            this.lbl_driver.Size = new System.Drawing.Size(59, 17);
            this.lbl_driver.TabIndex = 20;
            this.lbl_driver.Text = "Sürücü";
            // 
            // txtWaybillID
            // 
            this.txtWaybillID.Location = new System.Drawing.Point(180, 12);
            this.txtWaybillID.Name = "txtWaybillID";
            this.txtWaybillID.Size = new System.Drawing.Size(188, 20);
            this.txtWaybillID.TabIndex = 43;
            // 
            // lblWaybillID
            // 
            this.lblWaybillID.AutoSize = true;
            this.lblWaybillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaybillID.Location = new System.Drawing.Point(11, 9);
            this.lblWaybillID.Name = "lblWaybillID";
            this.lblWaybillID.Size = new System.Drawing.Size(105, 17);
            this.lblWaybillID.TabIndex = 44;
            this.lblWaybillID.Text = "İrsaliye kodu:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(767, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 25);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Seçili Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btn_update_Add
            // 
            this.btn_update_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update_Add.Location = new System.Drawing.Point(767, 546);
            this.btn_update_Add.Name = "btn_update_Add";
            this.btn_update_Add.Size = new System.Drawing.Size(120, 25);
            this.btn_update_Add.TabIndex = 46;
            this.btn_update_Add.Text = "Kaydet";
            this.btn_update_Add.UseVisualStyleBackColor = true;
            this.btn_update_Add.Click += new System.EventHandler(this.Btn_update_Add_Click);
            // 
            // nud_adet
            // 
            this.nud_adet.Location = new System.Drawing.Point(640, 284);
            this.nud_adet.Name = "nud_adet";
            this.nud_adet.Size = new System.Drawing.Size(120, 20);
            this.nud_adet.TabIndex = 49;
            // 
            // chc_delivery
            // 
            this.chc_delivery.AutoSize = true;
            this.chc_delivery.Location = new System.Drawing.Point(777, 222);
            this.chc_delivery.Name = "chc_delivery";
            this.chc_delivery.Size = new System.Drawing.Size(86, 17);
            this.chc_delivery.TabIndex = 50;
            this.chc_delivery.Text = "Ulaşım Tarihi";
            this.chc_delivery.UseVisualStyleBackColor = true;
            this.chc_delivery.CheckedChanged += new System.EventHandler(this.Chc_delivery_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_senderAdress);
            this.groupBox1.Controls.Add(this.txt_senderPhone);
            this.groupBox1.Controls.Add(this.txt_senderCompany);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 109);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Muhattap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şirket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adres";
            // 
            // txt_senderCompany
            // 
            this.txt_senderCompany.Location = new System.Drawing.Point(69, 17);
            this.txt_senderCompany.Name = "txt_senderCompany";
            this.txt_senderCompany.ReadOnly = true;
            this.txt_senderCompany.Size = new System.Drawing.Size(100, 20);
            this.txt_senderCompany.TabIndex = 5;
            // 
            // txt_senderPhone
            // 
            this.txt_senderPhone.Location = new System.Drawing.Point(248, 17);
            this.txt_senderPhone.Name = "txt_senderPhone";
            this.txt_senderPhone.ReadOnly = true;
            this.txt_senderPhone.Size = new System.Drawing.Size(100, 20);
            this.txt_senderPhone.TabIndex = 6;
            // 
            // txt_senderAdress
            // 
            this.txt_senderAdress.Location = new System.Drawing.Point(69, 68);
            this.txt_senderAdress.Multiline = true;
            this.txt_senderAdress.Name = "txt_senderAdress";
            this.txt_senderAdress.ReadOnly = true;
            this.txt_senderAdress.Size = new System.Drawing.Size(279, 29);
            this.txt_senderAdress.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_receiverAdress);
            this.groupBox2.Controls.Add(this.txt_receiverPhone);
            this.groupBox2.Controls.Add(this.txt_receiverCompany);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(460, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 109);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Muhattap";
            // 
            // txt_receiverAdress
            // 
            this.txt_receiverAdress.Location = new System.Drawing.Point(69, 68);
            this.txt_receiverAdress.Multiline = true;
            this.txt_receiverAdress.Name = "txt_receiverAdress";
            this.txt_receiverAdress.ReadOnly = true;
            this.txt_receiverAdress.Size = new System.Drawing.Size(279, 29);
            this.txt_receiverAdress.TabIndex = 7;
            // 
            // txt_receiverPhone
            // 
            this.txt_receiverPhone.Location = new System.Drawing.Point(248, 17);
            this.txt_receiverPhone.Name = "txt_receiverPhone";
            this.txt_receiverPhone.ReadOnly = true;
            this.txt_receiverPhone.Size = new System.Drawing.Size(100, 20);
            this.txt_receiverPhone.TabIndex = 6;
            // 
            // txt_receiverCompany
            // 
            this.txt_receiverCompany.Location = new System.Drawing.Point(69, 17);
            this.txt_receiverCompany.Name = "txt_receiverCompany";
            this.txt_receiverCompany.ReadOnly = true;
            this.txt_receiverCompany.Size = new System.Drawing.Size(100, 20);
            this.txt_receiverCompany.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Şirket";
            // 
            // FormWayBillUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chc_delivery);
            this.Controls.Add(this.nud_adet);
            this.Controls.Add(this.btn_update_Add);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblWaybillID);
            this.Controls.Add(this.txtWaybillID);
            this.Controls.Add(this.lw_products);
            this.Controls.Add(this.cmb_sender);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.cmb_billType);
            this.Controls.Add(this.dtp_deliveryDate);
            this.Controls.Add(this.dtp_shipmentDate);
            this.Controls.Add(this.cmb_receiver);
            this.Controls.Add(this.cmb_product);
            this.Controls.Add(this.cmb_vechile);
            this.Controls.Add(this.cmb_driver);
            this.Controls.Add(this.lbl_billType);
            this.Controls.Add(this.lbl_deliveryDate);
            this.Controls.Add(this.lbl_shipmentDate);
            this.Controls.Add(this.lbl_receiver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_vechile);
            this.Controls.Add(this.lbl_driver);
            this.Name = "FormWayBillUpdate";
            this.Text = "FormWayBillUpdate";
            this.Load += new System.EventHandler(this.FormWayBillUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lw_products;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cmb_sender;
        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ComboBox cmb_billType;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.DateTimePicker dtp_shipmentDate;
        private System.Windows.Forms.ComboBox cmb_receiver;
        private System.Windows.Forms.ComboBox cmb_product;
        private System.Windows.Forms.ComboBox cmb_vechile;
        private System.Windows.Forms.ComboBox cmb_driver;
        private System.Windows.Forms.Label lbl_billType;
        private System.Windows.Forms.Label lbl_deliveryDate;
        private System.Windows.Forms.Label lbl_shipmentDate;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_vechile;
        private System.Windows.Forms.Label lbl_driver;
        private System.Windows.Forms.TextBox txtWaybillID;
        private System.Windows.Forms.Label lblWaybillID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn_update_Add;
        private System.Windows.Forms.NumericUpDown nud_adet;
        private System.Windows.Forms.CheckBox chc_delivery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_senderAdress;
        private System.Windows.Forms.TextBox txt_senderPhone;
        private System.Windows.Forms.TextBox txt_senderCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_receiverAdress;
        private System.Windows.Forms.TextBox txt_receiverPhone;
        private System.Windows.Forms.TextBox txt_receiverCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}