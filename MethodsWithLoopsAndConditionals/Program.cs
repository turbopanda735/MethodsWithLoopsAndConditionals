using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main()
        {
            NegativeOneThousandToPositive();
            ThreeByThree();
            
            Console.WriteLine("please enter two numbers and i will check if they are equal");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(AreEqual(x, y));

            Console.WriteLine("enter a number to check if it is even");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenOrOdd(z));

            Console.WriteLine("enter a number to check if it is positive");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(PositiveOrNegative(a));

            Console.WriteLine("enter an age to see if they are eligible to vote");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(VotingAge(b));

            Console.WriteLine("please enter a number and i will check if it is between -10 and 10");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(InRange(c));

            Console.WriteLine("please enter a number to display the multiplication table 1-12");
            int userInput = int.Parse(Console.ReadLine());
            MultiplicationTable(userInput);
            Console.ReadLine();
        }
        static void NegativeOneThousandToPositive()
        {
            //Write a method that will print to the console all numbers 1000 through -1000
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void ThreeByThree()
        {
            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                Console.WriteLine(i);
            }
        }
        static bool AreEqual(int x, int y)
        {
            //Write a method to accept two integers as parameterss and check whether they are equal or not
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool EvenOrOdd(int z)
        {
            //Write a method to check whether a given number is even or odd
            if (z % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;    
            }
        }
        static bool PositiveOrNegative(int a)
        {
            //Write a method to check whether a given number is positive or negative
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string VotingAge(int b)
        {
            //Write a method to read the age of a candidate and determine whether they can vote.
            if (b < 18)
            {
                return "sorry, you are directly effected by public policy but you have no say in it"; 
            }
            else
            {
                return "america #1";
            }
        }
        static bool InRange(int c)
        {
            //Write a method to check if an integer (from the user) is in the range -10 to 10
            if (c < -10)
            {
                return false;
            }
            else if (c > 10)
            {
                return false;
            }
            else return true;
        }
        static void MultiplicationTable(int userInput)
        {
            for (int i = 1; i < 13; i++)
            {
                var result = userInput * i;
                Console.WriteLine($"{userInput} * {i} = {result}");
            }
        }
    }
}

