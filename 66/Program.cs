// задайте значения M и N .
//Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N .

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Cумма чисел = {Sum(m, n)}");

int Sum(int start, int end)
{
    if (start == end) return start;
    return (start + Sum(start + 1, end));
}