/*Задача 58: Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.*/
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

int[,] matrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    // condition check
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Error: Wrong dimensions of Matrices");
        return result; 
    }
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                result[i, j] += matrix1[i,n] * matrix2[n,j]; 
            }
        }
    }
    return result; 
}

int[,] matrix1 = generateIntMatrix(3,2,10); 
int[,] matrix2 = generateIntMatrix(2,5,10); 
int[,] productMatrix = matrixMultiplication(matrix1, matrix2); 

printIntMatrix(matrix1, name:"First Matrix"); 
printIntMatrix(matrix2, name:"Second Matrix"); 
printIntMatrix(productMatrix, name:"Multiplication of Matrices"); 


