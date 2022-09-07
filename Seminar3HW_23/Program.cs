// Программа принимает число (n) и выдает таблицу кубов чисел от 1 до n.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= num)
{
  Console.WriteLine (Math.Pow (i, 3));
  i++;  
}


