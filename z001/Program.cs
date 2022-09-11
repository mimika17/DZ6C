// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Количество вводимых чисел");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Введите числа");

int[] FillArray(int[] collection)
{
    int b = collection.Length;
    int index = 0;
    while (index < b)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    return collection;
}
int AboveZero(int[] arr)
{
    int j = 0;
    foreach (int i in arr)
    {
        if (i < 0)
        {
            j++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"чисел больше 0 ввёл пользователь {j}");
    return j;
}
FillArray(array);
AboveZero(array);
