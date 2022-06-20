/*Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите номер дня недели (1-7): ");
int NWeek = int.Parse(Console.ReadLine());

if (NWeek > 0 && NWeek < 8)
{
    if(NWeek == 6 || NWeek == 7)
    {Console.WriteLine("Выходной день");}

    else
    {Console.WriteLine("Рабочий день");}
}
else 
{
    Console.WriteLine("Ошибка, введите число от 1 до 7");
}