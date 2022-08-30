// Задача 25: Напишиет цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// Например: 3,5 --> 243 (3^5) или 2,4 --> 16 (2^4)
/*
int Exponentiation(int num_A, int Digree)

{
    int res = 1;
    for (int i = 0; i < Digree; i++)
    {
        if (Digree == 1)
        {
            res = num_A;
        }
        if (Digree > 1)
        {
            res = res * num_A;
        }
    }
    return res;
}

void CheckingInput( int num_A_in, int Digree_in)
{

    while (num_A_in == 0 || Digree_in == 0)
    {        
            Console.WriteLine();
            Console.WriteLine($"Вы ввели число {num_A_in} или степень {Digree_in} равное нулю не натуральному числу");
            Console.WriteLine();
            if (num_A_in == 0)
            {
                Console.WriteLine($"Попробуйте еще, введите число больше нуля и число возведем в степень {Digree_in}");
                Console.Write("Введите число больше нуля:");
                num_A_in = Convert.ToInt32(Console.ReadLine());
            }
            if (Digree_in == 0)
            {   Console.WriteLine($"Попробуйте еще, введите степень больше нуля и число {num_A_in} возведем в степень");
                Console.Write("Введите cтепень больше нуля:");
                Digree_in = Convert.ToInt32(Console.ReadLine());
            }
            if (Digree_in == 0 && num_A_in == 0)
            {
                Console.WriteLine("Попробуйте еще, введите число больше нуля и степень больше нуля");
                Console.Write("Введите число больше нуля:");
                num_A_in = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите степень больше нуля:");
                Digree_in = Convert.ToInt32(Console.ReadLine());
            }
            
    }
    int Res = Exponentiation(num_A_in, Digree_in);
    
    Console.WriteLine($"{num_A_in}^{Digree_in} = {Res}");
 
}
Console.WriteLine("Введите число А и В и возведем А в степень В");
Console.Write("Введите натуральное число A:");
int num_A_input = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B:");
int Digree_in = Convert.ToInt32(Console.ReadLine());
CheckingInput(num_A_input, Digree_in);
*/

//==================================================================================
//Задача 27: Напишите программу, которая принмает на вход число и выдает сумму цифр в числе
//Например: 452 --> 11, 82 --> 10, 9012 --> 12
//====
/*
int CharDigit(int num)
{
    int num1 = Math.Abs(num);
    int sum = 0;
    int remains = 0;
    while (num1 > 0)
    {
        if ((num1 % 10) >= 0)
        {   remains = num1 % 10;
            sum += remains; 
            num1 = num1 / 10;
        }
    }
    
    return sum;
}
void CheckingInput_and_out(int num_A_in)
{

    while (num_A_in == 0)
    {        
            Console.WriteLine();
            Console.WriteLine($"Вы ввели число {num_A_in} равное нулю");
            Console.WriteLine();
            if (num_A_in == 0)
            {
                Console.WriteLine($"Попробуйте еще, введите число больше нуля");
                Console.Write("Введите число больше нуля:");
                num_A_in = Convert.ToInt32(Console.ReadLine());
            }
            
    }
  Console.WriteLine($"Сумма цифр в числе {num_A_in} = {CharDigit(num_A_in)}");
}

Console.WriteLine("Введите число больше ноля и желательно двух значное и более, и найдем сумму цифр в числе");
Console.Write("Введите натуральное число (452, 9012, 82):");
int num_A_input = Convert.ToInt32(Console.ReadLine());
CheckingInput_and_out(num_A_input);
*/


//Задача 29: Напишите программу, которая задает массив из 8 элементов и выводит их на экран. 1,2,5,7,19 --> [1, 2, 5, 7, 19] или 6, 1, 33 -->[6, 1, 33]
// Было пояснение, что нужно чтобы массив заполнился пользователем запрос эелемнта массива 0,1 и т.д.

//=====Вариант 1
/*
int[] Generetion(int sizen) 
      {
       int[] arr = new int[sizen];
       int sizeL = arr.Length;
       for (int i = 0; i < sizeL; i++)
        { Console.Write($"Введите значение (число) элемиента массива для индекса {i}:");
          int num = Convert.ToInt32(Console.ReadLine());
          arr[i] = num;
          
        } 
        return arr;
      } 
      void Print(int[] arrys)
      { int sizeL = arrys.Length;
        Console.Write("[");
        for (int j = 0; j < sizeL;j++)
       {
            
             Console.Write($"{arrys[j]}, ");
            
       }
        Console.WriteLine("\b\b]");
          
      }
      Console.WriteLine("Заполним массив числами для массива состоящего из 8 элементов");
      
      int[] arrg = Generetion(8);
      Print(arrg);
*/

//=====Вариант 2
/*
int[] Generetion(int sizen) 
      {
           
       while (sizen == 0)
       {
       Console.Write($"!!! Укажите размер массива от 1 до 10...n, a не {sizen}:");
       sizen = Convert.ToInt32(Console.ReadLine());
       }
       int[] arr = new int[sizen];
       for (int i = 0; i < sizen; i++)
        { 
          Console.Write($"Введите значение (число) элемиента массива для индекса {i}:");
          int num = Convert.ToInt32(Console.ReadLine());
          arr[i] = num;
          
        } 
        return arr;
      } 
      void Print(int[] arrys)
      { int sizeL = arrys.Length;
        Console.Write("[");
        for (int j = 0; j < sizeL;j++)
       {
            
             Console.Write($"{arrys[j]}, ");
            
       }
        Console.WriteLine("\b\b]");
          
      }
      Console.WriteLine("Заполним массив числами для массива состоящего из n элементов");
      Console.Write("Укажите размер массива от 1 до 10...n:");
      int sizeArr = Convert.ToInt32(Console.ReadLine());      
      int[] arrg = Generetion(sizeArr);
      Print(arrg);
*/
