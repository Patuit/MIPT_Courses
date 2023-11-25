Console.WriteLine();
Console.WriteLine("===================================================================");
Console.WriteLine("===         Расчёт периметра и площади прямоугольника           ===");
Console.WriteLine("===================================================================");
Console.WriteLine();

double? inputLength;
double? inputWidth;

Console.Write("Введите длинну прямоугольника: ");
inputLength = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите ширину прямоугольника: ");
inputWidth = Convert.ToDouble(Console.ReadLine());

if (inputWidth == 0 || inputLength == 0)
{
    Console.WriteLine();
    Console.WriteLine("===================================================================");
    Console.WriteLine("===                             УПС!                            ===");
    Console.WriteLine("=== Одно из значений равно нулю, расчёт не может быть выполнен. ===");
    Console.WriteLine("===================================================================");
    Console.WriteLine();
    return;
}

Console.WriteLine();
Console.WriteLine($"Периметр прямоугольника: {(inputWidth + inputLength) * 2}");
Console.WriteLine($"Площадь прямоугольника: {inputWidth * inputLength}");
Console.WriteLine();
