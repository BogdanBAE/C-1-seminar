Console.Clear();
Console.Write("Введите число: ");
int N = Math.Abs(int.Parse(Console.ReadLine()));

if (N<100|| N> 999) {
    Console.Write("Введено не трехзначное число");
    return;
}

int division = N % 10;
Console.WriteLine($"{division} последняя цифра числа {N}");