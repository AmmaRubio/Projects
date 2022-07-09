/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.WriteLine("input number, and you will get it`s 3rd digit: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
string  numS = number.ToString(); 
if(numS.Length < 3){
Console.WriteLine("there is less than 3 digits in the number"); 
}else{
    Console.WriteLine($" Third digit is: {numS[2]}"); 
}

