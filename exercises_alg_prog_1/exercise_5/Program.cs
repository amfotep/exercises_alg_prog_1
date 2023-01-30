using System;
using System.Linq;

namespace exercise_5
{
    class Program
    {
        
        static int GetInt(char character)
        {
            Console.Write(character + " = ");
            return int.Parse(Console.ReadLine());
        }

        static void Solution_2()
        {
            int[] numbers = new int[3];
            int coincidence = 0;

            for(int i = 0; i < numbers.Length; i++) {
                Console.Write($"L{i+1} = " );
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {   
                numbers[i] *= -1;
                coincidence += Convert.ToInt32(numbers.Sum() > 0);
                numbers[i] *= -1;
            }

            Console.WriteLine(coincidence != numbers.Length ? "Triangle cannot be formed" : "Triangle is ok");

        }

        static void Solution_1()
        {
            int a=GetInt('a'), b=GetInt('b'), c=GetInt('c');

            bool condition = a+b-c>0 && a-b+c>0 && -a+b+c>0;

            Console.WriteLine(!condition ? "Triangle cannot be formed" : "Triangle is ok");

        }

        static void Main(string[] args)
        {
            Solution_1();
            // Solution_2();

            Console.ReadKey();
        }
    }
}
