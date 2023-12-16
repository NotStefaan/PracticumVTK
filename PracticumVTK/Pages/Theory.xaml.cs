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
    /// Логика взаимодействия для Theory.xaml
    /// </summary>
    public partial class Theory : Page
    {
        public Theory()
        {
            InitializeComponent();
        }

        private void Intro_theory_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Intro());
        }

        private void Variables_theory_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Variables());
        }

        private void TypesOfValues_theory_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Types_of_values());
        }

        private void Operations_theory_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Operations());
        }

        private void Convert_types_theory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Convert_types());
        }

        private void Cycles_theory_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cycles());
        }
    }
}
