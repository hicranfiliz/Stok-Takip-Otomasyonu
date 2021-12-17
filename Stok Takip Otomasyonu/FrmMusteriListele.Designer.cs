
namespace Stok_Takip_Otomasyonu
{
    partial class FrmMusteriListele
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
            this.dataGridViewmusteri = new System.Windows.Forms.DataGridView();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTCara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmusteri
            // 
            this.dataGridViewmusteri.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewmusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmusteri.Location = new System.Drawing.Point(243, 88);
            this.dataGridViewmusteri.Name = "dataGridViewmusteri";
            this.dataGridViewmusteri.Size = new System.Drawing.Size(423, 194);
            this.dataGridViewmusteri.TabIndex = 0;
            this.dataGridViewmusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmusteri_CellDoubleClick);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(98, 249);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(139, 33);
            this.btnguncelle.TabIndex = 21;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(98, 153);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(139, 26);
            this.msktelefon.TabIndex = 20;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(98, 89);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(139, 26);
            this.mskTC.TabIndex = 19;
            this.mskTC.ValidatingType = typeof(int);
            this.mskTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTC_MaskInputRejected);
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(98, 185);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(139, 26);
            this.txtadres.TabIndex = 18;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(98, 121);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(139, 26);
            this.txtadsoyad.TabIndex = 17;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(98, 217);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(139, 26);
            this.txtemail.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "TC:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "TC Ara";
            // 
            // txtTCara
            // 
            this.txtTCara.Location = new System.Drawing.Point(369, 38);
            this.txtTCara.Name = "txtTCara";
            this.txtTCara.Size = new System.Drawing.Size(100, 26);
            this.txtTCara.TabIndex = 24;
            this.txtTCara.TextChanged += new System.EventHandler(this.txtTCara_TextChanged);
            // 
            // FrmMusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 357);
            this.Controls.Add(this.txtTCara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewmusteri);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FrmMusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewmusteri;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTCara;
    }
}