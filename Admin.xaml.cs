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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void kode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void telepon_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void OnClickInput(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO administrator(kode_admin,nama_admin,no_telponadmin) values (@kode_admin, @nama_admin, @no_telponadmin)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@kode_admin", kode.Text);
            cmd.Parameters.AddWithValue("@nama_admin", Nama.Text);
            cmd.Parameters.AddWithValue("@no_telponadmin", telepon.Text);
            cmd.ExecuteNonQuery();
            string message = "Berhasil Ditambahkan!";
            string title = "Pesan";
            MessageBox.Show(message, title);
            con.Close();
           
        }
    }
}
