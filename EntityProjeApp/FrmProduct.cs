using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EntityProjeApp
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome fr = new FrmHome();
            fr.Show();
            this.Close();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        void list()
        {
            dataGridView1.DataSource = (from x in db.TblProduct select new { x.ProductID, x.ProductName, x.ProductBrand, x.ProductStock, x.ProductPrice, x.ProductStatu, x.TblCategory.CategoryName }).ToList();
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            list();
            //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GAR7AJO;Initial Catalog=DbEntityUrun;Integrated Security=True");
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("select * from TblCategory",baglanti);
            //SqlDataReader dr = komut.ExecuteReader();
            //while(dr.Read())
            //{
            //    CmbCategory.Items.Add(dr["CategoryName"]);
            //}
            //baglanti.Close();
            var kategoriler = (from x in db.TblCategory select new { x.CategoryID, x.CategoryName }).ToList();
            CmbCategory.ValueMember = "CategoryID";
            CmbCategory.DisplayMember = "CategoryName";
            CmbCategory.DataSource = kategoriler;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtProductID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtProductBrand.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtProductStock.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtProductPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            CmbStatu.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            CmbCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //int a = CmbCategory.SelectedIndex;

            Boolean b = Convert.ToBoolean(CmbStatu.Text);

            TblProduct t = new TblProduct();
            t.ProductName = TxtProductName.Text;
            t.ProductBrand = TxtProductBrand.Text;
            t.ProductStock = Convert.ToInt16(TxtProductStock.Text);
            t.ProductPrice = Convert.ToDecimal(TxtProductPrice.Text);
            t.ProductStatu = b;

            t.ProductCategory = int.Parse(CmbCategory.SelectedValue.ToString());
            db.TblProduct.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarılı Şekilde Eklendi");
            list();
        }

        private void TxtProductStatu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtProductStock_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void TxtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtProductBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            TblProduct pr = new TblProduct();
            int id = Convert.ToInt32(TxtProductID.Text);

            var urun = db.TblProduct.Find(id);
            db.TblProduct.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün silindii");
            list();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (TxtProductID.Text.Trim() != "")
            {
                int id = Convert.ToInt32(TxtProductID.Text);
                var urun = db.TblProduct.Find(id);
                if (TxtProductName.Text.Trim() != "")
                { urun.ProductName = TxtProductName.Text; }
                if (TxtProductStock.Text.Trim() != "")
                {
                    urun.ProductStock = short.Parse(TxtProductStock.Text);
                }

                if (TxtProductBrand.Text.Trim() != "")
                { urun.ProductBrand = TxtProductBrand.Text; }
                if (TxtProductPrice.Text.Trim() != "")
                {
                    urun.ProductPrice = decimal.Parse(TxtProductPrice.Text);
                }

                if (CmbStatu.Text.Trim() != "")
                {
                    urun.ProductStatu = Boolean.Parse(CmbStatu.Text);
                }
                if (CmbCategory.Text.Trim() != "")
                { urun.ProductCategory = CmbCategory.SelectedIndex; }
                MessageBox.Show("Ürün Güncelleme Yapıldı");
                list();

            }
            else
            {
                MessageBox.Show("Ürün Seçimi Yapılmadan Güncelleme İşlemi Yapılamaz");

            }
        }
    }
}
