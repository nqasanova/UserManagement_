using System;
using UserManagement.ApplicationLogic;

namespace UserManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available Commands : ");
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");

            while (true)
            {
                Console.WriteLine("Please enter command : ");
                string command = Console.ReadLine();

                if (command == "/register")
                {
                    Authentication.Register();
                }

                else if (command == "/login")
                {
                    Authentication.Login();
                }

                else if (command == "/exit")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Command not found!");
                }
            }
        }
    }
}