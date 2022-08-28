//Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа. 
//Например 456 --> 5, 782 --> 8, 918 --> 1

//Вариант 1._________________________________________________________________________

/*
void secondDigit(int num)
{
 int result = (num/10)%10;
 Console.Write($"Вторая цифра трехначного числа {num} это {result}");
}
Console.WriteLine("Outputs the second digit of the number");
Console.Write("Input a three-digit integer(232, 111):");
int num_A = Convert.ToInt32(Console.ReadLine()); 

secondDigit(num_A);
*/

//-----------------------------------------------------------------------------
//Второй вариант

/*
int CharDigit(int num)
{
    int char_n = 0;
    int num1 = Math.Abs(num);
    while (num1 > 0)
    {
        if ((num1 % 10) >= 0)
        {
            num1 = num1 / 10;
            char_n++;
        }
    }
    
    return char_n;
}

void secondDigit(int num)
{
 int result = (num/10)%10;
 Console.WriteLine();
 Console.WriteLine($"Вторая цифра трехзначного числа {num} это {result}");
}
void outputCheck(int num_a)
{
    int digitVal = CharDigit(num_a);
    while (digitVal < 3 || digitVal >= 3)
    {

        if (digitVal < 3 || digitVal > 3)
        {
            Console.WriteLine();
            Console.WriteLine($"Вы ввели число {num_a} состоящее из {digitVal} цифр");
            Console.WriteLine();
            Console.Write("Попробуйте еще, введите трехзначное число:");
            num_a = Convert.ToInt32(Console.ReadLine());
            digitVal = CharDigit(num_a);
            continue;
        }
        else
        {
            Console.Clear();
            Console.WriteLine();
            secondDigit(num_a);            
            Console.WriteLine("Ещё :");
            Console.WriteLine($"число {num_a} состоит из {digitVal} цифр");
            break;
        }
    }
}
Console.WriteLine("Принимает трехзначное число и выводит вторую цифру числа");
Console.Write("Введите трехзначное сичло (100, 300):");
int numr = Convert.ToInt32(Console.ReadLine());
outputCheck(numr);
Console.WriteLine();
Console.WriteLine("!Повторить - dotnet run");
*/

//----------------------------------------------------------------------------------------------------------------------
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нету.
// Например: 645 --> 5, 78 --> нет, 32679 --> 6
//==== Варинат 1:
/*
int CharDigit(int num)
{
    int char_n = 0;
    int num1 = Math.Abs(num);
    while (num1 > 0)
    {
        if ((num1 % 10) >= 0)
        {
            num1 = num1 / 10;
            char_n++;
        }
    }
    
    return char_n;
}

void OutputThirdDigit(int num)
{
    int Valency = CharDigit(num);

    if (Valency < 3)
    {
    Console.WriteLine($"В введенной цифре {num} третьей цифры Нет!");
    }
    if (Valency == 3)
    {
        int a = num%10;
        Console.WriteLine($"В введенной цифре {num} третья цифра {a}");
    }
    if (Valency == 4)
    {
        int b = (num%100)/10;
        Console.WriteLine($"В введенной цифре {num} третья цифра {b}");
    }
    if (Valency == 5)
    {
        int c = (num%1000)/100;
        Console.WriteLine($"В введенной цифре {num} третья цифра {c}");
    }
    if (Valency == 6)
    {
        int d = (num%10000)/1000;
        Console.WriteLine($"В введенной цифре {num} третья цифра {d}");
    }
    if (Valency == 7)
    {
        int e = (num/10000)%10;
        Console.WriteLine($"В введенной цифре {num} третья цифра {e}");
    }
     if (Valency == 8)
    {
         int f = (num/100000)%10;
        Console.WriteLine($"В введенной цифре {num} третья цифра {f}");
    }
      if (Valency == 9)
    {
        int j = (num/1000000)%10;
        Console.WriteLine($"В введенной цифре {num} третья цифра {j}");
    }
    if (Valency >= 10)
    {
        Console.WriteLine($"Вы ввели цифру {num} состоящую из {Valency} введите поменьше или равную 999999999, повторите dotnet run");

    }
 
}
Console.WriteLine("Выведет третью цифру числа или сообщит, что третьей цифры нет");
Console.Write("Введит целое число желательно до 9 занков например (999999999):");

int numA = Convert.ToInt32(Console.ReadLine());

OutputThirdDigit(numA);
*/
//===Варинт 2:

/*
int ThirdDigit(int num1)
{
    //int char_n = 0;
    num1 = Math.Abs(num1);
    while (num1 > 0)
    {
        if (num1 >= 1000)
        {
            num1 = num1 / 10;
            //char_n++;
        }

        if (num1 >= 100 && num1 < 1000)
        {
            num1 = num1 % 10;
            break;
        }
        if (num1 <= 99)
        {
            num1 = 0;
            break;
        }

    }
return num1;  
}

Console.WriteLine("Выведет третью цифру числа или сообщит, что третьей цифры нет");
Console.Write("Введит целое число желательно до 9 занков например (999999999):");

int numA = Convert.ToInt32(Console.ReadLine());

int res = ThirdDigit(numA);
if (res > 0)
{
Console.Write($"Третья цифра {res} от числа {numA}");
}else{
Console.Write($"Третьей цифры нет в числе {numA}");
}
*/

///_-------------------------------------------------------------------------------------------------------------------------------------

//Задача 15: Напишите программу, которая принмает на вход цифру, обозначаующую день недели и проверяет, является ли этот день выходным.
// 6--> Да, 7--> Да, 1 --> нет
/*
int CharDigit(int num)
{
    int char_n = 0;
    int num1 = Math.Abs(num);
    while (num1 > 0)
    {
        if ((num1 % 10) >= 0)
        {
            num1 = num1 / 10;
            char_n++;
        }
    }
    
    return char_n;
}
void FindDays(int num_a)
{
    string[] Days = {"Пн (Mon)", "Вт (Tue)", "Ср (Wed)", "Чт (Thu)", "Пт (Fri)", "Сб (Sat)", "Вс (Sun)"};
    int lengthDays = Days.Length;
    int index = 0;

    while (index < lengthDays)
    {
       int num_c = num_a - 1;
       if (index == num_c)
        {
            if (num_c == 5 || num_c == 6 )
            {
            string findDay = Days[index];
            Console.Write($"цифра {num_a} соответсвует дню недели {findDay} выходной");
            break;
            }else{
            string findDay = Days[index];
            Console.Write($"цифра {num_a} соответсвует дню недели {findDay} не выходной");
            break;
            }
        }
        index++;
    }

}

void outputCheck(int num_a)
{
    int digitVal = CharDigit(num_a);
    int dangerDigit = 0;
    while (digitVal < 1 || digitVal >= 1)
    {
        
        if (digitVal > 1 || num_a == 0 || num_a > 7)
        {
            dangerDigit++;
            Console.WriteLine();
            Console.WriteLine($"Вы ввели число {num_a} состоящее из {digitVal} цифр");
            if ((dangerDigit % 2) == 0)
            {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Просьба ввести число от 1 до 7!");
            Console.WriteLine($"Вы ввели число {num_a} состоящее из {digitVal} цифр");
            }
            Console.WriteLine();
            Console.Write("Попробуйте еще, введите число от 1 до 7: ");
            num_a = Convert.ToInt32(Console.ReadLine());
            digitVal = CharDigit(num_a);
            
            continue;
        }
        else
        {
            FindDays(num_a);                       
            Console.WriteLine();
            //Console.WriteLine($"число {num_a} состоит из {digitVal} цифр");
            break;
        }
        
    }
}
Console.WriteLine("Чтобы проверить какому дню недели соответсвует цифра");
Console.Write("Введите цифру от 1 по 7: ");
int days = Convert.ToInt32(Console.ReadLine());
outputCheck(days);
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Чтобы проверить eще введите dotnet run");

*/

