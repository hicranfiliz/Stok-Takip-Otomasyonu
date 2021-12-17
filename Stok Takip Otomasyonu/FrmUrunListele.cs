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
    public partial class FrmUrunListele : Form
    {
        public FrmUrunListele()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        //kayıtları geçici olarak tuttuğumuz bir tablo ekliyoruz
        DataSet daset = new DataSet();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UrunListele()
        {
            // Bilgileri datagridin içine getirme işlemi:
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Urun", bgl.baglanti());
            adtr.Fill(daset, "Urun");
            dataGridView1.DataSource = daset.Tables["Urun"];
            bgl.baglanti().Close();
        }

        private void FrmUrunListele_Load(object sender, EventArgs e)
        {
            UrunListele();
            kategorigetir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagrid de bir bilginin üzerine çift tıklayınca bütün bilgiler soldaki textlere gelsin
            txtbarkodno.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txtkategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txturunadi.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txtmiktari.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            txtalisfiyati.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            txtsatişfiyati.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            // set--> neler değişecek  where--> neye göre değişecek
            SqlCommand komut = new SqlCommand("Update Urun set urunadi=@p1,miktari=@p2,alisfiyati=@p3,satisfiyati=@p4 where barkodno=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunadi.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse(txtmiktari.Text));
            komut.Parameters.AddWithValue("@p3", double.Parse(txtalisfiyati.Text));
            komut.Parameters.AddWithValue("@p4", double.Parse(txtsatişfiyati.Text));
            komut.Parameters.AddWithValue("@p5", txtbarkodno.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            daset.Tables["Urun"].Clear();
            UrunListele();
            MessageBox.Show("Ürün Kaydı Güncellendi");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnmarkaguncelle_Click(object sender, EventArgs e)
        {
            //yanlış girilmemesi için
            if (txtbarkodno.Text != "")
            {
                SqlCommand komut = new SqlCommand("Update Urun set kategori=@p1,marka=@p2, where barkodno=@p5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", cmbkategori.Text);
                komut.Parameters.AddWithValue("@p2", cmbmarka.Text);
                komut.Parameters.AddWithValue("@p5", txtbarkodno.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Marka ve Kategori Kaydı Güncellendi");
                daset.Tables["Urun"].Clear();
                UrunListele();
            }
            else
            {
                MessageBox.Show("Barkodno Seçili Değil");
            }
            

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmarka.Items.Clear();
            cmbmarka.Text = "";
            SqlCommand komut = new SqlCommand("Select * From marka_bilgileri where kategori='" + cmbkategori.SelectedItem + "'", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbmarka.Items.Add(read["marka"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            daset.Tables["Urun"].Clear();
            UrunListele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtbarkodnoara_TextChanged(object sender, EventArgs e)
        {
            //girilen barkodno ya göre ürünleri listeleyecek kodlar
            // % işaretinin olması aradığım sayı veya harf başta ya da sonda nerede olursa onu getirir
            DataTable tablo = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Urun where barkodno like '%" + txtbarkodnoara.Text + " % '", bgl.baglanti());
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bgl.baglanti().Close();
        }
    }
}
