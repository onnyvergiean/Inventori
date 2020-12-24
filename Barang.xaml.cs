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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)// Berat
        {

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e) //Nama
        {

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e) //Barang
        {
            
        }
        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)// Kadaluarsa
        {

        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)// Jumlah
        {

        }
        private void OnClickInput(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO barang(kode_barang, nama_barang, berat_barang, kadaluarsa, jumlah) values (@kode_barang, @nama_barang, @berat_barang, @kadaluarsa, @jumlah)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@kode_barang", TextBox1.Text);
            cmd.Parameters.AddWithValue("@nama_barang", TextBox2.Text);
            cmd.Parameters.AddWithValue("@berat_barang", TextBox.Text);                      
            cmd.Parameters.AddWithValue("@kadaluarsa", TextBox3.Text);
            cmd.Parameters.AddWithValue("@jumlah", TextBox4.Text);
            cmd.ExecuteNonQuery();
            string message = "Berhasil Ditambahkan!";
            string title = "Pesan";
            MessageBox.Show(message, title);
            con.Close();
        }
    }
}
