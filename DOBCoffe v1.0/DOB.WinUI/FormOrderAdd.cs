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
    public partial class FormOrderAdd : Form
    {
        Guid ID = Guid.NewGuid();
        OrderController _od;
        BranchController _bc;
        ProductController _pc;
        public FormOrderAdd()
        {
            InitializeComponent();
            _od = new OrderController();
            _bc = new BranchController();
            _pc = new ProductController();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        { 
            // veritabanına siparişi ve sipariş detayını kaydet..
        //{
        //    List<OrderDTO> list = _od.TumSiparisleriVer();
        //    lstshoppingcart.Yükle<OrderDTO>(list, "OrderID", "OrderID");

        }

        private void FormOrderAdd_Load(object sender, EventArgs e)
        {
            cmbproductype.EnumLoad<ProductType>();
           
            List<BranchDTO> branchs = _bc.TumSubeleriVer();
            cmbBranch.Yükle<BranchDTO>(branchs, "BranchName", "ID");
            grpExtra.Enabled = false;

           

            

        }

        private void Cmbproductype_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = (ProductType)cmbproductype.SelectedItem;
            if (type==ProductType.Drink)
            {
                List<ProductDTO> drinks = _pc.ListProducts().Where(r => r.ProductType == WHelper.ProductType.Drink).ToList();
                cmProductSub.Yükle<ProductDTO>(drinks, "ProductName", "Id");
                grpExtra.Enabled = true;

            }
            else
            {
                List<ProductDTO> foods = _pc.ListProducts().Where(r => r.ProductType == WHelper.ProductType.Food).ToList();
                cmProductSub.Yükle<ProductDTO>(foods, "ProductName", "Id");
                grpExtra.Enabled = false;
            }
        }

        private void BtnListBoxAdd_Click(object sender, EventArgs e)
        {
            
            var entity = (ProductDTO)cmProductSub.SelectedItem;
            var dto = new OrderDetailDTO();

            dto.Id = Guid.NewGuid();
            dto.OrderID = ID;
            dto.ProductID = entity.ProductID;
            dto.Quantity = (short)nudDrinks.Value;


        }
    }
}
