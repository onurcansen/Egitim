using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sevkiyat.UI
{
    public partial class FormLogIn : Form
    {
        SevkiyatDBEntities _db;
        public FormLogIn()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void Btn_giris_Click(object sender, EventArgs e)
        {
            var kullaniciKontrol = (from u in _db.Users
                                    where u.UserName == txt_kullaniciAdi.Text && u.Password == txt_sifre.Text
                                    select u).FirstOrDefault();            
            if (kullaniciKontrol == null )
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
            else
            {
                Session.CurrentUser = kullaniciKontrol;
                Session.CurrentRole = kullaniciKontrol.Roles.FirstOrDefault();
                FormMain main = new FormMain();               
                main.ShowDialog();
                this.Close();
            }
            
        }
    }
}
