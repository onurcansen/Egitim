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
    public partial class FormVehicleAdd : Form
    {
        SevkiyatDBEntities _db;
        public FormVehicleAdd()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void FormVehicleAdd_Load(object sender, EventArgs e)
        {          
           
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrEmpty(txtPlate.Text) == true)
            {
                MessageBox.Show("Plaka alanı boş geçilemez");
                return;
            }
            else if (nudCapacity.Value == 0)
            {
                MessageBox.Show("Kapasite alanı boş geçilemez");
                return;
            }
            else if (string.IsNullOrEmpty(txtBrand.Text) == true)
            {
                MessageBox.Show("Marka alanı boş geçilemez");
                return;
            }
            else if (string.IsNullOrEmpty(txtModel.Text) == true)
            {
                MessageBox.Show("Model alanı boş geçilemez");
                return;
            }
            #endregion
            Vehicle vehicle = new Vehicle();
            vehicle.ID = Guid.NewGuid();
            vehicle.Plate = txtPlate.Text;
            vehicle.Capacity = Convert.ToInt32(nudCapacity.Value);
            vehicle.Brand = txtBrand.Text;
            vehicle.Model = txtModel.Text;
            
            try
            {
                _db.Vehicles.Add(vehicle);
                _db.SaveChanges();
                MessageBox.Show("İşlem başarılı");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata nedeniyle işlem tamamlanamadı");
            } //Vehicle add
        }
    }
}
