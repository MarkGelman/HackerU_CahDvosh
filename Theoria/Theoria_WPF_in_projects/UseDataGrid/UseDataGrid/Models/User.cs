using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDataGrid.Models
{
    internal class User : ForPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;



        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                _dateOfBirth = value;
                OnPropertyChanged(nameof(DateOfBirth));
            }
        }
    }
}
