   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    Gym   Gym.Window_4   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   -   5          � Title$  Gym Registration Form��5   	      AccentColorBrush#���   6'    � WindowStartupLocation$ CenterScreen=�6X   $	��700��6}   $	��700��6�    � 
ResizeMode$ NoResize=�6�   .��5      � 
������� � 	Resources 5   
    �� 
TargetType �� Property �� Value  ErrorToolTipTemplate_1��%�   '��       �� 5
      " ��6   .�5      ��  � ��$
 Left=�68   �� 5       � ��$	 Top=�66   �� 5       � ��$	 150��6*   �� 5       � ��$ 30��6+   �� 5       �@=�ErrorTemplate# �  6=   5      5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Step 3: Enter Preferences��6A   $��Center=�6e   $
��Left=�6�   $��15,0,0,0q�6�   $��14(�6�   $
��Bold"�6�   �� 5   
   $��1��6   $��0��6   $$��My number one fitness goal is:��6-   $��Center=�6V   $��Right=�6x   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $��cbGoal��5   0   $��1��6   $��1��6    $��25��6>   $��Center=�6J   ��6e   �� *FitnessGoals+	 �� SelectedItem	 6�   �� *FitnessGoal+
 �� Mode$
 TwoWay=� �� ValidatesOnDataErrors . 5"      �� 5#   
   $��2��6   $��0��6   $#��My preference of Gym Classes:��6-   $��Center=�6U   $��Right=�6w   $��14(�6�   $
��Bold"�6�   �� 5$   
   -   5        $��cbClass��5$   0   $��2��6   $��1��6    $��25��6?   $��Center=�6K   ��6f   �� *
GymClasses+	 6�   �� *
GymClass+$
 TwoWay=� . 5'      �� 5(   
   $��3��6   $��0��6   $��My preference of sport:��6-   $��Center=�6O   $��Right=�6q   $��14(�6�   $
��Bold"�6�   �� 5)   
   -   5        $��cbSport��5)   0   $��3��6   $��1��6    $��25��6?   $��Center=�6K   ��6f   �� *Sports+	 6�   �� *Sport+$
 TwoWay=� . 5,      �� 5-   
   $��4��6   $��0��6"   $��2��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   .+�5.      �� -   5        $��btnOK��5.      $��75��6"   $��30��6-   $��10q�69   $��Register��6E   {�6X   �� *IsSelectedBtn4+6}   �� 5/      -   5        $��	btnCancel��5/      $��75��6&   $��30��61   $��10q�6=   $��Cancel��6I   6Z   50      51      52      