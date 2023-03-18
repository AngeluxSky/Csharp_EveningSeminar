// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];
Random rnd = new Random();

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
}
FillArray(randomArray);
Console.WriteLine();
PrintArray(randomArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];
Console.Write("Введите позицию строки: ");
int position1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int position2 = Convert.ToInt32(Console.ReadLine());

void RandomArray(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 10);
            Console.Write($"{randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

RandomArray(m, n);
if (position1 < 1 || position2 < 1)
{
    Console.Write("Позиции строк не могут быть отрицательными");
}
else if (position1 <= m + 1 && position2 <= n + 1)
{
    Console.Write($"Значение элемента равно {randomArray[position1 -1, position2 -1]} ");
}
else
{
    Console.Write("Такого элемента нет в массиве");
}
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];
Random rnd = new Random();

void Massive(int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = rnd.Next(1, 9);
            Console.Write($"{randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Sum(int m, int n)
{
    Console.Write("Среднее арифметическое: ");
    int i, j;
    Random rand = new Random();
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
            sum = sum + randomArray[i, j];
        }
        Console.Write($"{Math.Round(sum / (i), 1)}; ");      //{..:F2}
    }
}
Massive(m, n);
Console.WriteLine();
Sum(m, n);
*/