﻿/*Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.*/
Console.WriteLine("Input an integer N");
int num = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(""); 
for(int i = 1; i <= num; i++){
    if (i%2 == 0) Console.WriteLine(i); 
}