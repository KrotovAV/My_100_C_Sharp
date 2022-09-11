//  6. Выяснить является ли число чётным

Console.WriteLine();
Console.WriteLine("Write number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("------------------");
if(a % 2 == 0)
{
Console.WriteLine($"Number {a} is even.");
}
else
{
    Console.WriteLine($"Number {a} is odd.");
}
//Console.WriteLine(a % 2);
Console.WriteLine();