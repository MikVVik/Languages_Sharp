

Console.WriteLine("Enter X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Location - I Quarter");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("Location - II Quarter");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("Location - III Quarter");
}


else if (x > 0 && y < 0)
{
    Console.WriteLine("Location - IV Quarter");
}

else
{
    Console.WriteLine("Location not estimated - try again");
}
