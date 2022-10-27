using System;

namespace TCSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageText;
            int age;
            string firstName;
            bool alive;
            string phoneNumber;

            Console.WriteLine("What is your name? ");
            firstName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName}.  It's nice to meet you.");

            Console.WriteLine("What is your age?: ");
            ageText = Console.ReadLine();
            Console.WriteLine($"Your age is {ageText}:");

            Console.WriteLine("Are you alive? yes/no :");
            alive = Console.ReadLine();
            Console.WriteLine($"The Answer to whether or not I'm alive is {alive}.");
            
            Console.WriteLine("What is your phone number, numbers only 1234567890");
            phoneNumber = Console.ReadLine();
            Console.WriteLine($"Your phone number is {phoneNumber}");




            Console.WriteLine("Application Done");
            Console.ReadLine();

        }





    }
}
