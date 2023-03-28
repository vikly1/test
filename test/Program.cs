// See https://aka.ms/new-console-template for more information
Console.WriteLine("Программа для вычисления среднего арифметического значения 5 чисел (Вводите любое число, привосходящее 0...)");
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите четвертое число: ");
double num4 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите пятое число: ");
double num5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Среднее арефметическое: ");
double res = (num1 + num2 + num3 + num4 + num5)/5;
Console.WriteLine($"{res}");