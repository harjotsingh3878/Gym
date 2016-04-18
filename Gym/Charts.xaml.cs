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
using MahApps.Metro.Controls;
using Gym.ViewModel;
using Gym.Model;
using SQLite;

namespace Gym
{
    /// <summary>
    /// Interaction logic for Charts.xaml
    /// </summary>
    public partial class Charts : MetroWindow
    {
        
        public Charts()
        {
            InitializeComponent();
            this.DataContext = new Chart2();
        }

        public Charts(ObservableCollection<User> ChartTypes)
        {
            InitializeComponent();
            this.DataContext = new Chart2(ChartTypes);            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

       
    }
}
