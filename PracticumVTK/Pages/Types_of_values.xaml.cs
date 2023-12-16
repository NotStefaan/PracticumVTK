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
    /// Логика взаимодействия для Types_of_values.xaml
    /// </summary>
    public partial class Types_of_values : Page
    {
        public Types_of_values()
        {
            InitializeComponent();
        }

        private void Back_btn_TOV_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Variables());
        }

        private void Next_btn_TOV_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Operations());
        }
    }
}
