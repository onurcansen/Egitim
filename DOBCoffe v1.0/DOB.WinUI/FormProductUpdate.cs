using DOB.BLL.Controllers;
using DOB.DTO;
using Framework.Core;
using Framework.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHelper;

namespace DOB.WinUI
{
    public partial class FormProductUpdate : Form
    {
        ProductController _pc;
        ProductDTO gncproduct;
        public static event Event1 ProductUpdated;
        public FormProductUpdate(ProductDTO product)
        {
            InitializeComponent();
             gncproduct= product;
            _pc = new ProductController();
        }
        private void FormProductUpdate_Load(object sender, EventArgs e)
        {
            cmbProductType.EnumLoad<ProductType>();

            txtProductName.Text = gncproduct.ProductName;
            txtStock.Text = gncproduct.UnitOnStock.ToString();
            txtPrice.Text = gncproduct.UnitPrice.ToString();
            cmbProductType.SelectedValue = gncproduct.ProductType;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Ürün adı boş geçilemez.");
            }
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Stok alanı boş geçilemez.");
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Fiyat alanı boş geçilemez");
            }
            if (cmbProductType.SelectedIndex == -1)
            {
                MessageBox.Show("Bir tip seçmelisiniz.");
            }
            #endregion
            gncproduct.ProductName = txtProductName.Text;
            gncproduct.UnitPrice = int.Parse(txtPrice.Text);
            gncproduct.UnitOnStock = int.Parse(txtStock.Text);
            gncproduct.ProductType = (ProductType)cmbProductType.SelectedValue;

            var result = _pc.ProductUpdate(gncproduct);
            result.NotificationShow();
            if(result.State== ResultState.Success)
            {
                ProductUpdated.Raise();
                this.Close();
            }
        }
    }
}
