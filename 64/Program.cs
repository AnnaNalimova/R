//  Задайте значение N. Напишите программу ,
//которая выведет все натуральные числа в промежутке от N до 1 

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(GetNumbers(m, n));

string GetNumbers(int start, int end)
{
    if (end == start) 
    return end.ToString();
    return (end + " , " + GetNumbers(start, end - 1));
}
