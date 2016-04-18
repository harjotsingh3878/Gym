using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Gym.Model;
using MahApps.Metro.Controls;

namespace Gym
{
    /// <summary>
    /// Interaction logic for Window_2.xaml
    /// </summary>
    public partial class Window_2 : MetroWindow
    {
        User user = new User();

        public Window_2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {          
            this.DataContext = user;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Window_3 window3 = new Window_3(user);
            window3.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a new BitmapImage.
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri("pack://application:,,,/gym-logo.jpg");
            b.EndInit();
            
            var image = sender as Image;

            image.Source = b;
        }
    }
}
