// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine(number);
int digit2 = number % 10;
int digit1 = number / 10;

Console.WriteLine($"first digit = {digit1}, second digit = {digit2}");


if (digit1 > digit2)
{
    Console.WriteLine($"max is {digit1}");
}
    
else
{
    Console.WriteLine($"max is {digit2}");
}
    