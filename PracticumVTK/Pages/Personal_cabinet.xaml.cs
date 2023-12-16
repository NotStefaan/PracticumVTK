using PracticumVTK.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Drawing;


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
                
                string Avatar_string = UserOBJ.user.avatar;
                try
                {
                    System.Drawing.Image image = ConvertBase64ToImage(Avatar_string);
                    BitmapSource bitmapSource = ConvertImageToBitmapSource(image);

                    ImageBrush imageBrush = new ImageBrush(bitmapSource);
                    Avatar_eclipse.Fill = imageBrush;
                }
                catch (Exception)
                {
                    MessageBox.Show("Неудачная конвертация изображения");
                }
            }
            else
                return;
        }

        static System.Drawing.Image ConvertBase64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                    return new Bitmap(image); // Создаем новый объект Bitmap из изображения
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при преобразовании Base64 в изображение: {ex.Message}");
                return null;
            }
        }

        private BitmapSource ConvertImageToBitmapSource(System.Drawing.Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new MemoryStream(memoryStream.ToArray());
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }
    }
}
