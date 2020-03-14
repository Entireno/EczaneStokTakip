using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using IlacStok.classlar;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Timers;
namespace IlacStok.usercontroller
{
    /// <summary>
    /// Interaction logic for satis.xaml
    /// </summary>
    public partial class satis : UserControl
    {
        public satis()
        {
            InitializeComponent();
        }

        private void txt_tc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Back)
            {
                e.Handled = false;//eğer rakam ve backspace  ise  yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void txt_adet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Back)
            {
                e.Handled = false;//eğer rakam ve backspace  ise  yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            cmb_ilac.Items.Add("İlaç Seçin");
            cmb_ilac.SelectedIndex = 0;
            MySqlCommand stokilac = new MySqlCommand("SELECT * FROM stok", baglan.baglanti);
            baglan.baglanti.Open();
            MySqlDataReader dr;
            dr = stokilac.ExecuteReader();

            while (dr.Read())
            {
                cmb_ilac.Items.Add(dr["ilac"]);
            }
            baglan.baglanti.Close();
        }

        private void cmb_ilac_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {
           
            lbl_message.Content = "";
            baglan.baglanti.Open();
            string money;
            MySqlCommand secili = new MySqlCommand("SELECT fiyat FROM stok WHERE ilac=@ilac", baglan.baglanti);
            string deger = cmb_ilac.SelectedItem.ToString();
            secili.Parameters.AddWithValue("@ilac", deger);

            money = Convert.ToString(secili.ExecuteScalar());
            if (deger == "İlaç Seçin")
            {
                lbl_fiyat.Content = "";
                lbl_toplam.Content = "0";
                txt_adet.Text = "";
                txt_tc.Text="";

            }
            else
            {


                lbl_fiyat.Content = money;
               
            }
            if (txt_adet.Text != ""  && deger!= "İlaç Seçin")
            {
                double toplamfiyat;
                money = Convert.ToString(secili.ExecuteScalar());
                string adet;
                adet = txt_adet.Text;
                toplamfiyat = Convert.ToDouble(money) * Convert.ToDouble(adet);
                lbl_toplam.Content = toplamfiyat;
            }
            else
            {
                lbl_toplam.Content = "0";
            }
            baglan.baglanti.Close();
        }

        private void txt_adet_TextChanged(object sender, TextChangedEventArgs e)
        {

            if(cmb_ilac.SelectedItem.ToString() != "İlaç Seçin" && txt_adet.Text!="") {
            baglan.baglanti.Open();
            string money;
            double toplamfiyat;
            MySqlCommand secili = new MySqlCommand("SELECT fiyat FROM stok WHERE ilac=@ilac", baglan.baglanti);
            string deger = cmb_ilac.SelectedItem.ToString();
            secili.Parameters.AddWithValue("@ilac", deger);

            money = Convert.ToString(secili.ExecuteScalar());
            string adet;
            adet = txt_adet.Text.Replace(" ","");
            toplamfiyat =Convert.ToDouble( money) * Convert.ToDouble(adet);

                
                lbl_toplam.Content = toplamfiyat;
            }
            baglan.baglanti.Close();
        }

        private void btn_satis_Click(object sender, RoutedEventArgs e)
        {
            
            string deger = cmb_ilac.SelectedItem.ToString();
            string adet = txt_adet.Text.Replace(" ", "");
            baglan.baglanti.Open();
            MySqlCommand secili = new MySqlCommand("SELECT adet FROM stok WHERE ilac=@ilac", baglan.baglanti);
            secili.Parameters.AddWithValue("@ilac", deger);
            string miktar= Convert.ToString(secili.ExecuteScalar());
            baglan.baglanti.Close();
            
            if (deger == "İlaç Seçin")
            {
                lbl_message.Content = "Lütfen İlaç Seçiniz";
            }
            else if(txt_adet.Text==""){
                lbl_message.Content = "Lütfen Adet Sayısını giriniz";
            }
            else if (txt_tc.Text == "")
            {
                lbl_message.Content = "Lütfen Tc giriniz";
            }
            else if (txt_tc.Text.Length != 11)
            {
                lbl_message.Content = " Tc No yu düzgün giriniz";
            }
            else if (Convert.ToInt32( adet) > Convert.ToInt32( miktar))
            {
                lbl_message.Content = "Stokta "+miktar+ " "+ deger+" bulunmaktadır";
            }
            
            else
            {
                string tc, money;
                double toplamfiyat;
                money = lbl_fiyat.Content.ToString();
           
                toplamfiyat = Convert.ToDouble(money) * Convert.ToDouble(adet);
                tc = txt_tc.Text.Replace(" ", "");
                DateTime zaman = DateTime.Now;
                baglan.baglanti.Open();

                MySqlCommand ekle = new MySqlCommand("INSERT INTO satis(ilac,miktar,tarih,tc,toplam) VALUES (@ilac,@adet,@tarih,@tc,@toplamfiyat)", baglan.baglanti);
                ekle.Parameters.AddWithValue("@adet",adet );
                ekle.Parameters.AddWithValue("@ilac", deger);
                ekle.Parameters.AddWithValue("@toplamfiyat",toplamfiyat);
                ekle.Parameters.AddWithValue("@tc", tc);
                ekle.Parameters.AddWithValue("@tarih", zaman);
                if (ekle.ExecuteNonQuery() == 1)
                {
                    MySqlCommand guncelle = new MySqlCommand("UPDATE stok SET adet=@adet WHERE ilac=@deger", baglan.baglanti);
                    int kalan = Convert.ToInt32(miktar) - Convert.ToInt32(adet);
                    guncelle.Parameters.AddWithValue("@deger", deger);
                    guncelle.Parameters.AddWithValue("@adet",kalan);
                    guncelle.ExecuteNonQuery();
                    lbl_message.Content = "Başarıyla Satıldı";
                    txt_adet.Text = "";
                    txt_tc.Text = "";
                    lbl_toplam.Content= "0";
                    lbl_fiyat.Content = "";


                }
                else
                {
                    lbl_message.Content = "Bi sorun oluştu lütfen ilgili kişi ile irtibata geçin";
                }
                
            }
           
        }
    }
}
