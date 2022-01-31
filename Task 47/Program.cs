// Написать программу копирования массива
int [] firstarray = new int[10];
void Feelarray(int [] firstarray)
{
    Console.WriteLine("Исходный массив");
    for (int i = 0; i < firstarray.Length; i++)
    {
        firstarray[i] = new Random().Next(0,100);
    Console.Write(firstarray[i]+"; ");
    }
    Console.WriteLine();
}

void Copyarray(int [] secondarray)
{
    Console.WriteLine("Скопированный массив");
    for (int j = 0; j < secondarray.Length; j++)
    {
        secondarray[j] = firstarray[j];
    Console.Write(secondarray[j]+"; ");
    }
    Console.WriteLine();
}

Feelarray (firstarray);
//firstarray[5] = 1000;
Copyarray (firstarray);