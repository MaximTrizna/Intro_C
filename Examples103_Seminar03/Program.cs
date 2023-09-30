// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт число плоскости, в которой находится эта точка.

// string f(int x, int y)
// {
//     if (x > 0 && y > 0)
//         return "I";
//     else if (x < 0 && y > 0)
//         return "II";
//     else if (x < 0 && y < 0)
//         return "III";
//     return "IV";
// }
//  
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(x, y));

// __________________________________________________________________________________________________________________________

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// string f(int x)
// {
//     if (x == 1)
//         return "x > 0 & y > 0";
//     else if (x == 2)
//         return "x < 0 & y > 0";
//     else if (x == 3)
//         return "x < 0 & y < 0";
//     return "x < 0 & y > 0";
// }
// 
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// 
// Console.WriteLine(f(x));

// __________________________________________________________________________________________________________________________

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// 
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите число: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
// Console.WriteLine(d);

//_________________________________________________________________________________________________________

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4 */

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= n; i++)
//     Console.Write(Math.Pow(i, 2) + " ");

