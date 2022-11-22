/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] matrix = new int[rows, colums];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);
        }    
    }
}

int[,] matr = new int[rows, colums];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

for (int j = 0; j < matr.GetLength(1); j++)
{
    double sa = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sa += matrix[i, j];
    }
    Console.Write($"[{sa / matr.GetLength(0)}] ");
} 

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}