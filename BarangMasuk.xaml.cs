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
    /// Interaction logic for BarangMasuk.xaml
    /// </summary>
    public partial class BarangMasuk : Window
    {
        public BarangMasuk()
        {
            InitializeComponent();
        }

        private void OnClickInput(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO barang_masuk(kodemasuk_barang, nama_barang, tglmasuk_barang, jumlah) values (@kodemasuk_barang, @nama_barang, @tglmasuk_barang, @jumlah)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@kodemasuk_barang", KodeMasuk.Text);
            cmd.Parameters.AddWithValue("@nama_barang", Nama_Barang.Text);
            cmd.Parameters.AddWithValue("@tglmasuk_barang", Tanggal_Masuk.Text);
            cmd.Parameters.AddWithValue("@jumlah", Jumlah.Text);
            string message = "Berhasil Ditambahkan!";
            string title = "Pesan";
            MessageBox.Show(message, title);
            cmd.ExecuteNonQuery();  
        }

        

        private void Nama_Barang_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tanggal_Masuk_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Jumlah_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void KodeMasuk_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
     
    }
}
