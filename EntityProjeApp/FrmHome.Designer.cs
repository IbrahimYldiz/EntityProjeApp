
namespace EntityProjeApp
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.BtnCategoryOperations = new System.Windows.Forms.Button();
            this.BtnProductOperations = new System.Windows.Forms.Button();
            this.BtnCustomerOperations = new System.Windows.Forms.Button();
            this.BtnSellOperations = new System.Windows.Forms.Button();
            this.BtnStatistics = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCategoryOperations
            // 
            this.BtnCategoryOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnCategoryOperations.ForeColor = System.Drawing.Color.White;
            this.BtnCategoryOperations.Location = new System.Drawing.Point(12, 69);
            this.BtnCategoryOperations.Name = "BtnCategoryOperations";
            this.BtnCategoryOperations.Size = new System.Drawing.Size(176, 155);
            this.BtnCategoryOperations.TabIndex = 0;
            this.BtnCategoryOperations.Text = "Kategori İşlemleri";
            this.BtnCategoryOperations.UseVisualStyleBackColor = false;
            this.BtnCategoryOperations.Click += new System.EventHandler(this.BtnCategoryOperations_Click);
            // 
            // BtnProductOperations
            // 
            this.BtnProductOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnProductOperations.ForeColor = System.Drawing.Color.White;
            this.BtnProductOperations.Location = new System.Drawing.Point(194, 69);
            this.BtnProductOperations.Name = "BtnProductOperations";
            this.BtnProductOperations.Size = new System.Drawing.Size(176, 155);
            this.BtnProductOperations.TabIndex = 1;
            this.BtnProductOperations.Text = "Ürün İşlemleri";
            this.BtnProductOperations.UseVisualStyleBackColor = false;
            this.BtnProductOperations.Click += new System.EventHandler(this.BtnProductOperations_Click);
            // 
            // BtnCustomerOperations
            // 
            this.BtnCustomerOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnCustomerOperations.ForeColor = System.Drawing.Color.White;
            this.BtnCustomerOperations.Location = new System.Drawing.Point(376, 69);
            this.BtnCustomerOperations.Name = "BtnCustomerOperations";
            this.BtnCustomerOperations.Size = new System.Drawing.Size(176, 155);
            this.BtnCustomerOperations.TabIndex = 2;
            this.BtnCustomerOperations.Text = "Müşteri İşlemleri";
            this.BtnCustomerOperations.UseVisualStyleBackColor = false;
            this.BtnCustomerOperations.Click += new System.EventHandler(this.BtnCustomerOperations_Click);
            // 
            // BtnSellOperations
            // 
            this.BtnSellOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnSellOperations.ForeColor = System.Drawing.Color.White;
            this.BtnSellOperations.Location = new System.Drawing.Point(558, 69);
            this.BtnSellOperations.Name = "BtnSellOperations";
            this.BtnSellOperations.Size = new System.Drawing.Size(176, 155);
            this.BtnSellOperations.TabIndex = 3;
            this.BtnSellOperations.Text = "Satış İşlemleri";
            this.BtnSellOperations.UseVisualStyleBackColor = false;
            this.BtnSellOperations.Click += new System.EventHandler(this.BtnSellOperations_Click);
            // 
            // BtnStatistics
            // 
            this.BtnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BtnStatistics.ForeColor = System.Drawing.Color.White;
            this.BtnStatistics.Location = new System.Drawing.Point(740, 69);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.Size = new System.Drawing.Size(176, 155);
            this.BtnStatistics.TabIndex = 4;
            this.BtnStatistics.Text = "İstatistikler";
            this.BtnStatistics.UseVisualStyleBackColor = false;
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(870, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(922, 247);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnStatistics);
            this.Controls.Add(this.BtnSellOperations);
            this.Controls.Add(this.BtnCustomerOperations);
            this.Controls.Add(this.BtnProductOperations);
            this.Controls.Add(this.BtnCategoryOperations);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCategoryOperations;
        private System.Windows.Forms.Button BtnProductOperations;
        private System.Windows.Forms.Button BtnCustomerOperations;
        private System.Windows.Forms.Button BtnSellOperations;
        private System.Windows.Forms.Button BtnStatistics;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}