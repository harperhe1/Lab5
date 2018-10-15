using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program

    {

        static void Main(string[] args)
        {

            string doAgain;
            bool cont = true;
            while (cont)
            {

                Console.WriteLine("Welcome to the Factorial Calculator");
                Console.WriteLine("Enter an integer that's greater than 0 but less than 10: ");
                long input = long.Parse(Console.ReadLine());


                long fact = input;

                for (long i = input - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine("The factorial of " + (input) + " is " + (fact));

                bool cont2 = true;
                while (cont2)
                {

                    Console.WriteLine("Continue?(y/n)");
                    doAgain = Console.ReadLine().ToLower();

                    if (doAgain == "y")
                    {
                        cont2 = false;
                    }

                    else if (doAgain == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        cont2 = false;
                        cont = false;
                    }

                    else
                    {
                        Console.WriteLine("Invalid input. Try Again!");
                    }

                }

            }
            Console.ReadLine();
        }
    }
}
