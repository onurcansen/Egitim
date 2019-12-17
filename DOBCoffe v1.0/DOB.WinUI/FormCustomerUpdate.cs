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

namespace DOB.WinUI
{
    public partial class FormCustomerUpdate : Form
    {
        CustomerDTO _customer;
        CustomerController _cc;
        public static event Event1 CustomerUpdated;
        public FormCustomerUpdate(CustomerDTO customer)
        {
            InitializeComponent();
            _customer = customer;
            _cc = new CustomerController();
        }

        
        private void FormCustomerUpdate_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = _customer.FirstName;
            txtLastName.Text = _customer.LastName;
            txtPhone.Text = _customer.Phone;
            txtEmail.Text = _customer.EMail;
            dtpBirthDate.Value = (DateTime)_customer.BirthDate;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Müşteri Adı boş Geçilemez!");
                return;
            }
            #endregion
            _customer.FirstName = txtFirstName.Text;
            _customer.LastName = txtLastName.Text;
            _customer.Phone = txtPhone.Text;
            _customer.EMail = txtEmail.Text;
            _customer.BirthDate = dtpBirthDate.Value;

            var result = _cc.CustomerUpdate(_customer);
            result.NotificationShow();
            if (result.State==ResultState.Success)
            {
                CustomerUpdated.Raise();
                this.Close();
                
            }
        }
    }
}
