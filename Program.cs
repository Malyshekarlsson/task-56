/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int sum = 0;
int sum_min = 10000;
int line_min = 0;
int count = 0;
while (count < array.GetLength(0))
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[count, j];
    }
    if (sum < sum_min)
    {
        sum_min = sum;
        line_min = count;
    }
    count++;
    sum = 0;
}
Console.WriteLine($"{line_min + 1}-ая строка с наименьшей суммой элементов, равной {sum_min} ");