// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int ones = num % 10;

    return hundreds * 10 + ones;
}

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно a и b.

/*
bool IsDivided(int number, int firstDivider, int secondDivider);
{
    return number % firstDivider == 0 && number % secondDivider == 0;

    // if (number % firstDivider == 0 && number % secondDivider == 0)
    //    return true;
    // else
    //    return false;
}
Console.Write("Imput a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a first divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsDivided(num, div1, div2));
*/
// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int Max(int num)
{
int dec = num / 10;
int ones = num % 10;
if (dec > ones)
    return dec;
else
    return ones;
}
int randNumber = new Random().Next(10, 100);
Console.WriteLine($"В числе {randNumber} самая большая цифра {Max(randNumber)}");
*/

// Напишите программу, которая принимает
// на вход два числа и проверяет, является
// ли одно число квадратом другого.

/*
bool CheckSquare(int num1, int num2)
{
    return (num1*num1==num2 || num2*num2 == num1);
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckSquare(num1, num2));
*/