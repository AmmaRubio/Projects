/*Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
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
void printIntMatrix(int[,] matrix, string name = "matrix")
{
    Console.WriteLine($"-------------{name}-------------");
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
int[] getRowFromMatrixInt(int[,] matrix, int rowIndex)
{
    int[] result = new int[matrix.GetLength(1)];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = matrix[rowIndex, i];
    }
    return result;
}
void printIntArray(int[] array, string name = "array")
{
    Console.WriteLine($"-------------{name}-------------");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int[] getRowSumsMatrixInt(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i,j]; 
        }
    }
    return result; 
}
int getMinIndexArrayInt(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[min])
        {
            min = i;
        }
    }
    return min; 
}

int[] getMinSumRowMatrixInt(int[,] matrix){
int[] result = getRowFromMatrixInt(matrix, getMinIndexArrayInt(getRowSumsMatrixInt(matrix))); 
return result; 
}

int[,] matrix = generateIntMatrix(4,5,10); 
printIntMatrix(matrix); 
int[] minRow = getMinSumRowMatrixInt(matrix); 

printIntArray(minRow, "row with min sum of elements"); 



