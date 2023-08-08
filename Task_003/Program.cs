// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// 1. Задать номер
// 2. Выдать день недели(или сообщение об ошибке)

// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели от 1 до 7: ");
string? day = Console.ReadLine();

if (day == "1")
{
    Console.WriteLine("Понедельник");
}
else if (day == "2")
{
    Console.WriteLine("Вторник");
}
else if (day == "3")
{
    Console.WriteLine("Среда");
}
else if (day == "4")
{
    Console.WriteLine("Четверг");
}
else if (day == "5")
{
    Console.WriteLine("Пятница");
}
else if (day == "6")
{
    Console.WriteLine("Суббота");
}
else if (day == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Ошибка! Некорректный ввод. Введите номер от 1 до 7.");
}