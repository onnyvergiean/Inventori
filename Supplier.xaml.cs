using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace inventory
{
    /// <summary>
    /// Interaction logic for Supplier.xaml
    /// </summary>
    public partial class Supplier : Window
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void OnClickInput(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO supplier(kode_supplier, nama_supplier, no_telpon, alamat) values (@kode_supplier, @nama_supplier, @no_telpon, @alamat)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@kode_supplier", KodeSupplier.Text);
            cmd.Parameters.AddWithValue("@nama_supplier", NamaSupplier.Text);
            cmd.Parameters.AddWithValue("@no_telpon", NoTelepon.Text);
            cmd.Parameters.AddWithValue("@alamat", Alamat.Text);
            cmd.ExecuteNonQuery();
            string message = "Berhasil Ditambahkan!";
            string title = "Pesan";
            MessageBox.Show(message, title);
            con.Close();
        }

        private void KodeSupplier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NamaSupplier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NoTelepon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Alamat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
