   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  e aPresentationFramework.AeroLite, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35kNclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroLiteMicrosoft.Windows.Themes &     Dentistry.Pages.AddReceptionPage   X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:Dentistry.Pages     aThemesNclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroLite       N� 
Background
  ����� N� Title$7 1Добавление данных о приеме��.��� .+��� $��Center=�$��Center=�.+���  �� Orientation$ 
Horizontal=�.+��� $��	Дата:��   
CommonText#��[  &   Xceed.Wpf.Toolkit.DateTimePicker  -   $��DPickerReceptionDate��$	��200��$��25��&   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�   FormatString$ dd/MM/yyyy HH:mm��,  &Xceed.Wpf.Toolkit.Primitives.InputBase   	Watermark$, &Выберите дату приема���� $ 
Horizontal=�.+��� $��
Врач: ��#��[  �� -   $��ComboDoctors�� �� 
IsEditable . 
������� �� DisplayMemberPath$ FullName��$��5q� �� SelectedIndex$ 0��$��1q��� $ 
Horizontal=�.+��� $��Пациент: ��#��[  �� -   $��ComboClients�� . 
�������$ FullName��$��5q�$ 0��$��1q��� $ 
Horizontal=�.+��� $��Услуга: ��#��[  �� -   $��ComboServices�� . 
�������$ NameService��$��5q�$ 0��$��1q��� $ 
Horizontal=�.+��� $��Диагноз: ��#��[  �� -   $��TBoxDiagnosis��$	��200��$��50��	 �� TextWrapping$
	 Wrap=�$��Times New Roman)�$��14(�$��3q��� $ 
Horizontal=�$��0 5 0 0q�.+��� $ ��Статус оплаты:��#��[  �� -   $��TBoxPayment��$	��150��$
	 Wrap=�$��Times New Roman)�$��14(�$��3q��� -   $��BtnAddReception��$��Добавить��$��10q�