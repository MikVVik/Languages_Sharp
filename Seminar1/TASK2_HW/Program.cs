// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Enter the number A");
int numberA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number B");
int numberB= Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    int modx = numberA;
    Console.Write("max = "); Console.WriteLine(modx);
    int modn = numberB;
    Console.Write("min = "); Console.WriteLine(modn);
}
else 
{
    int modx = numberB;
    Console.Write("max = "); Console.WriteLine(modx);
    int modn = numberA;
    Console.Write("min = "); Console.WriteLine(modn);
}