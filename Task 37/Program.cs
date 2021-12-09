// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();

int[] array = new int[123];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
      {
          array[i] = rnd.Next(0, 20);
          Console.Write($" {array[i]} ");
      } 
      //for (int i = 0; i < array.Length; i++)
      //{
        //  array[i] = i+1;
        //  Console.Write($" {array[i]} ");
     // }

int count =0; 
for (int index = 0; index < array.Length; index++)
{
    if (array[index] >= 10 && array[index] <= 99)
    {
        count = count + 1;
    }
}
Console.WriteLine($"\n Количество элементов внутри отрезка от 10 до 99: {count}");
