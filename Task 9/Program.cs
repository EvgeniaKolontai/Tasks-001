//Показать последнюю цифру трёхзначного числа

Console.Clear(); 
int N = new Random ().Next(100,999);
Console.WriteLine(N);
Console.WriteLine(N %10);
