// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

using System;

namespace zadacha_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А: "); //82
            int number = Convert.ToInt32(Console.ReadLine());

            int Sum(int number) //вводим метод
            {

                int counter = Convert.ToString(number).Length; //конвертируем в строку и выводим количеств символов 2
                int result = 0; //Вводим переменные
                int advance = 0; //Вводим переменные

                for (int i = 0; i < counter; i++)
                {                   
                    advance = number - number % 10; 
                    
                    result = result + (number - advance);
                    number = number / 10;
                }
                return result;
            }

            int itog = Sum(number);
            Console.WriteLine("Сумма цифр в числе: " + itog);
        }
    }

}