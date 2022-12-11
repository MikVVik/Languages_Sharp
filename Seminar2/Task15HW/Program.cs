// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number between 1 and 7");
int number= Convert.ToInt32(Console.ReadLine());

if (number < 6 && number > 0)
{
    Console.WriteLine("WORK HARD - IT'S A WORKING DAY!");
}
else 
{
   if (number >= 6 && number <= 7)
{
    Console.WriteLine("RELAX! TAKE IT EASY! IT'S A WEEKEND, BABY!");
}
else
{
    Console.WriteLine("ARE YOU SURE? ENTER THE NUMBER !!BETWEEN 1 AND 7!!");
}
}