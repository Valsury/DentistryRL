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

        public RegPage(Entities.User selectedUser /*, Entities.Client selectedClient*/)
        {
            InitializeComponent();


            if (selectedUser != null)
            {
                _currentUser = selectedUser;
                TBoxName.Text = _currentUser.NameUser;
                TBoxLastName.Text = _currentUser.LastNameUser;
                TBoxPatronymic.Text = _currentUser.PatronymicUser;
                DtpBirthDate.SelectedDate = _currentUser.DateOfBirthUser;
                TBoxLogin.Text = _currentUser.LoginUser;
                PBoxPass.Password = _currentUser.PasswordUser;
                BtnReg.Content = "Изменить";


                if (_currentUser.PreviewUser != null)
                {
                    ImagePreview.DataContext = _currentUser.PreviewUser;
                }
            }

            //if (selectedClient !=null)
            //{
            //    _currentClient = selectedClient;
            //    TBoxSerie.Text = _currentClient.SeriesOfPassportClient;
            //    TBoxNumber.Text = _currentClient.NumberOfPassportClient;
            //    TBoxPhoneNumber.Text = _currentClient.PhoneNumberClient;

            //}

        }

        private void UpdateData()
        {
            var currentClient = AppData.Context.Clients.ToList();
            var currentUser = AppData.Context.Users.ToList();
        }
       

       public void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if (_currentUser != null /*&& _currentClient != null*/)
            {

                _currentUser.NameUser = TBoxName.Text;
                _currentUser.LastNameUser = TBoxLastName.Text;
                _currentUser.PatronymicUser = TBoxPatronymic.Text;
                _currentUser.DateOfBirthUser = DtpBirthDate.SelectedDate;
                _currentUser.LoginUser = TBoxLogin.Text;
                _currentUser.PasswordUser = PBoxPass.Password;
                 


                if (_previewData != null)
                    _currentUser.PreviewUser = _previewData;

                AppData.Context.SaveChanges();
                UpdateData();
                MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                NavigationService.GoBack();


                //_currentClient.SeriesOfPassportClient = TBoxSerie.Text;
                //_currentClient.NumberOfPassportClient = TBoxNumber.Text;
                //_currentClient.PhoneNumberClient = TBoxPhoneNumber.Text;


            }

            else
            {
                if (TBoxName.Text != "" && TBoxNumber.Text != "" && TBoxLastName.Text != "" && TBoxPhoneNumber.Text != "" && TBoxSerie.Text != "")
                {
                    _currentClient = new Entities.Client
                    {
                        IdClient = AppData.Context.Clients.ToList().Max(P => P.IdClient) + 1,
                       SeriesOfPassportClient = TBoxSerie.Text,
                        NumberOfPassportClient = TBoxNumber.Text,
                        PhoneNumberClient = TBoxPhoneNumber.Text
                    };

                    AppData.Context.Clients.Add(_currentClient);
                    UpdateData();
                    AppData.Context.SaveChanges();
                    


                    _currentUser = new Entities.User
                    {
                        IdUser = AppData.Context.Users.ToList().Max(P => P.IdUser) + 1,
                        NameUser = TBoxName.Text,
                        LastNameUser = TBoxLastName.Text,
                        PatronymicUser = TBoxPatronymic.Text,
                        DateOfBirthUser = DtpBirthDate.SelectedDate,
                        IdPosition = 2,
                        LoginUser = TBoxLogin.Text,
                        PasswordUser = PBoxPass.Password
                    };


                    if (_previewData != null)
                        _currentUser.PreviewUser = _previewData;

                    AppData.Context.Users.Add(_currentUser);
                    UpdateData();
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk);
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
            if(ofd.ShowDialog()==true)
            {
                _previewData = File.ReadAllBytes(ofd.FileName);
            }

            ImagePreview.DataContext = _previewData;
        }
    }
}
