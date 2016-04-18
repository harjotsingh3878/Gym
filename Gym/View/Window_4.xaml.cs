using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Gym.ViewModel;
using MahApps.Metro.Controls;

namespace Gym
{
    /// <summary>
    /// Interaction logic for Window_4.xaml
    /// </summary>
    public partial class Window_4 : MetroWindow
    {
        User user = new User();
        UserLogic ul = new UserLogic();

        public Window_4()
        {
            InitializeComponent();
        }

        public Window_4(User _user)
        {
            //constructor
            InitializeComponent();
            user = _user;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = user;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(user);
            mainWindow.Show();          
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
