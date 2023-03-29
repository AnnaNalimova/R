// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.


Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция  = {FunctionAck(n, m)}");

int FunctionAck(int start, int end)
{
    if (start == 0) return end + 1;
    if (end == 0) return FunctionAck(start - 1, 1);
    return FunctionAck(start - 1, FunctionAck(start, end - 1));
}
