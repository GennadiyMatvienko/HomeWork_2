Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Console.Write("Введите трёхзначное число: ");
int number_1 = int.Parse(Console.ReadLine());
int max = number_1 % 100;
int number_2 = max / 10;

Console.Write($" второе в трехзначном числе: {number_2}");

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Console.Write("Введите трёхзначное число: ");
int number_1 = int.Parse(Console.ReadLine());
while (number_1 > 999)
{
    number_1 = number_1 / 10;
}
if (number_1 <= 999 && number_1 > 99)
{
    number_1 = number_1 % 10;
    Console.Write($"третья цифра трехзначного числа: {number_1}");
}
else if (number_1 < 99)
{
    Console.Write("нет");
}

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

Console.Write("Введите номер дня недели от 1 до 7: ");
int day = int.Parse(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Нет");
}
if (day == 2)
{
    Console.WriteLine("Нет");
}
if (day == 3)
{
    Console.WriteLine("нет");
}
if (day == 4)
{
    Console.WriteLine("Нет");
}
if (day == 5)
{
    Console.WriteLine("Нет");
}
if (day == 6)
{
    Console.WriteLine("Да, выходной");
}
if (day == 7)
{
    Console.WriteLine("Да,выходной");
}
if (day < 1 || day > 7)
{
    Console.WriteLine("Номер недели введён неверно");
}
