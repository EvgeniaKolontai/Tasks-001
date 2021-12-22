// В Указанном массиве вещественных чисел найдите
// разницу между максимальным и минимальным элементом

Console.Clear();
int [] array =new int [10];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(2, 40);
    Console.Write(" "+ array[i] + " ");
}
Console.WriteLine();


int min = array[0];
int max = 0;
for (int k = 0; k < (array.Length); k++)
{
    if (array[k]>max) max = array[k];
    if (array[k]< min) min = array [k];
}
Console.WriteLine($"Разница элементов {max} - {min} = {max-min}");