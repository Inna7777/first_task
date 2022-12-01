// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите  число ");
string nStr = Console.ReadLine() ??"";
int n = Convert.ToInt32(nStr);
n = Math.Abs(n);

for (int i = (1); i <= n; i++)
{  
    int nrem = i % 2;
    if (nrem == 0)
    {
        Console.Write(i+ " ");
    }
   
}
