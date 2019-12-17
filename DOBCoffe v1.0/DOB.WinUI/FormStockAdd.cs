using DOB.BLL.Controllers;
using DOB.DTO;
using Framework.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOB.WinUI
{
    public partial class FormStockAdd : Form
    {
        ProductController _pc;
        public FormStockAdd()
        {
            InitializeComponent();
            _pc = new ProductController();
        }

        private void FromStockAdd_Load(object sender, EventArgs e)
        {
            
            List<ProductDTO> list = _pc.ListProducts();
            cmbProducts.Yükle<ProductDTO>(list, "ProductName", "ProductID");                     
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductDTO dto = (ProductDTO)cmbProducts.SelectedItem;
            dto.UnitOnStock = int.Parse(txtStock.Text);
            var result = _pc.ProductUpdate(dto);
            result.NotificationShow();
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductDTO dto = (ProductDTO)cmbProducts.SelectedItem;
            txtStock.Text = dto.UnitOnStock.ToString();
            if (dto.UnitOnStock > 0)
            {
                btnAdd.Text = "Güncelle";
            }
            if (dto.UnitOnStock == null)
            {
                txtStock.Text = 0.ToString();
                btnAdd.Text = "Ekle";
            }
        }
    } 
}
