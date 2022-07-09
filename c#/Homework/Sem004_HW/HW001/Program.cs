/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/
Console.WriteLine("input number:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("another number:");
int numB = Convert.ToInt32(Console.ReadLine());

int powerAB(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
int output = powerAB(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {output}");