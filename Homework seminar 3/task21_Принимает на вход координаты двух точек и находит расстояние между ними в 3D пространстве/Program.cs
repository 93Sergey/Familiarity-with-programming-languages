/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
//D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2).
Console.Write("Введите координаты A первой точки: ");
int pointX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты A второй точки: ");
int pointY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты A третей точки: ");
int pointZ1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты B первой точки: ");
int pointX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты B второй точки: ");
int pointY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты B третей точки: ");
int pointZ2 = Convert.ToInt32(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(pointX2 - pointX1, 2) + Math.Pow(pointY2 - pointY1, 2) + Math.Pow(pointZ2 - pointZ1, 2));
Console.WriteLine($"A ({pointX1},{pointY1},{pointZ1}); B ({pointX2},{pointY2},{pointZ2}) -> {Math.Round(distance, 2)}");