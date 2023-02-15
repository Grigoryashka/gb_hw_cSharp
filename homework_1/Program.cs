// TASK 2
/*Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.WriteLine($"Минимальное число: {b}, максимальное число: {a}");
else Console.WriteLine($"Минимальное число: {a}, максимальное число: {b}");*/

// TASK 4
/*Console.Write("Введите число A: ");
int a4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int c4 = Convert.ToInt32(Console.ReadLine());
if (a4 >= b4 & a4 >= c4) Console.WriteLine($"Максимальное число: {a4}");
else if (b4 >= a4 & b4 >= c4) Console.WriteLine($"Максимальное число: {b4}");
else if (c4 >= a4 & c4 >= b4) Console.WriteLine($"Максимальное число: {c4}");*/

// TASK 6
/*Console.Write("Введите число: ");
int a6 = Convert.ToInt32(Console.ReadLine());
if (a6 % 2 == 0) Console.WriteLine($"Yes");
else Console.WriteLine("No");*/


// TASK 8
Console.Write("Введите конечное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все четные числа от 1 до n:");
for (int i = 2; i<=n; i=i+2) Console.WriteLine(i);
