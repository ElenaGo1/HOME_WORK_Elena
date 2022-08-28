// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Например: 14212 --> Нет, 12821 --> Да, 23432 --> Да
/*
void PalindromeCheck(int num)
{
    int i = num;
    int ReverseNum = 0;
    int Remainder = 0;

    while (i > 0)
    {
        Remainder = i % 10;
        ReverseNum = (ReverseNum * 10) + Remainder;
        i = (i / 10);
    }

    if (ReverseNum == num)
    {
        Console.WriteLine("You have entered {1}.\nReverse number {0}.The Number {0} is a palindrome", ReverseNum, num);
    }
    else
    {
        Console.WriteLine("You have entered {1}.\nReverse number {0}. The Number is not a palidrome", ReverseNum, num);
    }
}

 Console.WriteLine("Checking whether a number is a palindrome, to do this, enter a five-digit number");
 Console.Write("Input a five-digit integer:");
 int inputNumber = Convert.ToInt32(Console.ReadLine());
 PalindromeCheck(inputNumber);
*/

//Вариант 2. Вариант через bool
/*
int ReverseNumbers(int num)
{
    int i = num;
    int ReverseNum = 0;
    int Remainder = 0;

    while (i > 0)
    {
        Remainder = i % 10;
        ReverseNum = (ReverseNum * 10) + Remainder;
        i = (i / 10);
    }
    return ReverseNum;
}
bool PalindromeCheck(int num, int ReverseNum)
{
    if (ReverseNum == num)
    {
        return true;
    }
    else
    {
        return false;
    }
}

 Console.WriteLine("Checking whether a number is a palindrome, to do this, enter a five-digit number");
 Console.Write("Input a five-digit integer:");
 int inputNumber = Convert.ToInt32(Console.ReadLine());
 //PalindromeCheck(inputNumber);
 int ReversNumberOut = ReverseNumbers(inputNumber);
 if (PalindromeCheck(inputNumber, ReversNumberOut))
{
Console.WriteLine("You have entered {1}.\nReverse number {0}.The Number {0} is a palindrome", ReversNumberOut, inputNumber);
}else{
Console.WriteLine("You have entered {1}.\nReverse number {0}. The Number is not a palidrome", ReversNumberOut, inputNumber);
}
*/

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например A (3,6,8) и B (2,1,-7) --> 15.84 или A (7,-5,0) и B (1,-1,9) --> 11.53
/*
double segmentLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{

    double seglenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    seglenght = Math.Round(seglenght, 2);
    return seglenght;
}

Console.WriteLine("Enter the coordinates of points A (x1, y1, z1) and B(x2, y2, z2)");
Console.WriteLine("Enter the coordinates of point A (x1, y1, z1)");
Console.Write("Enter the coordinate x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinate y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinate z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinates of point B (x2, y2, z2)");
Console.Write("Enter the coordinate x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinate y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinate z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Distance between two coordinate points A ({x1}, {y1}, {z1}) и B ({x2}, {y2}, {z2}) = " + segmentLenght(x1, y1, z1, x2, y2, z2));
*/


//Задача 23: Напишите программу, которая принимает на вход число N и выдает Таблицу кубов чисел от 1 до N.
/*
void CubesOfNumbers(int Num)
{ int i = 1;
  while (i <= Num)
  {
    if (i == 1)
    {
    Console.Write($"{Math.Pow(i,3)}");
    }else{
    Console.Write($", {Math.Pow(i,3)}");
    }
    i++;
  }

}
Console.WriteLine("Let's cube the numbers for the segment N from 1 to N and output them");
Console.Write("Enter an integer from 1 to N for example 5:");
int input = Convert.ToInt32(Console.ReadLine());
CubesOfNumbers(input);
*/