   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value��%l  '        '��      '�� �    �� 5
   
   "  6   .�5      ��  �@ RowBackground
 ��� �6A   �� 5        �@ AlternatingRowBackground
 �����6L   �� 5       � ��$ 16(�6)   66   �� 5       �@ AutoGenerateColumns$ False��64   6D   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�6;   6L   �� 5       � ��$ Center=�69   6J   �� 5       � ��$ 16(�6)   66   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�69   6J   �� 5       � ��$ Center=�6;   6L   �� 5       � ��$ 16(�6)   66   5      5      .��5      � .+�5   
     $��1��6   $��2��6    ��64   ��  �� Path$ Games�   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� $
 Name�  5"      $ Price��6%    64   �� $ Price�	 �� StringFormat$	 {0:C2}��5  /System.Windows.Controls.DataGridHyperlinkColumn  5#      $
 Site��6*    68   �� $
 Site�4  .System.Windows.Controls.DataGridTemplateColumn  5$      $
 More��6)   
   CellTemplate
 5%      �� 5&      .R�5'      �� -   5        $
��More��5'   %   64   5(      5*        5+      $
 Edit��6)   
 5,      �� 5-      .R�5.      �� $
��Edit��6%   5/      51        52      $ Delete��6)   
 53      �� 54      .R�55      �� $��Delete��6%   56      58      4  .System.Windows.Controls.DataGridComboBoxColumn  59      -   5        
column��$ Category��59   9      SelectedItemBinding 6K   �� $ Category�5<      5=      5>      