/* Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11   // 4 + 5 + 2 = 11
82 -> 10
9012 -> 12
*/

// using System;

// class Program
// {
//     static int SumDigit(int digit)
//     {
//         int sumDigit = 0;
//         while (digit != 0)
//         {
//             sumDigit += Math.Abs(digit % 10);
//             digit /= 10;
//         }
//         return sumDigit;
//     }

//     static void Main(string[] args)
//     {
//         string variant = "+";
//         while (variant == "+") // до тех пор, пока значение переменной variant будет равно да => +
//         {
//             Console.Write("Введите число = ");
//             int input = Convert.ToInt32(Console.ReadLine());
//             int result = SumDigit(input);
//             Console.WriteLine($"Сумма цифр в числе {input} равна {result}.");

//             Console.Write("Хотите продолжить? (да => + / нет => любая клавиша): ");
//             variant = Console.ReadLine().ToLower();

//             if (variant != "+")
//             {
//                 Console.WriteLine("Программа завершена.");
//             }
//         }
//     }
// }



int SumDigit(int digit)
{
    int sum = 0;


    if (digit < 0)
    {
        digit = -digit;
    }
    for (; digit > 0; digit /= 10)
    {
        sum += digit % 10;
    }

    return sum;
}
Console.Write("Введите число = ");
int input = Convert.ToInt32(Console.ReadLine());
int result = SumDigit(input);
Console.WriteLine($"Сумма цифр в числе {input} равна {result}.");


