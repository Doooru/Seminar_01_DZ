﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число 
// чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
string? A = Console.ReadLine()!;
int AInt = Convert.ToInt32(A);
if (AInt % 2 == 0) {
Console.Write("Число A чётное!");
}
else {
    Console.Write("Число A нечётное!");
}