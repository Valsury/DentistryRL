   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dentistry.PagesDentistry.Pages  ?$clr-namespace:Dentistry.UserControlsDentistry.UserControls  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem H DXamlFlair.WPF, Version=1.2.8.0, Culture=neutral, PublicKeyToken=nullN7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPFXamlFlair.Controls <.clr-namespace:XamlFlair;assembly=XamlFlair.WPF	XamlFlair      Dentistry.Pages.DoctorPage   X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  )localclr-namespace:Dentistry.Pages  7usercontrols$clr-namespace:Dentistry.UserControls  0cor&clr-namespace:System;assembly=mscorlib  Axfc7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPF  7xf.clr-namespace:XamlFlair;assembly=XamlFlair.WPF    N� Title$  Окно Доктора�� N� 
Background
 �����.��� -    �Name$ GridFullInfo�� � RowDefinitions �� $
��auto ��� .+�� $��35��$	��650��$	��Top=�
�������$��
10 10 10 0q�.+��� $��1q�
���   �._���  �� Orientation$ 
Horizontal=�.+��� $ 
Horizontal=�.+��� $0��*/Dentistry;component/Assets/Icons/info.png��$��25���� $��20��$��16(��� -    �Name$ HLinkPersonalInfo��.�GEДополнительная информация о пациенте�� $ 
Horizontal=�.+��� $4��./Dentistry;component/Assets/Icons/ToothIco.png��$��25���� $��20��$��16(��� -   $ HLinkTeethCard��.�Зубная карта�� $ 
Horizontal=�.+��� $:��4/Dentistry;component/Assets/Icons/AppointmentIco.png��$��25���� $��20��$��16(��� -   $ HLinkAllReceptions��.�История приемов� -   $��GridAddTooth��$y�	Collapsed=�$��1��$��	0 80 0 0 q� � ColumnDefinitions �� �� $	��400 �.+��� -   $��CanvasTeeth��$��-20 -120 0 0q�.+�3   -Dentistry.UserControls.ToothStatusUserControl  -     Name$ Tooth11��3   -Dentistry.UserControls.ToothStatusUserControl   
MouseEnter$ Tooth_MouseEnter��	   MouseDoubleClick$	 Tooth_MouseDoubleClick��

 � Tag$
 11��   Source$. (/Dentistry;component/Assets/Teeth/11.png�� �� Left$	 353��
 �� Top$ 84��$��0q�$��29��$��37��  -   $ Tooth12��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 12��$. (/Dentistry;component/Assets/Teeth/12.png��$	 328��$ 87��$��0q�$��36��$��45��  -	   $ Tooth13��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 13��$. (/Dentistry;component/Assets/Teeth/13.png��$	 313��$	 102��$��0q�$��30��$��38��  -
   $ Tooth14��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 14��$. (/Dentistry;component/Assets/Teeth/14.png��$	 300��$	 110��$��0q�$��29��$��48��  -   $ Tooth15��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 15��$. (/Dentistry;component/Assets/Teeth/15.png��$	 291��$	 127��$��0q�$��29��$��48��  -   $ Tooth16��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 16��$. (/Dentistry;component/Assets/Teeth/16.png��$	 282��$	 143��$��0q�$��34��$��56��  -   $ Tooth17��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 17��$. (/Dentistry;component/Assets/Teeth/17.png��$	 276��$	 166��$��0q�$��33��$��55�� J� RenderTransformOrigin$ 0.233,0.533&�  -   $ Tooth18��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 18��$. (/Dentistry;component/Assets/Teeth/18.png��$	 272��$	 190��$��0q�$��33��$��56��$ -0.033,0.667&�  -   $ Tooth21��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 21��$. (/Dentistry;component/Assets/Teeth/21.png��$	 377��$ 78��$��0q�$��30��$��50��  -   $ Tooth22��$	 Tooth_MouseDoubleClick��$ Tooth_MouseEnter��$
 22��$. (/Dentistry;component/Assets/Teeth/22.png��$	 402��$ 89��$��0q�$��24��$��43��$ 0.5,0.5&�  -   $ Tooth23��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 23��$. (/Dentistry;component/Assets/Teeth/23.png��$	 418��$ 97��$��0q�$��29��$��47��  -   $ Tooth24��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 24��$. (/Dentistry;component/Assets/Teeth/24.png��$	 428��$	 110��$��0q�$��29��$��48��  -   $ Tooth25��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 25��$. (/Dentistry;component/Assets/Teeth/25.png��$	 437��$	 126��$��0q�$��29��$��48��$ 	0.5,0.567&�  -   $ Tooth26��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 26��$. (/Dentistry;component/Assets/Teeth/26.png��$	 440��$	 143��$��0q�$��34��$��56��$ 1.733,0.844&�  -   $ Tooth27��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 27��$. (/Dentistry;component/Assets/Teeth/27.png��$	 448��$	 166��$��0q�$��33��$��55��  -   $ Tooth28��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 28��$. (/Dentistry;component/Assets/Teeth/28.png��$	 450��$	 190��$��0q�$��33��$��56��$ 1.167,0.833&�  -   $ Tooth31��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 31��$. (/Dentistry;component/Assets/Teeth/31.png��$	 364��$	 371��$��0q�$��30��$��50��$ 	0.256,2.4&�  -   $ Tooth32��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 32��$. (/Dentistry;component/Assets/Teeth/32.png��$	 380��$	 366��$��0q�$��30��$��50��  -   $ Tooth33��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 33��$. (/Dentistry;component/Assets/Teeth/33.png��$	 394��$	 354��$��0q�$��30��$��50��$ -0.389,2.522&�  -   $ Tooth34��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 34��$. (/Dentistry;component/Assets/Teeth/34.png��$	 412��$	 342��$��0q�$��30��$��50��$ -0.311,2.011&�  -   $ Tooth35��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 35��$. (/Dentistry;component/Assets/Teeth/35.png��$	 424��$	 330��$��0q�$��30��$��50��  -   $ Tooth36��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 36��$. (/Dentistry;component/Assets/Teeth/36.png��$	 436��$	 307��$��0q�$��30��$��50��  -   $ Tooth37��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 37��$. (/Dentistry;component/Assets/Teeth/37.png��$	 446��$	 282��$��0q�$��30��$��50��  -   $ Tooth38��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 38��$. (/Dentistry;component/Assets/Teeth/38.png��$	 452��$	 250��$��0q�$��33��$��55��$ 0.606,0.455&�  -   $ Tooth41��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 41��$. (/Dentistry;component/Assets/Teeth/41.png��$	 347��$	 371��$��0q�$��30��$��50��  -    $ Tooth42��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 42��$. (/Dentistry;component/Assets/Teeth/42.png��$	 330��$	 367��$��0q�$��30��$��50��  -!   $ Tooth43��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 43��$. (/Dentistry;component/Assets/Teeth/43.png��$	 317��$	 354��$��0q�$��30��$��50��  -"   $ Tooth44��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 44��$. (/Dentistry;component/Assets/Teeth/44.png��$	 304��$	 342��$��0q�$��30��$��50��  -#   $ Tooth45��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 45��$. (/Dentistry;component/Assets/Teeth/45.png��$	 292��$	 327��$��0q�$��30��$��50��  -$   $ Tooth46��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 46��$. (/Dentistry;component/Assets/Teeth/46.png��$	 283��$	 303��$��0q�$��30��$��50��  -%   $ Tooth47��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 47��$. (/Dentistry;component/Assets/Teeth/47.png��$	 274��$	 278��$��0q�$��30��$��50��  -&   $ Tooth48��$ Tooth_MouseEnter��$	 Tooth_MouseDoubleClick��$
 48��$. (/Dentistry;component/Assets/Teeth/48.png��$	 265��$	 245��$��0q�$��35��$��58��$ 0.406,0.163&�� -'    �Name$ popUpStatus�� � 	StaysOpen .  $��Mouse=�$	��160�� � AllowsTransparency . .���� 
�������.+��� $ 
Horizontal=�.+���    
CommonText#��[  $��Пломбирован��	� -(   $��
RadioHelth��$
 Пломбирован�� 	� 	GroupName$ ToothStatus���� $ 
Horizontal=�.+��� #��[  $'��!Требуется лечение��	� -)   $��RadioNeedTreatment��$'
 !Требуется лечение��$ ToothStatus�� d� 	IsChecked �� *IdToothStatus+�� $ 
Horizontal=�.+��� #��[  $��Вылечен��	� -*   $��
RadioCured��$
 Вылечен��$ ToothStatus���� $ 
Horizontal=�.+��� #��[  $��Имплант��	� -+   $��RadioImplant��$
 Имплант��$ ToothStatus���� $ 
Horizontal=�.+��� #��[  $��Удален��	� -,   $��RadioRemoved��$
 Удален��$ ToothStatus��� $��1�� �� .+��� $��1��.+��� $ 
Horizontal=�.+��� $��Зуб:��#��[  $	��150���� --   $��TboxIdTooth��$	��150��$��10q� �� 
IsReadOnly . .���� -.   $��BtnAdd��$��Segoe MDL2 Assets)�$	����$
��Bold"�$��16(�
���   �$��0q�
�������$��20��$��20���� $ 
Horizontal=�.+��� $"��Состояние зуба:��#��[  $	��150���� -/   $��comboToothStatus�� �� 
IsEditable . 
�������$��14(�$��1q� �� SelectedIndex$ 0�� �� DisplayMemberPath$ NameToothStatus���� $ 
Horizontal=�.+��� $��Услуга:��#��[  $	��150���� -0   $��comboService�� . 
�������$��14(�$��1q�$ NameService��$ 0���� $ Vertical=�$��5q�.+��� $��Диагноз: ��#��[  $	��150�� �� TextAlignment$ Center=�$��Center=��� -1   $��TBoxDiagnosis��$	��330��$��50��$��4q� �� TextWrapping$
 Wrap=�.���� -2   $��BtnAddTooth��$��Добавить��$��10q�� -3   $��GridReceptions��$��1��$y�	Collapsed=� �� $
��auto ��� .+��� $ 
Horizontal=�$��Center=�.+��� -4   $��
TBoxSearch��  
TboxSearch#��[ &   System.Windows.Controls.DataGrid  -5     Name$ DGridReceptions��$��1��   AutoGenerateColumns .     CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    Header$ Дата приема��    CanUserReorder  .  1  +System.Windows.Controls.DataGridBoundColumn!   Binding! �� *DateReception+" �� StringFormat$" dd.MM.yyyy HH:mm��  $ * $ Врач��! �� *Doctor.FullNameDoctor+  $ * $ Жалоба��! �� *" Appointment.ComplaintAppointment+  $ * $ Диагноз��! �� *DiagnosisReception+  $ * $ Услуга��! �� *Service.NameService+  $ * $ Цена��! �� *Service.PriceService+$" {0} руб.��� -6   $��GridProfile��$��1�� �� $	��210 ��� $	��500 ��� $
��auto �.+��� ���	#FFDCFCFF$��1q�
���   �� -7   $ GridNavButtons��.+��� $��Center=�$��	0 -20 0 0q�.+��� $ 
Horizontal=��� -8   $��ButtonAdditionalInfo��$��0q�$��50��$��10q�$��50��$��50(�$	����
���   �$��Segoe MDL2 Assets)�
������ �� -9   $��ButtonXRays��$��0q�$��10q�$��50��$��50��$��50(�$	����
���   �$��Segoe MDL2 Assets)�
������ � $��2��$��Center=�$��40 0 0 0q�.+��� $��2��$��0 25 0 0q�$��Center=�.+��� -:   $��BorderPhoto��$	��140��$	��150��# �� CornerRadius$# 80��$��0 15 0 0q����� $ �� ImageSource$ �� �� -;   $��TBlockFullName��$	��200��$ Center=�$
��Bold"�#��[  $��0 10 0 0q�$��18(��� $ 
Horizontal=�$�� 5 5 0 0q�$��Center=�.+��� $4��./Dentistry;component/Assets/Icons/PhoneIco.png��% J� Opacity$	% 0.6Q��� -<   $��TBlockPhoneNumber��#��[  $
 Left=�$��Heavy"�$	% 0.6Q��� $ 
Horizontal=�$�� 5 5 0 0q�$��Center=�.+��� $6��0/Dentistry;component/Assets/Icons/AddressIco.png��$	% 0.5Q��� -=   $��TBlockAddress��#��[  $	��130��$
 Left=�$��Heavy"�$	% 0.5Q��� $ 
Horizontal=�$�� 5 5 0 0q�$��Center=�.+��� $<��6/Dentistry;component/Assets/Icons/LastReceptionIco.png��$	% 0.4Q��� ->   $��TBlockLastReception��#��[  $	��130��$
 Left=�$��Heavy"�$	% 0.4Q�� -?   $ GridAdditionalInfo��$y�Visible=�$��1�����	#FFFAECDB.+��� $��Center=�$��Center=�.+��� .+��� $ 
Horizontal=�$��0 0 0 5q�.+��� $��40��$��40��$>��8/Dentistry;component/Assets/Icons/ChronicDiseasesIco.png��(  "Xceed.Wpf.Toolkit.WatermarkTextBox  -@   &  Name$& TBoxchronicDiseases��'   	Watermark$3' -Хронические заболеваня: ��$	��300��$��30��
������ 
���   �$��0 0 0 3q�
���ؿ��$
��Left=�$��16(��� .+��� $ 
Horizontal=�$��0 10 0 5q�.+��� $��40��$	% 0.6Q�$��40��$4��./Dentistry;component/Assets/Icons/Pill_Ico.png��  -A   $& TBoxPastDiseases��$5' /Перенесенные заболеваня: ��$	��300��$��30��
������ 
���   �$��0 0 0 3q�
���ؿ��$
��Left=�$��16(��� $ 
Horizontal=�$��0 10 0 5q�.+��� $��40��$	% 0.6Q�$��40��$;��5/Dentistry;component/Assets/Icons/CurrectDiseases.png��  -B   $& TBoxCurrentDiseases��$D' >Развитие настоящего заболевания: ��$	��300��$��30��
������ 
���   �$��0 0 0 3q�
���ؿ��$
��Left=�$��16(��� $ 
Horizontal=�$��0 10 0 5q�.+��� $��40��$	% 0.6Q�$��40��$5��//Dentistry;component/Assets/Icons/HabitIcon.png��  -C   $& TBoxBadHabit��$'' !Вредные привычки: ��$	��300��$��30��
������ 
���   �$��0 0 0 3q�
���ؿ��$
��Left=�$��16(��� -D   $��BtnEditAdditionalInfo��
������ $��5q�$��Segoe MDL2 Assets)�$	����$��0q�$��24(�$��40��
���   �� -E   $��GridDental_Xrays��$y�	Collapsed=����	#FFFAECDB$��1�� �� $
��auto ��� .+��� $
��auto��$��Center=�$ 
Horizontal=�.+��� -F   $��BtnAddDental��$	��110��$#��Добавить снимок���� $
 Left=�$��03q�#��[  $��Выберите зуб: ��$	��100��)	  #Xceed.Wpf.Toolkit.WatermarkComboBox	  -G   $��
ComboTeeth�� . $ IdTooth��$	��100��$��20��$��3q�
������ �� -H   $��PreviewXray��$y�	Collapsed=��� $��2��.���� -I   $��
LViewXrays������ .R�� ���� .R�4
   .Dentistry.UserControls.Dental_X_rayUserControl
  $��15 10q�$	��400��