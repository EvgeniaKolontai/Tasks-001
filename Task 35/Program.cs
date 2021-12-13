// Определить, присутствует ли в заданном массиве, некоторое число
Console.Clear();
Console.Write("Введите размер массивa length = ");
int length = int.Parse(Console.ReadLine());
int[] array = new int [length];
 for (int i = 0; i < length; i++)
 {
     array[i] = new Random().Next(1, 10);
     Console.Write($" {array[i]} ");

 }
 Console.WriteLine();
 Console.WriteLine("Введите число: ");
 int a = int.Parse(Console.ReadLine());
 bool b = true;
 for (int i = 0; i < length; i++)
 {
     if(a == array[i]) 
    {
        b = false;
        Console.WriteLine("Число присутствует");
        break;  

    }
 }

if (b)
{
    Console.WriteLine("Число не присутствет");
}