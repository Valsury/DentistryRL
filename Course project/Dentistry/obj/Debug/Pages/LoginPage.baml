   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      H DXamlFlair.WPF, Version=1.2.8.0, Culture=neutral, PublicKeyToken=nullN7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPFXamlFlair.Controls 5      <.clr-namespace:XamlFlair;assembly=XamlFlair.WPF	XamlFlair 5      D @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dentistry	Dentistry 5	         Dentistry.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6cor&clr-namespace:System;assembly=mscorlib     5      Gxfc7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPF     5      =xf.clr-namespace:XamlFlair;assembly=XamlFlair.WPF     5      )localclr-namespace:Dentistry     5	      -   5          N� 
Background
  ����� N� Title$ Авторизация��5       � 	Resources 5         validationFailed �� Orientation1&clr-namespace:System;assembly=mscorlibSystem  5   C    �� 
TargetType  PBoxPass �� 	Resources  Key j� 
AlignmentX j� 
AlignmentY j� Stretch	 !� Visual
 �� Property �� Value �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.MouseOver.Border  TextBox.Focus.Border��5      %�  &	        &	 G     7  7  �� 5   
   .R�5      �� $ 
Horizontal=�6   5      5      �� 5   
   6sys&clr-namespace:System;assembly=mscorlib     6C   " G�6    5      ��!� 5      Bg1 $
 Left=�6+   $ Center=�6=   $
 None=�6Q   	 5      �� 5      
�������$��5,0,0,0q�62   5      !� 5      Bg2 $
 Left=�6+   $ Center=�6=   $
 None=�6Q   	 5      �� 5      $�� ��6    
�������$��5,0,0,0q�6B   5      5      .�5       �� 
 � ��$ 12(�6)   �� 5!      
 � �� �	#FF5858586+   �� 5"      
 � ��$ Center=�69   �� 5#      
 � ��$
 Left=�6;   �� 5$      
 � ��$ 5q�6'   63   �� 5%      
 � ��$ Times New Roman)�6+   6E   �� 5&      
 � ��$	 175��6&   64   �� 5'      
 � ��$ 30��6'   64   -   5        �� 5)      
 � �� 5*      �� 5+      " G�6&   .R�5,      �� $ border��63   $ 10��6!   #��z��6C   
�������$��0 0 0 3q�6�   ._�5-      �� $ PART_ContentHost��6�   $��Visible=�6+   $��0q�6^   ��. 6�   5.       5/      P� 50       � {� .  . �51   "   �� $ border��6<   
 �@J�Opacity$
 0.56Q�6P   52      P� 53       �@J�IsMouseOver . . �54   "   �� $ border��6@   8   
 � ��6T   55      P� 56       �@J�IsKeyboardFocused . . �57   "   �� $ border��6@   8  
 � ��6T   58      5:      5<      5=      5>      .��5?      �  � ColumnDefinitions 5@   
   �� 5A      6!   �� 5B      $	��320 �6   6-   .+�5E   
   �  
 FadeIn  XamlFlair.Animations   Primary# [ 6   ��5F      �� 5G       �� ImageSource$3 -/Dentistry;component/Assets/DentistryWall.jpg��6   5I      �� 5J   
   $��1��6   $��Center=�6%   $��Center=�6B   .+�5L      �� $ Vertical=�6   $��Center=�60   .+�5M      �� -   5        $��	TBoxLogin��5M   4   $��0 0 0 3q�6     	TboxLogin#��[ 6]   ��6F   �� *Login+6�   � 5O      .+�5P      G� -   5        $��PBoxPassword��5P   "   #��[ 5Q   "   5T      �� 5U      -   5        $��
TBlockPass��5U        J� IsHitTestVisible .  $��Пароль��6K   $��	12 12 0 0q�6Y   
�������6�   5V      5X      �� 5Z      -   5        $��CheckRemebmer��5Z      $!��Запомнить меня��6,   $��Center=�6E   6d   �� 5[      -   5        $��BtnNavigate��5[   &    �� 	IsDefault . $��30��69   $	��175��5\      $��
Войти��6!   $��Center=�5]      
�������
������ 5a      �� 5b        LinkText#��[ 6   $��Center=�6:   ,*У вас ещё нет аккаунта? �� 5c   )   -   5        .�5c   K   &$Зарегистрироваться6_   5d      5g      5i      5l      