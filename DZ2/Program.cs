/*Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
*/
int x1 = new Random().Next(0,1000);
int x2 = x1 % 10;
int x3 = (x1/10) % 10;
int x4 =x1 / 100;

Console.WriteLine(x1);
Console.Write($"{x3}"); 

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
