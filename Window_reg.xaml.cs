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
    /// Логика взаимодействия для Window_reg.xaml
    /// </summary>
    public partial class Window_reg
    {
        public Window_reg()
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
            Next.Content = Resource.Next;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            // Открытие основного окна
            Window_reg_pet newForm = new Window_reg_pet();
            newForm.Show();
            this.Close();
        }
    }
}
