   M S B A M L   `   `   `  ����@  <Task4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task4Task4  5   	       Task4.AuthorizationWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task4     5   	     � Title$  AuthorizationWindow��5   	   $	��160��6%   $	��600��62    � 
ResizeMode$ NoResize=�6>   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6   $��0��6   $��
Логин��6-   �� 5   
   -   5         ��Name$ LoginTextBox��5      $��0��6(   $��1��65   �� 5   
   $��1��6   $��0��6   $��Пароль��6-   �� 5   
   -   5        $ PasswordTextBox��5      $��1��6+   $��1��68   �� 5   
   -   5        $��2��5      $��2��6   $"��Авторизоваться��63   6L   5      5      