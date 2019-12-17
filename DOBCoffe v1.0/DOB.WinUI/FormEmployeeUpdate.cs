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
    public partial class FormEmployeeUpdate : Form
    {
        EmployeeDTO _employee;
        EmployeeController _ec;
        public static event Event1 EmployeeUpdated;
        public FormEmployeeUpdate(EmployeeDTO employee)
        {
            InitializeComponent();
            _employee = employee;
            _ec = new EmployeeController();
        }

        private void FormEmployeeUpdate_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = _employee.FirstName;
            txtLastName.Text = _employee.LastName;
            txtPhone.Text = _employee.Phone;
            //  txtBranch.Text = _employee.BranchID;
            dtpBirthDate.Value = (DateTime)_employee.BirthDate;
            txtEmail.Text = _employee.EMail;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Personel adı boş geçilemez!");
                return;
            }
            #endregion

            _employee.FirstName = txtFirstName.Text;
            _employee.LastName = txtLastName.Text;
            _employee.Phone = txtPhone.Text;
            _employee.BirthDate = dtpBirthDate.Value;
            _employee.EMail = txtEmail.Text;

            var result = _ec.EmployeeUpdate(_employee);
            result.NotificationShow();
            if (result.State==ResultState.Success)
            {
                EmployeeUpdated.Raise();
                this.Close();
            }

        }
    }
}
