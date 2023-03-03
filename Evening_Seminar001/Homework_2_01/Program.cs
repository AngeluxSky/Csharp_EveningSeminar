//Задача 19. Напишите программу, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.Write("Imput a five-digit number: ");
int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine((num1 == 0) || (reverse(num1, 0) == num1));
    Console.ReadKey(true);
int reverse(int num1, int acc)
{    
if (num1 < 10000 || num1 >= 100000)
{
    Console.WriteLine("Input error, the number is not five-digit.");
}
while (num1 > 0) 
{
    acc = acc * 10 + num1 % 10; num1 /= 10; }
    return acc;
}
*/

// Задача 21. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

/*
double FindLengh (double x1,double x2,double y1,double y2, double z1, double z2)
{
  double result = Math.Sqrt(Math.Pow(x2 - x1,2)+ Math.Pow(y2 - y1,2)+ Math.Pow(z2 - z1,2));
  result = Math.Round(result, 2);
  return result; 
}

Console.WriteLine("введите координату по оси x первой точки");
double x1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси y первой точки");
double y1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси z первой точки");
double z1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси x второй точки");
double x2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси y второй точки");
double y2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси z второй точки");
double z2=Convert.ToInt32(Console.ReadLine());

double FindLengh2d=FindLengh(x1, x2, y1, y2, z1, z2);
System.Console.WriteLine ($"расстояние между точками = {FindLengh2d}");
/*

//Задача 23. Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
*/