using System;
using System.Collections.Generic;
using MySql.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using IlacStok.classlar;
using System.Data;


namespace IlacStok.classlar
{
     public class baglan
    {
       
           public static string connectionString = "SERVER=160.153.16.16; DATABASE=entireno; UID=entireno; PASSWORD=$0wPab!(]wxr;";
           public static MySqlConnection baglanti = new MySqlConnection(connectionString);

        public String baglanti_kontrol()
        {
            try
            {
                baglanti.Open();
                return "true";
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }

        }

    }
}
