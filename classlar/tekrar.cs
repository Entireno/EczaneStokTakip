using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;

namespace IlacStok.classlar
{
    public static class tekrar
    {
        public static string toplamsatis() {

            baglan.baglanti.Open();
            MySqlCommand toplamsatis = new MySqlCommand("SELECT SUM(toplam) as toplam FROM satis", baglan.baglanti);
            string toplam = Convert.ToString(toplamsatis.ExecuteScalar());
           
            baglan.baglanti.Close();
            return toplam;
            

           


        }
        public static string toplamilac()
        {
            baglan.baglanti.Open();
            MySqlCommand toplamilac = new MySqlCommand("SELECT SUM(adet) as toplam FROM stok", baglan.baglanti);
            string ilactoplam = Convert.ToString(toplamilac.ExecuteScalar());
            baglan.baglanti.Close();
            return ilactoplam;
        }


    }
}
