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
    public partial class FormCreateWayBill : Form
    {
        SevkiyatDBEntities _db;
        public FormCreateWayBill()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void FormCreateWayBill_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
      

            
        }
        //CREATED USER - CREATED DATE 
        //BU 2 İRSALİYE KOLONU ELLE GİRİLMEYECEĞİ İÇİN FORMDA YOK

        private void ComboDoldur()
        {
            FormExtension.Load<Payer>(cmb_receiver, _db, "ContactName", "ID");
            FormExtension.Load<Payer>(cmb_sender, _db, "ContactName", "ID");
            FormExtension.Load<Vehicle>(cmb_vechile, _db, "PlateModel", "ID");
            FormExtension.Load<Driver>(cmb_driver, _db, "DriverName", "ID");
            FormExtension.EnumLoad<WayBillType>(cmb_billType);
        }
    }
}
