/*: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.*/
Console.WriteLine("Input 3 numbers (with ENTER): ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine()); 

if (num1 >= num2){ 
    if(num1 >= num3){
        Console.WriteLine("max = "+ num1);
    }
    else{
        Console.WriteLine("max = "+ num3); 
    }
}
else if(num2 >= num3){
    Console.WriteLine("max = "+ num2); 
}
else{
    Console.WriteLine("max = "+ num3); 
}
//Наверно, лучше было бы делать через int max...