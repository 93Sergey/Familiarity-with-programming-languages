/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        {
            Console.WriteLine($"{day} -> нет");
            break;
        }
    case 2:
        {
            Console.WriteLine($"{day} -> нет");
            break;
        }
    case 3:
        {
            Console.WriteLine($"{day} -> нет");
            break;
        }
    case 4:
        {
            Console.WriteLine($"{day} -> нет");
            break;
        }
    case 5:
        {
            Console.WriteLine($"{day} -> нет");
            break;
        }
    case 6:
        {
            Console.WriteLine($"{day} -> да");
            break;
        }
    case 7:
        {
            Console.WriteLine($"{day} -> да");
            break;
        }
    default:
        {
            Console.WriteLine($"{day} -> такого дня недели не существует!! ");
            break;
        }
}