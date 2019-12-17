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
    public partial class FormWayBillUpdate : Form
    {
        SevkiyatDBEntities _db;
        public FormWayBillUpdate()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }
        private void FormWayBillUpdate_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            dtp_deliveryDate.Enabled = false;
            
        }

        private void ComboDoldur()
        {
            FormExtension.Load<Payer>(cmb_receiver, _db, "ContactName", "ID");
            FormExtension.Load<Payer>(cmb_sender, _db, "ContactName", "ID");
            FormExtension.Load<Vehicle>(cmb_vechile, _db, "PlateModel", "ID");
            FormExtension.Load<Driver>(cmb_driver, _db, "DriverName", "ID");
            FormExtension.Load<Product>(cmb_product, _db, "ProductName", "ID");
            FormExtension.EnumLoad<WayBillType>(cmb_billType);
        }

        private void Cmb_sender_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_senderCompany.Text=((Payer)cmb_sender.SelectedItem).CompanyName;
            txt_senderPhone.Text = ((Payer)cmb_sender.SelectedItem).Phone;
            txt_senderAdress.Text = ((Payer)cmb_sender.SelectedItem).Address;
            groupBox1.Text = ((Payer)cmb_sender.SelectedItem).ContactName;




        }

        private void Cmb_receiver_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_receiverCompany.Text = ((Payer)cmb_receiver.SelectedItem).CompanyName;
            txt_receiverPhone.Text = ((Payer)cmb_receiver.SelectedItem).Phone;
            txt_receiverAdress.Text = ((Payer)cmb_receiver.SelectedItem).Address;
            groupBox2.Text = ((Payer)cmb_receiver.SelectedItem).ContactName;
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            var ProductInformation = (from p in _db.Products
                                      where p.ID == (Guid)cmb_product.SelectedValue
                                      select p.ProductName).FirstOrDefault();
            var ProductInformation2 = (from p in _db.Products
                                      where p.ID == (Guid)cmb_product.SelectedValue
                                      select ((ProductQuantityPerUnit)p.QuantityPerUnit).ToString()).FirstOrDefault();

            
            ListViewItem lstItem = new ListViewItem();
            lstItem.Text = ProductInformation;
            lstItem.SubItems.Add(ProductInformation2);
            lstItem.SubItems.Add(nud_adet.Value.ToString());
            lw_products.Items.Add(lstItem);
        }

        private void Chc_delivery_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_delivery.Checked == false)
            {
                dtp_deliveryDate.Enabled = false;
            }
            else
            {
                dtp_deliveryDate.Enabled = true;
            }
           
        }

        private void Btn_update_Add_Click(object sender, EventArgs e)
        {
            #region WayBill Add
            WayBill wayBill = new WayBill();
            wayBill.BillType = (byte)cmb_billType.SelectedIndex;
            wayBill.CreatedDate = DateTime.Now;
            wayBill.CreatedUserID = Session.CurrentUser.ID;
            wayBill.ID = Guid.NewGuid();
            wayBill.ShipmentDate = dtp_shipmentDate.Value;
            wayBill.DeliveryDate = dtp_deliveryDate.Value;
            wayBill.ReceiverID = (Guid)cmb_receiver.SelectedValue;
            wayBill.SenderID = (Guid)cmb_sender.SelectedValue;
            wayBill.VehicleID = (Guid)cmb_vechile.SelectedValue;
            wayBill.DriverID = (Guid)cmb_driver.SelectedValue;
            try
            {
                _db.WayBills.Add(wayBill);
                _db.SaveChanges();

                MessageBox.Show("İşlem Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem bir hata sebebiyle tamamlanamadı.");

            }
            #endregion
            #region 
            WayBillDetail wayBillDetail = new WayBillDetail();
            wayBillDetail.WaybillID = wayBill.ID;
            #endregion
        }
    }
}
