/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

String[] weekDays = { "no", "no", "no", "no", "no", "yes", "yes" };
Console.WriteLine("input number from 1 to 7");
int input = Convert.ToInt32(Console.ReadLine());
if (input >= 1 & input <= 7)
{
    Console.WriteLine($"Is this day a weekend? -- {weekDays[(input - 1)]}");
}
else
{
    Console.WriteLine("Error: Wrong Number");
}
