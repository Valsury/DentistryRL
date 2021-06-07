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
    /// Interaction logic for AddReceptionPage.xaml
    /// </summary>
    public partial class AddReceptionPage : Page
    {
        private Entities.Reception _currentReception;
        public AddReceptionPage(Entities.Reception selectedReception)
        {
            InitializeComponent();



            ComboDoctors.ItemsSource = AppData.Context.Users.ToList().Where(p=>p.IdPosition==3);
            ComboClients.ItemsSource = AppData.Context.Users.ToList().Where(p => p.IdPosition == 2);
            ComboServices.ItemsSource = AppData.Context.Services.ToList();



            if (selectedReception != null)
            {
                _currentReception = selectedReception;

                //(ComboClients.SelectedItem as Entities.User).Client.IdClient = _currentReception.Client.FullNameClient;
                //(ComboDoctors.SelectedItem as Entities.User).Doctor.IdDoctor = _currentReception.Doctor.FullNameDoctor;
                ComboServices.SelectedItem = _currentReception.Service.NameService;
                DPickerReceptionDate.SelectedDate = _currentReception.DateReception;
                TBoxDiagnosis.Text = _currentReception.DiagnosisReception;
               BtnAddReception.Content = "Изменить";
                Title = "Редактирование данных о приеме";
            }

        }


        private void UpdateData()
        {

            AppData.Context.Users.ToList();
            AppData.Context.Receptions.ToList();
           
            if (ComboDoctors.SelectedIndex > 0)
            {
             
                var currentDoctor = (ComboDoctors.SelectedItem as Entities.User).Doctor;
            }
                
            if(ComboServices.SelectedIndex > 0)
            {
           
                var currentService = (ComboServices.SelectedItem as Entities.Service).NameService;
            }

            if(ComboClients.SelectedIndex > 0)
            {
          
                var currentClient = (ComboClients.SelectedItem as Entities.User).Client;
            }
              
            
        }

        private void ComboClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
   
            UpdateData();

        }

        private void BtnAddReception_Click(object sender, RoutedEventArgs e)
        {

            if (_currentReception != null)
            {

                _currentReception.Client = (ComboClients.SelectedItem as Entities.User).Client;
                _currentReception.Doctor = (ComboDoctors.SelectedItem as Entities.User).Doctor;
                _currentReception.Service = ComboServices.SelectedItem as Entities.Service;
                _currentReception.DateReception = DPickerReceptionDate.SelectedDate;
              _currentReception.DiagnosisReception = TBoxDiagnosis.Text;




                AppData.Context.SaveChanges();
                UpdateData();
               if(MessageBox.Show("Успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk)==MessageBoxResult.OK)
                {
                    NavigationService.GoBack();
                }
                



            }

            else
            {
                if (ComboClients.SelectedItem != null && ComboDoctors.SelectedItem != null && ComboServices.SelectedItem != null && TBoxDiagnosis.Text != "" && DPickerReceptionDate.SelectedDate != null)
                {
                    _currentReception = new Entities.Reception
                    {
                        IdReception = AppData.Context.Receptions.ToList().Max(P => P.IdReception) + 1,
                        DateReception = DPickerReceptionDate.SelectedDate,
                        Client= (ComboClients.SelectedItem as Entities.User).Client,
                    Doctor = (ComboDoctors.SelectedItem as Entities.User).Doctor,
                        Service = (ComboServices.SelectedItem as Entities.Service),
                        DiagnosisReception = TBoxDiagnosis.Text
                    };

                    AppData.Context.Receptions.Add(_currentReception);
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

        private void ComboServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void ComboDoctor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }
    }
}
