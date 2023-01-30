using System;
using System.Linq;

namespace exercise_4
{
    class Program
    {

        static void Solution_2() 
        {
            int[] numbers = new int[2];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numbers.Max()} is greater than {numbers.Min()}");
        }


        static void Solution_1() 
        {
            int n1=0, n2=0;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.Max(n1, n2)} is greater than {Math.Min(n1, n2)}");
        }


        static void Main(string[] args)
        {
            Solution_1();
            // Solution_2();

            Console.ReadKey();
        }
    }
}
