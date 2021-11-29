// Возведите число А в натуральную степень B используя цикл

Console.Clear();
Console.WriteLine("Enter num ");
int A = int.Parse(Console.ReadLine());
int B = new Random ().Next(2, 5);
int result = 1;


for (int i = 0; i < B; i++)
{
    result =  result * A ;
    
}
    Console.WriteLine(B);
    Console.WriteLine(result);
  

