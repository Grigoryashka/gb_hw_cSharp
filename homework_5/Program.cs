// TASK 34
Console.WriteLine("Hello, World!");
/*void InputMatrix(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        matrix[i] = new Random().Next(100, 1000); // [1, 20]
}

void PrintMatrix(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) {
        Console.Write($"{matrix[i]} ");
    }
    Console.WriteLine();
}

int count(int[] matrix) 
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) {
            if (matrix[i] % 2 == 0) k += 1;
    }
    return k;
}
//int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.Write("Введите длину массива: ");
int[] matrix = new int[Convert.ToInt32(Console.ReadLine())];
InputMatrix(matrix);
Console.WriteLine("Полученный массив: ");
PrintMatrix(matrix);
Console.Write($"Количество четных элементов массива: {count(matrix)}");*/


// TASK 36
/*void InputMatrix(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        matrix[i] = new Random().Next(-1000, 1001); // [1, 20]
}

void PrintMatrix(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) {
        Console.Write($"{matrix[i]} ");
    }
    Console.WriteLine();
}

int summary(int[] matrix) 
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) {
            if (i % 2 == 1) sum += matrix[i];
    }
    return sum;
}
//int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.Write("Введите длину массива: ");
int[] matrix = new int[Convert.ToInt32(Console.ReadLine())];
InputMatrix(matrix);
Console.Write("Полученный массив: ");
PrintMatrix(matrix);
Console.Write($"Сумма элементов на нечетных позициях массива: {summary(matrix)}");*/


// TASK 38
/*void InputMatrix(double[] matrix)
{
    int end = 1001, begin = -1000;
    for (int i = 0; i < matrix.GetLength(0); i++)
        matrix[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2); // [1, 20]
}

void PrintMatrix(double[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) {
        Console.Write($"{matrix[i]} ");
    }
    Console.WriteLine();
}

double diff(double[] matrix) 
{
    double dif = 0;
    double min = matrix[0];
    double max = matrix[0];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        if (matrix[i] > max) max = matrix[i];
        else if (matrix[i] < min) min = matrix[i];
    }
    dif = max - min;
    return dif;
}
//int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.Write("Введите длину массива: ");
double[] matrix = new double[Convert.ToInt32(Console.ReadLine())];
InputMatrix(matrix);
Console.Write("Полученный массив: ");
PrintMatrix(matrix);
Console.Write($"Разница между крайними массива: {diff(matrix)}");*/


// TASK EXTRA
Console.Write("Введите количество оценок Василя: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите дни месяца, в которые Василь получал оценки: ");
int[] marks = Console.ReadLine()!.Split(' ').Select(x => int.Parse(x)).ToArray();
int[] odd_marks = Array.FindAll(marks, mark => mark % 2 == 1);
int[] even_marks = Array.FindAll(marks, mark => mark % 2 == 0);
for (int i = 0; i < odd_marks.GetLength(0); i++)
    Console.Write($"{odd_marks[i]} ");
Console.WriteLine();
for (int i = 0; i < even_marks.GetLength(0); i++)
    Console.Write($"{even_marks[i]} ");
Console.WriteLine();
if (even_marks.GetLength(0) >= odd_marks.GetLength(0)) Console.WriteLine("YES");
else Console.WriteLine("NO");
