using mshtml;
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
    /// Interaction logic for ReportDoctorPage.xaml
    /// </summary>
    public partial class ReportDoctorPage : Page
    {
        public ReportDoctorPage()
        {
            InitializeComponent();
        }
        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            var currentUsers = AppData.Context.Users.ToList().Where(p => p.IdPosition == 3);

            if (PickerStart.SelectedDate.HasValue == true)
            {
                currentUsers = currentUsers.Where(p => p.DateOfBirthUser >= PickerStart.SelectedDate.Value).ToList();
            }
            if (PickerEnd.SelectedDate.HasValue == true)
            {
                currentUsers = currentUsers.Where(p => p.DateOfBirthUser <= PickerEnd.SelectedDate.Value).ToList();
            }

            var result = new StringBuilder();

            // Основные теги перед генерацией таблицы.
            result.Append("<html>");
            result.Append("<meta charset='utf-8'/>");
            result.Append("<body>");

            // Заголовок отчета.
            result.Append("<p align='center'> <b>Отчет по пользователям</b> </p>");

            // Тег с параметрами таблицы.
            result.Append("<table width=100% border=1 bordercolor=#000 style='border-collapse:collapse;'>");

            // Настройка строк и столбцов внутри. tr - строка, td - столбец.
            result.Append("<tr>");
            // Необходимые заголовки таблицы.
            result.Append("<td align=center><b>Имя</b></td>");
            result.Append("<td align=center><b>Фамилия</b></td>");
            result.Append("<td align=center><b>Отчество</b></td>");
            result.Append("<td align=center><b>Дата рождения</b></td>");
            result.Append("</tr>");

            // Генерация содержимого через цикл.
            foreach (var item in currentUsers)
            {
                // Настройка строк и столбцов внутри. tr - строка, td - столбец.
                result.Append("<tr>");
                // Обращение к переменной item и получение необходимого свойства в соответствии с заголовком.
                result.Append($"<td align=center>{item.NameUser}</td>");
                result.Append($"<td align=center>{item.LastNameUser}</td>");
                result.Append($"<td align=center>{item.PatronymicUser}</td>");
                result.Append($"<td align=center>{item.DateOfBirthUser}</td>");
                result.Append("</tr>");
            }

            // Закрытие основных тегов.
            result.Append("</table>");
            result.Append("</body>");
            result.Append("</html>");

            // Загрузка отчета в WebBrowser.
            BrowserReport.NavigateToString(result.ToString());
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            // Чтобы подключить объект IHTMLDocument2 необходимо добавить ссылку на Microsoft.mshtml (References - Assemblies).
            var document = BrowserReport.Document as IHTMLDocument2;
            document.execCommand("Print");
        }
    }
}
