   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    Gym   Gym.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   >grid-http://schemas.microsoft.com/wpf/2008/toolkit     5   	   -   5          � Title$  Gym Uers Data��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��700��6D   $	��700��6Q    � WindowState$ 	Maximized=�6]    � 
ResizeMode$ NoResize=�6u   .��5      � 
������� � RowDefinitions 5   
   �� 5	      $
��auto �6   �� 5
      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5        $��btnChart��5      $	��300��6%   $��50��61   $��10q�6=   $��15(�6I   $&�� Graphical Representation of Data��6W   6�   �� 5      -   5        $��Add New Users��5      $	��300��6-   $��50��69   $��15(�6E   $��0��6h   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGridView1��5         AutoGenerateColumns .  $��100, 0, 100, 0q�6D   $��20, 0, 20, 0q�6\   $��Center=�6s   $��15(�6�      CanUserResizeColumns . $��1��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6<   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6\     5      $	 
First Name��6C    6%   �� *	FirstName+6Y     5      $	 	Last Name��6B   
 .  6%   �� *
LastName+6i     5      $	 Address��6A   
 .  6%   �� *	Address+6f     5      $
	 City��6>    6%   �� *City+6N     5      $	 Postal Code��6D   
 .  6%   �� *
PostalCode+6m     5      $	 Province��6B   
 .  6%   �� *
Province+6h     5      $	 Email��6?    6%   �� *Email+6P     5      $	 Phone Number��6E   
 .  6%   �� *PhoneNumber+6o     5      $	 FitnessGoal��6E   
 .  6%   �� *FitnessGoal+6n     5      $	 	Gym Class��6B    6%   �� *
GymClass+6W     5      $	 Sport��6?   
 .  6%   �� *Sport+6b   5!      5#      5$      