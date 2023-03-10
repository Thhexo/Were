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
            for (int i = 0; i < n;i++)
            {
                Console.WriteLine("Ведите {0} элемент последовательности", i);
                l = Convert.ToInt32(Console.ReadLine());
                b[i] = l;
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