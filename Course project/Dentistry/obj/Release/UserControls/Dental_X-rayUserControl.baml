   M S B A M L   `   `   `  ���� D  @Dentistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Dentistry.UserControlsDentistry.UserControls  4    .Dentistry.UserControls.Dental_X_rayUserControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:Dentistry.UserControls     .���   � RowDefinitions  �� $
��auto �.+���  �� Orientation$ 
Horizontal=�$��Center=�.+��� $3��-/Dentistry;component/Assets/Icons/DentIco.png��$��Center=��� -   $��TBlockNameTooth��$��0q� �� TextAlignment$ Center=�   
HeaderText#��[  $��Center=����� *	IdTooth+�� -   $��	XrayImage��$	��150��$	��150������ *PreviewXray+ � ToolTip _�  � DataContext �� *PlacementTarget+ �� RelativeSource �� *Self+.���� 
���   �$��1q�$��5,7,5,5q�._��� $
��Fill=�$	��400��$	��400������ *Source+��   
CommonText#��[ $
 Left=�$��Heavy"����� *
DateOfXray+ �� StringFormat$ 
dd.MM.yyyy��