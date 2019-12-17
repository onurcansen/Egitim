namespace Sevkiyat.UI
{
    partial class FormProductAdd
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_pro_type = new System.Windows.Forms.Label();
            this.lbl_weigh = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmb_productType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_unitType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(133, 15);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(100, 20);
            this.txt_productName.TabIndex = 1;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(133, 86);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(100, 20);
            this.txt_weight.TabIndex = 3;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_productName.Location = new System.Drawing.Point(9, 18);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(63, 17);
            this.lbl_productName.TabIndex = 6;
            this.lbl_productName.Text = "Ürün Adı";
            // 
            // lbl_pro_type
            // 
            this.lbl_pro_type.AutoSize = true;
            this.lbl_pro_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pro_type.Location = new System.Drawing.Point(9, 54);
            this.lbl_pro_type.Name = "lbl_pro_type";
            this.lbl_pro_type.Size = new System.Drawing.Size(66, 17);
            this.lbl_pro_type.TabIndex = 7;
            this.lbl_pro_type.Text = "Ürün Tipi";
            // 
            // lbl_weigh
            // 
            this.lbl_weigh.AutoSize = true;
            this.lbl_weigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_weigh.Location = new System.Drawing.Point(9, 87);
            this.lbl_weigh.Name = "lbl_weigh";
            this.lbl_weigh.Size = new System.Drawing.Size(46, 17);
            this.lbl_weigh.TabIndex = 8;
            this.lbl_weigh.Text = "Ağırlık";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.Location = new System.Drawing.Point(157, 164);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 33);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Kaydet";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // cmb_productType
            // 
            this.cmb_productType.FormattingEnabled = true;
            this.cmb_productType.Location = new System.Drawing.Point(133, 52);
            this.cmb_productType.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_productType.Name = "cmb_productType";
            this.cmb_productType.Size = new System.Drawing.Size(100, 21);
            this.cmb_productType.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "BirimCinsi";
            // 
            // cmb_unitType
            // 
            this.cmb_unitType.FormattingEnabled = true;
            this.cmb_unitType.Location = new System.Drawing.Point(133, 119);
            this.cmb_unitType.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_unitType.Name = "cmb_unitType";
            this.cmb_unitType.Size = new System.Drawing.Size(100, 21);
            this.cmb_unitType.TabIndex = 11;
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 209);
            this.Controls.Add(this.cmb_unitType);
            this.Controls.Add(this.cmb_productType);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_weigh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_pro_type);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_productName);
            this.Name = "FormProductAdd";
            this.Text = "Product Add";
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_pro_type;
        private System.Windows.Forms.Label lbl_weigh;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_productType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_unitType;
    }
}

