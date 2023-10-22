// **Задача 50.** Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// Решение:
/* 

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}


void ReleaseMatrix(int[,] matrix, int n)
{
    int n1 = n / 10;
    int n2 = n % 10;
    if (n1 > matrix.GetLength(0) || n2 > matrix.GetLength(1))
        Console.WriteLine("Такого элемента нет");
    else
        Console.WriteLine(matrix[n1, n2]);
}


Console.Clear();
Console.Write("Введите размер матрицы: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.Write("Введите позицию элемента: "); 
int n = Convert.ToInt32(Console.ReadLine());
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix, n); 
 */

// ______________________________________________________________________________________________________________

// **Задача 52.** Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Решение:
/* 
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}


void ReleaseMatrix(int[,] matrix)
{
    Console.WriteLine("Среднее арифмитическое столбцов:");
    double summa;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summa = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           summa += matrix[i, j];
        }
        Console.Write($"{Math.Round(summa /  matrix.GetLength(0), 2)}\t");
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
*/

// ______________________________________________________________________________________________________________
// ______________________________________________________________________________________________________________

// РЕКУРСИЯ:

/* 
int summa(int a, int b)
{
    if (b == 0)
        return a;
    return summa(a + 1, b - 1);
}
// 4 3
// 5 2
// 6 1
// 7 0
// 8 -1
// 9 -2

Console.Write("Введите элемент: "); 
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент: "); 
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(summa(a, b));
 */

// ______________________________________________________________________________________________________________

//  **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Решение:

/* 
string rec(int n)
{
    if (n == 0)
        return "";
    return rec(n - 1) + $"{n} ";
}
//                               rec(5)
//                         rec(4) + '5'
//                   rec(3) + '4'
//             rec(2) + '3'
//       rec(1) + '2'
// rec(0) + '1'
// ''


Console.Write("Введите элемент: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));
 */

// ______________________________________________________________________________________________________________

// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// Решение:

/* 
string rec(int m, int n)
{
    if (n == m)
        return $"{m} ";
    return rec(m, n - 1) + $"{n} ";
}

Console.Write("Введите элемент: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));
 */

// ______________________________________________________________________________________________________________

//  **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

// Решение:
/* 
int rec(int n)
{   
    if (n < 10)
        return n;
    return rec(n / 10) + n % 10;
}
Console.Write("Введите элемент: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));
 */
 // ______________________________________________________________________________________________________________

// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Решение:
/* 
int rec(int a, int b)
{
    if (b == 1)
        return a;
    return rec(a, b - 1) * a;
}
//                      rec(4, 3)
//              rec(4, 2) * 4
//      rec(4, 1) * 4
//      4


// rec(4, 0) * 4
// 1


Console.Write("Введите элемент: "); 
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент: "); 
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(a, b));
 */

// ______________________________________________________________________________________________________________