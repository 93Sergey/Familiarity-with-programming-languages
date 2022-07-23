// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[,] arrayValue = new double[2, 2];
double[] xAndIntersectionPoint = new double[2];


void inputArray(double[,] arr)
{
    System.Console.Write("Введите значение b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите значение b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите значение k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите значение k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    arr[0, 0] = b1;
    arr[0, 1] = b2;
    arr[1, 0] = k1;
    arr[1, 1] = k2;
}

void result(double[,] arr)
{
    xAndIntersectionPoint[0] = (arr[0, 1] - arr[0, 0]) / (arr[1, 0] - arr[1, 1]);
    xAndIntersectionPoint[1] = arr[1, 0] * xAndIntersectionPoint[0] + arr[0, 0];
}
inputArray(arrayValue);
result(arrayValue);
System.Console.WriteLine($"b1 = {arrayValue[0, 0]}, k1 = {arrayValue[1, 0]}, b2 = {arrayValue[0, 1]}, k2 = {arrayValue[1, 1]} -> ({xAndIntersectionPoint[0]}; {xAndIntersectionPoint[1]})");
