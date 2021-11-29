// Найти сумму чисел от 1 до А
Console.Clear();
Console.WriteLine("Enter num ");
int A = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= A ; i++)
{
  sum = i + sum;
  Console.Write($"{i}+");
}

Console.WriteLine($"={sum}");
