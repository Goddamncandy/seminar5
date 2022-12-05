// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[5];

void FillArray(int [] numbers)
{
    int length = numbers.Length;
    int i = 0;
    while (i < length)
    {
        numbers[i] = new Random().Next(100, 1000);
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
int count = 0;
int length = array.Length;
while (index < length)
{
   if (array[index] % 2 == 0)
  { 
    count++;
    index++;
  }
  else
  index++;
}
Console.WriteLine($"Количество четных чисел в массиве равно " + count);