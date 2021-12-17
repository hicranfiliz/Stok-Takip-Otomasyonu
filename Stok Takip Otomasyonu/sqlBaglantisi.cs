using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stok_Takip_Otomasyonu
{
    class SqlBaglantisi
    {
            public SqlConnection baglanti()
            {
                SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-A0KGUVJ\\;Initial Catalog=Stok_Takip;Integrated Security=True");
                baglan.Open();
                return baglan;
            }
    }
}
