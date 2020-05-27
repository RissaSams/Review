using System;

namespace Review
{
    class Question2
    {
        static void Main(string[] args)
        {
            
        }

        private static void One()
        {
            for (int i = 13; i <= 76; i++)
            {
                Console.WriteLine($"The loop index is = {i}.");
            }
        }


        private static void Two()
        {
            for (int i = 0; i <= 50; i+=7)
            {
                Console.WriteLine($"The loop index squared is: {i}.");
            }
        }

        private static void Three()
        {
            for (int i = 21; i <= 43; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine($"{i} is an odd number.");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine($"The number {i} is divisible by 2.");
                }
            }
        }

        
    }
}
