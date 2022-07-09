/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/
double[,] generateDoubleMatrix(int rowNumber, int colNumber, double numberRange)
{
    double[,] matrix = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble()*(numberRange)*(new Random().Next(0,2)*2 -1),2);
        }
    }
    return matrix;
}
void printDoubleMatrix(double[,] matrix)
{
    Console.WriteLine($"m = {matrix.GetLength(0)}, n = {matrix.GetLength(1)}"); 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t"); 
        }
        Console.WriteLine();
        Console.WriteLine();  
    }
}

printDoubleMatrix(generateDoubleMatrix(3,4,10)); 