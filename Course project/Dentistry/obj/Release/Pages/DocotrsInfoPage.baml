   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  ?$clr-namespace:Dentistry.UserControlsDentistry.UserControls      Dentistry.Pages.NewsPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:Dentistry.Pages     =usercontrols$clr-namespace:Dentistry.UserControls       N� 
Background
  ����� N� Title$ 	О нас��.���  � RowDefinitions �� $
��auto ��� $��1 ��� $��* ��� $
��auto �.+��� $��2��.���� -   $��	LViewNews������ .R�� ���� .R��  �� �� .+��� $
��auto��$
��auto��$��Center=�$��	260 0 0 0q�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,2&�.���  � Color$ 	#FFD8F6FD�� � Offset$	 0.1Q�� $ 	#FFFFE25F��$ 1Q� J� Clip ��  �� RadiusX$ 10Q�	 �� RadiusY$	 10Q�
 �� Rect$
 2,2,600,800�._��� $��Center=�$	��500��.+���    HeaderNewsText#��[   �� TextAlignment$
 Left=�$
��Left=����� *Doctor.FullNameDoctor+��  �� Orientation$ Vertical=�$
��Left=�.+��� $��10 0 0 0q�$��20(�  
CommonText#��[ $
��auto������ *" Doctor.Department.NameDepartment+ �� StringFormat$ Отедление: {0}���� $��10 0 0 0q�#��[ $
 Left=�$
��auto��$��Heavy"�$��24(����� *Doctor.WorkExperienceDoctor+$  Стаж работы: {0}���� $��2��$	��230��$
��auto��$��Center=����� *PreviewUser+�� #��[ $
��auto��$ Justify=�$��
10 10 10 0q����� *Doctor.DescriptionDoctor+�� $��BtnReception��-   $��1��$*��$Записаться на прием��$��Heavy"�$��14(�
���   �$��
260 0 0 15q�
������ $
��auto��$	��Top=�