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
        public LoginPage()
        {
            InitializeComponent();

            //хэширование паролей в базе
            //    var allusers = AppData.Context.Users.ToList();
            //    var hashing = new Classes.SHA1Hashing();
            //    foreach (var user in allusers)
            //    {
            //        user.PasswordUser = hashing.HashString(user.PasswordUser);
            //    }
            //    AppData.Context.SaveChanges();
        }


        private void BtnNavigate_Click(object sender, RoutedEventArgs e)
        {

            var hashedPass = new Classes.SHA1Hashing().HashString(PBoxPassword.Password);

            if (TBoxLogin.Text != "" && PBoxPassword.Password != "")
            {
                var currentUser = AppData.Context.Users.ToList().FirstOrDefault(p => p.LoginUser == TBoxLogin.Text && p.PasswordUser == hashedPass);

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
            AppData.CurrentUser = currentUser;
            switch (currentUser.IdPosition)
            {
                case 1:
                    SaveUserSettings(currentUser.IdUser, CheckRemebmer.IsChecked.Value);
                    NavigationService.Navigate(new AdminMenuPage());
                    break;

                case 2:
                    SaveUserSettings(currentUser.IdUser, CheckRemebmer.IsChecked.Value);
                    NavigationService.Navigate(new Pages.PersonalAreaPage(null));
                    break;

                case 3:
                    SaveUserSettings(currentUser.IdUser, CheckRemebmer.IsChecked.Value);
                    NavigationService.Navigate(new Pages.DoctorPage());

                    //MessageBox.Show("Функция недоступна!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;

                default:
                    MessageBox.Show("Для данной должности не предусмотрен функционал", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }

        public void SaveUserSettings(int id, bool isChecked)
        {
            Entities.User user = new Entities.User();
            if (isChecked)
            {
                if (user.IdPosition != 4)
                {
                    Properties.Settings.Default.UserID = id;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                if (user.IdPosition != 4)
                {
                    Properties.Settings.Default.UserID = id;
                }
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


        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.RegPage(null));
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {



            if (PBoxPassword.Password.Length > 0)
            {
                TBlockPass.Visibility = Visibility.Collapsed;

            }

            else
                TBlockPass.Visibility = Visibility.Visible;
        }
    }
}
