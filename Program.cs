// Урок 6. Одномерные массивы. Продолжение
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Input number for fill array: ");
//         int numb = Convert.ToInt32(Console.ReadLine());
//         array[i] = numb;
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// void Positive(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         count ++;
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Count of positive numbers is {count}");
// }


// Console.WriteLine("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// PrintArray(array);
// Positive(array);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void Equation(double b1, double k1, double b2, double k2)
// {
//     double x = (-b2 + b1) / (-k1 + k2);
//     double y = k2 * x + b2;
//     Console.WriteLine($"{y} and {x}");
// }

// Console.WriteLine("Input b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// Equation(b1, k1, b2, k2);

