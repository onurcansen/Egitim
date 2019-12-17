using DOB.BLL;
using DOB.BLL.Controllers;
using DOB.DTO;
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
    public partial class FormProductAdd : Form
    {
        ProductController _pc;
        public FormProductAdd()
        {
            InitializeComponent();
            _pc = new ProductController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Ürün adı boş geçilemez.");
            }          
            if(string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Fiyat alanı boş geçilemez");
            }
            if (cmbProductType.SelectedIndex == -1)
            {
                MessageBox.Show("Bir tip seçmelisiniz.");
            }
            #endregion
            var dto = new ProductDTO();

            dto.ProductID = Guid.NewGuid();
            dto.ProductName = txtProductName.Text;
            dto.ProductType = (ProductType)cmbProductType.SelectedValue;
            dto.UnitPrice = int.Parse(txtPrice.Text);
            dto.Description = txtDescription.Text;
            dto.IsDeleted = false;
            dto.Discountinued = true;
            dto.UserId = Session.CurrentUser.Id;
            dto.CreatedDate = DateTime.Now;
            
            var result = _pc.ProductAdd(dto);
            result.NotificationShow();
        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            cmbProductType.EnumLoad<ProductType>();
        }
    }
}
