﻿// Напишите программу, которая:
// 1. На вход принимает два числа 
// 2. и проверяет, является ли первое число квадратом второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne / numberTwo == numberTwo)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}