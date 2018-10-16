using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string username = nameValidation();
            Console.WriteLine("Thanks, "  + username + " What's your email?");
            string useremail = emailValidation();
            Console.WriteLine("Thanks, " + username + " What's your phone number?");
            string userphone = phoneValidation();
            Console.WriteLine("Thanks, " + username + " What's the date?");
            string userdate = dateValidation();
            Console.WriteLine("Thanks, " + username);
            
        }

        public static string nameValidation()
        {
            Console.WriteLine("What is your name?");
            //input
            string userName = Console.ReadLine();

            //processing

            while(!Regex.IsMatch(userName, @"^[A-Z]+[A-z]{2,30}$"))
            {
                Console.WriteLine("I'm sorry! That's not a name.");
                userName = Console.ReadLine();
            }

            //output
            return userName; 
        }

        public static string emailValidation()
        {
            Console.WriteLine("Please enter a valid email");
            string userEmail = Console.ReadLine();

            while(!Regex.IsMatch(userEmail, @"^[A-z0-9]{5,30}@[a-z]{5,10}.[a-z]{2,3}$"))
            {
                Console.WriteLine("I'm sorry! That's not a valid email.");
                userEmail = Console.ReadLine();
            }

            return userEmail;
        }

        public static string phoneValidation()
        {
            Console.WriteLine("Please enter a valid phone number");
            string userPhone = Console.ReadLine();

            while(!Regex.IsMatch(userPhone, @"^\d\d\d-\d\d\d-\d\d\d\d$"))
            {
                Console.WriteLine("I'm sorry! That's not a valid phone number");
                userPhone = Console.ReadLine();
            }

            return userPhone;
        }

        public static string dateValidation()
        {
            Console.WriteLine("Please enter a valid date");
            string userDate = Console.ReadLine();

            while(!Regex.IsMatch(userDate, @"^\d{2}\/\d{2}\/\d{4}$"))
            {
                Console.WriteLine("I'm sorry! That's not a valid date");
                userDate = Console.ReadLine();
            }

            return userDate;
        }

    }

}
