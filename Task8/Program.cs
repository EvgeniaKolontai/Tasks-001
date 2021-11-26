//Показать четные числа от 1 до N

Console.Clear(); 
Console.Write("our num is ");
int N = new Random().Next(1, 200);
Console.WriteLine(N);
int FirstNum = 1;
int NextNum = FirstNum + 1;

while (NextNum < N)
{
    if (NextNum %2 == 0)
    {
        Console.WriteLine(NextNum);
    
    }
   NextNum = NextNum + 2;  
}