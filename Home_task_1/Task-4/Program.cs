Random rnd = new Random();
int countBoxInWarehouse = rnd.Next(1, 50);
int countBoxForCar;

do
{
    Console.WriteLine($"Количество коробок на складе: {countBoxInWarehouse}. Введите количество ящиков для погрузки в машину:");
    countBoxForCar = Convert.ToInt32(Console.ReadLine());
    countBoxInWarehouse -= countBoxForCar;
    if (countBoxInWarehouse < 0)
    {
        Console.WriteLine($"Такого количества коробок на складе нет. Можно выгрузить только {countBoxInWarehouse+countBoxForCar}.");
    }
} while (countBoxInWarehouse > 0);