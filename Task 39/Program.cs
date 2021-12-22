// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();

int[] array = new int[8];

Console.Write("Массив");
for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(2,20);
    Console.Write(" " + array[i]+ " ");
}

Console.WriteLine($"\n{array[0]}*{array[7]} = {array[0]*array[7]}");
Console.WriteLine($"{array[1]}*{array[6]} = {array[1]*array[6]}");
Console.WriteLine($"{array[2]}*{array[5]} = {array[2]*array[5]}");
Console.WriteLine($"{array[3]}*{array[4]} = {array[3]*array[4]}");