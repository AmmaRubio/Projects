// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Hello, World!");
int[] array2Digits = new int[4];

int[] fillArray2Digits(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) { Console.Write(array[i] + " "); }
}
int sumOddPosition(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) // использовал == 0 так как первая позиция 0
        {
            result = result + array[i];
        }
    }
    return result;
}


array2Digits = fillArray2Digits(array2Digits);
int output = sumOddPosition(array2Digits);
printArray(array2Digits);
Console.Write("-> " + output);


