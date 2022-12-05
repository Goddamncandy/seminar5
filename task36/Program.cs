// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[6];

void FillArray(int [] numbers)
{
    int length = numbers.Length;
    int i = 0;
    while (i < length)
    {
        numbers[i] = new Random().Next(-50, 100);
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

int index = 1;
int sum = 0;
int length = array.Length;
while (index < length)
{
    sum = sum + array[index];
    index = index + 2;
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна " + sum);