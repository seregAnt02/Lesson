﻿

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

int[] mas = {1,2,3,4,5,6,7,8,9};
string numberEven = ""; 

Console.WriteLine("Введите число от 1 - 9");
int n = Convert.ToInt32(Console.ReadLine());

for(int x = 0; x < mas.Length; x++){
    // проверяем условия на остаток и входящие значение.
    if (mas[x] % 2 == 0 && mas[x] <= n){
        
        string num = mas[x].ToString();        
        // проверяем условие и присваиваем значение переменной 
        numberEven += x == 1 ? num : "," + num;
    }
}

Console.WriteLine($"Чётные числа от 1 до { n }: { numberEven }");