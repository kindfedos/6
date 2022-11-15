Console.Clear();
Console.WriteLine("введите значение a1");
double a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение a2");
double a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b2");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = (-a2 + a1)/(-b1 + b2);
double y = b2 * x + a2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
