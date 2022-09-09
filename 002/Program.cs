//  2. Даны два числа. Показать большее и меньшее число

Console.WriteLine("");

Console.WriteLine("Write namber a");
double a = int.Parse(Console.ReadLine());

Console.WriteLine("Write namber b");
double b = int.Parse(Console.ReadLine());

Console.WriteLine("-------");

if(a < b)
{
    Console.WriteLine($"Namber a ({a}) is min, namber b ({b}) is max");
}
else
{
    Console.WriteLine($"Namber a ({a}) is max, namber b ({b}) is min");
}
Console.WriteLine("");
