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
    /// Interaction logic for MedicalCouponPage.xaml
    /// </summary>
    public partial class MedicalCouponPage : Page
    {
        public MedicalCouponPage()
        {
            InitializeComponent();
            LoadAndUpdateData();
            
        }

        private void LoadAndUpdateData()
        {
            int userId = Properties.Settings.Default.UserID;
            if (userId > 0)
            {
                var currentUser = AppData.Context.Users.ToList().FirstOrDefault(p => p.IdUser == userId);
                var currentClient = AppData.Context.Clients.ToList().FirstOrDefault(p => p.IdClient == userId);

                if (currentUser != null && currentClient != null)
                {


                    this.DataContext = currentUser;

                }
            };
        }

        private void TblockDate_Loaded(object sender, RoutedEventArgs e)
        {
            

     

        }

        private void TblockAge_Loaded(object sender, RoutedEventArgs e)
        {
        //    int userId = Properties.Settings.Default.UserID;
        //    var currentUser = AppData.Context.Users.ToList().FirstOrDefault(p => p.IdUser == userId);
        //    var Bday = currentUser.DateOfBirthUser.Value;

        //    DateTime now = DateTime.Today;
        //    var age = now.Year - Bday.Year;
        //    if (Bday > now.AddYears(-age)) age--;

        //    int currentAge = age;
        //    string text;
        //    int last = currentAge % 10;
        //    int beforelast;
        //    if (currentAge.ToString().Length == 3)
        //        beforelast = int.Parse(currentAge.ToString()[1].ToString());
        //    else if (currentAge.ToString().Length == 2)
        //        beforelast = int.Parse(currentAge.ToString()[0].ToString());
        //    else
        //        beforelast = 0;

        //    switch(beforelast)
        //    {
        //        case 1:
        //            text = "лет";
        //            break;
        //        default:
        //            switch(last)
        //            {
        //                case 1:
        //                    text = "год";
        //                    break;

        //                case int n when n>= 2 && n <=4:
        //                    text = "годa";
        //                    break;
        //                default:
        //                    text = "лет";
        //                    break;
                                
        //            }
        //            break;
        //    }

        //    TblockAge.Text = currentAge + " " + text;

        }




        private void ComboDoctors_Loaded(object sender, RoutedEventArgs e)
        {
            var Doctors = AppData.Context.Users.ToList().Where(p => p.IdPosition == 3);
            ComboDoctors.ItemsSource = Doctors;
            if (ComboDoctors.SelectedIndex != -1)
            {
                var currentDocotor = (ComboDoctors.SelectedItem as Entities.User).Doctor;
                currentDocotor.Users.ToList();
               

            }


        }

        private void ComboDoctors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentDocotor = ComboDoctors.SelectedItem as Entities.User;
           
        }
            

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            if(ComboDoctors.SelectedItem != null && TboxComplaint.Text != null)
            {

                //PrintDialog printDialog = new PrintDialog();
                //if (printDialog.ShowDialog() == true)
                //{
                //    GridCanvas.Visibility = Visibility.Hidden;

                //    printDialog.PrintVisual(CanvasCoupon, "Распечатываем элемент Canvas");

                //    CanvasCoupon.LayoutTransform = null;
                //    GridCanvas.Visibility = Visibility.Visible;
                //}
                if(TboxComplaint.Text!="")
                {
                    Entities.Appointment currAppointment = new Entities.Appointment
                    {
                        IdAppointment = AppData.Context.Appointments.ToList().Max(P => P.IdAppointment) + 1,
                        DateAppointment = DPSelectedDate.Value,
                        IdClient = Properties.Settings.Default.UserID,
                        IdDoctor = (ComboDoctors.SelectedItem as Entities.User).Doctor.IdDoctor,
                        IdUser = Properties.Settings.Default.UserID,
                        ComplaintAppointment = TboxComplaint.Text
                    };

                    AppData.Context.Appointments.Add(currAppointment);
                    AppData.Context.Appointments.ToList();
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Успешно!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    NavigationService.GoBack();
                }
                else
                {
                    MessageBox.Show("Заполните поле для жалоб!", "Информация", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }

            }
            else
            {
                MessageBox.Show("Все данные должны быть указаны!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

           
             
            

        }



    }
    
}
