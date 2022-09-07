// Программа выводит на экран третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 645-5, 78 - третьей цифры нет, 32676 -6.

// int num;

Console.WriteLine("Введите число: ");   
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    int i = num;
    while (i > 999) 
    {
        i = i / 10;

    }
    Console.WriteLine(i % 10);
     i++;
} 
else 
{
    Console.WriteLine("третьей цифры нет");
}