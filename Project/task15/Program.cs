﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным."); 
Console.WriteLine("Введите число: ");

// 1 -> понедельник
// 2 -> вторник
// 3 -> среда
// 4 -> четверг
// 5 -> пятница
// 6 -> суббота
// 7 -> воскресенье

var number = Convert.ToInt32(Console.ReadLine());

if(number > 0){

    if(number < 6) Console.WriteLine("нет");
    if(number == 6 || number == 7) Console.WriteLine("да");
}
else Console.WriteLine("Повторите и введите значение..");

