//Напишите цикл, который принимает два числа А И В, и возводит А в натуральную степень В.

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int i = 1;
int res = 1;

while (i <= B)
{
    res = (res * A);
    Console.WriteLine(res);
    i++;
}
