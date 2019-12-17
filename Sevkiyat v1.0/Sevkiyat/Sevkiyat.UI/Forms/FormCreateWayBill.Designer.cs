namespace Sevkiyat.UI
{
    partial class FormCreateWayBill
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
            this.lbl_driver = new System.Windows.Forms.Label();
            this.lbl_vechile = new System.Windows.Forms.Label();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.lbl_shipmentDate = new System.Windows.Forms.Label();
            this.lbl_deliveryDate = new System.Windows.Forms.Label();
            this.lbl_billType = new System.Windows.Forms.Label();
            this.cmb_driver = new System.Windows.Forms.ComboBox();
            this.cmb_vechile = new System.Windows.Forms.ComboBox();
            this.cmb_receiver = new System.Windows.Forms.ComboBox();
            this.dtp_shipmentDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_billType = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cmb_sender = new System.Windows.Forms.ComboBox();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_driver
            // 
            this.lbl_driver.AutoSize = true;
            this.lbl_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_driver.Location = new System.Drawing.Point(50, 30);
            this.lbl_driver.Name = "lbl_driver";
            this.lbl_driver.Size = new System.Drawing.Size(52, 17);
            this.lbl_driver.TabIndex = 0;
            this.lbl_driver.Text = "Driver";
            // 
            // lbl_vechile
            // 
            this.lbl_vechile.AutoSize = true;
            this.lbl_vechile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vechile.Location = new System.Drawing.Point(50, 80);
            this.lbl_vechile.Name = "lbl_vechile";
            this.lbl_vechile.Size = new System.Drawing.Size(61, 17);
            this.lbl_vechile.TabIndex = 1;
            this.lbl_vechile.Text = "Vechile";
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_receiver.Location = new System.Drawing.Point(50, 130);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(72, 17);
            this.lbl_receiver.TabIndex = 3;
            this.lbl_receiver.Text = "Receiver";
            // 
            // lbl_shipmentDate
            // 
            this.lbl_shipmentDate.AutoSize = true;
            this.lbl_shipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shipmentDate.Location = new System.Drawing.Point(50, 230);
            this.lbl_shipmentDate.Name = "lbl_shipmentDate";
            this.lbl_shipmentDate.Size = new System.Drawing.Size(114, 17);
            this.lbl_shipmentDate.TabIndex = 4;
            this.lbl_shipmentDate.Text = "Shipment Date";
            // 
            // lbl_deliveryDate
            // 
            this.lbl_deliveryDate.AutoSize = true;
            this.lbl_deliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deliveryDate.Location = new System.Drawing.Point(50, 280);
            this.lbl_deliveryDate.Name = "lbl_deliveryDate";
            this.lbl_deliveryDate.Size = new System.Drawing.Size(106, 17);
            this.lbl_deliveryDate.TabIndex = 5;
            this.lbl_deliveryDate.Text = "Delivery Date";
            // 
            // lbl_billType
            // 
            this.lbl_billType.AutoSize = true;
            this.lbl_billType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_billType.Location = new System.Drawing.Point(50, 330);
            this.lbl_billType.Name = "lbl_billType";
            this.lbl_billType.Size = new System.Drawing.Size(71, 17);
            this.lbl_billType.TabIndex = 6;
            this.lbl_billType.Text = "Bill Type";
            // 
            // cmb_driver
            // 
            this.cmb_driver.FormattingEnabled = true;
            this.cmb_driver.Location = new System.Drawing.Point(230, 30);
            this.cmb_driver.Name = "cmb_driver";
            this.cmb_driver.Size = new System.Drawing.Size(121, 21);
            this.cmb_driver.TabIndex = 8;
            // 
            // cmb_vechile
            // 
            this.cmb_vechile.FormattingEnabled = true;
            this.cmb_vechile.Location = new System.Drawing.Point(230, 80);
            this.cmb_vechile.Name = "cmb_vechile";
            this.cmb_vechile.Size = new System.Drawing.Size(121, 21);
            this.cmb_vechile.TabIndex = 9;
            // 
            // cmb_receiver
            // 
            this.cmb_receiver.FormattingEnabled = true;
            this.cmb_receiver.Location = new System.Drawing.Point(230, 130);
            this.cmb_receiver.Name = "cmb_receiver";
            this.cmb_receiver.Size = new System.Drawing.Size(121, 21);
            this.cmb_receiver.TabIndex = 10;
            // 
            // dtp_shipmentDate
            // 
            this.dtp_shipmentDate.Location = new System.Drawing.Point(230, 230);
            this.dtp_shipmentDate.Name = "dtp_shipmentDate";
            this.dtp_shipmentDate.Size = new System.Drawing.Size(121, 20);
            this.dtp_shipmentDate.TabIndex = 11;
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.Location = new System.Drawing.Point(230, 280);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(121, 20);
            this.dtp_deliveryDate.TabIndex = 12;
            // 
            // cmb_billType
            // 
            this.cmb_billType.FormattingEnabled = true;
            this.cmb_billType.Items.AddRange(new object[] {
            "Entry",
            "Out"});
            this.cmb_billType.Location = new System.Drawing.Point(230, 330);
            this.cmb_billType.Name = "cmb_billType";
            this.cmb_billType.Size = new System.Drawing.Size(121, 21);
            this.cmb_billType.TabIndex = 13;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(50, 380);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 25);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirm.Location = new System.Drawing.Point(230, 380);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(120, 25);
            this.btn_confirm.TabIndex = 15;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // cmb_sender
            // 
            this.cmb_sender.FormattingEnabled = true;
            this.cmb_sender.Location = new System.Drawing.Point(230, 180);
            this.cmb_sender.Name = "cmb_sender";
            this.cmb_sender.Size = new System.Drawing.Size(121, 21);
            this.cmb_sender.TabIndex = 17;
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sender.Location = new System.Drawing.Point(50, 180);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(60, 17);
            this.lbl_sender.TabIndex = 16;
            this.lbl_sender.Text = "Sender";
            // 
            // FormCreateWayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 427);
            this.Controls.Add(this.cmb_sender);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cmb_billType);
            this.Controls.Add(this.dtp_deliveryDate);
            this.Controls.Add(this.dtp_shipmentDate);
            this.Controls.Add(this.cmb_receiver);
            this.Controls.Add(this.cmb_vechile);
            this.Controls.Add(this.cmb_driver);
            this.Controls.Add(this.lbl_billType);
            this.Controls.Add(this.lbl_deliveryDate);
            this.Controls.Add(this.lbl_shipmentDate);
            this.Controls.Add(this.lbl_receiver);
            this.Controls.Add(this.lbl_vechile);
            this.Controls.Add(this.lbl_driver);
            this.Name = "FormCreateWayBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Waybill";
            this.Load += new System.EventHandler(this.FormCreateWayBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_driver;
        private System.Windows.Forms.Label lbl_vechile;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.Label lbl_shipmentDate;
        private System.Windows.Forms.Label lbl_deliveryDate;
        private System.Windows.Forms.Label lbl_billType;
        private System.Windows.Forms.ComboBox cmb_driver;
        private System.Windows.Forms.ComboBox cmb_vechile;
        private System.Windows.Forms.ComboBox cmb_receiver;
        private System.Windows.Forms.DateTimePicker dtp_shipmentDate;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.ComboBox cmb_billType;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cmb_sender;
        private System.Windows.Forms.Label lbl_sender;
    }
}