// Найти сумму элементов от M до N, N и M заданы

void SumNum( int N, int M, int sum)
{
    if (M == N) 
    {
    sum = sum+M; Console.WriteLine(M); 
    Console.WriteLine($"Сумма чисел равна {sum}");return;
     }
    if (M < N) { sum = sum+M;Console.WriteLine(M); SumNum(N, M + 1 , sum); }
    else if (M > N) {sum = sum+M; Console.WriteLine(M); SumNum(N, M - 1, sum); }

}
SumNum(5, 8, 0);
