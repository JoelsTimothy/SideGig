using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Threading;
using System.Net.Cache;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Class1
{
	public Class1()
	{

        static void Main(string[] args)
        {

            int[] numbers = new int[10] { 1234, 2345, 3456, 4567, 5678, 6789, 7890, 8901, 9012, 0123 };
            Console.WriteLine(numbers[0]);

            Console.WriteLine("Welcome to Golds Gym!");
            Console.Write("Are you a Gold Customer? True or False: ");
            bool isGoldCustomer = Convert.ToBoolean(Console.ReadLine());

            float price;
            if (isGoldCustomer)
            {
                MembershipNumber1();
            }
            else
            {
                price = 29.95f;
                Console.WriteLine("Welcome to Golds Gym!  Your entrance fee will be {0}", price);
            }
        }

        //### activate: private static void MembershipNumber()

        //private static void MembershipNumber()
        {
            int[] numbers = new int[9] { 1234, 2345, 3456, 4567, 5678, 6789, 7890, 8901, 9012 };
            Console.Write("Please type in your 4 digit membership number: ");
            int result = Convert.ToInt32(Console.ReadLine());

            float price;
            if (result.Equals(numbers[0]) || result.Equals(numbers[1]) || result.Equals(numbers[2]))
            {
                price = 19.95f;
                Console.WriteLine("Welcome Gold Member!  Your entrance fee today is only {0}", price);
            }
            else if (result.Equals(numbers[3]) || result.Equals(numbers[4]) || result.Equals(numbers[5]))
            {
                price = 19.95f;
                Console.WriteLine("Welcome Gold Member!  Your entrance fee today is only {0}", price);
            }
            else if (result.Equals(numbers[6]) || result.Equals(numbers[7]) || result.Equals(numbers[8]))
            {
                price = 19.95f;
                Console.WriteLine("Welcome Gold Member!  Your entrance fee today is only {0}", price);
            }

            else
            {
                LoginAttempt1();  
            }

            Console.WriteLine("Thank you for coming in!");

        }

        //### activate: private static void LoginAttempt1()

        //private static void LoginAttempt1()   
        {
            int loginAttempts = 0;
            float price;
            for (int i = 1; i < 3; i++)
            {
                int[] numbers = new int[9] { 1234, 2345, 3456, 4567, 5678, 6789, 7890, 8901, 9012 };
                Console.WriteLine("Incorrect membership number");
                Console.Write("Please type in your 4 digit membership number again: ");
                int result = Convert.ToInt32(Console.ReadLine());

                if (result.Equals(numbers[0]) || result.Equals(numbers[1]) || result.Equals(numbers[2]))
                {
                    price = 19.95f;
                    Console.WriteLine("Welcome Gold Member!  Your entrance fee today is only {0}", price);
                    break;
                }
                else if (result.Equals(numbers[3]) || result.Equals(numbers[4]) || result.Equals(numbers[5]))
                {
                    price = 19.95f;
                    Console.WriteLine("Welcome Gold Member!  Your entrance fee today is only {0}", price);
                    break;
                }
                else if (result.Equals(numbers[6]) || result.Equals(numbers[7]) || result.Equals(numbers[8]))
                {
                    price = 19.95f;
                    Console.WriteLine("Welcome Gold Member!  Your entrance fee today is only {0}", price);
                    break;
                }
                else
                    loginAttempts++;

            }

            if (loginAttempts > 1)
            {
                price = 29.95f;
                Console.WriteLine("Login Failure.  We cannot confirm your membership.  Please confirm with staff, or pay todays entrance fee of {0}", price);
            }

        }

    }
}
