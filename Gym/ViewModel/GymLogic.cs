using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.ViewModel
{
    class GymLogic : INotifyPropertyChanged
    {
        private int id;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string province;
        private string postalCode;
        private string email;
        private string phoneNumber;
        private string dateOfBirth;
        private string gender;
        private string fitnessGoal;
        private string gymClass;
        private string sport;

        private string gymLocation;
        private bool isSelected;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string City
        {
            get { return city; }
            set { city = value; }
        }


        public string Province
        {
            get { return province; }
            set { province = value; }
        }


        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }


        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string FitnessGoal
        {
            get { return fitnessGoal; }
            set { fitnessGoal = value; }
        }

        private List<string> fitnessGoals = new List<string>() { "Gain Weight", "Decrease Pain", "Increase Energy", "Lose inches", "Lose Weight", "Increase Strength", "Increase Flexibility" };

        public List<string> FitnessGoals { get { return fitnessGoals; } private set { } }

        public string GymClass
        {
            get { return gymClass; }
            set { gymClass = value; }
        }

        private List<string> gymClasses = new List<string>() { "Cardio", "Yoga", "Strength", "Toning" };

        public List<string> GymClasses { get { return gymClasses; } private set { } }

        public string Sport
        {
            get { return sport; }
            set { sport = value; }
        }

        private List<string> sports = new List<string>() { "Basketball", "Badminton", "Swimming", "Squash", "Tennis", "Gymnastics" };

        public List<string> Sports { get { return sports; } private set { } }

        public string GymLocation
        {
            get { return gymLocation; }
            set
            {
                gymLocation = value;
                IsSelected = (!string.IsNullOrEmpty(gymLocation));
            }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        private List<string> gymLocations = new List<string>() { "Cambridge Hespeler Road Club", "Kitchener Fairway Club", "Kitchener Williamsburg Club", "Kitchener Market Square Club", "Kitchener Highland Hills Club", "Guelph Pergola Commons Club", "Guelph Edinburgh Plaza Club", "Waterloo Weber Street Club" };

        public List<string> GymLocations { get { return gymLocations; } private set { } }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
