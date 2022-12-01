//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
string aStr = Console.ReadLine() ??"";
int a = Convert.ToInt32(aStr);
Console.WriteLine("Введите второе число" );
string bStr = Console.ReadLine() ??"";
int b = Convert.ToInt32(bStr);
int max = a;
    if (b == max)
   {
    Console.WriteLine($"Числа равны {bStr}={aStr}");
   }
    else
   {
    if (b > max)
  { max = b;
  Console.WriteLine($"большее число: {bStr}, меньшее число : {aStr}" );
     }
     else
   {
    Console.WriteLine($"большее число: {aStr}, меньшее число : {bStr}");
   }
   }

