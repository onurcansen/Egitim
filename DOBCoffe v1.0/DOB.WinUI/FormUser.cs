using DOB.BLL;
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
    public partial class FormUser : Form
    {
        LoginController _lc;
        public FormUser()
        {
            InitializeComponent();
            _lc = new LoginController();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
           


        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            

            ServiceResult result= _lc.Login(txtuser.Text, txtpassword.Text);
            
            if (result.State==ResultState.Success)
            {
              
                // customer rolüne sahipse form main customer
                //FormMainCustomer frm = new FormMainCustomer();
                //frm.Show();
                //this.Hide();

                if (Session.CurrentRole.Count() == 1)
                {
                  var frmMain=(Form)Activator.CreateInstance("DOB.WinUI", "DOB.WinUI.FormMain"+Session.CurrentRole.FirstOrDefault().RoleName).Unwrap();
                    frmMain.Show();


                }

                if (Session.CurrentRole.Count() > 1)
                {
                    FormSessionRoleList fr = new FormSessionRoleList();
                    fr._lc = _lc;
                    fr.Show();


                }
                
                this.Hide();
                            
            }
           
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatali");
            }
        }

        private void LnkCustomerAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCustomerAdd frm = new FormCustomerAdd();
            frm.Show;
            this.Close();
        }
    }
}
