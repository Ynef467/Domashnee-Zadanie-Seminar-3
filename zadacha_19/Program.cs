// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Введите пятизначное число: ");
        string number = Console.ReadLine();

        void numberChec(string number)
        {
          if (number[0]==number[4] || number[1]==number[3]){
            Console.WriteLine($"Число {number} палиндром");
          }
          else Console.WriteLine($"Число {number} не палиндром");
        }
        
        if (number!.Length == 5)
        {
          numberChec(number);
        }
        else Console.WriteLine($"Введи правильное число");
           

        }
    }
}