﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int step1 = number / 10;
int step2 = step1 % 10;

Console.WriteLine($"Digit2 = {step2}");
