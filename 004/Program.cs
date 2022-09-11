//  4. Найти максимальное из трех чисел

Console.WriteLine();

Console.WriteLine("Write first number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write second number");
int b = int.Parse(Console.ReadLine());


Console.WriteLine("Write third number");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("-----------------");

if(a > b && a > c) Console.WriteLine($"Number {a} is the biggest");
if(b > a && b > c) Console.WriteLine($"Number {b} is the biggest");
if(c > a && c > b) Console.WriteLine($"Number {c} is the biggest");
Console.WriteLine("");
