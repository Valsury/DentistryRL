   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  '    !Dentistry.Pages.MedicalCouponPage   X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:Dentistry.Pages     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$'  !Медицинская карта�� N� 
Background
 �����.��� -    �Name$ 
GridCanvas�� � RowDefinitions �� $
��auto ��� .+�� $��1��.+��� $��Center=�$��Center=�.+���  �� Orientation$ 
Horizontal=�.+���    
CommonText#��[  $#��Выберите врача: ���� -    ��Name$ ComboDoctors��
�������$��14(� �� 
IsEditable . $��1q� �� DisplayMemberPath$ FullName��$��Center=�$	��200��$��25���� $
��auto��.+���  �� TextAlignment$ Center=�#��[  $��Жалобы: ���� -   	 ��Name$	 TboxComplaint��$	��350��$��40��
 �� TextWrapping$

 Wrap=�$��3q��� $��10q�.+�&   Xceed.Wpf.Toolkit.DateTimePicker  -     Name$ DPSelectedDate��$	��200��$��25��&   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�   FormatString$ dd/mm/yyyy HH:mm��,  &Xceed.Wpf.Toolkit.Primitives.InputBase   	Watermark$, &Выберите дату приема���� -    ��Name$ BtnToAppointment��$��Записаться��
�������
���   �