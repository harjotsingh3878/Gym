   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Y UDe.TorstenMandelkow.MetroChart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullwTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart 5   	    Gym   
Gym.Charts   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   fchartTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart     5   	     � Title$  Charts��5   	    � WindowStartupLocation$ CenterScreen=�6    � WindowState$ 	Maximized=�6=    � 
ResizeMode$ NoResize=�6U   .��5      � $��20, 0, 0, 0q�6    � RowDefinitions 5      �� 5	   
   $	��100 �6   �� 5
   
   $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   .+�5   
   �� $��0��6   $��0��6"   $��3��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   .+�5      �� -   5        $��btnBack��5      $��75��6$   $��30��6/   $��10q�6;   $
��Back��6G   6V   �� 5      $5��/Data Reprentation of Preferences of Gym Members��6   $��Center=�6N   $
��Left=�6p   $��15,0,0,0q�6�   $��14(�6�   $
��Bold"�6�   5      � 5      $��1��6   $��0��6     5      �� 5      $	��500 �6     5      �� 5      $	��400 �6#   .+�5      -  'De.TorstenMandelkow.MetroChart.PieChart  $��0��5      $��0��5          MinimalChartStyle#��[  5!      .  (De.TorstenMandelkow.MetroChart.ChartBase   
ChartTitle$  Preference for Gym classes��5"         ChartSubTitle$ Gym Classes��5#      	   SelectedItem	 5$      �� 
 �� Path$
 SelectedItem� �� Mode$ TwoWay=�   Series 5&      0  *De.TorstenMandelkow.MetroChart.ChartSeries     DisplayMember$ Category��5(         ValueMember$ Number��5)      ��5*      �� $
 GymClassChart�5,      5.      � 50   
   $��1��6   $��1��6    51      �� 52      $	��500 �6     55      �� 56      $	��400 �6#   .+�58      9  3De.TorstenMandelkow.MetroChart.ClusteredColumnChart  $��0��6)   $��0��66   $ Fitness Goals��6F   $! Preference of fitness goals��6d    5:        $ Category��6(   $ Number��5=   $   ��5;   $   �� $
 FitnessGoalChart�5=   $   5@      5A      � 5C   
   $��1��6   $��2��6    5D      �� 5E      $	��500 �6     5G      �� 5H      $	��400 �6#   .+�5K      6  0De.TorstenMandelkow.MetroChart.ClusteredBarChart  $��0��6&   $��0��63   $ Sports��6C   $ Preference of sports��6Z    5M        $	��100��6(   $ Category��64   $ Number��5P   $   ��5N   $   �� $
 
SportChart�5P   $   5S      5T      5U      5V      