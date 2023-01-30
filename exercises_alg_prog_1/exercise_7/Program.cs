using System;

namespace exercise_7
{
    class Program
    {   
        static void Solution_1() 
        {
            int n1 =0;

            Console.Write($"Score: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"You{(n1 < 70 ? " not " : " ")}passed!");
        }

        static void Main(string[] args)
        {
            Solution_1();
            Console.ReadKey();
        }
    }
}
