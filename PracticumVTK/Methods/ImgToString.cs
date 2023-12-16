using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using MaterialDesignThemes.Wpf;
using System.Windows;
using PracticumVTK.Data;
using System.Xml.Serialization;

namespace PracticumVTK.Methods
{
    internal class ImgToString
    {
        public string ImageStr()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg;*.gif;*.bmp)|*.png;*.jpeg;*.jpg;*.gif;";
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                using (MemoryStream stream = new MemoryStream())
                {
                    using (FileStream file = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        file.CopyTo(stream);
                    }
                    byte[] imageBytes = stream.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }

            }
            else
            {
                return null;
            }
        }
    }
}
