using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeApp
{
    public partial class FrmSell : Form
    {
        public FrmSell()
        {
            InitializeComponent();
        }

        void product()
        {
            
        }
        int c;
        decimal y;
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void FrmSell_Load(object sender, EventArgs e)
        {
            var urun = (from x in db.TblProduct select new { x.ProductID, x.ProductName }).ToList();
            CmbProductName.ValueMember = "ProductID";
            CmbProductName.DisplayMember = "ProductName";
            CmbProductName.DataSource = urun;
            var musteri = (from a in db.TblCustomer select new { a.CustomerId, a.CustomerName }).ToList();
            CmbCustomerName.ValueMember = "CustomerId";
            CmbCustomerName.DisplayMember = "CustomerName";
            CmbCustomerName.DataSource = musteri;
                       
            list();
        }
        void list()
        {
            dataGridView1.DataSource = (from d in db.TblSell select new { d.SELLId, d.TblProduct.ProductName, d.TblCustomer.CustomerName, d.Price, d.Date }).ToList();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Satış Onay", "Lütfen Bilgileri Kontrol Ettikten Sonra Onaylayınız", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                DateTime dt = dateTimePicker1.Value;
                TblSell sl = new TblSell();
                TblProduct pd = new TblProduct();
                sl.Product = Convert.ToInt32(CmbProductName.SelectedValue.ToString());
                sl.Customer = Convert.ToInt32(CmbCustomerName.SelectedValue.ToString());
                sl.Date = dt;
                sl.Price = y;
                db.TblSell.Add(sl);
                db.SaveChanges();
                MessageBox.Show("Satış Gerçekleşti");
                list();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edilmiştir.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome fr = new FrmHome();
            fr.Show();
            this.Close();
        }

        private void CmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
           c = Convert.ToInt32(CmbProductName.SelectedValue);
            y = Convert.ToDecimal((from x in db.TblProduct orderby x.ProductID == c descending select x.ProductPrice).FirstOrDefault());
        }
    }
}
