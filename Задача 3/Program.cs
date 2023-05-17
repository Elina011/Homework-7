// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] resultArray = new double[n];

for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += matrix[i, j];
    }
    resultArray[j] = sum / m;
}

Console.WriteLine($"{String.Join("; ", resultArray)}");


