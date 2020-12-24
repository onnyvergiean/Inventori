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
    /// Interaction logic for BarangKeluar.xaml
    /// </summary>
    public partial class BarangKeluar : Window
    {
        public BarangKeluar()
        {
            InitializeComponent();
        }

        private void OnClickInput(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO barang_keluar(kodekeluar_barang, nama_barang, tglkeluar_barang, jumlah) values (@kodekeluar_barang, @nama_barang, @tglkeluar_barang, @jumlah)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@nama_barang", Nama.Text);
            cmd.Parameters.AddWithValue("@tglkeluar_barang", Tanggal.Text);
            cmd.Parameters.AddWithValue("@jumlah", Jumlah.Text);
            cmd.Parameters.AddWithValue("@kodekeluar_barang", KodeKeluar.Text);
            cmd.ExecuteNonQuery();
            string message = "Berhasil Ditambahkan!";
            string title = "Pesan";
            MessageBox.Show(message, title);
            con.Close();
        }

        private void KodeKeluar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tanggal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Jumlah_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
