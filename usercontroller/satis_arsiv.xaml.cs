using IlacStok.classlar;
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

namespace IlacStok.usercontroller
{
    /// <summary>
    /// Interaction logic for satis_arsiv.xaml
    /// </summary>
    public partial class satis_arsiv : UserControl
    {
        public satis_arsiv()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dbgrid.SatisGrid(satis);
        }
    }
}
