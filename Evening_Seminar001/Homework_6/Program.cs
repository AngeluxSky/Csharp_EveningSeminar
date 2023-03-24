// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1

/*
void PrintNumberToN(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.Write($"{N} ");
    PrintNumberToN(N - 1);
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(number);
*/

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumN(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else if (M < N)
    {
        return N + SumN(M, N - 1);
    }
    else
    {
        return N + SumN(M, N + 1);
    }
}
Console.Write($"{SumN(M, N)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
int FunctionOfAker(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    if (M != 0 && N == 0)
    {
        return FunctionOfAker(M - 1, 1);
    }
    if (M > 0 && N > 0)
    {
        return FunctionOfAker(M - 1, FunctionOfAker(M, N - 1));
    }
    return FunctionOfAker(M, N);
}
Console.Write($"Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Акермана для числа A ({M},{M}) = {FunctionOfAker(M, N)}");
*/