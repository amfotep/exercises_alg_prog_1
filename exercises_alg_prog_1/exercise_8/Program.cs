using System;

namespace exercise_8
{
    class Program
    {

        static void Solution_1() 
        {
            int n1 =0, n2=0;
            const int C = 15;

            Console.Write($"N1 = ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write($"N1 = ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Average = {(n1+n2)/2}");
            Console.WriteLine($"Sum, Subs, Mult by 15 are {n1+n2} {n1-n2} {(n1+n2) * C}");
        }

        static void Main(string[] args)
        {
            Solution_1();
            Console.ReadKey();
        }

    }
}
