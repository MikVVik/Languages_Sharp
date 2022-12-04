// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("enter 5digit number");
int n = Convert.ToInt32(Console.ReadLine());
if (Length(n) < 5 || Length(n) > 5 )
{
    Console.WriteLine("enter 5digit number");
}