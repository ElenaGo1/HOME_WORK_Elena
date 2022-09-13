/**=*===============================*=*
  *|* $ $ * * My HomeWork 9 * * $ $ *|* 
  *=*===============================*=**/

/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
/*
void GenerationScaleOfNumbers(int m, int n)
{
    for (; m < n; m++)
        Console.Write($"{m},");
    Console.Write("{0}", n);
}
void NumberInputAndOutputResult()
{
    Console.Write("Input integer m = 1 or 4: ");
    int NumM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input integer n = 5 or 8: ");
    int NumN = Convert.ToInt32(Console.ReadLine());
    GenerationScaleOfNumbers(n: NumN, m: NumM);
}

NumberInputAndOutputResult();
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumOfNaturalNumbersInTheInterval(int mNum, int nNum)
{   int sum = 0;
    //Console.Write($"m={m}");
    for (int m = mNum; m < nNum; m++)
    { if (mNum == m)
        Console.Write($"from m={mNum}");
        sum += m;
        if (m % 2 == 1)        
            Console.Write($".");        
    }
    Console.Write("to n={0} -->", nNum);
    sum = sum + nNum;
    return sum;
}
void InputOfValuesOutputResult()
{
    Console.Write("Input integer m = 1 or 4: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input integer n = 15 or 8: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int sumResult = SumOfNaturalNumbersInTheInterval(nNum: n, mNum: m);
    Console.Write(" {0}", sumResult);
}

InputOfValuesOutputResult();

*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 не правильный пример т.к. Cогласно таблицы Аккермана можно получить 29 при А(m,n) 1 (3,2) 2(2,13)

Реализация:

Функция Аккермана определяется рекурсивно для неотрицательных целых чисел следующим образом:

        |n+1             m=0;
A(m,n)= |A(m-1,1)        m>0,n=0;
        |A(m-1,A(m,n-1)) m>0,n>0.
*/

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

void EnteringFunctionValuesAndOutResult()
{
    Console.WriteLine("Enter two non-negative numbers, for example A (m,n) m = 2 and n = 13,\n and we get the result of calculating the Ackerman function");
    Console.Write("Input integer m = 2 or 3: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input integer n = 13 or 2: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int result = AckermanFunction(m, n);
    Console.WriteLine("For values A(m,n), A({0},{1}), the result of the calculation = {2} ", m, n, result);

}

EnteringFunctionValuesAndOutResult();
