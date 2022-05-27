using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SQLite;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StuManApp
{
    /// <summary>
    /// Interaction logic for CreateStudent.xaml
    /// </summary>
    public partial class UpdateStudent : Window
    {
        public string user_id;
        public const string dbcon = "Data Source = H:\\DATA CODE\\Project_C_Shape\\BaiTap\\WPF_XAM\\StuManApp\\StuManDB.db";
        public UpdateStudent(string id)
        {
            user_id = id;
            InitializeComponent();
            showStatus(cmbStatus);
            show_ket_qua_ra_di(user_id);
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != "" || txtClass.Text != "" || cmbStatus.SelectedIndex == -1)
            {
                try
                {
                    //INSERT a student to DB.
                    SQLiteConnection conn = new SQLiteConnection(dbcon);
                    conn.Open();
                    SQLiteDataAdapter ad = new SQLiteDataAdapter();
                    SQLiteCommand cmd = new SQLiteCommand();

                    String str = "UPDATE Student SET Name = '" + txtName.Text.ToString() + "', Class = '"+ txtClass.Text.ToString() + "', Status = '"+ cmbStatus.SelectedValue.ToString() + "' WHERE ID = " + user_id + ";";
                    cmd.CommandText = str;
                    ad.SelectCommand = cmd;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    lblNoti.Content = "Da Thay Doi";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Name/Class/Status is requied.");
            }
        }

        private void cmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void show_ket_qua_ra_di(string result)
        {
            try
            {
                //DELETE person from the data-grid.
                SQLiteConnection conn = new SQLiteConnection(dbcon);
                conn.Open();
                SQLiteDataAdapter ad = new SQLiteDataAdapter();
                SQLiteCommand cmd = new SQLiteCommand();
                String str = "SELECT * FROM Student WHERE ID = " + result + "; ";
                cmd.CommandText = str;
                ad.SelectCommand = cmd;
                cmd.Connection = conn;
                SQLiteDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    txtName.Text = Convert.ToString(r["Name"]);
                    txtClass.Text = Convert.ToString(r["Class"]);
                    cmbStatus.Text = Convert.ToString(r["Status"]);
                }
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).btnRefresh_Click();
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

        public void showStatus(ComboBox cmbStatus)
        {
            cmbStatus.Items.Clear();
            try
            {
                SQLiteConnection conn = new SQLiteConnection(dbcon);
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT ID,Name FROM Status", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Status");
                cmbStatus.ItemsSource = ds.Tables[0].DefaultView;
                cmbStatus.DisplayMemberPath = ds.Tables[0].Columns["Name"].ToString();
                cmbStatus.SelectedValuePath = ds.Tables[0].Columns["Name"].ToString();
                cmbStatus.SelectedIndex = 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
