//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

void PlusNumber (int[]newAr)
{
    int count = 0;
        {
        for (int k = 0; k < newAr.Length; k++) 
            {
                if (newAr[k] % 2 == 0)
                {
                    Console.WriteLine(newAr[k]);
                    count += 1; 
                }
            }       
    }
     Console.Write($"Четных чисел в массиве:{count}  " );  

}        
             
PlusNumber(array);      


