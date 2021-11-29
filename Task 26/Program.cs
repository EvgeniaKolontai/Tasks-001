// Возведите число А в натуральную степень B используя цикл

Console.Clear();
Console.WriteLine("Enter num ");
double A = double.Parse(Console.ReadLine());
int B = new Random().Next(1, 25);
double result = 1;

for (int i = 0; i < B; i++)
{
    result =  result * A ;
    
}
    Console.WriteLine(B);
    Console.WriteLine(result);