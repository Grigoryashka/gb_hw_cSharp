// TASK 19
/*Console.Write("Введите 5-изначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (10000>number | number>99999) {
    Console.Write("Это не 5-изначное число, ведите 5-изначное: ");
    number = Convert.ToInt32(Console.ReadLine());
    }
if (number / 10000 == number % 10 & number / 1000 % 10 == number / 10 % 10) 
Console.Write("Это число палиндром");
else Console.Write("Это число НЕ палиндром");*/


// TASK 21
/*Console.WriteLine("Введите координаты первой точки (x, y, z): ");
int[] A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Введите координаты второй точки (x, y, z): ");
int[] B = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
double dist = Math.Sqrt(Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2) + Math.Pow((A[2] - B[2]), 2));
Console.Write($"Расстояние между двумя точками: {dist}");*/


//TASK 23
/*Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Кубы всех чисел от 1 до {number}: ");
for (int i = 1; i <= number; i++) {
    if (i != number) Console.Write($"{Math.Pow(i, 3)}, ");
    else Console.Write($"{Math.Pow(i, 3)}");
}*/


// EXTRA TASK
Console.Write("Введите количество кустов: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество ягод на каждом кусте через пробел: ");
int[] berries = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
int sum = berries[0]+berries[1]+berries[2];
for (int i = 1; i <= count - 3; i++) {
if (berries[i]+berries[i+1]+berries[i+2] > sum) sum = berries[i]+berries[i+1]+berries[i+2];
}
Console.WriteLine(sum);
