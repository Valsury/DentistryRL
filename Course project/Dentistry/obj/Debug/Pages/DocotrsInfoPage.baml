   M S B A M L   `   `   `  ����D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  5      ?$clr-namespace:Dentistry.UserControlsDentistry.UserControls  5          Dentistry.Pages.NewsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Dentistry.Pages     5      =usercontrols$clr-namespace:Dentistry.UserControls     5        N� 
Background
  ����� N� Title$ 	О нас��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��1 �6   6)   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   .+�5   
   �� $��2��6   .��5      �� -   5        $��	LViewNews��5      ��5      �� 5      .R�5      � 6&   5      ��5      �� 5      .R�5      �  5      �� 5    "   62   �� 5!   "   62   .+�5#      �� $
��auto��5$      $
��auto��6#   $��Center=�61   $��	260 0 0 0q�6N   ��5%   "   �� 5&   &    �� 
StartPoint$	 0,0&�6:    �� EndPoint$	 1,2&�6K   .��5'   *   �  � Color$ 	#FFD8F6FD��67    � Offset$	 0.1Q�6I   � 5(   *   $ 	#FFFFE25F��67   $ 1Q�6I   5)   '    J� Clip 5,   "   �� 5-   &    �� RadiusX$ 10Q�5.      	 �� RadiusY$	 10Q�5/      
 �� Rect$
 2,2,600,800�50      51   '   ._�53   "   �� $��Center=�6-   $	��500��6J   .+�55   &   ��    HeaderNewsText#��[  60    �� TextAlignment$
 Left=�6�   $
��Left=�6�   ��6X   �� *Doctor.FullNameDoctor+56   '   �� 57   &    �� Orientation$ Vertical=�62   $
��Left=�6I   .+�58   *   �� $��10 0 0 0q�64   $��20(�6F     
CommonText#��[ 6T   $
��auto��6x   ��6�   �� *" Doctor.Department.NameDepartment+ �� StringFormat$ Отедление: {0}��6�   �� 59   *   $��10 0 0 0q�65   #��[ 6G   $
 Left=�6k   $
��auto��6�   $��Heavy"�6�   $��24(�6�   ��6�   �� *Doctor.WorkExperienceDoctor+$  Стаж работы: {0}��6�   5:   '   �� 5;   &   $��2��6,   $	��230��6X   $
��auto��6e   $��Center=�6r   ��69   �� *PreviewUser+6�   �� 5<   &   #��[ 61   $
��auto��6U   $ Justify=�6b   $��
10 10 10 0q�6z   ��6�   �� *Doctor.DescriptionDoctor+6�   5>   #   5@      �� 5C      $��BtnReception��62   -   5        $��1��5C   %   $*��$Записаться на прием��5D      $��Heavy"�5E      $��14(�60   
���   �$��
260 0 0 15q�5F   0   
������ $
��auto��6]   $	��Top=�6j   6�   5O      5P      5R      5S      5U      5V      