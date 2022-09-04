// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16 

using System;

namespace zadacha_25
{
    class Program
    {
        static void Main(string[] args)
       {
        System.Console.WriteLine("Введите число A: ");
        int numberA = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите степень в которую нужно возвести число A: ");
        int numberB = int.Parse(Console.ReadLine());

        double result = 0;

        if(numberA > 0 && numberB > 0)
        {
           result = Math.Pow(numberA, numberB);
        }
         System.Console.WriteLine(result);
       }
    }
}
