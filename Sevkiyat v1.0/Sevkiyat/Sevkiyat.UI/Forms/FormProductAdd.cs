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
    public partial class FormProductAdd : Form
    {
        SevkiyatDBEntities _db;
        public FormProductAdd()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            cmb_productType.Items.Add("Seçiniz");
            cmb_productType.Items.Add(ProductType.Kırılabilir);
            cmb_productType.Items.Add(ProductType.PatlayıcıMadde);
            cmb_productType.Items.Add(ProductType.YanıcıMadde);
            cmb_productType.SelectedIndex = 0;
            cmb_unitType.Items.Add("Seçiniz");
            cmb_unitType.Items.Add(ProductQuantityPerUnit.Kutu);
            cmb_unitType.Items.Add(ProductQuantityPerUnit.Şişe);
            cmb_unitType.Items.Add(ProductQuantityPerUnit.AltılıŞişe);
            cmb_unitType.Items.Add(ProductQuantityPerUnit.Kg);
            cmb_unitType.Items.Add(ProductQuantityPerUnit.Gram);
            cmb_unitType.SelectedIndex = 0;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrEmpty(txt_productName.Text) == true)
            {
                MessageBox.Show("Ürün adı alanı boş geçilemez");
                return;
            }
            else if (cmb_productType.SelectedIndex == 0)
            {
                MessageBox.Show("Ürün tipi seçmelisiniz");
                return;
            }
            else if (string.IsNullOrEmpty(txt_weight.Text) == true)
            {
                MessageBox.Show("Ağırlık alanı boş geçilemez");
                return;
            }
            else if (cmb_unitType.SelectedIndex==0)
            {
                MessageBox.Show("Birim cinsi seçmelisiniz");
                return;
            }
            #endregion
            try
            {
                Product product = new Product();
                product.ID = Guid.NewGuid();
                product.ProductName = txt_productName.Text;
                product.ProductType = (byte)cmb_productType.SelectedIndex;
                product.Weigh = Convert.ToInt32(txt_weight.Text);
                product.QuantityPerUnit = (byte)cmb_unitType.SelectedIndex;

                _db.Products.Add(product);
                _db.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show("İşlem bir hata nedeniyle tamamlanamadı");
            }  //Add product               
        }
    }
}
