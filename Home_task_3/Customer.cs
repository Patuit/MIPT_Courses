namespace Home_task_3;

/// <summary>
/// Покупатель
/// </summary>
class Customer
{
    /// <summary>
    /// ФИО покупателя
    /// </summary>
    public string Fio { get; }

    /// <summary>
    /// Купленная машина
    /// </summary>
    public Car? Car { get; set; }

    public Customer(string fio)
    {
        this.Fio = fio;
    }

    public string GetSNCar() {
        return Car is null ? "" : Convert.ToString(Car.SerialNumber);
    }
}