   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  ?$clr-namespace:Dentistry.UserControlsDentistry.UserControls  &     Dentistry.Pages.PersonalAreaPage   X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:Dentistry.Pages     =usercontrols$clr-namespace:Dentistry.UserControls     -     N� 
Background
  ����� N� Title$! Личный кабинет�� � 	Resources O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  �� 
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
 30��-   �� 	 � ��
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
 30��-   �� 	 � ��
 �� " G�.R��� $ border��$ 10��#��z��$��1q�
�������._��� $ PART_ContentHost��$��Visible=�$��0q���.  P�  �@J�	IsFocused . . ��� $ border��	 � ��
 �	#FFD0D0D0�� $ border��	 � ��$
 2q��� # Z  �� $ Password�.a��� 8
   	 � ����  �� $ Password� Z� .a��� 8
  	 � ��P�  �@J�IsKeyboardFocused . . ��� 	 � ��

 �����.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto ��� $	��500 ��� $
��auto �.+�� $��1��$��0 60 0 0q�.+��� $��10q� �� Orientation$ 
Horizontal=�$��Center=�$
��Left=�.+��� $
��auto��$	��155������  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,2&�.���  � Color$ 	#FFFBE1AF�� � Offset$	 0.1Q�� $ 	#FFCD9C47��$ 1Q� J� Clip ��  �� RadiusX$ 10Q�  �� RadiusY$  10Q�! �� Rect$! 0,0,300,200�._��  �� $
��auto ��� $
��auto �.+��� $��1��$��0 35 0 0q�.+��� $��	10,0,10,0q�  
HeaderText#��[ ���� *LastNameUser+�� $ 
Horizontal=�.+��� $��10,0,3,0q�#��[ ���� *
NameUser+�� $��1,0,10,0q�#��[ ���� *PatronymicUser+�� .+��  �� $
��auto ��� $
��auto � �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��	10,5,10,0q�" �� TextAlignment$
" Left=�
�������  
CommonText#��[ $
��Left=�$!��Дата рождения: ��$��14(�$
��auto���� $��1��$��1,5,10,0q�#��[ $��14(�$
" Left=�$
��auto������ *DateOfBirthUser+# �� StringFormat$# 
dd.MM.yyyy���� $��1��$��	10,5,10,0q�$
" Left=�$��14(�
�������#��[ $
��Left=�$��Пол: ��$
��auto���� $��1,5,10,0q�$��1��$��1��#��[ $
" Left=�$��14(�$
��auto������ *Gender.NameGender+�� $��2��$��	10,5,10,0q�$
" Left=�$��14(�
�������#��[ $
��Left=�$��Моб. Телефон: ��$
��auto���� $��1,5,10,0q�$��2��$��2��#��[ $
" Left=�$��14(�$
��auto������ *Client.PhoneNumberClient+� $��1��$��2��$��35��$	��700��$	��Top=�
�������$��
20 10 10 0q�.+��� $ 
Horizontal=�.+��� $ 
Horizontal=�.+��� $0��*/Dentistry;component/Assets/Icons/info.png��$��25���� $��20��$��16(��� -   $ �Name$$ HLinkPersonalInfo��.�/-Персональная информация�� $ 
Horizontal=�.+��� $4��./Dentistry;component/Assets/Icons/ToothIco.png��$��25���� $��20��$��16(��� -   $$ HLinkTeethCard��.�Зубная карта�� $ 
Horizontal=�.+��� $:��4/Dentistry;component/Assets/Icons/AppointmentIco.png��$��25���� $��20��$��16(��� -   $$ HLinkAllReceptions��.�История приемов�� $ 
Horizontal=�.+��� $8��2/Dentistry;component/Assets/Icons/ReceptionIco.png��$��25���� $��20��$��16(��� -   .�Запись на прием�� $
��Left=�$��2��.+��� $��20q�$	��140��$	��120��
�������._�� .+��� -   $��
ImgPreview������ *PreviewUser+ �� $ 20Q�$  10Q�$! 0,0,300,200�� -	   $��
GridCanvas��$��1��$��1��$��2��
�������$	��710��$��	10 10 0 0q� �� $	��200 ��� $
��auto � �� �� .+��� $��1��$��	50 60 0 0q�$	��170��.+��� #��[ $" Justify=�$	��150��П - пломбирован�� #��[ $" Justify=�$	��150��(&Т - Требуется лечение�� #��[ $" Justify=�$	��150��И - Имплант�� #��[ $" Justify=�$	��150��В - Вылечен�� #��[ $" Justify=�$	��150��У - Удален�� #��[ $" Justify=�$	��150��К - Коронка� -
   $��GridEditInfo��$��1��$��1��$��2��
�������$	��710��$��	10 10 0 0q�$y�	Collapsed=�.+�� $��Center=�$��Center=� �� $
��auto � �� $
��auto �.+��� $��10 0 0 0q�$ 
Horizontal=�$��Center=�$��Center=�.+��� .+��� .+��� $ 
Horizontal=�$��Center=�.+��� -   $��TBoxLastName��  TboxLastname#��[ ���� *LastNameUser+�� -   $��TBoxName��  TboxUsername#��[ ���� *
NameUser+�� -   $��TBoxPatronymic�� 	 TboxPatronymic#��[	 ���� *PatronymicUser+�� $ 
Horizontal=�$��Center=�.+�&   Xceed.Wpf.Toolkit.DateTimePicker  -   $��DtpBirthDate��$	��200��$��25��&   Xceed.Wpf.Toolkit.DateTimeUpDown%   Format$% Custom=�&   FormatString$& 
dd/MM/yyyy��,  &Xceed.Wpf.Toolkit.Primitives.InputBase'   	Watermark$0' *Выберите дату рождения���  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]](   Value( �� *DateOfBirthUser+�� $ 
Horizontal=�$��Center=�.+��� -   $��	TBoxSerie�� 
 
TboxSeries#��[
 ���� *Client.SeriesOfPassportClient+�� -   $��
TBoxNumber��  
TboxNumber#��[ ���� *Client.NumberOfPassportClient+�� $��Center=�$ 
Horizontal=�.+�)  #Xceed.Wpf.Toolkit.WatermarkComboBox  -   $��ComboGender��$��10q�)   	Watermark$) Пол:��* �� 
IsEditable* . 
������ $	��150��+ �� DisplayMemberPath$+ 
NameGender��, � DataContext, �� *Gender.NameGender+(  "Xceed.Wpf.Toolkit.WatermarkTextBox  -   $��TBoxAddress��$��10q�-   	Watermark$- Адрес:��
������ $	��150������ *Client.AddressClient+�� $ 
Horizontal=�$��Center=�.+��� -   $��TBoxPhoneNumber��  TboxPhonenumber#��[ ���� *Client.PhoneNumberClient+�� $ 
Horizontal=�$��Center=�.+��� -   $��	TBoxLogin��  	TboxLogin#��[ ���� *	LoginUser+� -   $��GridPass��.+�G� -   $��PBoxPass��#��[ �� -   $��
TBlockPass��. J� IsHitTestVisible. .  $��Пароль��$��	12 12 0 0q�
�������� .+�G� -   $��PBoxComfPass��#��[  $
��Left=��� -   $��TBlockComfPass��. .  $-��'Подтверждение пароля��$��	12 12 0 0q�
��������� $��1��$��Center=�$��Center=�.+��� $ 
Horizontal=�.+��� -   $��BtnChooseImg��$��5q�
����·�$+��%Выбрать изображение���� -   $��BtnEditInfo��$��5q�
����·�$��Изменить��� $��1��$��2��
�������$	��710��$	��130��$��10 0 0 0q��� -   $��CanvasTeeth��$��1��$��1��$��-240 -60 0 0q�.+�3   -Dentistry.UserControls.ToothStatusUserControl  -   /  Name$/ Tooth11��3   -Dentistry.UserControls.ToothStatusUserControl0   
MouseEnter$0 Tooth_MouseEnter��
1 � Tag$1 11��2   Source$.2 (/Dentistry;component/Assets/Teeth/11.png��3 �� Left$	3 353��
4 �� Top$4 84��$��0q�$��29��$��37��  -   $/ Tooth12��$0 Tooth_MouseEnter��$1 12��$.2 (/Dentistry;component/Assets/Teeth/12.png��$	3 328��$4 87��$��0q�$��36��$��45��  -   $/ Tooth13��$0 Tooth_MouseEnter��$1 13��$.2 (/Dentistry;component/Assets/Teeth/13.png��$	3 313��$	4 102��$��0q�$��30��$��38��  -    $/ Tooth14��$0 Tooth_MouseEnter��$1 14��$.2 (/Dentistry;component/Assets/Teeth/14.png��$	3 300��$	4 110��$��0q�$��29��$��48��  -!   $/ Tooth15��$0 Tooth_MouseEnter��$1 15��$.2 (/Dentistry;component/Assets/Teeth/15.png��$	3 291��$	4 127��$��0q�$��29��$��48��  -"   $/ Tooth16��$0 Tooth_MouseEnter��5   
MouseLeave$5 Tooth_MouseLeave��$1 16��$.2 (/Dentistry;component/Assets/Teeth/16.png��$	3 282��$	4 143��$��0q�$��34��$��56��  -#   $/ Tooth17��$0 Tooth_MouseEnter��$1 17��$.2 (/Dentistry;component/Assets/Teeth/17.png��$	3 276��$	4 166��$��0q�$��33��$��55��6 J� RenderTransformOrigin$6 0.233,0.533&�  -$   $/ Tooth18��$0 Tooth_MouseEnter��$1 18��$.2 (/Dentistry;component/Assets/Teeth/18.png��$	3 272��$	4 190��$��0q�$��33��$��56��$6 -0.033,0.667&�  -%   $/ Tooth21��$0 Tooth_MouseEnter��$1 21��$.2 (/Dentistry;component/Assets/Teeth/21.png��$	3 377��$4 78��$��0q�$��30��$��50��  -&   $/ Tooth22��$0 Tooth_MouseEnter��$1 22��$.2 (/Dentistry;component/Assets/Teeth/22.png��$	3 402��$4 89��$��0q�$��24��$��43��$6 0.5,0.5&�  -'   $/ Tooth23��$0 Tooth_MouseEnter��$1 23��$.2 (/Dentistry;component/Assets/Teeth/23.png��$	3 418��$4 97��$��0q�$��29��$��47��  -(   $/ Tooth24��$0 Tooth_MouseEnter��$1 24��$.2 (/Dentistry;component/Assets/Teeth/24.png��$	3 428��$	4 110��$��0q�$��29��$��48��  -)   $/ Tooth25��$0 Tooth_MouseEnter��$1 25��$.2 (/Dentistry;component/Assets/Teeth/25.png��$	3 437��$	4 126��$��0q�$��29��$��48��$6 	0.5,0.567&�  -*   $/ Tooth26��$0 Tooth_MouseEnter��$1 26��$.2 (/Dentistry;component/Assets/Teeth/26.png��$	3 440��$	4 143��$��0q�$��34��$��56��$6 1.733,0.844&�  -+   $/ Tooth27��$0 Tooth_MouseEnter��$1 27��$.2 (/Dentistry;component/Assets/Teeth/27.png��$	3 448��$	4 166��$��0q�$��33��$��55��  -,   $/ Tooth28��$0 Tooth_MouseEnter��$1 28��$.2 (/Dentistry;component/Assets/Teeth/28.png��$	3 450��$	4 190��$��0q�$��33��$��56��$6 1.167,0.833&�  --   $/ Tooth31��$0 Tooth_MouseEnter��$1 31��$.2 (/Dentistry;component/Assets/Teeth/31.png��$	3 364��$	4 371��$��0q�$��30��$��50��$6 	0.256,2.4&�  -.   $/ Tooth32��$0 Tooth_MouseEnter��$1 32��$.2 (/Dentistry;component/Assets/Teeth/32.png��$	3 380��$	4 366��$��0q�$��30��$��50��  -/   $/ Tooth33��$0 Tooth_MouseEnter��$1 33��$.2 (/Dentistry;component/Assets/Teeth/33.png��$	3 394��$	4 354��$��0q�$��30��$��50��$6 -0.389,2.522&�  -0   $/ Tooth34��$0 Tooth_MouseEnter��$1 34��$.2 (/Dentistry;component/Assets/Teeth/34.png��$	3 412��$	4 342��$��0q�$��30��$��50��$6 -0.311,2.011&�  -1   $/ Tooth35��$0 Tooth_MouseEnter��$1 35��$.2 (/Dentistry;component/Assets/Teeth/35.png��$	3 424��$	4 330��$��0q�$��30��$��50��  -2   $/ Tooth36��$0 Tooth_MouseEnter��$1 36��$.2 (/Dentistry;component/Assets/Teeth/36.png��$	3 436��$	4 307��$��0q�$��30��$��50��  -3   $/ Tooth37��$0 Tooth_MouseEnter��$1 37��$.2 (/Dentistry;component/Assets/Teeth/37.png��$	3 446��$	4 282��$��0q�$��30��$��50��  -4   $/ Tooth38��$0 Tooth_MouseEnter��$1 38��$.2 (/Dentistry;component/Assets/Teeth/38.png��$	3 452��$	4 250��$��0q�$��33��$��55��$6 0.606,0.455&�  -5   $/ Tooth41��$0 Tooth_MouseEnter��$1 41��$.2 (/Dentistry;component/Assets/Teeth/41.png��$	3 347��$	4 371��$��0q�$��30��$��50��  -6   $/ Tooth42��$0 Tooth_MouseEnter��$1 42��$.2 (/Dentistry;component/Assets/Teeth/42.png��$	3 330��$	4 367��$��0q�$��30��$��50��  -7   $/ Tooth43��$0 Tooth_MouseEnter��$1 43��$.2 (/Dentistry;component/Assets/Teeth/43.png��$	3 317��$	4 354��$��0q�$��30��$��50��  -8   $/ Tooth44��$0 Tooth_MouseEnter��$1 44��$.2 (/Dentistry;component/Assets/Teeth/44.png��$	3 304��$	4 342��$��0q�$��30��$��50��  -9   $/ Tooth45��$0 Tooth_MouseEnter��$1 45��$.2 (/Dentistry;component/Assets/Teeth/45.png��$	3 292��$	4 327��$��0q�$��30��$��50��  -:   $/ Tooth46��$0 Tooth_MouseEnter��$1 46��$.2 (/Dentistry;component/Assets/Teeth/46.png��$	3 283��$	4 303��$��0q�$��30��$��50��  -;   $/ Tooth47��$0 Tooth_MouseEnter��$1 47��$.2 (/Dentistry;component/Assets/Teeth/47.png��$	3 274��$	4 278��$��0q�$��30��$��50��  -<   $/ Tooth48��$0 Tooth_MouseEnter��$1 48��$.2 (/Dentistry;component/Assets/Teeth/48.png��$	3 265��$	4 245��$��0q�$��35��$��58��$6 0.406,0.163&�