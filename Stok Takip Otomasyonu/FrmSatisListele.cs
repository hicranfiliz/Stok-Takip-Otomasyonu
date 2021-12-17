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
    public partial class FrmSatisListele : Form
    {
        public FrmSatisListele()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet();

        private void satislistele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From satis", bgl.baglanti());
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            bgl.baglanti().Close();
        }

        private void FrmSatisListele_Load(object sender, EventArgs e)
        {
            satislistele();
        }
    }
}
