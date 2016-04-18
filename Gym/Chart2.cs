using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.ViewModel;
using Gym.Model;
using SQLite;

namespace Gym
{
    class Chart2
    {
        UserLogic userLogic = new UserLogic();
        public ObservableCollection<TestClass> FitnessGoalChart { get; private set; }

        public ObservableCollection<TestClass> GymClassChart { get; private set; }

        public ObservableCollection<TestClass> SportChart { get; private set; }
        public ObservableCollection<User> ChartTypes { get; set; }

        public Chart2()
        {
            LoadCharts();
        }

        public Chart2(ObservableCollection<User> _ChartTypes)
        {
            ChartTypes = _ChartTypes;
            LoadCharts();
        }

        private async void GetData()
        {
            await userLogic.Init();
            //ChartTypes = userLogic.UserCollection;
            LoadCharts();
        }
        
        private void LoadCharts()
        {
            
            //ChartTypes = new ObservableCollection<User>();
            FitnessGoalChart = new ObservableCollection<TestClass>();

            GymClassChart = new ObservableCollection<TestClass>();

            SportChart = new ObservableCollection<TestClass>();

            int gainWeight = 0, decreasePain = 0, increaseEnergy = 0, loseInches = 0, loseWeight = 0, increaseStrength = 0, increaseFlexiblity = 0;
            
            foreach (User user in ChartTypes)
            {
                switch (user.FitnessGoal)
                {
                    case "Gain Weight": gainWeight++;
                        break;
                    case "Decrease Pain": decreasePain++;
                        break;
                    case "Increase Energy": increaseEnergy++;
                        break;
                    case "Lose Inches": loseInches++;
                        break;
                    case "Lose Weight": loseWeight++;
                        break;
                    case "Increase Strength": increaseStrength++;
                        break;
                    case "Increase Flexibility": increaseFlexiblity++;
                        break;
                    default:
                        break;
                }



            }

            FitnessGoalChart.Add(new TestClass() { Category = "Gain Weight", Number = gainWeight });
            FitnessGoalChart.Add(new TestClass() { Category = "Decrease Pain", Number = decreasePain });
            FitnessGoalChart.Add(new TestClass() { Category = "increase Energy", Number = increaseEnergy });
            FitnessGoalChart.Add(new TestClass() { Category = "Lose Inches", Number = loseInches });
            FitnessGoalChart.Add(new TestClass() { Category = "Lose Weight", Number = loseWeight });
            FitnessGoalChart.Add(new TestClass() { Category = "increase Strength", Number = increaseStrength });
            FitnessGoalChart.Add(new TestClass() { Category = "increase Flexiblity", Number = increaseFlexiblity });

            int cardio = 0, yoga = 0, strength = 0, toning = 0;

            foreach (User user in ChartTypes)
            {
                switch (user.GymClass)
                {
                    case "Cardio": cardio++;
                        break;
                    case "Yoga": yoga++;
                        break;
                    case "Strength": strength++;
                        break;
                    case "Toning": toning++;
                        break;
                    default:
                        break;
                }



            }


            GymClassChart.Add(new TestClass() { Category = "Cardio", Number = cardio });
            GymClassChart.Add(new TestClass() { Category = "Yoga", Number = yoga });
            GymClassChart.Add(new TestClass() { Category = "Strength", Number = strength });
            GymClassChart.Add(new TestClass() { Category = "Toning", Number = toning });


            int basketball = 0, badminton = 0, swimming = 0, squash = 0, tennis = 0, gymnastics = 0;
            
            foreach (User user in ChartTypes)
            {
                switch (user.Sport)
                {
                    case "Basketball": basketball++;
                        break;
                    case "Badminton": badminton++;
                        break;
                    case "Swimming": swimming++;
                        break;
                    case "Squash": squash++;
                        break;
                    case "Tennis": tennis++;
                        break;
                    case "Gymnastics": gymnastics++;
                        break;
                    default:
                        break;
                }



            }


            SportChart.Add(new TestClass() { Category = "Basketball", Number = basketball });
            SportChart.Add(new TestClass() { Category = "Badminton", Number = badminton });
            SportChart.Add(new TestClass() { Category = "Swimming", Number = swimming });
            SportChart.Add(new TestClass() { Category = "Squash", Number = squash });
            SportChart.Add(new TestClass() { Category = "Tennis", Number = tennis });
            SportChart.Add(new TestClass() { Category = "Gymnastics", Number = gymnastics });

           

        }

        

        private object selectedItem = null;
        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                // selected item has changed
                selectedItem = value;
            }
        }
    }
}
