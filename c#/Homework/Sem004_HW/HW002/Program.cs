// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write integer (more than one digit!)");
int input = Convert.ToInt32(Console.ReadLine());

int sumOfDigits(int num)
{
    int result = 0;
   while(num > 0){
       int res = num % 10; 
       num = num/10; 
       result = result + res; 
   }
   return result; 
}
int output = sumOfDigits(input); 
Console.WriteLine($"{input} -> {output}"); 
