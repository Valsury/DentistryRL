   M S B A M L   `   `   `  ����D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  5      +    %Dentistry.Pages.Admin_sReceptionsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Dentistry.Pages     5      -   5          N� Title$*  $Информация о приеме��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridReceptions��5   !   $��1��6      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ Дата приема��6/      CanUserReorder .  1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6D   �� *DateReception+
 �� StringFormat$
 dd.MM.yyyy HH:mm��6�     5      $ * 6%   $ Врач��6/   	 6=   �� *Doctor.FullNameDoctor+  5      $ * 6%   $ Пациент��6/   	 6@   �� *Client.FullNameClient+  5      $ * 6%   $ Жалоба��6/   	 6?   �� *" Appointment.ComplaintAppointment+  5      $ * 6%   $ Диагноз��6/   	 6@   �� *DiagnosisReception+  5      $ * 6%   $ Услуга��6/   	 6?   �� *Service.NameService+  5      $ * 6%   $ Цена��6/   	 6=   �� *Service.PriceService+$
 {0} руб.��  5      $ * 6%   $% Состояние оплаты��6/   	 6I   �� *PaymentStatus+5      �� 5    
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5!      �� -   5        $��
TBoxSearch��5!   :      
TboxSearch#��[  6   6s   5"      �� 5#   
   $ 
Horizontal=�6   $��Right=�6.   .+�5$      �� $��Right=�6    �� TextAlignment$ Right=�64   $ ��Сортировка по:��6J     
CommonText#��[ 6`   $	��160��6�   6�   �� 5%      -   5        $��ComboFilter��5%   �    �� 
IsEditable . 
�������$��Times New Roman)�6<   $��14(�6Y   $��Right=�6h    �� SelectedIndex$ 0��6�   .@�5&      �� $��Дата приема��6   67   �� 5'      $��Врач��6   60   �� 5(      $��Пациент��6   63   �� 5)      $��Услуга��6   62   �� 5*      $��Диагноз��6   63   �� 5+      $��Цена��6   60   �� 5,      $$��Cостояние оплаты��6   6<   �� 5-      $��Жалоба оплаты��6   69   5.      5/      �� 50   
   $��Center=�6   $��Center=�60   $ 
Horizontal=�6M   $��2��6f   .+�51      �� $��Center=�6   $��Center=�64   $ 
Horizontal=�6Q   $��2��6j   .+�52      �� -   5        $��
BtnAddData��52      $��Добавить��6+   6Z   �� 53      -   5        $��BtnChangeData��53      $ ��Редактировать��6.   6e   �� 54      -   5        $��BtnDeleteData��54      $��Удалить��6.   6_   55      56      58      59      