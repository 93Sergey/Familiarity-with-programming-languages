// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int randomArray = new Random().Next(0, 10);
int[] array = new int[randomArray];
int sumNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    if (i % 2 != 0)
    {
        sumNumbers += array[i];
    }

}
System.Console.WriteLine("[" + string.Join(", ", array) + "]" + " -> " + sumNumbers);

