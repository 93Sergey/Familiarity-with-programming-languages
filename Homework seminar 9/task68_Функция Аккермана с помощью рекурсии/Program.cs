// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
Console.Clear();


int DefAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return DefAkkerman(m - 1, 1);
    return DefAkkerman(m - 1, DefAkkerman(m, n - 1));
}

System.Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {DefAkkerman(numberN, numberM)}");

