﻿namespace Sevkiyat.UI
{
    partial class FormProductList
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
            this.lstProducts = new System.Windows.Forms.ListView();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.HideSelection = false;
            this.lstProducts.Location = new System.Drawing.Point(12, 43);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(360, 464);
            this.lstProducts.TabIndex = 0;
            this.lstProducts.UseCompatibleStateImageBehavior = false;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(297, 12);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 1;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(12, 522);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnProductUpdate.TabIndex = 2;
            this.btnProductUpdate.Text = "Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(297, 522);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductDelete.TabIndex = 3;
            this.btnProductDelete.Text = "Sil";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 557);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.lstProducts);
            this.Name = "FormProductList";
            this.Text = "Ürünleri Listele";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstProducts;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductDelete;
    }
}