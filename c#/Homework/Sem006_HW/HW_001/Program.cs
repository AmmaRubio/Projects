// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
String y = " ";
int count = 0;
int countPositive = 0;
while (!y.Equals("00"))
{
    Console.WriteLine($"You have input {count} numbers, {countPositive} of them are greater than 0");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine(" To quit enter 00");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Input a number:");
    y = Console.ReadLine(); 
    if(y.Equals("00")) break; 
    int input = Convert.ToInt32(y); 
    if (input>0) countPositive++; 
    count++; 
}

