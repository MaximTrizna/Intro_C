// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Решение: 

/* void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9; 9]
}

void ReleaseArray(int[] array)
{
    int SumPos = 0;
    int SumNeg = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            SumPos += array[i];
        else 
            SumNeg += array[i];
    Console.WriteLine($"Сумма пол = {SumPos}, сумма отр = {SumNeg}");
}


Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array); */

// _______________________________________________________________________________________________________________

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Решение: 

/* void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9; 9]
}

void ReleaseArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
        array[i] *= -1;
}


Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]"); */

// _______________________________________________________________________________________________________________

// Задача 33: 
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Решение: 

/* void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10); // [-9; 9]
}

string ReleaseArray(int[] array, int k)
{
    for(int i = 0; i < array.Length; i++)
        if (array[i] == k)
            return "yes";
            
    return "no";

}


Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array, k)); */

// ______________________________________________________________________________________________________________________________________________________________________

// Задача 35:
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Решение: 

/* void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 200);
}

void ReleaseArray(int[] array)
{
    int k = 0;
        for(int i = 0; i < array.Length; i++)
        if (array[i] > 9 && array[i] < 100)
            k += 1;
        
    Console.WriteLine($"Сумма = {k}");
}

Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array); */

// _____________________________________________________________________________________________________________________________________________________________________

// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Решение: 

/* void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10); // [0, 199]
}


void ReleaseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2 + array.Length % 2 ; i++)
        Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
    // array[0]   array[array.Length - 1 - 0]
    // array[1]   array[array.Length - 1 - 1]
    // array[2]   array[array.Length - 1 - 2]
    // array[3]   array[array.Length - 1 - 3]
    // 0 1 2 3 4 5
    // 5 9 6 3 7 4
}

Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array); */

// _______________________________________________________________________________________________________________________________________________________________________
// Домашнее задагие:  

// ЗАДАЧА 1: 

// Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
// Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".
// Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.

// Аргументы, передаваемые в метод/функцию:
// '124, 378, 593, 821, 456'
// На выходе:
// Массив:
// 124     378     593     821     456 
// Количество четных элементов: 3

// Решение: 

/* using System;
public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
    // Введите свое решение ниже
        int m = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] % 2 == 0)
            m += 1;
        return m;
    }

    public static void PrintArray(int[] array)
    {
    // Введите свое решение ниже
        Console.WriteLine($"{string.Join("\t", array)}\t");
    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}
 */

 // _______________________________________________________________________________________________________________________________________________________________________

 // ЗАДАЧА 2: 

// Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".
// Аргументы, передаваемые в метод/функцию:
// '18, 76, 11'
// На выходе:
// 18      76      11  
// Сумма нечетных элементов: 76

// Решение: 
/* 
using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
// Введите свое решение ниже
        int m = 0;
        for (int i = 0; i < array.Length; i++)
            if (i % 2 != 0)
            m += array[i];
        return m;

    }

    public static void PrintArray(int[] array)
    {
         // Введите свое решение ниже
        Console.WriteLine($"{string.Join("\t", array)}\t");

    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}
 */

// _______________________________________________________________________________________________________________________________________________________________________

// ЗАДАЧА 3:

// Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу 
// между максимальным и минимальным числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.
// Аргументы, передаваемые в метод/функцию:
// '3.17, 8.94, 2.36, 5.72, 0.85'
// На выходе:
// Массив:
// 3.17    8.94    2.36    5.72    0.85    
// Разность между максимальным и минимальным элементом = 8.09

// Решение: 

/* using System;

public class Answer
{
    public static double FindMax(double[] array)
    {     // Введите свое решение ниже
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
            if (array[i] > max)
            max = array[i];
        return max;       
    }

    public static double FindMin(double[] array)
    {     // Введите свое решение ниже
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
            if (array[i] < min)
            min = array[i];
        return min;       
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {// Введите свое решение ниже
        double m = FindMax(array) - FindMin(array);
        return m;
    }

    public static void PrintArray(double[] array)
    {// Введите свое решение ниже

        // Console.WriteLine($"{string.Join("\t", array)}\t");
       
        for (int i=0 ; i < array.Length ; i++)
        Console.Write($"{array[i]:f2}\t");
        Console.WriteLine();
    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
} */
