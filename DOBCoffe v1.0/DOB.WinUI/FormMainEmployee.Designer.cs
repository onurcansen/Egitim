namespace DOB.WinUI
{
    partial class FormMainEmployee
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasswordChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRejcet = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.productToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.OrderToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerListToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.customerToolStripMenuItem.Text = "Müsteriler";
            // 
            // CustomerListToolStripMenuItem
            // 
            this.CustomerListToolStripMenuItem.Name = "CustomerListToolStripMenuItem";
            this.CustomerListToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.CustomerListToolStripMenuItem.Text = "Tüm Müşterileri Listele";
            this.CustomerListToolStripMenuItem.Click += new System.EventHandler(this.CustomerListToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductAddToolStripMenuItem,
            this.ProductListToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.productToolStripMenuItem.Text = "Ürünler";
            // 
            // ProductAddToolStripMenuItem
            // 
            this.ProductAddToolStripMenuItem.Name = "ProductAddToolStripMenuItem";
            this.ProductAddToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.ProductAddToolStripMenuItem.Text = "Ürün Ekle";
            this.ProductAddToolStripMenuItem.Click += new System.EventHandler(this.ProductAddToolStripMenuItem_Click);
            // 
            // ProductListToolStripMenuItem
            // 
            this.ProductListToolStripMenuItem.Name = "ProductListToolStripMenuItem";
            this.ProductListToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.ProductListToolStripMenuItem.Text = "Tüm Ürünleri Listele";
            this.ProductListToolStripMenuItem.Click += new System.EventHandler(this.ProductListToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StockAddToolStripMenuItem,
            this.StockListToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.stockToolStripMenuItem.Text = "Stok";
            // 
            // StockAddToolStripMenuItem
            // 
            this.StockAddToolStripMenuItem.Name = "StockAddToolStripMenuItem";
            this.StockAddToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.StockAddToolStripMenuItem.Text = "Stok Ekle";
            this.StockAddToolStripMenuItem.Click += new System.EventHandler(this.StockAddToolStripMenuItem_Click);
            // 
            // StockListToolStripMenuItem
            // 
            this.StockListToolStripMenuItem.Name = "StockListToolStripMenuItem";
            this.StockListToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.StockListToolStripMenuItem.Text = "Stokdaki Ürünleri Listele";
            this.StockListToolStripMenuItem.Click += new System.EventHandler(this.StockListToolStripMenuItem_Click);
            // 
            // OrderToolStripMenuItem
            // 
            this.OrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderAddToolStripMenuItem,
            this.OrderListToolStripMenuItem});
            this.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem";
            this.OrderToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.OrderToolStripMenuItem.Text = "Satış";
            // 
            // OrderAddToolStripMenuItem
            // 
            this.OrderAddToolStripMenuItem.Name = "OrderAddToolStripMenuItem";
            this.OrderAddToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.OrderAddToolStripMenuItem.Text = "Satış İşlemi";
            this.OrderAddToolStripMenuItem.Click += new System.EventHandler(this.OrderAddToolStripMenuItem_Click);
            // 
            // OrderListToolStripMenuItem
            // 
            this.OrderListToolStripMenuItem.Name = "OrderListToolStripMenuItem";
            this.OrderListToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.OrderListToolStripMenuItem.Text = "Tüm İşlemleri Listele";
            this.OrderListToolStripMenuItem.Click += new System.EventHandler(this.OrderListToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeAddToolStripMenuItem,
            this.EmployeeListToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.employeeToolStripMenuItem.Text = "Personeller";
            // 
            // EmployeeAddToolStripMenuItem
            // 
            this.EmployeeAddToolStripMenuItem.Name = "EmployeeAddToolStripMenuItem";
            this.EmployeeAddToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.EmployeeAddToolStripMenuItem.Text = "Personel Ekle";
            this.EmployeeAddToolStripMenuItem.Click += new System.EventHandler(this.EmployeeAddToolStripMenuItem_Click);
            // 
            // EmployeeListToolStripMenuItem
            // 
            this.EmployeeListToolStripMenuItem.Name = "EmployeeListToolStripMenuItem";
            this.EmployeeListToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.EmployeeListToolStripMenuItem.Text = "Tüm Personelleri Listele";
            this.EmployeeListToolStripMenuItem.Click += new System.EventHandler(this.EmployeeListToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.DisplayToolStripMenuItem,
            this.UpdateToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.accountToolStripMenuItem.Text = "Hesabım";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasswordChangeToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.SettingsToolStripMenuItem.Text = "Ayarlar";
            // 
            // PasswordChangeToolStripMenuItem
            // 
            this.PasswordChangeToolStripMenuItem.Name = "PasswordChangeToolStripMenuItem";
            this.PasswordChangeToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.PasswordChangeToolStripMenuItem.Text = "Sifre Değiştir";
            this.PasswordChangeToolStripMenuItem.Click += new System.EventHandler(this.PasswordChangeToolStripMenuItem_Click);
            // 
            // DisplayToolStripMenuItem
            // 
            this.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
            this.DisplayToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.DisplayToolStripMenuItem.Text = "Görüntüle";
            this.DisplayToolStripMenuItem.Click += new System.EventHandler(this.DisplayToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.UpdateToolStripMenuItem.Text = "Güncelle";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 564);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(79, 26);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Onayla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnRejcet
            // 
            this.btnRejcet.Location = new System.Drawing.Point(710, 564);
            this.btnRejcet.Name = "btnRejcet";
            this.btnRejcet.Size = new System.Drawing.Size(75, 23);
            this.btnRejcet.TabIndex = 2;
            this.btnRejcet.Text = "Reddet/Sil";
            this.btnRejcet.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(0, 36);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(797, 522);
            this.dgvOrders.TabIndex = 3;
            // 
            // FormMainEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DOB.WinUI.Properties.Resources.logotrans;
            this.ClientSize = new System.Drawing.Size(797, 602);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnRejcet);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainEmployee";
            this.Text = "Personel Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasswordChangeToolStripMenuItem;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRejcet;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
    }
}