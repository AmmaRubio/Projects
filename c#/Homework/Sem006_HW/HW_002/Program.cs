// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("please inputs values for b1, k1, b2 and k2 in form of y = k1 * x + b1, y = k2 * x + b2, to find interception point");
Console.WriteLine("---------------------------------");
Console.WriteLine("b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("---------------------------------");
Console.WriteLine("k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("---------------------------------");
Console.WriteLine("b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("---------------------------------");
Console.WriteLine("k2");
int k2 = Convert.ToInt32(Console.ReadLine());

int[] findIntercept(int b1, int b2, int k1, int k2)
{
    int [] result = new int[2]; 
    result[0] = (b1 - b2)/(k2-k1);
    result[1] = k1*result[0] + b1; 
    return result;
}
int[] intercept = new int[2]; 
intercept = findIntercept(b1,b2,k1,k2);
Console.WriteLine($"intercept: ({intercept[0]};{intercept[1]})"); 