   M S B A M L   `   `   `  ����D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dentistry	Dentistry  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      H DXamlFlair.WPF, Version=1.2.8.0, Culture=neutral, PublicKeyToken=nullN7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPFXamlFlair.Controls 5      <.clr-namespace:XamlFlair;assembly=XamlFlair.WPF	XamlFlair 5	          Dentistry.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Dentistry     5   	   6cor&clr-namespace:System;assembly=mscorlib     5      Gxfc7clr-namespace:XamlFlair.Controls;assembly=XamlFlair.WPF     5      =xf.clr-namespace:XamlFlair;assembly=XamlFlair.WPF     5	      X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5
      -   5          � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5   	   $	��600��5   @   $	��600��6P   $
��1000��6]   $
��1000��6m    � Title 6	   �� *Content.Title+ �� ElementName$ 	MainFrame��.��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��1 �6   �� 5      �� 5      $��1 �6   �� 5      $��30 �6   .+�5   
   ��    	LightBlue#��[  6   $��1��66   $
��50 0q�6C   �� 5   
   #��[  6   $��3��66   $
��50 0q�6C    � 5   
   -   5          �Name$ 	MainFrame��5      $��2��6     � NavigationUIVisibility$ Hidden=�60   6P   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   .+�5       �� -   5         ��Name$ BtnBack��5    D   $	����6   $��Right=�6(   $��30��6k   $
��auto��6w   $	��4 0q�6�   $
��15 0q�6�   $y�	Collapsed=�6�   $��Segoe MDL2 Assets)�5!      
���   �$
��Bold"�6C   $��0q�6U   
�������$��25(�6|   �� 5"      -   5        $ BtnMinimize��5"   D   $	����6   $��Right=�6(   $��30��6s   $
��auto��6   $	��4 0q�6�   $
��15 0q�6�   $��Segoe MDL2 Assets)�5#      
���   �$
��Bold"�6C   $��0q�6U   
�������$��25(�6|   �� 5$      -   5        $ BtnExit��5$   D   $	����6   $��Right=�6(   $��30��6k   $
��auto��6w   $	��4 0q�6�   $
��15 0q�6�   $��Segoe MDL2 Assets)�5%      
���   �$
��Bold"�6C   $��0q�6U   
�������$��25(�6|   5&      �� 5)   
   -   5        	 ��Name$	 ImgLogo��5)   �   4  .System.Windows.Automation.AutomationProperties
   
ItemStatus$
 public��6   $$��Assets/Icons/DentistryLogo.png��69   $
��Left=�6a   $
��10 0q�6|   6�   �� 5*   
   -   5         ��Name$ TBlockTitle��5*      $��Center=�6_   $��Center=�6z     
HeaderText#��[ 6�   ��6)   �� *Content.Title+$ 	MainFrame��6�   5+      5,      