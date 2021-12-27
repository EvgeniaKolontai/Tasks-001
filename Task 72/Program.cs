// Написать программу возведения числа А в целую стень B
double NumGegree(double a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    if (b < 0)
    {
        return NumGegree (a, b + 1)/a;
    }
    return NumGegree(a, b - 1)*a;
}
Console.WriteLine(NumGegree(4, -3));