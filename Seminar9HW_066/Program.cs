// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите первую цифру интервала: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую цифру интервала: ");
int n = Convert.ToInt32(Console.ReadLine());

SumOfElements( m, n);

void SumOfElements(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int sum = m;
    if (m == n) return 0;
  
        else 
        {
            m++;
            sum = m + SumMN(m, n);
            return sum;
        } 
}

