// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

/*
int Prompt(string message)
{
Console.Write("Imput a number: ");
int result = Convert.ToInt32(Console.ReadLine());
//чтобы не дублировать ещё раз строку
return result;
}
int num1 = Prompt("Imput a number: ");
if (num1 < 100 || num1 >= 1000)
{
    Console.WriteLine("Input error, the number is not three-digit.");
    return;
}
Console.WriteLine($"Entered number: {num1}");
int secondNum =  num1 / 10 % 10;
Console.WriteLine($"Second digit of the number: {secondNum}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

/*
int Prompt(string message)
{
Console.Write("Imput a number: ");
int result = Convert.ToInt32(Console.ReadLine());
//чтобы не дублировать ещё раз строку
return result;
}
int ThirdRank(int number)
{
while (number > 999)
{
    number /= 10;
}
return number % 10;
}
bool CorrectData (int number)
{
if (number < 100)
{
    Console.WriteLine("Input error");
    return false;
}
return true;
}
int number = Prompt("Imput a number > ");
if (CorrectData(number))
{
    Console.WriteLine(ThirdRank(number));
}
*/

//  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Введите номер дня недели  ");
int num = Convert.ToInt32(Console.ReadLine()); 
if (num >= 1 && num <= 5) 
{ 
    Console.Write("Нет, это не выходной"); 
} 
else 
if (num >= 6 && num <= 7) 
{ 
    Console.Write("Да, это выходной"); 
} 
else 
{
    Console.Write("Не существует такого дня недели"); 
}
*/




