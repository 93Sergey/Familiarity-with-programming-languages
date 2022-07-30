// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillArray(int m, int n)
{
    double[,] doubleArray = new double[m, n];
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i, j] = new Random().NextDouble() * 5;
        }
    }
    return doubleArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(array[i, j], 1) + " ");
        }
        System.Console.WriteLine();
    }
}
System.Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int table = Convert.ToInt32(Console.ReadLine());
PrintArray(FillArray(line, table));