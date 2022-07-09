int[] generateIntArray(int length, int numberRange)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-numberRange, numberRange + 1);
    }
    return array;
}
void printIntArray(int[] array, string name = "array")
{
    Console.WriteLine($"-------------{name}-------------");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
int[] sortArray(int[] array)
{
    Array.Sort(array);
    return array;
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


// 2 dimensional arrays 
int[,] generateIntMatrix(int rowNumber, int colNumber, int numberRange = 10)
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
        int i = index / matrix.GetLength(0); // finding row
        int j = index % matrix.GetLength(1); // finding column
        Console.WriteLine($"{index} -> {matrix[i, j]}");
    }
}
void printColumnMeanIntMatrix(int[,] matrix)//prints out mean of every column
{
    Console.WriteLine();
    Console.Write("Mean of every column is: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        double mean = Math.Round(sum / (matrix.GetLength(0)), 2);
        Console.Write(mean + "; ");
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
int[] getRowSumsMatrixInt(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i, j];
        }
    }
    return result; 
}
// test
int[,] matrix = generateIntMatrix(3, 4, 10);
printIntMatrix(matrix);
printIntArray(getRowFromMatrixInt(matrix, 2));