int[] random8Array()
{
    int[] result = new int[8];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 10);
    }
    return result; 
}
void printArray(int[] array)
{
for(int i = 0; i < array.Length; i++){
    Console.Write(" " + array[i]); 
}
}
printArray(random8Array()); 
