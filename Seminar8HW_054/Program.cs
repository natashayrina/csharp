// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите размер массива: количество строк, затем количество столбцов:   ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
    }
    Console.WriteLine();
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

PrintArr(arr);
Console.WriteLine();

void ReplacementLine(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int d = 0; d < arr.GetLength(1) - 1; d++)
            {
                if (arr[i, d] < arr[i, d + 1])
                {
                    int help = 0;
                    help = arr[i, d];
                    arr[i, d] = arr[i, d + 1];
                    arr[i, d + 1] = help;
                }
            }
        }

    }

}

Console.WriteLine();
ReplacementLine(arr);
PrintArr(arr);
