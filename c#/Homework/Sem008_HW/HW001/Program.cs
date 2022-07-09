/*Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
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
int[] getRowFromMatrixInt(int[,] matrix, int rowIndex)
{
    int[] result = new int[matrix.GetLength(1)];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = matrix[rowIndex, i];
    }
    return result;
}
int[] sortArray(int[] array)
{
    Array.Sort(array);
    return array;
}
int[,] sortMatrixRowsInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] sortedRow = sortArray(getRowFromMatrixInt(matrix, i));
        for (int j = 0; j < sortedRow.Length; j++)
        {
            matrix[i, j] = sortedRow[j];
        }
    }
    return matrix;
}

// test
int[,] matrix = generateIntMatrix(3, 4, 10);
printIntMatrix(matrix);
matrix = sortMatrixRowsInt(matrix);
printIntMatrix(matrix);
