// 15. Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine();
Console.WriteLine("Write a number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("------------------");

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($"Namber {a} is multiple number 7 and 23.");
}
else
{
    Console.WriteLine($"Namber {a} is not multiple number 7 and 23.");
}
Console.WriteLine();
