   M S B A M L   `   `   `  ����@  <Task4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task4Task4  5   	       Task4.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task4     5   	     � Title$  
MainWindow��5   	   $	��360��6   $	��400��6,    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� CornerRadius �� Triggers	 P� Property
 P� Value �� 
TargetName �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration �� From��%m  '��       �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��1q�5   !   $	 4,2q�5   !   
�������$ 3��5   !   #��z��5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5      	 �@J�IsMouseOver$
 False��6=   . �5   "   �� $ border��6)    � ��
 �   �6T   5      5      5       5      :� 5       $ 
MouseEnter��6   [�5!      �� 5"      .��5#      �� .��5$   "   �� $ Background.Color�61    
BlueViolet5%   1   $ 0:0:0D�5&   1   5'      5(      5*      :� 5+      $ 
MouseLeave��6   [�5,      �� 5-      .��5.      �� .��5/   "   �� $ Background.Color�61    
BlueViolet50   1   $ 0:0:0D�51   1   52      53      55      57      58      .��59      � .+�5:   
   � $	��300��6   $	��270��6    � RowDefinitions 5;      �� 5<      �� 5=      $��30 �6    �� 5>      �� 5?      $��30 �6    �� 5@      .+�5C      �� $��0��6   $
��Text��6"   �� 5D      $��2��6   $
��Text��6"   �� 5E      $��4��6   $
��Text��6"   5F      5G      5H      