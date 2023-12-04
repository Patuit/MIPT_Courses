namespace Home_task_3;

/// <summary>
/// Двигатель автомобиля
/// </summary>
class Engine
{
    /// <summary>
    /// Размер педалей
    /// </summary>
    public int PedalSize { get; }

    public Engine(int pedalSize)
    {
        PedalSize = pedalSize;
    }
}