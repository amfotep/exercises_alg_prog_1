using System;

namespace exercise_3
{
    class Program
    {

        static void Solution_1() {
            int sum = 0, length = 3;

            for (int i = 0; i < length; i++)
            {   
                Console.Write($"L{i+1} = ");
                sum += int.Parse(Console.ReadLine()); 
            }
            
            Console.WriteLine($"\n Triangle area is: {sum/2}");
        }

        
        static void Main(string[] args)
        {
            Solution_1();
            Console.ReadKey();
        }
    }
}
