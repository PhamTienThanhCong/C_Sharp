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
using System.Data.SQLite;

namespace SinhVien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string dbcon = "Data Source = H:\\DATA CODE\\Project_C_Shape\\BaiTap\\WPF_XAM\\SinhVien\\SinhVien\\data.db";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            SQLiteConnection conn = new SQLiteConnection(dbcon);
            conn.Open();
            SQLiteDataAdapter ad = new SQLiteDataAdapter();
            SQLiteCommand cmd = new SQLiteCommand();

            string str = "SELECT * FROM SinhVien";
            cmd.CommandText = str;
            ad.SelectCommand = cmd;
            cmd.Connection = conn;
            SQLiteDataReader reader = cmd.ExecuteReader();



            string r = "";
            TextBox.Text = "";
            while (reader.Read())
            {
                r += String.Format("{0} {1} \n", reader[0], reader[1]);
                string name = reader.GetString(1);
                TextBox.Text += name + "\n";
                Console.WriteLine(r);
            }
            conn.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
