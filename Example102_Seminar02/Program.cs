﻿// Задача 1: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Решение :

// int n = new Random().Next(10, 100); // [10, 99]
// Console.WriteLine("Рандомное число " + n);

// int n1 = n / 10; // 78 / 10 = 7
// int n2 = n % 10; // 78 % 10 = 8

// if (n1 > n2)
//     Console.WriteLine(n1);
// else
//    Console.WriteLine(n2);

// ___________________________________________________________________________________________________________________

// Задача 2: Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// Решение :

// int n = new Random().Next(100, 1000);
// Console.WriteLine("Рандомное число " + n);
// int n1 = n / 100;
// int n2 = n % 100;
// int n3 = n2 % 10;
// Console.WriteLine(n1);
// Console.WriteLine(n3);

// ___________________________________________________________________________________________________________________

// Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Решение :

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n % 7 == 0 && n % 23 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// _______________________________________________________________________________________________________________________________

// Задача 4: Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Решение :

// Console.WriteLine("Проверяем кратность чисел.");
// Console.Write("Введите число 1: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n % m == 0) 
//     Console.WriteLine("Число 1 кратно числу 2");
// else
//     Console.WriteLine($"Число 1 не кратно числу 2, остаток от деления: {n % m}");

// ___________________________________________________________________________________________________________________________

// Задача 5: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Решение :

// Console.Write("Введите число 1: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (m * m == n || n * n == m) 
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// ДОМАШНЕЕ ЗАДАНИЕ:

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение :

// Found: Console.Write("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 1000 && n >= 100)
//     Console.Write((n / 10) % 10);
// else
//     goto Found;

// _____________________________________________________________________________________________________________


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Решение :

// int f (String Msg)
//     {
//     Console.Write(Msg);
//     int Result = Convert.ToInt32(Console.ReadLine());
//     return Result;
//     }

        int G(int n)
        {
            while (n > 999)
            {
                n /= 10;
            }
            return n % 10;
        }

        // bool V (int n)
        //     {
        //         if (n < 100)
        //         {
        //         Console.Write("Третьей цифры нет");
        //         return false;
        //         }
        //         return true;
        //     }

        // int n = f ("Введите число: ");

        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 100)
            Console.Write("Третьей цифры нет");
        else
        {
            Console.WriteLine(G(n));
        }
   
// _____________________________________________________________________________________________________________

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Решение :




// _____________________________________________________________________________________________________________