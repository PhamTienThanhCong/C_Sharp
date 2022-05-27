using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Data.SQLite;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StuManApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string dbcon = "Data Source = H:\\DATA CODE\\Project_C_Shape\\BaiTap\\WPF_XAM\\StuManApp\\StuManDB.db";
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                //LOAD data from database.
                SQLiteConnection conn = new SQLiteConnection(dbcon);
                conn.Open();
                SQLiteDataAdapter ad = new SQLiteDataAdapter();
                SQLiteCommand cmd = new SQLiteCommand();
                String str = "SELECT * FROM Student";
                cmd.CommandText = str;
                ad.SelectCommand = cmd;
                cmd.Connection = conn;
                DataSet ds = new DataSet();
                ad.Fill(ds);
                studentList.ItemsSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateStudent newStudent = new CreateStudent();
            this.Close();
            newStudent.Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)studentList.SelectedItem;
                String result = (dataRowView["Id"]).ToString();
                UpdateStudent updateStudent = new UpdateStudent(result);
                updateStudent.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Grab the Id field from the personList data-grid and store it in the result variable.
            DataRowView dataRowView = (DataRowView)studentList.SelectedItem;
            String result = (dataRowView["Id"]).ToString();
            try
            {
                //DELETE person from the data-grid.
                SQLiteConnection conn = new SQLiteConnection(dbcon);
                conn.Open();
                SQLiteDataAdapter ad = new SQLiteDataAdapter();
                SQLiteCommand cmd = new SQLiteCommand();
                String str = "DELETE FROM Student WHERE ID = " + result + ";";
                cmd.CommandText = str;
                ad.SelectCommand = cmd;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                lblMess.Content = "Deleted a selected student";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //personList.Items.Refresh();
                //REFRESH person from the data-grid.
                SQLiteConnection conn = new SQLiteConnection(dbcon);
                conn.Open();
                SQLiteDataAdapter ad = new SQLiteDataAdapter();
                SQLiteCommand cmd = new SQLiteCommand();
                String str = "SELECT * FROM Student";
                cmd.CommandText = str;
                ad.SelectCommand = cmd;
                cmd.Connection = conn;
                DataSet ds = new DataSet();
                ad.Fill(ds);
                studentList.ItemsSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public void btnRefresh_Click()
        {
            //LOAD data from database.
            SQLiteConnection conn = new SQLiteConnection(dbcon);
            conn.Open();
            SQLiteDataAdapter ad = new SQLiteDataAdapter();
            SQLiteCommand cmd = new SQLiteCommand();
            String str = "SELECT * FROM Student";
            cmd.CommandText = str;
            ad.SelectCommand = cmd;
            cmd.Connection = conn;
            DataSet ds = new DataSet();
            ad.Fill(ds);
            studentList.ItemsSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
