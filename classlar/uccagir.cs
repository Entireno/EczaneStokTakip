using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IlacStok.classlar
{
    public class uccagir
    {
        public static void uc_ekle (Grid grd ,UserControl uc)
        {
            if (grd.Children.Count > 0)
            {
                grd.Children.Clear();
                grd.Children.Add(uc);
            }
            else
            {
                grd.Children.Add(uc);
            }
        }
    }
}
