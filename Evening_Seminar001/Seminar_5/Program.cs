// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

/*
int[,] FillMatrixWithRandom(int row, int col){
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ReplaceRows(int[,] array){
    int[] first = new int[array.GetLength(1)];
    for(int i=0; i<first.Length; i++){
        first[i] = array[0,i];
    }

    int[] last = new int[array.GetLength(1)];
    for(int i=0; i<last.Length; i++){
        last[i] = array[array.GetLength(0)-1,i];
    }
  
    for(int i=0; i<first.Length; i++){
        array[0,i] = last[i];
        array[array.GetLength(0)-1,i] = first[i];
    }

    PrintMatrix(array);
}

int row = 0 ;
int col = 0;
while(row <= 0){
    Console.Write("Введите кол-во строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}
while(col <= 0){
    Console.Write("Введите кол-во столбцов: ");
    col = Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = FillMatrixWithRandom(row, col);
PrintMatrix(matrix);
Console.WriteLine();
ReplaceRows(matrix);
*/

// Правильный вариант

/*
int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} \t");
}
Console.WriteLine();
}
}

int[,] SwitchRows(int [,] matrix)
{
int temp = 0;

for(int i = 0; i < matrix.GetLength(1); i++)
{
    temp = matrix[0, i];
    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
    matrix[matrix.GetLength(0) - 1, i] = temp;
}
return matrix;
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
SwitchRows(matrix);
PrintMatrix(matrix);
*/

// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.

/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
int[,] resultMatrix = new int[column, row];
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = matrix[j, i];
    }
}
System.Console.WriteLine();
PrintMatrix(resultMatrix);
*/

//Второй вариант (групповой)

/*
int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReverseRowsCols(int[,] array)
{
    int compare = 0;
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

    if (array.GetLength(0) > array.GetLength(1) || array.GetLength(0) < array.GetLength(1))
    { //проверяем на прямогульную
        compare = 1;
    }

    switch (compare)
    {
        case 0:
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i, j] += array[j, i];
                }
            }
            break;

        case 1:
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    newArray[i, j] += array[j, i];
                }
            }
            break;
    }
    PrintMatrix(newArray);

}

int row = 0;
int col = 0;
while (row <= 0)
{
    Console.Write("Введите кол-во строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}
while (col <= 0)
{
    Console.Write("Введите кол-во столбцов: ");
    col = Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = FillMatrixWithRandom(row, col);
PrintMatrix(matrix);
Console.WriteLine();

ReverseRowsCols(matrix);
*/

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

// Первый вариант решения

/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
int count = 0;

for (int k = 0; k < 10; k++)
{
    count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == k)
            {
                count++;
            }
        }
    }
    if (count > 0)
    {
        System.Console.WriteLine($"Кол-во повторений для {k} = {count} раз");
    }
}
*/

// Второй вариант решения

/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

int[] countArray = new int[10];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        countArray[matrix[i, j]]++;
    }
}

for (int i = 0; i < countArray.Length; i++)
{
    if (countArray[i] != 0)
    {
        System.Console.WriteLine($"Кол-во повторений для {i} = {countArray[i]} раз");
    }
}
*/

// Третий вариант (групповой)

/*
int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FindSmth(int[,] array)
{
    int[] number = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int count = 0;
    for (int k = 0; k < number.Length; k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (number[k] == array[i, j])
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"Число {number[k]} встречалось {count}");
        count = 0;
    }
}

int row = 0;
int col = 0;
while (row <= 0)
{
    Console.Write("Введите кол-во строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}
while (col <= 0)
{
    Console.Write("Введите кол-во столбцов: ");
    col = Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = FillMatrixWithRandom(row, col);
PrintMatrix(matrix);
Console.WriteLine();

FindSmth(matrix);
*/

// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

/*
int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[] FindMin(int[,] array)
{
    int min = array[0, 0];
    int[] minPos = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minPos[0] = i;
                minPos[1] = j;
            }
        }
    }
    return minPos;
}

int[,] CopyWithoutMin(int[,] matrix, int[] minPos)
{
    int[,] array = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0, k = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0, l = 0; j < matrix.GetLength(1); j++)
        {
            if (i != minPos[0] && j != minPos[1])
            {
                array[k, l] = matrix[i, j];
                l++;
            }
        }
        if (i != minPos[0])
        {
            k++;
        }
    }
    return array;
}

int row = 0;
int col = 0;
while (row <= 0)
{
    Console.Write("Введите кол-во строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}
while (col <= 0)
{
    Console.Write("Введите кол-во столбцов: ");
    col = Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = FillMatrixWithRandom(row, col);
PrintMatrix(matrix);
Console.WriteLine();

int[] minPosition = FindMin(matrix);
Console.WriteLine($"[{string.Join(", ", minPosition)}]");
Console.WriteLine();

int[,] newMatrix = CopyWithoutMin(matrix, minPosition);
PrintMatrix(newMatrix);
*/
