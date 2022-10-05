// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[arrayLength];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-100, 100);
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

int SumNechetPoz = 0;
for (int i = 1; i < array.Length; i += 2)
    SumNechetPoz = SumNechetPoz + array[i];

Console.WriteLine("Сумма элементов массива, стоящих на нечётных позициях, равна " + SumNechetPoz + ".");