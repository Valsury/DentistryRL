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
    /// Interaction logic for NewsPage.xaml
    /// </summary>
    public partial class NewsPage : Page
    {
        public NewsPage()
        {
            InitializeComponent();
            var currentDepartments = AppData.Context.Departments.ToList();
            if (LViewNews != null)
            LViewNews.ItemsSource = AppData.Context.Users.ToList().Where(p => p.IdPosition == 3);
            //UpdateItems();

        }
        private void UpdateItems()
        {
            //var allNews = AppData.Context.News.ToList();
            //if (ComboAuthors.SelectedIndex > 0)
            //{
            //    allNews = allNews.Where(p => p.Author == ComboAuthors.SelectedItem as Entities.Doctor).ToList();
            //}
            //switch (ComboSort.SelectedIndex)
            //{
            //    case 0:
            //        allNews = allNews.OrderBy(p => p.CreationDateNews).ToList();
            //        break;
            //    case 1:
            //        allNews = allNews.OrderBy(p => p.HeaderNews).ToList();
            //        break;
            //    case 2:
            //        allNews = allNews.OrderBy(p => p.TextNews).ToList();
            //        break;
            //    default:
            //        allNews = allNews.OrderBy(p => p.Author.NameAuthor).ThenBy(p => p.CreationDateNews).ToList();
            //        break;
 

        }



        private void ComboSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }

       


        private void BtnReception_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MedicalCouponPage());
        }

        private void ComboDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }
    }
}
