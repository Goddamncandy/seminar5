// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[4];

void FillArray(int [] numbers)
{
    int length = numbers.Length;
    int i = 0;
    while (i < length)
    {
        numbers[i] = new Random().Next(0, 100);
        i++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(collection[pos]);
        pos++;
    }
}

FillArray(array);
PrintArray(array);

int index = 0;
int max = 0;
int length = array.Length;

while (index < length)
{
    if (array[index] > max)
    {
        max = array[index];
        index++;
    }
    else
    index++;
}

int ind = 0;
int min = array[0];
int L = array.Length;

while (ind < L)
{
    if (array[ind] <= min)
    {
        min = array[ind];
        ind++;
    }
    else
    ind++;
}

int N = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = " + N);