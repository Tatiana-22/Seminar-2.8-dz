/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

var massive01 = Generate2DArray(2,2);
var massive02 = Generate2DArray(2,2);
Console.WriteLine("Исходный массив 1");
Print2DArray(massive01);
Console.WriteLine("Исходный массив 2");
Print2DArray(massive02);
Console.WriteLine("Произведение двух матриц");
Print2DArray(GenerateNewArray(massive01, massive02));


int[,] Generate2DArray(int m, int n)
{
    int [,] result = new int [m,n];

    for (int i=0; i<result.GetLength(0); i++)
    {
        for (int j=0; j<result.GetLength(1); j++)
        {
            result [i, j] = new Random().Next(1,100);
        }
    }
    return result;
}

void Print2DArray(int [,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
           Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateNewArray(int[,] massive01, int[,] massive02)
{
    int [,] result = new int [massive01.GetLength(0), massive02.GetLength(1)];

    for (int i=0; i<massive01.GetLength(0); i++)
    {
        for (int j=0; j<massive02.GetLength(1); j++)
        {
            for (int k = 0; k < massive01.GetLength(0); k++)
            {
                result[i,j]+= massive01[i,k] * massive02[k,j];
            }
        }
    }
    return result;
}