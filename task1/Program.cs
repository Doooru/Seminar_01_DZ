﻿// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите число A:");
string? A = Console.ReadLine()!;
int AInt = Convert.ToInt32(A);
Console.WriteLine("Введите число B:");
string? B = Console.ReadLine()!;
int BInt = Convert.ToInt32(B);
if (AInt > BInt) {
    Console.WriteLine("Число А большее числа B");
    Console.WriteLine("Число B меньшее числа A");
}
else {
    Console.WriteLine("Число B большее числа A");
    Console.WriteLine("Число A меньшее числа B");
}