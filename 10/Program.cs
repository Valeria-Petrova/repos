//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5

Console.WriteLine("Введите трехзначное число num: ");
int num = int.Parse(Console.ReadLine());
int num1 = num / 10;
int num2 = num1 % 10;

Console.WriteLine(num2);

