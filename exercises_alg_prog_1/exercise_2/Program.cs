using System;

namespace exercise_2
{
    class Program
    {

        static void Solution_1() {
            int sum = 0, length = 4;

            for (int i = 0; i < length; i++)
            {   
                Console.Write($"L{i+1} = ");
                sum += int.Parse(Console.ReadLine()); 
            }
            
            Console.WriteLine($"\nRectangle perimeter is: {sum}");
        }

        static void Main(string[] args)
        {
            Solution_1();
            Console.ReadKey();
        }
    }
}
