// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите колличество чисел: ");
int col = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < col; i++)
{
    Console.Write($"Введите число: ");
    int num = int.Parse(Console.ReadLine());
    if (num > 0)
        count++;
}
Console.WriteLine($"Положительных чисел: {count}");