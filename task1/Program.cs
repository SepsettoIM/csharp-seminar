// Задача №1. Напиште программу, которая не вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет

// Задача №3. Напиште программу, которая будет выдавать назание дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница

Console.WriteLine("Введите два числа: ");
int number = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

if (number2 == number*number)   
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");
    
    