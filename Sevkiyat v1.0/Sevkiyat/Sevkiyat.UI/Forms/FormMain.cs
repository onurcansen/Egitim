using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sevkiyat.UI.Enums;

namespace Sevkiyat.UI
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        #region
        private void irsaliyeOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            this.MdiChildShow<FormWayBillUpdate>();           
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormProductAdd>();
        }

        private void aracEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormVehicleAdd>();
        }

        private void aracListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormVehicleList>();
        }

        private void soforEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormDriverAdd>();
        }

        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPayerAdd>();
        }

        private void musteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPayersList>();
        }

        private void IrsaliyeleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormListWayBill>();
        }

        private void IrsaliyeDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormWayBillUpdate>();
        }

        private void IrsaliyeDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormWaybillDetails>();
        }

        private void UrunListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormProductList>();
        }

        private void SoforListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormDriverList>();
        }

        private void KullaniciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormUserAdd>();
        }

        private void KullaniciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormUserList>();
        }

        private void SifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPasswordChange>();
        }
        #endregion Sayfa Geçişleri
        private void FormMain_Load(object sender, EventArgs e)
        {                        
            if (Session.CurrentRole.RoleName == "Gözlemci")
            {
                irsaliyeDüzenleToolStripMenuItem.Enabled = false;
                irsaliyeOlusturToolStripMenuItem.Enabled = false;
                urunEkleToolStripMenuItem.Enabled = false;
                aracEkleToolStripMenuItem.Enabled = false;
                soforEkleToolStripMenuItem.Enabled = false;
                musteriEkleToolStripMenuItem.Enabled = false;
                kullaniciEkleToolStripMenuItem.Enabled = false;
                kullaniciListeleToolStripMenuItem.Enabled = false;
            }
        }
    }
}
