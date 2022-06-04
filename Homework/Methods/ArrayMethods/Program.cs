int[] generateIntArray(int length, int numberRange)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-numberRange, numberRange + 1);
    }
    return array;
}
void printIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
// 2 dimensional arrays 
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
double[,] generateDoubleMatrix(int rowNumber, int colNumber, double numberRange)
{
    double[,] matrix = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (numberRange) * (new Random().Next(0, 2) * 2 - 1), 2);
        }
    }
    return matrix;
}
void printDoubleMatrix(double[,] matrix)
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

void getElementByIndexInt(int[,] matrix, int index)
{
    if (index >= matrix.GetLength(0) * matrix.GetLength(1))
    {
        Console.WriteLine("Error: index is out of matrix range");
    }
    else
    {
        int i = index/matrix.GetLength(0); // finding row
        int j = index%matrix.GetLength(1); // finding column
        Console.WriteLine($"{index} -> {matrix[i,j]}"); 
    }
}

// test
//int[] array = generateIntArray(5, 10);
//printIntArray(array);
//printIntMatrix(generateIntMatrix(4,5,10.1)); 
//printDoubleMatrix(generateDoubleMatrix(4, 5, 10.1));
int[,] matrix = generateIntMatrix(3,4,10); 
printIntMatrix(matrix); 
getElementByIndexInt(matrix, 8);