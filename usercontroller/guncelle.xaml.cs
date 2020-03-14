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

namespace IlacStok.usercontroller
{
    /// <summary>
    /// Interaction logic for guncelle.xaml
    /// </summary>
    public partial class guncelle : UserControl
    {
        public guncelle()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            cmb_ilac.Items.Add("İlaç Seçin");
            cmb_ilac.SelectedIndex = 0;
            MySqlCommand stokilac = new MySqlCommand("SELECT * FROM stok",baglan.baglanti);
            baglan.baglanti.Open();
            MySqlDataReader dr;
            dr = stokilac.ExecuteReader();
            
            while (dr.Read()){
                cmb_ilac.Items.Add(dr["ilac"]);
            }
            baglan.baglanti.Close();
        }

        private void cmb_ilac_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbl_message.Content = "";
            baglan.baglanti.Open();
            MySqlCommand secili = new MySqlCommand("SELECT * FROM stok WHERE ilac=@ilac", baglan.baglanti);
            string deger = cmb_ilac.SelectedItem.ToString();
            secili.Parameters.AddWithValue("@ilac", deger);
            MySqlDataReader oku = secili.ExecuteReader();
            if (deger=="İlaç Seçin") {
                txt_adet.Text = "";
                txt_barkod.Text = "";
                txt_firma.Text = "";
                txt_ilac.Text = "";
                txt_fiyat.Text = "";
                
            }
            else { 
           while(oku.Read()) {
                txt_adet.Text = oku["adet"].ToString();
                txt_barkod.Text = oku["barkod"].ToString();
                txt_firma.Text = oku["Firma"].ToString();
                txt_ilac.Text=oku["ilac"].ToString();
                txt_fiyat.Text= oku["fiyat"].ToString();
            }
            }
            baglan.baglanti.Close();
        }

        private void btn_guncelle_Click(object sender, RoutedEventArgs e)
        {
            string firma, ilac, barkod, adet, fiyat,fiyat2;
            firma = txt_firma.Text.Trim();
            barkod = txt_barkod.Text.Replace(" ", "");
            adet = txt_adet.Text.Replace(" ", "");
            ilac = txt_ilac.Text.Trim();
            fiyat = txt_fiyat.Text.Replace(" ", "");
            fiyat2 = fiyat.Replace(".", ",");
            baglan.baglanti.Open();

            string deger = cmb_ilac.SelectedItem.ToString();
            if (deger == "İlaç Seçin")
            {
                lbl_message.Content = "Lütfen İlaç Seçiniz";
            }
            else if (txt_firma.Text == "")
            {
                lbl_message.Content = "Firma ismi boş olamaz";
            }
            else if (txt_ilac.Text == "")
            {
                lbl_message.Content = "İlac ismi boş olamaz";
            }
            else if (txt_fiyat.Text == "")
            {
                lbl_message.Content = "Fiyat boş olamaz";
            }
            else if (txt_barkod.Text == "")
            {
                lbl_message.Content = "Barkod boş olamaz";
            }
            else if (txt_adet.Text == "")
            {
                lbl_message.Content = "Adet kısmı boş olamaz";
            }
            else
            {
                double gfiyat = Convert.ToDouble(fiyat2);
                int gadet = Convert.ToInt32(adet);

                MySqlCommand ekle = new MySqlCommand("UPDATE stok SET firma=@firma, ilac=@ilac, adet=@adet, barkod=@barkod,fiyat=@fiyat WHERE ilac=@deger", baglan.baglanti);
                ekle.Parameters.AddWithValue("@firma", firma);
                ekle.Parameters.AddWithValue("@ilac", ilac);
                ekle.Parameters.AddWithValue("@adet", gadet);
                ekle.Parameters.AddWithValue("@barkod", barkod);
                ekle.Parameters.AddWithValue("@fiyat", gfiyat);
                ekle.Parameters.AddWithValue("@deger", deger);
                if (ekle.ExecuteNonQuery() == 1)
                {
                    lbl_message.Content = "Başarıyla Güncellendi";


                }
                else
                {
                    lbl_message.Content = "Bi sorun oluştu lütfen ilgili kişi ile irtibata geçin";
                }
            }

            baglan.baglanti.Close();

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

        private void txt_barkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Back)
            {
                e.Handled = false;//eğer rakam ve backspace ise  yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void txt_fiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Back || e.Key == Key.OemPeriod)
            {
                e.Handled = false;//eğer rakam ve backspace ise ve '.'  yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void btn_sil_Click(object sender, RoutedEventArgs e)
        {
            string deger = cmb_ilac.SelectedItem.ToString();
            if (deger == "İlaç Seçin")
            {
                lbl_message.Content = "Lütfen İlaç Seçiniz";
            }
            else
            {
                MySqlCommand sil = new MySqlCommand("DELETE FROM stok WHERE ilac=@deger",baglan.baglanti);
                sil.Parameters.AddWithValue("@deger", deger);
                baglan.baglanti.Open();
                if (sil.ExecuteNonQuery() == 1)
                {
                    lbl_message.Content = "Başırıyla Silindi";
                    txt_adet.Text = "";
                   txt_firma.Text = "";
                    txt_fiyat.Text = "";
                    txt_ilac.Text = "";
                   txt_barkod.Text = "";
                 
                }
                else
                {
                    lbl_message.Content = "Bi sorun oluştu lütfen ilgili kişi ile irtibata geçin";
                }
                baglan.baglanti.Close();
            }
        }
    }
}
