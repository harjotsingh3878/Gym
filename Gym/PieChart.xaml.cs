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
using MahApps.Metro.Controls;

namespace Gym
{
    /// <summary>
    /// Interaction logic for PieChart.xaml
    /// </summary>
    public partial class PieChart : MetroWindow
    {

        public PieChart()
        {
            InitializeComponent();
            this.DataContext = new Chart();
        }


    }

}