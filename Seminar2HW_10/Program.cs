// Вход трехзначное число, выход показывает вторую цифру этого числа. 456 - 5, 782 - 8, 918 - 1.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 100 * 100;
int num2 = num % 10;
int num3 = (num - num1 - num2) / 10;

Console.WriteLine(num3);



