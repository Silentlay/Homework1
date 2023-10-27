/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.

Примеры:

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// using System;

// class Program
// {
//     static int CalculatePow(int A, int B)
//     {
//         return (int)Math.Pow(A, B);
//     }

//     static void Main()
//     {
//         string variant = "+";
//         while (variant == "+")
//         {
//             Console.Write("Введите число   A = ");
//             int A = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Введите степень B = ");
//             int B = Convert.ToInt32(Console.ReadLine());
// //          //Console.WriteLine(CalculatePow(A, B));
//             Console.WriteLine($"{A} в степени \t{B} = {CalculatePow(A, B)}");

//             Console.Write("Хотите продолжить? (да => +   /   нет => любая клавиша на клавиатуре): ");
//             variant = Console.ReadLine().ToLower();

//             if (variant != "+")
//             {
//                 Console.WriteLine("Программа завершена.");
//             }
//         }
//     }
// }

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{A} в степени {B} = {RaiseToDegree(A, B)}");
int RaiseToDegree(int number, int power)
{
    int res = 1; // Переменная с результатом
    for (int i = 0; i < power; i++)
    {
        res *= number; // 2 в 3 степени: Число 2 умножить
    }
    return res;
}