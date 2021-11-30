// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("Enter num ");
int A = int.Parse(Console.ReadLine());
int P = 1;
for (int i = 1; i <= A ; i++)
{
  P = i * P;
  Console.Write($"{i}*");
}

Console.WriteLine($"={P}");