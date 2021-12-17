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

namespace Stok_Takip_Otomasyonu
{
    public partial class FrmMüsteriEkle : Form
    {
        public FrmMüsteriEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmMüsteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Musteri (TC,adsoyad,telefon,adres,email) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtadres.Text);
            komut.Parameters.AddWithValue("@p5", txtemail.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Eklendi.");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
