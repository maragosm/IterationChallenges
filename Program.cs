using System;

namespace Iteration_Statements_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro / First Challenge
            Console.WriteLine("Welcome to Michael M's Iteration Statement Challenge program.");
            Console.WriteLine("For my first trick, I will not print all numbers 1000 to -1000");
            Console.WriteLine();
            CountDown();

            //Second Challenge
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Next, I will count to 999 by threes, printing my count as I go.");
            Console.WriteLine();
            IncrBy3();

            //Third Challenge
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("For my next trick, I will need two integers, any two! Please type them below.");
            Console.WriteLine("Integer 1:");
            var userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Integer 2:");
            var userInput2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            EqualCheck(userInput1, userInput2);

            //Fourth Challenge
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Now, provide one integer for this next trick.");
            Console.WriteLine("Integer:");
            var userInput3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            EvenCheck(userInput3);

            //Fifth Challenge
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("For the grand finale, I will need one last integer.");
            Console.WriteLine("Integer:");
            var userInput4 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            PositiveCheck(userInput4);

            //Sixth Challenge
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enough 'magic', how old are you anyways?");
            Console.WriteLine("Age:");
            var userInput5 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Age(userInput5);

            //Seventh Challenge
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wait, I almost forgot! I have two more magic tricks. Give me a new integer.");
            Console.WriteLine("Integer:");
            var userInput6 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            TensRange(userInput6);

            //Eighth Challenge
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Alright, last trick I swear to Bill Gates. Can I have one more integer, please?");
            Console.WriteLine("Integer:");
            var userInput7 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            MultTable(userInput7);

            //Outro
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("That's everything! Thanks for giving me numbers for the last minute or two.");
        }

        //First Challenge Method - Count down from 1000 to -1000
        public static void CountDown()
        {
            for (int i = 1000; i > -1001; i--)
            {
                Console.Write($"{i}, ");
            }
        }

        //Second Challenge Method - Count to 999 by threes
        public static void IncrBy3()
        {
            for (int i = 3; i < 1000; i+=3)
            {
                Console.Write($"{i}, ");
            }
        }

        //Third Challenge Method - Check if input are equal
        public static void EqualCheck(int userInput1, int userInput2)
        {
            Console.WriteLine(userInput1 == userInput2 ? $"{userInput1} is equal to {userInput2}" : $"{userInput1} is not equal to {userInput2}");
        }

        //Fourth Challenge Method - Check if input is even or odd
        public static void EvenCheck(int userInput3)
        {
            var test = userInput3 % 2;
            Console.WriteLine(test == 0 ? $"{userInput3} is even" : $"{userInput3} is odd");
        }

        //Fifth Challenge Method - Check if input is posetive or negative
        public static void PositiveCheck(int userInput4)
        {
            if (userInput4 > 0)
            {
                Console.WriteLine($"{userInput4} is posetive");
            }
            else if (userInput4 < 0)
            {
                Console.WriteLine($"{userInput4} is negative");
            }
            else
            {
                Console.WriteLine("Way to be difficult, I'm going to say 0 is posetive.");
            }
        }

        //Sixth Challenge Method - Check if old enough to drink (without carding)
        public static void Age(int userInput5)
        {
            Console.WriteLine(userInput5 >= 21 ? $"Let's grab a drink." : $"Lets grab a drink... of soda.");
        }

        //Seventh Challenge Method - Check if input is between 10 and -10 (inclusive)
        public static void TensRange(int userInput6)
        {
            bool range = userInput6 <= 10 && userInput6 >= -10;
            Console.WriteLine(range == true ? $"{userInput6} is included in the range of 10 to -10" : $"{userInput6} is not included in the range of 10 to -10");
        }

        //Eighth Challenge Method - Output multiplication table (1 to 12) of input
        public static void MultTable(int userInput7)
        {
            for (int i = 0; i <= 10; i++)
            {
                var currentMult = userInput7 * i;
                Console.WriteLine($"{userInput7} * {i} = {currentMult}");
            }
        }

    }
}
