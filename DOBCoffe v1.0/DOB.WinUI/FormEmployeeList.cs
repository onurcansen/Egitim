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
    public partial class FormEmployeeList : Form
    {
        EmployeeController _ec;
        public FormEmployeeList()
        {
            InitializeComponent();
            _ec = new EmployeeController();
            FormEmployeeAdd.EmployeeAdded += ListLoad;
            FormEmployeeUpdate.EmployeeUpdated += ListLoad;
        }

        private void ListLoad()
        {
            List<EmployeeDTO> employees = _ec.ListEmployees();
            lstEmployeeList.DataSource = null;
            lstEmployeeList.DisplayMember = "EmployeeName";
            lstEmployeeList.ValueMember = "Id";
            lstEmployeeList.DataSource = employees;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lstEmployeeList.SelectedIndex==-1)
            {
                MessageBox.Show("Önce bir kayır seçmeniz gerekmektedir");
                return;
            }
            #endregion

            var employee = (EmployeeDTO)lstEmployeeList.SelectedItem;
            FormEmployeeUpdate frm = new FormEmployeeUpdate(employee);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lstEmployeeList.SelectedIndex == -1)
            {
                MessageBox.Show("Önce bir kayıt seçmeniz gerekmektedir.");
                return;
            }
            #endregion

            var employee = (EmployeeDTO)lstEmployeeList.SelectedItem;

            ServiceResult result = _ec.EmployeeDelete(employee);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                ListLoad();
            }
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            ListLoad();
        }
    }
}
