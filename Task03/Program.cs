// Напишите программу, которая на вход принимает число и
// выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
string nStr = Console.ReadLine() ??"";
int n = Convert.ToInt32(nStr);
int nrem = n % 2;
 if (nrem == 0)
 {
    Console.WriteLine (n+ " четное число");
 }
 else {
    Console.WriteLine (n+ " не является четным числом");
 }
