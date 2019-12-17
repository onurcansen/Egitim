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
    public partial class FormEmployeeAdd : Form
    {
        public static Event1 EmployeeAdded;
        EmployeeController _ec;
        public FormEmployeeAdd()
        {
            InitializeComponent();
            _ec = new EmployeeController();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                message += "Personel adı boş geçilemez\n";
            }
            if (message !="")
            {
                MessageBox.Show(message);
                return;
            }

            var dto = new EmployeeDTO()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                EMail = txtEmail.Text,
                BirthDate=dtpBirthDate.Value,
               // BranchID=(Guid)cmbBranch.ValueMember,
                
                
            };

            var result = _ec.EmployeeAdd(dto);

            result.NotificationShow();

            if (result.State==ResultState.Success)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                dtpBirthDate.Value = DateTime.Now;

                EmployeeAdded.Raise();
            }
        }

        private void FormEmployeeAdd_Load(object sender, EventArgs e)
        {
            cmbBranch.Yukle<BranchDTO>();
        }
    }
}
