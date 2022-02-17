

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("How many number do you want to add together?");
            string numberLength = Console.ReadLine();
            
            int numOfNumbers = number(numberLength);

            while (numOfNumbers > 10 || numOfNumbers < 1)
            {
                Console.WriteLine($"{numberLength} is not a valid number. Choose a new number from 1-10.");
                numberLength = Console.ReadLine();
                numOfNumbers = number(numberLength);
            }

            Console.WriteLine("What numbers do you want to add together?\nNot entering a number will be counted as a 0");
            Console.WriteLine("Input them on the same line, separated by spaces.");
            string[] numbersAsString = Console.ReadLine().Split(" ");
            long[] numbers = new long[numOfNumbers];
            
            for (int i = 0; i < numbersAsString.Length; i++)
            {
                while(numbersAsString.Length > numOfNumbers)
                {
                    Console.WriteLine($"Too many numbers chosen. You can only select {numOfNumbers} numbers");
                    numbersAsString = Console.ReadLine().Split(" ");
                }


                numbers[i] = validate(numbersAsString[i]);
            }

            long total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }

            Console.WriteLine(total);
        }
        
        public static int number(string numberLength)
        {
            int numOfNumbers;
            bool wholeNum = int.TryParse(numberLength, out numOfNumbers);

            while (wholeNum != true || numberLength == null)
            {
                Console.WriteLine($"{numberLength} is not a valid number. Choose a new number.");
                numberLength = Console.ReadLine();
                wholeNum = int.TryParse(numberLength, out numOfNumbers);
            }

            return numOfNumbers;
        }

        public static long validate(string numberLength)
        {
            long numOfNumbers;
            bool wholeNum = long.TryParse(numberLength, out numOfNumbers);

            while (wholeNum != true || numberLength == null || numOfNumbers > (Math.Pow(10, 10)) || numOfNumbers < 0)
            {
                Console.WriteLine($"{numberLength} is not a valid number choice. Choose a new number.");
                numberLength = Console.ReadLine();
                wholeNum = long.TryParse(numberLength, out numOfNumbers);
            }

            return numOfNumbers;
        }
    }
}
