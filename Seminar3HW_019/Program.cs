// Напишите программу, которая на вход принимает 5-значное число и проверяет, является ли оно палиндромом.
// 14122 - нет, 23432 - да.

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 10000;
int num2 = num / 1000 % 10;

int num3 = num % 100 / 10;
int num4 = num % 10;

if (num1 == num4 && num2 == num3)
{
    Console.WriteLine ("это число палиндром");
}
 else
 {
    Console.WriteLine ("нет");
 }       

 
