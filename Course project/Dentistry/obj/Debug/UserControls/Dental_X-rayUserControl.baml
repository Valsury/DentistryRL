   M S B A M L   `   `   `  ����D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Dentistry.UserControlsDentistry.UserControls  5      4    .Dentistry.UserControls.Dental_X_rayUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Dentistry.UserControls     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   6,   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� $3��-/Dentistry;component/Assets/Icons/DentIco.png��6   $��Center=�6K   6h   �� 5   
   -   5        $��TBlockNameTooth��5   �   $��0q�6    �� TextAlignment$ Center=�6      
HeaderText#��[  66   $��Center=�6�   ��6Z   �� *	IdTooth+6�   �� 5   
   -   5        $��	XrayImage��5   1   $	��150��6B   $	��150��6N   ��6   �� *PreviewXray+ � ToolTip 5      _� 5       � DataContext 6   �� *PlacementTarget+ �� RelativeSource �� *Self+.��5      �� 
���   �$��1q�65   $��5,7,5,5q�6I   ._�5      �� $
��Fill=�6>   $	��400��6M   $	��400��6Z   ��6$   �� *Source+6Z   5      5      5      �� 5        
CommonText#��[ 6   $
 Left=�6<   $��Heavy"�6Q   ��6d   �� *
DateOfXray+ �� StringFormat$ 
dd.MM.yyyy��6�   5      5      5      