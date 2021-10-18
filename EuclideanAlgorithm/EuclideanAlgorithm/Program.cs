using System;

namespace EuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            bool isEquels = false;
            while (!isEquels)
                if (numberOne > numberTwo)
                {
                    int subtraction = numberOne - numberTwo;
                    numberOne = subtraction;
                }

                else if (numberOne < numberTwo)
                {
                    int subtraction2 = numberTwo - numberOne;
                    numberTwo = subtraction2;
                }

                else
                {
                    isEquels = true;
                    Console.WriteLine($"The greatest common divisor for the given numbers is: {numberOne}");
                }

        }
    }
}
