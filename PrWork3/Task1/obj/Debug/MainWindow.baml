   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� M     '�� �     'm�     �� 5
   
   " ��6   .�5      ��  � ��$ 16(�6)   66   5      �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   66   5      �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   66   �� 5       �@��TextWrapping$
 Wrap=�6-   6<   5      �� 5   
   " m�6   .�5      ��  � ��$ 16(�6)   66   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��3* �6   6,    � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5       $��40 �6   6*   �� 5!      $��40 �6   6*   �� 5"      6   �� 5#      $��40 �6   6*   .+�5&   
   o� $��2��6   .@�5'      m� $��Создать��6   .@�5(      m� -   5        $!��Новый документ��5(      6S   m� 5)      -   5        $*��$Документ по шаблону��5)      6U   5*      5+      �� 5-   
   $��1��6   $��Номер:��6   60   �� 5.   
   $��2��6   $��Название:��6   63   �� 5/   
   $��3��6   $ ��Текст задания:��6   68   �� 50   
   $��4��6   $.��(Количество вариантов:��6   6?   �� 52   
   -   5         ��Name$ numberTextBox��52      $��1��6)   $��1��66   6H   �� 53   
   -   5        $ titleTextBox��53      $��2��6(   $��1��65   6G   �� 54   
   -   5        $ textTextBox��54      $��3��6'   $��1��64    �� AcceptsReturn . 6[   �� 55   
   -   5        $ countOfOptionsTextBox��55      $��4��61   $��1��6>   6P   56      57      