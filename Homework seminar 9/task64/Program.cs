﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void NumbersFromMtoN(int M, int N)
{
    if (M != (N - 1))
    {
        NumbersFromMtoN(M - 1, N);
        Console.Write(M + " ");
    }
}


System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());




System.Console.Write($" M = {M}; N = {N}. -> ");
Console.Write("\"\" ");
NumbersFromMtoN(N, M);
Console.Write("\"\"");
