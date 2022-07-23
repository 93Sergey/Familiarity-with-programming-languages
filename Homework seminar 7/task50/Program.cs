// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int table = Convert.ToInt32(Console.ReadLine());

int product = line * table;

System.Console.Write($"Введите искомую позицию числа, от 0 до {product - 1}: ");
int number = Convert.ToInt32(Console.ReadLine());

int[,] doubleArray = new int[line, table];

int[,] FillArray(int[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i, j] = new Random().Next(1, 10);
        }
    }
    return doubleArray;
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


int[] numbersList = new int[product];

void Transformation1Darray(int[,] array2D, int[] array1D)
{
    int index = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array1D[index] = array2D[i, j];
            index++;
        }
    }
}

void PrintResult(int[] array1D)
{
    int numbers = 0;
    for (int i = 0; i < array1D.Length; i++)
    {
        if (number == i)
        {
            numbers = array1D[number];
            System.Console.WriteLine($"На позиции {number}, находится число -> {numbers}");
            break;
        }
        else if (number < 0 || number > array1D.Length - 1)
        {
            System.Console.WriteLine($"{number} - > такой позиции в массиве нет!!! Введите существующую позицию от 0 до {array1D.Length - 1}");
            break;
        }
    }
}


FillArray(doubleArray);
PrintArray(doubleArray);
Transformation1Darray(doubleArray, numbersList);
PrintResult(numbersList);