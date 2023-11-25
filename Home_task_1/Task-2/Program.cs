double insertLength;
double sumSequence = 0;

Console.WriteLine();
Console.WriteLine("Расчёт суммы ряда чисел от 1 до n.");
Console.WriteLine();
Console.WriteLine("Введите значение n:");

insertLength = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i <= insertLength; i++)
{
    sumSequence += i;
}
Console.WriteLine();
Console.WriteLine($"Сумма ряда чисел от 1 до {insertLength} равна {sumSequence}");
Console.WriteLine();