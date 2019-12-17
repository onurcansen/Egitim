using DOB.BLL;
using DOB.BLL.Controllers;
using DOB.DTO;
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
    public partial class FormSessionRoleList : Form
    {
       public LoginController _lc;

        public FormSessionRoleList()
        {
            InitializeComponent();
            _lc = new LoginController();
            this.Load += ListeYükle;
        }

        private void FormSessionRoleList_Load(object sender, EventArgs e)
        {
            
        }

        private void ListeYükle(object sender, EventArgs e)
        {
            lstSessionRole.DataSource = null;
            lstSessionRole.DisplayMember = "RoleName";
            lstSessionRole.ValueMember = "Id";
            lstSessionRole.DataSource = Session.CurrentRole.ToList();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Session.CurrentRole.Clear();

            Session.CurrentRole.Add((RoleDTO)lstSessionRole.SelectedItem);

            if(Session.CurrentRole.FirstOrDefault().RoleName == "Employee")
            {
                FormMainEmployee frm = new FormMainEmployee();
                frm.ShowDialog();
            }
            if (Session.CurrentRole.FirstOrDefault().RoleName == "Customer")
            {
                FormMainCustomer frm = new FormMainCustomer();
                frm.ShowDialog();
            }
            if (Session.CurrentRole.FirstOrDefault().RoleName == "Admin")
            {
                FormMainEmployee frm = new FormMainEmployee();
                frm.ShowDialog();
            }

        }
    }
}
