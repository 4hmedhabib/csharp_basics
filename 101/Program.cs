// ? INT
// =====
// int a = 2;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;

// Console.WriteLine(d);
// int max = int.MaxValue;
// int min = int.MinValue;

// Console.WriteLine($"The range of integers is {min} to {max}");

// ? DOUBLE
//  =======

// double max = double.MaxValue;
// double min = double.MinValue;
// Console.WriteLine($"The range of double is {min} to {max}");

// ? DECIMALS
// ==========
// decimal min = decimal.MinValue;
// decimal max = decimal.MaxValue;

// Console.WriteLine($"The range of decimal is {min} to {max}");


// ? LONG
// ======
// long min = long.MinValue;
// long max = long.MaxValue;

// Console.WriteLine($"The range of long is {min} to {max}");

// ? CHALLENGE
//   =========
// double radius = 2.50;
// double area = Math.PI * radius * radius;

// Console.WriteLine(area);

// * BRANCHES
// ==========

// ? IF STATEMENT
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 5;
            // int b = 3;
            // int c = 4;

            // bool isGreaterThan10 = a + b > 10;
            // if (isGreaterThan10)
            // {
            //     Console.WriteLine("The Answer is greater than 10");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10");
            // }



            // if ((a + b + c > 10) && (a == b))
            // {
            //     Console.WriteLine("The answer is greater than 10");
            //     Console.WriteLine("And the first number is equal to the second.");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10");
            //     Console.WriteLine("Or the first number is not equal to the second");
            // }


            // if ((a + b + c > 10) || (a == b))
            // {
            //     Console.WriteLine("The answer is greater than 10");
            //     Console.WriteLine("Or the first number is equal to the second");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10");
            //     Console.WriteLine("And the first number is not equal to the second");
            // }


            // ? WHILE LOOP
            // ============
            // int counter = 0;
            // while (counter < 10)
            // {
            //     Console.WriteLine($"COUNTER {counter}");
            //     counter++;
            // }

            // ? DO WHILE LOOP
            // ===============
            // int counter = 0;
            // do
            // {
            //     Console.WriteLine($"COUNTER {counter}");
            //     counter++;
            // } while (counter < 10);


            // ? FOR LOOP
            // ==========
            // for (int index = 1; index <= 10; index++)
            // {
            //     Console.WriteLine($"Hello World, {index}");
            // }

            // ? Nested If Statement and Loops
            // ===============================
            // int sum = 0;
            // for (int i = 1; i <= 10; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //         sum = sum + i;
            //     }
            // }
            // Console.WriteLine($"Total Sum is : {sum}");

            // ? Nested Loops
            // ==============
            // for (int row = 1; row < 11; row++)
            // {
            //     for (char column = 'a'; column < 'k'; column++)
            //     {
            //         Console.WriteLine($"The cell is ({row}, {column})");
            //     }
            // }


            // ? FOREACH LOOP
            // ==============
            // * List Type String
            // ------------------
            var names = new List<string> { "<name>", "Ahmed", "Felipe" };
            // foreach (string name in names)
            // {
            //     Console.WriteLine($"Hello {name.ToUpper()}!");
            // }

            // for (int i = 0; i < names.Count; i++)
            // {
            //     Console.WriteLine($"Hello {names[i].ToUpper()}!");
            // }

            // * ARRAY METHODS
            // ===============
            // names.Add("Maria");
            // names.Add("Bill");
            // names.Sort();
            // names.Remove("<name>");

            // foreach (string name in names)
            // {
            //     Console.WriteLine(name);
            // }

            // var index = names.IndexOf("Maria");

            // if (index == -1)
            // {
            //     Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            // }
            // else
            // {
            //     Console.WriteLine($"The name {names[index]} is at index {index}");
            // }

            // * List Type Int
            // ---------------
            var fabonacciNumbers = new List<int> { 1, 1 };

            while (fabonacciNumbers.Count < 20)
            {

                var previous = fabonacciNumbers[fabonacciNumbers.Count - 1];
                var previous2 = fabonacciNumbers[fabonacciNumbers.Count - 2];

                fabonacciNumbers.Add(previous + previous2);
            };

            foreach (var fabon in fabonacciNumbers)
                Console.WriteLine(fabon);

        }
    }
}