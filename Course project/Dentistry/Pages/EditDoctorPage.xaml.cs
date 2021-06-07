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
    /// Interaction logic for EditDoctorPage.xaml
    /// </summary>
    public partial class EditDoctorPage : Page
    {
        private Entities.User _currentUser;
        private byte[] _previewData;
        public EditDoctorPage(Entities.User selectedUser)
        {
            InitializeComponent();
            ComboDepartments.ItemsSource = AppData.Context.Departments.ToList();
            if (selectedUser != null)
            {
                _currentUser = selectedUser;
                TBoxName.Text = _currentUser.NameUser;
                TBoxLastName.Text = _currentUser.LastNameUser;
                TBoxPatronymic.Text = _currentUser.PatronymicUser;
                DtpBirthDate.SelectedDate = _currentUser.DateOfBirthUser;
                TBoxLogin.Text = _currentUser.LoginUser;
                TBoxWorkExp.Text = _currentUser.Doctor.WorkExperienceDoctor;
                TBoxPhoneNumber.Text = _currentUser.Doctor.PhoneNumberDoctor;
                ComboDepartments.SelectedItem = _currentUser.Doctor.Department.NameDepartment;
                TboxEducation.Text = _currentUser.Doctor.EducationDoctor;
                PBoxPass.Password = _currentUser.PasswordUser;
                BtnReg.Content = "Изменить";
                Title = "Редактирование данных о враче";


                if (_currentUser.PreviewUser != null)
                {
                    ImagePreview.DataContext = _currentUser.PreviewUser;
                }
            }


        }

        private void UpdateData()
        {
            var currentClient = AppData.Context.Doctors.ToList();
            var currentUser = AppData.Context.Users.ToList();

            


        }


        public void BtnReg_Click(object sender, RoutedEventArgs e)
        {

            if (_currentUser != null)
            {

                _currentUser.NameUser = TBoxName.Text;
                _currentUser.LastNameUser = TBoxLastName.Text;
                _currentUser.PatronymicUser = TBoxPatronymic.Text;
                _currentUser.DateOfBirthUser = DtpBirthDate.SelectedDate;
                _currentUser.LoginUser = TBoxLogin.Text;
                _currentUser.PasswordUser = PBoxPass.Password;
                _currentUser.Doctor.WorkExperienceDoctor = TBoxWorkExp.Text;
                _currentUser.Doctor.Department = ComboDepartments.SelectedItem as Entities.Department;
                _currentUser.Doctor.PhoneNumberDoctor = TBoxPhoneNumber.Text;
                _currentUser.Doctor.EducationDoctor = TboxEducation.Text;




                if (_previewData != null)
                    _currentUser.PreviewUser = _previewData;

                AppData.Context.SaveChanges();
                UpdateData();
                if(MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk)==MessageBoxResult.OK)
                NavigationService.GoBack();



            }

            else
            {
                if (TBoxName.Text != "" && ComboDepartments.Text != null && TBoxLastName.Text != "" && TBoxPhoneNumber.Text != "" && TBoxWorkExp.Text != "")
                {
                    var currentDepartment = ComboDepartments.SelectedItem as Entities.Department;

                    var hashClass = new Classes.SHA1Hashing();
                    var hashedpass = hashClass.HashString(PBoxPass.Password);

                    _currentUser = new Entities.User
                    {
                        IdUser = AppData.Context.Users.ToList().Max(P => P.IdUser) + 1,
                        NameUser = TBoxName.Text,
                        LastNameUser = TBoxLastName.Text,
                        PatronymicUser = TBoxPatronymic.Text,
                        DateOfBirthUser = DtpBirthDate.SelectedDate,
                        IdPosition = 3,
                        LoginUser = TBoxLogin.Text,
                        Doctor = new Entities.Doctor
                        {
                            IdDoctor = AppData.Context.Doctors.ToList().Max(P => P.IdDoctor) + 1,
                            PhoneNumberDoctor = TBoxPhoneNumber.Text,
                            WorkExperienceDoctor = TBoxWorkExp.Text,
                            EducationDoctor = TboxEducation.Text,
                            EmploymentDateDoctor = DateTime.Now,
                            Department = currentDepartment
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

        private void ComboDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboDepartments.SelectedIndex > 0)
            {
                var currentDepartment = ComboDepartments.SelectedItem as Entities.Department;
            }
                
        }
    }
}

