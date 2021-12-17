
namespace Stok_Takip_Otomasyonu
{
    partial class FormSatis
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewsatis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttoplamfiyat = new System.Windows.Forms.TextBox();
            this.txtsatisfiyati = new System.Windows.Forms.TextBox();
            this.txtmiktari = new System.Windows.Forms.TextBox();
            this.txturunadı = new System.Windows.Forms.TextBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnsatisiptal = new System.Windows.Forms.Button();
            this.btnsatisyap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblgeneltoplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsatislisteleme = new System.Windows.Forms.Button();
            this.btnurunlisteleme = new System.Windows.Forms.Button();
            this.btnurunekleme = new System.Windows.Forms.Button();
            this.btnmusterilisteleme = new System.Windows.Forms.Button();
            this.btnmusteriekleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewsatis
            // 
            this.dataGridViewsatis.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewsatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsatis.Location = new System.Drawing.Point(273, 112);
            this.dataGridViewsatis.Name = "dataGridViewsatis";
            this.dataGridViewsatis.Size = new System.Drawing.Size(451, 246);
            this.dataGridViewsatis.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msktelefon);
            this.groupBox1.Controls.Add(this.mskTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtadsoyad);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(117, 89);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(126, 26);
            this.msktelefon.TabIndex = 7;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(117, 25);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(126, 26);
            this.mskTC.TabIndex = 6;
            this.mskTC.ValidatingType = typeof(int);
            this.mskTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTC_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC:";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(117, 57);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(126, 26);
            this.txtadsoyad.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txttoplamfiyat);
            this.groupBox2.Controls.Add(this.txtsatisfiyati);
            this.groupBox2.Controls.Add(this.txtmiktari);
            this.groupBox2.Controls.Add(this.txturunadı);
            this.groupBox2.Controls.Add(this.txtbarkodno);
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Toplam Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Satış Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Barkod No:";
            // 
            // txttoplamfiyat
            // 
            this.txttoplamfiyat.Location = new System.Drawing.Point(117, 153);
            this.txttoplamfiyat.Name = "txttoplamfiyat";
            this.txttoplamfiyat.Size = new System.Drawing.Size(126, 26);
            this.txttoplamfiyat.TabIndex = 3;
            // 
            // txtsatisfiyati
            // 
            this.txtsatisfiyati.Location = new System.Drawing.Point(117, 121);
            this.txtsatisfiyati.Name = "txtsatisfiyati";
            this.txtsatisfiyati.Size = new System.Drawing.Size(126, 26);
            this.txtsatisfiyati.TabIndex = 3;
            this.txtsatisfiyati.TextChanged += new System.EventHandler(this.txtsatisfiyati_TextChanged);
            // 
            // txtmiktari
            // 
            this.txtmiktari.Location = new System.Drawing.Point(117, 89);
            this.txtmiktari.Name = "txtmiktari";
            this.txtmiktari.Size = new System.Drawing.Size(126, 26);
            this.txtmiktari.TabIndex = 2;
            this.txtmiktari.Text = "1";
            this.txtmiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmiktari.TextChanged += new System.EventHandler(this.txtmiktari_TextChanged);
            // 
            // txturunadı
            // 
            this.txturunadı.Location = new System.Drawing.Point(117, 57);
            this.txturunadı.Name = "txturunadı";
            this.txturunadı.Size = new System.Drawing.Size(126, 26);
            this.txturunadı.TabIndex = 1;
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(117, 25);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(126, 26);
            this.txtbarkodno.TabIndex = 0;
            this.txtbarkodno.TextChanged += new System.EventHandler(this.txtbarkodno_TextChanged);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(294, 364);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(81, 31);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(730, 112);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(84, 33);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnsatisiptal
            // 
            this.btnsatisiptal.Location = new System.Drawing.Point(730, 151);
            this.btnsatisiptal.Name = "btnsatisiptal";
            this.btnsatisiptal.Size = new System.Drawing.Size(84, 30);
            this.btnsatisiptal.TabIndex = 5;
            this.btnsatisiptal.Text = "Satış İptal";
            this.btnsatisiptal.UseVisualStyleBackColor = true;
            this.btnsatisiptal.Click += new System.EventHandler(this.btnsatisiptal_Click);
            // 
            // btnsatisyap
            // 
            this.btnsatisyap.Location = new System.Drawing.Point(715, 365);
            this.btnsatisyap.Name = "btnsatisyap";
            this.btnsatisyap.Size = new System.Drawing.Size(99, 30);
            this.btnsatisyap.TabIndex = 6;
            this.btnsatisyap.Text = "Satış Yap";
            this.btnsatisyap.UseVisualStyleBackColor = true;
            this.btnsatisyap.Click += new System.EventHandler(this.btnsatisyap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Genel Toplam";
            // 
            // lblgeneltoplam
            // 
            this.lblgeneltoplam.AutoSize = true;
            this.lblgeneltoplam.Location = new System.Drawing.Point(602, 377);
            this.lblgeneltoplam.Name = "lblgeneltoplam";
            this.lblgeneltoplam.Size = new System.Drawing.Size(0, 18);
            this.lblgeneltoplam.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnsatislisteleme);
            this.panel1.Controls.Add(this.btnurunlisteleme);
            this.panel1.Controls.Add(this.btnurunekleme);
            this.panel1.Controls.Add(this.btnmusterilisteleme);
            this.panel1.Controls.Add(this.btnmusteriekleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 76);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kategori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Marka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsatislisteleme
            // 
            this.btnsatislisteleme.Location = new System.Drawing.Point(531, 20);
            this.btnsatislisteleme.Name = "btnsatislisteleme";
            this.btnsatislisteleme.Size = new System.Drawing.Size(143, 33);
            this.btnsatislisteleme.TabIndex = 4;
            this.btnsatislisteleme.Text = "Satışları Listeleme";
            this.btnsatislisteleme.UseVisualStyleBackColor = true;
            this.btnsatislisteleme.Click += new System.EventHandler(this.btnsatislisteleme_Click);
            // 
            // btnurunlisteleme
            // 
            this.btnurunlisteleme.Location = new System.Drawing.Point(405, 20);
            this.btnurunlisteleme.Name = "btnurunlisteleme";
            this.btnurunlisteleme.Size = new System.Drawing.Size(120, 33);
            this.btnurunlisteleme.TabIndex = 3;
            this.btnurunlisteleme.Text = "Ürün Listeleme";
            this.btnurunlisteleme.UseVisualStyleBackColor = true;
            this.btnurunlisteleme.Click += new System.EventHandler(this.btnurunlisteleme_Click);
            // 
            // btnurunekleme
            // 
            this.btnurunekleme.Location = new System.Drawing.Point(294, 20);
            this.btnurunekleme.Name = "btnurunekleme";
            this.btnurunekleme.Size = new System.Drawing.Size(105, 33);
            this.btnurunekleme.TabIndex = 2;
            this.btnurunekleme.Text = "Ürün Ekleme";
            this.btnurunekleme.UseVisualStyleBackColor = true;
            this.btnurunekleme.Click += new System.EventHandler(this.btnurunekleme_Click);
            // 
            // btnmusterilisteleme
            // 
            this.btnmusterilisteleme.Location = new System.Drawing.Point(136, 20);
            this.btnmusterilisteleme.Name = "btnmusterilisteleme";
            this.btnmusterilisteleme.Size = new System.Drawing.Size(152, 33);
            this.btnmusterilisteleme.TabIndex = 1;
            this.btnmusterilisteleme.Text = "Müşteri Listeleme";
            this.btnmusterilisteleme.UseVisualStyleBackColor = true;
            this.btnmusterilisteleme.Click += new System.EventHandler(this.btnmusterilisteleme_Click);
            // 
            // btnmusteriekleme
            // 
            this.btnmusteriekleme.Location = new System.Drawing.Point(3, 20);
            this.btnmusteriekleme.Name = "btnmusteriekleme";
            this.btnmusteriekleme.Size = new System.Drawing.Size(127, 33);
            this.btnmusteriekleme.TabIndex = 0;
            this.btnmusteriekleme.Text = "Müşteri Ekleme";
            this.btnmusteriekleme.UseVisualStyleBackColor = true;
            this.btnmusteriekleme.Click += new System.EventHandler(this.btnmusteriekleme_Click);
            // 
            // FormSatis
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblgeneltoplam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsatisyap);
            this.Controls.Add(this.btnsatisiptal);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewsatis);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.FormSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewsatis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttoplamfiyat;
        private System.Windows.Forms.TextBox txtsatisfiyati;
        private System.Windows.Forms.TextBox txtmiktari;
        private System.Windows.Forms.TextBox txturunadı;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnsatisiptal;
        private System.Windows.Forms.Button btnsatisyap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblgeneltoplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsatislisteleme;
        private System.Windows.Forms.Button btnurunlisteleme;
        private System.Windows.Forms.Button btnurunekleme;
        private System.Windows.Forms.Button btnmusterilisteleme;
        private System.Windows.Forms.Button btnmusteriekleme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

