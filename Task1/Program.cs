
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
int result1= numberA * numberA;
Console.WriteLine(result1);

int numberB = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberB);
int result2= numberB * numberB;
Console.WriteLine(result2);

if (result1 == result2)
{
    Console.WriteLine("Квадрат числа");
}

else
{
  Console.WriteLine("НеВерно");  
}


