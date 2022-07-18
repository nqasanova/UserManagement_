using UserManagement.Database.Models;
using UserManagement.Database.Repository;

namespace UserManagement.ApplicationLogic.Validations
{
    class UserValidation : Validation
    {
        public static bool IsValidFirstName(string firstName)
        {
            if (Validation.IsLengthBetween(firstName) &
                Validation.IsNumberExists(firstName) &
                Validation.IsFirstLetterUpperCase(firstName))
            {
                return true;
            }

            Console.WriteLine("The name you have entered is incorrect. Your name's first letter should be capitalized, your name should only contain letters, and your name's length should be greater than 3 and less than 30.");
            return false;
        }

        public static bool IsValidLastName(string lastName)
        {
            if (Validation.IsLengthBetween(lastName) &
                Validation.IsNumberExists(lastName) &
                Validation.IsFirstLetterUpperCase(lastName))
            {
                return true;
            }

            Console.WriteLine("The last name you have entered is incorrect.Your last name's first letter should be capitalized, your last name should only contain letters, and your last name's length should be greater than 5 and less than 20.");
            return false;
        }
        public static bool IsValidEmail(string email)
        {
            if (Validation.IsValidEmailLength(email) &
                Validation.IsNumberAndLetters(email) &
                Validation.IsEmailDomain(email) &
                Validation.IsEmailUnique(email))
            {
                return true;
            }

            Console.WriteLine("The email you have entered is incorrect.Your email should only contain letters and numbers, your email's length should be greater than 10 and less than 30, your email should contain '@', and your email's domain should be 'code.edu.az'");
            return false;
        }
        public static bool IsValidPassword(string password)
        {
            if (Validation.IsValidPasswordLength(password) &
                Validation.IsLetterUpperAndLower(password) &
                Validation.IsNumberExists(password))
            {
                return true;
            }

            Console.WriteLine("The password you have entered is incorrect. Your password should contain one uppercase letter, 1 lowercase letter, and your password should not contain symbols");
            return false;
        }

        public static bool IsValidConfirmPassword(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }

            Console.WriteLine("The passwords you have entered do not match!");
            return false;
        }

        public static bool IsValidLogin(string email, string password)
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
