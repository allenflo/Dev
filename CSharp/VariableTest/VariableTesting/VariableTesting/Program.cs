using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            

            Console.Write("What is your First Name? ");
            firstName = Console.ReadLine();
            Console.Write("What is your Last Name?");
            lastName = Console.ReadLine();
            Console.Write("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welcome " + firstName + " " + lastName);
            Console.WriteLine("You're Age is " + age);
           


            Console.ReadLine();


        }
    }
}
