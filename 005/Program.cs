// 5. Написать программу вычисления значения функции y = f(a)

Console.WriteLine();

Console.WriteLine("Here is the function: y = a * x + b");
Console.WriteLine();
Console.WriteLine("Write number a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write number b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Write number x");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("------------------");
int y = a * x + b;
Console.WriteLine($"y = {y}");
Console.WriteLine();

