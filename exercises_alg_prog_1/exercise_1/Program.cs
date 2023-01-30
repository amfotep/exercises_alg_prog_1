using System;
using System.Linq;
using static System.Math;

namespace exercise_1
{
    class Program
    {
        // Solution for non-organized numbers
        static void Solution_2() {
            int[] numbers = new int[3];
            int max = 0, result = 0;

            for(int i = 0; i < numbers.Length; i++) {
                Console.Write($"Write {((char)(i + 65))} = " );
                numbers[i] = int.Parse(Console.ReadLine());
            }

            max = numbers.Max();

            numbers = Array.FindAll(numbers, (int n)=> n != max);

            result = numbers.Select((int n)=> n * n).Sum();

            Console.WriteLine("\n res> " + (result == max*max ? "Yes" : "No"));   
        }

        // Solution for organized numbers
        static void Solution_1(){
            int[] numbers = new int[3];
            string response = "";

            for(int i = 0; i < numbers.Length; i++) {
                Console.Write($"Write {((char)(i + 65))} = " );
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // response = numbers[2] * numbers[2] == numbers[0]*numbers[0] + numbers[1]*numbers[1] ? "Yes" : "No";

            response = Pow(numbers[2], 2) == Pow(numbers[0], 2) + Pow(numbers[1], 2) ? "Yes" : "No";

            Console.WriteLine("\n res> " + response);            
        }

        static void Main(string[] args)
        {
            Solution_1();
            //Solution_2();

            Console.ReadKey();
        }
    }
}
