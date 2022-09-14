// Задача 36: Задайте одномерный массив из случайных чисел.
//  Найдите сумму элементов массива, стоящих на нечетных позициях. 
// [3, 7, 23, 12] -> 19

int[] array = new int[9];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 20);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

void ArraySum(int[]ar)
{
   int sum = 0;
   {
       for (int i = 0; i < ar.Length; i ++)
       {
          if(i % 2  != 0)
          {
            Console.Write($"{ar[i]} ");
            sum += ar[i];
           }
        }      
    }
   Console.WriteLine($"Сумма: {sum} ");
}

ArraySum(array);