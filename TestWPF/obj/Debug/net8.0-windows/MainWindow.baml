   M S B A M L   `   `   `  ����B  >TestWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TestWPFTestWPF  5   	       TestWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TestWPF     5   	     � Title$  
MainWindow��5   	   $	��198��6   $	��227��6)    � 	Resources 5	         MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� ElementName �� Path	 J� Effect-  'System.Windows.Media.Effects.BlurEffect
   Radius   
KernelType J� Opacity��%7  &	        �� 5
   
   " ��6&   .�5      ��  � ��$ Verdana)�63   �� 5       � ��
 �����63   �� 5       � ��
 �����63   �� 5       � ��$ 10q�6/   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��button��6\   $ 5��6!   #��z��62   ._�5      � .+�5   "   �� $��1,0,1,1q�6)   
������� 6W   �� $ button��$ CornerRadius�	 5   &     5   *   $
 2Q�65   $ Gaussian=�6@   5   #   �� 5   "   $��0,1,1,0q�6)   
�������$��2q�6W   $	 0.7Q�6b    6p   �� $ button��$ CornerRadius�	 5   &     5   *   $
 2Q�65   $ Gaussian=�6@   5   #   �� 5   "   #��z��63   #��z��6c   #��z��6�   $��Center=�6�   $��Center=�6�   #��z��6  6)  5      5       5!      5$      5&      5'      .��5(      �  � RowDefinitions 5)   
   �� 5*      6   �� 5+      6    � ColumnDefinitions 5-   
   �� 5.      6!   �� 5/      6!   .+�51   
   �� $��Button 1��6   $��0��52      $��0��53      #��[  54      �� 55   
   $��Button 2��6   $��0��56      $��1��57      #��[  58      59      5:      