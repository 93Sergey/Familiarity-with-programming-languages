/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}

if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine(string.Join("", array) + "-> да");
}
else
{
    Console.WriteLine(string.Join("", array) + "-> нет");
}

