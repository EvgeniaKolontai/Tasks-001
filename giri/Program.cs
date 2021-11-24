int []array = { 1, 2, 4, 6, 12, 16, 17, 20, 22, 24};

int n = array.Length;
int find = 22;

int index = 0;

while(index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
    }
     index++;  
}