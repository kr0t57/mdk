   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.AuthWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
AuthWindow��5   	   $	��450��6   $	��800��6,    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� <    �� 5
   
   " ��6   .�5      ��  � ��$ 
Bauhaus 93)�6+   �� 5       � ��$ 20(�6)   �� 5       � ��
 ��p��6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 
Bauhaus 93)�6+   �� 5       � ��$ 20(�6)   �� 5       �@��	MaxLength$ 30��6*   5      �� 5   
   " ��6   .�5      ��  � ��$ 
Bauhaus 93)�6+   �� 5       � ��$ 20(�6)   �� 5       � ��$ 30��6'   �� 5       � ��$	 100��6&   �� 5       � ��$	 Top=�62   �� 5       � ��
 �� ��6+   �� 5       � ��$ 0 5 5 5q�6'   5      5      .��5      � .+�5    
   � $	��300��6   $	��120��6    � RowDefinitions 5!      �� 5"      �� 5#      �� 5$       � ColumnDefinitions 5&      �� 5'      �� 5(      .+�5+      �� $��0��6   $��0��6!   $��Login��61   �� 5,      $��1��6   $��0��6!   $��Password��61   �� 5.      -   5         ��Name$ LoginTextBox��5.   3   $��0��6   $��1��6#   63   �� 5/      -   5        $ PasswordTextBox��5/   3   $��1��6   $��1��6#   63   �� 51      $��2��6   $��0��6&   $��2��66    �� Orientation$ 
Horizontal=�6J   .+�52      �� $��Ok��6   �� 53      $��Cancel��6   54      55      56      57      