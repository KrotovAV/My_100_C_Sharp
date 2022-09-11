// 9. Показать последнюю цифру трёхзначного числа

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

Console.WriteLine(a % 10);
Console.WriteLine();
