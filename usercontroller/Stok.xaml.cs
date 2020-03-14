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
using MySql.Data;
using MySql.Data.MySqlClient;
using IlacStok.classlar;
using System.Data;

namespace IlacStok.usercontroller
{
    /// <summary>
    /// Interaction logic for Stok.xaml
    /// </summary>
    public partial class Stok : UserControl
    {
        public Stok()
        {
            InitializeComponent();

            
          
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dbgrid.GridDoldur(data_stok);

        }
    }
}
