/**=*===============================*=*
  *|* < $ > * My HomeWork 6 * < $ > *|* 
  *=*===============================*=**/


//Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
//Например:
/*m = 3, n = 4.

 0,5 7 -2 -0,2
 1 -3,3 8 -9,9
 8 7,8 -7,1 9*/
/*
double[,] Generetion2DArrOutdoub(int rows, int cols)
{
    double[,] arry = new double[rows, cols];
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            double num = new Random().NextDouble();

            num = Math.Round(num * 20 - 10, 1);
            arry[row, col] = num;
        }
    }
    return arry;
}
void Show2D_Array(double[,] arry)
{ Console.WriteLine ("\nArray Double 2D\n");
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            Console.Write($"{arry[row, col]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine ("\nEnd.....");
}

Console.WriteLine("Задаст двумерный массив вещественных чисел, с вашей помощью.\n" + "Необходимо задать количество строк m и столбцов n.\n"+
"Например m = 3 и n = 4\n");
Console.Write("Введите количество строк m:");
int row_m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n:");
int col_n = Convert.ToInt32(Console.ReadLine());
Show2D_Array(Generetion2DArrOutdoub(row_m, col_n));
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
/*
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
/*
int[,] Generetion2DArrOutInt(int n_row, int d_col)
{
    int[,] arry = new int[n_row, d_col];
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            int num = new Random().Next(1, 20);
            arry[row, col] = num;
        }
    }
    return arry;
}
void Show2Darray(int[,] arry)
{ Console.WriteLine ("\n\tInteger array 2D\n");
    for (int row1 = 0; row1 < arry.GetLength(0); row1++)
    {
        for (int col2 = 0; col2 < arry.GetLength(1); col2++)
        {
            Console.Write($"{arry[row1, col2]} ");
        }
        Console.WriteLine();
    }
   Console.WriteLine ();
}
void FindPosAndOut(int[,] arry, int num)
{

    if (num <= arry.Length && num > 0)
    {
        int rowf = (num - 1) / arry.GetLength(1);
        int colall = arry.GetLength(1);
        int colf = num - rowf * colall - 1;
        Console.WriteLine($"\npos: row- {rowf+1} column: {colf+1} result num: {arry[rowf, colf]}");
    }else{
        Console.WriteLine("\nThere is no position {0} in the array consisting of {1} elements", num, arry.Length);
    }
    
    
}

Console.WriteLine("Let's set the number of rows and columns of the new array, generate an integer array\n");
Console.Write("\nEnter the number of array rows greater than 0:");
int row_n_ = Convert.ToInt32(Console.ReadLine());
Console.Write("\nEnter the number of array columns greater than 0:");
int col_n_ = Convert.ToInt32(Console.ReadLine());

int[,] arry = Generetion2DArrOutInt(row_n_, col_n_);
int allposarray = arry.Length;
Show2Darray(arry);
Console.Write("\nAll position array = {0}\n" + "Enter an integer number of the array position from 1 or {0}:", allposarray);
int numin = Convert.ToInt32(Console.ReadLine());
FindPosAndOut(arry, numin);
*/

//Second Option реализации данной задачи через проебразование в из двумерного массива в одномерный.
//=================================================
/*
int[,] Generetion2DArrOutInt(int n_row, int d_col)
{
    int[,] arry = new int[n_row, d_col];
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            int num = new Random().Next(1, 20);
            arry[row, col] = num;
        }
    }
    return arry;
}
void Show2Darray(int[,] arry)
{ Console.WriteLine ("\n\tInteger array 2D\n");
    for (int row1 = 0; row1 < arry.GetLength(0); row1++)
    {
        for (int col2 = 0; col2 < arry.GetLength(1); col2++)
        {
            Console.Write($"{arry[row1, col2]} ");
        }
        Console.WriteLine();
    }
   Console.WriteLine ();
}
//The second option for searching for a position is generation into a one-dimensional array
int[] Converting_in_OneD_from2D_array(int[,] array)
{
   int sizeall= array.Length;
   int sOne = 0;
   int[] arrayOne = new int[sizeall];
   for (int i0 = 0; i0 < array.GetLength(0); i0++)
   {
       for (int i1 = 0; i1 < array.GetLength(1); i1++)
       {
         arrayOne[sOne] = array[i0, i1];
         sOne++;
       }
   }
return arrayOne;
}
void ShowOne_D_array_tothe_Console(int[] arrys)
{  Console.WriteLine("\tInteger array 1D\n");
   for (int jcount = 0; jcount != arrys.Length; jcount++)
    {
        if (jcount == 0) Console.Write("[");
        if (jcount < arrys.Length - 1) Console.Write($"{arrys[jcount]}, ");
        if (jcount == arrys.Length - 1) Console.Write($"{arrys[jcount]}]");
    }   
   Console.WriteLine();
}
void FindPosition_by_number(int[] arrayOne, int F_num)
{
    if (F_num <= arrayOne.Length && F_num > 0)
    Console.WriteLine($"\nPosition array {F_num} this value of the array element is {arrayOne[F_num-1]}");

    if (F_num <=0 || F_num > arrayOne.Length )
    Console.WriteLine("\nThere is no position {0} in the array consisting of {1} elements", F_num, arrayOne.Length);



}
Console.WriteLine("Let's set the number of rows and columns of the new array, generate 2D an integer array\n");
Console.Write("\nEnter the number of array rows greater than 0:");
int row_n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\nEnter the number of array columns greater than 0:");
int col_n1 = Convert.ToInt32(Console.ReadLine());

int[,] array_2D = Generetion2DArrOutInt(row_n1, col_n1);
Show2Darray(array_2D);
int[] array_1D = Converting_in_OneD_from2D_array(array_2D);
ShowOne_D_array_tothe_Console(array_1D);
int allpos1D = array_1D.Length;
Console.Write("\nAll position array = {0}\n" + "Enter an integer number of the array position from 1 or {0}:", allpos1D);
int numin = Convert.ToInt32(Console.ReadLine());
FindPosition_by_number(F_num: numin, arrayOne: array_1D);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

/*
int[,] Generetion2DArrOutInt(int n_row, int d_col, int min_num, int max_num)
{
    int[,] arry = new int[n_row, d_col];
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            int num = new Random().Next(min_num, max_num);
            arry[row, col] = num;
        }
    }
    return arry;
}
void Show2DarrayInt(int[,] arry)
{ Console.WriteLine ("\n\tInteger array 2D\n");
    for (int row1 = 0; row1 < arry.GetLength(0); row1++)
    {
        for (int col2 = 0; col2 < arry.GetLength(1); col2++)
        {
            Console.Write($"{arry[row1, col2]} ");
        }
        Console.WriteLine();
    }
   Console.WriteLine ();
}

void Arithmetic_Mean_By_Col(int[,] arrays)
{
    double sum = 0;
    for (int i = 0; i < arrays.GetLength(1); i++)
    {
        for (int j = 0; j < arrays.GetLength(0); j++)
        {
            sum += arrays[j, i];
        }
        Console.Write(Math.Round(sum / arrays.GetLength(0), 1, MidpointRounding.AwayFromZero) + "; ");
        sum = 0;
    }
}

Console.WriteLine("Зададим количество строк и столбцов нового массива, сгенерируем целочисленный массив\n");
Console.Write("\nВведите число строк массива больше 0:");
int row_n_ = Convert.ToInt32(Console.ReadLine());
Console.Write("\nВведите число столбцов массива больше 0:");
int col_n_ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nЗададим генерацию чисел от 1 до 10\n");
Console.Write("\nВведите число от = 1:");
int min_n = Convert.ToInt32(Console.ReadLine());
Console.Write("\nВведите число до = 10:");
int max_n = Convert.ToInt32(Console.ReadLine());

int[,] Gen_arr = Generetion2DArrOutInt(d_col: col_n_, n_row:row_n_, max_num:max_n, min_num: min_n);
Show2DarrayInt(Gen_arr);

//Выведем среднею арифметическую по столбцам массива

Arithmetic_Mean_By_Col(Gen_arr);
*/