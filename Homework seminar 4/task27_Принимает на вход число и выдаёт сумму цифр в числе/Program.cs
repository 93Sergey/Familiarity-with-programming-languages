/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numbersString = number.ToString();

int SumNumber(string strings)
{
    int sum = 0;
    for (int i = 0; i < numbersString.Length; i++)
    {
        sum += Convert.ToInt32(numbersString[i].ToString());
    }
    return sum;

}
System.Console.WriteLine($"{numbersString} -> {SumNumber(numbersString)}");