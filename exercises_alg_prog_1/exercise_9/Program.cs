using System;

namespace exercise_9
{
    class Program
    {
        static void Solution_1() 
        {
            int[] numbers = new int[3];
            int counter = 0;

            for(int i = 0; i < numbers.Length; i++) {
                
                Console.Write($"{((char)(i + 65))} = " );
                numbers[i] = int.Parse(Console.ReadLine());

                if(i > 0)
                    if (numbers[i] == numbers[i-1])
                        counter++;
            }

            Console.WriteLine(counter == 2 ? "Equilateral" : counter < 1 ? "Scalene" : "Isosceles");
            
        }

        static void Main(string[] args)
        {
            Solution_1();

            Console.ReadKey();
        }
    }
}
