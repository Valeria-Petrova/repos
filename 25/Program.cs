//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"число {A} в степени {B} = {GetNatDegree(B, A)}");


int GetNatDegree(int B, int A)
{
    int res1 = A;
    for (int i = 1; i < B; i++)
    {
        res1=res1*A;
    }
    return res1;
}

//void Print(int res1){
   // Console.WriteLine(res1);
//}
