// Напишите программу, которая на вход принимает число и выдает, является ли число четным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
int mod = number % 2;

if (mod == 0)
{
    Console.WriteLine("EVEN NUMBER");
}
else
{
    Console.WriteLine("ODD NUMBER");
}