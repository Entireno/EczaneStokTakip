using IlacStok.classlar;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace IlacStok.usercontroller
{
    /// <summary>
    /// Interaction logic for ilacekle.xaml
    /// </summary>
    public partial class ilacekle : UserControl
    {
        public ilacekle()
        {
            InitializeComponent();
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
           if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Back || e.Key==Key.OemPeriod )
            {
                e.Handled = false;//eğer rakam ve backspace ise ve '.'  yazdır.
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

        private void ekle_Click(object sender, RoutedEventArgs e)

        {
            baglan baglanti = new baglan();

            if (baglanti.baglanti_kontrol() == "true")
            {
                string firma, ilac, barkod, adet, fiyat, fiyat2;
                firma = txt_firma.Text.Trim();
                barkod = txt_barkod.Text.Replace(" ", "");
                adet = txt_adet.Text.Replace(" ", "");
                ilac = txt_ilac.Text.Trim();
                fiyat = txt_fiyat.Text.Replace(" ", "");
                fiyat2 = fiyat.Replace(".", ",");

                MySqlCommand aynisorgu = new MySqlCommand("SELECT barkod FROM stok WHERE barkod=@barkod", baglan.baglanti);
                aynisorgu.Parameters.AddWithValue("@barkod", barkod);
                int Count = Convert.ToInt32(aynisorgu.ExecuteScalar());

                if (txt_firma.Text =="")
                {
                    lbl_message.Content = "Firma ismi boş olamaz";
                }
                else if (txt_ilac.Text =="")
                {
                    lbl_message.Content = "İlac ismi boş olamaz";
                }
                else if (txt_fiyat.Text =="")
                {
                    lbl_message.Content = "Fiyat boş olamaz";
                }
                else if (txt_barkod.Text =="")
                {
                    lbl_message.Content = "Barkod boş olamaz";
                }
                else if (txt_adet.Text =="")
                {
                    lbl_message.Content = "Adet kısmı boş olamaz";
                }
                else if(Count!=0){
                    lbl_message.Content = "Girdiğiniz Barkoda ait bir ürün bulunmaktadır";
                }
                else
                {
                    float gfiyat = (float) Convert.ToDouble(fiyat2);
                    int gadet = Convert.ToInt32(adet);

                    MySqlCommand ekle = new MySqlCommand("INSERT INTO stok(firma,ilac,barkod,adet,fiyat) VALUES (@firma,@ilac,@barkod,@adet,@fiyat)",baglan.baglanti);
                    ekle.Parameters.AddWithValue("@firma", firma);
                    ekle.Parameters.AddWithValue("@ilac", ilac);
                    ekle.Parameters.AddWithValue("@adet", gadet);
                    ekle.Parameters.AddWithValue("@barkod",barkod);
                    ekle.Parameters.AddWithValue("@fiyat", gfiyat);
                    if (ekle.ExecuteNonQuery() == 1)
                    {
                       

                        lbl_message.Content = "Başrıyla Eklendi";
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
                }
                
            }
            else
            {
                lbl_message.Content = "Veri tabanına baglanılamıyor";
            }



            baglan.baglanti.Close();
    


        }
    }
}
