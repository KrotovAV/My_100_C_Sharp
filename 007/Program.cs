//  7. Показать числа от -N до N

Console.WriteLine();
Console.WriteLine("Write number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");
for (int i = - a; i < a +1; i++)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();
Console.WriteLine();