using System;

namespace exercise_6
{
    class Program
    {

        static void Solution_1() 
        {
            int[] numbers = new int[3];

            for(int i = 0; i < numbers.Length; i++) {
                Console.Write($"n{ (i+1 < numbers.Length ? i+1 : "Average") } = " );
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\n n3 = {(numbers[2]*3)-numbers[1]-numbers[0]}");
        }

        static void Main(string[] args)
        {
            Solution_1();
        }
    }
}
