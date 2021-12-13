// Определить сколько чисел больше 0 введено с клавиатуры
Console.Clear();
int count = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write($"Enter number {i+1}: ");
    if (Convert.ToInt32(Console.ReadLine()) > 0)
    {
        count++;
    }
}
Console.WriteLine($"{count} numbers greater than 0");
    
