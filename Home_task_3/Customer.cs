namespace Home_task_3;

class Customer
{
    public string Fio { get; }

    Car car;

    public Customer(string fio, Car someCar)
    {
        this.car = someCar;
        this.Fio = fio;
    }
}