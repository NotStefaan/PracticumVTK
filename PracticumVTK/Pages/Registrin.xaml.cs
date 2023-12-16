using PracticumVTK.Data;
using PracticumVTK.Methods;
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
using System.Windows.Shapes;

namespace PracticumVTK.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registrin.xaml
    /// </summary>
    public partial class Registrin : Window
    {
        ApplicationContext db;
        ImgToString img_str;
        private string Avatar_string;
        public Registrin()
        {
            InitializeComponent();

            db = new ApplicationContext();

        }

        private void Login_btn_reg_Click(object sender, RoutedEventArgs e)
        {
            var Page1 = new MainWindow();
            Page1.Show();
            this.Close();
        }

        private void Regin_btn_reg_Click(object sender, RoutedEventArgs e)
        {
            string Username = Name_box_reg.Text.Trim();
            string Lastname = Lastname_box_reg.Text.Trim();
            string Fathername = Father_box_reg.Text.Trim();
            string Password = Pass_box_reg.Password.Trim();
            string Password2 = Pass2_box_reg.Password.Trim();
            string Groupname = Group_box_reg.Text.Trim().ToUpper();
            string Email = Mail_box_reg.Text.Trim().ToLower();

            if (Password != Password2)
            {
                Pass2_box_reg.ToolTip = "Пароли не совпадают";
                Pass2_box_reg.BorderBrush = Brushes.DarkRed;
            }
            else if (Email.Length < 5 || !Email.Contains("@"))
            {
                Mail_box_reg.ToolTip = "Email введён неправильно";
                Mail_box_reg.BorderBrush = Brushes.DarkRed;
            }
            else if (Groupname.Length < 4 || !Groupname.Contains("-"))
            {
                Group_box_reg.ToolTip = "Запись группы должна быть вида: ИТ-41 | ГД-41 и.тд.";
                Group_box_reg.BorderBrush = Brushes.DarkRed;
            }
            else
            {
                Pass2_box_reg.ToolTip = "";
                Pass2_box_reg.BorderBrush = Brushes.Transparent;
                Mail_box_reg.ToolTip = "";
                Mail_box_reg.BorderBrush = Brushes.Transparent;
                Group_box_reg.ToolTip = "";
                Group_box_reg.BorderBrush = Brushes.Transparent;

                User user = new User(Username, Lastname, Fathername, Groupname, Password, Email);

                User validate = null;
                validate = db.Users.Where(z => z.username == user.Username && z.lastname == user.Lastname && z.fathername == user.Fathername && z.groupname == user.Groupname && z.email == user.Email).FirstOrDefault();

                if (validate == null)
                {
                    if (img_str != null)
                    {
                        string Avatar = Avatar_string;
                        User user_with_avatar = new User(Username, Lastname, Fathername, Groupname, Password, Avatar, Email);
                        db.Users.Add(user_with_avatar);
                        db.SaveChanges();
                        MessageBox.Show("Регистрация успешна с изображением");
                    }
                    else
                    {
                        db.Users.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Регистрация успешна без изображения");
                    }
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существует");
                }
            }


        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Avatar_btn_Click(object sender, RoutedEventArgs e)
        {
            img_str = new ImgToString();
            if (img_str != null)
            {
                this.Avatar_string = img_str.ImageStr().ToString(); // Используйте this для обращения к полю класса
            }
            else
                return;
            
        }
    }
}
