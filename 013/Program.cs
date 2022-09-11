// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine();
Console.WriteLine("Write a number a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Write a number b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("------------------");

if (a % b == 0)
{
    Console.WriteLine($"Namber {a} is multiple number {b}.");
}
else
{
    Console.WriteLine($"Namber {a} is not multiple number {b}.");
    Console.WriteLine($"Remainder of the division {a} by {b} is {a % b}.");
}
Console.WriteLine();