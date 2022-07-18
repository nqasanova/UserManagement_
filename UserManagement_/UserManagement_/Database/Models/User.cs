using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Database.Models
{
    internal class User
    {
        private static int IDCounter;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegisterationTime { get; set; }

        public User(string firstName, string lastName, string email, string password)
        {
            ID = IDCounter;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IDCounter++;
            RegisterationTime = DateTime.Now;
        }

        public string GetUserInfo()
        {
            return $" ID: {ID}, Name : {FirstName}, Last name : {LastName}, Email : {Email}, Password : {Password}, Registration Time : {RegisterationTime}";
        }
    }
}
