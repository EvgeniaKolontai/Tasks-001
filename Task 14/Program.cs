// Найти третью цифру числа или сообщить, что её нет
Console.Clear();

void Find3Num(int NumberA)

{string NumberB = NumberA.ToString();
    
    if (NumberB.Length > 2)
    {
       
        Console.WriteLine($"{NumberB[2]}");
    }
    else
    {
        Console.WriteLine("Нет,третьей цифры");
    }
}
Console.Write("Enter number: ");

Find3Num(Convert.ToInt32(Console.ReadLine()));
