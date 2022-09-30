// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите количество строк, затем количество столбцов:   ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
int[,] arrSecond = new int[m, n];
int[,] arrResult = new int[m, n];


void FillArrRandom (int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
    }
}
}
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine ();
    }
}

void ResultArray (int [,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arrSecond.GetLength(1); j++)
    {
        arrResult[i,j] = 0;
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            arrResult[i, j] += arr[i, k] * arrSecond[k, j];
        }
    } 
   
}
 return;

if (arr.GetLength(0) != arrSecond.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
}
FillArrRandom(arr);
PrintArr(arr);
Console.WriteLine();

FillArrRandom(arrSecond);
PrintArr(arrSecond);
Console.WriteLine();

ResultArray(arr);
PrintArr(arrResult);

