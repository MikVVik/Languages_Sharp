// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// AB = √(xb - xa)2 + (yb - ya)2

Console.WriteLine("enter XA");
double XA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter YA");
double YA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter XB");
double XB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter YB");
double YB = Convert.ToInt32(Console.ReadLine());

double resX = Math.Pow(XB - XA,2);
double resY = Math.Pow(YB - YA,2);
double res = Math.Sqrt(resX + resY);
Console.WriteLine($"{res:f3}");