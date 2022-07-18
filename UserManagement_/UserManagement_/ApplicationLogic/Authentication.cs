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

            Console.Write("Please enter user's last name : ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter user's email : ");
            string email = Console.ReadLine();

            Console.Write("Please enter user's password : ");
            string password = Console.ReadLine();

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
                    Console.WriteLine(UserRepository.GetUser(email));

                    Console.WriteLine("/show-users");
                    string command = Console.ReadLine();

                    if (command == "/show-users")
                    {
                        UserRepository.GetAll();
                    }

                    else
                    {
                        Console.WriteLine("Welcome!");
                        Console.WriteLine(UserRepository.GetUser(email));
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
