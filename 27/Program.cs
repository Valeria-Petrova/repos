﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11    82 -> 10     9012 -> 12

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
//Console.WriteLine("Сумма = {0}", sum);
Console.WriteLine($"сумма цифр числа {number} = {Summa(number)}");


int Summa(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum=sum+number%10;
        number/=10;
    }
    return sum;
}


