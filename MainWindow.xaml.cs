using IlacStok.classlar;
using IlacStok.usercontroller;
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
using MySql.Data.MySqlClient;
using MySql.Data;

namespace IlacStok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
           
            InitializeComponent();
       



        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void stok_Click(object sender, RoutedEventArgs e)
        {
            uccagir.uc_ekle(Content_icerik,new Stok());
          
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            uccagir.uc_ekle(Content_icerik, new Stok());
            lbl_toplamilac.Content = tekrar.toplamilac();
            lbl_toplamsatis.Content = tekrar.toplamsatis() + " ₺";

        }

        private void ilac_ekle_Click(object sender, RoutedEventArgs e)
        {
           
            uccagir.uc_ekle(Content_icerik, new ilacekle());
         
        }

        private void guncelle_Click(object sender, RoutedEventArgs e)
        {
            uccagir.uc_ekle(Content_icerik, new guncelle());
            
        }

        private void satis_Click(object sender, RoutedEventArgs e)
        {
            uccagir.uc_ekle(Content_icerik, new satis());
         
        }

        private void satis_arsiv_Click(object sender, RoutedEventArgs e)
        {
            uccagir.uc_ekle(Content_icerik, new satis_arsiv());
         
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lbl_toplamilac.Content = tekrar.toplamilac();
            lbl_toplamsatis.Content = tekrar.toplamsatis() + " ₺";
        }

        private void alt_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
