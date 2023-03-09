// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (num2<1)
Console.Write("Число B должно быть натуральным");
else
{
while (num2!=0)
{
c = c * num1;
num2 = num2 - 1;
}
Console.Write($"Число A в натуральной степени B равно {c}");
}
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int len = Length(num);
Console.Write($"The sum of the number - {num} equally: {Sum(num,len)}");

int Length(int num)
{
int index = 0;
while (num > 0)
    {
    num /= 10;
    index++;
    }
return index;
}

int Sum(int num, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
    {
    sum += num % 10;
    num /= 10;
    }
return sum;
}
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,99);
Console.Write(randomArray[i] + " ");
}
*/