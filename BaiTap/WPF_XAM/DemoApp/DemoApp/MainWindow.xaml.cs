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

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Gioi_Tinh1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String text = "";
            text += "Xin chào " + Ho_Va_Ten.Text +"\n";
            String gioiTinh = "khong";
            if (Gioi_Tinh.IsChecked == false)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                gioiTinh = "Nam";
            }
            text += "Giới tính: " + gioiTinh + "\nNgành: ";
            if (nganh_ai.IsChecked == true)
            {
                text += "Ngành AI, ";
            }
            if (nganh_it.IsChecked == true)
            {
                text += "Ngành IT, ";
            }
            ListBoxItem myItem = khoa.SelectionBoxItem as ListBoxItem;
            
            text += "\nKhóa: " + myItem.Content.ToString();
            MessageBox.Show(text, "Thông tin sinh viên");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ho_Va_Ten.Text = String.Empty;
            nganh_ai.IsChecked = false;
            nganh_it.IsChecked = false;
            Gioi_Tinh.IsChecked = false;
            Gioi_Tinh1.IsChecked = false;
            khoa.SelectedIndex = -1;
        }
    }
}
