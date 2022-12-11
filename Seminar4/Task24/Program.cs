// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

bool Validate(int number)
{
    if (number > 1)
    {
        return true;
    }    
    else
    {
        return false;
    }
}
int Sum1toA(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;  // sum = sum + i; the same meaning - the longer writing 
    }
    return sum;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
    
int number = GetNumber("Enter the number");
bool IsCorrect = Validate(number);
if (IsCorrect == true)
{
    int sum = Sum1toA(number);
    Console.WriteLine($"Summ from 1 to {number} = {sum}");
}
else
{
    Console.WriteLine($"Mission is impossible to get the summ from 1 to {number}");
}

