// Программа принимает цифру, которая обозначает день недели, и проверяет, является ли этот день выходным.
// int num;

Console.WriteLine("Введите число от 0 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1 && num < 6)
{
    Console.WriteLine ("это будний день");
}
else
{
    Console.WriteLine ("выходной!");
}