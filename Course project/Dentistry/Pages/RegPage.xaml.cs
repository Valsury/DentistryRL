using Microsoft.Win32;
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

namespace Dentistry.Pages
{
    /// <summary>
    /// Interaction logic for RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        private Entities.User _currentUser;
        private Entities.Client _currentClient;
        private byte[] _previewData;


        public RegPage(Entities.User selectedUser)
        {
            InitializeComponent();
            ComboGender.ItemsSource = AppData.Context.Genders.ToList();



            if (selectedUser != null)
            {
                _currentUser = selectedUser;
                TBoxName.Text = _currentUser.NameUser;
                TBoxLastName.Text = _currentUser.LastNameUser;
                TBoxPatronymic.Text = _currentUser.PatronymicUser;
                DtpBirthDate.Value = _currentUser.DateOfBirthUser;
                TBoxLogin.Text = _currentUser.LoginUser;
                PBoxPass.Password = _currentUser.PasswordUser;
                TBoxSerie.Text = _currentUser.Client.SeriesOfPassportClient;
               TBoxNumber.Text = _currentUser.Client.NumberOfPassportClient;
               TBoxPhoneNumber.Text = _currentUser.Client.PhoneNumberClient;
                TBoxAddress.Text = _currentUser.Client.AddressClient;
                BtnReg.Content = "Изменить";


                if (_currentUser.PreviewUser != null)
                {
                    ImagePreview.DataContext = _currentUser.PreviewUser;
                }
            }


        }


        private void UpdateData()
        {
            var currentClient = AppData.Context.Clients.ToList();
            var currentUser = AppData.Context.Users.ToList();


        }


        public void BtnReg_Click(object sender, RoutedEventArgs e)
        {

            if (_currentUser != null)
            {

                _currentUser.NameUser = TBoxName.Text;
                _currentUser.LastNameUser = TBoxLastName.Text;
                _currentUser.PatronymicUser = TBoxPatronymic.Text;
                _currentUser.DateOfBirthUser = DtpBirthDate.Value;
                _currentUser.LoginUser = TBoxLogin.Text;
                _currentUser.PasswordUser = PBoxPass.Password;
                _currentUser.Client.SeriesOfPassportClient = TBoxSerie.Text;
                _currentUser.Client.NumberOfPassportClient = TBoxNumber.Text;
                _currentUser.Client.PhoneNumberClient = TBoxPhoneNumber.Text;
                _currentUser.Client.AddressClient = TBoxAddress.Text;




                if (_previewData != null)
                    _currentUser.PreviewUser = _previewData;

                AppData.Context.SaveChanges();
                UpdateData();
                MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                NavigationService.GoBack();





            }

            else
            {
                if (TBoxName.Text != "" && TBoxNumber.Text != "" && TBoxLastName.Text != "" && TBoxPhoneNumber.Text != "" && TBoxSerie.Text != "")
                {


                    var hashClass = new Classes.SHA1Hashing();
                    var hashedpass = hashClass.HashString(PBoxPass.Password);

                    _currentUser = new Entities.User
                    {
                        IdUser = AppData.Context.Users.ToList().Max(P => P.IdUser) + 1,
                        NameUser = TBoxName.Text,
                        LastNameUser = TBoxLastName.Text,
                        PatronymicUser = TBoxPatronymic.Text,
                        DateOfBirthUser = DtpBirthDate.Value,
                        IdPosition = 2,
                        IdGender = (ComboGender.SelectedItem as Entities.Gender).IdGender,
                        LoginUser = TBoxLogin.Text,
                        Client = new Entities.Client
                        {
                            IdClient = AppData.Context.Users.ToList().Max(P => P.IdUser) + 1,
                            SeriesOfPassportClient = TBoxSerie.Text,
                            NumberOfPassportClient = TBoxNumber.Text,
                            PhoneNumberClient = TBoxPhoneNumber.Text,
                            AddressClient = TBoxAddress.Text
                            
                        },
                        PasswordUser = hashedpass
                    };


                    if (_previewData != null)
                        _currentUser.PreviewUser = _previewData;

                    AppData.Context.Users.Add(_currentUser);
                    UpdateData();
                    AppData.Context.SaveChanges();
                    if (MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk) == MessageBoxResult.OK)
                    {
                        NavigationService.GoBack();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }



            }



        }

        private void BtnChooseImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images | *.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == true)
            {
                _previewData = File.ReadAllBytes(ofd.FileName);
            }

            ImagePreview.DataContext = _previewData;
        }

        private void OnConfPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PBoxComfPass.Password.Length > 0)
                TBlockComfPass.Visibility = Visibility.Collapsed;
            else
                TBlockComfPass.Visibility = Visibility.Visible;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PBoxPass.Password.Length > 0)
                TBlockPass.Visibility = Visibility.Collapsed;
            else
                TBlockPass.Visibility = Visibility.Visible;
        }
    }
}
