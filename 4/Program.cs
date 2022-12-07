//задача 4. Принимает на вход три числа и выдает максимальное из них

Console.Write("введите num1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("введите num2: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("введите num3: ");
int num3 = int.Parse(Console.ReadLine());
int max;
if (num1 >= num2)
{
    if (num3 >= num1)
    {
        max = num3;
    }
    else
    {
        max = num1;
    }
}
else
{
    if(num3>=num2)
    {
        max=num3;
    }
    else
    {
        max=num2;
    }
}
Console.WriteLine(max);