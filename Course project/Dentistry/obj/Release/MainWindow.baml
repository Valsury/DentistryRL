   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dentistry	Dentistry  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem H DXamlFlair.WPF, Version=1.2.8.0, Culture=neutral, PublicKeyToken=nullN7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPFXamlFlair.Controls <.clr-namespace:XamlFlair;assembly=XamlFlair.WPF	XamlFlair     Dentistry.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Dentistry     6cor&clr-namespace:System;assembly=mscorlib     Gxfc7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPF     =xf.clr-namespace:XamlFlair;assembly=XamlFlair.WPF     X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  -     � WindowStyle$
  None=� � 
ResizeMode$ NoResize=�$	��600��$	��600��$
��1000��$
��1000�� � Title �� *Content.Title+ �� ElementName$ 	MainFrame��.���  � RowDefinitions �� $��50 ��� $��1 ��� �� $��1 ��� $��30 �.+���    	LightBlue#��[  $��1��$
��50 0q��� #��[  $��3��$
��50 0q� � -     �Name$ 	MainFrame��$��2��  � NavigationUIVisibility$ Hidden=���  �� Orientation$ 
Horizontal=�$��Right=�.+��� -    ��Name$ BtnBack��$	����$��Right=�$��30��$
��auto��$	��4 0q�$
��15 0q�$y�	Collapsed=�$��Segoe MDL2 Assets)�
���   �$
��Bold"�$��0q�
�������$��25(��� -   $ BtnMinimize��$	����$��Right=�$��30��$
��auto��$	��4 0q�$
��15 0q�$��Segoe MDL2 Assets)�
���   �$
��Bold"�$��0q�
�������$��25(��� -   $ BtnExit��$	����$��Right=�$��30��$
��auto��$	��4 0q�$
��15 0q�$��Segoe MDL2 Assets)�
���   �$
��Bold"�$��0q�
�������$��25(��� -   	 ��Name$	 ImgLogo��4  .System.Windows.Automation.AutomationProperties
   
ItemStatus$
 public��$$��Assets/Icons/DentistryLogo.png��$
��Left=�$
��10 0q��� -    ��Name$ TBlockTitle��$��Center=�$��Center=�  
HeaderText#��[ ���� *Content.Title+$ 	MainFrame��