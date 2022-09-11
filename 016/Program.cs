// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

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

if(a > 5)
{
    Console.WriteLine("The day is day off."); 
}
else
{
    Console.WriteLine("The day is working day."); 
}

Console.WriteLine("");