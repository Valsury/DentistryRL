   M S B A M L   `   `   `  ����D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  5      (    "Dentistry.Pages.InfoAboutUsersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Dentistry.Pages     5      -   5          N� 
Background
  ����� N� Title$0 *Информация о пациентах��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��auto �6    60   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGridUsers��5   O   $��1��6B      AutoGenerateColumns .     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6)      Header$ Фото��63      CellTemplate 5      �� 5      .R�5      �� $��5q�6$   ��6/   �� *PreviewUser+6Q   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ * 6%   $ Имя��6/   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6<   �� *
NameUser+  5      $ * 6%   $ Фамилия��6/   	 6@   �� *LastNameUser+  5      $ * 6%   $ Отчество��6/   	 6A   �� *PatronymicUser+  5      $ * 6%   $ Дата рождения��6/   	 6F   �� *DateOfBirthUser+
 �� StringFormat$
 
dd.MM.yyyy��  5      $ * 6%   $  Cерия паспотра��6/   	 6G   �� *Client.SeriesOfPassportClient+  5       $ * 6%   $! Номер паспорта��6/   	 6G   �� *Client.NumberOfPassportClient+  5!      $ * 6%   $! Номер телефона��6/   	 6G   �� *Client.PhoneNumberClient+  5"      $ * 6%   $! Номер телефона��6/   	 6G   �� *Client.AddressClient+5$      �� 5&   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5'      �� -   5        $��
TBoxSearch��5'   :      
TboxSearch#��[  6   6s   5(      �� 5)   
   $ 
Horizontal=�6   $��Right=�6.   .+�5*      �� $��Right=�6    �� TextAlignment$ Right=�64   $ ��Сортировка по:��6J     
CommonText#��[ 6`   $	��160��6�   6�   �� 5+      -   5        $��ComboFilter��5+   �    �� 
IsEditable . 
�������$��Times New Roman)�6<   $��14(�6Y   $��Right=�6g    �� SelectedIndex$ 0��6�   .@�5,      �� $��Имя��6   6/   �� 5-      $��Фамилия��6   63   �� 5.      $��Отчество��6   64   �� 5/      $��Дата рождения��6   69   �� 50      $!��Серия паспорта��6   6:   �� 51      $!��Номер паспорта��6   6:   �� 52      $!��Номер телефона��6   6:   53      54      �� 55   
   $��Center=�6   $��Center=�60   $ 
Horizontal=�6M   $��2��6f   .+�56      �� -   5        $��
BtnAddData��56      $��Добавить��6'   6V   �� 57      -   5        $��BtnChangeData��57      $ ��Редактировать��6*   6a   �� 58      -   5        $��BtnDeleteData��58      $��Удалить��6*   6[   �� 59      -   5        $��BtnReportData��59      $��
Отчёт��6*   6Y   5:      5<      5=      