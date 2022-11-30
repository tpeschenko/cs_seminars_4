//  Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
using System;
void zadacha29()
{
    Console.WriteLine("Программа задаёт массив и 8 случайных чисел\n\rи выводит отсортированный по модулю массив.");
    Random rand = new Random();
    int size = 8;
    int temp;
    int[] numbers = new int[size];


    for (int i = 0; i < size; i++)
    {
        numbers[i] = rand.Next(-50, 51);
    }


    Console.WriteLine("\n\rИсходнный массив: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]} ");
    }


    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size - 1 - i; j++)
        {
            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j+1]))
            {
                temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }


    Console.WriteLine("\n\rОтсортированный по модулю: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]} ");
    }

}


zadacha29();