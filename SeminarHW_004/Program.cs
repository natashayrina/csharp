﻿// int num;

Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i = i + 1;
}







