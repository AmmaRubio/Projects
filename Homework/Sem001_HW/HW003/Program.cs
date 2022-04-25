/*Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).*/

Console.WriteLine("input an integer");
int num = Convert.ToInt32(Console.ReadLine()); 
if (num%2 == 0){
    Console.WriteLine("yes");
}
else{
    Console.WriteLine("no"); 
}