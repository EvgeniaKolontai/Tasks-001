// Найти третью цифру числа или сообщить, что её нет
Console.Clear();

void Find3Num( string NumberA)
{
if (NumberA.Length >2)
{
    Console.WriteLine($"{NumberA[2]}");
}
else
{
    Console.WriteLine("Нет,nретьей цифры");
}
}
Console.Write("Enter number: ");
//string NumberA = Console.ReadLine();
Find3Num(Console.ReadLine());