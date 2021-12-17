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
    public partial class FormSatis : Form
    {
        public FormSatis()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet();

        private void sepetlistele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From sepet",bgl.baglanti());
            adtr.Fill(daset, "sepet");
            dataGridViewsatis.DataSource = daset.Tables["sepet"];
            dataGridViewsatis.Columns[0].Visible = false;
            dataGridViewsatis.Columns[1].Visible = false;
            dataGridViewsatis.Columns[2].Visible = false;

            bgl.baglanti().Close();
        }

        private void btnmusteriekleme_Click(object sender, EventArgs e)
        {
            FrmMüsteriEkle fr = new FrmMüsteriEkle();
            fr.Show();
        }

        private void btnmusterilisteleme_Click(object sender, EventArgs e)
        {
            FrmMusteriListele fr2 = new FrmMusteriListele();
            fr2.Show();
        }

        private void btnurunekleme_Click(object sender, EventArgs e)
        {
            FrmUrunEkle fr3 = new FrmUrunEkle();
            fr3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMarka fr4 = new FrmMarka();
            fr4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKategori fr5 = new FrmKategori();
            fr5.Show();
        }

        private void btnurunlisteleme_Click(object sender, EventArgs e)
        {
            FrmUrunListele fr6 = new FrmUrunListele();
            fr6.Show();
        }

        private void FormSatis_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void mskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskTC.Text=="")
            {
                txtadsoyad.Text = "";
                msktelefon.Text = "";
            }
            SqlCommand komut = new SqlCommand("Select * From musteri where tc like '%" + mskTC.Text + "%'", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtadsoyad.Text = read["adsoyad"].ToString();
                msktelefon.Text = read["telefon"].ToString();
            }

        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            if (txtbarkodno.Text=="")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtmiktari)
                        {
                            item.Text = "";
                        }
                    }
                    
                }
            }
            SqlCommand komut = new SqlCommand("Select * From Urun where barkodno like '" + txtbarkodno.Text + "'", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtsatisfiyati.Text = read["satisfiyati"].ToString();
                txturunadı.Text = read["urunadi"].ToString();
            }
        }

        //Barkod no aynıysa eklenen ürünün üzerine ekleme
        bool durum;
        private void BarkodKontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select * From sepet",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (txtbarkodno.Text==dr["barkodno"].ToString())
                {
                    durum = false;
                }
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum==true)
            {
                SqlCommand komut = new SqlCommand("Insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyat,tarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mskTC.Text);
                komut.Parameters.AddWithValue("@p2", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@p3", msktelefon.Text);
                komut.Parameters.AddWithValue("@p4", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@p5", txturunadı.Text);
                komut.Parameters.AddWithValue("@p6", int.Parse(txtmiktari.Text));
                komut.Parameters.AddWithValue("@p7", double.Parse(txtsatisfiyati.Text));
                komut.Parameters.AddWithValue("@p8", double.Parse(txttoplamfiyat.Text));
                komut.Parameters.AddWithValue("@p9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                bgl.baglanti().Close();
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("Update sepet set miktari=miktari+'" + int.Parse(txtmiktari.Text) + "'  where barkodno= '" + txtbarkodno.Text + "'", bgl.baglanti());
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("Update sepet set toplamfiyat=miktari*satisfiyati where barkodno= '" + txtbarkodno.Text + "'", bgl.baglanti());
                bgl.baglanti().Close();
            }
            
            txtmiktari.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtmiktari)
                        {
                            item.Text = "";
                        }
                    }

                }
            
        }

        private void txtmiktari_TextChanged(object sender, EventArgs e)
        {
            // Burada çarpma işlemi yapılacak. Try Catch bloğu ile
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtmiktari.Text) * double.Parse(txtsatisfiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtsatisfiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtmiktari.Text) * double.Parse(txtsatisfiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from sepet where barkodno='" + dataGridViewsatis.CurrentRow.Cells["barkodno"].Value.ToString() + "'",bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnsatisiptal_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from sepet ", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnsatislisteleme_Click(object sender, EventArgs e)
        {
            FrmSatisListele fr7 = new FrmSatisListele();
            fr7.Show();
        }

        private void hesapla()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select sum(toplamfiyat) from sepet ",bgl.baglanti());
                lblgeneltoplam.Text = komut.ExecuteScalar() + "TL";
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            //satış yapıldıktan sonra stoktan düşecek
            for (int i = 0; i < dataGridViewsatis.Rows.Count-1; i++)
            {
                SqlCommand komut = new SqlCommand("Insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyat,tarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mskTC.Text);
                komut.Parameters.AddWithValue("@p2", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@p3", msktelefon.Text);
                komut.Parameters.AddWithValue("@p4", dataGridViewsatis.Rows[i].Cells["barkodno"].Value.ToString());
                //demek istenilen kaç tane kayıt varsa onu barkod satırına aktar..
                komut.Parameters.AddWithValue("@p5", dataGridViewsatis.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@p6", int.Parse(dataGridViewsatis.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@p7", double.Parse(dataGridViewsatis.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@p8", double.Parse(dataGridViewsatis.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@p9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("Update Urun set miktari=miktari-'" + int.Parse(dataGridViewsatis.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + dataGridViewsatis.Rows[i].Cells["barkodno"].Value.ToString() + "' ", bgl.baglanti());
                // Kayıtta Kaç tane varsa o kadarının stoktan düşmesi lazım.
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                
            }
            MessageBox.Show("Satış Yapıldı");
            
            SqlCommand komut3 = new SqlCommand("Delete from sepet ", bgl.baglanti());
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();


        }
    }
}
