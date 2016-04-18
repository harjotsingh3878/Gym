using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using SQLite;

namespace Gym.Model
{
    [Table("User1")]
    public class User : INotifyPropertyChanged, IDataErrorInfo
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

        private bool isFisrtName = false;
        private bool isLastName = false;
        private bool isAddress = false;
        private bool isCity = false;
        private bool isProvince = false;
        private bool isPostalCode = false;
        private bool isEmail = false;
        private bool isPhoneNumber = false;
        private bool isDateOfBirth = false;
        private bool isGender = false;
        private bool isFitnessGoal = false;
        private bool isGymClass = false;
        private bool isSport = false;

        private bool isSelectedBtn2 = false;
        private bool isSelectedBtn3 = false;
        private bool isSelectedBtn4 = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public User()
        {
                   
        }

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                firstName = value;
                /*if (String.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Customer name is mandatory.");
                }
                else
                {

                }*/
            }
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
            set 
            { 
                gender = value;
                Console.WriteLine("Gender: " + value);
                RaisePropertyChanged("Gender");
            }
        }

        public string FitnessGoal
        {
            get { return fitnessGoal; }
            set { fitnessGoal = value; }
        }

        private List<string> fitnessGoals = new List<string>() { "Gain Weight", "Decrease Pain", "Increase Energy", "Lose inches", "Lose Weight", "Increase Strength", "Increase Flexibility" };

        [Ignore]
        public List<string> FitnessGoals { get { return fitnessGoals; } private set { } }

        public string GymClass
        {
            get { return gymClass; }
            set { gymClass = value; }
        }

        private List<string> gymClasses = new List<string>() { "Cardio", "Yoga", "Strength", "Toning" };
        [Ignore]
        public List<string> GymClasses { get { return gymClasses; } private set { } }

        public string Sport
        {
            get { return sport; }
            set { sport = value; }
        }

        
        private List<string> sports = new List<string>() { "Basketball", "Badminton", "Swimming", "Squash", "Tennis", "Gymnastics" };

        [Ignore]
        public List<string> Sports { get { return sports; } private set { } }

        [Ignore]
        public string GymLocation
        {
            get { return gymLocation; }
            set
            {
                gymLocation = value;
                IsSelectedBtn2 = (!string.IsNullOrEmpty(gymLocation));
            }
        }

        [Ignore]
        public bool IsSelectedBtn2
        {
            get { return isSelectedBtn2; }
            set
            {
                isSelectedBtn2 = value;
                OnPropertyChanged("IsSelectedBtn2");
            }
        }

        [Ignore]
        public bool IsSelectedBtn3
        {
            get { return isSelectedBtn3; }
            set
            {
                isSelectedBtn3 = value;
                OnPropertyChanged("IsSelectedBtn3");
            }
        }

        [Ignore]
        public bool IsSelectedBtn4
        {
            get { return isSelectedBtn4; }
            set
            {
                isSelectedBtn4 = value;
                OnPropertyChanged("IsSelectedBtn4");
            }
        }

        private List<string> gymLocations = new List<string>() { "Cambridge Hespeler Road Club", "Kitchener Fairway Club", "Kitchener Williamsburg Club", "Kitchener Market Square Club", "Kitchener Highland Hills Club", "Guelph Pergola Commons Club", "Guelph Edinburgh Plaza Club", "Waterloo Weber Street Club" };

        [Ignore]
        public List<string> GymLocations { get { return gymLocations; } private set { } }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private List<string> personGender = new List<string>() { "Male", "Female" };

        [Ignore]
        public List<string> PersonGenders
        {
            get { return personGender; }
            set
            {
                //departmentList = value;
                //RaisePropertyChanged("DepartmentList");
            }
        }

        private bool ValidEmail(string email)
        {
            Regex emailRegex = new Regex(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$");
            if (emailRegex.IsMatch(Email))
                return true;
            else
                return false;
        }

        [Ignore]
        private bool IsValidEmailAddress
        {          
            get
            {
                
                return ValidEmail(Email);
            }
        }

        [Ignore]
        private bool IsValidGender
        {
            get
            {                
                return (Gender != null || Gender != "");
            }
        }

        [Ignore]
        private bool IsValidFitnessGoal
        {
            get
            {
                return (FitnessGoal != null && FitnessGoal != "");
            }
        }

        [Ignore]
        private bool IsValidGymClass
        {
            get
            {
                return (GymClass != null && GymClass != "");
            }
        }

        [Ignore]
        private bool IsValidSport
        {
            get
            {
                return (Sport != null && Sport != "");
            }
        }

        #region IDataErrorInfo Members

        private string error = string.Empty;
        public string Error
        {
            get { return error; }
        }

        public string this[string columnName]
        {
            get
            {

                error = string.Empty;
                if (columnName == "LastName")
                {
                    if(string.IsNullOrWhiteSpace(LastName))
                    {
                        Console.WriteLine("column"+ columnName);
                        error = "Last name is required!";
                    }
                    else
                    {
                    Console.WriteLine(string.IsNullOrWhiteSpace(LastName));
                    isLastName = true;
                    }
                    
                }
                

                if (columnName == "City")
                {
                    if(string.IsNullOrWhiteSpace(City))
                    {
                        error = "City is required!";
                    }
                    else
                    {
                        isCity = true;
                    }
                        
                }
                

                if (columnName == "PostalCode")
                {
                    if(string.IsNullOrWhiteSpace(PostalCode))
                    {
                        error = "Postal Code is required!";
                    }
                    else
                    {
                        isPostalCode = true;
                    }
                    
                }
                

                if (columnName == "Gender")
                {   
                    if(!IsValidGender)
                    {
                        error = "Gender is required!";
                    }
                    else
                    {
                        isGender = true;
                    }   
                    
                }
                

                if (columnName == "Email")
                {
                    if(string.IsNullOrWhiteSpace(Email))
                    {
                         error = "Email address is required!";
                    }
                    else if(!IsValidEmailAddress)
                    {
                        error = "Please enter valid email address!";
                    }
                    else
                    {
                        isEmail = true;
                    }   
                   
                }
                

                if (columnName == "FitnessGoal" && !IsValidFitnessGoal)
                {
                    error = "Fitness Goal is required!";
                }
                else
                {
                    isFitnessGoal = true;
                }   

                if (columnName == "GymClass" && !IsValidGymClass)
                {
                    error = "Gym Class is required!";
                }
                else
                {
                    isGymClass = true;
                }   
                if (columnName == "Sport" && !IsValidSport)
                {
                    error = "Sport is required!";
                }
                else
                {
                    isSport = true;
                }

                if (isLastName && isCity && isPostalCode && isEmail && isGender)
                    IsSelectedBtn3 = true;
                else
                    isSelectedBtn3 = false;


                if (isFitnessGoal && isGymClass && isSport)
                    IsSelectedBtn4 = true;
                else
                    isSelectedBtn3 = false;
                //RaisePropertyChanged("IsValidSave");
                return error;

            }
        }

        #endregion
        public void RaisePropertyChanged(string propertyName)
        {
            if (null != PropertyChanged)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
