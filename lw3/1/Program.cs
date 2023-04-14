using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static  int [] Razvorot(int[] numbers, int n)
        { int [] numberraz= new int[n];
            for (int i = n - 1, e=0; i > (-1); i--,e++)
            {
               numberraz[e]=numbers[i];
            }
            return numberraz;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Сколько элементов в вашем массиве?");
            n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ведите {0} элемент массива", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введенный массив в обратном порядке [{0}]", string.Join(", ", Razvorot(numbers, n)));
        }
    }
}