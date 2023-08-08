// Напишите программу, которая:
// 1. принимает на вход трехзначное число 
// 2. и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) num *= -1;

if (num >= 100 && num <= 999)
{
    int lastDigit = num % 10;
    Console.WriteLine($"Последняя цифра: {lastDigit}");
}
else
{
    Console.WriteLine("Некорректный ввод.");
}