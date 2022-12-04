// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("enter X1");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter Y1");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter Z1");
double Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter X2");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter Y2");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter Z2");
double Z2 = Convert.ToInt32(Console.ReadLine());

double resX = Math.Pow(X2 - X1,2);
double resY = Math.Pow(Y2 - Y1,2);
double resZ = Math.Pow(Z2 - Z1,2);
double res = Math.Sqrt(resX + resY +resZ);
Console.WriteLine($"{res:f3}");