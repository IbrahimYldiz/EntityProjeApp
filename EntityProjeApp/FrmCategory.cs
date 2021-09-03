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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
            
        }
        void list()
        {
            dataGridView1.DataSource = (from x in db.TblCategory select new { x.CategoryID,x.CategoryName }).ToList();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtCategoryName.Text.Trim() != "" )
            {
                TblCategory t = new TblCategory();
                t.CategoryName = TxtCategoryName.Text.Trim();
                db.TblCategory.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori etkilendi");
                list();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCategoryID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtCategoryName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtCategoryID.Text.Trim() != "" )
            {
                int s = Convert.ToInt32(TxtCategoryID.Text);
                var ctgyr = db.TblCategory.Find(s);
                db.TblCategory.Remove(ctgyr);
                db.SaveChanges();
                MessageBox.Show("Kategori silindi");
                list();

            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Kategorinin ID Değerini Giriniz");
            }
        }
        private void clear()
        {
            TxtCategoryID.Text = "";
            TxtCategoryName.Text = "";
        }
        void clear1()
        {
            TxtCategoryName.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtCategoryName.Text.Trim() != "")
            {
                if (TxtCategoryID.Text.Trim() != "")
                {
                    int u = Convert.ToInt32(TxtCategoryID.Text);
                    var up = db.TblCategory.Find(u);
                    up.CategoryName = TxtCategoryName.Text.Trim();
                    db.SaveChanges();
                    MessageBox.Show("Güncelleme Yapıldı");
                    list();
                }
                else
                {
                    MessageBox.Show("Kategori ID ve Kategori Adı Boş Geçilemez");
                    clear1();
                }
            }
            else
            {
                MessageBox.Show("Kategori ID ve Kategori Adı Boş Geçilemez");
                clear1();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome fr = new FrmHome();
            fr.Show();
            this.Close();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            list();
            dataGridView1.Columns[0].HeaderText = "Kategori ID";
            dataGridView1.Columns[1].HeaderText = "Kategori Adı";
        }
    }
}

