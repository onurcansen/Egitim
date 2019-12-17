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
    
    public partial class FormVehicleList : Form
    {
        Vehicle vehicle;
        SevkiyatDBEntities _db;
        public FormVehicleList()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void FormVehicleList_Load(object sender, EventArgs e)
        {
            FormExtension.Load<Vehicle>(lstVehicles, _db, "PlateModel", "ID");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormVehicleAdd>();
        }

        private void LstVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicle = ((Vehicle)lstVehicles.SelectedItem);
            txtBrand.Text = vehicle.Brand;
            txtCapacity.Text = vehicle.Capacity.ToString();
            txtModel.Text = vehicle.Model;
            txtPlate.Text = vehicle.Plate;
        }
    }
}
