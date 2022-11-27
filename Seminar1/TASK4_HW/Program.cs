// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter the number A");
int numberA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number B");
int numberB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number C");
int numberC= Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine(numberA);
}
if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine(numberB);
}
if (numberC > numberA && numberC > numberB)
{
    Console.WriteLine(numberC);
}