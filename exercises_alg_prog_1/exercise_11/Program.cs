using System;

namespace exercise_11
{
    class Program
    {

        static void Solution_1() 
        {
            int[] numbers = new int[10], numbers_2 = new int[10];


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number #{i+1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length-1, j = 0; i >= 0; i--, j++)
            {
                numbers_2[j] = numbers[i];
                Console.WriteLine(numbers_2[j]);
            }
            

        }

        static void Main(string[] args)
        {
            Solution_1();
            Console.ReadKey();
        }
    }
}
