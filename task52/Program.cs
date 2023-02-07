// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void CreatArray (int [,] array)// метод для создания и вывода массива
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i,j] = new Random().Next(1,10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
}

int [,] array = new int [3,4];
CreatArray(array);

double [] middle = new double [4]; //массив для хранения среднего ар. 

for (int i = 0; i < 4; i++) // цикл для подсчета среднего ар.
{
    double sum = 0;
    for (int j = 0; j < 3; j++)
    {
        sum = sum + array [j,i];
    }
    middle [i] = Math.Round((sum/3), 1);
}

Console.Write($"Среднее арифметическое каждого столбца: ");
for (int i = 0; i < 4; i++) // вывод среднего ар. в консоль
{
    Console.Write($"{middle [i]} ");
}
