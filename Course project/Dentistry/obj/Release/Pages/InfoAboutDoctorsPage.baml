   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  *    $Dentistry.Pages.InfoAboutDoctorsPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:Dentistry.Pages     -     N� Title$*  $Информация о врачах�� N� 
Background
 �����.���  � RowDefinitions �� $
��auto ��� $��* ��� $
��auto �.+�&   System.Windows.Controls.DataGrid  -     Name$ 
DGridUsers��$��1��   AutoGenerateColumns .     Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    Header$ Фото��   CellTemplate �� .R��� $��5q����� *PreviewUser+0  *System.Windows.Controls.DataGridTextColumn  $ * $ Имя��1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *
NameUser+  $ * $ Фамилия��	 �� *LastNameUser+  $ * $ Отчество��	 �� *PatronymicUser+  $ * $ Дата рождения��	 �� *DateOfBirthUser+
 �� StringFormat$
 
dd.MM.yyyy��  $ * $ Образование��	 �� *Doctor.EducationDoctor+  $ * $ Отедление��	 �� *" Doctor.Department.NameDepartment+  $ * $ Стаж работы��	 �� *Doctor.WorkExperienceDoctor+  $ * $! Номер телефона��	 �� *Doctor.PhoneNumberDoctor+  $ * $- 'Дата трудоустройства��	 �� *Doctor.EmploymentDateDoctor+$
 
dd.MM.yyyy����  �� Orientation$ 
Horizontal=�$��Center=�.+��� -   $��
TBoxSearch��   
TboxSearch#��[  �� $ 
Horizontal=�$��Right=�.+��� $��Right=� �� TextAlignment$ Right=�$ ��Сортировка по:��  
CommonText#��[ $	��160���� -   $��ComboFilter�� �� 
IsEditable . 
�������$��Times New Roman)�$��14(�$��Right=� �� SelectedIndex$ 0��.@��� $��Имя���� $��Фамилия���� $��Отчество���� $��Дата рождения���� $��Отеделение���� $��Стаж работы���� $!��Номер телефона���� $��Center=�$��Center=�$ 
Horizontal=�$��2��.+��� -   $��
BtnAddData��$��Добавить���� -   $��BtnChangeData��$ ��Редактировать���� -   $��BtnDeleteData��$��Удалить���� -   $��BtnReportData��$��
Отчёт��