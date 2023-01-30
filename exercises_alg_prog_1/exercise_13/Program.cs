using System;

namespace exercise_13
{
    class Program
    {

        static void Solution_1() 
        {
            string[] words = new string[6];

            for(int i = 0; i < words.Length; i++) {
                Console.Write($"word #{i+1} = " );
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]);

                if (i < words.Length - 1)
                    Console.Write(" , ");
            }
        }

        static void Main(string[] args)
        {
            Solution_1();
        }
    }
}
