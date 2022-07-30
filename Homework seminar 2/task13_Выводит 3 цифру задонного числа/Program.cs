/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int number = new Random().Next(1, 99999);

if (number < 100)
{
    Console.WriteLine($"{number} -> третей цифры нет");
}

else if (number >= 100)
{
    string result = number.ToString();
    Console.WriteLine($"{number} -> {result[2]}");
}

/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit3 = -1; //несуществующее значение

while (number > 99)
{
    digit3 = number % 10;
    number = number / 10;
}

if (digit3 != -1)
{
    Console.WriteLine(digit3);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
*/