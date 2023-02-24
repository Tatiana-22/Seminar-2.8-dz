/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int colCount = 4;
int rowCount = 3;
var massive = Generate2DArray(rowCount, colCount);
Console.WriteLine("Исходный массив");
Print2DArray(massive);
Console.WriteLine();
Console.WriteLine("Сортировка по строкам по убыванию");
int[] row = new int[colCount];
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)
    {
        row[j] = massive[i, j];
    }
        
    Sort(row);
    Insert(i, row, massive);
}
Print2DArray(massive);

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

void Insert(int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        dest[dim, k] = source[k];
    }
}
             
void Sort(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }           
}          
                
