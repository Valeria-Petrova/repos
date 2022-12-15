// задача 8. число N и на выходе показывает все четные числа от 1 до N
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int A = 1;

while (A <= N)
{
    if (A%2 == 0)
    Console.WriteLine($"{A} ");
    A++;
}
