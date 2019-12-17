using DOB.BLL.Controllers;
using DOB.DTO;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOB.WinUI
{
    public partial class FormProductList : Form
    {
        ProductController _pc;
        public FormProductList()
        {
            InitializeComponent();
            _pc = new ProductController();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormProductUpdate frm = new FormProductUpdate((ProductDTO)lstProductList.SelectedItem);
            frm.ShowDialog();
            
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            ListLoad();
        }

        private void ListLoad()
        {

            lstProductList.DataSource = null;
            List<ProductDTO> products = _pc.ListProducts();
            lstProductList.DisplayMember = "ProductName";
            lstProductList.ValueMember = "Id";
            lstProductList.DataSource = products;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var product = (ProductDTO)lstProductList.SelectedItem;
            ServiceResult result = _pc.ProductDelete(product);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                ListLoad();
            }
        }
    }
}
