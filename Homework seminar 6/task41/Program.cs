// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Введите количество чисел: ");
int numberCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberCount];
void arrayInput(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}


void printResultArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine(string.Join(", ", arr) + " -> " + count);
}

arrayInput(array);
printResultArray(array);




