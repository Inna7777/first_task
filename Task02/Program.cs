//Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число и нажмите Enter");
string aStr = Console.ReadLine() ??"";
int a = Convert.ToInt32(aStr);
Console.WriteLine("Введите второе число и нажмите Enter");
string bStr = Console.ReadLine() ??"";
int b = Convert.ToInt32(bStr);
Console.WriteLine("Введите третье число и нажмите Enter");
string cStr = Console.ReadLine() ??"";
int c = Convert.ToInt32(cStr); //Предлагаем ввод чисел

int max = a;
   if (a>max) max = a;
   if (b>max) max =b;
   if (c>max) max =c;
Console.WriteLine ("max="+max); //выводим результат

