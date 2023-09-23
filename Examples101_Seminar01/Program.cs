// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Решение:

//Console.Write("Введите номер дня недели: ");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n==1) Console.WriteLine ("Понедельник");
// else if (n==2) Console.WriteLine ("Вторник");
//    else if (n==3) Console.WriteLine ("Среда");
//       else if (n==4) Console.WriteLine ("Четверг");
//           else if (n==5) Console.WriteLine ("Пятница");
//               else if (n==6) Console.WriteLine ("Суббота");
//                    else if (n==7) Console.WriteLine ("Воскресенье");
//

//_________________________________________________________________________________

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Решение:

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = n * (-1); i <= n; i++) // i++ -> i = i + 1
// Console.Write(i + " ");


// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

// Решение:

// Console.Write("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write (n%10);

// ДЗ №1
// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

// Решение:

// Console.Write("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > y) Console.WriteLine ("Число " + x + " - большее," + " а число " + y + " - меньшее.");
//    else if (x < y) Console.WriteLine ("Число " + y + " - большее," + "а число " + x + " - меньшее.");
//        else if (x == y) Console.WriteLine ("Числa " + x + " и " + y +" равны"); 

// ДЗ №2:
// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

// Решение:

// Console.Write("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int z = Convert.ToInt32(Console.ReadLine());
// int max = x;
// if (y > max) max = y;
// if (z > max) max = z;
// Console.Write("Максимальное число: " + max);