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

namespace Dentistry
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        PersonModel _validation;
        public LoginPage()
        {
            InitializeComponent();
            _validation = new PersonModel();
            this.DataContext = _validation;
        }

        private void BtnNavigate_Click(object sender, RoutedEventArgs e)
        {

            if (TBoxLogin.Text != "" && TBoxPassword.Password != "")
            {
                var currentUser = AppData.Context.Users.ToList().FirstOrDefault(p => p.LoginUser == TBoxLogin.Text && p.PasswordUser == TBoxPassword.Password);

                if (currentUser != null)
                {
                    NavigateUser(currentUser);
                }
                else
                {
                    MessageBox.Show("Пользователь не найден", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Все поля обязательны к заполнению", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void NavigateUser(Entities.User currentUser)
        {
            switch (currentUser.IdPosition)
            {
                case 1:
                    SaveUserSettings(currentUser.IdUser, CheckRemebmer.IsChecked.Value);
                    NavigationService.Navigate(new AdminMenuPage());
                    break;

                case 2:
                    SaveUserSettings(currentUser.IdUser, CheckRemebmer.IsChecked.Value);
                    //NavigationService.Navigate(new Pages.PersonalAreaPage());
                    MessageBox.Show("Функция недоступна!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;

                default:
                    MessageBox.Show("Для данной должности не предусмотрен функционал", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }

        private void SaveUserSettings(int id, bool isCheked)
        {
            if (isCheked)
            {
                Properties.Settings.Default.UserID = id;
                Properties.Settings.Default.Save();
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var UserId = Properties.Settings.Default.UserID;
            if (UserId > 0)
            {

                var currentUser = AppData.Context.Users.ToList().FirstOrDefault(p => p.IdUser == UserId);
                if (currentUser != null)
                {
                    NavigateUser(currentUser);
                }
            }
        }

        private void BtnNews_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.NewsPage());
        }

        private void TBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

            //_validation.Login = TBoxLogin.Text;
            _validation.CheckError("Login");

            //DataContext = null;
            //DataContext = _validation;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.RegPage(null));
        }
    }
}
