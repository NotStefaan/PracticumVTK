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
    /// Логика взаимодействия для Convert_types.xaml
    /// </summary>
    public partial class Convert_types : Page
    {
        public Convert_types()
        {
            InitializeComponent();
        }

        private void Back_btn_Convert_types_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Operations());
        }

        private void Next_btn_Convert_types_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cycles());
        }
    }
}
