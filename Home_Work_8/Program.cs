/**=*===============================*=*
  *|* $ $ * * My HomeWork 8 * * $ $ *|* 
  *=*===============================*=**/

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив
1472
5923
8424
В итоге получается вот такой массив:
7421
9532
8442*/
//================-->realization
//TODO:Вариант без участия пользователя Начало задачи закоментировано/*
/*
//Метод формирования(генерации) двумерного массива
int[,] Generetion2DArrOutInt(int nRow, int dCol)
{
    int[,] arry = new int[nRow, dCol];
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            int num = new Random().Next(1, 10);
            arry[row, col] = num;
        }
    }
    return arry;
}
//Метод упорядочивания знаений каждой строки массива по убыванию
int [,] ArrangeArrayValuesInDescendingOrder(int[,] arrays)
{
int max;
for (int row = 0; row < arrays.GetLength(0); row++)
{
    for (int i = 0; i < arrays.GetLength(1) - 1; i++)
    {
        for (int j = i + 1; j < arrays.GetLength(1); j++)
        {
            max = arrays[row, i];
            if (arrays[row, j] > max)
            {
                arrays[row, i] = arrays[row, j];
                arrays[row, j] = max;
            }
        }
    }
}
return arrays;
}
//Метод вывода массива в консоль
void ShowArray2D(int[,] array)
{
    Console.WriteLine();
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
            Console.Write($"{array[a, b]} ");

     Console.WriteLine();
    }

}
int Rows = 3;
int Colums = 4;
Console.WriteLine("\nNow the program will set a two-dimensional array of 3 x 4,\n"+
"fill in the values and outputs the array before conversion\n"+
"and after the conversion, ordering the values in descending order.\n");
int[,] arrGeneration = Generetion2DArrOutInt(dCol:Colums, nRow:Rows); 
Console.WriteLine("\t\tArrays 2D");
Console.WriteLine("\nBefore conversion:");
ShowArray2D(arrGeneration);
ArrangeArrayValuesInDescendingOrder(arrGeneration);
Console.WriteLine("\nAfter conversion:");
ShowArray2D(arrGeneration);
*/
//TODO:Вариант без участия пользователя Конец задачи закоментировано 

// Вариант 2 с участием пользователя.
//TODO: Начало Варианта 2
/*
int[,] CreateRandom2dNewArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value (1): ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value (9): ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

int [,] ArrangeArrayValuesInDescendingOrder2(int[,] arrays)
{
int max;
for (int row = 0; row < arrays.GetLength(0); row++)
{
    for (int i = 0; i < arrays.GetLength(1) - 1; i++)
    {
        for (int j = i + 1; j < arrays.GetLength(1); j++)
        {
            max = arrays[row, i];
            if (arrays[row, j] > max)
            {
                arrays[row, i] = arrays[row, j];
                arrays[row, j] = max;
            }
        }
    }
}
return arrays;
}

void ShowArray2dD2(int[,] array)
{
    Console.WriteLine();
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
            Console.Write($"{array[a, b]:D2} ");

     Console.WriteLine();
    }

}

int[,] newArrayUserAdd = CreateRandom2dNewArray();
Console.WriteLine("\n\t\tArrays 2D");
Console.WriteLine("\nBefore conversion:");
ShowArray2dD2(newArrayUserAdd);
Console.WriteLine("\nAfter conversion:");
ShowArray2dD2(ArrangeArrayValuesInDescendingOrder2(newArrayUserAdd));
*/
//TODO: Конец Варианта 2

//
//Новая задча 56. ======================================================
/*
Задача 56: Задайте прямоугольный двумерный массив Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив: 
1472
5923
8424
5267
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
//Варинат без участия пользователя
//TODO: Начало задачи 56. без участия пользователя
/*

//Метод формирования(генерации) двумерного массива
int[,] GeneretionArray2DOutInt(int nRow, int dCol)
{
    int[,] arry = new int[nRow, dCol];
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            int num = new Random().Next(1, 10);
            arry[row, col] = num;
        }
    }
    return arry;
}

//Метод вывода массива в консоль
void ShowArray2DinConsole(int[,] array)
{
    Console.WriteLine();
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write($"{array[a, b]} ");
        }
        Console.WriteLine();
    }
}
//Метод найдет сроку массива с минимальной суммой элементов 
void OutputStringWithThMinSumOfTheElements(int[,] arrays2D)

{
    int sum = 0;
    int sumMin = 0;
    int rowMin = 0;
    for (int row = 0; row < arrays2D.GetLength(0); row++)
    {
        for (int col = 0; col < arrays2D.GetLength(1); col++)
        {
            sum += arrays2D[row, col];

        }
        if (row == 0)
        {
            sumMin = sum;
            rowMin = row;
        }
        if (row > 0)
        {
            if (sumMin > sum)
            {
                sumMin = sum;
                rowMin = row;
            }
            
        }
        Console.WriteLine($"Amount per Row {row+1} = {sum}  ");
        sum = 0;
    }
    Console.WriteLine($"\nMinimum amount per row {rowMin+1} = {sumMin}");
}

Console.WriteLine("The program will define a two-dimensional rectangular array 6 x 4\n"+
"and find the row with the minimum sum of elements.");

int aRow = 6;
int bCol = 4;

int[,] array2D = GeneretionArray2DOutInt(aRow, bCol);

Console.WriteLine($"\n\t\tArrays 2D rows: {aRow}, columns: {bCol}");
ShowArray2DinConsole(array2D);
Console.WriteLine();
OutputStringWithThMinSumOfTheElements(array2D);

TODO: Конец задачи 56. без участия пользователя*/

//=====Вариант 2 с участиме пользователя

//TODO: Начало задачи 56. с участием пользователя
/*
int[,] CreateRandom2dRectangularArray()
{
    Console.WriteLine("\nThe program will define a two-dimensional rectangular array 6 x 4\n" +
    "and find the row with the minimum sum of elements\n");
    Console.Write("Input numbers of rows = [6]: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns = [4]: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value (1): ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value (9): ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void OutputStringWithThMinSumOfTheElements2(int[,] arrays2D)

{
    int sum = 0;
    int sumMin = 0;
    int rowMin = 0;
    for (int row = 0; row < arrays2D.GetLength(0); row++)
    {
        for (int col = 0; col < arrays2D.GetLength(1); col++)        
            sum += arrays2D[row, col];

        
        if (row == 0)
        {
            sumMin = sum;
            rowMin = row;
        }
        if (row > 0)
        {
            if (sumMin > sum)
            {
                sumMin = sum;
                rowMin = row;
            }
            
        }
        Console.WriteLine($"Amount per Row {row+1} = {sum}  ");
        sum = 0;
    }
    Console.WriteLine($"\nMinimum amount per row {rowMin+1} = {sumMin}");
}

void ShowArray2dDmore(int[,] array)
{
    Console.WriteLine();
    for (int a = 0; a < array.GetLength(0); a++)
    { Console.Write("|");
        for (int b = 0; b < array.GetLength(1); b++)
            Console.Write($"{array[a, b]:D2}");

     Console.Write("|");
     Console.WriteLine();
    }

}

int[,] RectangularArray = CreateRandom2dRectangularArray();
ShowArray2dDmore(RectangularArray);
Console.WriteLine();
OutputStringWithThMinSumOfTheElements2(RectangularArray);
*/
//TODO: Конец задачи 56. с участием пользователя

//Новая задача 60. ======================================================
/*
Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
Массив размером 2x2x2
66(0.0.0)25(0,1,0)
34(1.0.0)41(1,1,0)
27(0.0.1)90(0,1,1)
26(1.0.1)55(1.1,1)
*/
//TODO: Начало задачи 60. Вариант 1 без участия пользователя
/*
//Сформирован трехмерный массив
int [,,] Array3DhasBeenFormed()
{
int[,,] array3D = {{{66,27},{25,90}},{{34,26},{41,55}}};
return array3D;
}
//специальный вывод массива трехмерного под задачу
void ShowArray3DinConsole(int[,,] arrays3D)
{ //Выведем все первые элементы всех рядов и строк массива 
    for (int ranks = 0; ranks < arrays3D.GetLength(0); ranks++)
    {
        for (int rowsN = 0; rowsN < arrays3D.GetLength(1); rowsN++)
        {
            for (int colN = 0; colN < arrays3D.GetLength(2)-1; colN++)
            {
                Console.Write($"{arrays3D[ranks, rowsN, colN]} ({ranks},{rowsN},{colN})");
            }   
            
        }
        Console.WriteLine();      
    }
//Выведем все вторые элементы всех рядов и строк массива 
    for (int ranks = 0; ranks < arrays3D.GetLength(0); ranks++)
    {
        for (int rowsN = 0; rowsN < arrays3D.GetLength(1); rowsN++)
        {
            for (int colN = 1; colN < arrays3D.GetLength(2); colN++)
            {
                Console.Write($"{arrays3D[ranks, rowsN, colN]} ({ranks},{rowsN},{colN})");
            }   
            
        }
        Console.WriteLine();
      
    }

}

ShowArray3DinConsole(Array3DhasBeenFormed());

//TODO: Конец Задачи 60. Вариант 1. без участия пользователя */

//Задача 60. Вариант 2 с участиме пользователя.
//TODO Вариан 2 начало.
/*
int[,,] CreateNew3Darrays()
{   string[] stringNum = {"First","Second"};
    int[,,] array3D = {{{66,27},{25,90}},{{34,26},{41,55}}};
    int [,,] arrays3D = new int [2,2,2];
    for (int ranks = 0; ranks < arrays3D.GetLength(0); ranks++)
    {   Console.WriteLine($"\n\tLet's add numbers to the array ({stringNum[ranks]}):");
        for (int rowsN = 0; rowsN < arrays3D.GetLength(1); rowsN++)
        {   Console.WriteLine($"\nFill in the row {rowsN+1} from {arrays3D.GetLength(1)}:\n");
            for (int colN = 0; colN < arrays3D.GetLength(2); colN++)
            {
                Console.Write($"Enter the array value for the element {colN+1} = {array3D[ranks,rowsN,colN]} :");
                int Num = Convert.ToInt32(Console.ReadLine());
                arrays3D[ranks, rowsN, colN] = Num;
            }

        }

    }
    Console.WriteLine();
return arrays3D;
}

void ShowArray3DinConsole2(int[,,] arrays3D)
{ //Выведем все первые элементы всех рядов и строк массива 
    for (int ranks = 0; ranks < arrays3D.GetLength(0); ranks++)
    {
        for (int rowsN = 0; rowsN < arrays3D.GetLength(1); rowsN++)
            for (int colN = 0; colN < arrays3D.GetLength(2) - 1; colN++)
                Console.Write($"{arrays3D[ranks, rowsN, colN]} ({ranks},{rowsN},{colN})");
        Console.WriteLine();
    }
    //Выведем все вторые элементы всех рядов и строк массива 
    for (int ranks = 0; ranks < arrays3D.GetLength(0); ranks++)
    {
        for (int rowsN = 0; rowsN < arrays3D.GetLength(1); rowsN++)
            for (int colN = 1; colN < arrays3D.GetLength(2); colN++)
                Console.Write($"{arrays3D[ranks, rowsN, colN]} ({ranks},{rowsN},{colN})");
        Console.WriteLine();
    }

}

int[,,] newArrayCreate = CreateNew3Darrays();
ShowArray3DinConsole2(newArrayCreate);
*/
//TODO Вариан 2 Конец Задача 60..

//Новая задача 58. ========================================================
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
24|34
32|33
Результирующая матрица будет:
1820
1518
Чтобы узнать произведние двух матриц нужно сделать следующее: 
a11 a12|   |b11 b12|   a11*b11 + a12*b21  a11*b12 + a12*b22
a21 a22| Х |b21 b22| = a21*b11 + a22*b21  a21*b12 + a22*b22
*/
//TODO: Начало задачи 58
/*
//Метод заданных двух матриц как в примере
int[,,] GivenTwoMatrices()
{
 int[,,] GivenMatrices = {{{2,4},{3,2}},{{3,4},{3,3}}};
 return GivenMatrices;
}

int[,] MatrixMultiplicationAndOut2dArray(int[,,] array3D)
{
    int[,] array2Dnew = new int[2, 2];
    int a11 = array3D[0, 0, 0], a12 = array3D[0, 0, 1], a21 = array3D[0, 1, 0], a22 = array3D[0, 1, 1];
    int b11 = array3D[1, 0, 0], b12 = array3D[1, 0, 1], b21 = array3D[1, 1, 0], b22 = array3D[1, 1, 1];
    int C11 = a11 * b11 + a12 * b21, C12 = a11 * b12 + a12 * b22,
        C21 = a21 * b11 + a22 * b21, C22 = a21 * b12 + a22 * b22;
    array2Dnew[0, 0] = C11;
    array2Dnew[0, 1] = C12;
    array2Dnew[1, 0] = C21;
    array2Dnew[1, 1] = C22;
return array2Dnew;
}
//Метод ShowArray3DinConsole выведит две матрицы в консоль
void ShowArray3DinConsole(int[,,] arrays3D)
{  
    for (int ranks = 0; ranks < arrays3D.GetLength(0); ranks++)
    { string matrix = "A";
          if (ranks == 1) matrix = "B";
        Console.WriteLine($"Matrix: {matrix}"); 
        for (int rowsN = 0; rowsN < arrays3D.GetLength(1); rowsN++)
        {
           for (int colN = 0; colN < arrays3D.GetLength(2); colN++)            
                Console.Write($"{arrays3D[ranks, rowsN, colN]} ");               
            Console.WriteLine(); 
        }
        Console.WriteLine();
    }      
}
//Метод Show2Darray выведит консоль матрицу двумерную после умножения двух матриц
void Show2Darray(int[,] arry)
{ Console.WriteLine ("\n\tMultiplication Matrix A*B = C 2D");
    for (int row1 = 0; row1 < arry.GetLength(0); row1++)
    {
        for (int col2 = 0; col2 < arry.GetLength(1); col2++)        
            Console.Write($"{arry[row1, col2]} ");
        
        Console.WriteLine();
    }
Console.WriteLine ();
}

ShowArray3DinConsole(GivenTwoMatrices());
int[,] arrayNew2D = MatrixMultiplicationAndOut2dArray(GivenTwoMatrices());
Show2Darray(arrayNew2D);
*/
//TODO: Конец задачи 58

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4
Например, на выходе получается вот такой массив:
01020304
12131405
11161506
10090807
*/
//TODO: начало задачи 62.
/*
//Вывод массива под данную задачу
void Show2Darray(int[,] arry)
{
    Console.WriteLine("\n\tAn array filled with a spiral 2D\n");
    for (int row1 = 0; row1 < arry.GetLength(0); row1++)
    {
        for (int col2 = 0; col2 < arry.GetLength(1); col2++)
            Console.Write($"{arry[row1, col2]:D2} ");

        Console.WriteLine();
    }
    Console.WriteLine();
}
//Зададим массив

int[,] СreateAnewArray()
{
    int[,] array2D = new int [4,4];
    return array2D;
}


int [,] SpiralFillingAnArray(int[,] array2D)
{
int num = 01;
//Заполним первую строку числами
for (int i = 0; i < array2D.GetLength(0)/array2D.GetLength(0); i++)
{
    for(int j = 0; j < array2D.GetLength(1); j++)
    {
       array2D[i,j] = num;
       num++;
    }
}
//Заполним последний столбец числами минуя первую строку, так как столбец там заполнен.
for (int k = 1; k < array2D.GetLength(0); k++)
{
    for(int l = array2D.GetLength(1)-1; l < array2D.GetLength(1); l++)
    {
       array2D[k,l] = num;
       num++;
    }
}
//Заполним последную строку минуя последний столбец так как он заполнен.
for (int m = array2D.GetLength(0)-1; m < array2D.GetLength(0); m++)
{
    for (int n = array2D.GetLength(1)-2; n > -1; n--)
    {
        array2D[m,n] = num;
        num++;
    }
}
//Заполним первый столбец оставшихся строк с конца это 
for (int o = array2D.GetLength(0)-2; o > array2D.GetLowerBound(0); o--)
{
    for (int p = 0; p < array2D.GetLength(1)/array2D.GetLength(1); p++)
    {
        array2D[o,p] = num;
        num++;
    }
}
//Заполним оставшиеся столбцы второй строки от 2(1) стоблца по 3(2) столбец
for (int r = array2D.GetLength(0)/array2D.GetLength(0); r < array2D.GetLength(0)/array2D.GetLength(0)+1; r++)
{
    for (int s = 1; s < array2D.GetLength(1)-1; s++)
    {
        array2D[r,s] = num;
        num++;
    }
}

//Заполним оставшиеся столбцы третьей строки (2) строки от 3(2) стоблца по 2(1) столбец
for (int t = array2D.GetLength(0)-2; t < array2D.GetLength(0)-1; t++)
{
    for (int u = array2D.GetLength(1)-2; u > array2D.GetLowerBound(1); u--)
    {
        array2D[t,u] = num;
        num++;
    }
}
return array2D;
}



Console.WriteLine("\nLet's form a 4x4 array and fill it with integers with a spiral.");
int[,] OutpuArraySpiral = SpiralFillingAnArray(СreateAnewArray());
Show2Darray(OutpuArraySpiral);
*/
//TODO: Конец задачи 62.
