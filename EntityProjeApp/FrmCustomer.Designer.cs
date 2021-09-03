
namespace EntityProjeApp
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.TxtCustomerID = new System.Windows.Forms.TextBox();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.TxtCustomerCity = new System.Windows.Forms.TextBox();
            this.TxtCustomerSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCustomerUpdate = new System.Windows.Forms.Button();
            this.BtnCustomerAdd = new System.Windows.Forms.Button();
            this.BtnDeleted = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.Enabled = false;
            this.TxtCustomerID.Location = new System.Drawing.Point(201, 74);
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.Size = new System.Drawing.Size(155, 30);
            this.TxtCustomerID.TabIndex = 0;
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(201, 110);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(155, 30);
            this.TxtCustomerName.TabIndex = 2;
            // 
            // TxtCustomerCity
            // 
            this.TxtCustomerCity.Location = new System.Drawing.Point(201, 182);
            this.TxtCustomerCity.Name = "TxtCustomerCity";
            this.TxtCustomerCity.Size = new System.Drawing.Size(155, 30);
            this.TxtCustomerCity.TabIndex = 4;
            // 
            // TxtCustomerSurname
            // 
            this.TxtCustomerSurname.Location = new System.Drawing.Point(201, 146);
            this.TxtCustomerSurname.Name = "TxtCustomerSurname";
            this.TxtCustomerSurname.Size = new System.Drawing.Size(155, 30);
            this.TxtCustomerSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşterinin Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Müşterinin Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müşterinin Şehri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Müşteri ID:";
            // 
            // BtnCustomerUpdate
            // 
            this.BtnCustomerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnCustomerUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnCustomerUpdate.Location = new System.Drawing.Point(201, 283);
            this.BtnCustomerUpdate.Name = "BtnCustomerUpdate";
            this.BtnCustomerUpdate.Size = new System.Drawing.Size(155, 42);
            this.BtnCustomerUpdate.TabIndex = 9;
            this.BtnCustomerUpdate.Text = "Güncelle";
            this.BtnCustomerUpdate.UseVisualStyleBackColor = false;
            this.BtnCustomerUpdate.Click += new System.EventHandler(this.BtnCustomerUpdate_Click);
            // 
            // BtnCustomerAdd
            // 
            this.BtnCustomerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnCustomerAdd.ForeColor = System.Drawing.Color.White;
            this.BtnCustomerAdd.Location = new System.Drawing.Point(34, 283);
            this.BtnCustomerAdd.Name = "BtnCustomerAdd";
            this.BtnCustomerAdd.Size = new System.Drawing.Size(155, 42);
            this.BtnCustomerAdd.TabIndex = 10;
            this.BtnCustomerAdd.Text = "Ekle";
            this.BtnCustomerAdd.UseVisualStyleBackColor = false;
            this.BtnCustomerAdd.Click += new System.EventHandler(this.BtnCustomerAdd_Click);
            // 
            // BtnDeleted
            // 
            this.BtnDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnDeleted.ForeColor = System.Drawing.Color.White;
            this.BtnDeleted.Location = new System.Drawing.Point(107, 331);
            this.BtnDeleted.Name = "BtnDeleted";
            this.BtnDeleted.Size = new System.Drawing.Size(155, 42);
            this.BtnDeleted.TabIndex = 11;
            this.BtnDeleted.Text = "Sil";
            this.BtnDeleted.UseVisualStyleBackColor = false;
            this.BtnDeleted.Click += new System.EventHandler(this.BtnDeleted_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1115, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 261);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Müşterinin Durumu:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox1.Location = new System.Drawing.Point(201, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 33);
            this.comboBox1.TabIndex = 17;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1169, 405);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnDeleted);
            this.Controls.Add(this.BtnCustomerAdd);
            this.Controls.Add(this.BtnCustomerUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCustomerCity);
            this.Controls.Add(this.TxtCustomerSurname);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.TxtCustomerID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCustomerID;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.TextBox TxtCustomerCity;
        private System.Windows.Forms.TextBox TxtCustomerSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCustomerUpdate;
        private System.Windows.Forms.Button BtnCustomerAdd;
        private System.Windows.Forms.Button BtnDeleted;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}