/**=*===============================*=*
  *|*       * * * * * * * * *       *|*
  *|* * * * * My HomeWork 5 * * * * *|* 
  *|*       * * * * * * * * *       *|*
  *=*===============================*=**/

// Мое выполненное задание, прошу запустить весь код целиком. Спасибо!!!

Console.Clear();
Console.WriteLine("\t\t\t*=*===============================*=*\n"+
              "\t\t\t*|*       * * * * * * * * *       *|*\n"+
              "\t\t\t*|* * * * * My HomeWork 5 * * * * *|*\n"+ 
              "\t\t\t*|*       * * * * * * * * *       *|*\n"+
              "\t\t\t*=*===============================*=*\n");
              Console.Write("");

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество четных чисел в массиве.
//Например: [345, 897, 568, 234] --> 2

int[] GeneretionArr(int sizen, int minVal, int maxVal)
{
    int[] arr = new int[sizen];
    int sizeL = arr.Length;
    for (int i = 0; i < sizeL; i++)
    {
        int num = new Random().Next(minVal, maxVal);
        arr[i] = num;

    }
    return arr;
}

void Print(int[] arrys)
{
    int sizeL = arrys.Length;
    Console.Write("\n[");
    for (int j = 0; j < sizeL; j++)
    {
        Console.Write($"{arrys[j]}, ");
        
    }
   Console.Write($"\b\b]");
}

int QuantityEvenNum(int[] arry)
{
    int size = arry.Length;
    int quantity = 0;
    for (int i = 0; i < size; i++)
    {
        if ((arry[i] % 2) == 0)
        {
            quantity++;
        }

    }
    return quantity;
}
int[] arrg = GeneretionArr(9, 100, 1000);
Console.WriteLine("Задача 34:========================================");
Console.WriteLine("Задаст массив, заполненный случайными положительными трёхзначными числами.\n"+ 
"Покажет количество четных чисел в массиве.");
Thread.Sleep(3000);
Print(arrg);
Console.Write($" количество четных цифр = {QuantityEvenNum(arrg)}\n");
Thread.Sleep(5000);



//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечетных позициях.
//Например: [3, 7, 23, 12] --> 19, [-4, -6, 89, 6] --> 0
int SumElementsOddpos(int[] arry)
{
    int size = arry.Length;
    // int quantity = 0;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if ((i % 2) == 1)
        {
            sum += arry[i];
        }

    }
    return sum;
}
int[] Arryrandom = GeneretionArr(6, -50, 100);
Console.WriteLine();
Console.WriteLine("Задача 36:========================================");
Console.WriteLine("Задаст одномерный массив, заполненный случайными числами.\n"+ 
"Найдёт сумму элементов, стоящих на нечетных позициях.");
Thread.Sleep(3000);
Print(Arryrandom);
Console.Write($"  Сумма элементов на нечётных позициях = {SumElementsOddpos(Arryrandom)}\n");
Thread.Sleep(3000);


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//Например: [3, 7, 22, 2, 78] --> 76

double[] GeneretionArrDouble(int sizen)
{
    double[] arr = new double[sizen];
    int sizeL = arr.Length;
    double num = 0;
    Random rtd = new Random();
    for (int i = 0; i < sizeL; i++)
    {
        for (int j = 0; j < 109; j++)
        {
            num = rtd.NextDouble();
        }
        num = Math.Floor(num * 50);
       arr[i] = num;

    }
    return arr;
}
double Diff_Max_Min(double[] arry, out double maximum, out double minimum)
{
    int size = arry.Length;
    // int quantity = 0;
    double diff = 0;
    maximum = arry[0];
    minimum = arry[0];

    for (int i = 0; i < size; i++)
    {
        if (arry[i] > maximum)
        {
            maximum = arry[i];
        }
        if (arry[i] < minimum)
        {
            minimum = arry[i];
        }
    }
    diff = maximum - minimum;
    return diff;
}
void PrintDouble(double[] arrys)
{
    int sizeL = arrys.Length;
    Console.Write("\n[");
    for (int j = 0; j < sizeL; j++)
    {
        Console.Write($"{arrys[j]}, ");
        
    }
   Console.Write($"\b\b]");
}
double[] arr = GeneretionArrDouble(8);
Console.WriteLine();
Console.WriteLine("Задача 38:========================================");
Console.WriteLine("Задаст массив вещественных чисел.\n"+ 
"Найдёт разницу между максимальным и минимальным элементом массива.");
Thread.Sleep(3000);
PrintDouble(arr);
double max;
double min;
double diff = Diff_Max_Min(arr, out max, out min);
Console.WriteLine("  разница между {0} - {1} =  {2}", max, min, diff);
Thread.Sleep(3000);
Console.WriteLine();
Console.WriteLine("\tThank you for your time");
Thread.Sleep(2000);
Console.WriteLine("End......");
