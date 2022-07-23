// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
int[,] FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void LineNumberMinSum(int[,] matrix)
{
    System.Console.WriteLine();
    int[] SumLineArray = new int[matrix.GetLength(0)];
    int minValueLine = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumLineMatrix = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumLineMatrix += matrix[i, j];
        }
        // System.Console.WriteLine($"в строке {i + 1} сумма элементов = {sumLineMatrix}");
        SumLineArray[i] = sumLineMatrix;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (SumLineArray[i] < SumLineArray[minValueLine])
        {
            minValueLine = i;
        }
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minValueLine + 1}");
    System.Console.WriteLine();

}


Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int table = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[line, table];
matrix = FillMatrix(matrix);
PrintMatrix(matrix);

LineNumberMinSum(matrix);
