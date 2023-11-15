using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn_SigIn.Models
{
    class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
        public string UserName { get; set; }

        public User(string id, string name, string lastName, 
                    DateTime dateOfBirth, string password, string email, string userName)
        {
            Id= id; 
            Name = name; 
            LastName = lastName;   
            DateOfBirth = dateOfBirth;  
            Password = password; 
            Email = email; 
            UserName = userName;    
        }

    }
}
