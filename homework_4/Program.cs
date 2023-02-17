// TASK 25
/*Console.WriteLine("Hello, World!");
double pow(double A, int B) {
    double m = A;
    for (int i = 1; i <= B-1; i++) A = m*A;
    return A;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(pow(a, b));*/


// TASK 27
/*int summary(int number) {
    int sum = 0;
    int number_copy = number;
    while (number != 0) {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(summary(n));*/


// TASK 29
Console.Write("Введите количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа через пробел: ");
int[] numbers = Console.ReadLine()!.Split(' ').Select(x => int.Parse(x)).ToArray();
Console.Write("Введите Рост пети: ");
int number = Convert.ToInt32(Console.ReadLine());
int position = 1;
foreach (int i in numbers) {
    if (i >= number) position += 1;
    else break;
}
Console.WriteLine($"Позиция Пети дожна быть:{position}");