using System;

namespace SelectionsTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username;
            Console.Write("Please enter your Username: ");
            Username = Console.ReadLine();

            if (Username == "Jarrod")
            {
                Console.Write("Please enter your password: ");
            }

            else 
            {
                Console.Write("Login unsuccessful! Sorry, that Username does not exist.");
                return;
            }

            string Password;
            Password = Console.ReadLine();

            if (Password == "admin")
            {
                Console.Write("Login successful!");
            }

            else
            {
                Console.Write("Login unsuccessful! Incorrect Password.");
            }
        }
    }
}
