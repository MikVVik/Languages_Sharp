// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Диапазон от 0 до 150

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

const int SIZE = 123;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);

Console.WriteLine($"[{string.Join(", ", arr)}]");
int rez = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] <= 99 && arr[i] >=10)
    {rez ++;
    }
}

Console.WriteLine(rez); 