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
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        bool durum;
        private void BarkodKontrol()
        {
            // Durumu istediğimiz işlemde true, istemediğimiz işlemde false olarak tanımlayacağız.
            durum = true;
            SqlCommand komut = new SqlCommand("Select * From Urun", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                // eğer aradığımız kategori veritabanında varsa durumu false yap
                if (txtbarkodno.Text==read["barkodno"].ToString() || txtbarkodno.Text=="")
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();
        }

        private void kategorigetir()
        {
            SqlCommand komut2 = new SqlCommand("Select * From kategori_bilgileri", bgl.baglanti());
            //bilgileri çekme işleminde sqldatareader kullanıyoruz
            SqlDataReader read = komut2.ExecuteReader();
            //bilgiler okunurken şu işlemleri yap diyoruz.
            while (read.Read())
            {
                cmbkategori.Items.Add(read["kategori"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmarka.Items.Clear();
            cmbmarka.Text = "";
            SqlCommand komut = new SqlCommand("Select * From marka_bilgileri where kategori='"+cmbkategori.SelectedItem+"'", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbmarka.Items.Add(read["marka"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnyeniekle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum==true)
            {
                SqlCommand komut = new SqlCommand("Insert into Urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@p2", cmbkategori.Text);
                komut.Parameters.AddWithValue("@p3", cmbmarka.Text);
                komut.Parameters.AddWithValue("@p4", xtturunadi.Text);
                komut.Parameters.AddWithValue("@p5", int.Parse(txtmiktari.Text)); //Miktarı tamsayi olarak tanımlamıştık yine tamsayıya çeviriyoruz. Gerekli değil ama bazen hata verebiliyor.
                komut.Parameters.AddWithValue("@p6", double.Parse(txtalisfiyati.Text)); //Tamsayı olarak tanımladığımızı ondalklıya çeviriyouz. 
                komut.Parameters.AddWithValue("@p7", double.Parse(txtsatişfiyati.Text));
                komut.Parameters.AddWithValue("@p8", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Barkodno Zaten Var", "Uyarı");    
            }

            cmbmarka.Items.Clear();


            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtvarbarkodno_TextChanged(object sender, EventArgs e)
        {
            if (txtvarbarkodno.Text=="")
            {
                lblmiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            //barkodno ya numara girildiği zaman ürünün diğer bilgileri textlere gelsin
            SqlCommand komut = new SqlCommand("Select * From urun where barkodno like '"+txtvarbarkodno.Text+"'", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtvarkategori.Text = read["kategori"].ToString();
                txtvarmarka.Text = read["marka"].ToString();
                txtvarurunadi.Text = read["urunadi"].ToString();
                lblmiktari.Text = read["miktari"].ToString();
                txtvaralisfiyati.Text = read["alisfiyati"].ToString();
                txtvarsatisfiyati.Text = read["satisfiyati"].ToString();

            }
        }

        private void btnvarolanaekle_Click(object sender, EventArgs e)
        {
            //Update--> güncelle   Set--> neyi güncelleyeceğimiz   where--> neye göre güncelleyeceğimiz
            SqlCommand komut = new SqlCommand("Update Urun set miktari=miktari+'"+int.Parse(txtvarmiktari.Text)+"' where barkodno='"+txtvarbarkodno.Text+"' ",bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı");

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
