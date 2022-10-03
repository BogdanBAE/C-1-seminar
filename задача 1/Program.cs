Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write(" ВВедите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber == Convert.ToInt32(Math.Pow(secondNumber, 2)))
{
    Console.Write($"Первое число {firstNumber} является квадратом второго числа {secondNumber}");
} 
else
{
    Console.Write($"Первое число {firstNumber} НЕ является квадратом второго числа {secondNumber}");
}