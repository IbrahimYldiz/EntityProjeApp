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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void BtnCategoryOperations_Click(object sender, EventArgs e)
        {
            FrmCategory fr = new FrmCategory();
            fr.Show();
            this.Close();
        }

        private void BtnProductOperations_Click(object sender, EventArgs e)
        {
            FrmProduct fr = new FrmProduct();
            fr.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCustomerOperations_Click(object sender, EventArgs e)
        {
            FrmCustomer fr = new FrmCustomer();
            fr.Show();
            this.Close();
        }

        private void BtnSellOperations_Click(object sender, EventArgs e)
        {
            FrmSell fr = new FrmSell();
            fr.Show();
            this.Close();
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics fr = new FrmStatistics();
            fr.Show();
            this.Close();
        }

       
    }
}
