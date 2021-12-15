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

namespace WpfApp3
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

        private void btsothich_click(object sender, RoutedEventArgs e)
        {
            string sothich = "";

            if (chknghenhac.IsChecked == true)
                sothich = "nghe nhac";
            if (chkxemphim.IsChecked == true)
                sothich = sothich + "xem phim";
            if (chkthethao.IsChecked == true)
                sothich = sothich + "choi the thao";
            if (chkmuasam.IsChecked == true)
                sothich = sothich + "di mua sam";
            if (chkdulich.IsChecked == true)
                sothich = sothich + "di du lich";

            MessageBox.Show("so thich cua ban la: " + sothich +",");
        }

        private void btmau_click(object sender, RoutedEventArgs e)
        {
            string mau = "";

            if(rdodo.IsChecked == true)
                mau = "do";
            if (rdotrang.IsChecked == true)
                mau = "trang";
            if (rdovang.IsChecked == true)
                mau = "vang";
            if (rdohong.IsChecked == true)
                mau = "hong";
            if (rdotim.IsChecked == true)
                mau = "tim";
            MessageBox.Show("mau yeu thich cua ban la mau: " + mau);
        }
    }
}
