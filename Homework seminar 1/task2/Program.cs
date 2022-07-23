//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"max = {a}: min = {b}");
if (b > a)
    Console.WriteLine($"max = {b}: min = {a}");


