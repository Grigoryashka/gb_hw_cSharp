// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// TASK 47
/*Random rnd = new Random();
void InputMatrix(double[,] matrix)
{
    //int end = 10, begin = -10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0); // [1, 20]
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(String.Format("{0,5}", matrix[i, j]));
        Console.WriteLine();
    }
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);*/


// TASK 50
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
            Console.Write(String.Format("{0,3}", matrix[i, j]));
        Console.WriteLine();
    }
}

void Option(int[] coord, int[,] matrix)
{
    if (coord[0] < matrix.GetLength(0) && coord[1] < matrix.GetLength(1))
        Console.WriteLine($"На данной позиции элемент {matrix[coord[0], coord[1]]}");
    else Console.WriteLine("Такой позиции в массиве нет");
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.Write("Введите номер позиции массива: ");
int[] coord = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Option(coord, matrix);*/


// TASK 52
/*Random rnd = new Random();
void InputMatrix(int[,] matrix)
{
    //int end = 10, begin = -10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Convert.ToInt32(rnd.Next(0, 11)); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(String.Format("{0,4}", matrix[i, j]));
        Console.WriteLine();
    }
}

void middle(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) sum += matrix[i, j];
        double mid = sum / matrix.GetLength(0);
        Console.Write(String.Format("{0,4}", Math.Round(mid, 1)));
    }
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Среднее арифмитическое число для каждого столбца соответственно:");
middle(matrix);*/

// транпонирование
Random rnd = new Random();
void InputMatrix(int[,] matrix)
{
    //int end = 10, begin = -10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Convert.ToInt32(rnd.Next(0, 11)); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(String.Format("{0,4}", matrix[i, j]));
        Console.WriteLine();
    }
}

void option(int[,] matrix)
{
    for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(String.Format("{0,4}", matrix[i, j]));
        Console.WriteLine();
    }
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Перевернутый по горизонтали массив:");
option(matrix);