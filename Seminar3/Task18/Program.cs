// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("enter the quarter");
int n = Convert.ToInt32(Console.ReadLine());


if (n == 1)
{
    Console.WriteLine("x > 0 & y > 0");
}

else if (n == 2)
{
    Console.WriteLine("x < 0 & y > 0");
}

else if (n == 3)
{
    Console.WriteLine("x < 0 & y < 0");
}


else if (n == 4 )
{
    Console.WriteLine("x > 0 & y < 0");
}

else
{
    Console.WriteLine("the quarter is in some other demension");
}