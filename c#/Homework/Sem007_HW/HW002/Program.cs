/*апишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.*/
Console.WriteLine("input an index to find integer in 3x4 matrix"); 
int input = Convert.ToInt32(Console.ReadLine());

void getElementByIndexInt(int[,] matrix, int index)
{
    if (index >= matrix.GetLength(0) * matrix.GetLength(1))
    {
        Console.WriteLine("Error: index is out of matrix range:");
    }
    else
    {
        int i = index/matrix.GetLength(0); // finding row
        int j = index%matrix.GetLength(1); // finding column
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"{index} -> {matrix[i,j]}"); 
    }
}
void printIntMatrix(int[,] matrix)
{
    Console.WriteLine("Matrix:"); 
    Console.WriteLine("---------------------------------"); 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
int[,] generateIntMatrix(int rowNumber, int colNumber, int numberRange)
{
    int[,] matrix = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            matrix[i, j] = new Random().Next(-numberRange, numberRange + 1);
        }
    }
    return matrix;
}

int[,] matrix = generateIntMatrix(3,4,10); 
printIntMatrix(matrix); 
getElementByIndexInt(matrix, input);