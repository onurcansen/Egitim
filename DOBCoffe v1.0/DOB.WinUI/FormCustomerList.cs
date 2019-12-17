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
    public partial class FormCustomerList : Form
    {
        CustomerController _cc;
        public FormCustomerList()
        {
            InitializeComponent();
            _cc = new CustomerController();
            FormCustomerAdd.CustomerAdded += ListLoad;
            FormCustomerUpdate.CustomerUpdated += ListLoad;
        }

        private void ListLoad()
        {
            List<CustomerDTO> customers = _cc.ListCustomers();
            lstCustomerList.DataSource = null;
            lstCustomerList.DisplayMember = "CustomerName";
            lstCustomerList.ValueMember = "Id";
            lstCustomerList.DataSource = customers;
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lstCustomerList.SelectedIndex==-1) //buna bak
            {
                MessageBox.Show("Önce bir kayıt seçmeniz gerekmektedir.");
                return;
            }
            #endregion
            var customer = (CustomerDTO)lstCustomerList.SelectedItem;
            FormCustomerUpdate frm = new FormCustomerUpdate(customer);
            frm.MdiParent = this.MdiParent; //buna da bak!!
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lstCustomerList.SelectedIndex==-1)
            {
                MessageBox.Show("Önce bir kayıt seçmeniz gerekmektedir.");
                return;
            }
            #endregion

            var customer = (CustomerDTO)lstCustomerList.SelectedItem;

            ServiceResult result = _cc.CustomerDelete(customer);
            result.NotificationShow();
            if (result.State==ResultState.Success)
            {
                ListLoad();
            }
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            ListLoad();
        }
    }
}
