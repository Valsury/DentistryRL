   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages      Dentistry.Pages.RegPage   X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:Dentistry.Pages       N� Title$%  Окно регистрации�� N� 
Background
 ����� � 	Resources O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  �� 
TargetType   PBoxComfPass �� 	Resources  Key j� 
AlignmentX j� 
AlignmentY j� Stretch !� Visual	 �� Property
 �� Value �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName �� Empty �� Value �� Binding �� Path  Bg2  Bg11&clr-namespace:System;assembly=mscorlibSystem   PBoxPass��%  &	        7  7  &	 �    7  7  �� 6sys&clr-namespace:System;assembly=mscorlib     " G� ��!� Bg1 $
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

 �����.��� $��Center=�$��Center=� � RowDefinitions �� $��* ��� $��90 � � ColumnDefinitions �� $
��auto ��� $��* �.+��� $��10 0 0 0q� �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� .+��� $ 
Horizontal=�$��Center=�.+��� -   $��TBoxLastName��  TboxLastname#��[ �� -   $��TBoxName��  TboxUsername#��[ �� -   $��TBoxPatronymic��  TboxPatronymic#��[ �� $ 
Horizontal=�$��Center=�.+�&   Xceed.Wpf.Toolkit.DateTimePicker  -   $��DtpBirthDate��$	��200��$��25��&   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�   FormatString$ 
dd/mm/yyyy��,  &Xceed.Wpf.Toolkit.Primitives.InputBase   	Watermark$0 *Выберите дату рождения���� $ 
Horizontal=�$��Center=�.+��� -   $��	TBoxSerie��  
TboxSeries#��[ �� -   $��
TBoxNumber�� 	 
TboxNumber#��[	 �� $��Center=�$ 
Horizontal=�.+�)  #Xceed.Wpf.Toolkit.WatermarkComboBox  -	   $��ComboGender��$��10q�   	Watermark$ Пол:�� �� 
IsEditable . 
������ $	��150�� �� DisplayMemberPath$ 
NameGender��(  "Xceed.Wpf.Toolkit.WatermarkTextBox  -
   $��TBoxAddress��$��10q�    	Watermark$  Адрес:��
������ $	��150���� $ 
Horizontal=�$��Center=�.+��� -   $��TBoxPhoneNumber�� 
 TboxPhonenumber#��[
 �� $ 
Horizontal=�$��Center=�.+��� -   $��	TBoxLogin��  	TboxLogin#��[ � -   $��GridPass��.+�G� -   $��PBoxPass��#��[ �� -   $��
TBlockPass��! J� IsHitTestVisible! .  $��Пароль��$��	12 12 0 0q�
�������� .+�G� -   $��PBoxComfPass��#��[  $
��Left=��� -   $��TBlockComfPass��! .  $-��'Подтверждение пароля��$��	12 12 0 0q�
��������� $��1��$��Center=�$��Center=�.+��� .+��� -   $��BtnChooseImg��$��5q�
����·�$+��%Выбрать изображение���� .+��� -   $��ImagePreview��$��5q�$	��200��$	��150������ �� -   $��BtnReg��$(��"Зарегстрироваться��$��1��$��2��