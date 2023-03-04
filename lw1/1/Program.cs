using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, p, l;
            Console.WriteLine("Сколько элементов в вашей последовательности?");
            n = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[n];
            for (int i = 0; i < n;)
            {
                Console.WriteLine("Ведите " + i + " элемент последовательности");
                l = Convert.ToInt32(Console.ReadLine());
                b[i] = l;
                i++;
            };

            Console.WriteLine("Ведите p");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Следующие элементы последовательности больше " + p);
            foreach (int posl in b)
            {
                if (posl > p)
                {
                    Console.WriteLine(posl);
                }
                else
                {
                    continue;
                }

            }
        }
    }
}