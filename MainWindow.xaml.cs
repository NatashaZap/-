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
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow
    {

        public MainWindow()
        {
            InitializeComponent();
            Lang();

        }
        private void Lang()
        {
            // Подключение словаря к словам.
            SmartPet.Content = Resource.SmartPet;
            Login.Content = Resource.Log;
            Password.Content = Resource.Password;
            Logon.Content = Resource.Input;
            Reg.Content = Resource.Regist;
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {

            //string relativePath = @"\\Умный питомец\\Evidence.txt";
            //string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string appStorageFolder = System.IO.Path.Combine(baseFolder, "Evidence.txt");
            //string fullPath = System.IO.Path.Combine(appStorageFolder, relativePath);
            //StreamReader Client = new StreamReader(fullPath);
            //Client.ReadLine();
            //Client.Close();

            //Проверка данных, имеющихся на сервере
            
            // Открытие следующего окна
            Window newForm = new Window();
            newForm.Show();
            this.Close();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            // Открытие окна регистрации
            Window_reg newForm = new Window_reg();
            newForm.Show();
            this.Close();
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
    }
}


