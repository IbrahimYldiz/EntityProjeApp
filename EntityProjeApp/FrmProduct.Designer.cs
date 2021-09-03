
namespace EntityProjeApp
{
    partial class FrmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtProductBrand = new System.Windows.Forms.TextBox();
            this.TxtProductPrice = new System.Windows.Forms.TextBox();
            this.TxtProductStock = new System.Windows.Forms.TextBox();
            this.LblProductID = new System.Windows.Forms.Label();
            this.LblProductName = new System.Windows.Forms.Label();
            this.LblProductStock = new System.Windows.Forms.Label();
            this.LblProductBrand = new System.Windows.Forms.Label();
            this.LblProductStatu = new System.Windows.Forms.Label();
            this.LblProductPrice = new System.Windows.Forms.Label();
            this.LblProductCategory = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.CmbStatu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TxtProductID
            // 
            this.TxtProductID.Enabled = false;
            this.TxtProductID.Location = new System.Drawing.Point(189, 66);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(161, 30);
            this.TxtProductID.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(190, 102);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(161, 30);
            this.TxtProductName.TabIndex = 3;
            this.TxtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductName_KeyPress);
            // 
            // TxtProductBrand
            // 
            this.TxtProductBrand.Location = new System.Drawing.Point(189, 138);
            this.TxtProductBrand.Name = "TxtProductBrand";
            this.TxtProductBrand.Size = new System.Drawing.Size(161, 30);
            this.TxtProductBrand.TabIndex = 4;
            this.TxtProductBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductBrand_KeyPress);
            // 
            // TxtProductPrice
            // 
            this.TxtProductPrice.Location = new System.Drawing.Point(189, 210);
            this.TxtProductPrice.Name = "TxtProductPrice";
            this.TxtProductPrice.Size = new System.Drawing.Size(161, 30);
            this.TxtProductPrice.TabIndex = 6;
            this.TxtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductPrice_KeyPress);
            // 
            // TxtProductStock
            // 
            this.TxtProductStock.Location = new System.Drawing.Point(189, 174);
            this.TxtProductStock.Name = "TxtProductStock";
            this.TxtProductStock.Size = new System.Drawing.Size(161, 30);
            this.TxtProductStock.TabIndex = 5;
            this.TxtProductStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductStock_KeyPress);
            // 
            // LblProductID
            // 
            this.LblProductID.AutoSize = true;
            this.LblProductID.ForeColor = System.Drawing.Color.White;
            this.LblProductID.Location = new System.Drawing.Point(98, 69);
            this.LblProductID.Name = "LblProductID";
            this.LblProductID.Size = new System.Drawing.Size(84, 25);
            this.LblProductID.TabIndex = 9;
            this.LblProductID.Text = "Ürün ID:";
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.ForeColor = System.Drawing.Color.White;
            this.LblProductName.Location = new System.Drawing.Point(88, 105);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(94, 25);
            this.LblProductName.TabIndex = 10;
            this.LblProductName.Text = "Ürün Adı:";
            // 
            // LblProductStock
            // 
            this.LblProductStock.AutoSize = true;
            this.LblProductStock.ForeColor = System.Drawing.Color.White;
            this.LblProductStock.Location = new System.Drawing.Point(83, 177);
            this.LblProductStock.Name = "LblProductStock";
            this.LblProductStock.Size = new System.Drawing.Size(99, 25);
            this.LblProductStock.TabIndex = 12;
            this.LblProductStock.Text = "Ürün Stok";
            // 
            // LblProductBrand
            // 
            this.LblProductBrand.AutoSize = true;
            this.LblProductBrand.ForeColor = System.Drawing.Color.White;
            this.LblProductBrand.Location = new System.Drawing.Point(48, 141);
            this.LblProductBrand.Name = "LblProductBrand";
            this.LblProductBrand.Size = new System.Drawing.Size(134, 25);
            this.LblProductBrand.TabIndex = 11;
            this.LblProductBrand.Text = "Ürün Markası:";
            // 
            // LblProductStatu
            // 
            this.LblProductStatu.AutoSize = true;
            this.LblProductStatu.ForeColor = System.Drawing.Color.White;
            this.LblProductStatu.Location = new System.Drawing.Point(48, 249);
            this.LblProductStatu.Name = "LblProductStatu";
            this.LblProductStatu.Size = new System.Drawing.Size(134, 25);
            this.LblProductStatu.TabIndex = 14;
            this.LblProductStatu.Text = "Ürün Durumu:";
            // 
            // LblProductPrice
            // 
            this.LblProductPrice.AutoSize = true;
            this.LblProductPrice.ForeColor = System.Drawing.Color.White;
            this.LblProductPrice.Location = new System.Drawing.Point(71, 213);
            this.LblProductPrice.Name = "LblProductPrice";
            this.LblProductPrice.Size = new System.Drawing.Size(111, 25);
            this.LblProductPrice.TabIndex = 13;
            this.LblProductPrice.Text = "Ürün Fiyatı:";
            // 
            // LblProductCategory
            // 
            this.LblProductCategory.AutoSize = true;
            this.LblProductCategory.ForeColor = System.Drawing.Color.White;
            this.LblProductCategory.Location = new System.Drawing.Point(31, 288);
            this.LblProductCategory.Name = "LblProductCategory";
            this.LblProductCategory.Size = new System.Drawing.Size(152, 25);
            this.LblProductCategory.TabIndex = 15;
            this.LblProductCategory.Text = "Ürün Kategorisi:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(21, 386);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(161, 44);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnList.ForeColor = System.Drawing.Color.White;
            this.BtnList.Location = new System.Drawing.Point(22, 336);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(161, 44);
            this.BtnList.TabIndex = 17;
            this.BtnList.Text = "Listele";
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(189, 336);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(161, 44);
            this.BtnAdd.TabIndex = 19;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(189, 386);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(161, 44);
            this.BtnUpdate.TabIndex = 18;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 364);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1547, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(190, 285);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(162, 33);
            this.CmbCategory.TabIndex = 22;
            // 
            // CmbStatu
            // 
            this.CmbStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatu.FormattingEnabled = true;
            this.CmbStatu.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CmbStatu.Location = new System.Drawing.Point(190, 246);
            this.CmbStatu.Name = "CmbStatu";
            this.CmbStatu.Size = new System.Drawing.Size(162, 33);
            this.CmbStatu.TabIndex = 23;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1615, 447);
            this.Controls.Add(this.CmbStatu);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblProductCategory);
            this.Controls.Add(this.LblProductStatu);
            this.Controls.Add(this.LblProductPrice);
            this.Controls.Add(this.LblProductStock);
            this.Controls.Add(this.LblProductBrand);
            this.Controls.Add(this.LblProductName);
            this.Controls.Add(this.LblProductID);
            this.Controls.Add(this.TxtProductPrice);
            this.Controls.Add(this.TxtProductStock);
            this.Controls.Add(this.TxtProductBrand);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.TxtProductID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtProductBrand;
        private System.Windows.Forms.TextBox TxtProductPrice;
        private System.Windows.Forms.TextBox TxtProductStock;
        private System.Windows.Forms.Label LblProductID;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Label LblProductStock;
        private System.Windows.Forms.Label LblProductBrand;
        private System.Windows.Forms.Label LblProductStatu;
        private System.Windows.Forms.Label LblProductPrice;
        private System.Windows.Forms.Label LblProductCategory;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.ComboBox CmbStatu;
    }
}