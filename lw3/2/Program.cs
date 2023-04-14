using System;

namespace MyApp
{
    internal class Program
    {
        static int razrad(int number)
        {
            string number1 = Convert.ToString(number);
            int lengthnumber = Convert.ToInt32(number1.Length);
            return lengthnumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число {number} содержит в себе {razrad(number)} разрядов");
        }
    }
}

