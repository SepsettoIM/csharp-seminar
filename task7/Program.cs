// Задача №7. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 453 -> 3

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int result = number % 10;

if (99 < number && number < 1000)
    Console.Write(result);
else{
    Console.Write("Число неверно");
}
