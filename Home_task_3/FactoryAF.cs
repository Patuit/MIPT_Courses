namespace Home_task_3;

/// <summary>
/// Фабрика
/// </summary>
class FactoryAF
{
    public List<Car> cars = new List<Car>();
    public List<Customer> customers { get; set; }

    public FactoryAF(List<Customer> inputCustomer)
    {
        customers = inputCustomer;
    }

    /// <summary>
    /// Добавить машину на фабрику
    /// </summary>
    public void AddCar()
    {
        var rand = new Random();
        Car car = new Car(rand.Next(1000000, 9999999));
        cars.Add(car);
    }

    /// <summary>
    /// Раздать машины
    /// </summary>
    public void SaleCar()
    {
        foreach (Customer customer in customers)
        {
            if (cars.Count >= 1)
            {
                customer.Car = cars[0];
                cars.RemoveAt(0);
            }
            else
            {
                return;
            }
        }
        if (cars.Count > 0)
        {
            cars.Clear();
        }
    }
}