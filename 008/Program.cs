// 8. Показать четные числа от 1 до N

Console.WriteLine();
Console.WriteLine("Write number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");

for (int i = 2; i < a + 1; i+=2)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();
Console.WriteLine();