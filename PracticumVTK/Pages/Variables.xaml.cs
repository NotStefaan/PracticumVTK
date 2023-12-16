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
    /// Логика взаимодействия для Variables.xaml
    /// </summary>
    public partial class Variables : Page
    {
        public Variables()
        {
            InitializeComponent();
        }

        private void Next_btn_variables_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Types_of_values());
        }

        private void Back_btn_variables_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Intro());
        }
    }
}
