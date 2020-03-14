using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using IlacStok.classlar;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace IlacStok.classlar
{
   public class dbgrid
    {
        public static bool GridDoldur (DataGrid grd){
            sbyte i = 0;
            MySqlCommand sorgu = new MySqlCommand("SELECT barkod,ilac,firma,adet,fiyat FROM stok", baglan.baglanti);
            try { 
            MySqlDataAdapter data = new MySqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            data.Fill(dt);
            grd.ItemsSource = null;
            grd.ItemsSource = dt.DefaultView;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                baglan.baglanti.Close();
            }
            if (i > 0)
            {
                return true;
            
            }
            else
            {
                return false;
            }

        }
        public static bool SatisGrid (DataGrid grd)
        {
            sbyte i = 0;
            MySqlCommand sorgu = new MySqlCommand("SELECT tarih,ilac,miktar,toplam,tc FROM satis", baglan.baglanti);
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter(sorgu);
                DataTable dt = new DataTable();
                data.Fill(dt);
                grd.ItemsSource = null;
                grd.ItemsSource = dt.DefaultView;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                baglan.baglanti.Close();
            }
            if (i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
