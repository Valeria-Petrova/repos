// задача 2. принимает 2 числа и выдает какое больше, какое меньше
Console.WriteLine("введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B: ");
int B = int.Parse(Console.ReadLine());
if (A > B)
{
    Console.WriteLine($"число A -{A} -> max");
}
if (B > A)
{
    Console.WriteLine($"число B -{B} -> max");
}