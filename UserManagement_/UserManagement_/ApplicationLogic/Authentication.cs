using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.ApplicationLogic.Validations;
using UserManagement.Database.Models;
using UserManagement.Database.Repository;

namespace UserManagement.ApplicationLogic
{
    public class Authentication
    {
        public static void Register()
        {
            Console.Write("Please enter user's name : ");
            string firstName = Console.ReadLine();

            /*while(!UserValidation.IsValidFirstName(firstName))
            {
                Console.WriteLine("The name you have entered is incorrect. Your name's first letter should be capitalized, your name should only contain letters, and your name's length should be greater than 3 and less than 30.");
                firstName = Console.ReadLine();
            }*/

            Console.Write("Please enter user's last name : ");
            string lastName = Console.ReadLine();

            /*while (!UserValidation.IsValidLastName(lastName))
            {
                Console.WriteLine("The last name you have entered is incorrect. Your last name's first letter should be capitalized, your last name should only contain letters, and your last name's length should be greater than 5 and less than 20.");
                lastName = Console.ReadLine();
            }*/

            Console.Write("Please enter user's email : ");
            string email = Console.ReadLine();

            /*while (!UserValidation.IsValidEmail(email) && UserValidation.IsUserExist(email))
            {
                Console.WriteLine("The email you have entered is incorrect. Your email should only contain letters and numbers, your email's length should be greater than 10 and less than 30, your email should contain '@', and your email's domain should be 'code.edu.az'");
                email = Console.ReadLine();
            }*/

            Console.Write("Please enter user's password : ");
            string password = Console.ReadLine();

            /*while (!UserValidation.IsValidPassword(password, confirmPassword))
            {
                Console.WriteLine("The email you have entered is incorrect. Your email should only contain letters and numbers, your email's length should be greater than 10 and less than 30, your email should contain '@', and your email's domain should be 'code.edu.az'");
                password = Console.ReadLine();
                confirmPassword = Console.ReadLine();
            }*/

            Console.Write("Please enter user's confirm password : ");
            string confirmPassword = Console.ReadLine();

            if (UserValidation.IsValidFirstName(firstName) &
                UserValidation.IsValidLastName(lastName) &
                UserValidation.IsValidEmail(email) &
                UserValidation.IsValidConfirmPassword(password, confirmPassword))
            {
                User user = UserRepository.AddUser(firstName, lastName, email, password);
                Console.WriteLine($"User added to system, his/her details are : {user.GetUserInfo()}");
            }
        }

        public static void Login()
        {
            Console.WriteLine("Enter user's email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter user's password : ");
            string password = Console.ReadLine();

            if (UserValidation.IsValidLogin(email, password))
            {
                if (email == "admin@gmail.com" && password == "123321")
                {
                    Console.WriteLine("Welcome!");
                    Console.WriteLine(UserValidation.GetUser(email));

                    Console.WriteLine("/show-users");
                    string command = Console.ReadLine();

                    if (command == "/show-users")
                    {
                        UserRepository.GetAll();
                    }

                    else
                    {
                        Console.WriteLine("Welcome!");
                        Console.WriteLine(UserValidation.GetUser(email));
                    }
                }

                else
                {
                    Console.WriteLine("You have entered wrong email or password!");
                }
            }
        }
    }
}