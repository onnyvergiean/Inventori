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
using System.Data.SqlClient;
using LanguageExt.ClassInstances.Pred;
using Microsoft.Azure.Amqp.Framing;

namespace inventory
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

        private void OnClickBarang(object sender, RoutedEventArgs e)
        {
            Window1 barangWindow = new Window1();
            barangWindow.Show();
        }
        private void OnClickMasuk(object sender, RoutedEventArgs e)
        {
            BarangMasuk barangmasuk = new BarangMasuk();
            barangmasuk.Show();
        }

        private void OnClickKeluar(object sender, RoutedEventArgs e)
        {
            BarangKeluar barangkeluar = new BarangKeluar();
            barangkeluar.Show();
        }

        private void OnClickSup(object sender, RoutedEventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
        }

        private void OnClickAdmin(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void OnClickKaryawan(object sender, RoutedEventArgs e)
        {
            Karyawan karyawn = new Karyawan();
            karyawn.Show();
        }
    }
}
