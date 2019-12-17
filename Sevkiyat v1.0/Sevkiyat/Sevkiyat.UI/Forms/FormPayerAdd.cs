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
    public partial class FormPayerAdd : Form
    {
        SevkiyatDBEntities _db;
        public FormPayerAdd()
        {
            InitializeComponent();

            _db = new SevkiyatDBEntities();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            #region Validation
            if (string.IsNullOrEmpty(txtCompanyName.Text) == true)
            {
                MessageBox.Show("Şirket adı alanı boş geçilemez");
                return;
            }
            else if (string.IsNullOrEmpty(txtContactName.Text) == true)
            {
                MessageBox.Show("Muhattap adı alanı boş geçilemez");
                return;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text) == true)
            {
                MessageBox.Show("Telefon alanı boş geçilemez");
                return;
            }
            else if (string.IsNullOrEmpty(txtCity.Text) == true)
            {
                MessageBox.Show("Şehir alanı boş geçilemez");
                return;
            }
            else if (cmb_customerType.SelectedIndex == 0)
            {
                MessageBox.Show("Müşteri tipi seçmelisiniz");
                return;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                MessageBox.Show("Adres alanız boş geçilemez");
                return;
            }

            #endregion

            Payer payer = new Payer()
            {
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ID = Guid.NewGuid(),
                City = txtCity.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                TypeID = (byte)cmb_customerType.SelectedIndex
            };

            try
            {
                _db.Payers.Add(payer);
                _db.SaveChanges();

                MessageBox.Show("İşlem Başarılı");

            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem bir hata nedeniyle tamamlanamadı!");
                return;
            } //Payer Add

        }

        private void FormPayerAdd_Load(object sender, EventArgs e)
        {
            FormExtension.EnumLoad<PayerType>(cmb_customerType);
        }
    }
}
