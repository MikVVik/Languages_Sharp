﻿// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

Console.WriteLine(number * number);