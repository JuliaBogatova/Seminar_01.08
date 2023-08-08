// Напишите программу, которая:
// 1. принимает на вход три числа
// 2. и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = numberOne;

if (numberTwo > max)
{
    Console.WriteLine($"Самое большое число - {numberTwo}");
}
else if (numberThree > max)
{
    Console.WriteLine($"Самое большое число - {numberThree}");
}
else
{
    Console.WriteLine($"Самое большое число - {numberOne}");
}
