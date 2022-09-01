// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Таблица квадратов");
        for (int i = 0; i <= number; i++)
        {
            System.Console.WriteLine(Math.Pow(i,3));
        }

        }
    }
}