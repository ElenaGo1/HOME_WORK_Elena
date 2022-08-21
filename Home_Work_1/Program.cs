
//Задача 2: Напишмите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее. 
//Например: а = 5 b = 7 -> max = 7, a = 2 b = 10 -> max = 10, a = -9 b = -3 -> max = -3
/*
Console.Write("Input first integer number:");
int num_A = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input second integer number:");
int num_B = Convert.ToInt32(Console.ReadLine()); 

if (num_A > num_B)
{
    Console.Write($"The largest number :{num_A} and the smallest number {num_B}");
}
else
{
    Console.Write($"The largest number :{num_B} and the smallest number {num_A}");
}
*/
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
//Варинат 1.
Console.Write("Input first integer number:");
int num_A = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input second integer number:");
int num_B = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input third integer number:");
int num_С = Convert.ToInt32(Console.ReadLine()); 
int max = num_A;
if (num_B > max) max = num_B;
if (num_С > max) max = num_С;

Console.Write($"The maximum number of {num_A}, {num_B}, {num_С} is equal to {max}");
*/
//Вариант 2
/*
Console.WriteLine("Enter three numbers");
Console.Write("Input first integer number:");
int num_A = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input second integer number:");
int num_B = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input third integer number:");
int num_С = Convert.ToInt32(Console.ReadLine()); 
int index = 0;
int[] numbers = new int[] { num_A, num_B, num_С };
int max = numbers[index];
while  (index < numbers.Length)
{   
    if (numbers[index] > max)
    {
        max = numbers[index];
    }
    index++;
    }
    string str = string.Join(" ", numbers);
Console.Write($"The maximum number of [{str}] is equal to {max}");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число чётным (делится оно на два без остатка)
/*
Console.WriteLine("Let's check if the number is even, let's go");
Console.Write("Input integer number:");
int num_A = Convert.ToInt32(Console.ReadLine()); 
if ((num_A % 2) == 0)
{
    Console.Write($"The number {num_A} is even Yes");
} 
else
{
    Console.Write($"The number {num_A} is even No");  
}
*/
//Задача 8: Напишите программу, которая принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Output all even numbers from 1 to (N)");
Console.Write("Input integer number (N):");
int num_A = Convert.ToInt32(Console.ReadLine());
int num_n = 0;
Console.Write($"All even numbers from 1 to {num_A}: ");
while (num_n <= num_A)
{
    if (num_n > 1 & num_n % 2 == 0)
    {
        Console.Write(num_n + ", ");
    }
    num_n++;
}
*/