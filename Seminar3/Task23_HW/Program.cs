// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("enter N");
int N = Convert.ToInt32(Console.ReadLine());
if (N<=0)
{
   Console.WriteLine("enter N > 0"); 
}
else
{ 
    for (int i = 1; i <= N; i++)
{
  Console.WriteLine(i*i*i);
}
}