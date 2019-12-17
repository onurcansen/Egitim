using DOB.BLL;
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

namespace DOB.WinUI
{
    public partial class FormMainEmployee : Form
    {
        public FormMainEmployee()
        {
            InitializeComponent();
        }

        private void CustomerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormCustomerList>();
        }

        private void ProductAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormProductAdd>();
        }

        private void ProductListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormProductList>();
        }

        private void StockAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormStockAdd>();
        }              
    

        private void StockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormStockList>();
        }
        private void OrderAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormOrderAdd>();
        }

        private void OrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormOrderList>();
        }
        private void EmployeeAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.MdiChildShow<FormEmployeeAdd>();
            FormEmployeeAdd frm = new FormEmployeeAdd();
            frm.MdiParent = this;
            frm.Show();
            dgvOrders.Visible = false;
        

        }

        

        private void EmployeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormEmployeeList>();
        }
        private void PasswordChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPasswordChange>();
        }

        private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Kullanıcının kendi hesap bilgileirini görüntüleyeceği bir form..
        }
       
        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kullanıcının kendi hesap bilgilerini güncelleyebileceği bir form..

        }
        private void FormMainEmployee_Load(object sender, EventArgs e)
        {
            if (Session.CurrentRole.FirstOrDefault().RoleName=="Admin")
            {
                employeeToolStripMenuItem.Visible = true;
                customerToolStripMenuItem.Visible = true;
                IsMdiContainer = true;
            }
            dgvOrders.Visible = false;
        }

       
    }
}
