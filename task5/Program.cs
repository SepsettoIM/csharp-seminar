// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе принимает все числа в промежутке от -4 до N
// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
int i = -number; 
string result = "";
// while (i <= number)
// {
//     Console.Write(i + " ");
//     i ++;
//     result += ", ";
// }
while (i <= number)
{
    result += i.ToString();
    
    if (i != number)
    {
        result += ", ";
    }

    i++;
}

Console.WriteLine(result);