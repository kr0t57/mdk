   M S B A M L   `   `   `  ����	  Task1    Task1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	      PageBackground#��[  5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      �� 5      $��50 �6   .+�5   
   �� $��0��6V   $��Center=�5      $��Center=�61   ��5      ��  �� ElementName$ 	MainFrame�� �� Path$ Content.(Page.Title)�5   1   �� 5   
   -   5         ��Name$ 
BackButton��5      $
��Back��6%   $��0��6O   $��Right=�6\   $��Center=�5       � 5   
   -   5          �Name$ 	MainFrame��5      $��1��6#     � NavigationUIVisibility$ Hidden=�60   5      5      5      