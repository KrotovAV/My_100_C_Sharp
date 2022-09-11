// 3. По заданному номеру дня недели вывести его название

Console.WriteLine();

Console.WriteLine("Write a number from 1 to 7");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("-------");
if(a <1 || a > 7) 
{
    Console.WriteLine("!!! Number is not a number from 1 to 7 from 1 to 7"); 
    Console.WriteLine(""); 
    return;
}

string[] arr = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine($"The day is {arr[a-1]}.");

Console.WriteLine("");