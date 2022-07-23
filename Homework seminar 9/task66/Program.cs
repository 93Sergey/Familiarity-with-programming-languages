// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();


int SumOfNumbersFromMToN(int M, int N)
{
    if (N == M) return M;
    return SumOfNumbersFromMToN(M, N - 1) + N;
}
System.Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"M = {numM}; N = {numN} -> {SumOfNumbersFromMToN(numM,numN)}");
