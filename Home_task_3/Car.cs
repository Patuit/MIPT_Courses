namespace Home_task_3;

/// <summary>
/// Автомобиль
/// </summary>
class Car
{
    /// <summary>
    /// Серийный номер автомобиля
    /// </summary>
    public int SerialNumber { get; }

    /// <summary>
    /// Покупатель
    /// </summary>
    public Engine engine { get; }

    public Car(int serialNumber)
    {
        var rand = new Random();
        this.SerialNumber = serialNumber;
        this.engine = new Engine(rand.Next(1, 20));
    }
}