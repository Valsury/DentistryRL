   M S B A M L   `   `   `  ����D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  5      '    !Dentistry.Pages.MedicalCouponPage   5      X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Dentistry.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$'  !Медицинская карта��5
       N� 
Background
 �����.��5      � -   5         �Name$ 
GridCanvas��5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   � $��1��6   .+�5      �� $��Center=�6   $��Center=�64   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��    
CommonText#��[  6    $#��Выберите врача: ��5       �� 5      -   5         ��Name$ ComboDoctors��5      
�������$��14(�5       �� 
IsEditable . $��1q�5       �� DisplayMemberPath$ FullName��5      $��Center=�5!      $	��200��5"      $��25��5#      5$      5%      �� 5'      $
��auto��6   .+�5(      ��  �� TextAlignment$ Center=�6    #��[  5)      $��Жалобы: ��5*       �� 5-      -   5        	 ��Name$	 TboxComplaint��5-      $	��350��5.      $��40��6%   
 �� TextWrapping$

 Wrap=�5/       $��3q�50      52      �� 54      $��10q�6   .+�56      &   Xceed.Wpf.Toolkit.DateTimePicker  -   5          Name$ DPSelectedDate��58   $   $	��200��56   *   $��25��57   $   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�59         FormatString$ dd/mm/yyyy HH:mm��5:   *   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   	Watermark$, &Выберите дату приема��5;   $   �� 5=      -   5         ��Name$ BtnToAppointment��5>      $��Записаться��5=      
�������
���   �5A      5C      5D      5H      5J      5K      