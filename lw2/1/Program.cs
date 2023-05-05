using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 предложение");
            string one = Console.ReadLine();
            Console.WriteLine("Введите 2 предложение");
            string two = Console.ReadLine();
            string[] wordOne = one.Split(new char[] { ' ' });
            string[] wordTwo = two.Split(new char[] { ' ' });

            int[] massword = new int[wordOne.Length];
            int i = 0, n;
            foreach (string o in wordOne)
            {
                n = 0;
                foreach (string t in wordTwo)
                {
                    if (o == t) massword[i] = ++n;
                }
                i++;
            }

            Console.WriteLine("Во втором предложении повторялись следующие слова:");
            for (int v = 0; v < wordOne.Length; v++)
            {
                Console.WriteLine("{0}={1}", wordOne[v], massword[v]);
            }
        }
    }
}
