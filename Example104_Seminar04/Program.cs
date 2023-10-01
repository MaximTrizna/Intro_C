// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

/* void f(int n)
{
    int result = 0;
    for(int i = 1; i <= n; i++)
        result += i; // result = result + i
    Console.Write(result);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
f(n); */

// ______________________________________________________________________________________________________________________

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Решение:

/* Console.Clear();
void f(int n)
{
    int count = 0;
    while (n > 0)
    {
        count++;
        n /= 10;
    }
    Console.Write(count);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
f(n); */

// ____________________________________________________________________________________________________________________

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Решение:

/* void f(int n, ref int result)
{

    for(int i = 1; i <= n; i++)
        result *= i; // summ = summ + i
    
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 1;
f(n, ref result);
Console.Write(result); */

// ______________________________________________________________________________________________________________________

// Задвть и вывести массив из 8 элементов состоящий из 1 и 0.

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 2); // [0, 1]

// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine($"[{string.Join(", ", array)}]");