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

// Задaть и вывести массив из 8 элементов состоящий из 1 и 0.

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 2); // [0, 1]

// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine($"[{string.Join(", ", array)}]");

// ______________________________________________________________________________________________________________________

// Домашнее задание: 

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Решение 1:

/* Console.Write ("Введите число A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число B: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("A в степени B = " + Math.Pow(n, m)); */

// Решение 2: 
/* 
void f (int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
        result*=A;
    Console.Write ($"A в степени B = {result}");
}
Console.Write ("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
f(A,B);
 */
// ______________________________________________________________________________________________________________________

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Решение:
/*
Console.Clear();
void f (int n)
{
    int result = 0;
    for (int i = n; i > 0; i/=10)
       result += i % 10; 
    // while (n > 0) {
    //     result += n % 10;
    //     n = n / 10;
    //     }
    Console.Write ("Сумма цифр в числе = " + result);
}
Console.Write ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
f(n);
 */

// ______________________________________________________________________________________________________________________

// Задача 29: Напишите программу, которая принимет на вход длинну массива, и далее задает элементы массива. Программа должна вывести массив
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]

// Решение:
/* 
void InputArray(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Нижняя граница выбора случайного числа: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница выбора случайного числа: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, min, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
 */
// ______________________________________________________________________________________________________________________