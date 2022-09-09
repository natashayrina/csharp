// Напишите программу, которая принимает число и выдает сумму цифр этого чисоа. 452 - 11, 82 - 10, 9012 - 12.


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0; //   остаток от деления
int sum = 0;    //  значение суммы

while (num > 0)
{
    num1 = num % 10;
    if (num1 != 0)
    {
        sum +=num1;
    }
num = num / 10;
}
Console.WriteLine (sum);
