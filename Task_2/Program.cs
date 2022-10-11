// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
Console.WriteLine("Введите позиции элемента в массиве через пробел (например: 2 6): ");
string line = Console.ReadLine();
string[] element = line.Split(' ');
int m = Convert.ToInt32(element[0]);
int n = Convert.ToInt32(element[1]);

int find = matrix[m, n];
bool Contains(int[,] array, int find)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (matrix[i, j] == find) return true;
        }
    }
    return false;
}
var result = Contains(matrix, find);
if (result == false) Console.WriteLine ("Такого числа в массиве нет");
else Console.WriteLine (matrix[m,n]);
