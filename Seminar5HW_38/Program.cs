// Задача 38: Задайте  массив вещественных чисел.
//  Найдите разницу между макcимальным и минимальным элементами массива. 
// [3 7 22 2 78] -> 76

double[] array = new double[9];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 20);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

void MinNumber (double[]ar)
{
   double min = ar[0];
    {
       for (int i = 1; i < ar.Length; i ++)
       {
          if( ar[i] < min)
          {
            min = ar[i];
          }
        }  
        Console.Write($"Min число: {min} ");    
    }
}

Console.WriteLine();

void MaxNumber (double[]ar)
{
   double max = ar[0];
    {
       for (int i = 1; i < ar.Length; i ++)
       {
          if( ar[i] > max)
          {
            max = ar[i];
          }
        }  
        Console.Write($"Max число: {max} ");    
    }
}

Console.WriteLine();

 void DiffNumber (double[]arr)
{
    double sum = 0;
    {
        for (int i = 1; i < arr.Length; i ++)
        {
            sum = max - min;
        }
    }
    Console.WriteLine($"{sum}   "); 
}
MinNumber(array);
MaxNumber(array);
DiffNumber(array);


            
   
    
           
