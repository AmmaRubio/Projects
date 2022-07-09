/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/
int[] array = new int[5];

int[] fillArray2Digits(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) { Console.Write(array[i] + " "); }
}

int getMax(int[] array)
{
    int result = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > result) result = array[i]; 
    }
    return result;
}
int getMin(int[] array)
{
    int result = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < result) result = array[i]; 
    }
    return result;
}
array = fillArray2Digits(array); 
int output = getMax(array) - getMin(array); 
printArray(array); 
Console.Write(" -> " + output); 
