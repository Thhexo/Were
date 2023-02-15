using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e;
            Console.WriteLine("Введите число: ");
            e = Convert.ToInt32(Console.ReadLine());
            if ((e % 3 == 0) && (e % 5 == 0))
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (e % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else if (e % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
        }
    }
}
