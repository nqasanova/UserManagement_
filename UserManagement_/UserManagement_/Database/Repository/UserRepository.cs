using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Database.Models;

namespace UserManagement.Database.Repository
{
    internal class UserRepository
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User("Super", "Admin", "admin@gmail.com", "123321")
        };

        public static User AddUser(string firstName, string lastName, string email, string password)
        {
            User user = new User(firstName, lastName, email, password);
            Users.Add(user);
            return user;
        }
        public static List<User> GetAll()
        {
            return Users;
        }

        public static bool GetUser(string email)
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.Email == email)
                {
                    Console.WriteLine($" ID: {user.ID}, Name : {user.FirstName}, Last name : {user.LastName}, Email : {user.Email}, Password : {user.Password}, Registration Time : {user.RegisterationTime}");
                    return true;
                }
            }

            Console.WriteLine("You are not an admin!");
            return false;
        }
        public static bool IsUserExistsByEmail(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
