//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число num: ");
int num = int.Parse(Console.ReadLine());
if (num > 10000 && num < 100000)
{
    int num1 = num % 10;
    int num2 = num / 10000;
    int num31 = num / 10;
    int num3 = num31 % 10;
    int num41 = num / 1000;
    int num4 = num41 % 10;
   
    if ((num1 == num2) && (num3 == num4))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
    
}
else 
{
    Console.WriteLine("введено неверное число");
}

