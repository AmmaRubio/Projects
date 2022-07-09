void randomFillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 10);
    }
}
void printArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.WriteLine(col[i]);
    }
}
int indexOf(int[] col, int number)
{
    int result = -1;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] == number)
        {
            Console.WriteLine(i);
            result = i;
            break;
        }
    }
    return result;
}

int[] array= new int[10]; 
randomFillArray(array); 
printArray(array); 
Console.WriteLine(); 
int index = indexOf(array, 2); 

