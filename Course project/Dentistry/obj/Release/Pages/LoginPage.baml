   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  H DXamlFlair.WPF, Version=1.2.8.0, Culture=neutral, PublicKeyToken=nullN7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPFXamlFlair.Controls <.clr-namespace:XamlFlair;assembly=XamlFlair.WPF	XamlFlair D @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dentistry	Dentistry    Dentistry.LoginPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6cor&clr-namespace:System;assembly=mscorlib     Gxfc7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPF     =xf.clr-namespace:XamlFlair;assembly=XamlFlair.WPF     )localclr-namespace:Dentistry     -     N� 
Background
  ����� N� Title$ Авторизация�� � 	Resources    validationFailed �� Orientation1&clr-namespace:System;assembly=mscorlibSystem   �� 
TargetType  PBoxPass �� 	Resources  Key j� 
AlignmentX j� 
AlignmentY j� Stretch	 !� Visual
 �� Property �� Value �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.MouseOver.Border  TextBox.Focus.Border��%i  &	        &	      7  7  �� .R��� $ 
Horizontal=��� 6sys&clr-namespace:System;assembly=mscorlib     " G� ��!� Bg1 $
 Left=�$ Center=�$
 None=�	 �� 
�������$��5,0,0,0q�!� Bg2 $
 Left=�$ Center=�$
 None=�	 �� $�� ��
�������$��5,0,0,0q�.��� 
 � ��$ 12(��� 
 � �� �	#FF585858�� 
 � ��$ Center=��� 
 � ��$
 Left=��� 
 � ��$ 5q��� 
 � ��$ Times New Roman)��� 
 � ��$	 175���� 
 � ��$ 30��-   �� 
 � �� �� " G�.R��� $ border��$ 10��#��z��
�������$��0 0 0 3q�._��� $ PART_ContentHost��$��Visible=�$��0q���.  P�  � {� .  . ��� $ border��
 �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8   
 � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8  
 � ��.���  � ColumnDefinitions �� �� $	��320 �.+��  
 FadeIn  XamlFlair.Animations   Primary# [ ����  �� ImageSource$3 -/Dentistry;component/Assets/DentistryWall.jpg���� $��1��$��Center=�$��Center=�.+��� $ Vertical=�$��Center=�.+��� -   $��	TBoxLogin��$��0 0 0 3q�  	TboxLogin#��[ ���� *Login+� .+�G� -   $��PBoxPassword��#��[ �� -   $��
TBlockPass�� J� IsHitTestVisible .  $��Пароль��$��	12 12 0 0q�
��������� -   $��CheckRemebmer��$!��Запомнить меня��$��Center=��� -   $��BtnNavigate�� �� 	IsDefault . $��30��$	��175��$��
Войти��$��Center=�
�������
������ ��   LinkText#��[ $��Center=�,*У вас ещё нет аккаунта? �� -   .�&$Зарегистрироваться