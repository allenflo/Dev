using System;
using System.Collections.Generic;
using System.Text;

namespace TCSandbox
{
    public class UserMessaging
    {
        public static void ApplicationStartMessage()
        {
            Console.WriteLine("Welcome to the Static Class Demo App");

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine("Good Morning!");
            }

            else
            {
                Console.WriteLine("Good AfterNoon!");
            }

        }
    }
}
