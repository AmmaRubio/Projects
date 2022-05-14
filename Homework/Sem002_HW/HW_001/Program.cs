/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int number = new Random().Next(100,1000); 
Console.WriteLine($"the number is: {number}"); 
number= number/10; 
number = number%10; 
Console.WriteLine($"number on the second position is : {number}"); 