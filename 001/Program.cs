// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("");

Console.WriteLine("Write namber a");
double a = int.Parse(Console.ReadLine());

Console.WriteLine("Write power namber");
double b = int.Parse(Console.ReadLine());

Console.WriteLine("-------");

if(b*b ==a)
{
    Console.WriteLine("Namber a is a power b");
}
else
{
    Console.WriteLine("Namber a is not a power b");
}
Console.WriteLine("");
