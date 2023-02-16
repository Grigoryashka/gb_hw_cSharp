// TASK 10
/*Console.Write("Введите 3-ехзначное число: ");
int original_number = Convert.ToInt32(Console.ReadLine());
int abs_number = Math.Abs(original_number);
while (100>abs_number | abs_number>999) {
    Console.Write("Это не 3-ехзначное число, ведите 3-ехзначное: ");
    original_number = Convert.ToInt32(Console.ReadLine());
    abs_number = Math.Abs(original_number);
    }
Console.Write($"Вторая цифра числа {original_number}: {abs_number / 10 % 10}");*/


// TASK 13
/*Console.Write("Введите целое число: ");
int original_number = Convert.ToInt32(Console.ReadLine());
int abs_number = Math.Abs(a);
if (abs_number<100) Console.Write("Ваше число содержит меньше 3 цифр");
else {
    while (abs_number>999) abs_number = abs_number / 10;
    Console.Write($"Третья цифра вашего числа: {abs_number % 10}");
}*/


// TASK 15
/*Console.Write("Введите номер дня недели (от 1 до 7 включительно): ");
int day = Convert.ToInt32(Console.ReadLine());
if (1 <= day & day <= 7) {
    switch(day) {
        case 6:
        Console.WriteLine("Да, выходной день");
        break;
        case 7:
        Console.WriteLine("Да, выходной день");
        break;
        default:
        Console.WriteLine("Нет, будний день");
        break;
    }
}
else Console.WriteLine("Не соответствует порядковому номеру какого-либо дня недели");*/


// EXTRA TASK
Console.WriteLine("Введите набор целых чисел, закончите нулем(0): ");
int number = Convert.ToInt32(Console.ReadLine());
int max_1 = number;
int max_2 = 0;
while (number != 0) {
number = Convert.ToInt32(Console.ReadLine());
if (number > max_1) {max_2 = max_1;
    max_1 = number;
    }
else if (number < max_1 & number > max_2) max_2 = number;
}
Console.WriteLine($"Второе по величине число: {max_2}");
