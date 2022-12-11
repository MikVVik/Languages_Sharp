// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 != 0 && number / 100 < 10)
{
    Console.WriteLine($"Number of hundreds = {number / 100}");
}
 else
{
    if (number / 100 != 0 && number / 100 > 10) 
{
   int step1 = number / 100; 
   int step2 = step1 % 10; 
    Console.WriteLine($"Number of hundreds = {step2}");
}
else
{
       Console.WriteLine("There is no 3rd digit");
}
}