// Используя определение степени числа, напишите цикл, который принимает на вход 
// два натуральных числа (A и B) и возводит число A в степень B.
using System;
void zadacha25()
{
    Console.WriteLine(" Программа принимает на вход два натуральных числа (A и B) и возводит число A в степень B");
    Random rand = new Random();
    
    int numbersA = rand.Next(1, 6);
    Console.WriteLine($"Первое число A равно: {numbersA}");
    int numbersB = rand.Next(1, 6);
    Console.WriteLine($"Второе число Б равно: {numbersB}");
    int result = numbersA;
                                                                            // Console.WriteLine($"Первое число A равно: {A}");
                                                                            // double B = rand.Next(1, 6);
                                                                            // Console.WriteLine($"Первое число B равно: {B}");

                                                                            // double result = Math.Pow(A, B);

                                                                            // Console.WriteLine($"А в степени B равно: {result}");
    for (int i = 0; i < numbersB -1; i++)
    {
        result *= numbersA;
    }
   Console.WriteLine(result);
}

zadacha25();

