// See https://aka.ms/new-console-template for more information

int[] array3Digits = new int[4];

int[] fillArray3Digits(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int numberOfEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) { Console.Write(array[i] + " ");}
}

array3Digits = fillArray3Digits(array3Digits); 
int output = numberOfEven(array3Digits); 
printArray(array3Digits); 
Console.Write("-> " + output); 