using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string noSpase(string one)
        {
            for (int i = 0; i < one.Length; i++)
            {
                while (one[i] == ' ' && one[i + 1] == ' ')
                {
                    one = one.Remove(i + 1, 1);
                }
            }
            return one;
        }
        static void wordMax(string[] mass)
        {
            int maxWord = mass[0].Length;
            int indexMax = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Length > maxWord)
                {
                    indexMax = i;
                    maxWord = mass[i].Length;
                }
            }

            Console.WriteLine("Самое длинное слово: " + mass[indexMax]);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string one = Console.ReadLine();

            string oneNoSpase = noSpase(one);

            string[] mass = oneNoSpase.Split(new char[] { ' ' });

            wordMax(mass);


        }
    }
}