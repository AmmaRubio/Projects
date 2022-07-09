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

void printColumnMeanIntMatrix(int[,] matrix)
{
    Console.WriteLine();
    Console.Write("Mean of every column is: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i,j]; 
        }
        double mean = Math.Round(sum/(matrix.GetLength(0)), 2); 
        Console.Write(mean + "; "); 
    }
}

int[,] matrix = generateIntMatrix(3,4,10); 
printIntMatrix(matrix); 
printColumnMeanIntMatrix(matrix); 