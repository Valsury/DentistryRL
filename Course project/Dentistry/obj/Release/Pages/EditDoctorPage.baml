   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  ?$clr-namespace:Dentistry.UserControlsDentistry.UserControls  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem H DXamlFlair.WPF, Version=1.2.8.0, Culture=neutral, PublicKeyToken=nullN7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPFXamlFlair.Controls $    Dentistry.Pages.EditDoctorPage   X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  )localclr-namespace:Dentistry.Pages  7usercontrols$clr-namespace:Dentistry.UserControls  0cor&clr-namespace:System;assembly=mscorlib  Axfc7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPF    N� Title$6  0Добавление данных о в раче�� N� 
Background
 ����� � 	Resources 1&clr-namespace:System;assembly=mscorlibSystem  �� 
TargetType   PBoxComfPass �� 	Resources  Key j� 
AlignmentX j� 
AlignmentY j� Stretch !� Visual	 �� Property
 �� Value �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName �� Empty �� Value �� Binding �� Path  Bg2  Bg11&clr-namespace:System;assembly=mscorlibSystem   PBoxPass1&clr-namespace:System;assembly=mscorlibSystem   TboxWorkExp  TextBox.Static.Border-  'System.Windows.Input.KeyboardNavigation J� SnapsToDevicePixels  TextBox.MouseOver.Border  TextBox.Focus.Border �� Triggers 	 CueBannerBrush ]� 
Conditions �� Property �� Value1&clr-namespace:System;assembly=mscorlibSystem  
 TboxEducation��%  &	        7  7  &	 z    7  7  &	 �    7  7  7  7 	 7 	 &	
 �    7  7  7  7 	 7 	 �� 0sys&clr-namespace:System;assembly=mscorlib  " G� ��!� Bg1 $
 Left=�$ Center=�$
 None=� �� 
�������$��5,0,0,0q�!� Bg2 $
 Left=�$ Center=�$
 None=� �� $�� ��
�������$��5,0,0,0q�.��� 	 � ��$
 12(��� 	 � ��
 �	#FF585858�� 	 � ��$
 Center=��� 	 � ��$
 Center=��� 	 � ��$
 5q��� 	 � ��$
 Times New Roman)��� 	 � ��$	
 175���� 	 � ��$
 30��-   �� 	 � ��
 �� " G�.R��� $ border��$ 10��#��z��$��1q�
�������._��� $ PART_ContentHost��$��Visible=�$��0q���.  P�  �@J�	IsFocused . . ��� $ border��	 � ��
 �	#FFD0D0D0�� $ border��	 � ��$
 2q��� # Z  �� $ Password�.a��� 8
   	 � ����  �� $ Password� Z� .a��� 8
  	 � ��P�  �@J�IsKeyboardFocused . . ��� 	 � ��

 ������� .sys&clr-namespace:System;assembly=mscorlib  " G� ��!� Bg1 $
 Left=�$ Center=�$
 None=� �� 
�������$��5,0,0,0q�!� Bg2 $
 Left=�$ Center=�$
 None=� �� $�� ��
�������$��5,0,0,0q�.��� 	 � ��$
 12(��� 	 � ��
 �	#FF585858�� 	 � ��$
 Center=��� 	 � ��$

 Left=��� 	 � ��$
 5q��� 	 � ��$
 Times New Roman)��� 	 � ��$	
 175���� 	 � ��$
 30��-   �� 	 � ��
 �� " G�.R��� $ border��$ 10��#��z��$��1q�
�������._��� $ PART_ContentHost��$��Visible=�$��0q���.  P�  �@J�	IsFocused . . ��� $ border��	 � ��
 �	#FFD0D0D0�� $ border��	 � ��$
 2q��� # Z  �� $ Password�.a��� 8
   	 � ����  �� $ Password� Z� .a��� 8
  	 � ��P�  �@J�IsKeyboardFocused . . ��� 	 � ��

 ������� .sys&clr-namespace:System;assembly=mscorlib  " �� ��!� CueBannerBrush $
 Left=�$ Center=�$
 None=� �� $��Cтаж работы��
�������.��� 	 � ��$
 5q��� 	 � ��$
 Times New Roman)��� 	 � ��$	
 175���� 	 � ��$
 30���� 	 � ��$
 Center=��� 	 � ��#
 � ���� 	 � ��8
   �� 	 � ��#
 � ���� 	 � ��$
 1q��� 	 �@ TabNavigation$

 None=��� 	 � ��$

 Left=��� 	 �@�FocusVisualStyle
 Z� �� 	 �@J�	AllowDrop
 . �� 	 �@��PanningMode$
 VerticalFirst=��� 	 �@��IsFlicksEnabled
 .  �� 	 � ��
 �� " ��.R��� $ border��$ 12��#��z��#��z��#��z�� . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=� P�  � {� .  . ��� $ border��	 �@J�Opacity$

 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8
  	 � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8
  	 � �� P�  � ��# Z . ��� 	 � ��8
  P�  � �� Z� . ��� 	 � ��8
  P�  �@J�IsKeyboardFocused . . ��� 	 � ��

 �����]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./��� 	 �@��SelectionBrush#
 � /��� .sys&clr-namespace:System;assembly=mscorlib  " �� ��!� CueBannerBrush $
 Left=�$ Center=�$
 None=� �� $��Образование��
�������.��� 	 � ��$
 5q��� 	 � ��$
 Times New Roman)��� 	 � ��$	
 175���� 	 � ��$
 30���� 	 � ��$
 Center=��� 	 � ��#
 � ���� 	 � ��8
   �� 	 � ��#
 � ���� 	 � ��$
 1q��� 	 �@ TabNavigation$

 None=��� 	 � ��$

 Left=��� 	 �@�FocusVisualStyle
 Z� �� 	 �@J�	AllowDrop
 . �� 	 �@��PanningMode$
 VerticalFirst=��� 	 �@��IsFlicksEnabled
 .  �� 	 � ��
 �� " ��.R��� $ border��$ 12��#��z��#��z��#��z�� . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=� P�  � {� .  . ��� $ border��	 �@J�Opacity$

 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8
  	 � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8
  	 � �� P�  � ��# Z . ��� 	 � ��8
  P�  � �� Z� . ��� 	 � ��8
  P�  �@J�IsKeyboardFocused . . ��� 	 � ��

 �����]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./��� 	 �@��SelectionBrush#
 � /�.��� $��Center=�$��Center=� � RowDefinitions �� $��* ��� $��90 � � ColumnDefinitions �� $
��auto ��� $��* �.+��� $��10 0 0 0q� �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� .+��� $ 
Horizontal=�$��Center=�.+��� -   $��TBoxLastName��  TboxLastname#��[ �� -   $��TBoxName��  TboxUsername#��[ �� -   $��TBoxPatronymic��  TboxPatronymic#��[ �� $ 
Horizontal=�$��Center=�.+�&   Xceed.Wpf.Toolkit.DateTimePicker  -   $��DtpBirthDate��$	��200��$��25��&   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�    FormatString$  
dd/mm/yyyy��,  &Xceed.Wpf.Toolkit.Primitives.InputBase!   	Watermark$0! *Выберите дату рождения���� $ 
Horizontal=�$��Center=�.+�)  #Xceed.Wpf.Toolkit.WatermarkComboBox  -   $��ComboDepartments��" �� 
IsEditable" . 
�������# �� DisplayMemberPath$# NameDepartment��$��5q�$	��150��$��25��$   	Watermark$$ Отделение: ��$��1q��� -   $��TBoxWorkExp��#��[ �� $ Vertical=�$��Center=�.+��� -	   $��TBoxPhoneNumber��  TboxPhonenumber#��[ �� $��Center=�$ 
Horizontal=�.+�  -
   $��ComboGender��$$ Пол:��" . 
������ $	��150��$# 
NameGender���� -   $��TboxEducation��$	��260��$��50��% �� TextWrapping$
% Wrap=�#��[
 �� $ 
Horizontal=�$��Center=�.+��� -   $��	TBoxLogin��  	TboxLogin#��[ � -   $��GridPass��.+�G� -   $��PBoxPass��#��[ �� -   $��
TBlockPass��& J� IsHitTestVisible& .  $��Пароль��$��	12 12 0 0q�
�������� .+�G� -   $��PBoxComfPass��#��[  $
��Left=��� -   $��TBlockComfPass��& .  $-��'Подтверждение пароля��$��	12 12 0 0q�
��������� $��1��$��Center=�$��Center=�.+��� .+��� -   $��BtnChooseImg��$��5q�
����·�$+��%Выбрать изображение���� .+��� -   $��ImagePreview��$��5q�$	��200��$	��150������ �� -   $��BtnReg��$��Доавить��$��1��$��2��