using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class veriTabaniIslemleri
    {
        string baglantiCumlesi = ConfigurationManager.ConnectionStrings["EOKULBaglantiCumlesi"].ConnectionString;
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

            SqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}
