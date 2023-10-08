﻿// Задача 39: 
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Решение:
/* 
void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10); // [0, 199]
}


void ReleaseArray(int[] array)
{
    int temp = 0;
    for(int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
 */

//________________________________________________________________________________________________________________________________________________________________________

// Задача 40: 
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// Ввод элементов цикла с консоли:

// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.WriteLine($"[{string.Join(", ", size)}]");

// // "1 2 3 4 5"
// // "1", "2", "3", "4", "5"
// // 1, 2, 3, 4, 5
// // [1, 2, 3, 4, 5]
/* 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (size[0] < size[1] + size[2] &&
    size[1] < size[0] + size[2] &&
    size[2] < size[1] + size[0])
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
 */
 //________________________________________________________________________________________________________________________________________________________________________

// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Решение:

/* 
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string res = String.Empty;

while (n > 0)
{
    res = Convert.ToString(n % 2) + res;
    n /= 2;
}
Console.Write(res);
*/

//________________________________________________________________________________________________________________________________________________________________________

// Задача 44: 
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Решение:
/* 
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x0 = 0;
int x1 = 1;
int x2 = x0 + x1;

for (int i =0; i < n; i++)
{
    Console.Write($"{x0} ");
    x2 = x0 + x1;
    x0 = x1;
    x1 = x2;
}
 */
//________________________________________________________________________________________________________________________________________________________________________

// Задача 45: 
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// Решение:
/* 
void copy(int[] arr, int[] newArr) 
{
    for(int i = 0; i < arr.Length; i++) {
        newArr[i] = arr[i];
    }
}
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[] newArr = new int[array.Length];
copy(array, newArr);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", newArr)}]");
 */

 //________________________________________________________________________________________________________________________________________________________________________

 // Домашнее задание:

//  Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Решение:


//________________________________________________________________________________________________________________________________________________________________________

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решение:


//________________________________________________________________________________________________________________________________________________________________________