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
    /// Логика взаимодействия для Window_red_hum.xaml
    /// </summary>
    public partial class Window_red_hum
    {
        public Window_red_hum()
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
            Inform.Content = Resource.PersInf;
            Login.Content = Resource.Log;
            FIO.Content = Resource.FIO;
            Birthday_h.Content = Resource.Birthday;
            Email.Content = Resource.Email;
            Phone_number.Content = Resource.Number;
            Gender_h.Content = Resource.Gender;
            Home.Content = Resource.Home;
            Next.Content = Resource.OK;
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
