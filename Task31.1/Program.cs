// Задать массив из 8 элементов и вывести их на экран
void Array( int min, int max)

{
    int[] array = new int[8];//объявление пустого массива с длинной k

    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(min, max);
        Console.Write($"A[{i}]={array[i]}; ");
    }
}
// Console.Write("Введите длину массива: ");
//int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона: ");
int max = Convert.ToInt32(Console.ReadLine()); 
Array( min, max);


