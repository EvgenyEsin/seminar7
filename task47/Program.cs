// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

string FillArray (int m, int n)
// метод для создания массива m на n
{
decimal [,] array = new decimal [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        decimal num = new Random().Next(-90, 100);
        array [i,j] = num/10;// заполняем массив, как в примере (1 знак после запятой)
        // Если надо 2 знака после запятой. то добавляем везде 0:
        // decimal num = new Random().Next(-900, 1000);
        // array [i,j] = num/100;
        Console.Write(array[i,j] + " ");
    }
Console.WriteLine("");
}
return "";
}

Console.WriteLine("Ведите количество строк в массиве: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
FillArray (line, column); // Вызываем метод для создания массива