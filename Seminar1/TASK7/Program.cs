//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Enter the three-digit number");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int mod = number % 10;
    Console.WriteLine(mod);
    Console.WriteLine("SUCCESS!");
}
else
{
    Console.WriteLine("REALLY? ENTER THE !!THREE-DIGIT!! NUMBER");
    Console.WriteLine("LOOSER!!");
}