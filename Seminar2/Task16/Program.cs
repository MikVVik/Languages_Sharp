// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Enter the number A");
int numberA= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number B");
int numberB= Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB || numberB * numberB == numberA)
{
    Console.WriteLine("Square is over here!");
}
else
{
    Console.WriteLine("Not a square at all!");
}