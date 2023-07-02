/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();

Console.WriteLine("Введите размер двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(m,n);
PrintArray(array);
double[] meanArith = ArithmeticMeanColumn(array);
PrintMeanArithArray(meanArith);

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintMeanArithArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {        
        Console.Write($"{array[i]:f2}; ");
    }
}

double[] ArithmeticMeanColumn(int [,] array)
{
    
    double[] arithMean = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arithMean[j] += array[i,j];
            count++;
        }
        arithMean[j]/=count;
    }
    return arithMean;
}
