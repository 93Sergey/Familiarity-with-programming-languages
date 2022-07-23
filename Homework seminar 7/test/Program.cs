// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int table = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[line, table];

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void result(int[,] array)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double arithmeticalMean = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arithmeticalMean = array[j, i];
        }
        System.Console.Write($"{arithmeticalMean}");
        if (i < array.GetLength(1) - 1)
        {
            System.Console.Write("; ");
        }
        else
        {
            System.Console.Write(".");
        }
    }
}

FillArray(matrix);
PrintArray(matrix);
result(matrix);