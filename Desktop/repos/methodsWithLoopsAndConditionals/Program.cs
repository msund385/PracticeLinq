using System;
using System.Security.Cryptography.X509Certificates;

namespace methodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome , well see if you're eligible to vote");
            Console.WriteLine("Enter you're age to see if you can?");
            Vote(Convert.ToInt32(Console.ReadLine()));




        }
         public static void Vote(int num1)
        {

            if (num1 < 18)
            {
                Console.WriteLine("You are not old enough,give it some years");

            }
            else
            {
                Console.WriteLine("You are old enough to vote,congrats,exercise your right");
            }
        }

    }
}
