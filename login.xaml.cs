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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using MySql.Data;
using IlacStok.classlar;

namespace IlacStok
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
                
                InitializeComponent();
             
        }

        public void btn_giris_Click(object sender, RoutedEventArgs e)
        {
           
            baglan.baglanti.Open();
            MySqlCommand kadisorgu = new MySqlCommand("SELECT username FROM kisi WHERE username=@kadi", baglan.baglanti);
            string kadi = txt_kadi.Text.Trim();
            kadisorgu.Parameters.AddWithValue("@kadi", kadi);
            string username= Convert.ToString(kadisorgu.ExecuteScalar());
            MySqlCommand sifresorgu = new MySqlCommand("SELECT pass FROM kisi WHERE pass=@sifre", baglan.baglanti);
            string sifre = txt_sifre.Password.ToString().Trim();
            sifresorgu.Parameters.AddWithValue("@sifre", sifre);
            
            string pass = Convert.ToString(sifresorgu.ExecuteScalar());
            if (sifre==pass && kadi==username && txt_kadi.Text!="" && txt_sifre.Password!="")
            {
                baglan.baglanti.Close();
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
                
            }
            else
            {
                lbl_message.Content = "Kullanıcı Adı veya Şifre Hatalı";
            }
            baglan.baglanti.Close();
            
        }

        private void btn_cikis_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txt_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                RoutedEventArgs newEventArgs = new RoutedEventArgs(Button.ClickEvent);
                btn_giris.RaiseEvent(newEventArgs);
            }
        }
    }
}
