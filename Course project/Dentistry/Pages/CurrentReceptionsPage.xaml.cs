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
    /// Interaction logic for CurrentReceptionsPage.xaml
    /// </summary>
    public partial class CurrentReceptionsPage : Page
    {
        public CurrentReceptionsPage()
        {
            InitializeComponent();
            DGridDoctorReceptions.ItemsSource = AppData.Context.Receptions.ToList().Where(p=>p.IdDoctor==Properties.Settings.Default.UserID);
            LoadAndUpdateData();
       
        }
        
        private void LoadAndUpdateData()
        {
            int userId = Properties.Settings.Default.UserID;
            if (userId > 0)
            {
                var currentUser = AppData.Context.Users.ToList().FirstOrDefault(p => p.IdUser == userId);
                var currentDoctor = AppData.Context.Doctors.ToList().FirstOrDefault(p => p.IdDoctor == userId);

                if (currentUser != null && currentDoctor != null)
                {


                    this.DataContext = currentUser;

                }
            };
            
            
        }
    }
}
