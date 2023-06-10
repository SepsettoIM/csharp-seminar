// Напишите программу, которая на вход принимает число и выдает его квадрат

// Например:
// 4 -> 16
// -3 -> 9
// -7 - > 49

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = number*number;
Console.WriteLine("Квадрат числа равен = " + result);