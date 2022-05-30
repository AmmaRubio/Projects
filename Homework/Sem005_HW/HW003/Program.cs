int[] array = new int[6];

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
int[] getPairProduct(int[] array)
{
    int length = array.Length / 2; // 2
    if (length % 2 == 1) 
    length = length + 1; // 3
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        if(array.Length % 2 == 1 && i == length -1)
        result[i] = array[array.Length/2];  
        else result[i] = array[i]*array[array.Length-1-i];
    }
    return result; 
}


array = fillArray2Digits(array);

printArray(array);
Console.Write("-> ");
printArray(getPairProduct(array)); 
