// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.WriteLine("Введите номер чертверти: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1 || x >= 5) Console.WriteLine("Не верное значение четверти");
if (x == 1) Console.WriteLine(" x = от 0 до бесконечности, y = от 0 до бесконечности");
if (x == 2) Console.WriteLine(" x = от -0 до бесконечности, y = от 0до бесконечности");
if (x == 3) Console.WriteLine(" x = от -0 до бесконечности, y = от -0 до бесконечности");
if (x == 4) Console.WriteLine(" x = от 0 до бесконечности, y = от -0 до бесконечности");



    


