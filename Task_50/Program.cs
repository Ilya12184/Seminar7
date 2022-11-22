/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.*/

int[,] matrix = new int[4, 4];
int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
Console.WriteLine();

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
            matr[i,j] = new Random().Next(-10, 11);
        }    
    }
}

int[,] matr = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);

if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1))
{ 
    Console.WriteLine(matrix[rows, colums]);
}
else 
{
    Console.WriteLine($"{rows} {colums} индекс вышел за пределы массива!");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}