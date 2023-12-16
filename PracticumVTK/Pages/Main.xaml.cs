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

namespace PracticumVTK.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Exit_main_btn_Click(object sender, RoutedEventArgs e)
        {
            var Login_page = new MainWindow();
            Login_page.Show();
            this.Close();
        }

        private void Theory_main_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Theory());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Practice());
        }

        private void Cabinet_main_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Personal_cabinet());
        }
    }
}
