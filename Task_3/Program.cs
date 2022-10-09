// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
double average1 = (matrix[0, 0] + matrix[1, 0] + matrix[2, 0]) / 3.0;
double average2 = (matrix[0, 1] + matrix[1, 1] + matrix[2, 1]) / 3.0;
double average3 = (matrix[0, 2] + matrix[1, 2] + matrix[2, 2]) / 3.0;
double average4 = (matrix[0, 3] + matrix[1, 3] + matrix[2, 3]) / 3.0;

Console.Write("Среднее арифметическое каждого столбца: ");
Console.WriteLine($"{Math.Round(average1, 2)}, {Math.Round(average2, 2)},{Math.Round(average3, 2)}, {Math.Round(average4, 2)}");
