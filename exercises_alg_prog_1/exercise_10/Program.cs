using System;

namespace exercise_10
{
    class Program
    {

        static void Solution_1() 
        {
            double r = 0.0;

            Console.Write("r = ");
            r = double.Parse(Console.ReadLine());

            Console.WriteLine($"L = {2 * r * Math.PI}");
            Console.WriteLine($"A = {Math.Pow(r,2) * Math.PI}");
            
        }

        static void Main(string[] args)
        {
            Solution_1();

            Console.ReadKey();
        }
    }
}
