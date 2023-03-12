// See https://aka.ms/new-console-template for more information
// TASK 54
/*using System;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();

        void InputMatrix(int[,] matrix)
        {
            //int end = 10, begin = -10;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Convert.ToInt32(rnd.Next(-100, 100)); // [1, 20]
            }
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(string.Format("{0,5}", matrix[i, j]));
                Console.WriteLine();
            }
        }

        void option(int[,] matrix)
        {
            IComparer cmp = new compare();
            //int[] matrix_i = new int[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] matrix_i = new int[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                    //int[] matrix_i = new int[matrix.GetLength(1)];
                    matrix_i[j] = matrix[i, j];
                Array.Sort(matrix_i, cmp);
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(string.Format("{0,5}", matrix_i[j]));
                Console.WriteLine();
            }
            
        }

        Console.Write("Введите размер массива: ");
        int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
        int[,] matrix = new int[size[0], size[1]];
        InputMatrix(matrix);
        PrintMatrix(matrix);
        Console.WriteLine("Отсортированный массив: ");
        option(matrix);
    }
}

class compare : IComparer {
    public int Compare(Object? x, Object? y){
        return (new CaseInsensitiveComparer()).Compare(y, x);
    }
}*/


// TASK 56
/*Random rnd = new Random();
void InputMatrix(int[,] matrix)
{
    //int end = 10, begin = -10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Convert.ToInt32(rnd.Next(-100, 100)); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(string.Format("{0,5}", matrix[i, j]));
        Console.WriteLine();
    }
}

void option(int[,] matrix)
{
    int minsum = Int32.MaxValue, mini = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        if (sum < minsum) {minsum = sum; mini = i;}
    }
        Console.WriteLine($"Строка с наименьшей суммой элементов: {mini}");
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
option(matrix);*/

// TASK 60
/*Random rnd = new Random();
void InputMatrix(int[,,] matrix)
{
    //int end = 10, begin = -10;
    int origin = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int g = 0; g < matrix.GetLength(2); g++)
            matrix[i, j, g] = origin++; // [1, 20]
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int g = 0; g < matrix.GetLength(2); g++)
            Console.Write(string.Format($"{matrix[i, j, g]}({i}, {j}, {g}) "));
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}
Console.WriteLine("Enter mass size:");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);
Console.WriteLine("That's your mass:");
PrintMatrix(matrix);*/


// TASK 58
/*Random rnd = new Random();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Convert.ToInt32(rnd.Next(0, 100)); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(string.Format("{0,5}", matrix[i, j]));
        Console.WriteLine();
    }
}

int[,] Product(int[,] matirx_one, int[,] matrix_two)
{
    int[,] result = new int[matirx_one.GetLength(0), matirx_one.GetLength(1)];
    for (int i = 0; i < matirx_one.GetLength(0); i++)
    {
        for (int j = 0; j < matirx_one.GetLength(1); j++)
        result[i,j] = matirx_one[i, j] * matrix_two[i, j];
    }
    return result;
}

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] FirstMatrix = new int[size[0], size[1]];
int[,] SecondMatrix = new int[size[0], size[1]];
InputMatrix(FirstMatrix);
InputMatrix(SecondMatrix);
Console.WriteLine("Начальный массив 1: ");
PrintMatrix(FirstMatrix);
Console.WriteLine("Начальный массив 2: ");
PrintMatrix(SecondMatrix);
Console.WriteLine("Результат:");
PrintMatrix(Product(FirstMatrix, SecondMatrix));*/


// TASK 62
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,5}", array[i, j]));
        }
        Console.WriteLine();
    }
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
int num = 1, i = 0, j = 0;

while (num <= size * size)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    num++;
}
PrintArray(array);