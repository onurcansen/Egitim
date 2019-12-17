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
    public partial class FormDriverAdd : Form
    {
        SevkiyatDBEntities _db;
        public FormDriverAdd()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrEmpty(txtTcKimlikNo.Text) == true)
            {
                MessageBox.Show("Kimlik numarası alanı boş geçilemez");
                return;
            }
            else if (string.IsNullOrEmpty(txtAd.Text) == true)
            {
                MessageBox.Show("Sürücü adı alanı boş geçilemez");
                return;
            }
            else if (string.IsNullOrEmpty(txtSoyad.Text) == true)
            {
                MessageBox.Show("Sürücü soyadı alanı boş geçilemez");
                return;
            }
            else if (dtpDogumTarihi.Value == DateTime.Now)
            {
                MessageBox.Show("Doğum tarihi alanı boş geçilemez");
                return;
            }
            else if (string.IsNullOrEmpty(txtTel.Text) == true)
            {
                MessageBox.Show("Telefon alanı boş geçilemez");
                return;
            }
            #endregion
            Driver driver = new Driver();
            driver.ID = Guid.NewGuid();
            driver.TcNo = txtTcKimlikNo.Text;
            driver.FirstName = txtAd.Text;
            driver.LastName = txtSoyad.Text;
            driver.Phone = txtTel.Text;
            driver.BirthDate = dtpDogumTarihi.Value;
            try
            {               
                _db.Drivers.Add(driver);
                _db.SaveChanges();
                MessageBox.Show("İşlem başarıyla tamamlandı");
            }
            catch (Exception ex)
            {

                MessageBox.Show("İşlem bir hata nedeniyle tamamlanamadı");
            }
            

            
        }

        private void FormDriverAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}
