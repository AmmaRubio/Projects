/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

Console.WriteLine("input any integer"); 
int input = Convert.ToInt32(Console.ReadLine());

Boolean ispolindrom(int input)
{
    string array = input.ToString();
    Boolean result = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (!array[i].Equals(array[array.Length - i - 1]))
        {
            result = false;
        }
    }
    return result; 
}
string booleanToYesorNo(Boolean x){
    String result = "no"; 
    if(x == true) result = "yes"; 
    return result; 
}

String output = booleanToYesorNo(ispolindrom(input)); 
Console.WriteLine($"{input} -> {output}"); 

