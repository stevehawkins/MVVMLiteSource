using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System.Windows.Input;
using System.Threading.Tasks;
using mvvmLiteExample.Models;

namespace mvvmLiteExample.viewmodels
{
    public class UserInfoViewModel : ViewModelBase
    {
        private Person _person;
        private INavigationService _nav;

        public UserInfoViewModel(INavigationService navi)
        {
            _nav = navi;

            // set some default here for example
            _person = new Person
            {
                Age = 21,
                FirstName = "Steve",
                LastName = "Hawkins"
            };

         
         }

        public int Age
        {
            get { return _person.Age; }
            set
            {
                _person.Age = value;
                RaisePropertyChanged("UserInfo");
            }
        }

        public string FirstName
        {
            get { return _person.FirstName; }
            set
            {
                // if we are displaying firstname and we want to update we need to use
                // Set<string>(ref _person.FirstName, value, "FirstName"); // would need to be a seperate property

                _person.FirstName = value;
                RaisePropertyChanged("UserInfo");
            }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set
            {
                _person.LastName = value;
                RaisePropertyChanged("UserInfo");

            }
        }

        public string UserInfo
        {
            get { return _person.PersonInfo(); }
        }
    }
}
