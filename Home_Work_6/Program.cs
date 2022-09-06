/**=*===============================*=*
  *|* < $ > * My HomeWork 6 * < $ > *|* 
  *=*===============================*=**/

//|====================================================================================|
//Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь
// Например: 0,7,8,-2,2 --> 2, 1,-7, 567, 89, 223 --> 3
/*
int[] GeneretionAnArray(int sizen)
{
    while (sizen == 0)
    {
        Console.Write($"!!! Specify the size of the array from 1 to 10...n, a not {sizen}:");
        sizen = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[sizen];
    Console.WriteLine();
    for (int i = 0; i < sizen; i++)
    {   
        Console.Write($"Enter the value (number) of the array element for the index {i}:");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;

    }
    return array;
}
//Output of an array by beauty
void Output_an_array_tothe_Console(int[] arrys)
{  Console.WriteLine();
   for (int jcount = 0; jcount != arrys.Length; jcount++)
    {
        if (jcount == 0) Console.Write("[");
        if (jcount < arrys.Length - 1) Console.Write($"{arrys[jcount]}, ");
        if (jcount == arrys.Length - 1) Console.Write($"{arrys[jcount]}]");
    }   
   Console.WriteLine();
}
       
//Counting array numbers greater than zero
int Counting_Array_Num_Except_Zero(int[] arrysik)
{ int Counting = 0;
  
  for (int i = 0; i < arrysik.Length; i++)
  {
    if (i > 0 && arrysik[i] > 0) Counting++;
     
  }

  return Counting;
}

Console.WriteLine();
Console.WriteLine("We conduct M numbers from the keyboard and fill in the array.\n"+
"After we count how many numbers more than zero we entered.");
Console.WriteLine();
Console.WriteLine("Enter how many digits the array should contain");
Console.Write("Please enter a number from 5 to 13 or other integers:");
int Size_M_Array = Convert.ToInt32(Console.ReadLine());
int[] arrus = GeneretionAnArray(Size_M_Array);
Output_an_array_tothe_Console(arrus);
int CountNumNotZero = Counting_Array_Num_Except_Zero(arrus);
Console.WriteLine("======== -->|\n|--->In this array, the number of numbers is greater than zero = {0}",CountNumNotZero);
*/

//|====================================================================================|
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями у = kl * х + b1 у = к2 * х + Ь2; значения b1, kl, Ь2 и к2 задаются пользователем.
//b1 = 2, к1 = 5, Ь2 = 4, к2 = 9 -> (-0,5; -0,5)

//Для решения данной задачи нужно выполнить равенствто уравнений по правилам:
//1. делаем равенство kl * х + b1 = к2 * х + Ь2
//2. в первую часть перекинем все множители с неизвестными членами ураванения, а во вторую часть с изветсными:
// k1x - k2x = b2 - b1
//3. Kx = B
//4. x = B/K - нашли x
//5. Чтобы найти y подставим x в любое уравнение: y = 5 * x + 2;

void Uravnenie()
{
Console.Write("Введите значение уравнения k1 (например: 5):");
int k1 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
Console.Write("Введите значение уравнения b1 (например: 2):");
int b1 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
Console.Write("Введите значение уравнения k2 (например: 9):");
int k2 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
Console.Write("Введите значение уравнения b2 (например: 4):");
int b2 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
double resK = k1 - k2;
double resB = b2 - b1;
double res_x = resB / resK;
double res_y = k2 * res_x + b2;
Console.WriteLine ($"у = kl * х + b1, x = {res_x}, y = {k1} * {res_x} + {b1} = {res_y}, Точка А ({res_x},{res_y})\n");
}
Console.WriteLine();
Console.WriteLine("Найдём точку пересечения двух прямых,\nзаданных уравнениями у = kl * х + b1 у = к2 * х + Ь2\n");
Uravnenie();
