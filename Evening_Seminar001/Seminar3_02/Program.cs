// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

/*
int[] FillArrayWhithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

void ReverseArray(int[] arr)
{
    int temp = 0;

    for(int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
ReverseArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
*/

// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник 
// со сторонами такой длины.
/*
Console.Write("Imput a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput с: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = TriangleSidesCheck(a, b, c);
	
Console.WriteLine(result);
	
bool TriangleSidesCheck(int a, int b, int c)
	{
	return (a + b >= c || a + c >= b || b + c >= a);                                                   
    }
 Console.WriteLine($"Треульник со сторонами a:{a}, b:{b}, c{c} - {TriangleSidesCheck}.");
*/

// Второй вариант

/*
Console.Write("Введите первую сторону треугольника: ");
int ab = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
int bc = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
int ac = Convert.ToInt32(Console.ReadLine());

if(ab + bc > ac && ab + ac > bc && bc + ac > ab)
{
System.Console.Write("Треугольник существует");
}
else
{
System.Console.Write("Треугольник не существует");
}
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
/*
void PrintBinary(int number)
{
if(number <= 0)
{
return;
}

PrintBinary(number/2);
Console.Write(number%2);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinary(number);
*/


// Второй вариант
/*
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int end = 0;
int d = 1;
while (num1 > 0)
{
    end = end + num1 % 2 * d;
    num1 /= 2;
    d*= 10;
}
Console.WriteLine(end);
*/

// Трерий вариант
/*
int SizeofDif(int num)
{
int count = 0;

while (num > 0)
{
    num /= 2;
    count++;
}

return count;
}

int[] Dif(int num)
{
int[] arr = new int[SizeofDif(num)];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = num % 2;
    num /= 2;
}

return arr;
}

int[] Reverse(int[] someArr)
{

for (int i = 0; i < someArr.Length/2; i++)
{
    int temp = someArr[i];
    someArr[i] = someArr[someArr.Length - 1 - i];
    someArr[someArr.Length - 1 - i] = temp;
}

return someArr;
}

int[] result = Dif(2);
Console.WriteLine($"Your array: [{string.Join(", ", result)}]");
int[] newArr = Reverse(result);
Console.WriteLine($"Reverse array: [{string.Join(", ", newArr)}]");
*/


/*
void Main(string[] args)
{
    Console.Write("Enter a number : ");
    int num = Convert.ToInt32(Console.ReadLine());
    int one = 0;
    int two = 1;
    int three = 0;
    for (int i = 3; i <= num; i++)
    {
        three = one + two;
        Console.Write("{0} ", three);
        one = two;
        two = three;
    }
Console.Write($"Fibonacci {Main} {0} {1} {1} ", num, one, two);
}
*/


/*
Console.Write("Ввести число:");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = Fibonacci(number);

PrintArray(array);

int[] Fibonacci(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(@"[{0}]", string.Join(",", array));
}
*/

/*
int[] array = CreateArrayRndInt(0, 10, 8);

PrintArray(array);

int[] newArray = CopyArray(array);

PrintArray(newArray);




int[] CreateArrayRndInt(int min, int max, int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(@"[{0}]", string.Join("; ", array));
}


int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
*/