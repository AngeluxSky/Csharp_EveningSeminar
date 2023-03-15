// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] arrayNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}
Console.WriteLine("Array: ");
int size = 4;
int[] array = arrayNumber(size);

int count = 0;
for(int i=0; i<array.Length; i++){
    if((array[i] % 2)== 0) count++;
}
Console.WriteLine($"-> {count}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
Console.Write("Enter the number of array elements: ");
int arr = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[arr];

void ImputSizeArray(int num)
{
Random rand = new Random();
    for(int i = 0; i < arr; i++)
    {
    randomArray[i] = new Random().Next(-10,100);
    Console.Write($"{randomArray[i]} ");
    }
}
int SumElements(int[] randomArray)
{
int sum = 0;
int i = 0;
while (i < randomArray.Length)
{
sum = sum + randomArray[i];
i = i + 2;
}
return sum;
}

ImputSizeArray(arr);
Console.Write($"The sum of the elements standing in odd positions: {SumElements(randomArray)}");
*/

// Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

/*
void FillArrayRandomNumbers(double[] elements)
{
    for(int i = 0; i < elements.Length; i++)
        {
        elements[i] = Convert.ToDouble(new Random().Next(10,10000)) / 100;
        }
}
void PrintRandomArray(double[] randomArray)
{
    Console.Write("[ ");
    for(int i = 0; i < randomArray.Length; i++)
    {
    Console.Write(randomArray[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Enter the number of array elements: ");
int arr = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[arr];
FillArrayRandomNumbers(numbers);
PrintRandomArray(numbers);
double Difference(double[] randomArray)
{
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
    max = numbers[i];
    }
    if (numbers[i] < min)
    {
    min = numbers[i];
    }
}
return max-min;
}
Console.WriteLine($"The difference between the maximum and minimum array elements: {Difference(numbers):F2}");
*/

//Не корректный код

/*
Console.Write("Enter the number of array elements: ");
int arr = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[arr];

void ImputSizeArray(int num)
{
Random rand = new Random();
for (int i = 0; i < arr; i++)
    {
    randomArray[i] = (rand.NextDouble() * 2.0);
    double exponent = Math.Pow(2.0, rand.Next(1, 10));
    Console.Write($"{randomArray[i] * exponent:F1} ");
    }
}
double Difference(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
    for(int i = 1; i < randomArray.Length; i++)
    {
    if (max < randomArray[i])
    max = randomArray[i];
    if (min > randomArray[i])
    min = randomArray[i];
    }
return max-min;
}
ImputSizeArray(arr);
Console.Write($"The difference between the maximum and minimum array elements: {Difference(randomArray):F2}");

//----------

void ImputSizeArray(int num)
{
Random rand = new Random();
for (int i = 0; i < arr; i++)
{
randomArray[i] = (rand.NextDouble() * 2.0);
// double exponent = Math.Pow(2.0, rand.Next(1, 10)); // эти две строки меняли только отображение в консоли, а заполнялось всё в массив выше.
// Console.Write($"{randomArray[i] * exponent:F1} "); // здесь вы вели отображение, оно будет корректным, если вы заново переприсвоите элементы массива
}
}
Вот примерно таким образом, то тогда и отображение и заполнение будет верным
void ImputSizeArray(int num)
{
Random rand = new Random();
for (int i = 0; i < arr; i++)
{
randomArray[i] = (rand.NextDouble() * 2.0);
double exponent = Math.Pow(2.0, rand.Next(1, 10));
randomArray[i] = randomArray[i] * exponent;
Console.Write($"{Math.Round(randomArray[i], 2)} ");
}
}

*/
