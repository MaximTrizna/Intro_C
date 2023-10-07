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
// int number = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= number; i++)
//     Console.Write(Math.Pow(i, 2) + " ");

// _____________________________________________________________________________________________________________.

// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет,
// является ли оно палиндромом. Метод должен проверить является ли число пятизначным, в противном случае - вывести
// "Число не пятизначное" и False в следующей строке.
// Для остальных чисел вернуть True или False.

// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False

// Решение :

/* bool Validate (int number)
    {
        if (number > 99999 || number < 10000)
        {
            Console.WriteLine("Число не пятизначное");
            Console.Write("False");
            return false;
        }
        else if (number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10)
        {
            Console.Write("True");
            return true;
        }
        Console.Write("False");
        return false;
    }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Validate (number); */

//___________________________________________________________________________________________________________

// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек 
// pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

// d = √ (x2 - x1)² + (y2 - y1)² + (z2 - z1)²

// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Решение 1:

/* Console.Write("Введите число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2)), 2);
Console.WriteLine(d); */

// Решение 2:
/* 
public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
        double d = Math.Round(Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2)+ Math.Pow(pointB[2] - pointA[2], 2)), 2);
        return d;
    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
} */

//___________________________________________________________________________________________________________

// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов
// чисел от 1 до N (включительно) каждое на новой строке.

// N = 3 
// /*
// 1
// 8
// 27
// */

// N = 5
// /*
// 1
// 8
// 27
// 64
// 125
// */

// Решение:

/* public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
      for (int i = 1; i <= N; i++)
        Console.WriteLine(Math.Pow(i, 3));
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}
 */
//___________________________________________________________________________________________________________