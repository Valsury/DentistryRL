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

namespace Dentistry.Pages
{
    /// <summary>
    /// Interaction logic for InfoAboutClientsPage.xaml
    /// </summary>
    public partial class InfoAboutUsersPage : Page
    {
        public InfoAboutUsersPage()
        {
            InitializeComponent();
            {



                DGridUsers.ItemsSource = AppData.Context.Users.ToList().Where(p=>p.IdPosition==2);





            }

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DGridUsers.ItemsSource = AppData.Context.Users.ToList().Where(p => p.IdPosition == 2);
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string keyWord = TBoxSearch.Text.ToLower();

            DGridUsers.ItemsSource = AppData.Context.Users.ToList().Where(p => p.IdPosition == 2)
           .Where(p =>
           p.NameUser.ToLower().Contains(keyWord) ||
           p.LastNameUser.ToLower().Contains(keyWord) ||
           p.PatronymicUser.ToLower().Contains(keyWord) ||
           p.Client.SeriesOfPassportClient.ToLower().Contains(keyWord) ||
           p.Client.NumberOfPassportClient.ToLower().Contains(keyWord) ||
           p.Client.PhoneNumberClient.ToLower().Contains(keyWord) ||
            p.Client.AddressClient.ToLower().Contains(keyWord) ||
           p.DateOfBirthUser.ToString().Contains(keyWord)).ToList();


        }

        private void UpdateItems()
        {
           
            var allUsers = AppData.Context.Users.ToList().Where(p=>p.IdPosition==2);
            var allClients = AppData.Context.Clients.ToList();
            switch (ComboFilter.SelectedIndex)
            {
                case 0:
                    allUsers = allUsers.OrderBy(p => p.NameUser).ToList();
                    break;

                case 1:
                    allUsers = allUsers.OrderBy(p => p.LastNameUser).ToList();
                    break;

                case 2:
                    allUsers = allUsers.OrderBy(p => p.PatronymicUser).ToList();
                    break;

                case 3:
                    allUsers = allUsers.OrderBy(p => p.DateOfBirthUser).ToList();
                    break;

                case 4:
                    allClients = allClients.OrderBy(p => p.SeriesOfPassportClient).ToList();
                    break;

                case 5:
                    allClients = allClients.OrderBy(p => p.NumberOfPassportClient).ToList();
                    break;

                case 6:
                    allClients = allClients.OrderBy(p => p.PhoneNumberClient).ToList();
                    break;

                default:
                    allClients = allClients.OrderBy(p => p.IdClient).ToList();
                    break;
            }
            if (DGridUsers != null)
            {
                DGridUsers.ItemsSource = allClients;
                DGridUsers.ItemsSource = allUsers;
            }
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }

        private void BtnChangeData_Click(object sender, RoutedEventArgs e)
        {
            if (DGridUsers.SelectedItem is Entities.User currentUser)
            {
                NavigationService.Navigate(new RegPage(currentUser));


            }

            else
            {
                MessageBox.Show("Выберите данные для редактирования!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAddData_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage(null));
        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {
            if (DGridUsers.SelectedItem is Entities.User currentUser /*&& DGridUsers.SelectedItem is Entities.Client currentClient*/)
            {


                if(MessageBox.Show("Вы действительно хотите удалить данные?","Внимание",MessageBoxButton.YesNo,MessageBoxImage.Warning)==MessageBoxResult.Yes)
                {

                    
                    AppData.Context.Users.Remove(currentUser);
                    AppData.Context.SaveChanges();
                    AppData.Context.Users.ToList();
                    AppData.Context.Clients.ToList();
                    if(MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk)==MessageBoxResult.OK)
                    {
                        DGridUsers.Visibility = Visibility.Hidden;
                        DGridUsers.Visibility = Visibility.Visible;
                    }

                }
            }
        }

        private void BtnReportData_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReportPage());
        }

        private void DGridUsers_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DGridUsers.DataContext = null;
            DGridUsers.ItemsSource = AppData.Context.Users.ToList().Where(p => p.IdPosition == 2);
        }
    }
}
