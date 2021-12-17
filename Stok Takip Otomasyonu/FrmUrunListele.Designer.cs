
namespace Stok_Takip_Otomasyonu
{
    partial class FrmUrunListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtalisfiyati = new System.Windows.Forms.TextBox();
            this.txtsatişfiyati = new System.Windows.Forms.TextBox();
            this.txtmiktari = new System.Windows.Forms.TextBox();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbarkodnoara = new System.Windows.Forms.TextBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.btnmarkaguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(108, 318);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(121, 28);
            this.btnguncelle.TabIndex = 16;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Satış Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kategori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Barkod No:";
            // 
            // txtalisfiyati
            // 
            this.txtalisfiyati.Location = new System.Drawing.Point(108, 257);
            this.txtalisfiyati.Name = "txtalisfiyati";
            this.txtalisfiyati.Size = new System.Drawing.Size(121, 26);
            this.txtalisfiyati.TabIndex = 19;
            // 
            // txtsatişfiyati
            // 
            this.txtsatişfiyati.Location = new System.Drawing.Point(108, 289);
            this.txtsatişfiyati.Name = "txtsatişfiyati";
            this.txtsatişfiyati.Size = new System.Drawing.Size(121, 26);
            this.txtsatişfiyati.TabIndex = 18;
            // 
            // txtmiktari
            // 
            this.txtmiktari.Location = new System.Drawing.Point(108, 225);
            this.txtmiktari.Name = "txtmiktari";
            this.txtmiktari.Size = new System.Drawing.Size(121, 26);
            this.txtmiktari.TabIndex = 17;
            // 
            // txturunadi
            // 
            this.txturunadi.Location = new System.Drawing.Point(108, 193);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(121, 26);
            this.txturunadi.TabIndex = 15;
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(108, 97);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(121, 26);
            this.txtbarkodno.TabIndex = 14;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(745, 100);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(82, 30);
            this.btnsil.TabIndex = 29;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "BarkodNo\'ya Göre Ara:";
            // 
            // txtbarkodnoara
            // 
            this.txtbarkodnoara.Location = new System.Drawing.Point(485, 58);
            this.txtbarkodnoara.Name = "txtbarkodnoara";
            this.txtbarkodnoara.Size = new System.Drawing.Size(122, 26);
            this.txtbarkodnoara.TabIndex = 31;
            this.txtbarkodnoara.TextChanged += new System.EventHandler(this.txtbarkodnoara_TextChanged);
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(108, 129);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.ReadOnly = true;
            this.txtkategori.Size = new System.Drawing.Size(121, 26);
            this.txtkategori.TabIndex = 32;
            this.txtkategori.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(108, 161);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.ReadOnly = true;
            this.txtmarka.Size = new System.Drawing.Size(121, 26);
            this.txtmarka.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Marka:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 34;
            this.label10.Text = "Kategori:";
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(372, 366);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(145, 26);
            this.cmbkategori.TabIndex = 36;
            this.cmbkategori.SelectedIndexChanged += new System.EventHandler(this.cmbkategori_SelectedIndexChanged);
            // 
            // cmbmarka
            // 
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(372, 398);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(145, 26);
            this.cmbmarka.TabIndex = 37;
            // 
            // btnmarkaguncelle
            // 
            this.btnmarkaguncelle.Location = new System.Drawing.Point(372, 430);
            this.btnmarkaguncelle.Name = "btnmarkaguncelle";
            this.btnmarkaguncelle.Size = new System.Drawing.Size(145, 47);
            this.btnmarkaguncelle.TabIndex = 38;
            this.btnmarkaguncelle.Text = "Marka-Kategori Güncelle";
            this.btnmarkaguncelle.UseVisualStyleBackColor = true;
            this.btnmarkaguncelle.Click += new System.EventHandler(this.btnmarkaguncelle_Click);
            // 
            // FrmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 498);
            this.Controls.Add(this.btnmarkaguncelle);
            this.Controls.Add(this.cmbmarka);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txtkategori);
            this.Controls.Add(this.txtbarkodnoara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtalisfiyati);
            this.Controls.Add(this.txtsatişfiyati);
            this.Controls.Add(this.txtmiktari);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.txtbarkodno);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FrmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtalisfiyati;
        private System.Windows.Forms.TextBox txtsatişfiyati;
        private System.Windows.Forms.TextBox txtmiktari;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbarkodnoara;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.Button btnmarkaguncelle;
    }
}