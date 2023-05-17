// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет

void PrintMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixMAndN(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++ )
    {
        for(int j = 0; j < colums; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int m = 3;
int n = 4;

int[,] matrix = GetMatrixMAndN(m,n);

PrintMatrix(matrix);

int n1 = EnterData("Введение число:");
int n2 = EnterData("Введение число:");

if (n1 >= n || n2 >= m)
{
    Console.WriteLine("Числа нет");
}
else
{
    Console.WriteLine(matrix[n2, n1]);
}

