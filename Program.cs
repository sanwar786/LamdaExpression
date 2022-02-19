using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    internal class Program
    {
        //User Registration Using Lamda Expression
        //Instance Variable
        public static string firstName, lastName, email;
        //Main Method
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME to User Registration using Lambda Expression");
            Console.WriteLine("Choose an Option:\n 1. First Name\t2.Last Name\t3.Email\t4.Mobile Number\t5.Password\t6.exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter your first name (first lettershould be in capital format)");
                    firstName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter your Last Name(first lettershould be in capital format)");
                    lastName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter your email");
                    email = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Enter your mobile number");
                    string mobileNumber = Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Enter password");
                    string passWord = Console.ReadLine();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }


            Console.ReadLine();
        }
    }
}
