// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

void CreatArray (int [,] array) // метод для создания и вывода массива
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

Console.WriteLine("Ведите индекс строки в массиве (от 0 до 2): ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите индекс столбца в массиве (от 0 до 3): ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [3,4];
CreatArray(array);

string CheckArray (int line, int column) // метод для проверки массива
{
if (line < array.GetLength(0) && column < array.GetLength(1)) return ($"{array [line, column]}");
else return "такого числа в массиве нет";
}
Console.WriteLine($"{line} {column} -> {CheckArray(line, column)}");