/**=*===============================*=*
  *|* $ $ * * My HomeWork 9 * * $ $ *|* 
  *=*===============================*=**/

/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
//Через цикл не смотрите 
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
//Конец Через цикл не смотрите 

//Через рекурсию Задача 64.
//TODO:Задача 64 Вариант 1 
/*
void GenerationScaleOfNumbers(int m, int n)
{
    if (m < n) GenerationScaleOfNumbers(m, n - 1);
    Console.Write("{0} ", n);
    if (m > n) GenerationScaleOfNumbers(m, n + 1);
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
//TODO: Конец Задача 64 Вариант 1 
//TODO:Задача 64 Вариант 2 где меняется m
/*
void GenerationScaleOfNumbers2(int m, int n)
{
    if (m > n) GenerationScaleOfNumbers2(m - 1, n);
    Console.Write("{0} ", m);
    if (m < n) GenerationScaleOfNumbers2(m + 1, n);

}
void NumberInputAndOutputResult2()
{
    Console.Write("Input integer m = 1 or 4: ");
    int NumM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input integer n = 5 or 8: ");
    int NumN = Convert.ToInt32(Console.ReadLine());
    GenerationScaleOfNumbers2(n: NumN, m: NumM);
}
NumberInputAndOutputResult2();
*/
//TODO:Конец Задача 64 Вариант 2
//TODO:Задача 64 Вариант 3 когда выодится от m до n как задано пользователем
/*
void GenerationScaleOfNumbers3(int m, int n)
{   Console.Write("{0} ", m);
    if (m < n) GenerationScaleOfNumbers3(m + 1, n);
    if (m > n) GenerationScaleOfNumbers3(m - 1, n);
    
}
void NumberInputAndOutputResult3()
{
    Console.Write("Input integer m = 1 or 4: ");
    int NumM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input integer n = 5 or 8: ");
    int NumN = Convert.ToInt32(Console.ReadLine());
    GenerationScaleOfNumbers3(n: NumN, m: NumM);
}
NumberInputAndOutputResult3();
*/
//TODO:Конец Задача 64 Вариант 3
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
//Через цикл не смотрите
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
//Конец через цикл не смотрите
//TODO: Задача 66 Начало через рекурсию
/*
int SumOfNaturalNumbersInTheInterval(int mNum, int nNum, int countMin, int countMax)
{   if (mNum <= nNum && countMax == 0) return mNum + SumOfNaturalNumbersInTheInterval(mNum+1, nNum, countMin+1, countMax);  
    
    if (mNum >= nNum && countMin == 0) return mNum + SumOfNaturalNumbersInTheInterval(mNum-1, nNum, countMin, countMax+1); 
    return 0;
}
void GenerationScaleOfNumbers3(int mNum, int nNum)
{   Console.Write("{0} ", mNum);
    if (mNum < nNum) GenerationScaleOfNumbers3(mNum + 1, nNum);
    if (mNum > nNum) GenerationScaleOfNumbers3(mNum - 1, nNum);
    
}
void InputOfValuesOutputResult3()
{
    Console.Write("Input integer m = 1 or 4: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input integer n = 15 or 8: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int sumResult = SumOfNaturalNumbersInTheInterval(m, n,0,0);
    GenerationScaleOfNumbers3(nNum:n,mNum:m);
    Console.Write(" --> {0}", sumResult);
}

InputOfValuesOutputResult3();
//TODO: Задача 66 Конец через рекурсию

//Задача 64 и 66 объедененны реализаиця через рекурсию.
/*
int SumOfNaturalNumbersInTheIntervalShowScale(int mNum, int nNum)
{
    if (mNum <= nNum)
    {
        if (mNum < nNum) Console.Write("{0}, ", mNum);
        if (mNum == nNum) Console.Write("{0} -->", mNum);

        return mNum + SumOfNaturalNumbersInTheIntervalShowScale(mNum + 1, nNum);

    }else return 0;
}

void InputOfValuesOutputResult2()
{
    Console.Write("Input integer m = 1 or 4: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input integer n = 15 or 8: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int sumResult = SumOfNaturalNumbersInTheIntervalShowScale(nNum: n, mNum: m);
    Console.Write(" {0}", sumResult);
}


InputOfValuesOutputResult2();
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
/*
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
*/






//Дополнительно объединение в один метод эксперименты
/*
int doit(int m, int n, int count, int count1)
{
    if (m > n - 1 & count == 0)
    {
        Console.Write($"{m} ");
        return m + doit(m - 1, n, count, count1 + 1);
    }
    if (m <= n & count1 == 0)
    {
        Console.Write($"{m} ");
        if (m == n)
        {
            Console.Write("\n");
            Console.WriteLine("<--");
        }
        return doit(m + 1, n, count + 1, count1);
    }
    else if (m - (count + 1) < n && count1 == 0)
    {
        Console.Write($"{n} ");
        return n + doit(m, n - 1, count, count1);
    }
    else return 0;
}
Console.Write($" {doit(4, 8, 0, 0)}");
*/