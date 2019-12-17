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
    public partial class FormCustomerAdd : Form
    {
        public static Event1 CustomerAdded;
        CustomerController _cc;
        public FormCustomerAdd()
        {
            InitializeComponent();
            _cc = new CustomerController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region
            string message = "";
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                message += "Müşteri Adı Boş Geçilemez \n";
            }

            if (message !="")
            {
                MessageBox.Show(message);
                return;
            }
            #endregion Validation
            var dto = new CustomerDTO()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = dtpBirthDate.Value,
                Phone = txtPhone.Text,
                EMail = txtEmail.Text            
            };

            var result = _cc.CustomerAdd(dto);

            result.NotificationShow();

            if (result.State==ResultState.Success)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                dtpBirthDate.Value = DateTime.Now;

                CustomerAdded.Raise();
            }
        }

        private void FormCustomerAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}
