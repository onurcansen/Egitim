using DOB.BLL.Controllers;
using DOB.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOB.WinUI
{
    public partial class FormStockList : Form
    {
        ProductController _pc;
        public FormStockList()
        {
            InitializeComponent();
            _pc = new ProductController();
        }

        
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void FormStockList_Load(object sender, EventArgs e)
        {
            List<ProductDTO> productList =_pc.ListProducts();  
            
           // var stock = (from p in _)
        }
    }
}
