/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.*/
Console.WriteLine("Input Lower Bound");
int LB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Upper Bound");
int UB = Convert.ToInt32(Console.ReadLine());

void callNumbersInInterval(int lowerBound, int upperBound)
{
    if (lowerBound > upperBound)
    {
        int backup = lowerBound;
        upperBound = lowerBound;
        lowerBound = upperBound;
    }
    NumbersInInterval(lowerBound, upperBound);
}

void NumbersInInterval(int lowerBound, int upperBound)
{
    if (lowerBound == upperBound)
    {
        Console.Write(upperBound + ", "); 
    }
    else
    {
        Console.Write(upperBound + ", ");
        NumbersInInterval(lowerBound, upperBound - 1);
    }
}

callNumbersInInterval(LB, UB); 