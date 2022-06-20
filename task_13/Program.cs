/*Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа
 или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число"); 
int x = int.Parse(Console.ReadLine()); 

if (x < 100)
{
    Console.WriteLine("Нет третьего числа");
}
else 
{ 
    while (x >= 1000){x = x / 10;}
}
int num3 = x % 10;
Console.WriteLine(num3);