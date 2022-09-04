// Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее , делать все в методе который возвращает массив
// 5, 1, 20 -> [1, 2, 5, 7, 19]

// 3, 1, 33 -> [6, 1, 33]



using System;

namespace zadacha_29
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Введите размер массива: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Введите минимальное значение массива: ");
            int arrayMin = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Введите максимальное значение массива: ");
            int arrayMax = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arraySize];  



             for(int i = 0; i < arraySize; i++)
            {
                array[i] = new Random().Next(arrayMin,arrayMax);
                array[0] = arrayMin;
                array[^1] = arrayMax;   
                System.Console.Write(array[i]+" ");
            }
        }
    }
}




                 