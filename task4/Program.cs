// Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
string? A = Console.ReadLine()!;
int AInt = Convert.ToInt32(A);

for (int i = 2; i < AInt+1; i=i+2) 
{
    Console.Write(i);
    Console.Write(" ");
}

