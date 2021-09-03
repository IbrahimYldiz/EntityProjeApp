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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            list();
        }
        void list()
        {
            dataGridView1.DataSource = (from x in db.TblCustomer select new { x.CustomerId,x.CustomerName,x.CustomerSurname,x.CustomerCity,x.CustomerStatu }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCustomerID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtCustomerName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtCustomerSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtCustomerCity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome fr = new FrmHome();
            fr.Show();
            this.Close();
        }

        private void BtnCustomerAdd_Click(object sender, EventArgs e)
        {
            TblCustomer cs = new TblCustomer();
            cs.CustomerName = TxtCustomerName.Text;
            cs.CustomerSurname = TxtCustomerSurname.Text;
            cs.CustomerCity = TxtCustomerCity.Text;
            cs.CustomerStatu = Boolean.Parse(comboBox1.Text);
            db.TblCustomer.Add(cs);
            db.SaveChanges();
            MessageBox.Show("Müşteri Kayıt Edildi");
            list();
        }

        private void BtnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if(TxtCustomerID.Text.Trim()!="")
            {
                int id = Convert.ToInt32(TxtCustomerID.Text);
                var cus = db.TblCustomer.Find(id);
                if(TxtCustomerName.Text.Trim()!="")
                {
                    cus.CustomerName = TxtCustomerName.Text.Trim();
                    
                }
                if (TxtCustomerSurname.Text.Trim() != "")
                {
                    cus.CustomerSurname = TxtCustomerSurname.Text.Trim();
                }
                if (TxtCustomerCity.Text.Trim() != "")
                {
                    cus.CustomerCity = TxtCustomerCity.Text.Trim();
                }
                if(comboBox1.Text.Trim() !="")
                {
                    cus.CustomerStatu = Boolean.Parse(comboBox1.Text);
                }
                db.SaveChanges();
                MessageBox.Show("Güncelleme Başarılı Şekilde Tamamlandı");
                list(); 


            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Müşteriyi Seçiniz.");
            }
        }

        private void BtnDeleted_Click(object sender, EventArgs e)
        {
            if(TxtCustomerID.Text.Trim()!="")
            {
                int id = Convert.ToInt32(TxtCustomerID.Text);
                var cus = db.TblCustomer.Find(id);
                db.TblCustomer.Remove(cus);
                db.SaveChanges();
                MessageBox.Show("Müşteri Silindi");
                list();
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Müşteriyi Seçiniz");
            }
        }
    }
}
