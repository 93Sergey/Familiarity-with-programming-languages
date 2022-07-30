// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("number = ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
    Console.WriteLine($"number = {a}: является четным числом");
else
    Console.WriteLine($"number = {a}: не является четным числом");