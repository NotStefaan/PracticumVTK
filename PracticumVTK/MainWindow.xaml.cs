using MaterialDesignThemes.Wpf;
using PracticumVTK.Controllers;
using PracticumVTK.Data;
using PracticumVTK.Pages;
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

namespace PracticumVTK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Reg_in_btn_Click(object sender, RoutedEventArgs e)
        {
            var Page2 = new Registrin();
            Page2.Show();
            this.Close();

        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Log_in_btn_Click(object sender, RoutedEventArgs e)
        {
            String Name = Name_box_in.Text.Trim();
            String Lastname = Family_box_in.Text.Trim();
            String Pass = Pass_box_in.Password.Trim();

            
            using (ApplicationContext db = new ApplicationContext())
            {
                UserOBJ.user = db.Users.Where(b => b.username == Name && b.lastname == Lastname && b.password == Pass).FirstOrDefault();
            }
            if (UserOBJ.user != null) 
            {
                var MainPage = new Main();
                MainPage.Show();
                this.Close();
                //MessageBox.Show("Ваша ава:" + UserOBJ.user.Avatar.ToString());
            }
            else
                MessageBox.Show("Проверьте правильность введённых данных или создайте аккаунт.");
        }
    }
}
