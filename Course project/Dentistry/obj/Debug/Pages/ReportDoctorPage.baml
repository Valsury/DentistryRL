   M S B A M L   `   `   `  ����D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  5      &     Dentistry.Pages.ReportDoctorPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Dentistry.Pages     5        N� Title$%  Страница отчетов��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      ��    
CommonText#��[  6    �� TextAlignment$
 Left=�6<   $��10��6Q   с6_   (  "System.Windows.Controls.DatePicker  5      -   5        $��PickerStart��5      6.   �� 5      #��[  6   $
 Left=�6<   $��20��6Q   по6`     5      -   5        $��	PickerEnd��5      6,   �� 5      -   5        $��BtnGenerate��5      $��Сформировать��6(   6[   �� 5      -   5        $��BtnPrint��5      $��Печать��6%   6O   5      (  "System.Windows.Controls.WebBrowser  5   
   -   5        $��BrowserReport��5   "   $��1��6   69   5      5      