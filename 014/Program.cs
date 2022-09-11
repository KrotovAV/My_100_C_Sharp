// 14. Найти третью цифру числа или сообщить, что её нет


Console.WriteLine();
Console.WriteLine("Write a number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("------------------");

if(a < 99 ) 
{
    Console.WriteLine("Third-digit is not exist in namber."); 
    Console.WriteLine();
    return;
}

do
{
    a = a/10;
} while (a > 999);

Console.WriteLine(a % 10);

Console.WriteLine();