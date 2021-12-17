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
    public partial class FrmMusteriListele : Form
    {
        public FrmMusteriListele()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet(); //verileri geçici olarak burada tutmak için

        private void FrmMusteriListele_Load(object sender, EventArgs e)
        {
            //veritabanından çekmek için sqldataadapter ve select kullanıyoruz.
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Musteri ", bgl.baglanti());
            adtr.Fill(daset, "Musteri"); //içine geçici tabloyu ve veritabanındaki tablonun ismini yazıyoruz.
            //çektiğimiz bilgileri datagridwiewde göstermek için:
            dataGridViewmusteri.DataSource = daset.Tables["Musteri"];
            bgl.baglanti().Close();
        }

        private void dataGridViewmusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //bilgileri güncellemek için datagridview e çift tıklandığında textboxlardaki bilgiler girilsin.
            //mskTC.Text = dataGridViewmusteri.CurrentRow.Cells["TC"].Value();
            //txtadsoyad.Text = dataGridViewmusteri.CurrentRow.Cells["adsoyad"].Value.ToString();
            //msktelefon.Text = dataGridViewmusteri.CurrentRow.Cells["telefon"].Value.ToString();
            //txtadres.Text = dataGridViewmusteri.CurrentRow.Cells["adres"].Value.ToString();
            //txtemail.Text dataGridViewmusteri.CurrentRow.Cells["email"].Value.ToString();

            //bilgileri güncellemek için datagridview e çift tıklandığında textboxlardaki bilgiler girilsin.
            int secilen = dataGridViewmusteri.SelectedCells[0].RowIndex;
            mskTC.Text = dataGridViewmusteri.Rows[secilen].Cells[0].Value.ToString();
            txtadsoyad.Text = dataGridViewmusteri.Rows[secilen].Cells[1].Value.ToString();
            msktelefon.Text = dataGridViewmusteri.Rows[secilen].Cells[2].Value.ToString();
            txtadres.Text = dataGridViewmusteri.Rows[secilen].Cells[3].Value.ToString();
            txtemail.Text = dataGridViewmusteri.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Musteri set adsoyad=@p1,telefon=@p2,adres=@p3,email=@p4 where tc=@p5", bgl.baglanti());
            //update= güncelleme komutu. set--> neler güncellenecek?  where--> neye göre? burada tcye göre.
            komut.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p2", msktelefon.Text);
            komut.Parameters.AddWithValue("@p3", txtadres.Text);
            komut.Parameters.AddWithValue("@p4", txtemail.Text);
            komut.Parameters.AddWithValue("@p5", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            //tabloyu temizleyip sonra yeni kayıtı getiriyoruz
            daset.Tables["Musteri"].Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Musteri ", bgl.baglanti());
            adtr.Fill(daset, "Musteri");
            dataGridViewmusteri.DataSource = daset.Tables["Musteri"];
            bgl.baglanti().Close();
            
            MessageBox.Show("Müşteri Bilgisi Güncellendi");

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

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("Delete from Musteri where tc='" + dataGridViewmusteri.CurrentRow.Cells["tc"].Value.ToString + "'", bgl.baglanti());
            SqlCommand komut2 = new SqlCommand("Delete from Musteri where tc=@tc", bgl.baglanti());
            komut2.Parameters.AddWithValue("@tc", mskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            daset.Tables["Musteri"].Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Musteri ", bgl.baglanti());
            adtr.Fill(daset, "Musteri");
            dataGridViewmusteri.DataSource = daset.Tables["Musteri"];
            bgl.baglanti().Close();

            MessageBox.Show("Müşteri Kaydı Silindi");

        }

        private void txtTCara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adtr2 = new SqlDataAdapter("Select * from Musteri where TC like'%" + txtTCara.Text + "%'", bgl.baglanti());
            adtr2.Fill(tablo);  //kayıtları tabloya aktaracağız. sonra datagrid de gçstereceğiz.
            dataGridViewmusteri.DataSource = tablo;
            bgl.baglanti().Close();
        }

        private void mskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
