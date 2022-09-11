// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


Console.WriteLine();
Console.WriteLine("Write two-digit number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("------------------");

if(a > 99 || a < 9 ) 
{
    Console.WriteLine($"Namber {a} is not a two-digit number"); 
    Console.WriteLine();
    return;
}

Console.Write("Bigest namber is "); 

if((a % 100- a % 10)/10>a % 10)
{
    Console.WriteLine((a % 100- a % 10)/10);
}
else{
    Console.WriteLine(a % 10);
}
//int b = (a % 100- a % 10)/10;
//int c = a % 10;


//Console.WriteLine(b);
//Console.WriteLine(c);
Console.WriteLine();