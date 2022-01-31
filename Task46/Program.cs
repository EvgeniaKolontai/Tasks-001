// 46. Написать программу масштабирования фигуры
// Console.Write($"({X[IndexX]*k},");
string s = (Console.ReadLine());
// if ()
// Console.Write($"({X[IndexX]*k},");
double k = 2;
char[] separators = new char[] { ' ', ',', '(', ')' };
string[] Nums = (s.Split(separators, StringSplitOptions.RemoveEmptyEntries));

int[] X = new int[(Nums.Length)/2];
int[] Y = new int[(Nums.Length)/2];
  int Index = 0;
for (int i = Nums.Length - 1; i >= 0; i--)
{
    if (i%2==0)
    {
        X[Index] = (Convert.ToInt32(Nums[i]));
    
        Console.Write($"({X[Index]*k},");
    
    }
    else 
    {
        Y[Index] = (Convert.ToInt32(Nums[i]));
        
        Console.Write($" {Y[Index]*k}) ");
        Index++;
        
    }

}
