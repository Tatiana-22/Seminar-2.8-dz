/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

var massive = Generate2DArray(4,4);
Console.WriteLine("Исходный массив");
Print2DArray(massive);
int minrow = SumMinLine(massive);
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + minrow);


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

int SumMinLine (int[,]arr)
{
   int minRow=0;
   for (int i=0; i<arr.GetLength(0); i++)
   {
        int sum=0;
        int minSum=1000;
        
        for (int j=0; j<arr.GetLength(1); j++)
        {
           sum = sum + arr[i,j];
        }

        if(sum < minSum)
        {
            minSum = sum;
            minRow = i+1;
        }
   }
    return minRow;
}


