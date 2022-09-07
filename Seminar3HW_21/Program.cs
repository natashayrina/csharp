// Программа, принимает координаты 2-х точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите первую координату точки А (xa): ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки А (ya): ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату точки А (za): ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую координату точки B (xb): ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки B (yb): ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату точки B (zb): ");
int zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xb - xa,2) + Math.Pow(yb - ya,2) + Math.Pow(zb - za,2));
Console.WriteLine(Math.Round(result,2));