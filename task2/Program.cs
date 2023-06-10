// Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
// из этих чисел.

Console.WriteLine("Введите число A:");
string A = Console.ReadLine()!;
int AInt = Convert.ToInt32(A);
Console.WriteLine("Введите число B:");
string B = Console.ReadLine()!;
int BInt = Convert.ToInt32(B);
Console.WriteLine("Введите число C:");
string C = Console.ReadLine()!;
int CInt = Convert.ToInt32(C);
if (AInt > BInt) {
    if (AInt > CInt)
    {
        Console.Write("Число A максимальное и оно равно ");
        Console.Write(AInt);
    }
    else {
        Console.Write("Число C максимальное и оно равно ");
        Console.Write(CInt);
    }
}
else {
    if (BInt > CInt)
    {
        Console.Write("Число B максимальное и оно равно ");
        Console.Write(BInt);
    }
    else {
        Console.Write("Число C максимальное и оно равно ");
        Console.Write(CInt);
    }
}