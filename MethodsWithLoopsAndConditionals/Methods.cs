using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {   // Write a method that will print to the console all numbers 1000 through -1000

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintThreeNines()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void TwoIntParam(int x, int y)
        {
            string answer = x == y ? "They are equal" : "They are NOT equal";
            Console.WriteLine(answer);
        }
        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number: ");
            int c = int.Parse(Console.ReadLine());
            if (c % 2 == 0)
            {
                Console.Write("This number is an even number.");
                Console.Read();
            }
            else
            {
                Console.Write("This number is an odd number.");
                Console.Read();
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Enter a number: ");
            int c = int.Parse(Console.ReadLine());
            if (c > 0)
            {
                Console.WriteLine("This is a positive number");
            }
            else if (c == 0)
            {
                Console.WriteLine("You gave me a zero, hero");
            }
            else
            {
                Console.WriteLine("This is a negative number");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote. TRY-PARSE!!! LET'S GOOO!!
        public static void AgeOfCandidate()
        {
            int age = 0;
            bool ageVerify;
            //Do-While loop bc i need to save their age at least once

            do
            {
                Console.WriteLine("Please enter your age: ");
                ageVerify = int.TryParse(Console.ReadLine(), out age);

            } while (ageVerify == false);
            if (age <= 18 && age < 0)
            {
                Console.WriteLine("You are too young to vote");
            }
            else
            {
                Console.WriteLine("You are of ripe voting age");
            }
        }



        //HEATING UP SECTION:
        //Write a method to check if an integer (from the user) is in the range -10 to 10

        public static void IntegerRange()
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            if (x > -10 && x < 10)
            {
                Console.WriteLine("This is within range");
            }
            else if (x == 0)
            {
                Console.WriteLine("You provided a zero value");
            }
            else
            {
                Console.WriteLine("This is not within range");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplicationTable()
        {
            Console.WriteLine("Please provide a number: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{x}*{i}={x*i}");
            }
        }
    }

}   




