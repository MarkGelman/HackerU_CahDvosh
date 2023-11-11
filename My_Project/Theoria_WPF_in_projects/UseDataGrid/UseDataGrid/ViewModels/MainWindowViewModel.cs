using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseDataGrid.Helper;
using UseDataGrid.Models;

namespace UseDataGrid.ViewModels
{
    class MainWindowViewModel: ForPropertyChanged
    {
        public ObservableCollection<User> Users {get; set;}
        private User _user;

        public User SelectedUser 
        { get => _user; 
            set 
            { 
                _user = value;
                OnPropertyChanged(nameof(SelectedUser));
            } 
        }

        public ForCommand AddCommand { get; set; }
        public ForCommand DelCommand { get; set; }

        public MainWindowViewModel()
        {
            Users = new ObservableCollection<User>
            {
                    new User
                    {
                        LastName = "Piter",
                        FirstName = "Ivanov",
                        DateOfBirth = new DateTime(2000, 1, 1)
                    },

                    new User
                    {
                        LastName = "Galina",
                        FirstName = "Petrova",
                        DateOfBirth = new DateTime(1000, 1, 1)
                    }
            };

            AddCommand = new ForCommand(_ => true, _ => Add());
            DelCommand = new ForCommand(_ => Users.Count > 1, _ => Del());

        }

        private void Add()
        {
            Users.Add(SelectedUser);
        }

        private void Del()
        {
            Users.Remove(SelectedUser);
        }
    }
}
