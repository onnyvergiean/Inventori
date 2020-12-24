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
    /// Interaction logic for Karyawan.xaml
    /// </summary>
    public partial class Karyawan : Window
    {
        public Karyawan()
        {
            InitializeComponent();
        }

        private void OnClickInput(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO karyawan(kode_karyawan, nama_karyawan, no_telponkaryawan, sift_karyawan) values (@kode_karyawan, @nama_karyawan, @no_telponkaryawan, @sift_karyawan)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@kode_karyawan", KodeKaryawan.Text);
            cmd.Parameters.AddWithValue("@nama_karyawan", Nama.Text);
            cmd.Parameters.AddWithValue("@no_telponkaryawan", Telepon.Text);
            cmd.Parameters.AddWithValue("@sift_karyawan", Sift.Text);         
            cmd.ExecuteNonQuery();
            string message = "Berhasil Ditambahkan!";
            string title = "Pesan";
            MessageBox.Show(message, title);
            con.Close();
        }

        private void KodeKaryawan_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Telepon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Sift_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
