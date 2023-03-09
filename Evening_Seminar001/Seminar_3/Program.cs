//Задача 24: Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

/*
int Sum (int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum+=i;
    }
    return sum;
}

System.Console.WriteLine("Imput a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine($"Сумма от 1 до {number} = {sum}");
*/

//Задача 26.Напишите программу, которая принимает на вход число
//и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

/*
Console.Write("Imput a first number: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
while(num > 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine($"Кол-во цифр в числе: {count}");
*/

//Задача 28.Напишите программу, которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

/*
Console.WriteLine("Imput a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Pow(number);

int Pow(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine($"Результат: {result}");
*/

//Задача 30.Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

/*
Console.Write("Input array length "); //опционально
int n = Convert.ToInt32(Console.ReadLine()); //опционально
int[] array = new int [n];  
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write($"{array[i]} ");
}
*/

