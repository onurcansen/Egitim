namespace Sevkiyat.UI
{
    partial class FormVehicleList
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
            this.lstVehicles = new System.Windows.Forms.ListBox();
            this.lblVehicleInfo = new System.Windows.Forms.Label();
            this.lblPlate = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVehicles
            // 
            this.lstVehicles.FormattingEnabled = true;
            this.lstVehicles.Location = new System.Drawing.Point(20, 17);
            this.lstVehicles.Margin = new System.Windows.Forms.Padding(2);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(193, 316);
            this.lstVehicles.TabIndex = 0;
            this.lstVehicles.SelectedIndexChanged += new System.EventHandler(this.LstVehicles_SelectedIndexChanged);
            // 
            // lblVehicleInfo
            // 
            this.lblVehicleInfo.AutoSize = true;
            this.lblVehicleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVehicleInfo.Location = new System.Drawing.Point(292, 17);
            this.lblVehicleInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleInfo.Name = "lblVehicleInfo";
            this.lblVehicleInfo.Size = new System.Drawing.Size(86, 20);
            this.lblVehicleInfo.TabIndex = 1;
            this.lblVehicleInfo.Text = "Araç Bilgisi";
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlate.Location = new System.Drawing.Point(224, 73);
            this.lblPlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(43, 17);
            this.lblPlate.TabIndex = 2;
            this.lblPlate.Text = "Plaka";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCapacity.Location = new System.Drawing.Point(224, 133);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(63, 17);
            this.lblCapacity.TabIndex = 3;
            this.lblCapacity.Text = "Kapasite";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrand.Location = new System.Drawing.Point(224, 189);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(47, 17);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Marka";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(224, 247);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(284, 72);
            this.txtPlate.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.ReadOnly = true;
            this.txtPlate.Size = new System.Drawing.Size(145, 20);
            this.txtPlate.TabIndex = 6;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(284, 133);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(145, 20);
            this.txtCapacity.TabIndex = 7;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(284, 189);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(145, 20);
            this.txtBrand.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(284, 247);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(145, 20);
            this.txtModel.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(310, 300);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FormVehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 389);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.lblVehicleInfo);
            this.Controls.Add(this.lstVehicles);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVehicleList";
            this.Text = "FormVehicleList";
            this.Load += new System.EventHandler(this.FormVehicleList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVehicles;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnUpdate;
    }
}