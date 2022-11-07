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
    /// Логика взаимодействия для Window.xaml
    /// </summary>
    public partial class Window
    {
        public Window()
        {
            InitializeComponent();
            Lang();

            //Чтение из файла построчно

            StreamReader Client = new StreamReader("C:/Users/natas/source/repos/Умный питомец/Client inform.txt");

            //Познее файлы данных будут находиться в ApplicationData и следующий код будет их открывать:

            //var relativePath = @"Умный питомец/Client inform.txt";
            //string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string appStorageFolder = System.IO.Path.Combine(baseFolder, "Client inform.txt");
            //string fullPath = System.IO.Path.Combine(appStorageFolder, relativePath);
            //StreamReader Client = new StreamReader(fullPath);
            Login_human.Text = Client.ReadLine();
            FIO_human.Text = Client.ReadLine();
            Birthday_human.Text = Client.ReadLine();
            Email_human.Text = Client.ReadLine();
            Phone_number_human.Text = Client.ReadLine();
            Gender_human.Text = Client.ReadLine();
            Home_human.Text = Client.ReadLine();
            int col = int.Parse(Client.ReadLine()); // Количество животных
            Id_pet.Text = Client.ReadLine();
            Name_pet.Text = Client.ReadLine();
            Name.Content = Name_pet.Text;
            Type_pet.Text = Client.ReadLine();
            Breed_pet.Text = Client.ReadLine();
            Birthday_pet.Text = Client.ReadLine();
            Weight_pet.Text = Client.ReadLine();
            Gender_pet.Text = Client.ReadLine();
            Friends_pet.Text = Client.ReadLine();
            Rating_pet.Text = Client.ReadLine();
            Frequency1.Text = Client.ReadLine();
            TextSize.Text = Client.ReadLine();
            Client.Close(); //Закрытие файла

            // Смена стиля
            List<string> styles = new List<string> { "light", "dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "light";

            //Подключение карт (данный ключ зарегестрирован на сайте https://www.bingmapsportal.com/Application )
            var mapControl = new MapControl();
            mapControl.MapServiceToken = "Aqc-Vhqb7_l6kOcoFQuXh8D5-fhegPi0sSk7cFhBoJgQCepIa2OmSFx8wwiX3a5Q";
            mapControl.Children.Add(mapControl);

            var mapControl2 = new MapControl();
            mapControl2.MapServiceToken = "Aqc-Vhqb7_l6kOcoFQuXh8D5-fhegPi0sSk7cFhBoJgQCepIa2OmSFx8wwiX3a5Q";
            mapControl2.Children.Add(mapControl2);

            var mapControl_Pet = new MapControl();
            mapControl_Pet.MapServiceToken = "Aqc-Vhqb7_l6kOcoFQuXh8D5-fhegPi0sSk7cFhBoJgQCepIa2OmSFx8wwiX3a5Q";
            mapControl_Pet.Children.Add(mapControl_Pet);

            var mapControl_All = new MapControl();
            mapControl_All.MapServiceToken = "Aqc-Vhqb7_l6kOcoFQuXh8D5-fhegPi0sSk7cFhBoJgQCepIa2OmSFx8wwiX3a5Q";
            mapControl_All.Children.Add(mapControl_All);

            var mapControl_Fr = new MapControl();
            mapControl_Fr.MapServiceToken = "Aqc-Vhqb7_l6kOcoFQuXh8D5-fhegPi0sSk7cFhBoJgQCepIa2OmSFx8wwiX3a5Q";
            mapControl_Fr.Children.Add(mapControl_Fr);

        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            System.Windows.ResourceDictionary resourceDict = Application.LoadComponent(uri) as System.Windows.ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Что-то важное
        }
        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            //копируем ID в буфер
            Clipboard.SetText(Id_pet.Text);
        }
        private void Rus_Click(object sender, RoutedEventArgs e)
        {
            //Меняем язык системы
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
            Lang();
        }

        private void Eng_Click(object sender, RoutedEventArgs e)
        {
            //Меняем язык системы
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Lang();
        }
        private void Lang()
        {
            // Подключение словаря к словам.
            Sett.Header = Resource.Settings;
            Animal.Header = Resource.Animal;
            Inter.Header = Resource.Interface;
            PerInf.Header = Resource.PersInf; 
            Nastroiki2.Header = Resource.Choose;
            MyPet.Header = Resource.MyPet;
            Map.Header = Resource.Map;
            Friend.Header = Resource.Friends;
            FindFr.Header = Resource.FindFr;
            Delete.Content = Resource.DelProf;
            Exit.Content = Resource.LogOut;
            Edit.Content = Resource.Edit;
            Edit_human.Content = Resource.ChangeH;
            Inform.Content = Resource.PersInf;
            Login.Content = Resource.Log;
            FIO.Content = Resource.FIO;
            Birthday_h.Content = Resource.Birthday;
            Email.Content = Resource.Email;
            Phone_number.Content = Resource.Number;
            Gender_h.Content = Resource.Gender;
            Gender.Content = Resource.Gender;
            Home.Content = Resource.Home;
            Allower_distance.Content = Resource.Distance;
            Download.Content = Resource.UpPhoto;
            Edit_pet.Content = Resource.Edit;
            Id.Content = Resource.ID;
            Name_1.Content = Resource.Name;
            Type.Content = Resource.Type;
            Breed.Content = Resource.Breed;
            Birthday.Content = Resource.Birthday;
            Weight.Content = Resource.Weight;
            Gender.Content = Resource.Gender;
            Friends.Content = Resource.Friends;
            Comm.Content = Resource.Comments;
            Settings.Content = Resource.Settings;
            Size.Content = Resource.TextSize;
            Topic.Content = Resource.Theme;
            Frequency.Content = Resource.FreqOfReq;
            Proposal.Content = Resource.Lang;
            Condition.Content = Resource.CurStat;
            Pulse.Content = Resource.Pulse;
            Temperatura.Content = Resource.Temp;
            Distance.Content = Resource.Distance;
            Found.Content = Resource.Find;
        }

        private void FoundFriends_Click(object sender, RoutedEventArgs e)
        {
            
        }


        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            // Specify a known location.
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 59.9386, Longitude = 30.3141 };
            var cityCenter = new Geopoint(cityPosition);

            // Set the map location.
            await (sender as MapControl).TrySetViewAsync(cityCenter);
        }

        private void Edit_hum_Click(object sender, RoutedEventArgs e)
        {
            Window_red_hum newForm = new Window_red_hum();
            newForm.Show();
            this.Close();
        }
    }
}
