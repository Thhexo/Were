using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, l, a = 0, b = 0, c = 0, d = 0;
            Console.WriteLine("Сколько элементов в вашей последовательности?");
            n = Convert.ToInt32(Console.ReadLine());
            int[] an = new int[n];
            for (int i = 0; i < n;i++)
            {
                Console.WriteLine("Ведите {0} элемент последовательности", i);
                l = Convert.ToInt32(Console.ReadLine());
                an[i] = l;
            };


            for (int i = 0; i < n - 1; i++)
            {

                if (an[i] == an[i + 1])
                    a++;
                if ((an[i] == 0) && (an[i + 1] == 0))
                    b++;
                else if ((an[i] % 2 == 0) && (an[i + 1] % 2 == 0))
                    c++;
                if ((an[i] == 5) && (an[i + 1] == 5))
                    d++;


            }
            Console.WriteLine("Количество пар соседних чисел последовательности, равных между собой равно {0}", a);
            Console.WriteLine("Количество пар соседних чисел последовательности, равных нулю равно {0}", b);
            Console.WriteLine("Количество пар соседних чисел последовательности, являющихся четными числами равно {0}", c);
            Console.WriteLine("Количество пар соседних чисел последовательности, оканчивающихся на цифру 5 равно {0}", d);

        }
    }
}