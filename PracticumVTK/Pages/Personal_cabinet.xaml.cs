using PracticumVTK.Controllers;
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
    /// Логика взаимодействия для Personal_cabinet.xaml
    /// </summary>
    public partial class Personal_cabinet : Page
    {
        public Personal_cabinet()
        {
            InitializeComponent();
            Name_pcb.Text = UserOBJ.user.username;
            Lastname_pcb.Text = UserOBJ.user.username;
            Father_pcb.Text = UserOBJ.user.username;
            Group_pcb.Text = UserOBJ.user.username;
            AvatarShow();
        }

        private void AvatarShow() 
        {
            if (UserOBJ.user.avatar != null)
            {
                Avatar_eclipse.Visibility = Visibility.Collapsed;
            }
            else
                return;
        }
    }
}
