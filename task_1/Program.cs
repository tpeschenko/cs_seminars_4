// Используя определение степени числа, напишите цикл, который принимает на вход 
// два натуральных числа (A и B) и возводит число A в степень B.
using System;
void zadacha25()
{
    Console.WriteLine(" Программа принимает на вход два натуральных числа (A и B) и возводит число A в степень B");
    Random rand = new Random();
    double A = rand.Next(1, 6);
    Console.WriteLine($"Первое число A равно: {A}");
    double B = rand.Next(1, 6);
    Console.WriteLine($"Первое число B равно: {B}");

    double result = Math.Pow(A, B);

    Console.WriteLine($"А в степени B равно: {result}");

}

zadacha25();

