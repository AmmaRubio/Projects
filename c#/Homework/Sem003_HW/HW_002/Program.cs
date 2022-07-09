/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double euqlidieanDistance3D(int a, int b, int c)
{
    double result = 0;
    result = Math.Sqrt((a * a) + (b * b) +(c * c));
    return result; 
}

Console.WriteLine("input X coordinate "); 
int xCoor = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("input Y coordinate "); 
int yCoor = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("input Z coordinate "); 
int zCoor = Convert.ToInt32(Console.ReadLine()); 

double distance = euqlidieanDistance3D(xCoor,yCoor,zCoor);

Console.WriteLine($"distance between points is: {distance}");


