//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> такого числа в массиве нет 

Console.WriteLine("Введите размер массива: количество строк, затем количество столбцов:   ");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int[rows, cols];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10);
        Console.Write ($"{arr[i, j]}   ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите координаты: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
object c = arr.GetValue(a,b);

if (a < arr.GetLength(0) && b < arr.GetLength(1))
{
  Console.WriteLine(c);
} 
else 
{
  Console.WriteLine($"{a}{b} такого числа в массиве нет ");
}






 
//  

//  Console.WriteLine("Введите координаты");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>rows && b>cols)
//  {
//   Console.Write($"{rows}{cols} такого числа нет");
//  }
//   else
//  {
//  object c = array.GetValue(a,b);
//  Console.WriteLine(c);
//  }