// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

Console.Write("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine() ?? "0");
double[] array = new double[arrayLength];

double [] FillArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 20 - 10, 2);
return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}

void DiffMaxMin(double[] array)
{
    double Max = array[0];
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
        else if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + (Max - Min));
}

FillArray(array);
PrintArray(array);
DiffMaxMin(array);

