// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.WriteLine("Enter num A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter num B");
int B = int.Parse(Console.ReadLine());

if (A / B == B)
{
    Console.WriteLine(" Первое число квадрат второго");
}
else
{
    Console.WriteLine("Не квадрат");
}