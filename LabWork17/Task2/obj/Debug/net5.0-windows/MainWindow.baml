   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%5  '��       '	� �     �� 5
   
   " ��6   .�5      ��  � ��$ Center=�6;   6L   �� 5       � ��$ Center=�69   6J   �� 5       � ��$ 16(�6)   66   5      �� 5   
   " 	�6   .�5      ��  � ��$ Center=�69   6J   �� 5       � ��$ 16(�6)   66   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $	��200 �6   6-    � RowDefinitions 5   
   �� 5      6   �� 5      $��40 �6   6*   .+�5    
   � -   5         �Name$ childrenGrid��5       $��1��6    5!      �� 5"      $��40 �6    6.   �� 5#      $��40 �6    6.   �� 5$      $��40 �6    6.   �� 5%      $��40 �6    6.   �� 5&      $��40 �6    6.   �� 5'      6"   .+�5*      �� $��0��6   $��Size (bytes):��6!   $��Bottom=�69   $
��Left=�6[   $��16(�6}   $
��Bold"�6�   6�   �� 5+      -   5         ��Name$ textBoxSize��5+   #   $��1��6   6k   	� 5,      -   5        0��	 	� 	GroupName$
	 Size��5,   $   $��2��65   $$��Меньше или равно��6B   6}   	� 5-      -   5        1��$
	 Size��5-   $   $��3��65   $$��Больше или равно��6B   6}   �� 5.      -   5        $��4��5.      $#��Очистить фильтр��6"   $��16(�6<   6g   �� 5/      -   5        
 ��Name$
 textBlockInfo��5/      $��5��6/   $
��Wrap=�6<   6R   50      &   System.Windows.Controls.DataGrid  52   
   -   5          Name$ dataGrid��52      6'   �� 53   
   -   5        $ textBoxPath��53      $��0��6'   $��1��67   $��C:\Temp\ISPP01\mdk0101��6D   6d   �� 54   
   -	   5        $��1��54      $��1��6   $��Запрос��6.   $��16(�6?   6e   55      56      