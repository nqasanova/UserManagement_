using System.Text.RegularExpressions;
using UserManagement.Database.Models;
using UserManagement.Database.Repository;

namespace UserManagement.ApplicationLogic.Validations
{
    public class Validation
    {
        public static bool IsLengthBetween(string text)
        {
            string pattern = @"[a-zA-Z]{3, 30}";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }

        public static bool IsFirstLetterUpperCase(string text)
        {
            string pattern = @"^[A-Z]";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }

        public static bool IsNumberExists(string text)
        {
            string pattern = @"[0-9]";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }

        public static bool IsNumberAndLetters(string text)
        {
            string pattern = @"[a-zA-Z0-9]";
            Regex regex = new Regex(text);

            return regex.IsMatch(text);
        }
        public static bool IsLetterUpperAndLower(string text)
        {
            string firstPattern = @"[a-z]";
            string secondPattern = @"[A-Z]";

            Regex firstRegex = new Regex(firstPattern);
            Regex secondRegex = new Regex(secondPattern);

            return firstRegex.IsMatch(text) && secondRegex.IsMatch(text);
        }

        public static bool IsEmailDomain(string email)
        {
            string pattern = @"^[a-z]+[\w.]+@code+[.]+edu+[.]+az";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        public static bool IsEmailUnique(string email)
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.Email == email)
                {
                    Console.WriteLine("This email is already registered!");
                    return false;
                }
            }

            return true;
        }

        public static bool IsValidEmailLength(string email)
        {
            string pattern = @"[a-zA-Z]{10, 30}";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        public static bool IsValidPasswordLength(string text)
        {
            string pattern = @"[a-zA-Z]{8, }";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }
    }
}
