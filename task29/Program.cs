/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


int[] array;


int[] result = GetBinaryArray(8);
Console.WriteLine($"[{String.Join("; ", result)}]");

int[] GetBinaryArray(int size)
{

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(150);
    }
    return array;
}