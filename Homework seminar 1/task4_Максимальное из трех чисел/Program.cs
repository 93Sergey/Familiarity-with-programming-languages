//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("numberA = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("numberB = ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("numberC = ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA >= numberB && numberA >= numberC)
{
    Console.WriteLine($"{numberA},{numberB},{numberC}: max = {numberA}");
}
else if (numberB >= numberA && numberB >= numberC)
{
    Console.WriteLine($"{numberA},{numberB},{numberC}: max = {numberB}");
}
else if (numberC >= numberA && numberC >= numberB)
{
    Console.WriteLine($"{numberA},{numberB},{numberC}: max = {numberC}");
}