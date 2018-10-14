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
            bool cont = true;

            do
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
                Console.WriteLine("Continue?(y/n)");
                bool cont2 = true;
                while (cont2)
                {
                    string yesOrNo;

                    yesOrNo = Console.ReadLine().ToLower();

                    if (yesOrNo == "y")
                    {
                        cont2 = false;
                    }

                    else if (yesOrNo == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        cont = false;
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try Again!");
                    }

                }

            } while (cont);
            
        }
    }
}
