   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��20 �6   �� 5      �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   o� .@�5      m� -   5        $
��Open��5      6%   5      r� 5   
   -   5         r�Name$ MediaElement��5      $��1��6-   � 5   
   $��2��6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� -   5        $��0��5      $
��Stop��6%   64   �� 5      -   5        $��1��5      $
��Play��6%   64   �� 5       -   5        $��2��5       $��Pause��6%   65   5!      � 5#   
   $��3��6    5$      �� 5%      �� 5&      .+�5)      �� -   5        $��Preview��5)      $��0��6'   67   �� 5*      -   5        $
��Next��5*      $��1��6$   64   5+      5,      5-      