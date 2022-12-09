//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = GetArray(8);

Console.WriteLine($"->[{String.Join(",", array)}]");


int[] GetArray(int size)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0,100);
        Console.Write($" {res [i]}");
    }
    
    return res;
}
