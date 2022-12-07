// задача 15. принимает цифру обозначающую день недели, и проверяет, явл. ли этот день выходным
// 6 -> да 7 ->да 1 -> нет

Console.WriteLine("Введите номер недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if(numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Введен неправильный номер");
    return;
}
if(numberDayOfWeek == 1 || numberDayOfWeek == 2 || numberDayOfWeek == 3 || numberDayOfWeek == 4 || numberDayOfWeek == 5)
{
    Console.WriteLine("нет");
}
if(numberDayOfWeek == 6 || numberDayOfWeek == 7)
{
    Console.WriteLine("да");
}