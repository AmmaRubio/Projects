/*Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.*/

int number = new Random().Next(100,1000); 
int dig1 = number/100; 
int dig3 = number % 10; 
Console.WriteLine($"{number} -> {dig1}{dig3}"); 

