using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sevkiyat.UI
{
    public partial class FormUserList : Form
    {
        SevkiyatDBEntities _db;
        public FormUserList()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            FormExtension.Load<User>(lstUsers, _db, "UserName", "ID");
        }
    }
}
