/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int sqr(int a)
{
    int result = a * a;
    return result;
}

void hw003(int x)
{
    Console.Write(x + " -> ");
    for (int i = 1; i <= x; i++)
    {
        Console.Write(sqr(i) + ", "); 
    }
}


Console.WriteLine("input an integer (not too big please)");
int input = Convert.ToInt32(Console.ReadLine()); 
hw003(input); 
