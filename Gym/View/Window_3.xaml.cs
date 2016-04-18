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
    /// Interaction logic for Window_3.xaml
    /// </summary>
    public partial class Window_3 : MetroWindow
    {
        private int _noOfErrorsOnScreen = 0;
        User user = new User();

        public Window_3()
        {
            InitializeComponent();
        }

        public Window_3(User _user)
        {
           //constructor
           InitializeComponent();
           user = _user;
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //user = new User() { PostalCode = user.PostalCode };
            this.DataContext = user;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Window_4 window4 = new Window_4(user);
            window4.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void tbPhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text[0]))
                e.Handled = true;
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                _noOfErrorsOnScreen++;
            else
                _noOfErrorsOnScreen--;
        }
    }
}
