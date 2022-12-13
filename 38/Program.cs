﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomNumbers(array);
Console.WriteLine("массив: ");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}


Console.WriteLine($"Разница между максимальным и минимальным значением {max}-{min} = {max - min}");

void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
