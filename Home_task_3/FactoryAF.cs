namespace Home_task_3;

class FactoryAF
{
    public List<Car> cars = new List<Car>();
    List<Customer> customers;

    public FactoryAF(List<Customer> inputCustomer)
    {
        customers = inputCustomer;
    }

    public void AddCar()
    {
        var rand = new Random();
        Car car = new Car(rand.Next(1000000, 9999999));
        cars.Add(car);
    }
    public void SaleCar()
    {

    }
}