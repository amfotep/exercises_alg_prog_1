using System;
using System.Linq;

namespace exercise_12
{
    class Program
    {
        static void Solution_1() 
        {
            int[] numbers = new int[5];
            int sum = 0, max = 0;

            for(int i = 0; i < numbers.Length; i++) {
                Console.Write($"n{i+1} = " );
                numbers[i] = int.Parse(Console.ReadLine());
            }

            sum = numbers[0] + numbers[numbers.Length - 1];

            Console.WriteLine($"Middle number is: {numbers[(numbers.Length/2)]}");

            Console.WriteLine($"Max number is: {numbers.Max()}"); // Solution with IEnumerable

            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }

            Console.WriteLine($"Max number is: {max}"); // Solution with algorithm
            
        }

        static void Main(string[] args)
        {
            Solution_1();
        }
    }
}
