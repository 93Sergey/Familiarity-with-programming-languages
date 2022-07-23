// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] arrayRealNumbers = new double[4];

for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = new Random().NextDouble() * 10;
    arrayRealNumbers[i] = Math.Round(arrayRealNumbers[i], 2);
}
double maxNumbers = arrayRealNumbers[0];
double minNumbers = arrayRealNumbers[0];
for (int i = 0; i < arrayRealNumbers.Length; i++)
    if (maxNumbers < arrayRealNumbers[i])
    {
        maxNumbers = arrayRealNumbers[i];
    }
    else if (minNumbers > arrayRealNumbers[i])
    {
        minNumbers = arrayRealNumbers[i];
    }

double difference = maxNumbers - minNumbers;
System.Console.WriteLine("[" + string.Join(", ", arrayRealNumbers) + "]" + " -> " + Math.Round(difference,2));