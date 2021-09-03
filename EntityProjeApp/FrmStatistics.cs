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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            LblCategoryNum1.Text = db.TblCategory.Count().ToString();
            LblProductNum1.Text = db.TblProduct.Count().ToString();
            LblOnlineCustomerNum1.Text = db.TblCustomer.Count(x => x.CustomerStatu == true).ToString();
            LblOfflineCustomerNum1.Text = db.TblCustomer.Count(a => a.CustomerStatu == false).ToString();
            LblTotalStock1.Text = db.TblProduct.Sum(b => b.ProductStock).ToString();
            LblHighestPricedProduct1.Text = (from f in db.TblProduct orderby f.ProductPrice descending select f.ProductName).FirstOrDefault();
            LblKasadakiTutar1.Text = db.TblSell.Sum(d => d.Price).ToString()+ " TL";
            LblLowestPricedProduct1.Text=(from r in db.TblProduct orderby r.ProductPrice ascending select r.ProductName).FirstOrDefault();
            LblBeyazEsya1.Text = db.TblProduct.Count(x => x.ProductCategory == 1).ToString();
            LblToplamBuzdolabiSayisi1.Text = db.TblProduct.Count(x => x.ProductName == "Buzdolabı").ToString();
            LblCity1.Text = (from s in db.TblCustomer select s.CustomerCity).Distinct().Count().ToString();
            LblEnFazlaUrunuOlanMarka1.Text = db.Brand().FirstOrDefault();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome fr = new FrmHome();
            fr.Show();
            this.Close();
        }
    }
}
