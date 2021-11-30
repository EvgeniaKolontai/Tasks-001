//Дано число. Проверить кратно ли оно 7 и 23
Console.Clear(); 
Console.WriteLine("Enter number ");
int number = int.Parse(Console.ReadLine());

    if (number %7 == 0 || number%23 ==0)
{
    Console.WriteLine("Делится на 7,23");
}
else
    {
        Console.WriteLine("Не кратно 7 и 23");
    }

