using System;
using System.IO;
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
using Microsoft.Toolkit.Wpf.UI.Controls;
using System.Threading;
using System.Globalization;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;

namespace Умный_питомец
{
    /// <summary>
    /// Логика взаимодействия для Window_reg_pet.xaml
    /// </summary>
    public partial class Window_reg_pet
    {
        public Window_reg_pet()
        {
            InitializeComponent();
            Lang();
        }


        private void Lang_Ru_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
            Lang();
        }
        private void Lang_En_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Lang();
        }

        private void Lang()
        {
            // Подключение словаря к словам.
            Animal.Content = Resource.Animal;
            Name_1.Content = Resource.Name;
            Type.Content = Resource.Type;
            Breed.Content = Resource.Breed;
            Birthday.Content = Resource.Birthday;
            Weight.Content = Resource.Weight;
            Gender.Content = Resource.Gender;
            Ok.Content = Resource.OK;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            // Открытие следующего окна
            Window newForm = new Window();
            newForm.Show();
            this.Close();
        }
    }
}
