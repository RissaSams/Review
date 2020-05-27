using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Review
{
    class Question3
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 6, 3, 3, 6, 76, 3, 6, 8, 6, 3, 243, 5, 7 };
            //  Convert this string into an array of words
            string line = "Convert this string into an array of words";
            string[] arr = line.Split(" ");


            var largestNum = numbers.Max();
            Console.WriteLine($"The largest number is {largestNum}.");

            var anyWithG = arr.Any(s => s.EndsWith('g'));
            Console.WriteLine($"Does any of the words end with a 'g'? {anyWithG}");

            var above20 = numbers.Any(n => n > 20);
            Console.WriteLine($"Are any number greater than 20? {above20}");

            var sum = numbers.Sum();
            Console.WriteLine($"The sum of all the numbers is {sum}.");

            var sumBelow50 = numbers.Where(n => n < 50).Sum();
            Console.WriteLine($"The sum of the numbers below 50 is {sumBelow50}.");


            var middle = numbers.ElementAt(numbers.Length / 2);
            Console.WriteLine($"{middle} is the number in the middle of the array.");

            var mid = arr.ElementAt(arr.Length / 2);
            Console.WriteLine($"{mid} is the word in the middle of the array.");

            var first4 = numbers.Take(4);

            var middle3Words = arr.Skip(3).Take(3);

            var ave = numbers.Average();
            Console.WriteLine($"The average is {ave}.");
        }
    }
}
