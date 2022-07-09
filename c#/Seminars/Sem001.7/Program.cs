/*4. Напишите программу, которая на вход принимает одно число
(N), а на выходе показывает все целые числа в промежутке от -N
до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/

Console.WriteLine("Input a number");
int N = Convert.ToInt32(Console.ReadLine()); 
int Nnew = (-1)* N; 
if(Nnew <= N){
    while(Nnew <= N)
    {
        Console.Write(Nnew+ " "); 
        Nnew++; 
    }
}
else{
    while(N <= Nnew){
        Console.Write(N+" ");
        N++; 
    }
}
