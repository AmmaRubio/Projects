/*  Задайте значения M и N. Напишите программу, которая
 найдёт сумму натуральных элементов в промежутке от M до N*/
Console.WriteLine("Input Lower Bound");
int LB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Upper Bound");
int UB = Convert.ToInt32(Console.ReadLine());

int callSumBetween(int lowerBound, int upperBound){
    return sumBetween(lowerBound,upperBound,0); 
}
int sumBetween(int lowerBound, int upperBound, int result)
{
    if (lowerBound > upperBound)
    {
        return result;
    }
    else
    {
         result = result + lowerBound; 
        return sumBetween(lowerBound+1,upperBound,result); 
    }
}

Console.WriteLine($"{LB}, {UB} -> {callSumBetween(LB,UB)}"); 
