// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using System;
void zadacha27()
{
    Console.WriteLine("программа принимает на вход число и выдаёт сумму цифр в числе.");
    Console.Write("Напишите число: ");
    string number = Console.ReadLine();
    int count = number.Length;
    int sum = 0;
    for (int i = 1; i < count + 1; i ++)
    {
        char letter = number[i - 1];
        int bar = letter - '0'; // хак!
        sum = sum + bar;       
    }
    Console.WriteLine($"Сумма чисел: {sum}");

}

zadacha27();
