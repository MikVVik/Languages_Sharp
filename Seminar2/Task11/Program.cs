// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int digit2 = number % 10;
int digit1 = number / 100;

Console.WriteLine($"The result = {digit1 * 10 + digit2}");
