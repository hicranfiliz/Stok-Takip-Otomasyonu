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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        // Var olan kategorinin tekrar girilmesini engellemek için
        // Önce bool tipinde bir değişken tanımlarız

        bool durum;
        private void kategoriengelle()
        {
            // Durumu istediğimiz işlemde true, istemediğimiz işlemde false olarak tanımlayacağız.
            durum = true;
            SqlCommand komut = new SqlCommand("Select * From kategori_bilgileri", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                // eğer aradığımız kategori veritabanında varsa durumu false yap
                if (txtkategori.Text==read["kategori"].ToString() || txtkategori.Text=="")
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum==true)
            {
                SqlCommand komut = new SqlCommand("Insert into kategori_bilgileri(kategori) values('" + txtkategori.Text + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Zaten Var", "Uyarı");
            }
            txtkategori.Text = "";

        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {

        }
    }
}
