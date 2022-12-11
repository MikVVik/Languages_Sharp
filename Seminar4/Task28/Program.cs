// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


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
int Mult1toA(int A)
{
    int mult = 1;
    for (int i = 1; i <= A; i++)
    {
        mult = mult * i;  
    }
    return mult;
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
    int mult = Mult1toA(number);
    Console.WriteLine($"Mult from 1 to {number} = {mult}");
}
else
{
    Console.WriteLine($"Mission is impossible to get the mult from 1 to {number}");
}

