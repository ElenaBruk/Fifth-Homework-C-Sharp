// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[arrayLength];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i == arr.Length - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}

FillArray(array);
PrintArray(array);

int KolNechetChisel = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) KolNechetChisel++;
}

Console.WriteLine("Количество чётных чисел в массиве равно " + KolNechetChisel + ".");