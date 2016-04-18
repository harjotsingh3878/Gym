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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Gym.Model;
using Gym.ViewModel;
using MahApps.Metro.Controls;
using SQLite;

namespace Gym
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        User user = new User();
        UserLogic ul = new UserLogic();
        public ObservableCollection<User> ChartTypes = new ObservableCollection<User>();      

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = user;
        }

        public MainWindow(User _user)
        {
            InitializeComponent();
            user = _user;
            this.DataContext = user;
            Console.WriteLine(user.Sport);
            Console.WriteLine(user.PostalCode);
            Console.WriteLine(user.GymLocation);
            Console.WriteLine(user.FitnessGoal);
            Console.WriteLine(user.FirstName);
            Console.WriteLine(user.PhoneNumber);
            createUser();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await ul.Init();
            dataGridView1.ItemsSource = ul.UserCollection;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window_2 window2 = new Window_2();
            window2.Show();
            this.Close();
        }

        private async void createUser()
        {
            await ul.Init();
            await ul.CreateUser(user);
        }


        private async void btnChart_Click(object sender, RoutedEventArgs e)
        {
            await ul.Init();
            ChartTypes = ul.UserCollection;
            Charts chartWindow = new Charts(ChartTypes);
            chartWindow.Show();
            this.Close();
        }
    }
}
