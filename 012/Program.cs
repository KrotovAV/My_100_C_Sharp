// 12. Удалить вторую цифру трёхзначного числа

Console.WriteLine();
Console.WriteLine("Write three-digit number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("------------------");

if(a > 999 || a < 99 ) 
{
    Console.WriteLine("Write namber is not a three-digit number"); 
    Console.WriteLine();
    return;
}

Console.WriteLine($"New two-digit namber is {(a / 100)*10 + a % 10}. "); 
//Console.WriteLine((a / 100)*10 + a % 10);
Console.WriteLine();
