//задача 6. на вход принимает число и выдает, является ли оно четным 

Console.WriteLine("введите число A: ");
int A = int.Parse(Console.ReadLine());


if (A%2 == 0)
{
    Console.WriteLine($"Число {A} - четное");
}
else
{
    Console.WriteLine($"Число {A} - нечетное");
}