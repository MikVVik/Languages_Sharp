// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Enter the number A");
int numberA= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number B");
int numberB= Convert.ToInt32(Console.ReadLine());

if (numberA % numberB == 0)
{
    Console.WriteLine("NumberA is a multiple of numberB");
}
else
{
    Console.WriteLine($"The balance = {numberA % numberB}");
}